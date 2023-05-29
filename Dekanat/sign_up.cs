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
using System.Xml.Schema;

namespace Dekanat
{
    public partial class sign_up : Form
    {

        Student dataBase = new Student();

        public sign_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student dataBase = new Student();
            var login = textBox1.Text;
            var password = textBox2.Text;

            string querystring = $"insert into register(login_user, password_user) values('{login}','{password}')";

            SqlCommand command = new SqlCommand(querystring,dataBase.getConnection());

            dataBase.openConnection();
            if (command.ExecuteNonQuery()==1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех!");
                Form1 frm_login = new Form1();
                this.Hide();
                frm_login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан!");
            }
            dataBase.closeConnection();
        }

        private Boolean checkuser()
        {
            var loginUser = textBox1.Text;
            var passUser = textBox2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
         
            string querystring = $"select id_user, login_user, password_user from register where login_user - '{loginUser}' and password_user - '{passUser}'";
            
            SqlCommand command = new SqlCommand(querystring,dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else
            { return false; }
        
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sign_up_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            pictureBox2.Visible = false;
            textBox1.MaxLength = 50;
            textBox2.MaxLength = 50;
        }
    }
}
