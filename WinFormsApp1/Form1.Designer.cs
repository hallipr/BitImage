namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label4;
            this.widthSlider = new System.Windows.Forms.TrackBar();
            this.offsetSlider = new System.Windows.Forms.TrackBar();
            this.widthLabel = new System.Windows.Forms.Label();
            this.offsetLabel = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.picturePanel = new System.Windows.Forms.Panel();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.scaleSlider = new System.Windows.Forms.TrackBar();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.fileButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.colorsButton = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.widthSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.picturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 16);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(25, 15);
            label4.TabIndex = 10;
            label4.Text = "File";
            // 
            // widthSlider
            // 
            this.widthSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.widthSlider.Location = new System.Drawing.Point(112, 40);
            this.widthSlider.Maximum = 128;
            this.widthSlider.Minimum = 1;
            this.widthSlider.Name = "widthSlider";
            this.widthSlider.Size = new System.Drawing.Size(676, 45);
            this.widthSlider.TabIndex = 0;
            this.widthSlider.Value = 32;
            // 
            // offsetSlider
            // 
            this.offsetSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.offsetSlider.Location = new System.Drawing.Point(112, 70);
            this.offsetSlider.Maximum = 32;
            this.offsetSlider.Name = "offsetSlider";
            this.offsetSlider.Size = new System.Drawing.Size(676, 45);
            this.offsetSlider.TabIndex = 1;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(12, 45);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(39, 15);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Width";
            // 
            // offsetLabel
            // 
            this.offsetLabel.AutoSize = true;
            this.offsetLabel.Location = new System.Drawing.Point(12, 76);
            this.offsetLabel.Name = "offsetLabel";
            this.offsetLabel.Size = new System.Drawing.Size(39, 15);
            this.offsetLabel.TabIndex = 3;
            this.offsetLabel.Text = "Offset";
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(394, 205);
            this.picture.TabIndex = 4;
            this.picture.TabStop = false;
            // 
            // picturePanel
            // 
            this.picturePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturePanel.AutoScroll = true;
            this.picturePanel.Controls.Add(this.picture);
            this.picturePanel.Location = new System.Drawing.Point(12, 139);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(776, 509);
            this.picturePanel.TabIndex = 5;
            // 
            // scaleLabel
            // 
            this.scaleLabel.AutoSize = true;
            this.scaleLabel.Location = new System.Drawing.Point(12, 108);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(34, 15);
            this.scaleLabel.TabIndex = 7;
            this.scaleLabel.Text = "Scale";
            // 
            // scaleSlider
            // 
            this.scaleSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleSlider.Location = new System.Drawing.Point(112, 100);
            this.scaleSlider.Maximum = 32;
            this.scaleSlider.Minimum = 1;
            this.scaleSlider.Name = "scaleSlider";
            this.scaleSlider.Size = new System.Drawing.Size(676, 45);
            this.scaleSlider.TabIndex = 6;
            this.scaleSlider.Value = 16;
            // 
            // fileTextBox
            // 
            this.fileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.fileTextBox.Location = new System.Drawing.Point(112, 12);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.ReadOnly = true;
            this.fileTextBox.Size = new System.Drawing.Size(542, 23);
            this.fileTextBox.TabIndex = 8;
            // 
            // fileButton
            // 
            this.fileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileButton.Location = new System.Drawing.Point(660, 12);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(61, 23);
            this.fileButton.TabIndex = 9;
            this.fileButton.Text = "File";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // colorsButton
            // 
            this.colorsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorsButton.Location = new System.Drawing.Point(727, 12);
            this.colorsButton.Name = "colorsButton";
            this.colorsButton.Size = new System.Drawing.Size(61, 23);
            this.colorsButton.TabIndex = 9;
            this.colorsButton.Text = "Colors";
            this.colorsButton.UseVisualStyleBackColor = true;
            this.colorsButton.Click += new System.EventHandler(this.colorsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 660);
            this.Controls.Add(label4);
            this.Controls.Add(this.colorsButton);
            this.Controls.Add(this.fileButton);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.picturePanel);
            this.Controls.Add(this.scaleLabel);
            this.Controls.Add(this.scaleSlider);
            this.Controls.Add(this.offsetLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.offsetSlider);
            this.Controls.Add(this.widthSlider);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.widthSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.picturePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scaleSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar widthSlider;
        private System.Windows.Forms.TrackBar offsetSlider;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label offsetLabel;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Panel picturePanel;
        private System.Windows.Forms.Label scaleLabel;
        private System.Windows.Forms.TrackBar scaleSlider;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button colorsButton;
    }
}
