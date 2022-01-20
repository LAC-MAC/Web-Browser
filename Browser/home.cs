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
    public partial class Home : Form
    {
        //attribute for URL to be used for home
        private string _homeURL;

        //getter and setter method for _homeURL attribute
        public String HomeURL
        {
            get
            {
                return _homeURL;
            }
            set
            {
                _homeURL = value;
            }
        }

        //constructor
        public Home()
        {
            InitializeComponent();
        }

        /*This method is for when the set home button is clicked
         * it will set the _homeURL attribute to text from the
         * homeTextBox
         */
        private void setHome_Click(object sender, EventArgs e)
        {
            //if hometextbox isnt empty then
            if (!homeTextBox.Text.Equals(""))
            {
                //then this._homeURL equals the text from the homeTextBox
                this._homeURL = homeTextBox.Text;
                //close dialog
                this.Close();
            }
            else
            {
                //send warning to user
                MessageBox.Show("Please Enter URL");
            }
            
        }

        
    }
}
