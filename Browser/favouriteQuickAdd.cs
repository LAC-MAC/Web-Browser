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
    public partial class favouriteQuickAdd : Form
    {
        //attribute for browser
        private Browser _browser;
        public favouriteQuickAdd(Browser browser)
        {
            //set this._brower equal browser passed a parameter 
            this._browser = browser;
            InitializeComponent();
        }

        /*This method is for when the quick add button is clicked
         * This metod will add a new favourite to favourites using 
         * the name in the quick add text box and the current website 
         * searched by the user
         */
        private void QuickAddButton_Click(object sender, EventArgs e)
        {
            //check the quick add text box is not empty
            if (!QuickAddTextBox.Text.Equals(""))
            {
                //add new favourite to browser favourites
                this._browser.Favourites.AddFavourtie(_browser.CurrentWebsite, QuickAddTextBox.Text);
                //close dialog
                this.Close();
            }
            else
            {
                //send warning to user
                MessageBox.Show("Please enter a name for the favourite");
            }
        }                               
    }
}
