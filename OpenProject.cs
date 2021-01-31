using ProjectsGenerator_WindowsForms_2.Objects;
using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
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
                var project = MainWindow.project;

                var connectionString = "Data Source=|DataDirectory|/db/db.db; version=3";
                using (SQLiteConnection connection2 = new SQLiteConnection(connectionString))
                using (SQLiteCommand sqlite_cmd2 = connection2.CreateCommand())
                {
                    connection2.Open();
                    sqlite_cmd2.CommandText = $"Select * FROM Projects WHERE id = {project.id}";
                    SQLiteDataReader sqlite_datareader2 = sqlite_cmd2.ExecuteReader();

                    if (sqlite_datareader2.Read())
                    {
                        project.ImageId = sqlite_datareader2.GetInt32(7);
                    }
                    sqlite_datareader2.Close();
                }

                var pictureId = project.ImageId;
                var pictureSrc = string.Empty;
                byte[] pictureContent = new byte[0];

                if (project != null && pictureId != null)
                {
                    using (SQLiteConnection connection3 = new SQLiteConnection(connectionString))
                    using (SQLiteCommand sqlite_cmd3 = connection3.CreateCommand())
                    {
                        connection3.Open();
                        sqlite_cmd3.CommandText = $"Select * FROM Pictures WHERE PictureId = {pictureId}";
                        SQLiteDataReader sqlite_datareader3 = sqlite_cmd3.ExecuteReader();

                        if (sqlite_datareader3.Read())
                        {
                            pictureSrc = sqlite_datareader3.GetString(1);
                            pictureContent = sqlite_datareader3.GetFieldValue<byte[]>(2);
                        }
                        sqlite_datareader3.Close();
                    }


                    ((OpenMap) newMdiChildMap).pbMap.Image = System.Drawing.Image.FromFile(pictureSrc);
                    //projectsKonstruktorEntities.Pictures1
                    //    .FirstOrDefault(q => q.PictureId == pictureId1).PictureName.ToString());
                    Byte[] byteBLOBData = (Byte[]) pictureContent;
                    //projectsKonstruktorEntities.Pictures1
                    //    .FirstOrDefault(q => q.PictureId == pictureId1).PictureContent;
                    MemoryStream ms = new MemoryStream(byteBLOBData);
                    ms.Write(byteBLOBData, 0, byteBLOBData.Length);
                    ms.Position = 0;
                    ((OpenMap)newMdiChildMap).pbMap.Image = Image.FromStream(ms);
                    newMdiChildMap.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Close();
            }
        }

        private void tbProjectInfoGeneral_TextChanged(object sender, EventArgs e)
        {
        }

        private void pProjectInfo_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pProjectInfo.DisplayRectangle, Color.LightSkyBlue, ButtonBorderStyle.Solid);
        }
    }
}
