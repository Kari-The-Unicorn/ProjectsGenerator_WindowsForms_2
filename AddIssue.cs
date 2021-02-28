using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using ProjectsGenerator_WindowsForms_2.Enums;
using ProjectsGenerator_WindowsForms_2.Objects;

namespace ProjectsGenerator_WindowsForms_2
{
    public partial class AddIssue : Form
    {
        public static OpenProject openProject = new OpenProject();
        public static OpenMap newMdiChildMap = new OpenMap();

        public AddIssue()
        {
            InitializeComponent();
            cbTypes.DataSource = Enum.GetValues(typeof(Types));
        }

        private void bAddIssue_Click(object sender, EventArgs e)
        {
            try
            {
                var project = MainWindow.project;
                var imagePosition = OpenMap.imagePos;

                if (project != null)
                {
                    string issueName = tbIssueName.Text.Trim();
                    int projectId = project.id;
                    string issueDescription = tbIssueDescription.Text.Trim();
                    string issuePlace = tbIssuePlace.Text.Trim();
                    var imageId = project.ImageId;
                    var issueCoordinateX = imagePosition.X - 30;
                    var issueCoordinateY = imagePosition.Y - 30;
                    var isValid = true;
                    var errorMessage = string.Empty;

                    if (string.IsNullOrWhiteSpace(issueName))
                    {
                        isValid = false;
                        errorMessage = "Proszę wpisać nazwę projektu.";
                    }

                    if (isValid)
                    {
                        var issue = new Issue();
                        issue.IssueName = issueName;
                        issue.ProjectId = projectId;
                        issue.IssueDescription = issueDescription;
                        issue.IssuePlace = issuePlace;
                        issue.ImageId = imageId;
                        issue.IssueCoordinateX = issueCoordinateX;
                        issue.IssueCoordinateY = issueCoordinateY;

                        try
                        {
                            var connectionString = "Data Source=|DataDirectory|/db/db.db; version=3";
                            string query = $@"insert into Issues(IssueName, ProjectId, IssueDescription, IssuePlace, ImageId, IssueCoordinateX, IssueCoordinateY)" +
                                           "values('" + issue.IssueName + "','" + issue.ProjectId + "', '" + issue.IssueDescription + "', '" + issue.IssuePlace + "', '" + issue.ImageId + "', '" + issue.IssueCoordinateX + "', '" + issue.IssueCoordinateY + "')";

                            using (SQLiteConnection dbConnection = new SQLiteConnection("Data Source=|DataDirectory|/db/db.db; version=3"))
                            using (SQLiteCommand dbCommand = new SQLiteCommand(query, dbConnection))
                            {
                                dbConnection.Open();
                                dbCommand.ExecuteNonQuery();
                            }

                            MessageBox.Show("Poprawkę dodano pomyślnie.");
                            Close();
                        }
                        catch (Exception exc)
                        {
                            Console.WriteLine(exc.Message);
                            MessageBox.Show("Poprawki nie dodano.");
                        }
                    }
                    else
                    {
                        MessageBox.Show(errorMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pProjectInfoInIssueForm_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pProjectInfoInIssueForm.DisplayRectangle, Color.LightSkyBlue, ButtonBorderStyle.Solid);
        }

        private void bCancelAddingIssue_Click(object sender, EventArgs e)
        {
            for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
            {
                if (Application.OpenForms[index].Name == "OpenMap")
                {
                    //Application.OpenForms[index].Hide(); 
                    Application.OpenForms[index].Refresh();
                    Application.OpenForms[index].Show();
                    //openProject.bShowMap_Click(sender, e);
                }

                else if (Application.OpenForms[index].Name == "AddIssue")
                {
                    Application.OpenForms[index].Hide();
                }
            }
            //var form2 = new OpenMap();
            //form2.OpenMap_Load(sender, e);
            
        }

        private void bCancelAddingIssue_Paint(object sender, PaintEventArgs e)
        {
            // 3D button style
            ControlPaint.DrawBorder(e.Graphics, bCancelAddingIssue.ClientRectangle, SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void bAddIssue_Paint(object sender, PaintEventArgs e)
        {
            // 3D button style
            ControlPaint.DrawBorder(e.Graphics, bAddIssue.ClientRectangle, SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void AddIssue_Load(object sender, EventArgs e)
        {

        }

        private void AddIssue_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
            {
                if (Application.OpenForms[index].Name == "OpenMap")
                {
                    Application.OpenForms[index].Hide();
                }

                else if (Application.OpenForms[index].Name == "AddIssue")
                {
                    Application.OpenForms[index].Hide();
                }
            }
            openProject.bShowMap_Click(sender, e);
        }

        private void lProjectInfoDateInInIssueForm_Click(object sender, EventArgs e)
        {

        }
    }
}