using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ProjectsGenerator_WindowsForms_2.Objects;

namespace ProjectsGenerator_WindowsForms_2
{
    public partial class MainWindow : Form
    {
        public static Project project = new Project();
        public MainWindow()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1900, 1000);
        }

        public void MainWindow_Load(object sender, System.EventArgs e)
        {
            var connectionString = "Data Source=|DataDirectory|/db/db.db; version=3";
            string dbQuery = "SELECT * FROM Projects";

            using (SQLiteConnection dbConnection = new SQLiteConnection(connectionString))
            using (SQLiteCommand dbCommand = new SQLiteCommand(dbQuery, dbConnection))
            {
                dbConnection.Open();
                DataTable dataTable = new DataTable();
                SQLiteDataAdapter dbAdapter = new SQLiteDataAdapter(dbCommand);
                dbAdapter.Fill(dataTable);
                dgvProjects.DataSource = dataTable;
            }
            dgvProjects.Columns["ImageId"].Visible = false;
            dgvProjects.Columns["ProjectName"].HeaderText = "Nazwa";
            dgvProjects.Columns["ProjectAddress"].HeaderText = "Adres";
            dgvProjects.Columns["ProjectCompany"].HeaderText = "Firma";
            dgvProjects.Columns["ProjectState"].HeaderText = "Stan";
            dgvProjects.Columns["ProjectDateIn"].HeaderText = "Od dnia";
            dgvProjects.Columns["ProjectDateOut"].HeaderText = "Do dnia";
            dgvProjects.Columns["ProjectDateIn"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvProjects.Columns["ProjectDateOut"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvProjects.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvProjects.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void bNewProject_Click(object sender, System.EventArgs e)
        {
            MDIChildAddProject(sender, e);
        }

        private void MDIChildAddProject(object sender, EventArgs e)
        {
            AddProject newMdiChildAdd = new AddProject();
            var ind = Application.OpenForms.Count;

            try
            {
                newMdiChildAdd.ShowDialog();
            }
            catch
            {
                Close();
            }
        }

        private void bEditProject_Click(object sender, EventArgs e)
        {
            MDIChildEditProject(sender, e);
        }

        protected void MDIChildEditProject(object sender, System.EventArgs e)
        {
            EditProject newMdiChildEdit = new EditProject();

            try
            {
                var id = 0;
                if (dgvProjects.SelectedRows.Count != 0)
                {
                    DataGridViewRow row = this.dgvProjects.SelectedRows[0];
                    id = int.Parse(row.Cells["id"].Value.ToString());
                }

                var connectionString = "Data Source=|DataDirectory|/db/db.db; version=3";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                using (SQLiteCommand sqlite_cmd = connection.CreateCommand())
                {
                    connection.Open();
                    sqlite_cmd.CommandText = $"Select * FROM Projects WHERE id = {id}";
                    SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
                    
                        if (sqlite_datareader.Read())
                        {
                            newMdiChildEdit.tbProjectName.Text = sqlite_datareader.GetString(1);
                            newMdiChildEdit.tbProjectAddress.Text = sqlite_datareader.GetString(2);
                            newMdiChildEdit.tbProjectCompany.Text = sqlite_datareader.GetString(3);
                            newMdiChildEdit.tbProjectState.Text = sqlite_datareader.GetString(4);
                            newMdiChildEdit.dtpProjectCollectionDate.Text = sqlite_datareader.GetString(5);
                            newMdiChildEdit.dtpProjectCompleteDate.Text = sqlite_datareader.GetString(6);
                            newMdiChildEdit.lblId.Text = id.ToString();
                            sqlite_datareader.Close();
                            newMdiChildEdit.ShowDialog();
                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Close();
            }
        }

        private void bOpenProject_Click(object sender, EventArgs e)
        {
            OpenProject newMdiChildOpen = new OpenProject();

            try
            {
                var id = 0;
                if (dgvProjects.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Zaznacz projekt (cały wiersz na niebiesko)");
                }
                else
                {
                    DataGridViewRow row = this.dgvProjects.SelectedRows[0];
                    id = int.Parse(row.Cells["id"].Value.ToString());
                }
                var connectionString = "Data Source=|DataDirectory|/db/db.db; version=3";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                using (SQLiteCommand sqlite_cmd = connection.CreateCommand())
                {
                    connection.Open();

                    sqlite_cmd.CommandText = $"Select * FROM Projects WHERE id = {id}";
                    SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
                    if (sqlite_datareader.Read())
                    {
                        project.id = sqlite_datareader.GetInt32(0);
                        project.ProjectName = sqlite_datareader.GetString(1);
                        project.ProjectAddress = sqlite_datareader.GetString(2);
                        project.ProjectCompany = sqlite_datareader.GetString(3);
                        project.ProjectState = sqlite_datareader.GetString(4);
                        project.ProjectDateIn = DateTime.Parse(sqlite_datareader.GetString(5));
                        project.ProjectDateOut = DateTime.Parse(sqlite_datareader.GetString(6));
                        newMdiChildOpen.tbProjectInfoGeneral.Text = project.ProjectName + "; " +
                                                                    project.ProjectAddress + "; " +
                                                                    project.ProjectCompany + "; " +
                                                                    project.ProjectState;
                        newMdiChildOpen.tbProjectInfoDateIn.Text = Regex.Replace(project.ProjectDateIn.ToString(),
                        @"\s(.*)", string.Empty, RegexOptions.IgnoreCase);
                        newMdiChildOpen.tbProjectInfoDateOut.Text = Regex.Replace(project.ProjectDateOut.ToString(),
                        @"\s(.*)", string.Empty, RegexOptions.IgnoreCase);
                        sqlite_datareader.Close();
                        newMdiChildOpen.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Close();
            }
        }

        private void bDeleteProject_Click(object sender, EventArgs e)
        {
            try
            {
                var id = 0;
                if (dgvProjects.SelectedRows.Count != 0)
                {
                    DataGridViewRow row = this.dgvProjects.SelectedRows[0];
                    id = int.Parse(row.Cells["id"].Value.ToString());
                }
                var connectionString = "Data Source=|DataDirectory|/db/db.db; version=3";
                
                using (SQLiteConnection connection2 = new SQLiteConnection(connectionString))
                using (SQLiteCommand sqlite_cmd2 = connection2.CreateCommand())
                {
                    connection2.Open();
                    sqlite_cmd2.CommandText = $"Select * FROM Projects WHERE id = {id}";
                    SQLiteDataReader sqlite_datareader2 = sqlite_cmd2.ExecuteReader();

                    if (sqlite_datareader2.Read())
                    {
                        project.ImageId = sqlite_datareader2.GetInt32(7);
                    }
                    sqlite_datareader2.Close();
                }

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                using (SQLiteCommand sqlite_cmd = connection.CreateCommand())
                {
                    connection.Open();

                    sqlite_cmd.CommandText = $"DELETE FROM Projects WHERE id = {id}";
                    sqlite_cmd.ExecuteNonQuery();
                    string dbQuery = "SELECT * FROM Projects";
                    SQLiteCommand dbCommand = new SQLiteCommand(dbQuery, connection);
                    DataTable dataTable = new DataTable();
                    SQLiteDataAdapter dbAdapter = new SQLiteDataAdapter(dbCommand);
                    dbAdapter.Fill(dataTable);
                    dgvProjects.DataSource = dataTable;
                    
                }
                using (SQLiteConnection connection1 = new SQLiteConnection(connectionString))
                using (SQLiteCommand sqlite_cmd1 = connection1.CreateCommand())
                {
                    connection1.Open();
                    sqlite_cmd1.CommandText = $"DELETE FROM Pictures WHERE PictureId = {project.ImageId}";
                    sqlite_cmd1.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Close();
            }
        }

        private void pSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lInfoProjects_Click(object sender, EventArgs e)
        {

        }
    }
}
