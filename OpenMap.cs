using ProjectsGenerator_WindowsForms_2.Objects;
using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace ProjectsGenerator_WindowsForms_2
{
    public partial class OpenMap : Form
    {
        private readonly Project project;
        public OpenMap()
        {
            InitializeComponent();
        }

        private void pbMap_Click(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            AddIssue newMdiChildEdit = new AddIssue();
            try
            {
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
    }
}
