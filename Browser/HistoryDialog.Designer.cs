
namespace Browser
{
    partial class HistoryDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryDialog));
            this.ClearHistory = new System.Windows.Forms.Button();
            this.removeHistory = new System.Windows.Forms.Button();
            this.historyBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ClearHistory
            // 
            this.ClearHistory.Location = new System.Drawing.Point(12, 517);
            this.ClearHistory.Name = "ClearHistory";
            this.ClearHistory.Size = new System.Drawing.Size(75, 23);
            this.ClearHistory.TabIndex = 0;
            this.ClearHistory.Text = "Clear History";
            this.ClearHistory.UseVisualStyleBackColor = true;
            this.ClearHistory.Click += new System.EventHandler(this.ClearHistory_Click);
            // 
            // removeHistory
            // 
            this.removeHistory.Location = new System.Drawing.Point(93, 517);
            this.removeHistory.Name = "removeHistory";
            this.removeHistory.Size = new System.Drawing.Size(75, 23);
            this.removeHistory.TabIndex = 2;
            this.removeHistory.Text = "Remove";
            this.removeHistory.UseVisualStyleBackColor = true;
            this.removeHistory.Click += new System.EventHandler(this.removeHistory_Click);
            // 
            // historyBox
            // 
            this.historyBox.FormattingEnabled = true;
            this.historyBox.Location = new System.Drawing.Point(13, 27);
            this.historyBox.Name = "historyBox";
            this.historyBox.Size = new System.Drawing.Size(587, 472);
            this.historyBox.TabIndex = 3;
            this.historyBox.DoubleClick += new System.EventHandler(this.historyBox_DoubleClick);
            // 
            // HistoryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 608);
            this.Controls.Add(this.historyBox);
            this.Controls.Add(this.removeHistory);
            this.Controls.Add(this.ClearHistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistoryDialog";
            this.Text = "HistoryDialog";
            this.Load += new System.EventHandler(this.HistoryDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClearHistory;
        private System.Windows.Forms.Button removeHistory;
        private System.Windows.Forms.ListBox historyBox;
    }
}