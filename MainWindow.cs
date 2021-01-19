using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectsGenerator_WindowsForms_2
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1900, 1000);
        }

        private void pLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainWindow_Load(object sender, System.EventArgs e)
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
