using ProjectsGenerator_WindowsForms_2.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectsGenerator_WindowsForms_2
{
    public partial class OpenProject : Form
    {
        public static List<Issue> issues = new List<Issue>();

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
            dgvIssues.Columns["ImageId"].Visible = false;
            dgvIssues.Columns["IssueCoordinateX"].Visible = false;
            dgvIssues.Columns["IssueCoordinateY"].Visible = false;
        }

        private void dgvIssues_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void bShowMap_Click(object sender, EventArgs e)
        {
            OpenMap newMdiChildMap = new OpenMap();
            try
            {
                Project project = MainWindow.project;
                Picture picture = new Picture();

                string connectionString = "Data Source=|DataDirectory|/db/db.db; version=3";
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
                            picture.PictureWidth = sqlite_datareader3.GetInt32(3);
                            picture.PictureHeight = sqlite_datareader3.GetInt32(4);
                            //pictureContent = sqlite_datareader3.GetFieldValue<byte[]>(2);
                        }
                        sqlite_datareader3.Close();
                    }

                    ((OpenMap)newMdiChildMap).pbMap.Image = Image.FromFile(pictureSrc);
                    ((OpenMap)newMdiChildMap).WindowState = FormWindowState.Normal;
                    ((OpenMap)newMdiChildMap).Size = new Size(picture.PictureWidth + 10, picture.PictureHeight + 10);
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

        private void bLoadIssues_Click(object sender, EventArgs e)
        {
            var connectionString = "Data Source=|DataDirectory|/db/db.db; version=3";
            var project = MainWindow.project;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand sqlite_cmd2 = connection.CreateCommand())
            {
                connection.Open();
                sqlite_cmd2.CommandText = $"Select * FROM Issues where ProjectId = '" + project.id + "'";
                SQLiteDataReader sqlite_datareader2 = sqlite_cmd2.ExecuteReader();

                while (sqlite_datareader2.Read())
                {
                    Issue issue = new Issue();
                    issue.id = sqlite_datareader2.GetInt32(0);
                    issue.IssueName = sqlite_datareader2.GetString(1);
                    issue.ProjectId = sqlite_datareader2.GetInt32(2);
                    issue.IssueDescription = sqlite_datareader2.GetString(3);
                    issue.IssuePlace = sqlite_datareader2.GetString(4);
                    issue.IssueCoordinateX = sqlite_datareader2.GetInt32(5);
                    issue.IssueCoordinateY = sqlite_datareader2.GetInt32(6);
                    issues.Add(issue);
                }
                sqlite_datareader2.Close();
            }

            dgvIssues.DataSource = issues;
            dgvIssues.Refresh();
        }

        private void bShowMap_Paint(object sender, PaintEventArgs e)
        {
            // 3D button style
            ControlPaint.DrawBorder(e.Graphics, bShowMap.ClientRectangle, SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void bLoadIssues_Paint(object sender, PaintEventArgs e)
        {
            // 3D button style
            ControlPaint.DrawBorder(e.Graphics, bLoadIssues.ClientRectangle, SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }
    }
}
