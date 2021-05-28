
namespace Vsqx2CCS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLogs = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvVSQX = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pbConvert = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSelDir = new System.Windows.Forms.Button();
            this.tbPathDestDir = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVSQXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbLogs);
            this.groupBox1.Location = new System.Drawing.Point(13, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logs";
            // 
            // tbLogs
            // 
            this.tbLogs.Enabled = false;
            this.tbLogs.Location = new System.Drawing.Point(7, 22);
            this.tbLogs.Multiline = true;
            this.tbLogs.Name = "tbLogs";
            this.tbLogs.Size = new System.Drawing.Size(607, 91);
            this.tbLogs.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvVSQX);
            this.groupBox2.Location = new System.Drawing.Point(13, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(620, 192);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "VSQX files";
            // 
            // lvVSQX
            // 
            this.lvVSQX.HideSelection = false;
            this.lvVSQX.Location = new System.Drawing.Point(7, 22);
            this.lvVSQX.Name = "lvVSQX";
            this.lvVSQX.Size = new System.Drawing.Size(607, 164);
            this.lvVSQX.TabIndex = 0;
            this.lvVSQX.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.pbConvert);
            this.groupBox3.Controls.Add(this.btnStart);
            this.groupBox3.Controls.Add(this.btnSelDir);
            this.groupBox3.Controls.Add(this.tbPathDestDir);
            this.groupBox3.Location = new System.Drawing.Point(13, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(620, 88);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Destination Directory";
            // 
            // pbConvert
            // 
            this.pbConvert.Location = new System.Drawing.Point(7, 50);
            this.pbConvert.Name = "pbConvert";
            this.pbConvert.Size = new System.Drawing.Size(526, 23);
            this.pbConvert.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(539, 50);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnSelDir
            // 
            this.btnSelDir.Location = new System.Drawing.Point(539, 22);
            this.btnSelDir.Name = "btnSelDir";
            this.btnSelDir.Size = new System.Drawing.Size(75, 23);
            this.btnSelDir.TabIndex = 1;
            this.btnSelDir.Text = "Select";
            this.btnSelDir.UseVisualStyleBackColor = true;
            this.btnSelDir.Click += new System.EventHandler(this.btnSelDir_Click);
            // 
            // tbPathDestDir
            // 
            this.tbPathDestDir.Location = new System.Drawing.Point(7, 21);
            this.tbPathDestDir.Name = "tbPathDestDir";
            this.tbPathDestDir.Size = new System.Drawing.Size(526, 23);
            this.tbPathDestDir.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(645, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVSQXToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addVSQXToolStripMenuItem
            // 
            this.addVSQXToolStripMenuItem.Name = "addVSQXToolStripMenuItem";
            this.addVSQXToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.addVSQXToolStripMenuItem.Text = "Add VSQX";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "VSQX2CCS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbLogs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvVSQX;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar pbConvert;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSelDir;
        private System.Windows.Forms.TextBox tbPathDestDir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVSQXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
    }
}

