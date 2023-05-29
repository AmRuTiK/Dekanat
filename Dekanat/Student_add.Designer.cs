namespace Dekanat
{
    partial class Student_add
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_facult = new System.Windows.Forms.TextBox();
            this.textBox_curs = new System.Windows.Forms.TextBox();
            this.textBox_fio = new System.Windows.Forms.TextBox();
            this.textBox_num_student = new System.Windows.Forms.TextBox();
            this.facult = new System.Windows.Forms.Label();
            this.curs = new System.Windows.Forms.Label();
            this.fio = new System.Windows.Forms.Label();
            this.num_student = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.Controls.Add(this.textBox_facult);
            this.panel1.Controls.Add(this.textBox_curs);
            this.panel1.Controls.Add(this.textBox_fio);
            this.panel1.Controls.Add(this.textBox_num_student);
            this.panel1.Controls.Add(this.facult);
            this.panel1.Controls.Add(this.curs);
            this.panel1.Controls.Add(this.fio);
            this.panel1.Controls.Add(this.num_student);
            this.panel1.Location = new System.Drawing.Point(44, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 232);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "id";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(155, 37);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 22);
            this.textBox_id.TabIndex = 12;
            // 
            // textBox_facult
            // 
            this.textBox_facult.Location = new System.Drawing.Point(155, 153);
            this.textBox_facult.Name = "textBox_facult";
            this.textBox_facult.Size = new System.Drawing.Size(100, 22);
            this.textBox_facult.TabIndex = 9;
            // 
            // textBox_curs
            // 
            this.textBox_curs.Location = new System.Drawing.Point(155, 122);
            this.textBox_curs.Name = "textBox_curs";
            this.textBox_curs.Size = new System.Drawing.Size(100, 22);
            this.textBox_curs.TabIndex = 8;
            // 
            // textBox_fio
            // 
            this.textBox_fio.Location = new System.Drawing.Point(155, 94);
            this.textBox_fio.Name = "textBox_fio";
            this.textBox_fio.Size = new System.Drawing.Size(100, 22);
            this.textBox_fio.TabIndex = 7;
            // 
            // textBox_num_student
            // 
            this.textBox_num_student.Location = new System.Drawing.Point(155, 65);
            this.textBox_num_student.Name = "textBox_num_student";
            this.textBox_num_student.Size = new System.Drawing.Size(100, 22);
            this.textBox_num_student.TabIndex = 6;
            // 
            // facult
            // 
            this.facult.AutoSize = true;
            this.facult.Location = new System.Drawing.Point(10, 159);
            this.facult.Name = "facult";
            this.facult.Size = new System.Drawing.Size(78, 16);
            this.facult.TabIndex = 3;
            this.facult.Text = "Факультет";
            // 
            // curs
            // 
            this.curs.AutoSize = true;
            this.curs.Location = new System.Drawing.Point(10, 128);
            this.curs.Name = "curs";
            this.curs.Size = new System.Drawing.Size(38, 16);
            this.curs.TabIndex = 2;
            this.curs.Text = "Курс";
            // 
            // fio
            // 
            this.fio.AutoSize = true;
            this.fio.Location = new System.Drawing.Point(10, 101);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(47, 16);
            this.fio.TabIndex = 1;
            this.fio.Text = "Ф.И.О.";
            // 
            // num_student
            // 
            this.num_student.AutoSize = true;
            this.num_student.Location = new System.Drawing.Point(10, 71);
            this.num_student.Name = "num_student";
            this.num_student.Size = new System.Drawing.Size(101, 16);
            this.num_student.TabIndex = 0;
            this.num_student.Text = "Студенческий";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(370, 283);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(87, 41);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(370, 227);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(87, 41);
            this.button_clear.TabIndex = 3;
            this.button_clear.Text = "Очистить";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // Student_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.panel1);
            this.Name = "Student_add";
            this.Text = "Student_add";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label facult;
        private System.Windows.Forms.Label curs;
        private System.Windows.Forms.Label fio;
        private System.Windows.Forms.Label num_student;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_clear;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox textBox_facult;
        public System.Windows.Forms.TextBox textBox_curs;
        public System.Windows.Forms.TextBox textBox_fio;
        public System.Windows.Forms.TextBox textBox_num_student;
        public System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
    }
}