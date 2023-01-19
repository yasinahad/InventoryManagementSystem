using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //checkbox to show/hide password
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHidePassword.Checked)
            {
                PasswordTb.UseSystemPasswordChar = true;
                chkHidePassword.Text = "view Password";
            }
            else
            {
                PasswordTb.UseSystemPasswordChar = false;
                chkHidePassword.Text = "Hide Password"; 
            }
        }

        //clear textbox
        private void label2_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PasswordTb.Text = "";
        }
    }
}
