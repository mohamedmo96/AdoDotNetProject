namespace lap_AdoDotNetday1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_co = new TextBox();
            dgv_Course = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            btn_add = new Button();
            btn_edit = new Button();
            btn_del = new Button();
            cm_To = new ComboBox();
            num_du = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgv_Course).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_du).BeginInit();
            SuspendLayout();
            // 
            // txt_co
            // 
            txt_co.Location = new Point(378, 38);
            txt_co.Name = "txt_co";
            txt_co.Size = new Size(125, 27);
            txt_co.TabIndex = 0;
            // 
            // dgv_Course
            // 
            dgv_Course.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Course.Location = new Point(12, 247);
            dgv_Course.Name = "dgv_Course";
            dgv_Course.RowHeadersWidth = 51;
            dgv_Course.RowTemplate.Height = 29;
            dgv_Course.Size = new Size(776, 191);
            dgv_Course.TabIndex = 4;
            dgv_Course.RowHeaderMouseDoubleClick += dgv_Course_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 38);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 5;
            label1.Text = "Course Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 147);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 6;
            label2.Text = " Duration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(518, 140);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 9;
            label4.Text = "Topic";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(217, 211);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 10;
            btn_add.Text = "Add Course";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(343, 211);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(94, 29);
            btn_edit.TabIndex = 11;
            btn_edit.Text = "Edit Course";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_del
            // 
            btn_del.Location = new Point(469, 211);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(94, 29);
            btn_del.TabIndex = 12;
            btn_del.Text = "Delete";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // cm_To
            // 
            cm_To.FormattingEnabled = true;
            cm_To.Location = new Point(580, 137);
            cm_To.Name = "cm_To";
            cm_To.Size = new Size(151, 28);
            cm_To.TabIndex = 13;
            // 
            // num_du
            // 
            num_du.Location = new Point(161, 145);
            num_du.Name = "num_du";
            num_du.Size = new Size(150, 27);
            num_du.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(num_du);
            Controls.Add(cm_To);
            Controls.Add(btn_del);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_Course);
            Controls.Add(txt_co);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_load;
            ((System.ComponentModel.ISupportInitialize)dgv_Course).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_du).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_co;
        private DataGridView dgv_Course;
        private Label label1;
        private Label label2;
        private Label label4;
        private Button btn_add;
        private Button btn_edit;
        private Button btn_del;
        private ComboBox cm_To;
        private NumericUpDown num_du;
    }
}