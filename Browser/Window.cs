using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;


namespace Browser
{
    public partial class Window : Form
    {
        //attribute for currentURL 
        private string _currentUrl;
        //attribute for  currentRequest
        private HTTPRequest _currentRequest;
        //attribute for  browser 
        private Browser _browser;
        //attribute for Current website 
        private Website _currentWebsite;
        //attribute for home form
        private Home _homeDia;


        //constructor
        public Window()
        {


            InitializeComponent();
            //this._browser = new browser object passing richTextBox1 as html display and textBox2 as html codeDisplay
            this._browser = new Browser(richTextBox1);

            //load in browser history
            this._browser.History.LoadHistory();

            //load in browser favourites
            this._browser.Favourites.LoadFavourites();

            //set this._currentRequest to new HTTPRequest object
            this._currentRequest = new HTTPRequest();

            try
            {
                //set the current url to the saved browser homepage
                this._currentUrl = this._browser.HomePage.WebUrl;

                //set the richTextBox1(display for HTML stream) to the browser homepage html stream
                richTextBox1.Text = this._browser.HomePage.Stream;

                //set the form title and code to the browser homepage title and code
                this.Text = "Browser: " + this._browser.CurrentWebsite.Title + " - " + this._browser.HomePage.Code;
            }
            catch
            {
                //this._currentURL equals the response stream of the HTTP response using the provided default homepage
                this._currentUrl = this._currentRequest.getResponse("https://www2.macs.hw.ac.uk/~lm168/");

                //this._currentWebsite equals a new website object created using the default URL , the html stream of this url, the html code of this url
                this._currentWebsite = new Website("https://www2.macs.hw.ac.uk/~lm168/", this._currentUrl, this._currentRequest.Code.ToString());

                //set the browser homepage to the currentwebsite attribute
                this._browser.HomePage = this._currentWebsite;

                //add this new website to the history
                this._browser.History.AddWebsite(this._currentWebsite);

                //updates the current website of the browser 
                this._browser.CurrentWebsite = this._currentWebsite;


                //richTextBox1 equals the html stream returned by the current website of the browser
                richTextBox1.Text = this._currentUrl;

                //update the title and code of the form to the title and form of the current website of the browser
                this.Text = this._currentWebsite.Title + " - " + this._currentWebsite.Code;
            }
            
        }


        /*This method is for when the go(search button) is clicked
         * It will take the url provided by the user and generate the HTTP response
         * Displaying the html stream and code to the window
         * As well as updating the history of the browser
         */
        private void Go_Click(object sender, EventArgs e)
        {
            //if textBox1 is not empty then
            if (!textBox1.Text.Equals(""))
            {
                //this._currentURL equals the response stream of the HTTP response using the provided URL (textBox1.Text) from user
                this._currentUrl = this._currentRequest.getResponse(textBox1.Text);

                //this._currentWebsite equals a new website object created using the URL provided by the user, the html stream of this url, the html code of this url
                this._currentWebsite = new Website(textBox1.Text, this._currentUrl, this._currentRequest.Code.ToString());

                //add this new website to the history
                this._browser.History.AddWebsite(this._currentWebsite);

                //updates the current website of the browser 
                this._browser.CurrentWebsite = this._currentWebsite;

                //richTextBox1 equals the html stream returned by the current website of the browser
                richTextBox1.Text = this._currentUrl;

                //update the title and code of the form to the title and code of the current website of the browser
                this.Text = this._currentWebsite.Title + " - " + this._currentWebsite.Code;
            }

        }


        /*This method is for when the refresh button is clicked
         * It will create a new HTTPRequest for the current website of the browser 
         * refresh the display
         * and add a new occurence of the website request to history
         */
        private void Refresh_Click(object sender, EventArgs e)
        {
            //if there is a current website then
            if (!this._currentUrl.Equals(""))
            {
                //this._currentUrL equals the new html response stream fro the current websites url
                this._currentUrl = this._currentRequest.getResponse(this._browser.CurrentWebsite.WebUrl);

                //this._currentWebsite equals a new website object created using the URL of the current website, the html stream of this url, the html code of this url
                this._currentWebsite = new Website(this._browser.CurrentWebsite.WebUrl, this._currentUrl, this._currentRequest.Code.ToString());

                //set browser current website to this newly generated website
                this._browser.CurrentWebsite = this._currentWebsite;

                //update the dispaly with the new html stream
                richTextBox1.Text = this._browser.CurrentWebsite.Stream;

                //update the title and code of the form to the title and code of the current website of the browser
                this.Text = this._currentWebsite.Title + " - " + this._currentWebsite.Code;

                //add this new request of the current website to history
                this._browser.History.AddWebsite(this._browser.CurrentWebsite);
            }
            else
            {
                //send warning to user
                richTextBox1.Text = "No Website to refresh, Please search";
            }

        }

        /*This method is for when the home button is clicked
         * This method will update date the display to show the stream of homepage
         * as well as adding this new occurence to the history
         */

        private void homeButton_Click(object sender, EventArgs e)
        {
            //this._currentUrL equals the new html response stream fro the homepages url
            this._currentUrl = this._currentRequest.getResponse(this._browser.HomePage.WebUrl);

            //update the code of the browser homepage
            this._browser.HomePage.Code = this._currentRequest.Code.ToString();

            //update the stream of the browser homepage
            this._browser.HomePage.Stream = this._currentUrl;

            //update the title and code of the form to the homepage title and code
            this.Text = this._browser.HomePage.Title + " - " + this._browser.HomePage.Code;

            //update the browsers current website to be the homepage
            this._browser.CurrentWebsite = this._browser.HomePage;

            //add a new occurence to history
            this._browser.History.AddWebsite(this._browser.HomePage);

            //update the display to new html stream of homepage
            richTextBox1.Text = this._browser.HomePage.Stream;
        }

        /*This method is for when the back page button is clicked
         * This method will get the previous website in the history 
         * and update the form to the previous website
         * 
         */
        private void backPage_Click(object sender, EventArgs e)
        {
            //get the index(key) of the previous website in history
            int prev = this._browser.History.Prev(this._browser.History.Head);

            //if prev isnt -1 then (-1 is the value for there is no previous from my history.Prev method)
            if (prev != -1)
            {
                //checking the value returned isnt null
                if (this._browser.History.Hist[prev] != null)
                {
                    //update the currentURL to the be the html stream of the previous website
                    this._currentUrl = this._browser.History.Hist[prev].Stream;

                    //update the display to the be the html stream of the previous website
                    richTextBox1.Text = this._browser.History.Hist[prev].Stream;

                    //update the head of the history to equal the index(key) of prev
                    this._browser.History.Head = prev;

                    //update the current website of the browser to be the previous website
                    this._browser.CurrentWebsite = this._browser.History.Hist[prev];

                    //update the title and code of the form to be the title and code of the previous website
                    this.Text = this._browser.CurrentWebsite.Title + " - " + this._browser.History.Hist[prev].Code;
                }
            }


        }

        /*This method is for when the forward page button is clicked 
         * This method will get the next website in the history
         * and update the form to the next website
         */
        private void forwardPage_Click(object sender, EventArgs e)
        {
            //get the index(key) of the next website in history
            int next = this._browser.History.Next(this._browser.History.Head);

            //if next isnt -1 then (-1 is the value for there is no next from my history.Next method)
            if (next != -1)
            {
                //checking the value returned isnt null
                if (this._browser.History.Hist[next] != null)
                {
                    //update the currentURL to the be the html stream of the next website
                    this._currentUrl = this._browser.History.Hist[next].Stream;

                    //update the display to the be the html stream of the next website
                    richTextBox1.Text = this._browser.History.Hist[next].Stream;

                    //update the head of the history to equal the index(key) of next
                    this._browser.History.Head = next;

                    //update the current website of the browser to be the next website
                    this._browser.CurrentWebsite = this._browser.History.Hist[next];

                    //update the title and code of the form to be the title and code of the next website
                    this.Text = this._browser.CurrentWebsite.Title + " - " + this._browser.History.Hist[next].Code;
                }
            }

        }




        /*This method is triggered when the form is closed
         * It saves the browser state
         */
        private void Window_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            //saves the browser size
            this._browser.Save();
        }


        /*This method is us when the home option of tool strip is clicked
         * This method opens the setting home dialog form
         */
        private void addHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create new home form 
            this._homeDia = new Home();

            //show dialog form
            this._homeDia.ShowDialog();
            //if formed is not in focus i.e been closed
            if (!this._homeDia.Focused)
            {
                //call homeclosed() method
                this.HomeClosed();
            }

        }

        /* This method is called when the home dialog form is closed
         * It updates the homepage of the browser
         */
        public void HomeClosed()
        {
            //gets the homeURL given by user from home form and makes sure its not null
            if (this._homeDia.HomeURL != null)
            {
                //create a new HTTPRequest object
                HTTPRequest homePageRequest = new HTTPRequest();

                //get the html response of the new homepage url
                String homepageResponse = homePageRequest.getResponse(this._homeDia.HomeURL);

                //update the browser homepage to a new website object for the home URL provided by the user
                this._browser.HomePage = new Website(this._homeDia.HomeURL, homepageResponse, homePageRequest.Code.ToString());
            }

        }

        /* This method is triggered when the history option of the tool strip is clicked
         * It creates a new history dialog form
         */
        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create a new history dialog form object passing the browser and currentURL
            HistoryDialog historyDia = new HistoryDialog(this._browser, this._currentUrl);

            //show the history dialog form
            historyDia.ShowDialog();

            //update form title
            this.Text = this._browser.CurrentWebsite.Title + " - " + this._browser.CurrentWebsite.Code;
        }


        /*This method is triggered when the favourites option of the tool strip is clicked
         * It creates a new history dialog form 
         * 
         */
        private void favouritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create a new favourite dialog form object passing the browser and currentURL
            Favourites favouriteDia = new Favourites(this._browser, this._currentUrl);

            //show the favourite dialog form
            favouriteDia.ShowDialog();

            //update form title
            this.Text = this._browser.CurrentWebsite.Title + " - " + this._browser.CurrentWebsite.Code;
        }


        /*This method is for the favourite button is clicked on the homepage
         * This method opens the quick add favourite dialog form
         */
        private void favouriteHomeButton_Click(object sender, EventArgs e)
        {
            //create favourite quick dialog object passing the browser and currentURL
            favouriteQuickAdd favouriteQuick = new favouriteQuickAdd(this._browser);

            //show the favourite quick dialog 
            favouriteQuick.ShowDialog();
        }

        /*This method is for when the bulk option of tool strip is clicked 
         * it creates a new bulk dialog form
         */
        private void bulkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creates a new bulk dialog form object passing the browser
            Bulk bulk = new Bulk(this._browser);

            //show the bulk dialog form
            bulk.ShowDialog();
        }

        /*This method deals with the key shortcuts for each form and buttons on the homepage
         * 
         */
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            //Ctrl + b to open the bulk form
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.B)
            {
                //creates a new bulk dialog form object passing the browser
                Bulk bulk = new Bulk(this._browser);

                //show the bulk dialog form
                bulk.ShowDialog();
            }

            //Ctrl + f to open the favourite form
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.F)
            {
                //create a new favourite dialog form object passing the browser and currentURL
                Favourites favouriteDia = new Favourites(this._browser, this._currentUrl);

                //show the favourite dialog form
                favouriteDia.ShowDialog();

                //update form title
                this.Text = this._browser.CurrentWebsite.Title;
            }

            //Ctrl + h to open the history form
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.H)
            {
                //Create a new history dialog form object passing the browser and currentURL
                HistoryDialog historyDia = new HistoryDialog(this._browser, this._currentUrl);

                //show the history dialog form
                historyDia.ShowDialog();

                //update form title
                this.Text = this._browser.CurrentWebsite.Title;
            }

            //Ctrl + Alt + h open the home form 
            if (e.Control && e.Alt && e.KeyCode == Keys.H)
            {
                //create new home form 
                this._homeDia = new Home();

                //show dialog form
                this._homeDia.ShowDialog();
                //if formed is not in focus i.e been closed
                if (!this._homeDia.Focused)
                {
                    //call homeclosed() method
                    this.HomeClosed();
                }


            }

            //Ctrl + Alt + f open the quick add favourite
            if (e.Control && e.Alt && e.KeyCode == Keys.F)
            {
                //create favourite quick dialog object passing the browser and currentURL
                favouriteQuickAdd favouriteQuick = new favouriteQuickAdd(this._browser);

                //show the favourite quick dialog 
                favouriteQuick.ShowDialog();

            }

            //Ctrl + r to refresh form
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.R)
            {
                //if there is a current website then
                if (!this._currentUrl.Equals(""))
                {
                    //this._currentUrL equals the new html response stream fro the current websites url
                    this._currentUrl = this._currentRequest.getResponse(this._browser.CurrentWebsite.WebUrl);

                    //this._currentWebsite equals a new website object created using the URL of the current website, the html stream of this url, the html code of this url
                    this._currentWebsite = new Website(this._browser.CurrentWebsite.WebUrl, this._currentUrl, this._currentRequest.Code.ToString());

                    //set browser current website to this newly generated website
                    this._browser.CurrentWebsite = this._currentWebsite;

                    //update the dispaly with the new html stream
                    richTextBox1.Text = this._browser.CurrentWebsite.Stream;

                    //update the title and code of the form to the title and code of the current website of the browser
                    this.Text = this._currentWebsite.Title + " - " + this._currentWebsite.Code;

                    //add this new request of the current website to history
                    this._browser.History.AddWebsite(this._browser.CurrentWebsite);
                }
                else
                {
                    //send warning to user
                    richTextBox1.Text = "No Website to refresh, Please search";
                }
            }


            //Ctrl + left arrow to go back a page 
            if (e.Control && e.KeyCode == Keys.Left)
            {
                //get the index(key) of the previous website in history
                int prev = this._browser.History.Prev(this._browser.History.Head);

                //if prev isnt -1 then (-1 is the value for there is no previous from my history.Prev method)
                if (prev != -1)
                {
                    //checking the value returned isnt null
                    if (this._browser.History.Hist[prev] != null)
                    {
                        //update the currentURL to the be the html stream of the previous website
                        this._currentUrl = this._browser.History.Hist[prev].Stream;

                        //update the display to the be the html stream of the previous website
                        richTextBox1.Text = this._browser.History.Hist[prev].Stream;

                        //update the head of the history to equal the index(key) of prev
                        this._browser.History.Head = prev;

                        //update the current website of the browser to be the previous website
                        this._browser.CurrentWebsite = this._browser.History.Hist[prev];

                        //update the title and code of the form to be the title and code of the previous website
                        this.Text = this._browser.CurrentWebsite.Title + " - " + this._browser.History.Hist[prev].Code;
                    }
                }
            }


            //Ctrl + right arrow to go forward a page
            if (e.Control && e.KeyCode == Keys.Right)
            {
                //get the index(key) of the next website in history
                int next = this._browser.History.Next(this._browser.History.Head);

                //if next isnt -1 then (-1 is the value for there is no next from my history.Next method)
                if (next != -1)
                {
                    //checking the value returned isnt null
                    if (this._browser.History.Hist[next] != null)
                    {
                        //update the currentURL to the be the html stream of the next website
                        this._currentUrl = this._browser.History.Hist[next].Stream;

                        //update the display to the be the html stream of the next website
                        richTextBox1.Text = this._browser.History.Hist[next].Stream;

                        //update the head of the history to equal the index(key) of next
                        this._browser.History.Head = next;

                        //update the current website of the browser to be the next website
                        this._browser.CurrentWebsite = this._browser.History.Hist[next];

                        //update the title and code of the form to be the title and code of the next website
                        this.Text = this._browser.CurrentWebsite.Title + " - " + this._browser.History.Hist[next].Code;
                    }
                }
            }
        }
    }
}
