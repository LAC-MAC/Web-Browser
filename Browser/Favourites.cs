using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class Favourites : Form
    {
        //aatribute for browser object
        private Browser _browser;

        //attribute for the listview for favourites
        private ListView _WebFavourites;

        //attribute for list of website objects the mirrors(same indexs) the listview component
        private List<Website> _favouritesWebsites;

        //string for currentURL
        private String _currentURL;

        //constructor
        public Favourites(Browser browser, String currentURL)
        {
            //this._browser equals the browser passed in as a parameter
            this._browser = browser;

            //this.currentURL equals the currentURL passed in as a parameter
            this._currentURL = currentURL;

            InitializeComponent();
        }
        //method for when favourites form is loaded
        private void Favourites_Load(object sender, EventArgs e)
        {
            //call update listview method
            updateListView();

            //set the size of the favourites form
            this.Size = new System.Drawing.Size(700, 700);
        }
        //updateListView method
        //this method populates the listView with the favourites
        private void updateListView()
        {
            //this._favouritesWebsites equals a new lists of website objects
            this._favouritesWebsites = new List<Website>();

            //clear listview items 
            listViewWebFavourites.Items.Clear();

            //this._WebFavourites equals listview component
            this._WebFavourites = listViewWebFavourites; 

            //set name column size of list view 
            this._WebFavourites.Columns.Add("Name", 150);

            //set URL column size of list view
            this._WebFavourites.Columns.Add("URL", 600);

            //position listview component
            this._WebFavourites.Top = 20;

            //draw listview component to certain size
            this._WebFavourites.Size = new System.Drawing.Size(650, 500);

            //specifies how items are displayed in the listview 
            this._WebFavourites.View = View.Details;

            //iterator for favourites dictionary
            foreach (var item in this._browser.Favourites.Fav)
            {
                
                try
                {
                    //create array for listview row
                    string[] arr = new string[2];

                    //add the key(name) of favourites pair to first index of array
                    arr[0] = item.Key;

                    //addd the value(website) of favourtites pair to second index of array
                    arr[1] = item.Value.WebUrl;

                    //create a listviewitem using the array 
                    ListViewItem listViewItem = new ListViewItem(arr);

                    //add website to the list of favourite websites
                    this._favouritesWebsites.Add(item.Value);

                    //add listviewitem  to list view
                    this._WebFavourites.Items.Add(listViewItem);

                }
                catch
                {

                }
            }
            // add list view to form
            this.Controls.Add(this._WebFavourites);
        }

        /*
        This method is for when the favourite add button is clicked
        It will add the name and url from the fields as a new favourite 
        */
        private void AddFavourite_Click(object sender, EventArgs e)
        {
            //if either text field is not empty then  
            if(favouriteName.Text != "" & FavouriteURL.Text != "")
            {
                //create a new HTTPRequest object
                HTTPRequest currentRequest = new HTTPRequest();

                //get response from HTTPRequest using url entered by user
                string favouriteStream = currentRequest.getResponse(FavouriteURL.Text);

                //create a new website object using the URL entered by the user 
                Website favouriteWebsite = new Website(FavouriteURL.Text, favouriteStream, currentRequest.Code.ToString());

                //if there is a stream returned then 
                if (favouriteStream != null)
                {
                    //try to add new favourite to favourites dictionary
                    try
                    {
                        this._browser.Favourites.Fav.Add(favouriteName.Text, favouriteWebsite);
                    }
                    catch
                    {
                        //send warning to user
                        MessageBox.Show("Favourite exists with that name");
                    }
                    //remove old list view from form
                    this.Controls.Remove(this._WebFavourites);

                    //generate a new list view using updateListView method
                    updateListView();
                }
                else
                {
                    //send warning to user
                    MessageBox.Show("Incorrect URL");
                }
            }
            else
            {
                //send warning to user
                MessageBox.Show("Please fill out both fields");
            }
            
        }

       /*
        * method for when the remove favourite button is clicked 
        * it will removed selected favourite from the favourites dictionary
        */

        private void removeFavourite_Click(object sender, EventArgs e)
        {
            //try to remove favourite selected 
            try
            {
                //remove selected favourite from favourites dictionary
                this._browser.Favourites.RemoveFavourtie(this._WebFavourites.SelectedItems[0].SubItems[0].Text);

                //remove listview from form
                this.Controls.Remove(this._WebFavourites);

                //generate new list view using updateListView method
                updateListView();
            }
            catch
            {
                //send warning to user
                MessageBox.Show("Please select a Favourite by clicking on it");
            }


        }

       /*this method is for when a listviewitem is double click
        * it will visit the favourite selected and close dialog
        * 
        */
        private void listViewWebFavourites_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //add a new occurence of the favourite website to history
            this._browser.History.AddWebsite(this._favouritesWebsites[this._WebFavourites.SelectedIndices[0]]);

            //display the html stream to the main display for html of the browser
            this._browser.Display.Text = this._favouritesWebsites[this._WebFavourites.SelectedIndices[0]].Stream;

            //update browser current website 
            this._browser.CurrentWebsite = this._favouritesWebsites[this._WebFavourites.SelectedIndices[0]];


            //close dialog
            this.Close();
        }

        /*This method is for when the change name button is clicked 
         * it will modify the favourite selected name
         */
        private void ChangeNameButton_Click(object sender, EventArgs e)
        {
            //try to make sure a favourite is selected
            try
            { 
                this._WebFavourites.SelectedItems[0].Equals(null);

                try
                {
                    //if the changenamefavourite field is not empty then
                    if (!changeNameFavourite.Text.Equals(""))
                    {
                        //add the new favourite with the updated name
                        this._browser.Favourites.Fav.Add(changeNameFavourite.Text, this._favouritesWebsites[this._WebFavourites.SelectedIndices[0]]);

                        //remove the previous favourite with the old name
                        this._browser.Favourites.RemoveFavourtie(this._WebFavourites.SelectedItems[0].SubItems[0].Text);

                        //remove the listview from the form
                        this.Controls.Remove(this._WebFavourites);

                        //generate the new listview using method updateListView
                        updateListView();
                    }
                    else
                    {
                        //send warning to user
                        MessageBox.Show("Please enter a name");
                    }
                }
                catch
                {
                    //send warning to user
                    MessageBox.Show("Favourite Already exists with that name");
                }
                
            }
            catch
            {
                //send warning to user
                MessageBox.Show("Please select a Favourite by clicking on it");
            }
            
            
        }
        /*This method is when the clear all button has been clicked
         * it will clear all saved favourites
         */
        private void clearAllFav_Click(object sender, EventArgs e)
        {
            //create new favourite object
            Favourite favourite = new Favourite();

            //set the browser favourite to the new blank favourite object
            this._browser.Favourites = favourite;

            //save new blank favourites
            this._browser.Favourites.SaveFavourites();

            //remove list view from form
            this.Controls.Remove(this._WebFavourites);

            //generate new updated list view using updateListView method
            updateListView();
        }
    }
}
