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
    public partial class Giveout : Form
    {
        public Giveout()
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



            string sql = "select idjournal, datevyd, datevoz, comm, tn, nameb from journal " +
                "inner join book on(book.idbook= journal.fkbook) " + 
                "inner join student on(student.idstudent= journal.fkstudent) order by tn"; // Строка запроса           

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Дата Возврата";
            dataGridView1.Columns[2].HeaderText = "Дата выдачи";
            dataGridView1.Columns[3].HeaderText = "Комментарий";
            dataGridView1.Columns[4].HeaderText = "Студент";
            dataGridView1.Columns[5].HeaderText = "Книга";

        }

        private void Giveout_Load(object sender, EventArgs e)
        {

        }

    }
}
