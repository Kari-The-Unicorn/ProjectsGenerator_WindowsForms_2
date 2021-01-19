
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
            this.pLogo = new System.Windows.Forms.Panel();
            this.bNewProject = new System.Windows.Forms.Button();
            this.bOpenProject = new System.Windows.Forms.Button();
            this.bEditProject = new System.Windows.Forms.Button();
            this.bDeleteProject = new System.Windows.Forms.Button();
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
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(125, 100);
            this.pLogo.TabIndex = 0;
            // 
            // bNewProject
            // 
            this.bNewProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bNewProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNewProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.bNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bNewProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNewProject.Location = new System.Drawing.Point(0, 100);
            this.bNewProject.Name = "bNewProject";
            this.bNewProject.Size = new System.Drawing.Size(125, 45);
            this.bNewProject.TabIndex = 3;
            this.bNewProject.Text = "Nowy projekt";
            this.bNewProject.UseVisualStyleBackColor = false;
            // 
            // bOpenProject
            // 
            this.bOpenProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bOpenProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOpenProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.bOpenProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bOpenProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOpenProject.Location = new System.Drawing.Point(0, 145);
            this.bOpenProject.Name = "bOpenProject";
            this.bOpenProject.Size = new System.Drawing.Size(125, 45);
            this.bOpenProject.TabIndex = 4;
            this.bOpenProject.Text = "Otwórz";
            this.bOpenProject.UseVisualStyleBackColor = false;
            // 
            // bEditProject
            // 
            this.bEditProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bEditProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEditProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.bEditProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bEditProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditProject.Location = new System.Drawing.Point(0, 190);
            this.bEditProject.Name = "bEditProject";
            this.bEditProject.Size = new System.Drawing.Size(125, 45);
            this.bEditProject.TabIndex = 5;
            this.bEditProject.Text = "Edytuj";
            this.bEditProject.UseVisualStyleBackColor = false;
            // 
            // bDeleteProject
            // 
            this.bDeleteProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bDeleteProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDeleteProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.bDeleteProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDeleteProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDeleteProject.Location = new System.Drawing.Point(0, 235);
            this.bDeleteProject.Name = "bDeleteProject";
            this.bDeleteProject.Size = new System.Drawing.Size(125, 45);
            this.bDeleteProject.TabIndex = 6;
            this.bDeleteProject.Text = "Usuń";
            this.bDeleteProject.UseVisualStyleBackColor = false;
            // 
            // dgvProjects
            // 
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
            this.dgvProjects.Location = new System.Drawing.Point(128, 16);
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.Size = new System.Drawing.Size(780, 487);
            this.dgvProjects.TabIndex = 3;
            // 
            // lInfoProjects
            // 
            this.lInfoProjects.AutoSize = true;
            this.lInfoProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.lInfoProjects.Location = new System.Drawing.Point(125, 0);
            this.lInfoProjects.Name = "lInfoProjects";
            this.lInfoProjects.Size = new System.Drawing.Size(318, 13);
            this.lInfoProjects.TabIndex = 4;
            this.lInfoProjects.Text = "Lista projektów (wybierz z listy poprzez zaznaczenie na niebiesko):";
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
        private System.Windows.Forms.Button bDeleteProject;
        private System.Windows.Forms.Button bEditProject;
        private System.Windows.Forms.Button bOpenProject;
        private System.Windows.Forms.Button bNewProject;
        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.Label lInfoProjects;
    }
}