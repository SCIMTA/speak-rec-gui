
namespace SpeakRec
{
    partial class ManagerForm
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
            this.components = new System.ComponentModel.Container();
            this.listPersonManager = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xoáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // listPersonManager
            // 
            this.listPersonManager.HideSelection = false;
            this.listPersonManager.Location = new System.Drawing.Point(9, 48);
            this.listPersonManager.Margin = new System.Windows.Forms.Padding(2);
            this.listPersonManager.Name = "listPersonManager";
            this.listPersonManager.Size = new System.Drawing.Size(583, 309);
            this.listPersonManager.TabIndex = 0;
            this.listPersonManager.UseCompatibleStateImageBehavior = false;
            this.listPersonManager.SelectedIndexChanged += new System.EventHandler(this.listPersonManager_SelectedIndexChanged);
            this.listPersonManager.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listPersonManager_MouseDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm người";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addPersonBtn);
            // 
            // contextMenuDelete
            // 
            this.contextMenuDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xoáToolStripMenuItem});
            this.contextMenuDelete.Name = "contextMenuDelete";
            this.contextMenuDelete.Size = new System.Drawing.Size(95, 26);
            // 
            // xoáToolStripMenuItem
            // 
            this.xoáToolStripMenuItem.Name = "xoáToolStripMenuItem";
            this.xoáToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.xoáToolStripMenuItem.Text = "Xoá";
            this.xoáToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listPersonManager);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản trị";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerForm_FormClosing);
            this.contextMenuDelete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listPersonManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuDelete;
        private System.Windows.Forms.ToolStripMenuItem xoáToolStripMenuItem;
    }
}