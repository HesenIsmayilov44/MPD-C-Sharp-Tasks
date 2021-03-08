using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            string userName = txt_Name.Text;
            string userPassword = txt_Password.Text;
            string userRole = combo_Role.SelectedItem.ToString();
            bool userIsAdmin = (check_IsAdmin.Checked);
            MessageBox.Show("User - " + userName + " created successfully!");
            txt_UsersList.AppendText("- " + userName + " | Role : " + userRole + " | Status : " + ((userIsAdmin) ? "Admin \r\n" : "Normal \r\n"));
        }
    }
}
