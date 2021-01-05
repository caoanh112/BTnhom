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
    public partial class frm_book_sale : Form
    {
        static double revenue = 0;
        static int num_cus = 0, num_studen = 0;
        public frm_book_sale()
        {
            InitializeComponent();
        }

        private void frm_book_sale_Load(object sender, EventArgs e)
        {
            txt_cus_name.Focus();
        }

        public void btn_invoice_Click(object sender, EventArgs e)
        {
            book_sales book = new book_sales();
            //check customer name
            if (txt_cus_name.Text=="")
            {
                MessageBox.Show("Enter customer name!");
                txt_cus_name.Focus();
            }
            else
            {
                //check num of book is invalid
                if (txt_num_of_book.Text.Contains(".")==true || txt_num_of_book.Text.Contains(",")==true)
                {
                    MessageBox.Show("Number of books not invalid!");
                    txt_num_of_book.Focus();
                }
                else
                {
                    int num_books = int.Parse(txt_num_of_book.Text), is_studen = 0;
                    if (num_books > 0)
                    {
                        if (ckb_student.Checked == true) is_studen = 1;
                        double total = book.bill_invoid(num_books, is_studen);
                        lbl_total_value.Text = total.ToString() + "VND"; // cout total_value
                                                                         //statistics
                        num_cus += 1;
                        num_studen += is_studen;
                        revenue += total;
                    }
                    else
                    {
                        MessageBox.Show("Number of books must greater than 0!");
                        txt_num_of_book.Focus();
                    }    
                }
            }
        }

        public void btn_next_Click(object sender, EventArgs e)
        {         

            txt_cus_name.Clear();
            txt_num_of_book.Clear();
            lbl_total_value.Text = "";
            ckb_student.Checked = false;
            txt_cus_name.Focus();           
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Do you want to exit book sales program?", "Book sales", MessageBoxButtons.YesNo);
            if (re == DialogResult.Yes) Close();
        }

        public void btn_statistics_Click(object sender, EventArgs e)
        {
            lbl_num_of_cus_value.Text = num_cus.ToString();
            lbl_num_of_stu_value.Text = num_studen.ToString();
            lbl_revenue_value.Text = revenue.ToString();
            
        }
    }
}
