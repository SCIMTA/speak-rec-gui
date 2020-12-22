
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
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSoundLength = new System.Windows.Forms.Label();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.labelFileName = new System.Windows.Forms.Label();
            this.btnShowSub = new System.Windows.Forms.Button();
            this.listPerson = new System.Windows.Forms.ListView();
            this.btnShowListPerson = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.ListSub = new System.Windows.Forms.ListView();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnExportText = new System.Windows.Forms.Button();
            this.tbSub = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ghiÂmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiThamGiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmNgườiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchNgườiThamGiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vănBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemKèmPhụĐềToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtPhụĐềToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Enabled = false;
            this.btnOpenFile.Location = new System.Drawing.Point(12, 27);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(69, 59);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Mở file";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(562, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên file";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(562, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đường dẫn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(562, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Độ dài âm thanh";
            // 
            // labelSoundLength
            // 
            this.labelSoundLength.AutoSize = true;
            this.labelSoundLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoundLength.Location = new System.Drawing.Point(704, 105);
            this.labelSoundLength.Name = "labelSoundLength";
            this.labelSoundLength.Size = new System.Drawing.Size(112, 17);
            this.labelSoundLength.TabIndex = 9;
            this.labelSoundLength.Text = "Độ dài âm thanh";
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilePath.Location = new System.Drawing.Point(704, 66);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(78, 17);
            this.labelFilePath.TabIndex = 8;
            this.labelFilePath.Text = "Đường dẫn";
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileName.Location = new System.Drawing.Point(704, 29);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(55, 17);
            this.labelFileName.TabIndex = 7;
            this.labelFileName.Text = "Tên file";
            // 
            // btnShowSub
            // 
            this.btnShowSub.Enabled = false;
            this.btnShowSub.Location = new System.Drawing.Point(12, 396);
            this.btnShowSub.Name = "btnShowSub";
            this.btnShowSub.Size = new System.Drawing.Size(190, 147);
            this.btnShowSub.TabIndex = 10;
            this.btnShowSub.Text = "Xem kèm phụ đề";
            this.btnShowSub.UseVisualStyleBackColor = true;
            this.btnShowSub.Click += new System.EventHandler(this.showSub_Click);
            // 
            // listPerson
            // 
            this.listPerson.HideSelection = false;
            this.listPerson.Location = new System.Drawing.Point(208, 396);
            this.listPerson.Name = "listPerson";
            this.listPerson.Size = new System.Drawing.Size(352, 283);
            this.listPerson.TabIndex = 12;
            this.listPerson.UseCompatibleStateImageBehavior = false;
            // 
            // btnShowListPerson
            // 
            this.btnShowListPerson.Location = new System.Drawing.Point(237, 27);
            this.btnShowListPerson.Name = "btnShowListPerson";
            this.btnShowListPerson.Size = new System.Drawing.Size(69, 59);
            this.btnShowListPerson.TabIndex = 14;
            this.btnShowListPerson.Text = "Danh sách";
            this.btnShowListPerson.UseVisualStyleBackColor = true;
            this.btnShowListPerson.Click += new System.EventHandler(this.btnShowListPerson_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(162, 27);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(69, 59);
            this.btnAddPerson.TabIndex = 13;
            this.btnAddPerson.Text = "Thêm người";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // ListSub
            // 
            this.ListSub.HideSelection = false;
            this.ListSub.Location = new System.Drawing.Point(12, 128);
            this.ListSub.Name = "ListSub";
            this.ListSub.Size = new System.Drawing.Size(1240, 262);
            this.ListSub.TabIndex = 15;
            this.ListSub.UseCompatibleStateImageBehavior = false;
            this.ListSub.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListSub_ItemSelectionChanged);
            // 
            // btnRecord
            // 
            this.btnRecord.Enabled = false;
            this.btnRecord.Location = new System.Drawing.Point(87, 27);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(69, 59);
            this.btnRecord.TabIndex = 16;
            this.btnRecord.Text = "Ghi âm";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnExportText
            // 
            this.btnExportText.Enabled = false;
            this.btnExportText.Location = new System.Drawing.Point(12, 549);
            this.btnExportText.Name = "btnExportText";
            this.btnExportText.Size = new System.Drawing.Size(190, 130);
            this.btnExportText.TabIndex = 17;
            this.btnExportText.Text = "Xuất phụ đề";
            this.btnExportText.UseVisualStyleBackColor = true;
            this.btnExportText.Click += new System.EventHandler(this.btnExportText_Click);
            // 
            // tbSub
            // 
            this.tbSub.Enabled = false;
            this.tbSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSub.Location = new System.Drawing.Point(566, 483);
            this.tbSub.Multiline = true;
            this.tbSub.Name = "tbSub";
            this.tbSub.Size = new System.Drawing.Size(686, 196);
            this.tbSub.TabIndex = 18;
            this.tbSub.TextChanged += new System.EventHandler(this.tbSub_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(566, 451);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(686, 26);
            this.tbName.TabIndex = 19;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ngườiThamGiaToolStripMenuItem,
            this.vănBảnToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuMain.Size = new System.Drawing.Size(1264, 24);
            this.menuMain.TabIndex = 20;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mởFileToolStripMenuItem,
            this.ghiÂmToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mởFileToolStripMenuItem
            // 
            this.mởFileToolStripMenuItem.Name = "mởFileToolStripMenuItem";
            this.mởFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mởFileToolStripMenuItem.Text = "Mở file";
            // 
            // ghiÂmToolStripMenuItem
            // 
            this.ghiÂmToolStripMenuItem.Name = "ghiÂmToolStripMenuItem";
            this.ghiÂmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ghiÂmToolStripMenuItem.Text = "Ghi âm";
            // 
            // ngườiThamGiaToolStripMenuItem
            // 
            this.ngườiThamGiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmNgườiToolStripMenuItem,
            this.danhSáchNgườiThamGiaToolStripMenuItem});
            this.ngườiThamGiaToolStripMenuItem.Name = "ngườiThamGiaToolStripMenuItem";
            this.ngườiThamGiaToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.ngườiThamGiaToolStripMenuItem.Text = "Người tham gia";
            // 
            // thêmNgườiToolStripMenuItem
            // 
            this.thêmNgườiToolStripMenuItem.Name = "thêmNgườiToolStripMenuItem";
            this.thêmNgườiToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.thêmNgườiToolStripMenuItem.Text = "Thêm người";
            // 
            // danhSáchNgườiThamGiaToolStripMenuItem
            // 
            this.danhSáchNgườiThamGiaToolStripMenuItem.Name = "danhSáchNgườiThamGiaToolStripMenuItem";
            this.danhSáchNgườiThamGiaToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.danhSáchNgườiThamGiaToolStripMenuItem.Text = "Danh sách người tham gia";
            // 
            // vănBảnToolStripMenuItem
            // 
            this.vănBảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemKèmPhụĐềToolStripMenuItem,
            this.xuấtPhụĐềToolStripMenuItem});
            this.vănBảnToolStripMenuItem.Name = "vănBảnToolStripMenuItem";
            this.vănBảnToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.vănBảnToolStripMenuItem.Text = "Văn bản";
            // 
            // xemKèmPhụĐềToolStripMenuItem
            // 
            this.xemKèmPhụĐềToolStripMenuItem.Name = "xemKèmPhụĐềToolStripMenuItem";
            this.xemKèmPhụĐềToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xemKèmPhụĐềToolStripMenuItem.Text = "Xem kèm phụ đề";
            // 
            // xuấtPhụĐềToolStripMenuItem
            // 
            this.xuấtPhụĐềToolStripMenuItem.Name = "xuấtPhụĐềToolStripMenuItem";
            this.xuấtPhụĐềToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xuấtPhụĐềToolStripMenuItem.Text = "Xuất phụ đề";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSub);
            this.Controls.Add(this.btnExportText);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.ListSub);
            this.Controls.Add(this.btnShowListPerson);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.listPerson);
            this.Controls.Add(this.btnShowSub);
            this.Controls.Add(this.labelSoundLength);
            this.Controls.Add(this.labelFilePath);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.menuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuMain;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpeakRec";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSoundLength;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Button btnShowSub;
        public System.Windows.Forms.ListView listPerson;
        private System.Windows.Forms.Button btnShowListPerson;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.ListView ListSub;
        public System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnExportText;
        private System.Windows.Forms.TextBox tbSub;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mởFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ghiÂmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngườiThamGiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmNgườiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchNgườiThamGiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vănBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemKèmPhụĐềToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtPhụĐềToolStripMenuItem;
    }
}

