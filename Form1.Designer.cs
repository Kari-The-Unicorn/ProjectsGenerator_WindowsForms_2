
namespace ProjectsGenerator_WindowsForms_2
{
    partial class Form1
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
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.bDisplayProjects = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProjects
            // 
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Location = new System.Drawing.Point(12, 23);
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.Size = new System.Drawing.Size(776, 339);
            this.dgvProjects.TabIndex = 0;
            // 
            // bDisplayProjects
            // 
            this.bDisplayProjects.Location = new System.Drawing.Point(204, 391);
            this.bDisplayProjects.Name = "bDisplayProjects";
            this.bDisplayProjects.Size = new System.Drawing.Size(101, 31);
            this.bDisplayProjects.TabIndex = 1;
            this.bDisplayProjects.Text = "Display Projects";
            this.bDisplayProjects.UseVisualStyleBackColor = true;
            this.bDisplayProjects.Click += new System.EventHandler(this.bDisplayProjects_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bDisplayProjects);
            this.Controls.Add(this.dgvProjects);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.Button bDisplayProjects;
    }
}

