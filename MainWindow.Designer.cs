
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pSideMenu = new System.Windows.Forms.Panel();
            this.bDeleteProject = new FontAwesome.Sharp.IconButton();
            this.bEditProject = new FontAwesome.Sharp.IconButton();
            this.bOpenProject = new FontAwesome.Sharp.IconButton();
            this.bNewProject = new FontAwesome.Sharp.IconButton();
            this.pLogo = new System.Windows.Forms.Panel();
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.lInfoProjects = new System.Windows.Forms.Label();
            this.pSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // pSideMenu
            // 
            this.pSideMenu.Controls.Add(this.bDeleteProject);
            this.pSideMenu.Controls.Add(this.bEditProject);
            this.pSideMenu.Controls.Add(this.bOpenProject);
            this.pSideMenu.Controls.Add(this.bNewProject);
            this.pSideMenu.Controls.Add(this.pLogo);
            this.pSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pSideMenu.Name = "pSideMenu";
            this.pSideMenu.Size = new System.Drawing.Size(125, 537);
            this.pSideMenu.TabIndex = 2;
            this.pSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pSideMenu_Paint);
            // 
            // bDeleteProject
            // 
            this.bDeleteProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDeleteProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.bDeleteProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.bDeleteProject.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.bDeleteProject.IconColor = System.Drawing.Color.Black;
            this.bDeleteProject.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bDeleteProject.IconSize = 20;
            this.bDeleteProject.Location = new System.Drawing.Point(0, 215);
            this.bDeleteProject.Name = "bDeleteProject";
            this.bDeleteProject.Size = new System.Drawing.Size(125, 47);
            this.bDeleteProject.TabIndex = 11;
            this.bDeleteProject.Text = "Usuń";
            this.bDeleteProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bDeleteProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bDeleteProject.UseVisualStyleBackColor = true;
            this.bDeleteProject.Click += new System.EventHandler(this.bDeleteProject_Click);
            // 
            // bEditProject
            // 
            this.bEditProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEditProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.bEditProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.bEditProject.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.bEditProject.IconColor = System.Drawing.Color.Black;
            this.bEditProject.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bEditProject.IconSize = 20;
            this.bEditProject.Location = new System.Drawing.Point(0, 168);
            this.bEditProject.Name = "bEditProject";
            this.bEditProject.Size = new System.Drawing.Size(125, 47);
            this.bEditProject.TabIndex = 10;
            this.bEditProject.Text = "Edytuj";
            this.bEditProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bEditProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bEditProject.UseVisualStyleBackColor = true;
            this.bEditProject.Click += new System.EventHandler(this.bEditProject_Click);
            // 
            // bOpenProject
            // 
            this.bOpenProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOpenProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.bOpenProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.bOpenProject.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.bOpenProject.IconColor = System.Drawing.Color.Black;
            this.bOpenProject.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bOpenProject.IconSize = 20;
            this.bOpenProject.Location = new System.Drawing.Point(0, 121);
            this.bOpenProject.Name = "bOpenProject";
            this.bOpenProject.Size = new System.Drawing.Size(125, 47);
            this.bOpenProject.TabIndex = 9;
            this.bOpenProject.Text = "Otwórz";
            this.bOpenProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bOpenProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bOpenProject.UseVisualStyleBackColor = true;
            this.bOpenProject.Click += new System.EventHandler(this.bOpenProject_Click);
            // 
            // bNewProject
            // 
            this.bNewProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNewProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.bNewProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.bNewProject.IconChar = FontAwesome.Sharp.IconChar.PenNib;
            this.bNewProject.IconColor = System.Drawing.Color.Black;
            this.bNewProject.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bNewProject.IconSize = 20;
            this.bNewProject.Location = new System.Drawing.Point(0, 74);
            this.bNewProject.Name = "bNewProject";
            this.bNewProject.Size = new System.Drawing.Size(125, 47);
            this.bNewProject.TabIndex = 7;
            this.bNewProject.Text = "Dodaj";
            this.bNewProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bNewProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bNewProject.UseVisualStyleBackColor = true;
            this.bNewProject.Click += new System.EventHandler(this.bNewProject_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProjects.DefaultCellStyle = dataGridViewCellStyle1;
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
            this.lInfoProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInfoProjects.Location = new System.Drawing.Point(125, 0);
            this.lInfoProjects.Name = "lInfoProjects";
            this.lInfoProjects.Size = new System.Drawing.Size(697, 24);
            this.lInfoProjects.TabIndex = 4;
            this.lInfoProjects.Text = "Lista projektów (wybierz z listy poprzez zaznaczenie całego wiersza na niebiesko)" +
    ":";
            this.lInfoProjects.Click += new System.EventHandler(this.lInfoProjects_Click);
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
        private FontAwesome.Sharp.IconButton bNewProject;
        private FontAwesome.Sharp.IconButton bOpenProject;
        private FontAwesome.Sharp.IconButton bEditProject;
        private FontAwesome.Sharp.IconButton bDeleteProject;
    }
}