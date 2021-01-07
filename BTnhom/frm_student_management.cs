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

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmb_sex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_faculty_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_student_management_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_managementDataSet.student_information' table. You can move, or remove it, as needed.
            this.student_informationTableAdapter.Fill(this.student_managementDataSet.student_information);

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
        }
    }
}
