
namespace BTnhom
{
    partial class frm_process_chain
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
            this.grb_input = new System.Windows.Forms.GroupBox();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.grb_output = new System.Windows.Forms.GroupBox();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.btn_num_char = new System.Windows.Forms.Button();
            this.btn_capitally = new System.Windows.Forms.Button();
            this.btn_lowercase = new System.Windows.Forms.Button();
            this.btn_num_capital = new System.Windows.Forms.Button();
            this.btn_num_lowercase = new System.Windows.Forms.Button();
            this.btn_num_digit = new System.Windows.Forms.Button();
            this.btn_chain_island = new System.Windows.Forms.Button();
            this.btn_chain_optimization = new System.Windows.Forms.Button();
            this.btn_find_position_first = new System.Windows.Forms.Button();
            this.btn_find_position_last = new System.Windows.Forms.Button();
            this.btn_occurrences = new System.Windows.Forms.Button();
            this.btn_Separation_words = new System.Windows.Forms.Button();
            this.btn_change_substring = new System.Windows.Forms.Button();
            this.btn_delete_substring = new System.Windows.Forms.Button();
            this.btn_insert_string = new System.Windows.Forms.Button();
            this.btn_filtered_extraction = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txt_seperation = new System.Windows.Forms.TextBox();
            this.btn_num_upper = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.lbl_position = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.lbl_p1 = new System.Windows.Forms.Label();
            this.lbl_p2 = new System.Windows.Forms.Label();
            this.grb_input.SuspendLayout();
            this.grb_output.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_input
            // 
            this.grb_input.Controls.Add(this.txt_input);
            this.grb_input.Location = new System.Drawing.Point(63, 25);
            this.grb_input.Name = "grb_input";
            this.grb_input.Size = new System.Drawing.Size(367, 161);
            this.grb_input.TabIndex = 0;
            this.grb_input.TabStop = false;
            this.grb_input.Text = "Input";
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(6, 23);
            this.txt_input.Multiline = true;
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(355, 132);
            this.txt_input.TabIndex = 0;
            // 
            // grb_output
            // 
            this.grb_output.Controls.Add(this.txt_output);
            this.grb_output.Location = new System.Drawing.Point(467, 25);
            this.grb_output.Name = "grb_output";
            this.grb_output.Size = new System.Drawing.Size(399, 161);
            this.grb_output.TabIndex = 0;
            this.grb_output.TabStop = false;
            this.grb_output.Text = "output";
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(6, 23);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(384, 132);
            this.txt_output.TabIndex = 0;
            // 
            // btn_num_char
            // 
            this.btn_num_char.Location = new System.Drawing.Point(72, 231);
            this.btn_num_char.Name = "btn_num_char";
            this.btn_num_char.Size = new System.Drawing.Size(358, 34);
            this.btn_num_char.TabIndex = 1;
            this.btn_num_char.Text = "Number of char";
            this.btn_num_char.UseVisualStyleBackColor = true;
            this.btn_num_char.Click += new System.EventHandler(this.btn_num_char_Click);
            // 
            // btn_capitally
            // 
            this.btn_capitally.Location = new System.Drawing.Point(72, 287);
            this.btn_capitally.Name = "btn_capitally";
            this.btn_capitally.Size = new System.Drawing.Size(358, 34);
            this.btn_capitally.TabIndex = 1;
            this.btn_capitally.Text = "Capitally";
            this.btn_capitally.UseVisualStyleBackColor = true;
            this.btn_capitally.Click += new System.EventHandler(this.btn_capitally_Click);
            // 
            // btn_lowercase
            // 
            this.btn_lowercase.Location = new System.Drawing.Point(72, 340);
            this.btn_lowercase.Name = "btn_lowercase";
            this.btn_lowercase.Size = new System.Drawing.Size(358, 34);
            this.btn_lowercase.TabIndex = 1;
            this.btn_lowercase.Text = "Lowercase";
            this.btn_lowercase.UseVisualStyleBackColor = true;
            this.btn_lowercase.Click += new System.EventHandler(this.btn_lowercase_Click);
            // 
            // btn_num_capital
            // 
            this.btn_num_capital.Location = new System.Drawing.Point(72, 401);
            this.btn_num_capital.Name = "btn_num_capital";
            this.btn_num_capital.Size = new System.Drawing.Size(358, 34);
            this.btn_num_capital.TabIndex = 1;
            this.btn_num_capital.Text = "Number of capital ";
            this.btn_num_capital.UseVisualStyleBackColor = true;
            // 
            // btn_num_lowercase
            // 
            this.btn_num_lowercase.Location = new System.Drawing.Point(72, 459);
            this.btn_num_lowercase.Name = "btn_num_lowercase";
            this.btn_num_lowercase.Size = new System.Drawing.Size(358, 34);
            this.btn_num_lowercase.TabIndex = 1;
            this.btn_num_lowercase.Text = "Number of lowercase";
            this.btn_num_lowercase.UseVisualStyleBackColor = true;
            this.btn_num_lowercase.Click += new System.EventHandler(this.btn_num_lowercase_Click);
            // 
            // btn_num_digit
            // 
            this.btn_num_digit.Location = new System.Drawing.Point(72, 518);
            this.btn_num_digit.Name = "btn_num_digit";
            this.btn_num_digit.Size = new System.Drawing.Size(358, 34);
            this.btn_num_digit.TabIndex = 1;
            this.btn_num_digit.Text = "Number of digit ";
            this.btn_num_digit.UseVisualStyleBackColor = true;
            // 
            // btn_chain_island
            // 
            this.btn_chain_island.Location = new System.Drawing.Point(72, 576);
            this.btn_chain_island.Name = "btn_chain_island";
            this.btn_chain_island.Size = new System.Drawing.Size(358, 34);
            this.btn_chain_island.TabIndex = 1;
            this.btn_chain_island.Text = "Chain island";
            this.btn_chain_island.UseVisualStyleBackColor = true;
            // 
            // btn_chain_optimization
            // 
            this.btn_chain_optimization.Location = new System.Drawing.Point(72, 632);
            this.btn_chain_optimization.Name = "btn_chain_optimization";
            this.btn_chain_optimization.Size = new System.Drawing.Size(358, 35);
            this.btn_chain_optimization.TabIndex = 1;
            this.btn_chain_optimization.Text = "Chain optimization";
            this.btn_chain_optimization.UseVisualStyleBackColor = true;
            // 
            // btn_find_position_first
            // 
            this.btn_find_position_first.Location = new System.Drawing.Point(473, 231);
            this.btn_find_position_first.Name = "btn_find_position_first";
            this.btn_find_position_first.Size = new System.Drawing.Size(271, 34);
            this.btn_find_position_first.TabIndex = 1;
            this.btn_find_position_first.Text = "Find the position appeared first";
            this.btn_find_position_first.UseVisualStyleBackColor = true;
            // 
            // btn_find_position_last
            // 
            this.btn_find_position_last.Location = new System.Drawing.Point(473, 287);
            this.btn_find_position_last.Name = "btn_find_position_last";
            this.btn_find_position_last.Size = new System.Drawing.Size(271, 34);
            this.btn_find_position_last.TabIndex = 1;
            this.btn_find_position_last.Text = "Find the position appeared last";
            this.btn_find_position_last.UseVisualStyleBackColor = true;
            // 
            // btn_occurrences
            // 
            this.btn_occurrences.Location = new System.Drawing.Point(473, 340);
            this.btn_occurrences.Name = "btn_occurrences";
            this.btn_occurrences.Size = new System.Drawing.Size(271, 34);
            this.btn_occurrences.TabIndex = 1;
            this.btn_occurrences.Text = "Number of occurrences";
            this.btn_occurrences.UseVisualStyleBackColor = true;
            // 
            // btn_Separation_words
            // 
            this.btn_Separation_words.Location = new System.Drawing.Point(473, 401);
            this.btn_Separation_words.Name = "btn_Separation_words";
            this.btn_Separation_words.Size = new System.Drawing.Size(271, 34);
            this.btn_Separation_words.TabIndex = 1;
            this.btn_Separation_words.Text = "Separation of words";
            this.btn_Separation_words.UseVisualStyleBackColor = true;
            this.btn_Separation_words.Click += new System.EventHandler(this.btn_Separation_words_Click);
            // 
            // btn_change_substring
            // 
            this.btn_change_substring.Location = new System.Drawing.Point(473, 459);
            this.btn_change_substring.Name = "btn_change_substring";
            this.btn_change_substring.Size = new System.Drawing.Size(185, 34);
            this.btn_change_substring.TabIndex = 1;
            this.btn_change_substring.Text = "Change the substring";
            this.btn_change_substring.UseVisualStyleBackColor = true;
            // 
            // btn_delete_substring
            // 
            this.btn_delete_substring.Location = new System.Drawing.Point(473, 518);
            this.btn_delete_substring.Name = "btn_delete_substring";
            this.btn_delete_substring.Size = new System.Drawing.Size(271, 34);
            this.btn_delete_substring.TabIndex = 1;
            this.btn_delete_substring.Text = "Delete the substring";
            this.btn_delete_substring.UseVisualStyleBackColor = true;
            // 
            // btn_insert_string
            // 
            this.btn_insert_string.Location = new System.Drawing.Point(473, 576);
            this.btn_insert_string.Name = "btn_insert_string";
            this.btn_insert_string.Size = new System.Drawing.Size(149, 34);
            this.btn_insert_string.TabIndex = 1;
            this.btn_insert_string.Text = "Insert string";
            this.btn_insert_string.UseVisualStyleBackColor = true;
            // 
            // btn_filtered_extraction
            // 
            this.btn_filtered_extraction.Location = new System.Drawing.Point(473, 632);
            this.btn_filtered_extraction.Name = "btn_filtered_extraction";
            this.btn_filtered_extraction.Size = new System.Drawing.Size(149, 34);
            this.btn_filtered_extraction.TabIndex = 1;
            this.btn_filtered_extraction.Text = "Filtered extraction";
            this.btn_filtered_extraction.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(766, 235);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(766, 291);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(766, 344);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 2;
            // 
            // txt_seperation
            // 
            this.txt_seperation.Location = new System.Drawing.Point(766, 409);
            this.txt_seperation.Name = "txt_seperation";
            this.txt_seperation.Size = new System.Drawing.Size(100, 26);
            this.txt_seperation.TabIndex = 2;
            // 
            // btn_num_upper
            // 
            this.btn_num_upper.Location = new System.Drawing.Point(72, 401);
            this.btn_num_upper.Name = "btn_num_upper";
            this.btn_num_upper.Size = new System.Drawing.Size(358, 34);
            this.btn_num_upper.TabIndex = 1;
            this.btn_num_upper.Text = "Number of uppercase";
            this.btn_num_upper.UseVisualStyleBackColor = true;
            this.btn_num_upper.Click += new System.EventHandler(this.btn_num_upper_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(766, 463);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 26);
            this.textBox6.TabIndex = 2;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(766, 518);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 26);
            this.textBox7.TabIndex = 2;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(664, 463);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(80, 26);
            this.textBox8.TabIndex = 2;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(628, 580);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(61, 26);
            this.textBox9.TabIndex = 2;
            // 
            // lbl_position
            // 
            this.lbl_position.AutoSize = true;
            this.lbl_position.Location = new System.Drawing.Point(695, 583);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Size = new System.Drawing.Size(65, 20);
            this.lbl_position.TabIndex = 3;
            this.lbl_position.Text = "Position";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(766, 576);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 26);
            this.textBox10.TabIndex = 2;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(796, 632);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(70, 26);
            this.textBox11.TabIndex = 2;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(674, 632);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(70, 26);
            this.textBox12.TabIndex = 2;
            // 
            // lbl_p1
            // 
            this.lbl_p1.AutoSize = true;
            this.lbl_p1.Location = new System.Drawing.Point(624, 639);
            this.lbl_p1.Name = "lbl_p1";
            this.lbl_p1.Size = new System.Drawing.Size(28, 20);
            this.lbl_p1.TabIndex = 3;
            this.lbl_p1.Text = "P1";
            // 
            // lbl_p2
            // 
            this.lbl_p2.AutoSize = true;
            this.lbl_p2.Location = new System.Drawing.Point(750, 635);
            this.lbl_p2.Name = "lbl_p2";
            this.lbl_p2.Size = new System.Drawing.Size(28, 20);
            this.lbl_p2.TabIndex = 3;
            this.lbl_p2.Text = "P2";
            // 
            // frm_process_chain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 700);
            this.Controls.Add(this.lbl_p2);
            this.Controls.Add(this.lbl_p1);
            this.Controls.Add(this.lbl_position);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txt_seperation);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_chain_optimization);
            this.Controls.Add(this.btn_chain_island);
            this.Controls.Add(this.btn_num_digit);
            this.Controls.Add(this.btn_num_lowercase);
            this.Controls.Add(this.btn_num_upper);
            this.Controls.Add(this.btn_num_capital);
            this.Controls.Add(this.btn_lowercase);
            this.Controls.Add(this.btn_capitally);
            this.Controls.Add(this.btn_filtered_extraction);
            this.Controls.Add(this.btn_insert_string);
            this.Controls.Add(this.btn_delete_substring);
            this.Controls.Add(this.btn_change_substring);
            this.Controls.Add(this.btn_Separation_words);
            this.Controls.Add(this.btn_occurrences);
            this.Controls.Add(this.btn_find_position_last);
            this.Controls.Add(this.btn_find_position_first);
            this.Controls.Add(this.btn_num_char);
            this.Controls.Add(this.grb_output);
            this.Controls.Add(this.grb_input);
            this.Name = "frm_process_chain";
            this.Text = "Process chain ";
            this.grb_input.ResumeLayout(false);
            this.grb_input.PerformLayout();
            this.grb_output.ResumeLayout(false);
            this.grb_output.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_input;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.GroupBox grb_output;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Button btn_num_char;
        private System.Windows.Forms.Button btn_capitally;
        private System.Windows.Forms.Button btn_lowercase;
        private System.Windows.Forms.Button btn_num_capital;
        private System.Windows.Forms.Button btn_num_lowercase;
        private System.Windows.Forms.Button btn_num_digit;
        private System.Windows.Forms.Button btn_chain_island;
        private System.Windows.Forms.Button btn_chain_optimization;
        private System.Windows.Forms.Button btn_find_position_first;
        private System.Windows.Forms.Button btn_find_position_last;
        private System.Windows.Forms.Button btn_occurrences;
        private System.Windows.Forms.Button btn_Separation_words;
        private System.Windows.Forms.Button btn_change_substring;
        private System.Windows.Forms.Button btn_delete_substring;
        private System.Windows.Forms.Button btn_insert_string;
        private System.Windows.Forms.Button btn_filtered_extraction;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txt_seperation;
        private System.Windows.Forms.Button btn_num_upper;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label lbl_position;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label lbl_p1;
        private System.Windows.Forms.Label lbl_p2;
    }
}