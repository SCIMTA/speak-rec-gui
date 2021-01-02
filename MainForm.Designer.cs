
using System.Windows.Forms;

namespace SpeakRec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnShowSub = new System.Windows.Forms.Button();
            this.listPerson = new System.Windows.Forms.ListView();
            this.btnShowListPerson = new System.Windows.Forms.Button();
            this.ListSub = new System.Windows.Forms.ListView();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnExportText = new System.Windows.Forms.Button();
            this.tbSub = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personJoinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listPersonJoinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenFile.BackgroundImage = global::SpeakRec.Properties.Resources.open;
            this.btnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenFile.Enabled = false;
            this.btnOpenFile.FlatAppearance.BorderSize = 0;
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Location = new System.Drawing.Point(49, 11);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(33, 31);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnShowSub
            // 
            this.btnShowSub.BackColor = System.Drawing.Color.Transparent;
            this.btnShowSub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowSub.BackgroundImage")));
            this.btnShowSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowSub.Enabled = false;
            this.btnShowSub.FlatAppearance.BorderSize = 0;
            this.btnShowSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowSub.Location = new System.Drawing.Point(131, 11);
            this.btnShowSub.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowSub.Name = "btnShowSub";
            this.btnShowSub.Size = new System.Drawing.Size(33, 31);
            this.btnShowSub.TabIndex = 10;
            this.btnShowSub.UseVisualStyleBackColor = false;
            this.btnShowSub.Click += new System.EventHandler(this.btnShowSub_Click);
            // 
            // listPerson
            // 
            this.listPerson.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listPerson.HideSelection = false;
            this.listPerson.Location = new System.Drawing.Point(1191, 32);
            this.listPerson.Margin = new System.Windows.Forms.Padding(4);
            this.listPerson.Name = "listPerson";
            this.listPerson.Size = new System.Drawing.Size(477, 200);
            this.listPerson.TabIndex = 12;
            this.listPerson.UseCompatibleStateImageBehavior = false;
            // 
            // btnShowListPerson
            // 
            this.btnShowListPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnShowListPerson.BackgroundImage = global::SpeakRec.Properties.Resources.list;
            this.btnShowListPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowListPerson.FlatAppearance.BorderSize = 0;
            this.btnShowListPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowListPerson.Location = new System.Drawing.Point(8, 11);
            this.btnShowListPerson.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowListPerson.Name = "btnShowListPerson";
            this.btnShowListPerson.Size = new System.Drawing.Size(33, 31);
            this.btnShowListPerson.TabIndex = 14;
            this.btnShowListPerson.UseVisualStyleBackColor = false;
            this.btnShowListPerson.Click += new System.EventHandler(this.btnShowListPerson_Click);
            // 
            // ListSub
            // 
            this.ListSub.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ListSub.HideSelection = false;
            this.ListSub.Location = new System.Drawing.Point(0, 240);
            this.ListSub.Margin = new System.Windows.Forms.Padding(4);
            this.ListSub.Name = "ListSub";
            this.ListSub.Size = new System.Drawing.Size(1684, 591);
            this.ListSub.TabIndex = 15;
            this.ListSub.UseCompatibleStateImageBehavior = false;
            this.ListSub.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListSub_ItemSelectionChanged);
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.Transparent;
            this.btnRecord.BackgroundImage = global::SpeakRec.Properties.Resources.record;
            this.btnRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecord.Enabled = false;
            this.btnRecord.FlatAppearance.BorderSize = 0;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.Location = new System.Drawing.Point(90, 11);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(33, 31);
            this.btnRecord.TabIndex = 16;
            this.btnRecord.Tag = "r";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnExportText
            // 
            this.btnExportText.BackColor = System.Drawing.Color.Transparent;
            this.btnExportText.BackgroundImage = global::SpeakRec.Properties.Resources.export;
            this.btnExportText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportText.Enabled = false;
            this.btnExportText.FlatAppearance.BorderSize = 0;
            this.btnExportText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportText.Location = new System.Drawing.Point(172, 11);
            this.btnExportText.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportText.Name = "btnExportText";
            this.btnExportText.Size = new System.Drawing.Size(33, 31);
            this.btnExportText.TabIndex = 17;
            this.btnExportText.UseVisualStyleBackColor = false;
            this.btnExportText.Click += new System.EventHandler(this.btnExportText_Click);
            // 
            // tbSub
            // 
            this.tbSub.Enabled = false;
            this.tbSub.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSub.Location = new System.Drawing.Point(12, 122);
            this.tbSub.Margin = new System.Windows.Forms.Padding(4);
            this.tbSub.Multiline = true;
            this.tbSub.Name = "tbSub";
            this.tbSub.Size = new System.Drawing.Size(1165, 110);
            this.tbSub.TabIndex = 18;
            this.tbSub.TextChanged += new System.EventHandler(this.tbSub_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbName.Location = new System.Drawing.Point(12, 82);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(725, 30);
            this.tbName.TabIndex = 19;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.personJoinToolStripMenuItem,
            this.textToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuMain.Size = new System.Drawing.Size(1685, 28);
            this.menuMain.TabIndex = 20;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.recordToolStripMenuItem,
            this.managerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openFileToolStripMenuItem.Text = "Mở file";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.recordToolStripMenuItem.Text = "Ghi âm";
            this.recordToolStripMenuItem.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.managerToolStripMenuItem.Text = "Quản trị";
            this.managerToolStripMenuItem.Click += new System.EventHandler(this.managerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Thoát";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // personJoinToolStripMenuItem
            // 
            this.personJoinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listPersonJoinToolStripMenuItem});
            this.personJoinToolStripMenuItem.Name = "personJoinToolStripMenuItem";
            this.personJoinToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.personJoinToolStripMenuItem.Text = "Người tham gia";
            // 
            // listPersonJoinToolStripMenuItem
            // 
            this.listPersonJoinToolStripMenuItem.Name = "listPersonJoinToolStripMenuItem";
            this.listPersonJoinToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.listPersonJoinToolStripMenuItem.Text = "Danh sách người tham gia";
            this.listPersonJoinToolStripMenuItem.Click += new System.EventHandler(this.btnShowListPerson_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSubToolStripMenuItem,
            this.exportSubToolStripMenuItem});
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.textToolStripMenuItem.Text = "Văn bản";
            // 
            // showSubToolStripMenuItem
            // 
            this.showSubToolStripMenuItem.Name = "showSubToolStripMenuItem";
            this.showSubToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.showSubToolStripMenuItem.Text = "Xem kèm phụ đề";
            this.showSubToolStripMenuItem.Click += new System.EventHandler(this.btnShowSub_Click);
            // 
            // exportSubToolStripMenuItem
            // 
            this.exportSubToolStripMenuItem.Name = "exportSubToolStripMenuItem";
            this.exportSubToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.exportSubToolStripMenuItem.Text = "Xuất phụ đề";
            this.exportSubToolStripMenuItem.Click += new System.EventHandler(this.btnExportText_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(744, 82);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 30);
            this.textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox2.Location = new System.Drawing.Point(965, 82);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 30);
            this.textBox2.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExportText);
            this.groupBox1.Controls.Add(this.btnShowSub);
            this.groupBox1.Controls.Add(this.btnShowListPerson);
            this.groupBox1.Controls.Add(this.btnOpenFile);
            this.groupBox1.Controls.Add(this.btnRecord);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1167, 47);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSub);
            this.Controls.Add(this.ListSub);
            this.Controls.Add(this.listPerson);
            this.Controls.Add(this.menuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ứng dụng nhận dạng giọng nói";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnShowSub;
        public System.Windows.Forms.ListView listPerson;
        private System.Windows.Forms.Button btnShowListPerson;
        private System.Windows.Forms.ListView ListSub;
        public System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnExportText;
        private System.Windows.Forms.TextBox tbSub;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.MenuStrip menuMain;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem personJoinToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem listPersonJoinToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem showSubToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem exportSubToolStripMenuItem;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private ToolStripMenuItem managerToolStripMenuItem;
    }
}

