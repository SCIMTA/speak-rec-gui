﻿
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Âm thanh vào";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Enabled = false;
            this.btnOpenFile.Location = new System.Drawing.Point(151, 14);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(69, 59);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Mở file";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thông tin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên file";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đường dẫn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(428, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Độ dài âm thanh";
            // 
            // labelSoundLength
            // 
            this.labelSoundLength.AutoSize = true;
            this.labelSoundLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoundLength.Location = new System.Drawing.Point(572, 82);
            this.labelSoundLength.Name = "labelSoundLength";
            this.labelSoundLength.Size = new System.Drawing.Size(112, 17);
            this.labelSoundLength.TabIndex = 9;
            this.labelSoundLength.Text = "Độ dài âm thanh";
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilePath.Location = new System.Drawing.Point(572, 46);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(78, 17);
            this.labelFilePath.TabIndex = 8;
            this.labelFilePath.Text = "Đường dẫn";
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileName.Location = new System.Drawing.Point(572, 9);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(55, 17);
            this.labelFileName.TabIndex = 7;
            this.labelFileName.Text = "Tên file";
            // 
            // btnShowSub
            // 
            this.btnShowSub.Enabled = false;
            this.btnShowSub.Location = new System.Drawing.Point(12, 414);
            this.btnShowSub.Name = "btnShowSub";
            this.btnShowSub.Size = new System.Drawing.Size(180, 98);
            this.btnShowSub.TabIndex = 10;
            this.btnShowSub.Text = "Xem sub";
            this.btnShowSub.UseVisualStyleBackColor = true;
            this.btnShowSub.Click += new System.EventHandler(this.showSub_Click);
            // 
            // listPerson
            // 
            this.listPerson.HideSelection = false;
            this.listPerson.Location = new System.Drawing.Point(12, 194);
            this.listPerson.Name = "listPerson";
            this.listPerson.Size = new System.Drawing.Size(532, 196);
            this.listPerson.TabIndex = 12;
            this.listPerson.UseCompatibleStateImageBehavior = false;
            // 
            // btnShowListPerson
            // 
            this.btnShowListPerson.Location = new System.Drawing.Point(294, 147);
            this.btnShowListPerson.Name = "btnShowListPerson";
            this.btnShowListPerson.Size = new System.Drawing.Size(250, 40);
            this.btnShowListPerson.TabIndex = 14;
            this.btnShowListPerson.Text = "Danh sách";
            this.btnShowListPerson.UseVisualStyleBackColor = true;
            this.btnShowListPerson.Click += new System.EventHandler(this.btnShowListPerson_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(12, 148);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(276, 40);
            this.btnAddPerson.TabIndex = 13;
            this.btnAddPerson.Text = "Thêm người";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // ListSub
            // 
            this.ListSub.HideSelection = false;
            this.ListSub.Location = new System.Drawing.Point(208, 396);
            this.ListSub.Name = "ListSub";
            this.ListSub.Size = new System.Drawing.Size(1053, 283);
            this.ListSub.TabIndex = 15;
            this.ListSub.UseCompatibleStateImageBehavior = false;
            this.ListSub.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListSub_ItemSelectionChanged);
            // 
            // btnRecord
            // 
            this.btnRecord.Enabled = false;
            this.btnRecord.Location = new System.Drawing.Point(236, 14);
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
            this.btnExportText.Location = new System.Drawing.Point(12, 554);
            this.btnExportText.Name = "btnExportText";
            this.btnExportText.Size = new System.Drawing.Size(180, 98);
            this.btnExportText.TabIndex = 17;
            this.btnExportText.Text = "Xuất văn bản";
            this.btnExportText.UseVisualStyleBackColor = true;
            this.btnExportText.Click += new System.EventHandler(this.btnExportText_Click);
            // 
            // tbSub
            // 
            this.tbSub.Enabled = false;
            this.tbSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSub.Location = new System.Drawing.Point(566, 194);
            this.tbSub.Multiline = true;
            this.tbSub.Name = "tbSub";
            this.tbSub.Size = new System.Drawing.Size(695, 196);
            this.tbSub.TabIndex = 18;
            this.tbSub.TextChanged += new System.EventHandler(this.tbSub_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(566, 153);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(695, 26);
            this.tbName.TabIndex = 19;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpeakRec";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label label2;
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
    }
}

