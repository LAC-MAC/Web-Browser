
namespace Browser
{
    partial class Bulk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bulk));
            this.BulkButton = new System.Windows.Forms.Button();
            this.BulkTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BulkButton
            // 
            this.BulkButton.Location = new System.Drawing.Point(398, 50);
            this.BulkButton.Name = "BulkButton";
            this.BulkButton.Size = new System.Drawing.Size(75, 23);
            this.BulkButton.TabIndex = 0;
            this.BulkButton.Text = "Bulk";
            this.BulkButton.UseVisualStyleBackColor = true;
            this.BulkButton.Click += new System.EventHandler(this.BulkButton_Click);
            // 
            // BulkTextBox
            // 
            this.BulkTextBox.Location = new System.Drawing.Point(13, 50);
            this.BulkTextBox.Name = "BulkTextBox";
            this.BulkTextBox.Size = new System.Drawing.Size(379, 20);
            this.BulkTextBox.TabIndex = 1;
            // 
            // Bulk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 115);
            this.Controls.Add(this.BulkTextBox);
            this.Controls.Add(this.BulkButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bulk";
            this.Text = "Bulk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BulkButton;
        private System.Windows.Forms.TextBox BulkTextBox;
    }
}