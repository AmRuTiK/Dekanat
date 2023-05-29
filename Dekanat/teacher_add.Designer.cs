namespace Dekanat
{
    partial class teacher_add
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
            this.label_caf = new System.Windows.Forms.Label();
            this.labelfio = new System.Windows.Forms.Label();
            this.label_less = new System.Windows.Forms.Label();
            this.textBox_caf = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox_lesson = new System.Windows.Forms.TextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.Controls.Add(this.label_caf);
            this.panel1.Controls.Add(this.labelfio);
            this.panel1.Controls.Add(this.label_less);
            this.panel1.Controls.Add(this.textBox_caf);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox_lesson);
            this.panel1.Location = new System.Drawing.Point(50, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 241);
            this.panel1.TabIndex = 0;
            // 
            // label_caf
            // 
            this.label_caf.AutoSize = true;
            this.label_caf.Location = new System.Drawing.Point(28, 127);
            this.label_caf.Name = "label_caf";
            this.label_caf.Size = new System.Drawing.Size(66, 16);
            this.label_caf.TabIndex = 5;
            this.label_caf.Text = "Кафедра";
            // 
            // labelfio
            // 
            this.labelfio.AutoSize = true;
            this.labelfio.Location = new System.Drawing.Point(28, 86);
            this.labelfio.Name = "labelfio";
            this.labelfio.Size = new System.Drawing.Size(47, 16);
            this.labelfio.TabIndex = 4;
            this.labelfio.Text = "Ф.И.О.";
            // 
            // label_less
            // 
            this.label_less.AutoSize = true;
            this.label_less.Location = new System.Drawing.Point(28, 41);
            this.label_less.Name = "label_less";
            this.label_less.Size = new System.Drawing.Size(39, 16);
            this.label_less.TabIndex = 3;
            this.label_less.Text = "Урок";
            // 
            // textBox_caf
            // 
            this.textBox_caf.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_caf.Location = new System.Drawing.Point(132, 127);
            this.textBox_caf.Name = "textBox_caf";
            this.textBox_caf.Size = new System.Drawing.Size(100, 22);
            this.textBox_caf.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_lesson
            // 
            this.textBox_lesson.Location = new System.Drawing.Point(132, 41);
            this.textBox_lesson.Name = "textBox_lesson";
            this.textBox_lesson.Size = new System.Drawing.Size(100, 22);
            this.textBox_lesson.TabIndex = 0;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(353, 227);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(87, 41);
            this.button_clear.TabIndex = 1;
            this.button_clear.Text = "Очистить";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(353, 274);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(87, 41);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(132, 13);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 22);
            this.textBox_id.TabIndex = 6;
            // 
            // teacher_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.panel1);
            this.Name = "teacher_add";
            this.Text = "teacher_add";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_caf;
        private System.Windows.Forms.Label labelfio;
        private System.Windows.Forms.Label label_less;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_add;
        public System.Windows.Forms.TextBox textBox_caf;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox_lesson;
        public System.Windows.Forms.TextBox textBox_id;
    }
}