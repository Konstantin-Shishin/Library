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
        string bookid;
        string studid;
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
            conn.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Дата выдачи";
            dataGridView1.Columns[2].HeaderText = "Дата возврата";
            dataGridView1.Columns[3].HeaderText = "Комментарий";
            dataGridView1.Columns[4].HeaderText = "Студент";
            dataGridView1.Columns[5].HeaderText = "Книга";

            string sql1 = "select idbook, izd,year,nameb, fn,sn,tn from book B inner join avtor A on(A.idavtor = B.fkavtor)";
            MySqlDataAdapter dataAdapter1 = new MySqlDataAdapter(sql1, conn);
            DataTable dt1 = new DataTable();
            dataAdapter1.Fill(dt1);


            dataGridView2.DataSource = dt1;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].HeaderText = "Издание";
            dataGridView2.Columns[2].HeaderText = "Год";
            dataGridView2.Columns[3].HeaderText = "Название";
            dataGridView2.Columns[4].HeaderText = "Имя";
            dataGridView2.Columns[5].HeaderText = "Отчество";
            dataGridView2.Columns[6].HeaderText = "Фамилия";

            string sql2 = "select idstudent,fn, sn, tn, dateb, tel, adr from student";
            MySqlDataAdapter dataAdapter2 = new MySqlDataAdapter(sql2, conn);
            DataTable dt2 = new DataTable();
            dataAdapter2.Fill(dt2);

            dataGridView3.DataSource = dt2;
            dataGridView3.Columns[0].Visible = false;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.Columns[0].Visible = false;
            dataGridView3.Columns[1].HeaderText = "Имя";
            dataGridView3.Columns[2].HeaderText = "Отчество";
            dataGridView3.Columns[3].HeaderText = "Фамилия";
            dataGridView3.Columns[4].HeaderText = "Дата рождения";
            dataGridView3.Columns[5].HeaderText = "Телефон";
            dataGridView3.Columns[6].HeaderText = "Адрес";


        }

        private void Giveout_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) // book
        {
            bookid=dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            studid=dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
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
            MySqlConnection conn = new MySqlConnection(connStr);
            string sql = "call vidacha(" + studid + "," + bookid + ")"; // Строка запроса           
            conn.Open();
            MySqlDataAdapter dataAdapter2 = new MySqlDataAdapter(sql, conn);
            DataTable dt2 = new DataTable();
            dataAdapter2.Fill(dt2);

        }
    }
}
