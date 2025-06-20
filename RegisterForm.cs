using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace HMS
{
    public partial class RegisterForm : Form
    {
        SqlConnection Conn1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Hspital.mdf;Integrated Security=True;");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Register_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_signin_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();

        }

        private void Register_Showpass2_CheckedChanged(object sender, EventArgs e)
        {
            txtRegister_Pass.PasswordChar = Register_Showpass2.Checked ? '\0' : '*';
            textRegister_cPass.PasswordChar = Register_Showpass2.Checked ? '\0' : '*';
        }
        public bool emptyFields()
        {
            if (txtRegister_Uname.Text == "" || txtRegister_Pass.Text == "" || textRegister_cPass.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {

                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (Conn1.State == ConnectionState.Closed)
                {

                    try
                    {
                        Conn1.Open();
                        string query1 = "SELECT * FROM Users WHERE Username = @usern";
                        SqlCommand cmd = new SqlCommand(query1, Conn1);

                        cmd.Parameters.AddWithValue("@usern", txtRegister_Uname.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            string usern = txtRegister_Uname.Text.Substring(0, 1).ToUpper() + txtRegister_Uname.Text.Substring(1);
                            MessageBox.Show(usern + "is already taken","Error Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (txtRegister_Pass.Text != textRegister_cPass.Text)
                        {
                            MessageBox.Show("password does not match.", "Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                        else if (txtRegister_Pass.Text.Length < 8)
                        {
                            MessageBox.Show("Invalid password , at least 8 characters are needed.","Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            string insertData = "INSERT INTO Users (Username,Password,Profile_Image,Role,Status,Reg_Date)" +
                                "VALUES (@usern,@pass,@image,@role,@status,@date)";
                            DateTime today = DateTime.Today;
                            SqlCommand cmd1 = new SqlCommand(insertData, Conn1);
                            {
                                cmd1.Parameters.AddWithValue("@usern",txtRegister_Uname.Text.Trim());
                                cmd1.Parameters.AddWithValue("@pass", txtRegister_Pass.Text.Trim());
                                cmd1.Parameters.AddWithValue("@image","");
                                cmd1.Parameters.AddWithValue("@role","Doctor");
                                cmd1.Parameters.AddWithValue("@status","Approval");
                                cmd1.Parameters.AddWithValue("@date",today);

                                cmd1.ExecuteNonQuery();

                                MessageBox.Show("Registered Successfully!","Information message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                // SWITCH FORM INTO LOGIN FORM
                                Form1 loginFom = new Form1();
                                loginFom.Show();

                                this.Hide();


                            }
                        }
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        Conn1.Close();
                    }
                   

                }

            }
        }
    }
}
