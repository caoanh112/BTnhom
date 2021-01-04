using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTnhom
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            txt_username.Focus();
            ckb_remember_me.Checked = true;
            
           
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '*';
            txt_password.Text = "";
            
        }

        private void btn_exitlogin_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Do you want to exit login?", "Login", MessageBoxButtons.YesNo);
            if (re == DialogResult.Yes) Close();
        }

        private void frm_login_MouseCaptureChanged(object sender, EventArgs e)
        {



        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {       
            
              
            if (txt_username.Text == "MRTHO" && txt_password.Text == "123")
            {
                MessageBox.Show("Login sucessful");
                if (ckb_remember_me.Checked == false) 
                { 
                    txt_username.Text = ""; 
                    txt_password.Text = ""; 
                }
                Close();
            }
            else
            {
                MessageBox.Show("Username or Password wrong!");
                txt_username.Text = "";
                txt_username.Focus();
            }
        }

        private void lbl_forgot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Username: MRTHO \n Password: 123");
        }
    }
}
