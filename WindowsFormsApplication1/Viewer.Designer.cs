namespace WindowsFormsApplication1
{
    partial class Viewer
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.showFilesButton = new System.Windows.Forms.Button();
            this.fileListBox = new System.Windows.Forms.ListBox();
            this.commitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 132);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(260, 118);
            this.textBox.TabIndex = 1;
            // 
            // showFilesButton
            // 
            this.showFilesButton.Location = new System.Drawing.Point(11, 12);
            this.showFilesButton.Name = "showFilesButton";
            this.showFilesButton.Size = new System.Drawing.Size(121, 24);
            this.showFilesButton.TabIndex = 4;
            this.showFilesButton.Text = "Show all .txt files";
            this.showFilesButton.UseVisualStyleBackColor = true;
            this.showFilesButton.Click += new System.EventHandler(this.VeiweFiles);
            // 
            // fileListBox
            // 
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.Location = new System.Drawing.Point(151, 12);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.Size = new System.Drawing.Size(121, 108);
            this.fileListBox.TabIndex = 5;
            this.fileListBox.SelectedValueChanged += new System.EventHandler(this.FileSelected);
            // 
            // commitbutton
            // 
            this.commitbutton.Location = new System.Drawing.Point(12, 102);
            this.commitbutton.Name = "commitbutton";
            this.commitbutton.Size = new System.Drawing.Size(120, 24);
            this.commitbutton.TabIndex = 6;
            this.commitbutton.Text = "Commit changes";
            this.commitbutton.UseVisualStyleBackColor = true;
            this.commitbutton.Click += new System.EventHandler(this.CommitChanges);
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.commitbutton);
            this.Controls.Add(this.fileListBox);
            this.Controls.Add(this.showFilesButton);
            this.Controls.Add(this.textBox);
            this.Name = "Viewer";
            this.Text = "FileViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button showFilesButton;
        private System.Windows.Forms.ListBox fileListBox;
        private System.Windows.Forms.Button commitbutton;
    }
}

