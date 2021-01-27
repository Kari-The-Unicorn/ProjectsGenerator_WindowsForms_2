using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ProjectsGenerator_WindowsForms_2
{
    public partial class OpenProject : Form
    {
        public OpenProject()
        {
            InitializeComponent();
        }

        private void OpenProject_Load(object sender, EventArgs e)
        {
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=|DataDirectory|/db/db.db; version=3");
            string dbQuery = "SELECT * FROM Issues";
            SQLiteCommand dbCommand = new SQLiteCommand(dbQuery, dbConnection);
            DataTable dataTable = new DataTable();
            SQLiteDataAdapter dbAdapter = new SQLiteDataAdapter(dbCommand);
            dbAdapter.Fill(dataTable);
            dgvIssues.DataSource = dataTable;
        }
    }
}
