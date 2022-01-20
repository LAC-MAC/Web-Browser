using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace Browser
{
    public class Browser
    {
        //Attribute for the current website of the browser
        private Website _currentWebsite;

        //attribute for the display passed to the browser
        private RichTextBox _display;

        //attribute for the homepage loaded in
        private Website _homepage;

        //attribute for the history loaded in
        private History _history;

        //attribute for the favourites loaded in
        private Favourite _favourites;


        //constructor
        public Browser(RichTextBox display)
        {
            //set this._display to the display passed in
            this._display = display;

            //call the load home method
            this.LoadHome();

            //set the current website to the homepage
            this._currentWebsite = this._homepage;

            //create a history object and set this._history to equal it
            this._history = new History();

            //add the homepage occurrence to history
            this._history.AddWebsite(this._currentWebsite);

            //create a favourites object and set this._history to equal it
            this._favourites = new Favourite();
        }

        
        //getter and setter function for  attribute ._currentWebsite
        public Website CurrentWebsite
        {
            get
            {
                return this._currentWebsite;
            }
            set
            {
                
                this._currentWebsite = value;
            }
        }

        //getter and setter function for attribute _homepage
        public Website HomePage
        {
            get
            {
                return this._homepage;
            }
            set
            {
                this._homepage = value;
            }
        }

        //getter and setter function for attribute _history
        public History History
        {
            get
            {
                return this._history;
            }
            set
            {
                this._history = value;
            }
        }

        //getter and setter function for attribute _favourites
        public Favourite Favourites
        {
            get
            {
                return this._favourites;
            }
            set
            {
                this._favourites = value;
            }
        }

        //getter and setter function for attribute _display
        public RichTextBox Display
        {
            get
            {
                return this._display;
            }
            set
            {
                this._display = value;
            }
        }


        

        /*This method is for saving the state of the browser
         * It saves the home url, the favourites and the history
         */
        public void Save()
        {
            //save home method
            this.SaveHome();

            //save favourites method
            this._favourites.SaveFavourites();

            //save history method
            this._history.SaveHistory();
        }

        /*This method is for saving the home url to a file
         * It serializes the homepage website object  and then writes to a file
         */
        public void SaveHome()
        {
            //file path current directory home.json
            string fileName = @".\\home.json";

            //serialize object  using newtonsoft
            string savedHist = JsonConvert.SerializeObject(this._homepage, Formatting.Indented);

            //write serialized object to file 
            File.WriteAllText(fileName, savedHist);
        }


        /*This method is for loading the home url from a file 
         * It reads from a file and then deserializes the homepage website object 
         *and sets the browser homepage to the deserialized website
         */
        public void LoadHome()
        {
            string fileName = @".\\home.json";
            try
            {
                //read the file into a string
                String input = String.Join("", File.ReadLines(fileName));

                //deserialize back into a website object
                Website deserializedHomepage = JsonConvert.DeserializeObject<Website>(input);

                //set homepage equal to this object
                this._homepage = deserializedHomepage;
            }
            catch
            {
                //no previous home
            }
           
        }
    }
}
