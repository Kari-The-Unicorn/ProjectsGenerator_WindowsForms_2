﻿using ProjectsGenerator_WindowsForms_2.Objects;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectsGenerator_WindowsForms_2
{
    public partial class AddIssue : Form
    {
        public static OpenProject openProject = new OpenProject();
        public static OpenMap newMdiChildMap = new OpenMap();

        public AddIssue()
        {
            InitializeComponent();
        }

        private void bAddIssue_Click(object sender, EventArgs e)
        {
            try
            {
                var project = MainWindow.project;
                //var project3 = Projects.project;
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
                        //var projectsKonstruktorEntities = new ProjectsKonstruktorEntities();
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
                            //projectsKonstruktorEntities.Issues.Add(issue);
                            //projectsKonstruktorEntities.SaveChanges();
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
                    Application.OpenForms[index].Hide();
                }

                else if (Application.OpenForms[index].Name == "AddIssue")
                {
                    Application.OpenForms[index].Hide();
                }
            }
            //var form2 = new OpenMap();
            //form2.OpenMap_Load(sender, e);
            //openProject.bShowMap_Click(sender, e);
        }
    }
}

