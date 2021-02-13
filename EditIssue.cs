using ProjectsGenerator_WindowsForms_2.Objects;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectsGenerator_WindowsForms_2
{
    public partial class EditIssue : Form
    {
        public OpenMap openMap = new OpenMap();
        public OpenProject openProject = new OpenProject();
        public static List<Issue> issuesOnMap = new List<Issue>();

        public EditIssue()
        {
            InitializeComponent();
        }

        private void pProjectInfoInIssueForm_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pProjectInfoInIssueForm.DisplayRectangle, Color.LightSkyBlue, ButtonBorderStyle.Solid);
        }

        private void bCancelAddingIssue_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void bDeleteIssue_Click(object sender, System.EventArgs e)
        {
            try
            {
                var idBase = int.Parse(lId.Text);
                var connectionString = "Data Source=|DataDirectory|/db/db.db; version=3";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                using (SQLiteCommand sqlite_cmd = connection.CreateCommand())
                {
                    connection.Open();

                    sqlite_cmd.CommandText = $"DELETE FROM Issues WHERE id = {idBase}";
                    sqlite_cmd.ExecuteNonQuery();
                    sqlite_cmd.CommandText = $"Select * FROM Issues";
                    SQLiteDataReader sqlite_datareader2 = sqlite_cmd.ExecuteReader();

                    while (sqlite_datareader2.Read())
                    {
                        Issue issue = new Issue();
                        issue.id = sqlite_datareader2.GetInt32(0);
                        issue.IssueName = sqlite_datareader2.GetString(1);
                        issue.ProjectId = sqlite_datareader2.GetInt32(2);
                        issue.IssueDescription = sqlite_datareader2.GetString(3);
                        issue.IssuePlace = sqlite_datareader2.GetString(4);
                        issue.IssueCoordinateX = sqlite_datareader2.GetInt32(5);
                        issue.IssueCoordinateX = sqlite_datareader2.GetInt32(6);
                        issuesOnMap.Add(issue);
                    }
                    sqlite_datareader2.Close();
                }
                Close();

                for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
                {
                    if (Application.OpenForms[index].Name == "OpenMap")
                    {
                        Application.OpenForms[index].Hide();
                    }
                    else if (Application.OpenForms[index].Name == "EditIssue")
                    {
                        Application.OpenForms[index].Hide();
                    }
                }
                //openMap.OpenMap_Load(sender, e);
                openProject.bShowMap_Click(sender, e);
            }
            catch
            {
                Close();
            }
        }

        private void bSaveEditingIssue_Click(object sender, System.EventArgs e)
        {
            try
            {
                var idBase = int.Parse(lId.Text);
                Issue issue = new Issue();
                var connectionString = "Data Source=|DataDirectory|/db/db.db; version=3";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                using (SQLiteCommand sqlite_cmd = connection.CreateCommand())
                {
                    connection.Open();
                    sqlite_cmd.CommandText = $"Select * FROM Issues WHERE id = {idBase}";
                    SQLiteDataReader sqlite_datareader2 = sqlite_cmd.ExecuteReader();

                    while (sqlite_datareader2.Read())
                    {
                        issue.id = sqlite_datareader2.GetInt32(0);
                        issue.IssueName = sqlite_datareader2.GetString(1);
                        issue.ProjectId = sqlite_datareader2.GetInt32(2);
                        issue.IssueDescription = sqlite_datareader2.GetString(3);
                        issue.IssuePlace = sqlite_datareader2.GetString(4);
                        issue.IssueCoordinateX = sqlite_datareader2.GetInt32(5);
                        issue.IssueCoordinateY = sqlite_datareader2.GetInt32(6);
                    }
                    sqlite_datareader2.Close();
                }

                string issueName = tbIssueName.Text.Trim();
                string issueDescription = tbIssueDescription.Text.Trim();
                string issuePlace = tbIssuePlace.Text.Trim();

                if (issueName != null)
                {
                    issue.IssueName = issueName;
                    issue.IssueDescription = issueDescription;
                    issue.IssuePlace = issuePlace;
                    string dbQuery = $@"UPDATE Issues SET IssueName = '{issue.IssueName}', IssueDescription = '{issue.IssueDescription}', IssuePlace = '{issue.IssuePlace}' WHERE id = {idBase}";

                    using (SQLiteConnection dbConnection = new SQLiteConnection("Data Source=|DataDirectory|/db/db.db; version=3"))
                    using (SQLiteCommand dbCommand = new SQLiteCommand(dbQuery, dbConnection))
                    {
                        dbConnection.Open();
                        dbCommand.ExecuteNonQuery();
                    }
                    Close();
                }
            }
            catch
            {
                Close();
            }
        }

        private void bCancelAddingIssue_Paint(object sender, PaintEventArgs e)
        {
            // 3D button style
            ControlPaint.DrawBorder(e.Graphics, bCancelAddingIssue.ClientRectangle, SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void bDeleteIssue_Paint(object sender, PaintEventArgs e)
        {
            // 3D button style
            ControlPaint.DrawBorder(e.Graphics, bDeleteIssue.ClientRectangle, SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void bSaveEditingIssue_Paint(object sender, PaintEventArgs e)
        {
            // 3D button style
            ControlPaint.DrawBorder(e.Graphics, bSaveEditingIssue.ClientRectangle, SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void EditIssue_Load(object sender, System.EventArgs e)
        {

        }
    }
}
