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
            frm_process_chain frm_chain = new frm_process_chain();
            frm_chain.Show();
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
            frm_book_sale frm_book = new frm_book_sale();
            frm_book.Show();
        }
    }
}
