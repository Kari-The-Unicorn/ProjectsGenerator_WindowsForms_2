
namespace ProjectsGenerator_WindowsForms_2
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pSideMenu = new System.Windows.Forms.Panel();
            this.pLogo = new System.Windows.Forms.Panel();
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.lInfoProjects = new System.Windows.Forms.Label();
            this.bNewProject = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.bOpenProject = new FontAwesome.Sharp.IconButton();
            this.bEditProject = new FontAwesome.Sharp.IconButton();
            this.bDeleteProject = new FontAwesome.Sharp.IconButton();
            this.pSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // pSideMenu
            // 
            this.pSideMenu.Controls.Add(this.bDeleteProject);
            this.pSideMenu.Controls.Add(this.bEditProject);
            this.pSideMenu.Controls.Add(this.bOpenProject);
            this.pSideMenu.Controls.Add(this.iconButton2);
            this.pSideMenu.Controls.Add(this.bNewProject);
            this.pSideMenu.Controls.Add(this.pLogo);
            this.pSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pSideMenu.Name = "pSideMenu";
            this.pSideMenu.Size = new System.Drawing.Size(125, 537);
            this.pSideMenu.TabIndex = 2;
            this.pSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pSideMenu_Paint);
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(125, 74);
            this.pLogo.TabIndex = 0;
            this.pLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.pLogo_Paint);
            // 
            // dgvProjects
            // 
            this.dgvProjects.AllowUserToAddRows = false;
            this.dgvProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProjects.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProjects.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProjects.Location = new System.Drawing.Point(128, 25);
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.Size = new System.Drawing.Size(780, 513);
            this.dgvProjects.TabIndex = 3;
            this.dgvProjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjects_CellContentClick);
            // 
            // lInfoProjects
            // 
            this.lInfoProjects.AutoSize = true;
            this.lInfoProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.lInfoProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lInfoProjects.Location = new System.Drawing.Point(125, 0);
            this.lInfoProjects.Name = "lInfoProjects";
            this.lInfoProjects.Size = new System.Drawing.Size(659, 22);
            this.lInfoProjects.TabIndex = 4;
            this.lInfoProjects.Text = "Lista projektów (wybierz z listy poprzez zaznaczenie całego wiersza na niebiesko)" +
    ":";
            this.lInfoProjects.Click += new System.EventHandler(this.lInfoProjects_Click);
            // 
            // bNewProject
            // 
            this.bNewProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNewProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.bNewProject.IconChar = FontAwesome.Sharp.IconChar.PenNib;
            this.bNewProject.IconColor = System.Drawing.Color.Black;
            this.bNewProject.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bNewProject.IconSize = 20;
            this.bNewProject.Location = new System.Drawing.Point(0, 80);
            this.bNewProject.Name = "bNewProject";
            this.bNewProject.Size = new System.Drawing.Size(119, 47);
            this.bNewProject.TabIndex = 7;
            this.bNewProject.Text = "Dodaj";
            this.bNewProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bNewProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bNewProject.UseVisualStyleBackColor = true;
            this.bNewProject.Click += new System.EventHandler(this.bNewProject_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(80, 335);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(12, 8);
            this.iconButton2.TabIndex = 8;
            this.iconButton2.Text = "iconButton2";
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // bOpenProject
            // 
            this.bOpenProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOpenProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.bOpenProject.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.bOpenProject.IconColor = System.Drawing.Color.Black;
            this.bOpenProject.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bOpenProject.IconSize = 20;
            this.bOpenProject.Location = new System.Drawing.Point(0, 123);
            this.bOpenProject.Name = "bOpenProject";
            this.bOpenProject.Size = new System.Drawing.Size(119, 47);
            this.bOpenProject.TabIndex = 9;
            this.bOpenProject.Text = "Otwórz";
            this.bOpenProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bOpenProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bOpenProject.UseVisualStyleBackColor = true;
            this.bOpenProject.Click += new System.EventHandler(this.bOpenProject_Click);
            // 
            // bEditProject
            // 
            this.bEditProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEditProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.bEditProject.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.bEditProject.IconColor = System.Drawing.Color.Black;
            this.bEditProject.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bEditProject.IconSize = 20;
            this.bEditProject.Location = new System.Drawing.Point(0, 176);
            this.bEditProject.Name = "bEditProject";
            this.bEditProject.Size = new System.Drawing.Size(119, 47);
            this.bEditProject.TabIndex = 10;
            this.bEditProject.Text = "Edytuj";
            this.bEditProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bEditProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bEditProject.UseVisualStyleBackColor = true;
            this.bEditProject.Click += new System.EventHandler(this.bEditProject_Click);
            // 
            // bDeleteProject
            // 
            this.bDeleteProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDeleteProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.bDeleteProject.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.bDeleteProject.IconColor = System.Drawing.Color.Black;
            this.bDeleteProject.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bDeleteProject.IconSize = 20;
            this.bDeleteProject.Location = new System.Drawing.Point(0, 219);
            this.bDeleteProject.Name = "bDeleteProject";
            this.bDeleteProject.Size = new System.Drawing.Size(119, 47);
            this.bDeleteProject.TabIndex = 11;
            this.bDeleteProject.Text = "Usuń";
            this.bDeleteProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bDeleteProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bDeleteProject.UseVisualStyleBackColor = true;
            this.bDeleteProject.Click += new System.EventHandler(this.bDeleteProject_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(909, 537);
            this.Controls.Add(this.dgvProjects);
            this.Controls.Add(this.lInfoProjects);
            this.Controls.Add(this.pSideMenu);
            this.IsMdiContainer = true;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Konstruktor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.pSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pSideMenu;
        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.Label lInfoProjects;
        public System.Windows.Forms.DataGridView dgvProjects;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton bNewProject;
        private FontAwesome.Sharp.IconButton bOpenProject;
        private FontAwesome.Sharp.IconButton bEditProject;
        private FontAwesome.Sharp.IconButton bDeleteProject;
    }
}