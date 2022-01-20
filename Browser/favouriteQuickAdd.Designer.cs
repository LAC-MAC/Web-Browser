
namespace Browser
{
    partial class favouriteQuickAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(favouriteQuickAdd));
            this.QuickAddTextBox = new System.Windows.Forms.TextBox();
            this.QuickAddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuickAddTextBox
            // 
            this.QuickAddTextBox.Location = new System.Drawing.Point(12, 42);
            this.QuickAddTextBox.Name = "QuickAddTextBox";
            this.QuickAddTextBox.Size = new System.Drawing.Size(408, 20);
            this.QuickAddTextBox.TabIndex = 0;
            // 
            // QuickAddButton
            // 
            this.QuickAddButton.Location = new System.Drawing.Point(426, 39);
            this.QuickAddButton.Name = "QuickAddButton";
            this.QuickAddButton.Size = new System.Drawing.Size(75, 23);
            this.QuickAddButton.TabIndex = 1;
            this.QuickAddButton.Text = "Add";
            this.QuickAddButton.UseVisualStyleBackColor = true;
            this.QuickAddButton.Click += new System.EventHandler(this.QuickAddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name of Favourite";
            // 
            // favouriteQuickAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 105);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuickAddButton);
            this.Controls.Add(this.QuickAddTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "favouriteQuickAdd";
            this.Text = "favouriteQuickAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QuickAddTextBox;
        private System.Windows.Forms.Button QuickAddButton;
        private System.Windows.Forms.Label label1;
    }
}