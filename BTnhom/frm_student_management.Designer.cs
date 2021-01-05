
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(22, 57);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(110, 25);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID Student:";
            // 
            // lbl_first_name
            // 
            this.lbl_first_name.AutoSize = true;
            this.lbl_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_first_name.Location = new System.Drawing.Point(382, 57);
            this.lbl_first_name.Name = "lbl_first_name";
            this.lbl_first_name.Size = new System.Drawing.Size(109, 25);
            this.lbl_first_name.TabIndex = 0;
            this.lbl_first_name.Text = "First name:";
            this.lbl_first_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_last_name
            // 
            this.lbl_last_name.AutoSize = true;
            this.lbl_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_last_name.Location = new System.Drawing.Point(737, 57);
            this.lbl_last_name.Name = "lbl_last_name";
            this.lbl_last_name.Size = new System.Drawing.Size(109, 25);
            this.lbl_last_name.TabIndex = 0;
            this.lbl_last_name.Text = "Last name:";
            this.lbl_last_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_date_birth
            // 
            this.lbl_date_birth.AutoSize = true;
            this.lbl_date_birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date_birth.Location = new System.Drawing.Point(10, 156);
            this.lbl_date_birth.Name = "lbl_date_birth";
            this.lbl_date_birth.Size = new System.Drawing.Size(122, 25);
            this.lbl_date_birth.TabIndex = 0;
            this.lbl_date_birth.Text = "Date of birth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sex:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_faculty
            // 
            this.lbl_faculty.AutoSize = true;
            this.lbl_faculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_faculty.Location = new System.Drawing.Point(726, 157);
            this.lbl_faculty.Name = "lbl_faculty";
            this.lbl_faculty.Size = new System.Drawing.Size(129, 25);
            this.lbl_faculty.TabIndex = 0;
            this.lbl_faculty.Text = "Faculty code:";
            this.lbl_faculty.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(138, 52);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(202, 30);
            this.txt_id.TabIndex = 1;
            // 
            // txt_first_name
            // 
            this.txt_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_first_name.Location = new System.Drawing.Point(497, 52);
            this.txt_first_name.Name = "txt_first_name";
            this.txt_first_name.Size = new System.Drawing.Size(202, 30);
            this.txt_first_name.TabIndex = 1;
            // 
            // txt_last_name
            // 
            this.txt_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_last_name.Location = new System.Drawing.Point(852, 52);
            this.txt_last_name.Name = "txt_last_name";
            this.txt_last_name.Size = new System.Drawing.Size(202, 30);
            this.txt_last_name.TabIndex = 1;
            // 
            // txt_faculty
            // 
            this.txt_faculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_faculty.Location = new System.Drawing.Point(852, 151);
            this.txt_faculty.Name = "txt_faculty";
            this.txt_faculty.Size = new System.Drawing.Size(202, 30);
            this.txt_faculty.TabIndex = 1;
            this.txt_faculty.TextChanged += new System.EventHandler(this.txt_faculty_TextChanged);
            // 
            // cmb_sex
            // 
            this.cmb_sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sex.FormattingEnabled = true;
            this.cmb_sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_sex.Location = new System.Drawing.Point(497, 151);
            this.cmb_sex.Name = "cmb_sex";
            this.cmb_sex.Size = new System.Drawing.Size(202, 33);
            this.cmb_sex.TabIndex = 2;
            this.cmb_sex.SelectedIndexChanged += new System.EventHandler(this.cmb_sex_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(138, 151);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(202, 30);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(48, 602);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(108, 38);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(201, 602);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(108, 38);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(353, 602);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(108, 38);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(497, 602);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(108, 38);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // frm_student_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 684);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmb_sex);
            this.Controls.Add(this.txt_last_name);
            this.Controls.Add(this.txt_first_name);
            this.Controls.Add(this.txt_faculty);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_faculty);
            this.Controls.Add(this.lbl_last_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_date_birth);
            this.Controls.Add(this.lbl_first_name);
            this.Controls.Add(this.lbl_id);
            this.Name = "frm_student_management";
            this.Text = "frm_student_management";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
    }
}