
namespace Assignment2
{
    partial class TextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewTool = new System.Windows.Forms.ToolStripButton();
            this.OpenTool = new System.Windows.Forms.ToolStripButton();
            this.SaveTool = new System.Windows.Forms.ToolStripButton();
            this.SaveAsTool = new System.Windows.Forms.ToolStripButton();
            this.BoldTool = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.CutTool = new System.Windows.Forms.ToolStripButton();
            this.CopyTool = new System.Windows.Forms.ToolStripButton();
            this.PasteTool = new System.Windows.Forms.ToolStripButton();
            this.ItalicTool = new System.Windows.Forms.ToolStripButton();
            this.UnderLineTool = new System.Windows.Forms.ToolStripButton();
            this.username = new System.Windows.Forms.ToolStripLabel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.UserType = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FontSizeTool = new System.Windows.Forms.ToolStripComboBox();
            this.AboutTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1216, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator4,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator5,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.richTextBox);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1180, 733);
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.toolStrip2);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 36);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1216, 766);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewTool,
            this.OpenTool,
            this.SaveTool,
            this.SaveAsTool,
            this.toolStripButton5,
            this.BoldTool,
            this.ItalicTool,
            this.UnderLineTool,
            this.FontSizeTool,
            this.toolStripSeparator2,
            this.AboutTool,
            this.toolStripSeparator3,
            this.username,
            this.toolStripSeparator1,
            this.UserType});
            this.toolStrip1.Location = new System.Drawing.Point(4, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(634, 33);
            this.toolStrip1.TabIndex = 0;
            // 
            // NewTool
            // 
            this.NewTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewTool.Image = global::Assignment2.Properties.Resources._new;
            this.NewTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewTool.Name = "NewTool";
            this.NewTool.Size = new System.Drawing.Size(34, 28);
            this.NewTool.Text = "new";
            this.NewTool.Click += new System.EventHandler(this.NewTool_Click);
            // 
            // OpenTool
            // 
            this.OpenTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenTool.Image = global::Assignment2.Properties.Resources.open;
            this.OpenTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenTool.Name = "OpenTool";
            this.OpenTool.Size = new System.Drawing.Size(34, 28);
            this.OpenTool.Text = "Open";
            this.OpenTool.Click += new System.EventHandler(this.OpenTool_Click);
            // 
            // SaveTool
            // 
            this.SaveTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveTool.Image = global::Assignment2.Properties.Resources.save;
            this.SaveTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveTool.Name = "SaveTool";
            this.SaveTool.Size = new System.Drawing.Size(34, 28);
            this.SaveTool.Text = "Save";
            this.SaveTool.Click += new System.EventHandler(this.SaveTool_Click);
            // 
            // SaveAsTool
            // 
            this.SaveAsTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveAsTool.Image = global::Assignment2.Properties.Resources.SaveAs;
            this.SaveAsTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAsTool.Name = "SaveAsTool";
            this.SaveAsTool.Size = new System.Drawing.Size(34, 28);
            this.SaveAsTool.Text = "SaveAs";
            this.SaveAsTool.Click += new System.EventHandler(this.SaveAsTool_Click);
            // 
            // BoldTool
            // 
            this.BoldTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoldTool.Image = global::Assignment2.Properties.Resources.bold;
            this.BoldTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoldTool.Name = "BoldTool";
            this.BoldTool.Size = new System.Drawing.Size(34, 28);
            this.BoldTool.Text = "Bold";
            this.BoldTool.Click += new System.EventHandler(this.BoldTool_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CutTool,
            this.CopyTool,
            this.PasteTool});
            this.toolStrip2.Location = new System.Drawing.Point(0, 4);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(36, 115);
            this.toolStrip2.TabIndex = 0;
            // 
            // CutTool
            // 
            this.CutTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CutTool.Image = global::Assignment2.Properties.Resources.cut;
            this.CutTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CutTool.Name = "CutTool";
            this.CutTool.Size = new System.Drawing.Size(33, 28);
            this.CutTool.Text = "Cut";
            this.CutTool.Click += new System.EventHandler(this.CutTool_Click);
            // 
            // CopyTool
            // 
            this.CopyTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyTool.Image = global::Assignment2.Properties.Resources.copy;
            this.CopyTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyTool.Name = "CopyTool";
            this.CopyTool.Size = new System.Drawing.Size(33, 28);
            this.CopyTool.Text = "Copy";
            this.CopyTool.Click += new System.EventHandler(this.CopyTool_Click);
            // 
            // PasteTool
            // 
            this.PasteTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PasteTool.Image = global::Assignment2.Properties.Resources.paste;
            this.PasteTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PasteTool.Name = "PasteTool";
            this.PasteTool.Size = new System.Drawing.Size(33, 28);
            this.PasteTool.Text = "Paste";
            this.PasteTool.Click += new System.EventHandler(this.PasteTool_Click);
            // 
            // ItalicTool
            // 
            this.ItalicTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItalicTool.Image = global::Assignment2.Properties.Resources.italics;
            this.ItalicTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItalicTool.Name = "ItalicTool";
            this.ItalicTool.Size = new System.Drawing.Size(34, 28);
            this.ItalicTool.Text = "Italic";
            this.ItalicTool.Click += new System.EventHandler(this.ItalicTool_Click);
            // 
            // UnderLineTool
            // 
            this.UnderLineTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UnderLineTool.Image = global::Assignment2.Properties.Resources.underline;
            this.UnderLineTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnderLineTool.Name = "UnderLineTool";
            this.UnderLineTool.Size = new System.Drawing.Size(34, 28);
            this.UnderLineTool.Text = "UnderLine";
            this.UnderLineTool.Click += new System.EventHandler(this.UnderLineTool_Click);
            // 
            // username
            // 
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(102, 28);
            this.username.Text = "UserName:";
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(3, 3);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(1177, 727);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // UserType
            // 
            this.UserType.Name = "UserType";
            this.UserType.Size = new System.Drawing.Size(93, 28);
            this.UserType.Text = "UserType:";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // FontSizeTool
            // 
            this.FontSizeTool.Name = "FontSizeTool";
            this.FontSizeTool.Size = new System.Drawing.Size(121, 33);
            this.FontSizeTool.SelectedIndexChanged += new System.EventHandler(this.FontSizeTool_Click);
            // 
            // AboutTool
            // 
            this.AboutTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AboutTool.Image = ((System.Drawing.Image)(resources.GetObject("AboutTool.Image")));
            this.AboutTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutTool.Name = "AboutTool";
            this.AboutTool.Size = new System.Drawing.Size(34, 28);
            this.AboutTool.Text = "About";
            this.AboutTool.Click += new System.EventHandler(this.AboutTool_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(289, 34);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(289, 34);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(289, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(289, 34);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(267, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(267, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 801);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextEditor";
            this.Text = "TextEditor";
            this.Load += new System.EventHandler(this.TextEditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton CutTool;
        private System.Windows.Forms.ToolStripButton CopyTool;
        private System.Windows.Forms.ToolStripButton PasteTool;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewTool;
        private System.Windows.Forms.ToolStripButton OpenTool;
        private System.Windows.Forms.ToolStripButton SaveTool;
        private System.Windows.Forms.ToolStripButton SaveAsTool;
        private System.Windows.Forms.ToolStripButton BoldTool;
        private System.Windows.Forms.ToolStripButton ItalicTool;
        private System.Windows.Forms.ToolStripButton UnderLineTool;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel username;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel UserType;
        private System.Windows.Forms.ToolStripSeparator toolStripButton5;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox FontSizeTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton AboutTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}