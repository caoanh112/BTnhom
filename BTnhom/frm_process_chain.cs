using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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
            chain_process chain = new chain_process();
            txt_output.Text = chain.Count(txt_input.Text, "lower").ToString();

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

        private void btn_text_void_Click(object sender, EventArgs e)
        {
            chain_process chain = new chain_process();
            txt_output.Text = "time delay few seconds..... \r\n if nothing happens, please click it again! \r\n";
            txt_output.Text += chain.text_to_void(txt_input.Text);
            
        }

        private void frm_process_chain_Load(object sender, EventArgs e)
        {
            chain_process chain = new chain_process();            
            Thread.Sleep(500);
            chain.text_to_void("Chào bạn, đây là chương trình xử lý văn bản");
        }

        private void btn_first_position_Click(object sender, EventArgs e)
        {
            chain_process chain = new chain_process();
            txt_output.Text = "Vị trí cần tìm là " + chain.firstposition(txt_input.Text, txt_first_position.Text).ToString();
        }

        private void btn_find_position_last_Click(object sender, EventArgs e)
        {
            chain_process chain = new chain_process();
            txt_output.Text = "Vị trí cần tìm là " + chain.lastposition(txt_input.Text, txt_last_position.Text).ToString();
        }

        private void btn_occurrences_Click(object sender, EventArgs e)
        {
            chain_process chain = new chain_process();
            txt_output.Text = "Số lần xuất hiện là " + chain.Number(txt_input.Text, num_occurrences.Text).ToString();
        }

        private void btn_change_substring_Click(object sender, EventArgs e)
        {
            chain_process chain = new chain_process();
            txt_output.Text = chain.change(txt_input.Text, txt_replace_string.Text, txt_new_string.Text);
        }

        private void btn_delete_substring_Click(object sender, EventArgs e)
        {
            chain_process chain = new chain_process();
            txt_output.Text = chain.delete(txt_input.Text, txt_del_string.Text);
        }

        private void btn_insert_string_Click(object sender, EventArgs e)
        {
            chain_process chain = new chain_process();
            int p = int.Parse(txt_insert_position.Text);
            txt_output.Text = chain.insert(txt_input.Text, txt_insert.Text, p);
        }

        private void btn_filtered_extraction_Click(object sender, EventArgs e)
        {
            chain_process chain = new chain_process();
            int p1 = int.Parse(txt_filter_p1.Text), p2 = int.Parse(txt_filter_p2.Text);
            txt_output.Text = chain.filter(txt_input.Text, p1, p2);

           
        }

        private void btn_num_digit_Click(object sender, EventArgs e)
        {
            chain_process chain = new chain_process();
            txt_output.Text = chain.Count(txt_input.Text, "digit").ToString();

        }
    }
}
