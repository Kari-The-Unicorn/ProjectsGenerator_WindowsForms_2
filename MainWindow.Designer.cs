
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pSideMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pSideMenu.Controls.Add(this.bDeleteProject);
            this.pSideMenu.Controls.Add(this.bEditProject);
            this.pSideMenu.Controls.Add(this.bOpenProject);
            this.pSideMenu.Controls.Add(this.bNewProject);
            this.pSideMenu.Controls.Add(this.pLogo);
            this.pSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pSideMenu.Name = "pSideMenu";
            this.pSideMenu.Size = new System.Drawing.Size(143, 537);
            this.pSideMenu.TabIndex = 2;
            this.pSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pSideMenu_Paint);
            // 
            // bDeleteProject
            // 
            this.bDeleteProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDeleteProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.bDeleteProject.FlatAppearance.BorderSize = 0;
            this.bDeleteProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bDeleteProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bDeleteProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDeleteProject.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.bDeleteProject.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.bDeleteProject.IconColor = System.Drawing.Color.Black;
            this.bDeleteProject.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bDeleteProject.IconSize = 29;
            this.bDeleteProject.Location = new System.Drawing.Point(0, 215);
            this.bDeleteProject.Name = "bDeleteProject";
            this.bDeleteProject.Size = new System.Drawing.Size(143, 47);
            this.bDeleteProject.TabIndex = 11;
            this.bDeleteProject.Text = "Usuń";
            this.bDeleteProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bDeleteProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bDeleteProject.UseVisualStyleBackColor = true;
            this.bDeleteProject.Click += new System.EventHandler(this.bDeleteProject_Click);
            this.bDeleteProject.Paint += new System.Windows.Forms.PaintEventHandler(this.bDeleteProject_Paint);
            // 
            // bEditProject
            // 
            this.bEditProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEditProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.bEditProject.FlatAppearance.BorderSize = 0;
            this.bEditProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bEditProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bEditProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEditProject.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.bEditProject.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.bEditProject.IconColor = System.Drawing.Color.Black;
            this.bEditProject.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bEditProject.IconSize = 29;
            this.bEditProject.Location = new System.Drawing.Point(0, 168);
            this.bEditProject.Name = "bEditProject";
            this.bEditProject.Size = new System.Drawing.Size(143, 47);
            this.bEditProject.TabIndex = 10;
            this.bEditProject.Text = "Edytuj";
            this.bEditProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bEditProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bEditProject.UseVisualStyleBackColor = true;
            this.bEditProject.Click += new System.EventHandler(this.bEditProject_Click);
            this.bEditProject.Paint += new System.Windows.Forms.PaintEventHandler(this.bEditProject_Paint);
            // 
            // bOpenProject
            // 
            this.bOpenProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOpenProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.bOpenProject.FlatAppearance.BorderSize = 0;
            this.bOpenProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bOpenProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bOpenProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOpenProject.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.bOpenProject.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.bOpenProject.IconColor = System.Drawing.Color.Black;
            this.bOpenProject.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bOpenProject.IconSize = 29;
            this.bOpenProject.Location = new System.Drawing.Point(0, 121);
            this.bOpenProject.Name = "bOpenProject";
            this.bOpenProject.Size = new System.Drawing.Size(143, 47);
            this.bOpenProject.TabIndex = 9;
            this.bOpenProject.Text = "Otwórz";
            this.bOpenProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bOpenProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bOpenProject.UseVisualStyleBackColor = true;
            this.bOpenProject.Click += new System.EventHandler(this.bOpenProject_Click);
            this.bOpenProject.Paint += new System.Windows.Forms.PaintEventHandler(this.bOpenProject_Paint);
            // 
            // bNewProject
            // 
            this.bNewProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bNewProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNewProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.bNewProject.FlatAppearance.BorderSize = 0;
            this.bNewProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNewProject.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.bNewProject.ForeColor = System.Drawing.Color.Black;
            this.bNewProject.IconChar = FontAwesome.Sharp.IconChar.PenNib;
            this.bNewProject.IconColor = System.Drawing.Color.Black;
            this.bNewProject.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bNewProject.IconSize = 29;
            this.bNewProject.Location = new System.Drawing.Point(0, 74);
            this.bNewProject.Name = "bNewProject";
            this.bNewProject.Size = new System.Drawing.Size(143, 47);
            this.bNewProject.TabIndex = 7;
            this.bNewProject.Text = "Dodaj";
            this.bNewProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bNewProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bNewProject.UseVisualStyleBackColor = false;
            this.bNewProject.Click += new System.EventHandler(this.bNewProject_Click);
            this.bNewProject.Paint += new System.Windows.Forms.PaintEventHandler(this.bNewProject_Paint);
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(143, 74);
            this.pLogo.TabIndex = 0;
            this.pLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.pLogo_Paint);
            // 
            // dgvProjects
            // 
            this.dgvProjects.AllowUserToAddRows = false;
            this.dgvProjects.AllowUserToDeleteRows = false;
            this.dgvProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProjects.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProjects.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProjects.Location = new System.Drawing.Point(147, 25);
            this.dgvProjects.Margin = new System.Windows.Forms.Padding(5);
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.RowHeadersWidth = 51;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjects.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjects.Size = new System.Drawing.Size(936, 513);
            this.dgvProjects.TabIndex = 0;
            this.dgvProjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjects_CellContentClick);
            // 
            // lInfoProjects
            // 
            this.lInfoProjects.AutoSize = true;
            this.lInfoProjects.BackColor = System.Drawing.Color.LemonChiffon;
            this.lInfoProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.lInfoProjects.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lInfoProjects.Location = new System.Drawing.Point(143, 0);
            this.lInfoProjects.Name = "lInfoProjects";
            this.lInfoProjects.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lInfoProjects.Size = new System.Drawing.Size(809, 23);
            this.lInfoProjects.TabIndex = 4;
            this.lInfoProjects.Text = "Lista projektów (wybierz z listy poprzez zaznaczenie całego wiersza na niebiesko)" +
    ":";
            this.lInfoProjects.Click += new System.EventHandler(this.lInfoProjects_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1083, 537);
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
        private FontAwesome.Sharp.IconButton bOpenProject;
        private FontAwesome.Sharp.IconButton bEditProject;
        private FontAwesome.Sharp.IconButton bDeleteProject;
        private FontAwesome.Sharp.IconButton bNewProject;
    }
}