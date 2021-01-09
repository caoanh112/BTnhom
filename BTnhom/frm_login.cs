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

        static string user_temp = "User name", pass_temp="Password";
        static Boolean checkbox = false;


        public void check(string user,string pass)
        {
            string temp = "123";
            
            if (user == "MRTHO" && pass.GetHashCode().ToString() == temp.GetHashCode().ToString())
            {
                MessageBox.Show("Login sucessful");
                check_login.check = true;
                if (ckb_remember_me.Checked == true)
                {
                    checkbox = true;
                    user_temp = "MRTHO";
                    pass_temp = "123";
                }
                else
                {
                    checkbox = false;
                    user_temp = "User name";
                    pass_temp = "Password";
                }
                Close();
            }
            else
            {
                MessageBox.Show("Username or Password wrong");
                txt_username.Focus();
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            if (checkbox == true)
            {
                txt_password.PasswordChar = '*';
            }
            txt_username.Text = user_temp;
            txt_password.Text = pass_temp;
            
            txt_username.Focus();
            ckb_remember_me.Checked = true;
            
           
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '*';
            //txt_password.Text = "";
            
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
            check(txt_username.Text, txt_password.Text);
        }

        private void lbl_forgot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Username: MRTHO \n Password: 123");
        }

        private void frm_login_Enter(object sender, EventArgs e)
        {
            check(txt_username.Text, txt_password.Text);

        }
    }
}
