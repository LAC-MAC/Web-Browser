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
    public class Favourite
    {
        //attribute for favourites dictionary
        private Dictionary<String, Website> _favourites;

        //constructor
        public Favourite()
        {
            //create a new dictionary with string, website pairs and assign it to this_favourites
            this._favourites = new Dictionary<String, Website>();
        }

        //getter and setter method for attribute _favourites
        public Dictionary<String, Website> Fav
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


        /*This method adds a favourite to the dictionary
         * It will send warning to user if there already exists and entry with that key
         */
        public void AddFavourtie(Website website, String name)
        {
            //try to add to dictionary
            try
            {
                //add to dictionary
                this._favourites.Add(name, website);
            }
            catch
            {
                //send warning to user
                MessageBox.Show("Please, rename the favourite");
            }
            
        }

        /*This method is for when a favourite it removed from the dictionary
         * It will try to remove it from dictionary, send warning to user if it isnt able to
         */
        public void RemoveFavourtie(String name)
        {
            //try to remove from dictionary
            try
            {
                //remove from dictionary
                this._favourites.Remove(name);
            }
            catch
            {
                //send warning to user
                MessageBox.Show("Favourite doesn't exist");
            }
        }

        /*This method is for saving favourites to a file
         *it serializes the dictionary using Newtonsoft and then writes to file
         */
        public void SaveFavourites()
        {

            string fileName = @".\\favourites.json";
            string savedHist = JsonConvert.SerializeObject(this._favourites, Formatting.Indented);
            File.WriteAllText(fileName, savedHist);
        }

        /*This method is for loading the favourites from a file 
         * it deserializes file creating a dictionary obeject that is then assigned to the _favourites attribute
         * It also checks a file exitst with the saved favourites data
         */
        public void LoadFavourites()
        {

            string fileName = @".\\favourites.json";
            try
            {
                String json = String.Join("", File.ReadLines(fileName));
                Dictionary<String, Website> deserialized = JsonConvert.DeserializeObject<Dictionary<String, Website>>(json);
                this._favourites = deserialized;
            }
            catch
            {
                //MessageBox.Show("no favourites");
            }
        }
    }
}
