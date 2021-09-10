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
    
    public partial class Books : Form
    {
        string avtid;

        public Books()
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



            string sql = "select idbook, izd,year,nameb, fn,sn,tn from book B inner join avtor A on(A.idavtor = B.fkavtor)"; // Строка запроса           

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Издание";
            dataGridView1.Columns[2].HeaderText = "Год";
            dataGridView1.Columns[3].HeaderText = "Название";

            dataGridView1.Columns[4].HeaderText = "Имя";
            dataGridView1.Columns[5].HeaderText = "Отчество";
            dataGridView1.Columns[6].HeaderText = "Фамилия";

        }

        private void Books_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

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



            string sql = "SELECT * FROM avtor "; // Строка запроса           

            MySqlDataAdapter dataAdapter1 = new MySqlDataAdapter(sql, conn1);
            conn1.Open();
            DataTable dt1 = new DataTable();
            dataAdapter1.Fill(dt1);
            dataGridView2.DataSource = dt1;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].HeaderText = "Имя";
            dataGridView2.Columns[2].HeaderText = "Отчество";
            dataGridView2.Columns[3].HeaderText = "Фамилия";
            dataGridView2.Columns[4].HeaderText = "Дата рождения";
            dataGridView2.Columns[5].HeaderText = "Страна";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            avtid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            avtid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string sql = "insert into book(nameb, izd, year, fkavtor) " +
                "values("+"\'"+ textBox1.Text + "\'," + "\'" + textBox2.Text + "\',"  + textBox3.Text +","+  avtid+ ")";
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
    }
}
