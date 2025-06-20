using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void adminAddUsers1_Load(object sender, EventArgs e)
        {

        }

        private void Register_close_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?","Confermation Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult chcek = MessageBox.Show("Are you sure you want to logout?", "Confermation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (chcek == DialogResult.Yes) 
            { 
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();


            }
        }
    }
}
