
namespace Browser
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Go = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.forwardPage = new System.Windows.Forms.Button();
            this.backPage = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favouriteHomeButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(505, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(674, 35);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(46, 41);
            this.Go.TabIndex = 2;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeButton.BackgroundImage")));
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeButton.Location = new System.Drawing.Point(111, 31);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(46, 44);
            this.homeButton.TabIndex = 3;
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // forwardPage
            // 
            this.forwardPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forwardPage.BackgroundImage")));
            this.forwardPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forwardPage.Location = new System.Drawing.Point(59, 30);
            this.forwardPage.Name = "forwardPage";
            this.forwardPage.Size = new System.Drawing.Size(46, 45);
            this.forwardPage.TabIndex = 4;
            this.forwardPage.UseVisualStyleBackColor = true;
            this.forwardPage.Click += new System.EventHandler(this.forwardPage_Click);
            // 
            // backPage
            // 
            this.backPage.BackColor = System.Drawing.Color.Transparent;
            this.backPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backPage.BackgroundImage")));
            this.backPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backPage.Location = new System.Drawing.Point(12, 30);
            this.backPage.Name = "backPage";
            this.backPage.Size = new System.Drawing.Size(46, 45);
            this.backPage.TabIndex = 5;
            this.backPage.UseVisualStyleBackColor = false;
            this.backPage.Click += new System.EventHandler(this.backPage_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refresh.BackgroundImage")));
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.refresh.Location = new System.Drawing.Point(726, 35);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(44, 41);
            this.refresh.TabIndex = 7;
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 78);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(805, 570);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addHomeToolStripMenuItem,
            this.favouritesToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.bulkToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // addHomeToolStripMenuItem
            // 
            this.addHomeToolStripMenuItem.Name = "addHomeToolStripMenuItem";
            this.addHomeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addHomeToolStripMenuItem.Text = "Add Home";
            this.addHomeToolStripMenuItem.Click += new System.EventHandler(this.addHomeToolStripMenuItem_Click);
            // 
            // favouritesToolStripMenuItem
            // 
            this.favouritesToolStripMenuItem.Name = "favouritesToolStripMenuItem";
            this.favouritesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.favouritesToolStripMenuItem.Text = "Favourites";
            this.favouritesToolStripMenuItem.Click += new System.EventHandler(this.favouritesToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // bulkToolStripMenuItem
            // 
            this.bulkToolStripMenuItem.Name = "bulkToolStripMenuItem";
            this.bulkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bulkToolStripMenuItem.Text = "Bulk";
            this.bulkToolStripMenuItem.Click += new System.EventHandler(this.bulkToolStripMenuItem_Click);
            // 
            // favouriteHomeButton
            // 
            this.favouriteHomeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("favouriteHomeButton.BackgroundImage")));
            this.favouriteHomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.favouriteHomeButton.Location = new System.Drawing.Point(776, 35);
            this.favouriteHomeButton.Name = "favouriteHomeButton";
            this.favouriteHomeButton.Size = new System.Drawing.Size(44, 40);
            this.favouriteHomeButton.TabIndex = 11;
            this.favouriteHomeButton.UseVisualStyleBackColor = true;
            this.favouriteHomeButton.Click += new System.EventHandler(this.favouriteHomeButton_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 660);
            this.Controls.Add(this.favouriteHomeButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.backPage);
            this.Controls.Add(this.forwardPage);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Window";
            this.Text = "Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Window_FormClosing_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Window_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button forwardPage;
        private System.Windows.Forms.Button backPage;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favouritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.Button favouriteHomeButton;
        private System.Windows.Forms.ToolStripMenuItem bulkToolStripMenuItem;
    }
}

