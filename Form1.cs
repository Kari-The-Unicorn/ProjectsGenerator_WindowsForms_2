using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Constructor_WinForms_SqlLite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=|DataDirectory|/db/db.db; version=3");

            //if (!File.Exists("./db.db"))
            //{
            //    SQLiteConnection.CreateFile("db.db");
            //}

            string dbQuery = "SELECT * FROM Projects";
            SQLiteCommand dbCommand = new SQLiteCommand(dbQuery, dbConnection);
            DataTable dataTable = new DataTable();
            SQLiteDataAdapter dbAdapter = new SQLiteDataAdapter(dbCommand);
            dbAdapter.Fill(dataTable);
            dgvProjects.DataSource = dataTable;
        }
    }
}
