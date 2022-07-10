namespace CSSSkins {
  partial class MainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.cssList = new System.Windows.Forms.ListBox();
            this.cssLb = new System.Windows.Forms.ComboBox();
            this.imageLb = new System.Windows.Forms.ComboBox();
            this.loadedImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CssFileLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.loadedImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.MainLayoutPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cssList
            // 
            this.cssList.AccessibleName = "";
            this.cssList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cssList.FormattingEnabled = true;
            this.cssList.Location = new System.Drawing.Point(0, 0);
            this.cssList.Name = "cssList";
            this.cssList.Size = new System.Drawing.Size(150, 340);
            this.cssList.TabIndex = 0;
            this.cssList.SelectedIndexChanged += new System.EventHandler(this.cssList_SelectedIndexChanged);
            // 
            // cssLb
            // 
            this.cssLb.AccessibleName = "";
            this.cssLb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cssLb.FormattingEnabled = true;
            this.cssLb.Location = new System.Drawing.Point(3, 20);
            this.cssLb.Name = "cssLb";
            this.cssLb.Size = new System.Drawing.Size(121, 21);
            this.cssLb.TabIndex = 1;
            this.cssLb.SelectedIndexChanged += new System.EventHandler(this.cssLb_SelectedIndexChanged);
            // 
            // imageLb
            // 
            this.imageLb.AccessibleName = "";
            this.imageLb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imageLb.FormattingEnabled = true;
            this.imageLb.Location = new System.Drawing.Point(3, 20);
            this.imageLb.Name = "imageLb";
            this.imageLb.Size = new System.Drawing.Size(121, 21);
            this.imageLb.TabIndex = 2;
            this.imageLb.SelectedIndexChanged += new System.EventHandler(this.imageLb_SelectedIndexChanged);
            // 
            // loadedImage
            // 
            this.loadedImage.Location = new System.Drawing.Point(0, 0);
            this.loadedImage.Name = "loadedImage";
            this.loadedImage.Size = new System.Drawing.Size(403, 307);
            this.loadedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadedImage.TabIndex = 3;
            this.loadedImage.TabStop = false;
            this.loadedImage.Paint += new System.Windows.Forms.PaintEventHandler(this.loadedImage_Paint);
            this.loadedImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loadedImage_MouseDown);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.loadedImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.MainLayoutPanel.SetRowSpan(this.panel1, 3);
            this.panel1.Size = new System.Drawing.Size(951, 534);
            this.panel1.TabIndex = 7;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(6, 49);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(133, 45);
            this.trackBar2.TabIndex = 8;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1107, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectColorToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // selectColorToolStripMenuItem
            // 
            this.selectColorToolStripMenuItem.Name = "selectColorToolStripMenuItem";
            this.selectColorToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.selectColorToolStripMenuItem.Text = "Select Color";
            this.selectColorToolStripMenuItem.Click += new System.EventHandler(this.SelectColor);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.ColumnCount = 2;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.MainLayoutPanel.Controls.Add(this.panel2, 1, 0);
            this.MainLayoutPanel.Controls.Add(this.panel3, 1, 1);
            this.MainLayoutPanel.Controls.Add(this.panel1, 0, 0);
            this.MainLayoutPanel.Controls.Add(this.panel4, 1, 2);
            this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowCount = 3;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(1107, 540);
            this.MainLayoutPanel.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CssFileLabel);
            this.panel2.Controls.Add(this.cssLb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(957, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 50);
            this.panel2.TabIndex = 0;
            // 
            // CssFileLabel
            // 
            this.CssFileLabel.AutoSize = true;
            this.CssFileLabel.Location = new System.Drawing.Point(3, 4);
            this.CssFileLabel.Name = "CssFileLabel";
            this.CssFileLabel.Size = new System.Drawing.Size(52, 13);
            this.CssFileLabel.TabIndex = 2;
            this.CssFileLabel.Text = "CSS files:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.imageLb);
            this.panel3.Controls.Add(this.trackBar2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(957, 50);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 150);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Images list:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cssList);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(957, 200);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 340);
            this.panel4.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1107, 564);
            this.Controls.Add(this.MainLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadedImage)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainLayoutPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.ListBox cssList;
        private System.Windows.Forms.ComboBox cssLb;
        private System.Windows.Forms.ComboBox imageLb;
        private System.Windows.Forms.PictureBox loadedImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CssFileLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectColorToolStripMenuItem;
    }
}

