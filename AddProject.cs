using ProjectsGenerator_WindowsForms_2.Objects;
using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProjectsGenerator_WindowsForms_2
{
    public partial class AddProject : Form
    {
        public static Picture picture = new Picture();
        private OpenFileDialog openFile;
        private string fileName;
        private string safeFileName;
        public AddProject()
        {
            InitializeComponent();
        }

        private void bAddProject_Click(object sender, EventArgs e)
        {
            try
            {
                string projectName = tbProjectName.Text.Trim();
                string projectAddress = tbProjectAddress.Text.Trim();
                string projectCompany = tbProjectCompany.Text.Trim();
                string projectState = tbProjectState.Text.Trim();
                var projectDateIn = dtpProjectCollectionDate.Value;
                var projectDateOut = dtpProjectCompleteDate.Value;
                var isValid = true;
                var errorMessage = string.Empty;

                if (string.IsNullOrWhiteSpace(projectName))
                {
                    isValid = false;
                    errorMessage = "Proszę wpisać nazwę projektu.";
                }

                if (projectDateIn > projectDateOut)
                {
                    isValid = false;
                    errorMessage = "Data rozpoczęcia nie może być późniejsza niż data ukończenia.";
                }

                if (fileName == null)
                {
                    isValid = false;
                    errorMessage = "Proszę załączyć plik PDF.";
                }

                if (isValid)
                {
                    MainWindow window = new MainWindow();
                    var project = new Project();
                    var picture = new Picture();
                    project.ProjectName = projectName.Trim();
                    project.ProjectAddress = projectAddress.Trim();
                    project.ProjectCompany = projectCompany.Trim();
                    project.ProjectState = projectState.Trim();
                    project.ProjectDateIn = projectDateIn;
                    project.ProjectDateOut = projectDateOut;
                    Image imageContent = new Bitmap(fileName);
                    picture.PictureName = fileName.Trim();
                    //project.ImageId = picture.PictureId;
                    picture.PictureContent = ConvertImageToByteArray(imageContent);
                    byte[] pictureContent = picture.PictureContent;
                    Image img = Image.FromFile(picture.PictureName);
                    picture.PictureWidth = img.Width;
                    picture.PictureHeight = img.Height;
                    //Copy file to destination
                    var destinationPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory) + @"Images\UsersImages\" + safeFileName;
                    File.Copy(fileName, destinationPath, true);
                    picture.PictureName = destinationPath;

                    try
                    {
                        string query = $@"insert into Projects(ProjectName, ProjectAddress, ProjectCompany, ProjectState, ProjectDateIn, ProjectDateOut, ImageId)" +
                                       "values('" + project.ProjectName + "','" + project.ProjectAddress + "', '" + project.ProjectCompany + "', '" + project.ProjectState + "', '" + project.ProjectDateIn + "', '" + project.ProjectDateOut + "', '" + project.ImageId + "'); insert into Pictures(PictureName, PictureContent, PictureWidth, PictureHeight)" +
                                       "values('" + picture.PictureName + "', '" + pictureContent + "', '" + picture.PictureWidth + "', '" + picture.PictureHeight + "')";

                        using (SQLiteConnection dbConnection = new SQLiteConnection("Data Source=|DataDirectory|/db/db.db; version=3"))
                        using (SQLiteCommand dbCommand = new SQLiteCommand(query, dbConnection))
                        {
                            dbConnection.Open();
                            dbCommand.ExecuteNonQuery();
                        }

                        string query2 = $@"SELECT * FROM Pictures ORDER BY PictureId DESC LIMIT 1";

                        using (SQLiteConnection dbConnection2 = new SQLiteConnection("Data Source=|DataDirectory|/db/db.db; version=3"))
                        {
                            using (SQLiteCommand dbCommand2 = new SQLiteCommand(query2, dbConnection2))
                            {
                                dbConnection2.Open();
                                dbCommand2.ExecuteNonQuery();
                                using (SQLiteCommand sqlite_cmd = dbConnection2.CreateCommand())
                                {
                                    sqlite_cmd.CommandText = query2;
                                    SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();

                                    if (sqlite_datareader.Read())
                                    {
                                        picture.PictureId = sqlite_datareader.GetInt32(0);
                                        project.ImageId = picture.PictureId;
                                    }
                                    sqlite_datareader.Close();
                                }
                            }
                            string query3 = $@"UPDATE Projects SET ImageId = '{picture.PictureId}' WHERE ProjectName = '" + project.ProjectName + "'";

                            using (SQLiteCommand dbCommand3 = new SQLiteCommand(query3, dbConnection2))
                            {
                                dbCommand3.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Projekt dodano pomyślnie.");
                        MainWindow mainWindow = (MainWindow)Application.OpenForms["MainWindow"];
                        if (mainWindow != null)
                        {
                            mainWindow.MainWindow_Load(sender, e);
                            mainWindow.dgvProjects.Update();
                            mainWindow.dgvProjects.Refresh();
                        }
                        for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
                        {
                            if (Application.OpenForms[index].Name == "Projects")
                            {
                                Application.OpenForms[index].Hide();
                                Application.OpenForms[index].Show();
                            }

                            else if (Application.OpenForms[index].Name == "AddProject")
                            {
                                Application.OpenForms[index].Hide();
                            }
                        }
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine(exc.Message);
                        MessageBox.Show("Projektu nie dodano.");
                    }
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Upload file";
            openFile.Filter = "JPG|*.jpg";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Kliknij OK żeby potwierdzić plik: " + openFile.SafeFileName + ".");
                if (openFile.FileName != null)
                {
                    lLoadedImageInfo.Text = "Wybrany plik: " + openFile.SafeFileName;
                    fileName = openFile.FileName;
                    safeFileName = openFile.SafeFileName;
                }
            }
        }
        public byte[] ConvertImageToByteArray(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void bCancelAddingProject_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
            {
                if (Application.OpenForms[index].Name == "Projects")
                {
                    Application.OpenForms[index].Hide();
                    Application.OpenForms[index].Show();
                }

                else if (Application.OpenForms[index].Name == "AddProject")
                {
                    Application.OpenForms[index].Hide();
                }
            }
        }

        private void bAddProject_Paint(object sender, PaintEventArgs e)
        {
            // 3D button style
            ControlPaint.DrawBorder(e.Graphics, bAddProject.ClientRectangle, SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void bCancelAddingProject_Paint(object sender, PaintEventArgs e)
        {
            // 3D button style
            ControlPaint.DrawBorder(e.Graphics, bCancelAddingProject.ClientRectangle, SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void bUploadImage_Paint(object sender, PaintEventArgs e)
        {
            // 3D button style
            ControlPaint.DrawBorder(e.Graphics, bUploadImage.ClientRectangle, SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }
    }
}
