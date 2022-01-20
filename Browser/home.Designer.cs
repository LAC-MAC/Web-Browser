
namespace Browser
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.setHome = new System.Windows.Forms.Button();
            this.homeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // setHome
            // 
            this.setHome.Location = new System.Drawing.Point(424, 39);
            this.setHome.Name = "setHome";
            this.setHome.Size = new System.Drawing.Size(75, 23);
            this.setHome.TabIndex = 0;
            this.setHome.Text = "Set Home";
            this.setHome.UseVisualStyleBackColor = true;
            this.setHome.Click += new System.EventHandler(this.setHome_Click);
            // 
            // homeTextBox
            // 
            this.homeTextBox.Location = new System.Drawing.Point(13, 39);
            this.homeTextBox.Name = "homeTextBox";
            this.homeTextBox.Size = new System.Drawing.Size(405, 20);
            this.homeTextBox.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 100);
            this.Controls.Add(this.homeTextBox);
            this.Controls.Add(this.setHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setHome;
        private System.Windows.Forms.TextBox homeTextBox;
    }
}