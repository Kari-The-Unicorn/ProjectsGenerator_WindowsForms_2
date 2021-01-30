using System.Drawing;
using System.Windows.Forms;
using ProjectsGenerator_WindowsForms_2.Objects;

namespace ProjectsGenerator_WindowsForms_2
{
    public partial class EditIssue : Form
    {
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
            //try
            //{
            //    var idBase = int.Parse(lId.Text);
            //    Issue issue = projectsKonstruktorEntities.Issues
            //        .FirstOrDefault(q => q.id == idBase);
            //    projectsKonstruktorEntities.Issues.Remove(issue);
            //    projectsKonstruktorEntities.SaveChanges();
            //    Close();

            //    for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
            //    {
            //        if (Application.OpenForms[index].Name == "OpenMap")
            //        {
            //            Application.OpenForms[index].Hide();
            //        }
            //        else if (Application.OpenForms[index].Name == "EditIssue")
            //        {
            //            Application.OpenForms[index].Hide();
            //        }
            //    }

            //    openProject.bShowMap_Click(sender, e);
            //}
            //catch
            //{
            //    Close();
            //}
        }

        private void bSaveEditingIssue_Click(object sender, System.EventArgs e)
        {
            //try
            //{
            //    var idBase = int.Parse(lId.Text);
            //    Issue issue = projectsKonstruktorEntities.Issues
            //        .FirstOrDefault(q => q.id == idBase);
            //    string issueName = tbIssueName.Text.Trim();
            //    string issueDescription = tbIssueDescription.Text.Trim();
            //    string issuePlace = tbIssuePlace.Text.Trim();

            //    if (issueName != null)
            //    {
            //        issue.IssueName = issueName;
            //        issue.IssueDescription = issueDescription;
            //        issue.IssuePlace = issuePlace;
            //        projectsKonstruktorEntities.SaveChanges();
            //        Close();
            //    }
            //}
            //catch
            //{
            //    Close();
            //}
        }
    }
}
