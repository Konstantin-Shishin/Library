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



            string sql = "select idstudent,fn, sn, tn, dateb, tel from student"; // Строка запроса           

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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Students_Load(object sender, EventArgs e)
        {

        }
    }
}
