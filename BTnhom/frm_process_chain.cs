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
    
    public partial class frm_process_chain : Form
    {
        public frm_process_chain()
        {
            InitializeComponent();
        }

        private void btn_Separation_words_Click(object sender, EventArgs e)
        {
            chain_process chain = new chain_process();
            txt_output.Text = chain.separation(txt_input.Text, txt_seperation.Text);
        }
    }
}
