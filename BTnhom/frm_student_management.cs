using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BTnhom
{
    public partial class frm_student_management : Form
    {
        public frm_student_management()
        {
            InitializeComponent();
        }

        SqlConnection conn = null;
        SqlCommand cmd;
        SqlDataAdapter dap;
        DataSet ds;

        string sqlconnect = "Data Source=35.240.156.92,1433; Initial Catalog = dbtest; User ID = admin; Password=freedata";



        private void frm_student_management_Load(object sender, EventArgs e)
        {
            //kết nối csdl
            try
            {
                conn = new SqlConnection(sqlconnect);
                conn.Open();
                lbl_status.Text += "connected";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            data_load("SELECT * FROM student_information");

            btn_edit.Enabled = false;
            btn_delete.Enabled = false;

            show_details(false);

        }

        private void data_load(string sql)
        {
            ds = new DataSet();

            dap = new SqlDataAdapter(sql, conn);

            dap.Fill(ds);

            dgv_table.DataSource = ds.Tables[0];

            
        }

        //true ==> enabled ; false ==> disenabled
        private void show_details(Boolean show)
        {
            txt_id.Enabled = show;
            txt_first_name.Enabled = show;
            txt_last_name.Enabled = show;
            dtp_birth.Enabled = show;
            cmb_sex.Enabled = show;
            txt_faculty.Enabled = show;
            //ẩn 2 nút save và cancel
            btn_save.Enabled = show;
            btn_cancel.Enabled = show;            
        }

        //làm trống form chi tiết
        private void clead_details()
        {
            txt_id.Clear();
            txt_first_name.Clear();
            txt_last_name.Clear();
            dtp_birth.Value = DateTime.Now;
            cmb_sex.SelectedItem = null;
            txt_faculty.Clear();
            
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            grb_details.Text = "Add infomation of student:";
            clead_details();
            btn_delete.Enabled = false;
            btn_edit.Enabled = false;
            btn_save.Enabled = false;

            show_details(true);

        }

        private void dgv_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            show_details(false);
            btn_edit.Enabled = true;
            btn_delete.Enabled = true;
            

            try
            {
                txt_id.Text = dgv_table[0, e.RowIndex].Value.ToString();
                txt_first_name.Text = dgv_table[1, e.RowIndex].Value.ToString();
                txt_last_name.Text = dgv_table[2, e.RowIndex].Value.ToString();
                dtp_birth.Value = (DateTime)dgv_table[3, e.RowIndex].Value;
                cmb_sex.Text = dgv_table[4, e.RowIndex].Value.ToString();
                txt_faculty.Text = dgv_table[5, e.RowIndex].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Do you want exit?", "Student management", MessageBoxButtons.YesNo);
            if (re == DialogResult.Yes) Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            grb_details.Text = "Edit information student:";
            btn_add.Enabled = false;
            btn_delete.Enabled = false;
            show_details(true);

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            
            show_details(false);
            btn_add.Enabled = true;
            btn_delete.Enabled = false;
            btn_edit.Enabled = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            show_details(true);
            grb_details.Text = "Delete information of student:";
            btn_add.Enabled = false;
            btn_edit.Enabled = false;
            DialogResult re = MessageBox.Show("to delete click button 'save'");
           
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
            
            
            if (conn == null)
            {
                conn = new SqlConnection(sqlconnect);
            }
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();         
            }
            string sql = null;
            if(btn_add.Enabled == true)
            {
                sql = "Select Count(*) From dbo.student_information Where ID = '" + txt_id.Text + "'";
                cmd = new SqlCommand(sql, conn);
                int val = (int)cmd.ExecuteScalar();

                if (val > 0)
                {
                    //kiểm tra mã số sinh viên bị trùng
                    MessageBox.Show("ID student have already exist!");
                    txt_id.Focus();
                }
                else
                {
                    if (txt_id.Text.Trim() != "")
                    {
                        sql = "INSERT INTO dbo.student_information(ID,First_name,Last_name,Date_birth,Sex,Faculty_code) VALUES (";
                        sql += "'" + txt_id.Text + "',";
                        sql += "N'" + txt_first_name.Text + "',";
                        sql += "N'" + txt_last_name.Text + "',";
                        sql += "'" + dtp_birth.Value.Date + "',";
                        sql += "N'" + cmb_sex.Text + "',";
                        sql += "'" + txt_faculty.Text + "')";
                    }
                    else
                    {
                        MessageBox.Show("Enter ID student");
                        txt_id.Focus();
                    }
                }
                
            }

            if (btn_edit.Enabled == true)
            {
                sql = "Update dbo.student_information SET ";
                sql += "First_name = N'" + txt_first_name.Text + "',";
                sql += "Last_name = N'" + txt_last_name.Text + "',";
                sql += "Date_birth = '" + dtp_birth.Value.Date + "',";
                sql += "Sex = N'" + cmb_sex.Text + "',";
                sql += "Faculty_code = '" + txt_faculty.Text + "' ";
                sql += "Where ID= '" + txt_id.Text + "'";
                

            }

            if (btn_delete.Enabled == true)
            {
                sql = "Delete from dbo.student_information Where ID = '" + txt_id.Text + "'";
                
            }
            cmd = new SqlCommand(sql,conn);
            cmd.ExecuteNonQuery();
            data_load("SELECT * FROM student_information");            
            conn.Close();
            
            btn_add.Enabled = true;
            
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}