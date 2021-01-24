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
            //MDIChildEditProject(sender, e);
        }

        protected void MDIChildEditProject(object sender, System.EventArgs e)
        {
            //EditProject newMdiChildEdit = new EditProject();

            //try
            //{
            //    project = projects.GetSelectedProject();

            //    if (project != null)
            //    {
            //        ((EditProject)newMdiChildEdit).lblId.Text = project.id.ToString().Trim();
            //        ((EditProject)newMdiChildEdit).tbProjectName.Text = project.ProjectName.Trim();
            //        ((EditProject)newMdiChildEdit).tbProjectAddress.Text = project.ProjectAddress.ToString().Trim();
            //        ((EditProject)newMdiChildEdit).tbProjectCompany.Text = project.ProjectCompany.ToString().Trim();
            //        ((EditProject)newMdiChildEdit).tbProjectState.Text = project.ProjectState.ToString().Trim();
            //        ((EditProject)newMdiChildEdit).dtpProjectCollectionDate.Value = project.ProjectDateIn.Value;
            //        ((EditProject)newMdiChildEdit).dtpProjectCompleteDate.Value = project.ProjectDateOut.Value;
            //        newMdiChildEdit.ShowDialog();
            //        openChildForm(projects);
            //    }
            //}
            //catch
            //{
            //    Close();
            //}
        }



        //public void openChildForm(Form childForm)
        //{
        //    if (activeForm != null)
        //        activeForm.Close();
        //    activeForm = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //    panelChildForm.Controls.Add(childForm);
        //    panelChildForm.Tag = childForm;
        //    childForm.BringToFront();
        //    childForm.Show();
        //}
    }
}
