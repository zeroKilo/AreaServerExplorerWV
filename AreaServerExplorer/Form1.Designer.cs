namespace AreaServerExplorer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAreaServerexeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPNACHFileForIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patchIPToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeImportCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMD5CheckallBinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSavegameCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gui02 = new System.Windows.Forms.Panel();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.extractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openInPACKEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInTEXTEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gui01 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.unpackAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packFromFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pb1 = new System.Windows.Forms.ToolStripProgressBar();
            this.hb2 = new Be.Windows.Forms.HexBox();
            this.hb1 = new Be.Windows.Forms.HexBox();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gui02.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.gui01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAreaServerexeToolStripMenuItem,
            this.createPNACHFileForIPToolStripMenuItem,
            this.patchesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.unpackAllToolStripMenuItem,
            this.packFromFolderToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openAreaServerexeToolStripMenuItem
            // 
            this.openAreaServerexeToolStripMenuItem.Name = "openAreaServerexeToolStripMenuItem";
            this.openAreaServerexeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.openAreaServerexeToolStripMenuItem.Text = "Open AreaServer.exe";
            this.openAreaServerexeToolStripMenuItem.Click += new System.EventHandler(this.openAreaServerexeToolStripMenuItem_Click);
            // 
            // createPNACHFileForIPToolStripMenuItem
            // 
            this.createPNACHFileForIPToolStripMenuItem.Name = "createPNACHFileForIPToolStripMenuItem";
            this.createPNACHFileForIPToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.createPNACHFileForIPToolStripMenuItem.Text = "Create PNACH file for IP";
            this.createPNACHFileForIPToolStripMenuItem.Click += new System.EventHandler(this.createPNACHFileForIPToolStripMenuItem_Click);
            // 
            // patchesToolStripMenuItem
            // 
            this.patchesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patchIPToolStripMenuItem1,
            this.removeImportCheckToolStripMenuItem,
            this.removeMD5CheckallBinToolStripMenuItem,
            this.removeSavegameCheckToolStripMenuItem});
            this.patchesToolStripMenuItem.Name = "patchesToolStripMenuItem";
            this.patchesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.patchesToolStripMenuItem.Text = "Patches";
            // 
            // patchIPToolStripMenuItem1
            // 
            this.patchIPToolStripMenuItem1.Name = "patchIPToolStripMenuItem1";
            this.patchIPToolStripMenuItem1.Size = new System.Drawing.Size(231, 22);
            this.patchIPToolStripMenuItem1.Text = "Patch IP";
            this.patchIPToolStripMenuItem1.Click += new System.EventHandler(this.patchIPToolStripMenuItem1_Click);
            // 
            // removeImportCheckToolStripMenuItem
            // 
            this.removeImportCheckToolStripMenuItem.Name = "removeImportCheckToolStripMenuItem";
            this.removeImportCheckToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.removeImportCheckToolStripMenuItem.Text = "Remove Import Check (pack.bin)";
            this.removeImportCheckToolStripMenuItem.Click += new System.EventHandler(this.removeImportCheckToolStripMenuItem_Click);
            // 
            // removeMD5CheckallBinToolStripMenuItem
            // 
            this.removeMD5CheckallBinToolStripMenuItem.Name = "removeMD5CheckallBinToolStripMenuItem";
            this.removeMD5CheckallBinToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.removeMD5CheckallBinToolStripMenuItem.Text = "Remove MD5 Check (all bin)";
            this.removeMD5CheckallBinToolStripMenuItem.Click += new System.EventHandler(this.removeMD5CheckallBinToolStripMenuItem_Click);
            // 
            // removeSavegameCheckToolStripMenuItem
            // 
            this.removeSavegameCheckToolStripMenuItem.Name = "removeSavegameCheckToolStripMenuItem";
            this.removeSavegameCheckToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.removeSavegameCheckToolStripMenuItem.Text = "Remove Savegame Check";
            this.removeSavegameCheckToolStripMenuItem.Click += new System.EventHandler(this.removeSavegameCheckToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gui02);
            this.splitContainer1.Panel2.Controls.Add(this.gui01);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 426);
            this.splitContainer1.SplitterDistance = 386;
            this.splitContainer1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(386, 426);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // gui02
            // 
            this.gui02.Controls.Add(this.hb2);
            this.gui02.Controls.Add(this.menuStrip3);
            this.gui02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gui02.Location = new System.Drawing.Point(0, 0);
            this.gui02.Name = "gui02";
            this.gui02.Size = new System.Drawing.Size(610, 426);
            this.gui02.TabIndex = 1;
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem2});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(610, 24);
            this.menuStrip3.TabIndex = 0;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // fileToolStripMenuItem2
            // 
            this.fileToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractToolStripMenuItem,
            this.importToolStripMenuItem1,
            this.openInPACKEditorToolStripMenuItem,
            this.openInTEXTEditorToolStripMenuItem});
            this.fileToolStripMenuItem2.Name = "fileToolStripMenuItem2";
            this.fileToolStripMenuItem2.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem2.Text = "File";
            // 
            // extractToolStripMenuItem
            // 
            this.extractToolStripMenuItem.Name = "extractToolStripMenuItem";
            this.extractToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.extractToolStripMenuItem.Text = "Extract";
            this.extractToolStripMenuItem.Click += new System.EventHandler(this.extractToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem1
            // 
            this.importToolStripMenuItem1.Name = "importToolStripMenuItem1";
            this.importToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.importToolStripMenuItem1.Text = "Import";
            this.importToolStripMenuItem1.Click += new System.EventHandler(this.importToolStripMenuItem1_Click);
            // 
            // openInPACKEditorToolStripMenuItem
            // 
            this.openInPACKEditorToolStripMenuItem.Name = "openInPACKEditorToolStripMenuItem";
            this.openInPACKEditorToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.openInPACKEditorToolStripMenuItem.Text = "Open in PACK Editor";
            this.openInPACKEditorToolStripMenuItem.Visible = false;
            this.openInPACKEditorToolStripMenuItem.Click += new System.EventHandler(this.openInPACKEditorToolStripMenuItem_Click);
            // 
            // openInTEXTEditorToolStripMenuItem
            // 
            this.openInTEXTEditorToolStripMenuItem.Name = "openInTEXTEditorToolStripMenuItem";
            this.openInTEXTEditorToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.openInTEXTEditorToolStripMenuItem.Text = "Open in TEXT Editor";
            this.openInTEXTEditorToolStripMenuItem.Click += new System.EventHandler(this.openInTEXTEditorToolStripMenuItem_Click);
            // 
            // gui01
            // 
            this.gui01.Controls.Add(this.splitContainer2);
            this.gui01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gui01.Location = new System.Drawing.Point(0, 0);
            this.gui01.Name = "gui01";
            this.gui01.Size = new System.Drawing.Size(610, 426);
            this.gui01.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listBox2);
            this.splitContainer2.Panel1.Controls.Add(this.menuStrip2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.hb1);
            this.splitContainer2.Size = new System.Drawing.Size(610, 426);
            this.splitContainer2.SplitterDistance = 127;
            this.splitContainer2.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.IntegralHeight = false;
            this.listBox2.ItemHeight = 14;
            this.listBox2.Location = new System.Drawing.Point(0, 24);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(610, 103);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(610, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(188, 6);
            // 
            // unpackAllToolStripMenuItem
            // 
            this.unpackAllToolStripMenuItem.Name = "unpackAllToolStripMenuItem";
            this.unpackAllToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.unpackAllToolStripMenuItem.Text = "Unpack to folder";
            this.unpackAllToolStripMenuItem.Click += new System.EventHandler(this.unpackAllToolStripMenuItem_Click);
            // 
            // packFromFolderToolStripMenuItem
            // 
            this.packFromFolderToolStripMenuItem.AutoToolTip = true;
            this.packFromFolderToolStripMenuItem.Enabled = false;
            this.packFromFolderToolStripMenuItem.Name = "packFromFolderToolStripMenuItem";
            this.packFromFolderToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.packFromFolderToolStripMenuItem.Text = "Pack from folder";
            this.packFromFolderToolStripMenuItem.ToolTipText = "Not Implemented Yet!";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pb1,
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 450);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1000, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pb1
            // 
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(100, 16);
            // 
            // hb2
            // 
            this.hb2.BoldFont = null;
            this.hb2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hb2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hb2.LineInfoForeColor = System.Drawing.Color.Empty;
            this.hb2.LineInfoVisible = true;
            this.hb2.Location = new System.Drawing.Point(0, 24);
            this.hb2.Name = "hb2";
            this.hb2.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hb2.Size = new System.Drawing.Size(610, 402);
            this.hb2.StringViewVisible = true;
            this.hb2.TabIndex = 1;
            this.hb2.UseFixedBytesPerLine = true;
            this.hb2.VScrollBarVisible = true;
            // 
            // hb1
            // 
            this.hb1.BoldFont = null;
            this.hb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hb1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hb1.LineInfoForeColor = System.Drawing.Color.Empty;
            this.hb1.LineInfoVisible = true;
            this.hb1.Location = new System.Drawing.Point(0, 0);
            this.hb1.Name = "hb1";
            this.hb1.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hb1.Size = new System.Drawing.Size(610, 295);
            this.hb1.StringViewVisible = true;
            this.hb1.TabIndex = 0;
            this.hb1.UseFixedBytesPerLine = true;
            this.hb1.VScrollBarVisible = true;
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 472);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Area Server Explorer by Warranty Voider";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gui02.ResumeLayout(false);
            this.gui02.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.gui01.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAreaServerexeToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel gui01;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private Be.Windows.Forms.HexBox hb1;
        private System.Windows.Forms.Panel gui02;
        private Be.Windows.Forms.HexBox hb2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem extractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInPACKEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPNACHFileForIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem patchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeImportCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patchIPToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeMD5CheckallBinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSavegameCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInTEXTEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unpackAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packFromFolderToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar pb1;
        private System.Windows.Forms.ToolStripStatusLabel status;
    }
}

