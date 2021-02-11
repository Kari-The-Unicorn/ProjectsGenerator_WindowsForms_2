
namespace ProjectsGenerator_WindowsForms_2
{
    partial class OpenProject
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
            this.pProjectInfo = new System.Windows.Forms.Panel();
            this.tbProjectInfoDateOut = new System.Windows.Forms.TextBox();
            this.tbProjectInfoDateIn = new System.Windows.Forms.TextBox();
            this.lProjectInfoDateOut = new System.Windows.Forms.Label();
            this.lProjectInfoDateIn = new System.Windows.Forms.Label();
            this.tbProjectInfoGeneral = new System.Windows.Forms.TextBox();
            this.lProjectInfo = new System.Windows.Forms.Label();
            this.lId = new System.Windows.Forms.Label();
            this.bShowMap = new System.Windows.Forms.Button();
            this.bLoadIssues = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvIssues = new System.Windows.Forms.DataGridView();
            this.pProjectInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssues)).BeginInit();
            this.SuspendLayout();
            // 
            // pProjectInfo
            // 
            this.pProjectInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pProjectInfo.Controls.Add(this.tbProjectInfoDateOut);
            this.pProjectInfo.Controls.Add(this.tbProjectInfoDateIn);
            this.pProjectInfo.Controls.Add(this.lProjectInfoDateOut);
            this.pProjectInfo.Controls.Add(this.lProjectInfoDateIn);
            this.pProjectInfo.Controls.Add(this.tbProjectInfoGeneral);
            this.pProjectInfo.Controls.Add(this.lProjectInfo);
            this.pProjectInfo.Location = new System.Drawing.Point(2, 3);
            this.pProjectInfo.Margin = new System.Windows.Forms.Padding(2);
            this.pProjectInfo.Name = "pProjectInfo";
            this.pProjectInfo.Size = new System.Drawing.Size(1092, 50);
            this.pProjectInfo.TabIndex = 6;
            this.pProjectInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pProjectInfo_Paint);
            // 
            // tbProjectInfoDateOut
            // 
            this.tbProjectInfoDateOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProjectInfoDateOut.Location = new System.Drawing.Point(939, 0);
            this.tbProjectInfoDateOut.Margin = new System.Windows.Forms.Padding(2);
            this.tbProjectInfoDateOut.Name = "tbProjectInfoDateOut";
            this.tbProjectInfoDateOut.ReadOnly = true;
            this.tbProjectInfoDateOut.Size = new System.Drawing.Size(143, 26);
            this.tbProjectInfoDateOut.TabIndex = 6;
            // 
            // tbProjectInfoDateIn
            // 
            this.tbProjectInfoDateIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProjectInfoDateIn.Location = new System.Drawing.Point(757, 1);
            this.tbProjectInfoDateIn.Margin = new System.Windows.Forms.Padding(2);
            this.tbProjectInfoDateIn.Name = "tbProjectInfoDateIn";
            this.tbProjectInfoDateIn.ReadOnly = true;
            this.tbProjectInfoDateIn.Size = new System.Drawing.Size(144, 26);
            this.tbProjectInfoDateIn.TabIndex = 5;
            // 
            // lProjectInfoDateOut
            // 
            this.lProjectInfoDateOut.AutoSize = true;
            this.lProjectInfoDateOut.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProjectInfoDateOut.Location = new System.Drawing.Point(904, 4);
            this.lProjectInfoDateOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lProjectInfoDateOut.Name = "lProjectInfoDateOut";
            this.lProjectInfoDateOut.Size = new System.Drawing.Size(41, 22);
            this.lProjectInfoDateOut.TabIndex = 4;
            this.lProjectInfoDateOut.Text = "Do:";
            // 
            // lProjectInfoDateIn
            // 
            this.lProjectInfoDateIn.AutoSize = true;
            this.lProjectInfoDateIn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProjectInfoDateIn.Location = new System.Drawing.Point(718, 5);
            this.lProjectInfoDateIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lProjectInfoDateIn.Name = "lProjectInfoDateIn";
            this.lProjectInfoDateIn.Size = new System.Drawing.Size(45, 22);
            this.lProjectInfoDateIn.TabIndex = 3;
            this.lProjectInfoDateIn.Text = "Od:";
            // 
            // tbProjectInfoGeneral
            // 
            this.tbProjectInfoGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbProjectInfoGeneral.Location = new System.Drawing.Point(71, 2);
            this.tbProjectInfoGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.tbProjectInfoGeneral.Multiline = true;
            this.tbProjectInfoGeneral.Name = "tbProjectInfoGeneral";
            this.tbProjectInfoGeneral.ReadOnly = true;
            this.tbProjectInfoGeneral.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbProjectInfoGeneral.Size = new System.Drawing.Size(644, 32);
            this.tbProjectInfoGeneral.TabIndex = 2;
            this.tbProjectInfoGeneral.TextChanged += new System.EventHandler(this.tbProjectInfoGeneral_TextChanged);
            // 
            // lProjectInfo
            // 
            this.lProjectInfo.AutoSize = true;
            this.lProjectInfo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProjectInfo.Location = new System.Drawing.Point(2, 6);
            this.lProjectInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lProjectInfo.Name = "lProjectInfo";
            this.lProjectInfo.Size = new System.Drawing.Size(76, 22);
            this.lProjectInfo.TabIndex = 1;
            this.lProjectInfo.Text = "Projekt:";
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(284, 61);
            this.lId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(0, 13);
            this.lId.TabIndex = 11;
            // 
            // bShowMap
            // 
            this.bShowMap.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bShowMap.FlatAppearance.BorderSize = 0;
            this.bShowMap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bShowMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bShowMap.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bShowMap.Location = new System.Drawing.Point(943, 58);
            this.bShowMap.Margin = new System.Windows.Forms.Padding(2);
            this.bShowMap.Name = "bShowMap";
            this.bShowMap.Size = new System.Drawing.Size(121, 35);
            this.bShowMap.TabIndex = 10;
            this.bShowMap.Text = "Pokaż mapę";
            this.bShowMap.UseVisualStyleBackColor = false;
            this.bShowMap.Click += new System.EventHandler(this.bShowMap_Click);
            this.bShowMap.Paint += new System.Windows.Forms.PaintEventHandler(this.bShowMap_Paint);
            // 
            // bLoadIssues
            // 
            this.bLoadIssues.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bLoadIssues.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bLoadIssues.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bLoadIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLoadIssues.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLoadIssues.Location = new System.Drawing.Point(256, 71);
            this.bLoadIssues.Margin = new System.Windows.Forms.Padding(2);
            this.bLoadIssues.Name = "bLoadIssues";
            this.bLoadIssues.Size = new System.Drawing.Size(105, 24);
            this.bLoadIssues.TabIndex = 9;
            this.bLoadIssues.Text = "Odśwież listę";
            this.bLoadIssues.UseVisualStyleBackColor = false;
            this.bLoadIssues.Click += new System.EventHandler(this.bLoadIssues_Click);
            this.bLoadIssues.Paint += new System.Windows.Forms.PaintEventHandler(this.bLoadIssues_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lista poprawek:";
            // 
            // dgvIssues
            // 
            this.dgvIssues.AllowUserToAddRows = false;
            this.dgvIssues.AllowUserToDeleteRows = false;
            this.dgvIssues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIssues.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvIssues.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dgvIssues.Location = new System.Drawing.Point(2, 104);
            this.dgvIssues.Margin = new System.Windows.Forms.Padding(2);
            this.dgvIssues.Name = "dgvIssues";
            this.dgvIssues.RowHeadersWidth = 51;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvIssues.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIssues.RowTemplate.Height = 24;
            this.dgvIssues.RowTemplate.ReadOnly = true;
            this.dgvIssues.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIssues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvIssues.Size = new System.Drawing.Size(1090, 482);
            this.dgvIssues.TabIndex = 7;
            this.dgvIssues.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIssues_CellContentClick);
            // 
            // OpenProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 597);
            this.Controls.Add(this.pProjectInfo);
            this.Controls.Add(this.lId);
            this.Controls.Add(this.bShowMap);
            this.Controls.Add(this.bLoadIssues);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIssues);
            this.Name = "OpenProject";
            this.Text = "OpenProject";
            this.Load += new System.EventHandler(this.OpenProject_Load);
            this.pProjectInfo.ResumeLayout(false);
            this.pProjectInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pProjectInfo;
        public System.Windows.Forms.TextBox tbProjectInfoDateOut;
        public System.Windows.Forms.TextBox tbProjectInfoDateIn;
        private System.Windows.Forms.Label lProjectInfoDateOut;
        private System.Windows.Forms.Label lProjectInfoDateIn;
        public System.Windows.Forms.TextBox tbProjectInfoGeneral;
        private System.Windows.Forms.Label lProjectInfo;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.Button bShowMap;
        private System.Windows.Forms.Button bLoadIssues;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvIssues;
    }
}