using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace BTnhom
{   
       
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();            
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_info info = new frm_info();
            info.Show();            
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.Show();
        }

        private void processChainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (check_login.check == false)
            {
                MessageBox.Show("You need login before can use it!");
                frm_login login = new frm_login();
                login.Show();
            }
            else
            {
                frm_process_chain frm_chain = new frm_process_chain();
                frm_chain.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Do you want to exit?", "Exit comfirm", MessageBoxButtons.YesNo);
            if (re==DialogResult.Yes)
            {
                Close();
            }
        }

        private void bookSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (check_login.check == false)
            {
                MessageBox.Show("You need login before can use it!");
                frm_login login = new frm_login();
                login.Show();
            }
            else
            {
                frm_book_sale frm_book = new frm_book_sale();
                frm_book.Show();
            }           
        }

        private void studentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (check_login.check == false)
            {
                MessageBox.Show("You need login before can use it!");
                frm_login login = new frm_login();
                login.Show();
            }
            else
            {
                frm_student_management student = new frm_student_management();
                student.Show();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_clock.Text = DateTime.Now.ToString("HH:mm");
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void logouttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            check_login.check = false;
            MessageBox.Show("Logout sucessful");
        }
    }
    public static class check_login
    {
        public static Boolean check = false;
    }
}
