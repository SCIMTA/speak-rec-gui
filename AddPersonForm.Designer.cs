
namespace SpeakRec
{
    partial class AddPersonForm
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.labelRec = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(12, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(437, 29);
            this.tbName.TabIndex = 0;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // btnRecord
            // 
            this.btnRecord.Enabled = false;
            this.btnRecord.Location = new System.Drawing.Point(12, 108);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(204, 40);
            this.btnRecord.TabIndex = 1;
            this.btnRecord.Text = "Ghi âm";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // labelRec
            // 
            this.labelRec.AutoSize = true;
            this.labelRec.Location = new System.Drawing.Point(213, 67);
            this.labelRec.Name = "labelRec";
            this.labelRec.Size = new System.Drawing.Size(49, 13);
            this.labelRec.TabIndex = 4;
            this.labelRec.Text = "00:00:00";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Enabled = false;
            this.btnOpenFile.Location = new System.Drawing.Point(245, 108);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(204, 40);
            this.btnOpenFile.TabIndex = 5;
            this.btnOpenFile.Text = "Mở file";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // AddPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 160);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.labelRec);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddPersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPerson";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddPersonForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Label labelRec;
        private System.Windows.Forms.Button btnOpenFile;
    }
}