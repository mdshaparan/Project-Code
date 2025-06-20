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
    public partial class Form1 : Form
    {
        string @usern, @pass;

        SqlConnection Conn1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Hspital.mdf;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();

            this.Hide();
        }

        private void chkShowpass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = chkShowpass.Checked ? '\0' : '*';
        }

        public bool emptyFields()
        {
            if (txtUname.Text == "" || txtPass.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be field.", "Error Message", MessageBoxButtons.OK);
            }
            else
            {
                if (Conn1.State == ConnectionState.Closed)
                {

                    try
                    {
                        Conn1.Open();

                        string selectAccount = "SELECT * FROM Users WHERE" +
                            " Username = @usern AND Password = @pass AND Status = @status";
                        SqlCommand cmd = new SqlCommand(selectAccount, Conn1);
                        {

                            cmd.Parameters.AddWithValue("@usern", txtUname.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", txtPass.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", "Active");

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                
                                MessageBox.Show("Login Suceessfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                AdminMainForm adminMainForm = new AdminMainForm();
                                adminMainForm.Show();

                                this.Hide();
                            }

                            else
                            {
                                MessageBox.Show("Incorrect Username/Password or there is no Admins Approval", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
