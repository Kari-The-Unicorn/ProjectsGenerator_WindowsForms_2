using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectsGenerator_WindowsForms_2
{
    public partial class EditProject : Form
    {
        public EditProject()
        {
            InitializeComponent();
        }

        private void bCancelEditingProject_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();

            for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
            {
                if (Application.OpenForms[index].Name == "EditProject")
                {
                    Application.OpenForms[index].Hide();
                }
            }
        }

        private void bEditProject_Click(object sender, EventArgs e)
        {
            try
            {
                var id = int.Parse(lblId.Text);

                string dbQuery = $@"UPDATE Projects SET ProjectName = '{tbProjectName.Text}', ProjectAddress = '{tbProjectAddress.Text}', ProjectCompany = '{tbProjectCompany.Text}', ProjectState = '{tbProjectState.Text}', ProjectDateIn = '{dtpProjectCollectionDate.Value}', ProjectDateOut = '{dtpProjectCompleteDate.Value}' WHERE id = {id}";

                using (SQLiteConnection dbConnection = new SQLiteConnection("Data Source=|DataDirectory|/db/db.db; version=3"))
                using (SQLiteCommand dbCommand = new SQLiteCommand(dbQuery, dbConnection))
                {
                    dbConnection.Open();
                    dbCommand.ExecuteNonQuery();
                }

                for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
                {
                    if (Application.OpenForms[index].Name == "EditProject")
                    {
                        Application.OpenForms[index].Hide();
                    }
                }

                MainWindow mainWindow = (MainWindow)Application.OpenForms["MainWindow"];
                if (mainWindow != null)
                {
                    mainWindow.MainWindow_Load(sender, e);
                    mainWindow.dgvProjects.Update();
                    mainWindow.dgvProjects.Refresh();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Close();
            }
        }

        private void EditProject_Load(object sender, EventArgs e)
        {
        }

        private void bCancelEditingProject_Paint(object sender, PaintEventArgs e)
        {
            // 3D button style
            ControlPaint.DrawBorder(e.Graphics, bCancelEditingProject.ClientRectangle, SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void bEditProject_Paint(object sender, PaintEventArgs e)
        {
            // 3D button style
            ControlPaint.DrawBorder(e.Graphics, bEditProject.ClientRectangle, SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }
    }
}
