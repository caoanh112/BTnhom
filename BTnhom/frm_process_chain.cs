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

        private void btn_separate_words_Click(object sender, EventArgs e)
        {
            chain_process chain = new chain_process();
            txt_output.Text = chain.separation(txt_input.Text, txt_seperation.Text);
        }

        private void btn_num_char_Click(object sender, EventArgs e)
        {
            txt_output.Text = txt_input.Text.Length.ToString();
        }

        private void btn_capitally_Click(object sender, EventArgs e)
        {

            chain_process chain = new chain_process();
            txt_output.Text = chain.Upper(txt_input.Text);
        }

        private void btn_lowercase_Click(object sender, EventArgs e)
        {
            chain_process chain = new chain_process();
            txt_output.Text = chain.Lower(txt_input.Text);
        }

        private void btn_num_upper_Click(object sender, EventArgs e)
        {
            chain_process chain = new chain_process();
            txt_output.Text = chain.Count(txt_input.Text, "up").ToString();
        }

        private void btn_num_lowercase_Click(object sender, EventArgs e)
        {

        }

        private void btn_mix_chain_Click(object sender, EventArgs e)
        {
            chain_process chain = new chain_process();
            txt_output.Text = chain.mix(txt_input.Text);
        }

        private void btn_chain_optimization_Click(object sender, EventArgs e)
        {
            chain_process chain = new chain_process();
            txt_output.Text = chain.Opimal(txt_input.Text);
        }
    }
}
