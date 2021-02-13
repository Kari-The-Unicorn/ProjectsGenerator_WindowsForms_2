using ProjectsGenerator_WindowsForms_2.Objects;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace ProjectsGenerator_WindowsForms_2
{
    public partial class OpenMap : Form
    {
        public static Point imagePos = new Point();
        public static List<Issue> issuesOnMap = new List<Issue>();
        public static Issue issue = new Issue();
        private bool isEditMode;
        

        public OpenMap()
        {
            //var picture = AddProject.picture;
            InitializeComponent();
            //this.Size = new Size(picture.PictureWidth, picture.PictureHeight);
            ToolTip tt = new ToolTip();
            tt.SetToolTip(pbMap, "Zaznacz poprawkę na mapie");
            tt.ShowAlways = true;
        }

        public void pbMap_Click(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            AddIssue newMdiChildEdit = new AddIssue();

            try
            {
                var project = MainWindow.project;

                if (project != null)
                {
                    ((AddIssue)newMdiChildEdit).tbProjectInfoGeneralInIssueForm.Text += project.ProjectName.ToString().Trim() + "; ";
                    ((AddIssue)newMdiChildEdit).tbProjectInfoGeneralInIssueForm.Text += project.ProjectAddress.ToString().Trim() + "; ";
                    ((AddIssue)newMdiChildEdit).tbProjectInfoGeneralInIssueForm.Text += project.ProjectCompany.ToString().Trim();
                    ((AddIssue)newMdiChildEdit).tbProjectInfoGeneralInIssueForm.Text += " (" + project.ProjectState.ToString().Trim() + ")";
                    ((AddIssue)newMdiChildEdit).tbProjectInfoDateInInIssueForm.Text += Regex.Replace(project.ProjectDateIn.ToString(),
                        @"\s(.*)", string.Empty, RegexOptions.IgnoreCase);
                    ((AddIssue)newMdiChildEdit).tbProjectInfoDateOutInIssueForm.Text += Regex.Replace(project.ProjectDateOut.ToString(),
                        @"\s(.*)", string.Empty, RegexOptions.IgnoreCase);
                    newMdiChildEdit.ShowDialog();
                }
            }
            catch
            {
                Close();
            }
        }

        private void pbMap_MouseDown(object sender, MouseEventArgs e)
        {
            isEditMode = false;
            issuesOnMap = new List<Issue>();
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
                    issuesOnMap.Add(issue);
                }
                sqlite_datareader2.Close();
            }

            Bitmap bmp = new Bitmap(pbMap.Image);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                {
                    foreach (var issueOnTheMap in issuesOnMap)
                    {
                        if (issueOnTheMap.IssueCoordinateX < e.Location.X &&
                            issueOnTheMap.IssueCoordinateX > e.Location.X - 60 &&
                            issueOnTheMap.IssueCoordinateY < e.Location.Y &&
                            issueOnTheMap.IssueCoordinateY > e.Location.Y - 60)
                        {
                            isEditMode = true;
                            EditIssue newMdiChildEdit = new EditIssue();

                            try
                            {
                                //project = MainWindow.project;
                                var image = AddProject.picture;
                                var imagePos2 = OpenMap.imagePos;

                                if (project != null)
                                {
                                    ((EditIssue)newMdiChildEdit).tbProjectInfoGeneralInIssueForm.Text += project.ProjectName.ToString().Trim() + "; ";
                                    ((EditIssue)newMdiChildEdit).tbProjectInfoGeneralInIssueForm.Text += project.ProjectAddress.ToString().Trim() + "; ";
                                    ((EditIssue)newMdiChildEdit).tbProjectInfoGeneralInIssueForm.Text += project.ProjectCompany.ToString().Trim();
                                    ((EditIssue)newMdiChildEdit).tbProjectInfoGeneralInIssueForm.Text += " (" + project.ProjectState.ToString().Trim() + ")";
                                    ((EditIssue)newMdiChildEdit).tbProjectInfoDateInInIssueForm.Text += Regex.Replace(project.ProjectDateIn.ToString(),
                                            @"\s(.*)", string.Empty, RegexOptions.IgnoreCase);
                                    ((EditIssue)newMdiChildEdit).tbProjectInfoDateOutInIssueForm.Text += Regex.Replace(project.ProjectDateOut.ToString(),
                                        @"\s(.*)", string.Empty, RegexOptions.IgnoreCase);
                                    ((EditIssue)newMdiChildEdit).lId.Text = issueOnTheMap.id.ToString();
                                    ((EditIssue)newMdiChildEdit).tbIssueName.Text = issueOnTheMap.IssueName;
                                    ((EditIssue)newMdiChildEdit).tbIssueDescription.Text = issueOnTheMap.IssueDescription;
                                    ((EditIssue)newMdiChildEdit).tbIssuePlace.Text = issueOnTheMap.IssuePlace;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                            newMdiChildEdit.ShowDialog();
                        }
                    }
                    if (!isEditMode)
                    {
                        imagePos = e.Location;
                        g.DrawImage(new Bitmap(
                            @"C:\Users\karol\source\repos\ProjectsGenerator_WindowsForms_2\Images\redcircle.png"),
                         new Point(imagePos.X - 30, imagePos.Y - 30));
                    }
                    pbMap.Image = bmp;
                }
            }
        }

        public void OpenMap_Load(object sender, EventArgs e)
        {
            List<Issue> issuesOnMap = new List<Issue>();
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
                    issuesOnMap.Add(issue);
                }
                sqlite_datareader2.Close();
            }

            foreach (var issueOnMap in issuesOnMap)
            {
                Bitmap bmp1 = new Bitmap(pbMap.Image);
                using (Graphics g = Graphics.FromImage(bmp1))
                {
                    g.DrawImage(new Bitmap(
                       @"C:\Users\karol\source\repos\ProjectsGenerator_WindowsForms_2\Images\redcircle.png"),
                    new Point((int)issueOnMap.IssueCoordinateX, (int)issueOnMap.IssueCoordinateY));
                    pbMap.Image = bmp1;
                }
            }
        }
    }
}
