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
    }
}
