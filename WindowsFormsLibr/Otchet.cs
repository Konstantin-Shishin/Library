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
    public partial class Otchet : Form
    {
        public Otchet()
        {
            InitializeComponent();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // pisatel
        {

        }

        private void button1_Click(object sender, EventArgs e) //pis
        {
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



            string sql = "select max(total), tn from (select count(*) as total, tn  from journal " +
                "inner join book on(book.idbook = journal.fkbook)" +
                "inner join avtor on(avtor.idavtor = book.fkavtor)" +
                "group by tn) as Result"; // Строка запроса           
            MySqlDataAdapter dataAdapter1 = new MySqlDataAdapter(sql, conn1);
            conn1.Open();
            DataTable dt1 = new DataTable();
            dataAdapter1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
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



            string sql = "select max(total), tn from (select count(*) as total, tn from journal " +
                "inner join student on(student.idstudent = journal.fkstudent) " +
                "group by tn) as Results"; // Строка запроса           
            MySqlDataAdapter dataAdapter1 = new MySqlDataAdapter(sql, conn1);
            conn1.Open();
            DataTable dt1 = new DataTable();
            dataAdapter1.Fill(dt1);
            dataGridView2.DataSource = dt1;
        }
    }
}
