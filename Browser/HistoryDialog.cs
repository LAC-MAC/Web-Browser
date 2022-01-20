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
    public partial class HistoryDialog : Form
    {
        //varaiable for the browser passed in as a parameter
        private Browser _browser;

        //Listbox component to display the history results
        private ListBox _webHistory;

        //list of website that mirrors(has the same indexs) as the listbox items (so i can get the website object)
        private List<Website> _webHistoryWebsites;

        //list of keys of the pairs that mirror(has the same indexs) as the listbox items
        private List<int> _webHistoryKeys;

        //string for currentURL being displayed
        private String _currentURL;

       

        //constructor
        public HistoryDialog(Browser browser, String currentURL)
        {
            //this.browser equals the browser passed in as a parameter
            this._browser = browser;

            //this.currentURL equals the currentURL passed in as a parameter
            this._currentURL = currentURL;

            InitializeComponent();
        }

        //On load of the History dialog component
        private void HistoryDialog_Load(object sender, EventArgs e)
        {
            //call the updateListBox method
            updateListBox();
        }


       //UpdateListBox Method
       //populates the Listbox with the items from history
        private void updateListBox()
        {
            //assign this._webHistoryWebsites to a new list of websites
            this._webHistoryWebsites = new List<Website>();

            //assign this._webHistoryKey to a new list of ints
            this._webHistoryKeys = new List<int>();

            //clear the the listbox 
            historyBox.Items.Clear();

            //set this._webHistory to historyBox component
            this._webHistory = historyBox;

            //set the size of listbox 
            this._webHistory.Size = new System.Drawing.Size(575, 475);

            //get the size of history Dictionary i.e how many history entries there is
            int i = _browser.History.Hist.Count;

            //loop while i isnt negative
            while (i >= 0)
            {
                //try catch incase the pair at current index i has been removed and now doesn't exist
                try
                {
                    //add the value(website) to the list for website 
                    this._webHistoryWebsites.Add(_browser.History.Hist[i]);

                    //add the key to the list for keys
                    this._webHistoryKeys.Add(i);

                    //add webURL of website of the pair at index i to the listbox 
                    this._webHistory.Items.Add(_browser.History.Hist[i].WebUrl);

                    //decrement the index
                    i--;
                }
                catch
                {
                    //there isnt a pair at current index i, still decrement i 
                    i--;
                }


            }
            //add listbox to controls
            this.Controls.Add(_webHistory);
        }

        //clearHistory method for when clearHistory button is clicked
        private void ClearHistory_Click(object sender, EventArgs e)
        {
            //create a new blank history object
            History history = new History();

            //set the browser history to equal new blank object
            this._browser.History = history;

            //save this new history to file
            this._browser.History.SaveHistory();

            //remove the current listbox from the form
            this.Controls.Remove(this._webHistory);

            //call updateListBox to generate new listBox
            updateListBox();
        }

        

       
        //removeHistory method for when the removeHistory button is clicked
        private void removeHistory_Click(object sender, EventArgs e)
        {
            //try catch incase no entry is selected
            try
            {
                
                 
                //then remove the dictionary pair from history using the key from webHistoryKeys
                this._browser.History.RemoveWebsite(this._webHistoryKeys[this._webHistory.SelectedIndex]);
                     
                //removed listbox from form
                this.Controls.Remove(this._webHistory);

                //generate new updated listbox
                updateListBox();
            }
            catch
            {
                //show warning to user
                MessageBox.Show("Please select a entry");
            }
           
            

        }
        //method for when a entry is double clicked, visit corresponding website
        private void historyBox_DoubleClick(object sender, EventArgs e)
        {
            //add a new occurence of selected website to history
            _browser.History.AddWebsite(_webHistoryWebsites[_webHistory.SelectedIndex]);

            //set browser current website to the selected website from history listbox
            _browser.CurrentWebsite = _webHistoryWebsites[_webHistory.SelectedIndex];

            //set the main display for html to the stream of the selected website from history listbox 
            _browser.Display.Text = _webHistoryWebsites[_webHistory.SelectedIndex].Stream;

            //removed listbox from form
            this.Controls.Remove(this._webHistory);

            //close dialog
            this.Close();

        }
    }
}
