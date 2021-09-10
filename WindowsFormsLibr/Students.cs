using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace WindowsFormsLibr
{
    public partial class Students : Form
    {
        string studid;
        public Students()
        {
            InitializeComponent();
            string serverName = "localhost"; // Адрес сервера (для локальной базы пишите "localhost")
            string userName = "root"; // Имя пользователя
            string dbName = "library"; //Имя базы данных
            string port = "3306"; // Порт для подключения
            string password = "0000"; // Пароль для подключения
            string connStr = "server=" + serverName +
                ";user=" + userName +
                ";database=" + dbName +
                ";port=" + port +
                ";password=" + password + ";";
            MySqlConnection conn = new MySqlConnection(connStr);



            string sql = "select idstudent,fn, sn, tn, dateb, tel, adr from student"; // Строка запроса           

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Отчество";
            dataGridView1.Columns[3].HeaderText = "Фамилия";
            dataGridView1.Columns[4].HeaderText = "Дата рождения";
            dataGridView1.Columns[5].HeaderText = "Телефон";
            dataGridView1.Columns[6].HeaderText = "Адрес";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            studid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void Students_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into student(fn, sn, tn, dateb, tel, adr) " +
                "values(" + "\'" + textBox1.Text + "\'," + "\'" + textBox2.Text + "\'," + "\'" + textBox3.Text + "\'," + "\'" + textBox4.Text + "\'," + "\'" + textBox5.Text + "\'," + "\'" + textBox6.Text + "\'" +  ")";
            string serverName = "localhost"; // Адрес сервера (для локальной базы пишите "localhost")
            string userName = "root"; // Имя пользователя
            string dbName = "library"; //Имя базы данных
            string port = "3306"; // Порт для подключения
            string password = "0000"; // Пароль для подключения
            string connStr = "server=" + serverName +
                ";user=" + userName +
                ";database=" + dbName +
                ";port=" + port +
                ";password=" + password + ";";
            MySqlConnection conn1 = new MySqlConnection(connStr);
            conn1.Open();
            MySqlCommand dataCommand = new MySqlCommand(sql, conn1);
            dataCommand.ExecuteNonQuery();
            conn1.Close();
            groupBox1.Visible = false;
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "delete from student where idavtor =  " + studid;
            string serverName = "localhost"; // Адрес сервера (для локальной базы пишите "localhost")
            string userName = "root"; // Имя пользователя
            string dbName = "library"; //Имя базы данных
            string port = "3306"; // Порт для подключения
            string password = "0000"; // Пароль для подключения
            string connStr = "server=" + serverName +
                ";user=" + userName +
                ";database=" + dbName +
                ";port=" + port +
                ";password=" + password + ";";
            MySqlConnection conn1 = new MySqlConnection(connStr);
            conn1.Open();
            MySqlCommand dataCommand = new MySqlCommand(sql, conn1);
            dataCommand.ExecuteNonQuery();
            conn1.Close();
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "update student set  " +
                "fn=" + "\'" + textBox1.Text + "\', sn=" + "\'" + textBox2.Text + "\', tn=" + "\'" + textBox3.Text + "\', tel=" + "\'" + textBox5.Text + "\',adr=" + "\'" + textBox5.Text + "\'" +   "where idstudent = " + studid;
            string serverName = "localhost"; // Адрес сервера (для локальной базы пишите "localhost")
            string userName = "root"; // Имя пользователя
            string dbName = "library"; //Имя базы данных
            string port = "3306"; // Порт для подключения
            string password = "0000"; // Пароль для подключения
            string connStr = "server=" + serverName +
                ";user=" + userName +
                ";database=" + dbName +
                ";port=" + port +
                ";password=" + password + ";";
            MySqlConnection conn1 = new MySqlConnection(connStr);
            conn1.Open();
            MySqlCommand dataCommand = new MySqlCommand(sql, conn1);
            dataCommand.ExecuteNonQuery();
            conn1.Close();
            dataGridView1.Refresh();
        }
    }
}
