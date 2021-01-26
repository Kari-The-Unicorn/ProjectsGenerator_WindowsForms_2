using System;
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

        public void MainWindow_Load(object sender, System.EventArgs e)
        {
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=|DataDirectory|/db/db.db; version=3");
            string dbQuery = "SELECT * FROM Projects";
            SQLiteCommand dbCommand = new SQLiteCommand(dbQuery, dbConnection);
            DataTable dataTable = new DataTable();
            SQLiteDataAdapter dbAdapter = new SQLiteDataAdapter(dbCommand);
            dbAdapter.Fill(dataTable);
            dgvProjects.DataSource = dataTable;
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
                //project = projects.GetSelectedProject();

                //if (project != null)
                //{
                //    ((AddProject)newMdiChildAdd).lblId.Text = project.id.ToString().Trim();
                //    ((AddProject)newMdiChildAdd).tbProjectName.Text = project.ProjectName.Trim();
                //    ((AddProject)newMdiChildAdd).tbProjectAddress.Text = project.ProjectAddress.ToString().Trim();
                //    ((AddProject)newMdiChildAdd).tbProjectCompany.Text = project.ProjectCompany.ToString().Trim();
                //    ((AddProject)newMdiChildAdd).tbProjectState.Text = project.ProjectState.ToString().Trim();
                //    ((AddProject)newMdiChildAdd).dtpProjectCollectionDate.Value = project.ProjectDateIn.Value;
                //    ((AddProject)newMdiChildAdd).dtpProjectCompleteDate.Value = project.ProjectDateOut.Value;
                newMdiChildAdd.ShowDialog();
                //openChildForm(projects);
                //}
            }
            catch
            {
                Close();
            }
        }
        private Form activeForm = null;

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
                string connectionPath = "Data Source=|DataDirectory|/db/db.db; version=3";
                SQLiteConnection connection = new SQLiteConnection(connectionPath);
                connection.Open();
                SQLiteCommand sqlite_cmd = connection.CreateCommand();
                sqlite_cmd.CommandText = $"Select * FROM Projects WHERE id = {id}";
                SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    newMdiChildEdit.tbProjectName.Text = sqlite_datareader.GetString(1);
                    newMdiChildEdit.tbProjectAddress.Text = sqlite_datareader.GetString(2);
                    newMdiChildEdit.tbProjectCompany.Text = sqlite_datareader.GetString(3);
                    newMdiChildEdit.tbProjectState.Text = sqlite_datareader.GetString(4);
                    newMdiChildEdit.dtpProjectCollectionDate.Text = sqlite_datareader.GetString(5);
                    newMdiChildEdit.dtpProjectCompleteDate.Text = sqlite_datareader.GetString(6);
                    newMdiChildEdit.ShowDialog();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Close();
            }
        }
    }
}
