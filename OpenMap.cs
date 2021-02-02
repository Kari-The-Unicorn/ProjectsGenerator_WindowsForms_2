using ProjectsGenerator_WindowsForms_2.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace ProjectsGenerator_WindowsForms_2
{
    public partial class OpenMap : Form
    {
        //public Project project;
        public static Point imagePos = new Point();
        private List<Issue> issuesOnMap = new List<Issue>();
        private bool isEditMode;

        public OpenMap()
        {
            InitializeComponent();
            ToolTip tt = new ToolTip();
            tt.SetToolTip(pbMap, "Zaznacz poprawkę na mapie");
            tt.ShowAlways = true;
            //issuesOnMap = projectsKonstruktorEntities.Issues.ToList();
        }

        private void pbMap_Click(object sender, EventArgs e)
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
            //issuesOnMap = projectsKonstruktorEntities.Issues.ToList();
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
                                var project = MainWindow.project;
                                //var project4 = Projects.project;
                                //var pictures1 = Pictures1.;
                                var imagePos2 = OpenMap.imagePos;

                                if (project != null)
                                {
                                    //((EditIssue)newMdiChildEdit).tbProjectInfoGeneralInIssueForm.Text = project4.id.ToString() + "; ";
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
                           @"C:\Users\karol\source\repos\WindowsFormsApp1\images\redcircle.png"),
                        new Point(imagePos.X - 30, imagePos.Y - 30));
                    }
                    pbMap.Image = bmp;
                }
            }
        }
    }
}
