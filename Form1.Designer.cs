
namespace ImageToASCII
{
    partial class MainForm
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
            this.imagePanel = new System.Windows.Forms.Panel();
            this.navbarPanel = new System.Windows.Forms.Panel();
            this.convertButton = new System.Windows.Forms.Button();
            this.selectImage = new System.Windows.Forms.Button();
            this.sizeBar = new System.Windows.Forms.TrackBar();
            this.displayImage = new System.Windows.Forms.PictureBox();
            this.outSizeLabel = new System.Windows.Forms.Label();
            this.imagePanel.SuspendLayout();
            this.navbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayImage)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.imagePanel.Controls.Add(this.outSizeLabel);
            this.imagePanel.Controls.Add(this.displayImage);
            this.imagePanel.Controls.Add(this.sizeBar);
            this.imagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagePanel.Location = new System.Drawing.Point(0, 0);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(618, 373);
            this.imagePanel.TabIndex = 1;
            // 
            // navbarPanel
            // 
            this.navbarPanel.Controls.Add(this.convertButton);
            this.navbarPanel.Controls.Add(this.selectImage);
            this.navbarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.navbarPanel.Location = new System.Drawing.Point(0, 373);
            this.navbarPanel.Name = "navbarPanel";
            this.navbarPanel.Size = new System.Drawing.Size(618, 77);
            this.navbarPanel.TabIndex = 0;
            // 
            // convertButton
            // 
            this.convertButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.convertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.convertButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.convertButton.FlatAppearance.BorderSize = 0;
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.ForeColor = System.Drawing.SystemColors.Control;
            this.convertButton.Location = new System.Drawing.Point(309, 0);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(309, 77);
            this.convertButton.TabIndex = 1;
            this.convertButton.Text = "Convert to ASCII";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // selectImage
            // 
            this.selectImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selectImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.selectImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.selectImage.FlatAppearance.BorderSize = 0;
            this.selectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectImage.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectImage.ForeColor = System.Drawing.SystemColors.Control;
            this.selectImage.Location = new System.Drawing.Point(0, 0);
            this.selectImage.Name = "selectImage";
            this.selectImage.Size = new System.Drawing.Size(309, 77);
            this.selectImage.TabIndex = 0;
            this.selectImage.Text = "Select Image";
            this.selectImage.UseVisualStyleBackColor = false;
            this.selectImage.Click += new System.EventHandler(this.selectImage_Click);
            // 
            // sizeBar
            // 
            this.sizeBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sizeBar.Location = new System.Drawing.Point(0, 328);
            this.sizeBar.Maximum = 11;
            this.sizeBar.Minimum = 1;
            this.sizeBar.Name = "sizeBar";
            this.sizeBar.Size = new System.Drawing.Size(618, 45);
            this.sizeBar.TabIndex = 0;
            this.sizeBar.Value = 6;
            this.sizeBar.Scroll += new System.EventHandler(this.sizeBar_Scroll);
            // 
            // displayImage
            // 
            this.displayImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayImage.Location = new System.Drawing.Point(0, 0);
            this.displayImage.Name = "displayImage";
            this.displayImage.Size = new System.Drawing.Size(618, 328);
            this.displayImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.displayImage.TabIndex = 1;
            this.displayImage.TabStop = false;
            // 
            // outSizeLabel
            // 
            this.outSizeLabel.AutoSize = true;
            this.outSizeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outSizeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.outSizeLabel.Location = new System.Drawing.Point(12, 9);
            this.outSizeLabel.Name = "outSizeLabel";
            this.outSizeLabel.Size = new System.Drawing.Size(72, 16);
            this.outSizeLabel.TabIndex = 2;
            this.outSizeLabel.Text = "Output Size:";
            this.outSizeLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.navbarPanel);
            this.MinimumSize = new System.Drawing.Size(300, 250);
            this.Name = "MainForm";
            this.Text = "Image to ASCII";
            this.imagePanel.ResumeLayout(false);
            this.imagePanel.PerformLayout();
            this.navbarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sizeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.Panel navbarPanel;
        private System.Windows.Forms.Button selectImage;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.PictureBox displayImage;
        private System.Windows.Forms.TrackBar sizeBar;
        private System.Windows.Forms.Label outSizeLabel;
    }
}

