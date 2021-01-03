using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BTnhom
{
    public partial class frm_info : Form
    {
        public frm_info()
        {
            InitializeComponent();
        }

        private void frm_info_Load(object sender, EventArgs e)
        {

        }

        private void lbl_urlgithub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/caoanh112/BTnhom");
        }
    }
}
