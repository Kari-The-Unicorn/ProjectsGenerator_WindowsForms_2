
namespace ProjectsGenerator_WindowsForms_2
{
    partial class OpenMap
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
            this.pbMap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMap
            // 
            this.pbMap.Location = new System.Drawing.Point(0, 0);
            this.pbMap.Margin = new System.Windows.Forms.Padding(2);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(0, 0);
            this.pbMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMap.TabIndex = 0;
            this.pbMap.TabStop = false;
            this.pbMap.Click += new System.EventHandler(this.pbMap_Click);
            this.pbMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMap_MouseDown);
            // 
            // OpenMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(676, 555);
            this.Controls.Add(this.pbMap);
            this.Name = "OpenMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mapa projektu";
            this.Load += new System.EventHandler(this.OpenMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pbMap;
    }
}