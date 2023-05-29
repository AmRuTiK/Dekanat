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
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Form1 : Form
    {
        Student database = new Student();

        int selectedRow;
        int selectedRow1;
        Student_add fradd = new Student_add();
        teacher_add frtch= new teacher_add();

        public Form1()
        {
            InitializeComponent();
           

        }

        private void CreateColumns()
        {
          
            dataGridView1.Columns.Add("id_user", "id");
            dataGridView1.Columns.Add("lesson", "lesson");
            dataGridView1.Columns.Add("fio_t", "Фио");
            dataGridView1.Columns.Add("caf", "Кафедра");
            dataGridView1.Columns.Add("IsNew",String.Empty);
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1),record.GetString(2),record.GetString(3), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from teacher";
            

            SqlCommand command = new SqlCommand(queryString, database.getConnection());
            
            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();
            

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);

            }
            reader.Close();
        }
        private void CreateColumns1()
        {
            dataGridView2.Columns.Add("id", "id");
            dataGridView2.Columns.Add("numstudent", "Номер Студенческого");
            dataGridView2.Columns.Add("fio", "Ф.И.О.");
            dataGridView2.Columns.Add("curs", "Курс");
            dataGridView2.Columns.Add("faculty", "Факультет");
            //dataGridView1.Columns.Add("form", "Форма обучения");
            dataGridView2.Columns.Add("IsNew", String.Empty);
        }
        private void ReadSingleRow1(DataGridView dgv, IDataRecord record1)
        {
            dgv.Rows.Add(record1.GetInt32(0), record1.GetInt32(1), record1.GetString(2), record1.GetInt32(3), record1.GetString(4),RowState.ModifiedNew);
        }
        private void RefreshDataGrid1(DataGridView dgv) 
        {
            dgv.Rows.Clear();
            string queryString2 = $"select * from st_db";
            SqlCommand command2 = new SqlCommand(queryString2, database.getConnection());
            database.openConnection();
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                ReadSingleRow1(dgv, reader2);

            }
            reader2.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            CreateColumns1();
            RefreshDataGrid(dataGridView1);
            RefreshDataGrid1(dataGridView2);
        }

        private void button_addStudent_Click(object sender, EventArgs e)
        {
            Student_add frm2 = new Student_add();
            this.Hide();
            frm2.ShowDialog();
            this.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {

               
                DataGridViewRow row = dataGridView2.Rows[selectedRow];
                fradd.ShowDialog();
                fradd.textBox_id.Text = row.Cells[0].Value.ToString();
                fradd.textBox_num_student.Text = row.Cells[1].Value.ToString();
                fradd.textBox_fio.Text = row.Cells[2].Value.ToString();
                fradd.textBox_curs.Text = row.Cells[3].Value.ToString();
                fradd.textBox_facult.Text = row.Cells[4].Value.ToString();
               // fradd.textBox_form.Text = row.Cells[5].Value.ToString();
                

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow1 = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row1 = dataGridView2.Rows[selectedRow1];
                frtch.ShowDialog();
                frtch.textBox_id.Text = row1.Cells[0].Value.ToString();
                frtch.textBox_lesson.Text = row1.Cells[1].Value.ToString();
                frtch.textBox2.Text = row1.Cells[2].Value.ToString();
                frtch.textBox_caf.Text = row1.Cells[3].Value.ToString();
                //frtch.textBox_facult.Text = row.Cells[4].Value.ToString();
                // fradd.textBox_form.Text = row.Cells[5].Value.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RefreshDataGrid1(dataGridView2);
            RefreshDataGrid(dataGridView1);
        }

        private void Search1(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString1 = $"select * from teacher where concat (id_user, lesson, fio_t,caf) like '%" + textBox1.Text + "%'";
        
            SqlCommand com1=new SqlCommand(searchString1,database.getConnection());

            database.openConnection(); 

            SqlDataReader read1= com1.ExecuteReader();

            while (read1.Read())
            {
                ReadSingleRow (dgw,read1 );
            }

            read1.Close();
        }

        private void Search2(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string searchString2 = $"select * from st_db where concat (id, numstudent, fio, curs, faculty) like '%" + textBox1.Text + "%'";

            SqlCommand com2 = new SqlCommand(searchString2, database.getConnection());

            database.openConnection();

            SqlDataReader read2 = com2.ExecuteReader();

            while (read2.Read())
            {
                ReadSingleRow1(dgv, read2);
            }

            read2.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search1(dataGridView1);
            Search2(dataGridView2);
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString()==string.Empty)

            {
                dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;
                return;
            }

            dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;
        }

        private void Update()   
        {
            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count-1; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[4].Value;
                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var id_user = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from teacher where id_user = {id_user}";

                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void deleteRow1()
        {
            int index1 = dataGridView2.CurrentCell.RowIndex;

            dataGridView2.Rows[index1].Visible = false;

            if (dataGridView2.Rows[index1].Cells[0].Value.ToString() == string.Empty)

            {
                dataGridView2.Rows[index1].Cells[5].Value = RowState.Deleted;
                return;
            }

            dataGridView2.Rows[index1].Cells[5].Value = RowState.Deleted;
        }

        private void Update1()
        {
            database.openConnection();

            for (int index1 = 0; index1 < dataGridView2.Rows.Count-1; index1++)
            {
                var rowState1 = (RowState)dataGridView2.Rows[index1].Cells[5].Value;

                if (rowState1 == RowState.Existed)
                    continue;

                if (rowState1 == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView2.Rows[index1].Cells[0].Value);
                    var deleteQuery1 = $"delete from st_db where id = {id}";

                    var command1 = new SqlCommand(deleteQuery1, database.getConnection());
                    command1.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            
            deleteRow1();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
           
            Update1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void button_addTecher_Click(object sender, EventArgs e)
        {
            teacher_add frm_tadd = new teacher_add();
            this.Hide();
            frm_tadd.ShowDialog();
            this.Show();
        }
    }
}
