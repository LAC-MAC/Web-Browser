
namespace Browser
{
    partial class Favourites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Favourites));
            this.AddFavourite = new System.Windows.Forms.Button();
            this.favouriteName = new System.Windows.Forms.TextBox();
            this.FavouriteURL = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.URLLABEL = new System.Windows.Forms.Label();
            this.removeFavourite = new System.Windows.Forms.Button();
            this.ChangeNameButton = new System.Windows.Forms.Button();
            this.listViewWebFavourites = new System.Windows.Forms.ListView();
            this.changeNameFavourite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clearAllFav = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddFavourite
            // 
            this.AddFavourite.Location = new System.Drawing.Point(562, 601);
            this.AddFavourite.Name = "AddFavourite";
            this.AddFavourite.Size = new System.Drawing.Size(75, 23);
            this.AddFavourite.TabIndex = 0;
            this.AddFavourite.Text = "Add";
            this.AddFavourite.UseVisualStyleBackColor = true;
            this.AddFavourite.Click += new System.EventHandler(this.AddFavourite_Click);
            // 
            // favouriteName
            // 
            this.favouriteName.Location = new System.Drawing.Point(12, 604);
            this.favouriteName.Name = "favouriteName";
            this.favouriteName.Size = new System.Drawing.Size(155, 20);
            this.favouriteName.TabIndex = 1;
            // 
            // FavouriteURL
            // 
            this.FavouriteURL.Location = new System.Drawing.Point(195, 604);
            this.FavouriteURL.Name = "FavouriteURL";
            this.FavouriteURL.Size = new System.Drawing.Size(343, 20);
            this.FavouriteURL.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(13, 587);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // URLLABEL
            // 
            this.URLLABEL.AutoSize = true;
            this.URLLABEL.Location = new System.Drawing.Point(192, 588);
            this.URLLABEL.Name = "URLLABEL";
            this.URLLABEL.Size = new System.Drawing.Size(29, 13);
            this.URLLABEL.TabIndex = 4;
            this.URLLABEL.Text = "URL";
            // 
            // removeFavourite
            // 
            this.removeFavourite.Location = new System.Drawing.Point(13, 539);
            this.removeFavourite.Name = "removeFavourite";
            this.removeFavourite.Size = new System.Drawing.Size(75, 23);
            this.removeFavourite.TabIndex = 5;
            this.removeFavourite.Text = "Remove Selected";
            this.removeFavourite.UseVisualStyleBackColor = true;
            this.removeFavourite.Click += new System.EventHandler(this.removeFavourite_Click);
            // 
            // ChangeNameButton
            // 
            this.ChangeNameButton.Location = new System.Drawing.Point(562, 562);
            this.ChangeNameButton.Name = "ChangeNameButton";
            this.ChangeNameButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeNameButton.TabIndex = 6;
            this.ChangeNameButton.Text = "Modify";
            this.ChangeNameButton.UseVisualStyleBackColor = true;
            this.ChangeNameButton.Click += new System.EventHandler(this.ChangeNameButton_Click);
            // 
            // listViewWebFavourites
            // 
            this.listViewWebFavourites.HideSelection = false;
            this.listViewWebFavourites.Location = new System.Drawing.Point(13, 12);
            this.listViewWebFavourites.Name = "listViewWebFavourites";
            this.listViewWebFavourites.Size = new System.Drawing.Size(655, 521);
            this.listViewWebFavourites.TabIndex = 7;
            this.listViewWebFavourites.UseCompatibleStateImageBehavior = false;
            this.listViewWebFavourites.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewWebFavourites_MouseDoubleClick);
            // 
            // changeNameFavourite
            // 
            this.changeNameFavourite.Location = new System.Drawing.Point(195, 565);
            this.changeNameFavourite.Name = "changeNameFavourite";
            this.changeNameFavourite.Size = new System.Drawing.Size(343, 20);
            this.changeNameFavourite.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Change Name Of Favourite";
            // 
            // clearAllFav
            // 
            this.clearAllFav.Location = new System.Drawing.Point(95, 539);
            this.clearAllFav.Name = "clearAllFav";
            this.clearAllFav.Size = new System.Drawing.Size(75, 23);
            this.clearAllFav.TabIndex = 10;
            this.clearAllFav.Text = "Clear";
            this.clearAllFav.UseVisualStyleBackColor = true;
            this.clearAllFav.Click += new System.EventHandler(this.clearAllFav_Click);
            // 
            // Favourites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 655);
            this.Controls.Add(this.clearAllFav);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeNameFavourite);
            this.Controls.Add(this.listViewWebFavourites);
            this.Controls.Add(this.ChangeNameButton);
            this.Controls.Add(this.removeFavourite);
            this.Controls.Add(this.URLLABEL);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.FavouriteURL);
            this.Controls.Add(this.favouriteName);
            this.Controls.Add(this.AddFavourite);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Favourites";
            this.Text = "Favourites";
            this.Load += new System.EventHandler(this.Favourites_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddFavourite;
        private System.Windows.Forms.TextBox favouriteName;
        private System.Windows.Forms.TextBox FavouriteURL;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label URLLABEL;
        private System.Windows.Forms.Button removeFavourite;
        private System.Windows.Forms.Button ChangeNameButton;
        private System.Windows.Forms.ListView listViewWebFavourites;
        private System.Windows.Forms.TextBox changeNameFavourite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearAllFav;
    }
}