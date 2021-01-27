using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ProjectsGenerator_WindowsForms_2
{
    public partial class EditProject : Form
    {
        public EditProject()
        {
            InitializeComponent();
        }

        private void bCancelEditingProject_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();

            for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
            {
                if (Application.OpenForms[index].Name == "EditProject")
                {
                    Application.OpenForms[index].Hide();
                }
            }
        }

        private void bEditProject_Click(object sender, EventArgs e)
        {
            //projectsKonstruktorEntities.SaveChanges();
            //((Projects)Owner).dgvProjects.Refresh();
            //Projects_Load(sender, e);
            MainWindow mainWindow = new MainWindow();
            //Projects projects = new Projects();
            try
            {
                var idBase = int.Parse(lblId.Text);
                SQLiteConnection dbConnection = new SQLiteConnection("Data Source=|DataDirectory|/db/db.db; version=3");
                dbConnection.Open();
                string query = $@"Select * FROM Projects WHERE id = {idBase}";

                SQLiteCommand dbCommand = new SQLiteCommand(query, dbConnection);
                DataTable dataTable = new DataTable();
                SQLiteDataAdapter dbAdapter = new SQLiteDataAdapter(dbCommand);
                dbAdapter.Fill(dataTable);
                //tbProjectName = dataTable.;

                dbCommand.ExecuteNonQuery();
                dbConnection.Close();

                //Project project = 

                //Project project = projectsKonstruktorEntities.Projects
                // .FirstOrDefault(q => q.id == idBase);
                //if (System.Windows.Forms.Application.OpenForms["EditProject"] != null)
                //{
                //    project = (System.Windows.Forms.Application.OpenForms["EditProject"] as Projects)
                //        .GetSelectedProject();
                //}

                //if (Application.OpenForms["EditProject"] != null)
                //{
                //    project = (Application.OpenForms["EditProject"] as Projects)
                //        .GetSelectedProject();
                //}

                //if (project != null)
                //{
                //    project.ProjectName = tbProjectName.Text;
                //    project.ProjectAddress = tbProjectAddress.Text;
                //    project.ProjectCompany = tbProjectCompany.Text;
                //    project.ProjectState = tbProjectState.Text;
                //    project.ProjectDateIn = dtpProjectCollectionDate.Value;
                //    project.ProjectDateOut = dtpProjectCompleteDate.Value;
                //}

                for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
                {
                    if (Application.OpenForms[index].Name == "EditProject")
                    {
                        Application.OpenForms[index].Hide();
                    }
                }
            }
            catch
            {
                Close();
            }
        }
    }
}
