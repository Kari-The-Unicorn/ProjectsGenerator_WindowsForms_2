
namespace ProjectsGenerator_WindowsForms_2
{
    partial class AddProject
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lUploadImage = new System.Windows.Forms.Label();
            this.tbProjectState = new System.Windows.Forms.TextBox();
            this.tbProjectCompany = new System.Windows.Forms.TextBox();
            this.projectStateLabel = new System.Windows.Forms.Label();
            this.projectCompanyLabel = new System.Windows.Forms.Label();
            this.projectAddressLabel = new System.Windows.Forms.Label();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.tbProjectAddress = new System.Windows.Forms.TextBox();
            this.tbProjectName = new System.Windows.Forms.MaskedTextBox();
            this.dtpProjectCollectionDate = new System.Windows.Forms.DateTimePicker();
            this.dtpProjectCompleteDate = new System.Windows.Forms.DateTimePicker();
            this.bUploadImage = new System.Windows.Forms.Button();
            this.lLoadedImageInfo = new System.Windows.Forms.Label();
            this.projectCompleteDateLabel = new System.Windows.Forms.Label();
            this.projectCollectionDateLabel = new System.Windows.Forms.Label();
            this.bCancelAddingProject = new System.Windows.Forms.Button();
            this.bAddProject = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.82019F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.17981F));
            this.tableLayoutPanel1.Controls.Add(this.lUploadImage, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbProjectState, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbProjectCompany, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.projectStateLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.projectCompanyLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.projectAddressLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.projectNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbProjectAddress, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbProjectName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpProjectCollectionDate, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpProjectCompleteDate, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.bUploadImage, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lLoadedImageInfo, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.projectCompleteDateLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.projectCollectionDateLabel, 0, 5);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.14421F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.52372F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49159F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49159F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49159F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.28774F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.98789F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.266402F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(714, 436);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lUploadImage
            // 
            this.lUploadImage.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lUploadImage.Location = new System.Drawing.Point(2, 322);
            this.lUploadImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lUploadImage.Name = "lUploadImage";
            this.lUploadImage.Size = new System.Drawing.Size(143, 75);
            this.lUploadImage.TabIndex = 17;
            this.lUploadImage.Text = "Załącznik";
            this.lUploadImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbProjectState
            // 
            this.tbProjectState.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.tbProjectState.Location = new System.Drawing.Point(150, 163);
            this.tbProjectState.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbProjectState.Multiline = true;
            this.tbProjectState.Name = "tbProjectState";
            this.tbProjectState.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbProjectState.Size = new System.Drawing.Size(444, 30);
            this.tbProjectState.TabIndex = 12;
            // 
            // tbProjectCompany
            // 
            this.tbProjectCompany.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.tbProjectCompany.Location = new System.Drawing.Point(150, 109);
            this.tbProjectCompany.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbProjectCompany.Multiline = true;
            this.tbProjectCompany.Name = "tbProjectCompany";
            this.tbProjectCompany.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbProjectCompany.Size = new System.Drawing.Size(444, 30);
            this.tbProjectCompany.TabIndex = 11;
            // 
            // projectStateLabel
            // 
            this.projectStateLabel.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.projectStateLabel.Location = new System.Drawing.Point(2, 161);
            this.projectStateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.projectStateLabel.Name = "projectStateLabel";
            this.projectStateLabel.Size = new System.Drawing.Size(143, 39);
            this.projectStateLabel.TabIndex = 6;
            this.projectStateLabel.Text = "Status";
            this.projectStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // projectCompanyLabel
            // 
            this.projectCompanyLabel.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.projectCompanyLabel.Location = new System.Drawing.Point(2, 107);
            this.projectCompanyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.projectCompanyLabel.Name = "projectCompanyLabel";
            this.projectCompanyLabel.Size = new System.Drawing.Size(143, 39);
            this.projectCompanyLabel.TabIndex = 4;
            this.projectCompanyLabel.Text = "Firma";
            this.projectCompanyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // projectAddressLabel
            // 
            this.projectAddressLabel.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.projectAddressLabel.Location = new System.Drawing.Point(2, 53);
            this.projectAddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.projectAddressLabel.Name = "projectAddressLabel";
            this.projectAddressLabel.Size = new System.Drawing.Size(143, 39);
            this.projectAddressLabel.TabIndex = 2;
            this.projectAddressLabel.Text = "Adres";
            this.projectAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.projectNameLabel.Location = new System.Drawing.Point(2, 0);
            this.projectNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(143, 39);
            this.projectNameLabel.TabIndex = 0;
            this.projectNameLabel.Text = "Nazwa projektu";
            this.projectNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbProjectAddress
            // 
            this.tbProjectAddress.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.tbProjectAddress.Location = new System.Drawing.Point(150, 55);
            this.tbProjectAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbProjectAddress.Multiline = true;
            this.tbProjectAddress.Name = "tbProjectAddress";
            this.tbProjectAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbProjectAddress.Size = new System.Drawing.Size(444, 30);
            this.tbProjectAddress.TabIndex = 10;
            // 
            // tbProjectName
            // 
            this.tbProjectName.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.tbProjectName.Location = new System.Drawing.Point(150, 2);
            this.tbProjectName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(444, 30);
            this.tbProjectName.TabIndex = 9;
            // 
            // dtpProjectCollectionDate
            // 
            this.dtpProjectCollectionDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpProjectCollectionDate.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.dtpProjectCollectionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProjectCollectionDate.Location = new System.Drawing.Point(150, 217);
            this.dtpProjectCollectionDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpProjectCollectionDate.Name = "dtpProjectCollectionDate";
            this.dtpProjectCollectionDate.Size = new System.Drawing.Size(206, 30);
            this.dtpProjectCollectionDate.TabIndex = 15;
            this.dtpProjectCollectionDate.Value = new System.DateTime(2020, 11, 29, 21, 23, 3, 0);
            this.dtpProjectCollectionDate.ValueChanged += new System.EventHandler(this.dtpProjectCollectionDate_ValueChanged);
            // 
            // dtpProjectCompleteDate
            // 
            this.dtpProjectCompleteDate.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.dtpProjectCompleteDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProjectCompleteDate.Location = new System.Drawing.Point(150, 271);
            this.dtpProjectCompleteDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpProjectCompleteDate.Name = "dtpProjectCompleteDate";
            this.dtpProjectCompleteDate.Size = new System.Drawing.Size(206, 30);
            this.dtpProjectCompleteDate.TabIndex = 16;
            // 
            // bUploadImage
            // 
            this.bUploadImage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bUploadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bUploadImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bUploadImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.bUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUploadImage.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.bUploadImage.Location = new System.Drawing.Point(150, 324);
            this.bUploadImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bUploadImage.Name = "bUploadImage";
            this.bUploadImage.Size = new System.Drawing.Size(136, 41);
            this.bUploadImage.TabIndex = 18;
            this.bUploadImage.Text = "Załaduj mapę";
            this.bUploadImage.UseVisualStyleBackColor = false;
            this.bUploadImage.Click += new System.EventHandler(this.bUploadImage_Click);
            this.bUploadImage.Paint += new System.Windows.Forms.PaintEventHandler(this.bUploadImage_Paint);
            // 
            // lLoadedImageInfo
            // 
            this.lLoadedImageInfo.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lLoadedImageInfo.Location = new System.Drawing.Point(150, 400);
            this.lLoadedImageInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lLoadedImageInfo.Name = "lLoadedImageInfo";
            this.lLoadedImageInfo.Size = new System.Drawing.Size(380, 32);
            this.lLoadedImageInfo.TabIndex = 19;
            this.lLoadedImageInfo.Text = "Wybierz plik .jpg";
            this.lLoadedImageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // projectCompleteDateLabel
            // 
            this.projectCompleteDateLabel.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.projectCompleteDateLabel.Location = new System.Drawing.Point(2, 215);
            this.projectCompleteDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.projectCompleteDateLabel.Name = "projectCompleteDateLabel";
            this.projectCompleteDateLabel.Size = new System.Drawing.Size(143, 33);
            this.projectCompleteDateLabel.TabIndex = 8;
            this.projectCompleteDateLabel.Text = "Data rozpoczęcia";
            this.projectCompleteDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // projectCollectionDateLabel
            // 
            this.projectCollectionDateLabel.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.projectCollectionDateLabel.Location = new System.Drawing.Point(2, 269);
            this.projectCollectionDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.projectCollectionDateLabel.Name = "projectCollectionDateLabel";
            this.projectCollectionDateLabel.Size = new System.Drawing.Size(143, 40);
            this.projectCollectionDateLabel.TabIndex = 7;
            this.projectCollectionDateLabel.Text = "Data oddania";
            this.projectCollectionDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bCancelAddingProject
            // 
            this.bCancelAddingProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(9)))), ((int)(((byte)(0)))));
            this.bCancelAddingProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancelAddingProject.FlatAppearance.BorderSize = 0;
            this.bCancelAddingProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.bCancelAddingProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.bCancelAddingProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancelAddingProject.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.bCancelAddingProject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bCancelAddingProject.Location = new System.Drawing.Point(151, 449);
            this.bCancelAddingProject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bCancelAddingProject.Name = "bCancelAddingProject";
            this.bCancelAddingProject.Size = new System.Drawing.Size(152, 39);
            this.bCancelAddingProject.TabIndex = 6;
            this.bCancelAddingProject.Text = "Anuluj";
            this.bCancelAddingProject.UseVisualStyleBackColor = false;
            this.bCancelAddingProject.Click += new System.EventHandler(this.bCancelAddingProject_Click);
            this.bCancelAddingProject.Paint += new System.Windows.Forms.PaintEventHandler(this.bCancelAddingProject_Paint);
            // 
            // bAddProject
            // 
            this.bAddProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(125)))), ((int)(((byte)(75)))));
            this.bAddProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAddProject.FlatAppearance.BorderSize = 0;
            this.bAddProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.bAddProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.bAddProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddProject.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.bAddProject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAddProject.Location = new System.Drawing.Point(1, 449);
            this.bAddProject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bAddProject.Name = "bAddProject";
            this.bAddProject.Size = new System.Drawing.Size(148, 39);
            this.bAddProject.TabIndex = 7;
            this.bAddProject.Text = "Dodaj projekt";
            this.bAddProject.UseVisualStyleBackColor = false;
            this.bAddProject.Click += new System.EventHandler(this.bAddProject_Click);
            this.bAddProject.Paint += new System.Windows.Forms.PaintEventHandler(this.bAddProject_Paint);
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 499);
            this.Controls.Add(this.bAddProject);
            this.Controls.Add(this.bCancelAddingProject);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddProject";
            this.Text = "Dodaj projekt";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lUploadImage;
        private System.Windows.Forms.TextBox tbProjectState;
        private System.Windows.Forms.TextBox tbProjectCompany;
        private System.Windows.Forms.Label projectStateLabel;
        private System.Windows.Forms.Label projectCompanyLabel;
        private System.Windows.Forms.Label projectAddressLabel;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.TextBox tbProjectAddress;
        private System.Windows.Forms.MaskedTextBox tbProjectName;
        private System.Windows.Forms.DateTimePicker dtpProjectCollectionDate;
        private System.Windows.Forms.DateTimePicker dtpProjectCompleteDate;
        private System.Windows.Forms.Button bUploadImage;
        private System.Windows.Forms.Label lLoadedImageInfo;
        private System.Windows.Forms.Label projectCompleteDateLabel;
        private System.Windows.Forms.Label projectCollectionDateLabel;
        private System.Windows.Forms.Button bCancelAddingProject;
        private System.Windows.Forms.Button bAddProject;
    }
}