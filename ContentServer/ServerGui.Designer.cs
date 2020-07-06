namespace ContentServer
{
    partial class ServerGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerGui));
            this.serverContents = new System.Windows.Forms.ListBox();
            this.addPKG = new System.Windows.Forms.Button();
            this.addPUP = new System.Windows.Forms.Button();
            this.addMisc = new System.Windows.Forms.Button();
            this.rmFile = new System.Windows.Forms.Button();
            this.addFolder = new System.Windows.Forms.Button();
            this.rmAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.consoleOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // serverContents
            // 
            this.serverContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverContents.FormattingEnabled = true;
            this.serverContents.Location = new System.Drawing.Point(12, 44);
            this.serverContents.Name = "serverContents";
            this.serverContents.Size = new System.Drawing.Size(660, 394);
            this.serverContents.TabIndex = 0;
            // 
            // addPKG
            // 
            this.addPKG.Location = new System.Drawing.Point(12, 12);
            this.addPKG.Name = "addPKG";
            this.addPKG.Size = new System.Drawing.Size(102, 23);
            this.addPKG.TabIndex = 1;
            this.addPKG.Text = "Add PKG File";
            this.addPKG.UseVisualStyleBackColor = true;
            this.addPKG.Click += new System.EventHandler(this.addPKG_Click);
            // 
            // addPUP
            // 
            this.addPUP.Location = new System.Drawing.Point(120, 12);
            this.addPUP.Name = "addPUP";
            this.addPUP.Size = new System.Drawing.Size(110, 23);
            this.addPUP.TabIndex = 2;
            this.addPUP.Text = "Add PUP File";
            this.addPUP.UseVisualStyleBackColor = true;
            this.addPUP.Click += new System.EventHandler(this.addPUP_Click);
            // 
            // addMisc
            // 
            this.addMisc.Location = new System.Drawing.Point(236, 12);
            this.addMisc.Name = "addMisc";
            this.addMisc.Size = new System.Drawing.Size(106, 23);
            this.addMisc.TabIndex = 3;
            this.addMisc.Text = "Add Misc";
            this.addMisc.UseVisualStyleBackColor = true;
            this.addMisc.Click += new System.EventHandler(this.addMisc_Click);
            // 
            // rmFile
            // 
            this.rmFile.Location = new System.Drawing.Point(460, 12);
            this.rmFile.Name = "rmFile";
            this.rmFile.Size = new System.Drawing.Size(106, 23);
            this.rmFile.TabIndex = 4;
            this.rmFile.Text = "Remove Selected";
            this.rmFile.UseVisualStyleBackColor = true;
            this.rmFile.Click += new System.EventHandler(this.rmFile_Click);
            // 
            // addFolder
            // 
            this.addFolder.Location = new System.Drawing.Point(348, 12);
            this.addFolder.Name = "addFolder";
            this.addFolder.Size = new System.Drawing.Size(106, 23);
            this.addFolder.TabIndex = 5;
            this.addFolder.Text = "Add Folder";
            this.addFolder.UseVisualStyleBackColor = true;
            this.addFolder.Click += new System.EventHandler(this.addFolder_Click);
            // 
            // rmAll
            // 
            this.rmAll.Location = new System.Drawing.Point(572, 12);
            this.rmAll.Name = "rmAll";
            this.rmAll.Size = new System.Drawing.Size(106, 23);
            this.rmAll.TabIndex = 6;
            this.rmAll.Text = "Remove All";
            this.rmAll.UseVisualStyleBackColor = true;
            this.rmAll.Click += new System.EventHandler(this.rmAll_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Console:";
            // 
            // consoleOutput
            // 
            this.consoleOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleOutput.Location = new System.Drawing.Point(15, 462);
            this.consoleOutput.Multiline = true;
            this.consoleOutput.Name = "consoleOutput";
            this.consoleOutput.ReadOnly = true;
            this.consoleOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleOutput.Size = new System.Drawing.Size(657, 147);
            this.consoleOutput.TabIndex = 8;
            // 
            // ServerGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 621);
            this.Controls.Add(this.consoleOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rmAll);
            this.Controls.Add(this.addFolder);
            this.Controls.Add(this.rmFile);
            this.Controls.Add(this.addMisc);
            this.Controls.Add(this.addPUP);
            this.Controls.Add(this.addPKG);
            this.Controls.Add(this.serverContents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 660);
            this.Name = "ServerGui";
            this.Text = "Content Server - Listening on Port 1337";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerGui_FormClosing);
            this.Load += new System.EventHandler(this.ServerGui_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox serverContents;
        private System.Windows.Forms.Button addPKG;
        private System.Windows.Forms.Button addPUP;
        private System.Windows.Forms.Button addMisc;
        private System.Windows.Forms.Button rmFile;
        private System.Windows.Forms.Button addFolder;
        private System.Windows.Forms.Button rmAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox consoleOutput;
    }
}

