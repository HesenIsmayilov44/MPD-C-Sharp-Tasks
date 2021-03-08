namespace Task1
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.check_IsAdmin = new System.Windows.Forms.CheckBox();
            this.lbl_headTitle = new System.Windows.Forms.Label();
            this.combo_Role = new System.Windows.Forms.ComboBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Role = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_UsersList = new System.Windows.Forms.TextBox();
            this.lbl_UsersList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_AddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddUser.FlatAppearance.BorderSize = 0;
            this.btn_AddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btn_AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddUser.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AddUser.Location = new System.Drawing.Point(12, 328);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(170, 38);
            this.btn_AddUser.TabIndex = 0;
            this.btn_AddUser.Text = "Add User";
            this.btn_AddUser.UseVisualStyleBackColor = false;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // check_IsAdmin
            // 
            this.check_IsAdmin.AutoSize = true;
            this.check_IsAdmin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_IsAdmin.Location = new System.Drawing.Point(12, 284);
            this.check_IsAdmin.Name = "check_IsAdmin";
            this.check_IsAdmin.Size = new System.Drawing.Size(170, 23);
            this.check_IsAdmin.TabIndex = 1;
            this.check_IsAdmin.Text = "Admin Panel Access";
            this.check_IsAdmin.UseVisualStyleBackColor = true;
            // 
            // lbl_headTitle
            // 
            this.lbl_headTitle.AutoSize = true;
            this.lbl_headTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_headTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_headTitle.Location = new System.Drawing.Point(199, 9);
            this.lbl_headTitle.Name = "lbl_headTitle";
            this.lbl_headTitle.Size = new System.Drawing.Size(106, 25);
            this.lbl_headTitle.TabIndex = 2;
            this.lbl_headTitle.Text = "Add User";
            // 
            // combo_Role
            // 
            this.combo_Role.DisplayMember = "Choose Role";
            this.combo_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Role.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Role.FormattingEnabled = true;
            this.combo_Role.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.combo_Role.Location = new System.Drawing.Point(12, 231);
            this.combo_Role.Name = "combo_Role";
            this.combo_Role.Size = new System.Drawing.Size(170, 26);
            this.combo_Role.Sorted = true;
            this.combo_Role.TabIndex = 3;
            this.combo_Role.Tag = "";
            // 
            // txt_Name
            // 
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(12, 109);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(170, 26);
            this.txt_Name.TabIndex = 4;
            // 
            // lbl_Role
            // 
            this.lbl_Role.AutoSize = true;
            this.lbl_Role.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Role.Location = new System.Drawing.Point(12, 209);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(51, 19);
            this.lbl_Role.TabIndex = 6;
            this.lbl_Role.Text = "Role :";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(12, 87);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(61, 19);
            this.lbl_Name.TabIndex = 7;
            this.lbl_Name.Text = "Name :";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(12, 148);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(87, 19);
            this.lbl_password.TabIndex = 9;
            this.lbl_password.Text = "Password :";
            // 
            // txt_Password
            // 
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(12, 170);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(170, 26);
            this.txt_Password.TabIndex = 8;
            // 
            // txt_UsersList
            // 
            this.txt_UsersList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UsersList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UsersList.Location = new System.Drawing.Point(245, 111);
            this.txt_UsersList.Multiline = true;
            this.txt_UsersList.Name = "txt_UsersList";
            this.txt_UsersList.ReadOnly = true;
            this.txt_UsersList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_UsersList.Size = new System.Drawing.Size(379, 257);
            this.txt_UsersList.TabIndex = 10;
            // 
            // lbl_UsersList
            // 
            this.lbl_UsersList.AutoSize = true;
            this.lbl_UsersList.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UsersList.Location = new System.Drawing.Point(241, 89);
            this.lbl_UsersList.Name = "lbl_UsersList";
            this.lbl_UsersList.Size = new System.Drawing.Size(110, 19);
            this.lbl_UsersList.TabIndex = 11;
            this.lbl_UsersList.Text = "List Of Users :";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(662, 411);
            this.Controls.Add(this.lbl_UsersList);
            this.Controls.Add(this.txt_UsersList);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Role);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.combo_Role);
            this.Controls.Add(this.lbl_headTitle);
            this.Controls.Add(this.check_IsAdmin);
            this.Controls.Add(this.btn_AddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task 1 ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.CheckBox check_IsAdmin;
        private System.Windows.Forms.Label lbl_headTitle;
        private System.Windows.Forms.ComboBox combo_Role;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_UsersList;
        private System.Windows.Forms.Label lbl_UsersList;
    }
}

