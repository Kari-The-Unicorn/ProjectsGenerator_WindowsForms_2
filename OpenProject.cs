using ProjectsGenerator_WindowsForms_2.Objects;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ProjectsGenerator_WindowsForms_2
{
    public partial class OpenProject : Form
    {
        public Project project;
        public OpenProject()
        {
            InitializeComponent();
        }

        private void OpenProject_Load(object sender, EventArgs e)
        {

            string dbQuery = "SELECT * FROM Issues";

            using (SQLiteConnection dbConnection = new SQLiteConnection("Data Source=|DataDirectory|/db/db.db; version=3"))
            using (SQLiteCommand dbCommand = new SQLiteCommand(dbQuery, dbConnection))
            {
                dbConnection.Open();
                DataTable dataTable = new DataTable();
                SQLiteDataAdapter dbAdapter = new SQLiteDataAdapter(dbCommand);
                dbAdapter.Fill(dataTable);
                dbConnection.Close();
                dgvIssues.DataSource = dataTable;
            }
            dgvIssues.Columns["IssueName"].HeaderText = "Nazwa poprawki";
            dgvIssues.Columns["IssueDescription"].HeaderText = "Opis";
            dgvIssues.Columns["IssuePlace"].HeaderText = "Lokalizacja";
            dgvIssues.Columns["id"].Visible = false;
            dgvIssues.Columns["ProjectId"].Visible = false;
            dgvIssues.Columns["IssueCoordinateX"].Visible = false;
            dgvIssues.Columns["IssueCoordinateY"].Visible = false;
        }

        private void dgvIssues_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bShowMap_Click(object sender, EventArgs e)
        {
            OpenMap newMdiChildMap = new OpenMap();
            try
            {
                var project1 = MainWindow.project;

                var pictureId1 = project1.ImageId;

                if (project1 != null && pictureId1 != null)
                {
                    //((OpenMap)newMdiChildMap).pbMap.Image = System.Drawing.Image.FromFile(projectsKonstruktorEntities.Pictures1
                    //    .FirstOrDefault(q => q.PictureId == pictureId1).PictureName.ToString());
                    //Byte[] byteBLOBData = (Byte[])projectsKonstruktorEntities.Pictures1
                    //    .FirstOrDefault(q => q.PictureId == pictureId1).PictureContent;
                    //MemoryStream ms = new MemoryStream(byteBLOBData);
                    //ms.Write(byteBLOBData, 0, byteBLOBData.Length);
                    //ms.Position = 0;
                    //((OpenMap)newMdiChildMap).pbMap.Image = Image.FromStream(ms);
                    //newMdiChildMap.ShowDialog();
                }
            }
            catch
            {
                Close();
            }
        }

        private void tbProjectInfoGeneral_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
