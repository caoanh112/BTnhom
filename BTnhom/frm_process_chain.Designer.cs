﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_process_chain));
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
            this.btn_mix_chain = new System.Windows.Forms.Button();
            this.btn_chain_optimization = new System.Windows.Forms.Button();
            this.btn_first_position = new System.Windows.Forms.Button();
            this.btn_find_position_last = new System.Windows.Forms.Button();
            this.btn_occurrences = new System.Windows.Forms.Button();
            this.btn_separate_words = new System.Windows.Forms.Button();
            this.btn_change_substring = new System.Windows.Forms.Button();
            this.btn_delete_substring = new System.Windows.Forms.Button();
            this.btn_insert_string = new System.Windows.Forms.Button();
            this.btn_filtered_extraction = new System.Windows.Forms.Button();
            this.txt_first_position = new System.Windows.Forms.TextBox();
            this.txt_last_position = new System.Windows.Forms.TextBox();
            this.txt_num_occurrences = new System.Windows.Forms.TextBox();
            this.txt_seperation = new System.Windows.Forms.TextBox();
            this.btn_num_upper = new System.Windows.Forms.Button();
            this.txt_new_string = new System.Windows.Forms.TextBox();
            this.txt_del_string = new System.Windows.Forms.TextBox();
            this.txt_replace_string = new System.Windows.Forms.TextBox();
            this.txt_insert = new System.Windows.Forms.TextBox();
            this.lbl_position = new System.Windows.Forms.Label();
            this.txt_insert_position = new System.Windows.Forms.TextBox();
            this.txt_filter_p2 = new System.Windows.Forms.TextBox();
            this.txt_filter_p1 = new System.Windows.Forms.TextBox();
            this.lbl_p1 = new System.Windows.Forms.Label();
            this.lbl_p2 = new System.Windows.Forms.Label();
            this.btn_text_void = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_tile = new System.Windows.Forms.Label();
            this.grb_input.SuspendLayout();
            this.grb_output.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_input
            // 
            this.grb_input.Controls.Add(this.txt_input);
            this.grb_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_input.ForeColor = System.Drawing.Color.White;
            this.grb_input.Location = new System.Drawing.Point(60, 41);
            this.grb_input.Name = "grb_input";
            this.grb_input.Size = new System.Drawing.Size(358, 161);
            this.grb_input.TabIndex = 0;
            this.grb_input.TabStop = false;
            this.grb_input.Text = "Input";
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(6, 23);
            this.txt_input.Multiline = true;
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(346, 132);
            this.txt_input.TabIndex = 0;
            // 
            // grb_output
            // 
            this.grb_output.Controls.Add(this.txt_output);
            this.grb_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_output.ForeColor = System.Drawing.Color.White;
            this.grb_output.Location = new System.Drawing.Point(452, 41);
            this.grb_output.Name = "grb_output";
            this.grb_output.Size = new System.Drawing.Size(393, 161);
            this.grb_output.TabIndex = 30;
            this.grb_output.TabStop = false;
            this.grb_output.Text = "Output";
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(6, 23);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(381, 132);
            this.txt_output.TabIndex = 0;
            // 
            // btn_num_char
            // 
            this.btn_num_char.Location = new System.Drawing.Point(60, 297);
            this.btn_num_char.Name = "btn_num_char";
            this.btn_num_char.Size = new System.Drawing.Size(358, 33);
            this.btn_num_char.TabIndex = 1;
            this.btn_num_char.Text = "Number of char";
            this.btn_num_char.UseVisualStyleBackColor = true;
            this.btn_num_char.Click += new System.EventHandler(this.btn_num_char_Click);
            // 
            // btn_capitally
            // 
            this.btn_capitally.Location = new System.Drawing.Point(60, 347);
            this.btn_capitally.Name = "btn_capitally";
            this.btn_capitally.Size = new System.Drawing.Size(358, 33);
            this.btn_capitally.TabIndex = 2;
            this.btn_capitally.Text = "Uppercase";
            this.btn_capitally.UseVisualStyleBackColor = true;
            this.btn_capitally.Click += new System.EventHandler(this.btn_capitally_Click);
            // 
            // btn_lowercase
            // 
            this.btn_lowercase.Location = new System.Drawing.Point(60, 397);
            this.btn_lowercase.Name = "btn_lowercase";
            this.btn_lowercase.Size = new System.Drawing.Size(358, 33);
            this.btn_lowercase.TabIndex = 3;
            this.btn_lowercase.Text = "Lowercase";
            this.btn_lowercase.UseVisualStyleBackColor = true;
            this.btn_lowercase.Click += new System.EventHandler(this.btn_lowercase_Click);
            // 
            // btn_num_capital
            // 
            this.btn_num_capital.Location = new System.Drawing.Point(60, 497);
            this.btn_num_capital.Name = "btn_num_capital";
            this.btn_num_capital.Size = new System.Drawing.Size(358, 33);
            this.btn_num_capital.TabIndex = 5;
            this.btn_num_capital.Text = "Number of capital ";
            this.btn_num_capital.UseVisualStyleBackColor = true;
            // 
            // btn_num_lowercase
            // 
            this.btn_num_lowercase.Location = new System.Drawing.Point(60, 547);
            this.btn_num_lowercase.Name = "btn_num_lowercase";
            this.btn_num_lowercase.Size = new System.Drawing.Size(358, 33);
            this.btn_num_lowercase.TabIndex = 6;
            this.btn_num_lowercase.Text = "Number of lowercase";
            this.btn_num_lowercase.UseVisualStyleBackColor = true;
            this.btn_num_lowercase.Click += new System.EventHandler(this.btn_num_lowercase_Click);
            // 
            // btn_num_digit
            // 
            this.btn_num_digit.Location = new System.Drawing.Point(60, 597);
            this.btn_num_digit.Name = "btn_num_digit";
            this.btn_num_digit.Size = new System.Drawing.Size(358, 33);
            this.btn_num_digit.TabIndex = 7;
            this.btn_num_digit.Text = "Number of digit ";
            this.btn_num_digit.UseVisualStyleBackColor = true;
            this.btn_num_digit.Click += new System.EventHandler(this.btn_num_digit_Click);
            // 
            // btn_mix_chain
            // 
            this.btn_mix_chain.Location = new System.Drawing.Point(60, 647);
            this.btn_mix_chain.Name = "btn_mix_chain";
            this.btn_mix_chain.Size = new System.Drawing.Size(358, 33);
            this.btn_mix_chain.TabIndex = 8;
            this.btn_mix_chain.Text = "Mix chain";
            this.btn_mix_chain.UseVisualStyleBackColor = true;
            this.btn_mix_chain.Click += new System.EventHandler(this.btn_mix_chain_Click);
            // 
            // btn_chain_optimization
            // 
            this.btn_chain_optimization.Location = new System.Drawing.Point(60, 697);
            this.btn_chain_optimization.Name = "btn_chain_optimization";
            this.btn_chain_optimization.Size = new System.Drawing.Size(358, 33);
            this.btn_chain_optimization.TabIndex = 9;
            this.btn_chain_optimization.Text = "Opimal chain";
            this.btn_chain_optimization.UseVisualStyleBackColor = true;
            this.btn_chain_optimization.Click += new System.EventHandler(this.btn_chain_optimization_Click);
            // 
            // btn_first_position
            // 
            this.btn_first_position.Location = new System.Drawing.Point(452, 297);
            this.btn_first_position.Name = "btn_first_position";
            this.btn_first_position.Size = new System.Drawing.Size(271, 34);
            this.btn_first_position.TabIndex = 11;
            this.btn_first_position.Text = "First appeared position";
            this.btn_first_position.UseVisualStyleBackColor = true;
            this.btn_first_position.Click += new System.EventHandler(this.btn_first_position_Click);
            // 
            // btn_find_position_last
            // 
            this.btn_find_position_last.Location = new System.Drawing.Point(452, 346);
            this.btn_find_position_last.Name = "btn_find_position_last";
            this.btn_find_position_last.Size = new System.Drawing.Size(271, 34);
            this.btn_find_position_last.TabIndex = 13;
            this.btn_find_position_last.Text = "Last appeared position";
            this.btn_find_position_last.UseVisualStyleBackColor = true;
            this.btn_find_position_last.Click += new System.EventHandler(this.btn_find_position_last_Click);
            // 
            // btn_occurrences
            // 
            this.btn_occurrences.Location = new System.Drawing.Point(452, 396);
            this.btn_occurrences.Name = "btn_occurrences";
            this.btn_occurrences.Size = new System.Drawing.Size(271, 34);
            this.btn_occurrences.TabIndex = 15;
            this.btn_occurrences.Text = "Number of appeared ";
            this.btn_occurrences.UseVisualStyleBackColor = true;
            this.btn_occurrences.Click += new System.EventHandler(this.btn_occurrences_Click);
            // 
            // btn_separate_words
            // 
            this.btn_separate_words.Location = new System.Drawing.Point(452, 446);
            this.btn_separate_words.Name = "btn_separate_words";
            this.btn_separate_words.Size = new System.Drawing.Size(271, 34);
            this.btn_separate_words.TabIndex = 17;
            this.btn_separate_words.Text = "Separate words";
            this.btn_separate_words.UseVisualStyleBackColor = true;
            this.btn_separate_words.Click += new System.EventHandler(this.btn_separate_words_Click);
            // 
            // btn_change_substring
            // 
            this.btn_change_substring.Location = new System.Drawing.Point(452, 496);
            this.btn_change_substring.Name = "btn_change_substring";
            this.btn_change_substring.Size = new System.Drawing.Size(185, 34);
            this.btn_change_substring.TabIndex = 20;
            this.btn_change_substring.Text = "Replace substring";
            this.btn_change_substring.UseVisualStyleBackColor = true;
            this.btn_change_substring.Click += new System.EventHandler(this.btn_change_substring_Click);
            // 
            // btn_delete_substring
            // 
            this.btn_delete_substring.Location = new System.Drawing.Point(452, 546);
            this.btn_delete_substring.Name = "btn_delete_substring";
            this.btn_delete_substring.Size = new System.Drawing.Size(271, 34);
            this.btn_delete_substring.TabIndex = 22;
            this.btn_delete_substring.Text = "Delete the substring";
            this.btn_delete_substring.UseVisualStyleBackColor = true;
            this.btn_delete_substring.Click += new System.EventHandler(this.btn_delete_substring_Click);
            // 
            // btn_insert_string
            // 
            this.btn_insert_string.Location = new System.Drawing.Point(452, 596);
            this.btn_insert_string.Name = "btn_insert_string";
            this.btn_insert_string.Size = new System.Drawing.Size(149, 34);
            this.btn_insert_string.TabIndex = 25;
            this.btn_insert_string.Text = "Insert string";
            this.btn_insert_string.UseVisualStyleBackColor = true;
            this.btn_insert_string.Click += new System.EventHandler(this.btn_insert_string_Click);
            // 
            // btn_filtered_extraction
            // 
            this.btn_filtered_extraction.Location = new System.Drawing.Point(452, 646);
            this.btn_filtered_extraction.Name = "btn_filtered_extraction";
            this.btn_filtered_extraction.Size = new System.Drawing.Size(149, 34);
            this.btn_filtered_extraction.TabIndex = 28;
            this.btn_filtered_extraction.Text = "Filtered extraction";
            this.btn_filtered_extraction.UseVisualStyleBackColor = true;
            this.btn_filtered_extraction.Click += new System.EventHandler(this.btn_filtered_extraction_Click);
            // 
            // txt_first_position
            // 
            this.txt_first_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_first_position.Location = new System.Drawing.Point(739, 296);
            this.txt_first_position.Name = "txt_first_position";
            this.txt_first_position.Size = new System.Drawing.Size(100, 30);
            this.txt_first_position.TabIndex = 10;
            // 
            // txt_last_position
            // 
            this.txt_last_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_last_position.Location = new System.Drawing.Point(739, 346);
            this.txt_last_position.Name = "txt_last_position";
            this.txt_last_position.Size = new System.Drawing.Size(100, 30);
            this.txt_last_position.TabIndex = 12;
            // 
            // txt_num_occurrences
            // 
            this.txt_num_occurrences.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num_occurrences.Location = new System.Drawing.Point(739, 396);
            this.txt_num_occurrences.Name = "txt_num_occurrences";
            this.txt_num_occurrences.Size = new System.Drawing.Size(100, 30);
            this.txt_num_occurrences.TabIndex = 14;
            // 
            // txt_seperation
            // 
            this.txt_seperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_seperation.Location = new System.Drawing.Point(739, 446);
            this.txt_seperation.Name = "txt_seperation";
            this.txt_seperation.Size = new System.Drawing.Size(100, 30);
            this.txt_seperation.TabIndex = 16;
            // 
            // btn_num_upper
            // 
            this.btn_num_upper.Location = new System.Drawing.Point(60, 447);
            this.btn_num_upper.Name = "btn_num_upper";
            this.btn_num_upper.Size = new System.Drawing.Size(358, 33);
            this.btn_num_upper.TabIndex = 4;
            this.btn_num_upper.Text = "Number of uppercase";
            this.btn_num_upper.UseVisualStyleBackColor = true;
            this.btn_num_upper.Click += new System.EventHandler(this.btn_num_upper_Click);
            // 
            // txt_new_string
            // 
            this.txt_new_string.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_new_string.Location = new System.Drawing.Point(739, 496);
            this.txt_new_string.Name = "txt_new_string";
            this.txt_new_string.Size = new System.Drawing.Size(100, 30);
            this.txt_new_string.TabIndex = 18;
            // 
            // txt_del_string
            // 
            this.txt_del_string.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_del_string.Location = new System.Drawing.Point(739, 546);
            this.txt_del_string.Name = "txt_del_string";
            this.txt_del_string.Size = new System.Drawing.Size(100, 30);
            this.txt_del_string.TabIndex = 21;
            // 
            // txt_replace_string
            // 
            this.txt_replace_string.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_replace_string.Location = new System.Drawing.Point(643, 496);
            this.txt_replace_string.Name = "txt_replace_string";
            this.txt_replace_string.Size = new System.Drawing.Size(80, 30);
            this.txt_replace_string.TabIndex = 19;
            // 
            // txt_insert
            // 
            this.txt_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_insert.Location = new System.Drawing.Point(611, 600);
            this.txt_insert.Name = "txt_insert";
            this.txt_insert.Size = new System.Drawing.Size(81, 30);
            this.txt_insert.TabIndex = 24;
            // 
            // lbl_position
            // 
            this.lbl_position.AutoSize = true;
            this.lbl_position.Location = new System.Drawing.Point(698, 607);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Size = new System.Drawing.Size(65, 20);
            this.lbl_position.TabIndex = 24;
            this.lbl_position.Text = "Position";
            // 
            // txt_insert_position
            // 
            this.txt_insert_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_insert_position.Location = new System.Drawing.Point(769, 600);
            this.txt_insert_position.Name = "txt_insert_position";
            this.txt_insert_position.Size = new System.Drawing.Size(70, 30);
            this.txt_insert_position.TabIndex = 23;
            this.txt_insert_position.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_insert_position_KeyPress);
            // 
            // txt_filter_p2
            // 
            this.txt_filter_p2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filter_p2.Location = new System.Drawing.Point(769, 650);
            this.txt_filter_p2.Name = "txt_filter_p2";
            this.txt_filter_p2.Size = new System.Drawing.Size(70, 30);
            this.txt_filter_p2.TabIndex = 26;
            this.txt_filter_p2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_filter_p2_KeyPress);
            // 
            // txt_filter_p1
            // 
            this.txt_filter_p1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filter_p1.Location = new System.Drawing.Point(641, 646);
            this.txt_filter_p1.Name = "txt_filter_p1";
            this.txt_filter_p1.Size = new System.Drawing.Size(70, 30);
            this.txt_filter_p1.TabIndex = 27;
            this.txt_filter_p1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_filter_p1_KeyPress);
            // 
            // lbl_p1
            // 
            this.lbl_p1.AutoSize = true;
            this.lbl_p1.Location = new System.Drawing.Point(607, 653);
            this.lbl_p1.Name = "lbl_p1";
            this.lbl_p1.Size = new System.Drawing.Size(28, 20);
            this.lbl_p1.TabIndex = 3;
            this.lbl_p1.Text = "P1";
            // 
            // lbl_p2
            // 
            this.lbl_p2.AutoSize = true;
            this.lbl_p2.Location = new System.Drawing.Point(741, 653);
            this.lbl_p2.Name = "lbl_p2";
            this.lbl_p2.Size = new System.Drawing.Size(28, 20);
            this.lbl_p2.TabIndex = 3;
            this.lbl_p2.Text = "P2";
            // 
            // btn_text_void
            // 
            this.btn_text_void.Location = new System.Drawing.Point(452, 697);
            this.btn_text_void.Name = "btn_text_void";
            this.btn_text_void.Size = new System.Drawing.Size(387, 33);
            this.btn_text_void.TabIndex = 29;
            this.btn_text_void.Text = "Text to void";
            this.btn_text_void.UseVisualStyleBackColor = true;
            this.btn_text_void.Click += new System.EventHandler(this.btn_text_void_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_text_void);
            this.groupBox1.Controls.Add(this.lbl_p2);
            this.groupBox1.Controls.Add(this.lbl_p1);
            this.groupBox1.Controls.Add(this.lbl_position);
            this.groupBox1.Controls.Add(this.txt_insert);
            this.groupBox1.Controls.Add(this.txt_filter_p1);
            this.groupBox1.Controls.Add(this.txt_filter_p2);
            this.groupBox1.Controls.Add(this.txt_insert_position);
            this.groupBox1.Controls.Add(this.txt_del_string);
            this.groupBox1.Controls.Add(this.txt_replace_string);
            this.groupBox1.Controls.Add(this.txt_new_string);
            this.groupBox1.Controls.Add(this.txt_seperation);
            this.groupBox1.Controls.Add(this.txt_num_occurrences);
            this.groupBox1.Controls.Add(this.txt_last_position);
            this.groupBox1.Controls.Add(this.txt_first_position);
            this.groupBox1.Controls.Add(this.btn_chain_optimization);
            this.groupBox1.Controls.Add(this.btn_mix_chain);
            this.groupBox1.Controls.Add(this.btn_num_digit);
            this.groupBox1.Controls.Add(this.btn_num_lowercase);
            this.groupBox1.Controls.Add(this.btn_num_upper);
            this.groupBox1.Controls.Add(this.btn_num_capital);
            this.groupBox1.Controls.Add(this.btn_lowercase);
            this.groupBox1.Controls.Add(this.btn_capitally);
            this.groupBox1.Controls.Add(this.btn_filtered_extraction);
            this.groupBox1.Controls.Add(this.btn_insert_string);
            this.groupBox1.Controls.Add(this.btn_delete_substring);
            this.groupBox1.Controls.Add(this.btn_change_substring);
            this.groupBox1.Controls.Add(this.btn_separate_words);
            this.groupBox1.Controls.Add(this.btn_occurrences);
            this.groupBox1.Controls.Add(this.btn_find_position_last);
            this.groupBox1.Controls.Add(this.btn_first_position);
            this.groupBox1.Controls.Add(this.btn_num_char);
            this.groupBox1.Controls.Add(this.grb_output);
            this.groupBox1.Controls.Add(this.grb_input);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(904, 797);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbl_tile
            // 
            this.lbl_tile.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tile.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_tile.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tile.ForeColor = System.Drawing.Color.White;
            this.lbl_tile.Location = new System.Drawing.Point(0, 0);
            this.lbl_tile.Name = "lbl_tile";
            this.lbl_tile.Size = new System.Drawing.Size(904, 96);
            this.lbl_tile.TabIndex = 6;
            this.lbl_tile.Text = "Chain Process Program";
            this.lbl_tile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_process_chain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 893);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_tile);
            this.DoubleBuffered = true;
            this.Name = "frm_process_chain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process chain ";
            this.Load += new System.EventHandler(this.frm_process_chain_Load);
            this.grb_input.ResumeLayout(false);
            this.grb_input.PerformLayout();
            this.grb_output.ResumeLayout(false);
            this.grb_output.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btn_mix_chain;
        private System.Windows.Forms.Button btn_chain_optimization;
        private System.Windows.Forms.Button btn_first_position;
        private System.Windows.Forms.Button btn_find_position_last;
        private System.Windows.Forms.Button btn_occurrences;
        private System.Windows.Forms.Button btn_separate_words;
        private System.Windows.Forms.Button btn_change_substring;
        private System.Windows.Forms.Button btn_delete_substring;
        private System.Windows.Forms.Button btn_insert_string;
        private System.Windows.Forms.Button btn_filtered_extraction;
        private System.Windows.Forms.TextBox txt_first_position;
        private System.Windows.Forms.TextBox txt_last_position;
        private System.Windows.Forms.TextBox txt_num_occurrences;
        private System.Windows.Forms.TextBox txt_seperation;
        private System.Windows.Forms.Button btn_num_upper;
        private System.Windows.Forms.TextBox txt_new_string;
        private System.Windows.Forms.TextBox txt_del_string;
        private System.Windows.Forms.TextBox txt_replace_string;
        private System.Windows.Forms.TextBox txt_insert;
        private System.Windows.Forms.Label lbl_position;
        private System.Windows.Forms.TextBox txt_insert_position;
        private System.Windows.Forms.TextBox txt_filter_p2;
        private System.Windows.Forms.TextBox txt_filter_p1;
        private System.Windows.Forms.Label lbl_p1;
        private System.Windows.Forms.Label lbl_p2;
        private System.Windows.Forms.Button btn_text_void;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_tile;
    }
}