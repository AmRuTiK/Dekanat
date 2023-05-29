using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dekanat
{
    public partial class teacher_add : Form
    {
        Student database = new Student();
        public teacher_add()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var lesson = textBox_lesson.Text;
            var fio_t = textBox2.Text;
            var caf= textBox_caf.Text;

            
                var addQuery = $"insert into teacher(lesson, fio_t,caf)values ('{lesson}','{fio_t}','{caf}')";

                var command = new SqlCommand(addQuery, database.getConnection());

                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_lesson.Text = " ";
            textBox2.Text = " ";
            textBox_caf.Text = " ";
        }
    }
}
