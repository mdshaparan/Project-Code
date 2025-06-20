using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;


namespace HMS
{
    public partial class AdminAddUsers : UserControl
    {
        SqlConnection Conn1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\7th Semester\C Sharp\HMS\HMS\Hspital.mdf"";Integrated Security=True;");
        public AdminAddUsers()
        {
            InitializeComponent();

            displayAddUsersData();
        }

        public void displayAddUsersData()
        {
            AdminAddUsersData userData = new AdminAddUsersData();
            List<AdminAddUsersData> listData = userData.usersListData();

            dataGridView1.DataSource = listData;
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public bool emptyFields()
        {
            if (AdminAddUsers_username.Text == "" || AdminAddUsers_password.Text == ""
                || comAdminAddUsers_role.Text == "" || comAdminAddUsers_status.Text == "" || AdminAddUsers_imageView.Image == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void AdminAddUsers_addbtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All field are required to be filled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (Conn1.State == ConnectionState.Closed)
                {
                    try
                    {
                        Conn1.Open();
                        // CHECK USERNAME IF ALREADY EXISTING
                        string selectUsern = "SELECT * FROM Users WHERE Username=@usern";
                        SqlCommand checkUsern = new SqlCommand(selectUsern, Conn1);
                         
                        checkUsern.Parameters.AddWithValue("@usern",AdminAddUsers_username.Text.Trim());


                        SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            string usern = AdminAddUsers_username.Text.Substring(0, 1).ToUpper() + AdminAddUsers_username.Text.Substring(1);
                            MessageBox.Show(usern+"is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } 
                        else
                        {
                            string inserData = "INSERT INTO Users (Username,Password,Profile_Image,Role,Status,Reg_Date)" +
                                "VALUES(@usern,@pass,@image,@role,@status,@date)";
                            DateTime today = DateTime.Today;

                            string path = Path.Combine(@"E:\7th Semester\C Sharp\HMS\HMS\User_Directory\" + AdminAddUsers_username.Text.Trim() + ".jpg");

                            string directoryPath = Path.GetDirectoryName(path);
                            
                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }

                            File.Copy(AdminAddUsers_imageView.ImageLocation,path,true);
                           
                            

                            SqlCommand cmd = new SqlCommand(inserData, Conn1);
                            cmd.Parameters.AddWithValue("@usern", AdminAddUsers_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", AdminAddUsers_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@image", path);
                            cmd.Parameters.AddWithValue("@role", comAdminAddUsers_role.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", comAdminAddUsers_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@date", today);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Added Successfully!","Information Message",MessageBoxButtons.OK, MessageBoxIcon.Information);

                            displayAddUsersData();


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

        private void AdminAddUsers_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
               OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg;*.png|*.jpg;*.png";
                string imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    AdminAddUsers_imageView.ImageLocation = imagePath;
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error"+ex,"Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private int Id =0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            AdminAddUsers_username.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            AdminAddUsers_password.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comAdminAddUsers_role.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comAdminAddUsers_status.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            // comAdminAddUsers_status.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            string imagePath = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            try
            {
                if (imagePath != null)
                {
                    AdminAddUsers_imageView.Image = Image.FromFile(imagePath);
                }
                else
                {
                    AdminAddUsers_imageView.Image = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No Image :3", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AdminAddUsers_updatebtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All field are required to be filled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Update Username: " + AdminAddUsers_username.Text.Trim()
                    + "?","Confermation Message",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (Conn1.State == ConnectionState.Closed)
                    {
                        try
                        {
                            Conn1.Open();

                            string selectUpdate = "UPDATE Users SET Username = @usern, Password = @pass,Role = @role, Status = @status WHERE ID = @Id";

                            SqlCommand cmd = new SqlCommand(selectUpdate, Conn1);

                            cmd.Parameters.AddWithValue("@usern", AdminAddUsers_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", AdminAddUsers_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@role", comAdminAddUsers_role.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", comAdminAddUsers_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@Id", Id);


                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            displayAddUsersData();

                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {
                            Conn1.Close();
                        }
                    }
               
                }
            }
        }

        public void clearFields()
        {
            AdminAddUsers_username.Text = "";
            AdminAddUsers_password.Text = "";
            comAdminAddUsers_role.SelectedIndex = -1;
            comAdminAddUsers_status.SelectedIndex = -1;
            AdminAddUsers_imageView.Image = null;
        }
        private void AdminAddUsers_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void AdminAddUsers_deletebtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All field are required to be filled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Delete Username: " + AdminAddUsers_username.Text.Trim()
                    + "?", "Confermation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (Conn1.State == ConnectionState.Closed)
                    {
                        try
                        {
                            Conn1.Open();

                            string selectDelete = "DELETE FROM Users WHERE Id = @Id";

                            SqlCommand cmd = new SqlCommand(selectDelete, Conn1);

                            cmd.Parameters.AddWithValue("@Id", Id);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Deleted Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            displayAddUsersData();

                        }
                        catch (Exception ex)
                        {

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
}
