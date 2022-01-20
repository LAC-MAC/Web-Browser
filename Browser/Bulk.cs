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

namespace Browser
{
    public partial class Bulk : Form
    {
        //variable for browser object 
        private Browser _browser;

        //list variable for URLs from  bulk file
        private List<string> _URLs;

        //attribute for the response string 
        private string _responseString;


        //constructor for Bulk form
        public Bulk(Browser browser)
        {
            //this.browser equals browser object passed as a parameter
            this._browser = browser;

            //this.URLs equals new list of strings
            this._URLs = new List<string>();

            InitializeComponent();
        }
        //method for click of BulkButton
        private void BulkButton_Click(object sender, EventArgs e)
        {
            //instantiation of fileName
            string fileName = "";

            //instantiation lines for reading file
            IEnumerable<string> lines = null;

            //if the text box is empty then 
            if (BulkTextBox.Text.Equals(""))
            {
                //filename is default bulk.txt
                fileName = @"C:\Users\UserN\Desktop\bulk.txt";
            }
            else
            {
                //else set the filename to the text provided by user
                fileName = BulkTextBox.Text;
            }
            try
            {
                //set lines to the lines read from file
                lines = File.ReadLines(fileName);
            }
            catch
            {
                //show error to user if issue with file path
                MessageBox.Show("Cannot find file or illegal file name");
            }
            //check readlines of file has taken place i.e lines is not null
            if(lines != null)
            {
                //iterator over lines of file
                foreach (var line in lines)
                {
                    //add URL(line) to list of URLs
                    this._URLs.Add(line);
                }
                //provide user feedback, so they know its taking some time
                _browser.Display.Text = "This may take some time";

                //call bulkRequest method
                this.BulkRequest();

                //display the result of bulkRequest to screen
                _browser.Display.Text = _responseString;

                //close dialog box
                this.Close();
            }
            
        }

        private void BulkRequest()
        {
            //create string builder variable
            var sb = new System.Text.StringBuilder();

            //append columns titles to string
            sb.Append(String.Format("{0,10}{1,10}{2,10}\n\n", "Code", "Length", "URL"));

            //iterator for URLs 
            foreach (var request in _URLs)
            {
                //create a new HTTPRequest object
                HTTPRequest pageRequest = new HTTPRequest();

                //get a response for the URL
                String homepageResponse = pageRequest.getResponse(request);

                //append the results code, length and URL in a format to string builder
                sb.Append(String.Format("{0,10}{1,11}{2,30}\n", pageRequest.Code.ToString(), pageRequest.LengthBytes.ToString(), request));
                
            }
            //set responseString to the completed string builder result
            this._responseString = sb.ToString();
        }
    }
}
