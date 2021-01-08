
namespace BTnhom
{
    partial class frm_student_management
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_first_name = new System.Windows.Forms.Label();
            this.lbl_last_name = new System.Windows.Forms.Label();
            this.lbl_date_birth = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_faculty = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_first_name = new System.Windows.Forms.TextBox();
            this.txt_last_name = new System.Windows.Forms.TextBox();
            this.txt_faculty = new System.Windows.Forms.TextBox();
            this.cmb_sex = new System.Windows.Forms.ComboBox();
            this.dtp_birth = new System.Windows.Forms.DateTimePicker();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.studentinformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_managementDataSet = new BTnhom.student_managementDataSet();
            this.student_informationTableAdapter = new BTnhom.student_managementDataSetTableAdapters.student_informationTableAdapter();
            this.pnl_tile = new System.Windows.Forms.Panel();
            this.lbl_tile = new System.Windows.Forms.Label();
            this.grb_details = new System.Windows.Forms.GroupBox();
            this.pnl_button = new System.Windows.Forms.Panel();
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentinformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_managementDataSet)).BeginInit();
            this.pnl_tile.SuspendLayout();
            this.grb_details.SuspendLayout();
            this.pnl_button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(6, 63);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(110, 25);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID Student:";
            // 
            // lbl_first_name
            // 
            this.lbl_first_name.AutoSize = true;
            this.lbl_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_first_name.Location = new System.Drawing.Point(6, 234);
            this.lbl_first_name.Name = "lbl_first_name";
            this.lbl_first_name.Size = new System.Drawing.Size(109, 25);
            this.lbl_first_name.TabIndex = 0;
            this.lbl_first_name.Text = "First name:";
            // 
            // lbl_last_name
            // 
            this.lbl_last_name.AutoSize = true;
            this.lbl_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_last_name.Location = new System.Drawing.Point(6, 147);
            this.lbl_last_name.Name = "lbl_last_name";
            this.lbl_last_name.Size = new System.Drawing.Size(109, 25);
            this.lbl_last_name.TabIndex = 0;
            this.lbl_last_name.Text = "Last name:";
            // 
            // lbl_date_birth
            // 
            this.lbl_date_birth.AutoSize = true;
            this.lbl_date_birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date_birth.Location = new System.Drawing.Point(6, 323);
            this.lbl_date_birth.Name = "lbl_date_birth";
            this.lbl_date_birth.Size = new System.Drawing.Size(122, 25);
            this.lbl_date_birth.TabIndex = 0;
            this.lbl_date_birth.Text = "Date of birth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sex:";
            // 
            // lbl_faculty
            // 
            this.lbl_faculty.AutoSize = true;
            this.lbl_faculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_faculty.Location = new System.Drawing.Point(6, 494);
            this.lbl_faculty.Name = "lbl_faculty";
            this.lbl_faculty.Size = new System.Drawing.Size(129, 25);
            this.lbl_faculty.TabIndex = 0;
            this.lbl_faculty.Text = "Faculty code:";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(136, 60);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(202, 30);
            this.txt_id.TabIndex = 1;
            // 
            // txt_first_name
            // 
            this.txt_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_first_name.Location = new System.Drawing.Point(136, 231);
            this.txt_first_name.Name = "txt_first_name";
            this.txt_first_name.Size = new System.Drawing.Size(202, 30);
            this.txt_first_name.TabIndex = 1;
            // 
            // txt_last_name
            // 
            this.txt_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_last_name.Location = new System.Drawing.Point(136, 144);
            this.txt_last_name.Name = "txt_last_name";
            this.txt_last_name.Size = new System.Drawing.Size(202, 30);
            this.txt_last_name.TabIndex = 1;
            // 
            // txt_faculty
            // 
            this.txt_faculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_faculty.Location = new System.Drawing.Point(136, 491);
            this.txt_faculty.Name = "txt_faculty";
            this.txt_faculty.Size = new System.Drawing.Size(202, 30);
            this.txt_faculty.TabIndex = 1;
            // 
            // cmb_sex
            // 
            this.cmb_sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sex.FormattingEnabled = true;
            this.cmb_sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_sex.Location = new System.Drawing.Point(136, 403);
            this.cmb_sex.Name = "cmb_sex";
            this.cmb_sex.Size = new System.Drawing.Size(202, 33);
            this.cmb_sex.TabIndex = 2;
            // 
            // dtp_birth
            // 
            this.dtp_birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_birth.Location = new System.Drawing.Point(136, 318);
            this.dtp_birth.Name = "dtp_birth";
            this.dtp_birth.Size = new System.Drawing.Size(202, 30);
            this.dtp_birth.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(57, 15);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(108, 38);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(210, 15);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(108, 38);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(362, 15);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(108, 38);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(50, 598);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(108, 38);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // studentinformationBindingSource
            // 
            this.studentinformationBindingSource.DataMember = "student_information";
            this.studentinformationBindingSource.DataSource = this.student_managementDataSet;
            // 
            // student_managementDataSet
            // 
            this.student_managementDataSet.DataSetName = "student_managementDataSet";
            this.student_managementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_informationTableAdapter
            // 
            this.student_informationTableAdapter.ClearBeforeFill = true;
            // 
            // pnl_tile
            // 
            this.pnl_tile.Controls.Add(this.lbl_tile);
            this.pnl_tile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_tile.Location = new System.Drawing.Point(0, 0);
            this.pnl_tile.Name = "pnl_tile";
            this.pnl_tile.Size = new System.Drawing.Size(1344, 119);
            this.pnl_tile.TabIndex = 5;
            // 
            // lbl_tile
            // 
            this.lbl_tile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_tile.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tile.Location = new System.Drawing.Point(0, 0);
            this.lbl_tile.Name = "lbl_tile";
            this.lbl_tile.Size = new System.Drawing.Size(1344, 119);
            this.lbl_tile.TabIndex = 0;
            this.lbl_tile.Text = "STUDENT MANAGEMENT";
            this.lbl_tile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grb_details
            // 
            this.grb_details.Controls.Add(this.lbl_status);
            this.grb_details.Controls.Add(this.btn_cancel);
            this.grb_details.Controls.Add(this.btn_save);
            this.grb_details.Controls.Add(this.txt_id);
            this.grb_details.Controls.Add(this.lbl_id);
            this.grb_details.Controls.Add(this.txt_last_name);
            this.grb_details.Controls.Add(this.txt_faculty);
            this.grb_details.Controls.Add(this.lbl_faculty);
            this.grb_details.Controls.Add(this.cmb_sex);
            this.grb_details.Controls.Add(this.dtp_birth);
            this.grb_details.Controls.Add(this.lbl_last_name);
            this.grb_details.Controls.Add(this.label2);
            this.grb_details.Controls.Add(this.txt_first_name);
            this.grb_details.Controls.Add(this.lbl_first_name);
            this.grb_details.Controls.Add(this.lbl_date_birth);
            this.grb_details.Dock = System.Windows.Forms.DockStyle.Right;
            this.grb_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_details.Location = new System.Drawing.Point(990, 119);
            this.grb_details.Name = "grb_details";
            this.grb_details.Size = new System.Drawing.Size(354, 788);
            this.grb_details.TabIndex = 7;
            this.grb_details.TabStop = false;
            this.grb_details.Text = "Details";
            // 
            // pnl_button
            // 
            this.pnl_button.Controls.Add(this.btn_add);
            this.pnl_button.Controls.Add(this.btn_exit);
            this.pnl_button.Controls.Add(this.btn_delete);
            this.pnl_button.Controls.Add(this.btn_edit);
            this.pnl_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_button.Location = new System.Drawing.Point(0, 832);
            this.pnl_button.Name = "pnl_button";
            this.pnl_button.Size = new System.Drawing.Size(990, 75);
            this.pnl_button.TabIndex = 8;
            // 
            // dgv_table
            // 
            this.dgv_table.AllowUserToAddRows = false;
            this.dgv_table.AllowUserToDeleteRows = false;
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_table.Location = new System.Drawing.Point(0, 119);
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.ReadOnly = true;
            this.dgv_table.RowHeadersWidth = 62;
            this.dgv_table.RowTemplate.Height = 28;
            this.dgv_table.Size = new System.Drawing.Size(990, 713);
            this.dgv_table.TabIndex = 9;
            this.dgv_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_table_CellContentClick);
            // 
            // lbl_status
            // 
            this.lbl_status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(3, 745);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(348, 40);
            this.lbl_status.TabIndex = 4;
            this.lbl_status.Text = "Status: ";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(230, 598);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(108, 38);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(850, 15);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(108, 38);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // frm_student_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 907);
            this.Controls.Add(this.dgv_table);
            this.Controls.Add(this.pnl_button);
            this.Controls.Add(this.grb_details);
            this.Controls.Add(this.pnl_tile);
            this.Name = "frm_student_management";
            this.Text = "frm_student_management";
            this.Load += new System.EventHandler(this.frm_student_management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentinformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_managementDataSet)).EndInit();
            this.pnl_tile.ResumeLayout(false);
            this.grb_details.ResumeLayout(false);
            this.grb_details.PerformLayout();
            this.pnl_button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_first_name;
        private System.Windows.Forms.Label lbl_last_name;
        private System.Windows.Forms.Label lbl_date_birth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_faculty;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_first_name;
        private System.Windows.Forms.TextBox txt_last_name;
        private System.Windows.Forms.TextBox txt_faculty;
        private System.Windows.Forms.ComboBox cmb_sex;
        private System.Windows.Forms.DateTimePicker dtp_birth;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private student_managementDataSet student_managementDataSet;
        private System.Windows.Forms.BindingSource studentinformationBindingSource;
        private student_managementDataSetTableAdapters.student_informationTableAdapter student_informationTableAdapter;
        private System.Windows.Forms.Panel pnl_tile;
        private System.Windows.Forms.GroupBox grb_details;
        private System.Windows.Forms.Label lbl_tile;
        private System.Windows.Forms.Panel pnl_button;
        private System.Windows.Forms.DataGridView dgv_table;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_exit;
    }
}