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
namespace Dekanat
{
    public partial class Student_add : Form
    {
        Student database=new Student();
        public Student_add()
        {
            
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_id.Text = " ";
            textBox_curs.Text = " ";
            textBox_facult.Text=" ";
            textBox_fio.Text=" ";
            textBox_num_student.Text=" ";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            database.openConnection();
            int numstudent;
            var fio = textBox_fio.Text;
            int curs;
            var faculty = textBox_facult.Text;

            if ((int.TryParse(textBox_num_student.Text, out numstudent)) &&( int.TryParse(textBox_curs.Text,out curs)))
            {
                var addQuery = $"insert into st_db(numstudent, fio,curs,faculty)values ('{numstudent}','{fio}','{curs}','{faculty}')";
                
                var command = new SqlCommand(addQuery,database.getConnection());

                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана", "Успех!",MessageBoxButtons.OK,MessageBoxIcon.Information);

            
            }
            else
            {
                MessageBox.Show("Номер студенческого или курс должны быть числами", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            database.closeConnection();
        }
    }
}
