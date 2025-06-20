namespace HMS
{
    partial class AdminAddUsers
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AdminAddUsers_importBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AdminAddUsers_imageView = new System.Windows.Forms.PictureBox();
            this.AdminAddUsers_clearbtn = new System.Windows.Forms.Button();
            this.AdminAddUsers_deletebtn = new System.Windows.Forms.Button();
            this.AdminAddUsers_updatebtn = new System.Windows.Forms.Button();
            this.AdminAddUsers_addbtn = new System.Windows.Forms.Button();
            this.comAdminAddUsers_status = new System.Windows.Forms.ComboBox();
            this.comAdminAddUsers_role = new System.Windows.Forms.ComboBox();
            this.AdminAddUsers_password = new System.Windows.Forms.TextBox();
            this.AdminAddUsers_username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminAddUsers_imageView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(386, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 711);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(8, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(833, 640);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data of users";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AdminAddUsers_importBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.AdminAddUsers_clearbtn);
            this.panel2.Controls.Add(this.AdminAddUsers_deletebtn);
            this.panel2.Controls.Add(this.AdminAddUsers_updatebtn);
            this.panel2.Controls.Add(this.AdminAddUsers_addbtn);
            this.panel2.Controls.Add(this.comAdminAddUsers_status);
            this.panel2.Controls.Add(this.comAdminAddUsers_role);
            this.panel2.Controls.Add(this.AdminAddUsers_password);
            this.panel2.Controls.Add(this.AdminAddUsers_username);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(15, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 711);
            this.panel2.TabIndex = 2;
            // 
            // AdminAddUsers_importBtn
            // 
            this.AdminAddUsers_importBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.AdminAddUsers_importBtn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminAddUsers_importBtn.ForeColor = System.Drawing.Color.White;
            this.AdminAddUsers_importBtn.Location = new System.Drawing.Point(109, 170);
            this.AdminAddUsers_importBtn.Name = "AdminAddUsers_importBtn";
            this.AdminAddUsers_importBtn.Size = new System.Drawing.Size(111, 40);
            this.AdminAddUsers_importBtn.TabIndex = 13;
            this.AdminAddUsers_importBtn.Text = "Import";
            this.AdminAddUsers_importBtn.UseVisualStyleBackColor = false;
            this.AdminAddUsers_importBtn.Click += new System.EventHandler(this.AdminAddUsers_importBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.AdminAddUsers_imageView);
            this.panel3.Location = new System.Drawing.Point(95, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 135);
            this.panel3.TabIndex = 12;
            // 
            // AdminAddUsers_imageView
            // 
            this.AdminAddUsers_imageView.Location = new System.Drawing.Point(0, 0);
            this.AdminAddUsers_imageView.Name = "AdminAddUsers_imageView";
            this.AdminAddUsers_imageView.Size = new System.Drawing.Size(140, 135);
            this.AdminAddUsers_imageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AdminAddUsers_imageView.TabIndex = 0;
            this.AdminAddUsers_imageView.TabStop = false;
            // 
            // AdminAddUsers_clearbtn
            // 
            this.AdminAddUsers_clearbtn.BackColor = System.Drawing.Color.Gray;
            this.AdminAddUsers_clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminAddUsers_clearbtn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminAddUsers_clearbtn.ForeColor = System.Drawing.Color.White;
            this.AdminAddUsers_clearbtn.Location = new System.Drawing.Point(201, 623);
            this.AdminAddUsers_clearbtn.Name = "AdminAddUsers_clearbtn";
            this.AdminAddUsers_clearbtn.Size = new System.Drawing.Size(124, 53);
            this.AdminAddUsers_clearbtn.TabIndex = 11;
            this.AdminAddUsers_clearbtn.Text = "CLEAR";
            this.AdminAddUsers_clearbtn.UseVisualStyleBackColor = false;
            this.AdminAddUsers_clearbtn.Click += new System.EventHandler(this.AdminAddUsers_clearbtn_Click);
            // 
            // AdminAddUsers_deletebtn
            // 
            this.AdminAddUsers_deletebtn.BackColor = System.Drawing.Color.Red;
            this.AdminAddUsers_deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminAddUsers_deletebtn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminAddUsers_deletebtn.ForeColor = System.Drawing.Color.White;
            this.AdminAddUsers_deletebtn.Location = new System.Drawing.Point(36, 623);
            this.AdminAddUsers_deletebtn.Name = "AdminAddUsers_deletebtn";
            this.AdminAddUsers_deletebtn.Size = new System.Drawing.Size(115, 53);
            this.AdminAddUsers_deletebtn.TabIndex = 10;
            this.AdminAddUsers_deletebtn.Text = "DELETE";
            this.AdminAddUsers_deletebtn.UseVisualStyleBackColor = false;
            this.AdminAddUsers_deletebtn.Click += new System.EventHandler(this.AdminAddUsers_deletebtn_Click);
            // 
            // AdminAddUsers_updatebtn
            // 
            this.AdminAddUsers_updatebtn.BackColor = System.Drawing.Color.Yellow;
            this.AdminAddUsers_updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminAddUsers_updatebtn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminAddUsers_updatebtn.ForeColor = System.Drawing.Color.Black;
            this.AdminAddUsers_updatebtn.Location = new System.Drawing.Point(201, 509);
            this.AdminAddUsers_updatebtn.Name = "AdminAddUsers_updatebtn";
            this.AdminAddUsers_updatebtn.Size = new System.Drawing.Size(124, 53);
            this.AdminAddUsers_updatebtn.TabIndex = 9;
            this.AdminAddUsers_updatebtn.Text = "UPDATE";
            this.AdminAddUsers_updatebtn.UseVisualStyleBackColor = false;
            this.AdminAddUsers_updatebtn.Click += new System.EventHandler(this.AdminAddUsers_updatebtn_Click);
            // 
            // AdminAddUsers_addbtn
            // 
            this.AdminAddUsers_addbtn.BackColor = System.Drawing.Color.Green;
            this.AdminAddUsers_addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminAddUsers_addbtn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminAddUsers_addbtn.ForeColor = System.Drawing.Color.Black;
            this.AdminAddUsers_addbtn.Location = new System.Drawing.Point(36, 509);
            this.AdminAddUsers_addbtn.Name = "AdminAddUsers_addbtn";
            this.AdminAddUsers_addbtn.Size = new System.Drawing.Size(115, 53);
            this.AdminAddUsers_addbtn.TabIndex = 8;
            this.AdminAddUsers_addbtn.Text = "ADD";
            this.AdminAddUsers_addbtn.UseVisualStyleBackColor = false;
            this.AdminAddUsers_addbtn.Click += new System.EventHandler(this.AdminAddUsers_addbtn_Click);
            // 
            // comAdminAddUsers_status
            // 
            this.comAdminAddUsers_status.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comAdminAddUsers_status.FormattingEnabled = true;
            this.comAdminAddUsers_status.Items.AddRange(new object[] {
            "Active ",
            "Inactive",
            "Approval"});
            this.comAdminAddUsers_status.Location = new System.Drawing.Point(124, 431);
            this.comAdminAddUsers_status.Name = "comAdminAddUsers_status";
            this.comAdminAddUsers_status.Size = new System.Drawing.Size(218, 31);
            this.comAdminAddUsers_status.TabIndex = 7;
            // 
            // comAdminAddUsers_role
            // 
            this.comAdminAddUsers_role.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comAdminAddUsers_role.FormattingEnabled = true;
            this.comAdminAddUsers_role.Items.AddRange(new object[] {
            "Admin",
            "Doctor"});
            this.comAdminAddUsers_role.Location = new System.Drawing.Point(124, 373);
            this.comAdminAddUsers_role.Name = "comAdminAddUsers_role";
            this.comAdminAddUsers_role.Size = new System.Drawing.Size(218, 31);
            this.comAdminAddUsers_role.TabIndex = 6;
            // 
            // AdminAddUsers_password
            // 
            this.AdminAddUsers_password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminAddUsers_password.Location = new System.Drawing.Point(124, 325);
            this.AdminAddUsers_password.Name = "AdminAddUsers_password";
            this.AdminAddUsers_password.Size = new System.Drawing.Size(218, 31);
            this.AdminAddUsers_password.TabIndex = 5;
            this.AdminAddUsers_password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // AdminAddUsers_username
            // 
            this.AdminAddUsers_username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminAddUsers_username.Location = new System.Drawing.Point(124, 257);
            this.AdminAddUsers_username.Name = "AdminAddUsers_username";
            this.AdminAddUsers_username.Size = new System.Drawing.Size(218, 31);
            this.AdminAddUsers_username.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Role:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // AdminAddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAddUsers";
            this.Size = new System.Drawing.Size(1259, 745);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdminAddUsers_imageView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comAdminAddUsers_status;
        private System.Windows.Forms.ComboBox comAdminAddUsers_role;
        private System.Windows.Forms.TextBox AdminAddUsers_password;
        private System.Windows.Forms.TextBox AdminAddUsers_username;
        private System.Windows.Forms.Button AdminAddUsers_clearbtn;
        private System.Windows.Forms.Button AdminAddUsers_deletebtn;
        private System.Windows.Forms.Button AdminAddUsers_updatebtn;
        private System.Windows.Forms.Button AdminAddUsers_addbtn;
        private System.Windows.Forms.Button AdminAddUsers_importBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox AdminAddUsers_imageView;
    }
}
