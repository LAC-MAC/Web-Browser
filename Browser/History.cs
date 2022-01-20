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
    public class History
    {
        //attribute for the dictionary for history
        private Dictionary<int, Website> _history;

        //attribute to keep track of the head of history
        private int _head;

        //constructor
        public History()
        {
            //create a new dictionary with int, website pairs and assign it to this._history
            this._history = new Dictionary<int, Website>();
        }

        //getter and setter for _history attribute
        public Dictionary<int, Website> Hist
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

        //getter and setter for _head attribute 
        public int Head
        {
            get
            {
                return this._head;
            }
            set
            {
                this._head = value;
            }
        }


        /*This method is for adding a website to the history
         * It checks if history isnt empty  then assigns a value a key(index) of 1+max 
         * If it is empty then first key(index) is 0
         * It will also update the _head 
         */
        public void AddWebsite(Website website)
        {

            //if history isnt empty then
            if (this._history.Count > 0)
            {
                //new head equals max+1 
                int newHead = this._history.Keys.Max() + 1;

                //add a new pair to history of newhead and website 
                this._history.Add(newHead, website);

                //update the head
                this._head = newHead;

            }
            else
            {
                //history is empty so add website with key of zero (first index)
                this._history.Add(0, website);

                //update the head
                this._head = 0;
            }

        }


        /*This method is for removing a pair from history
         * It checks if the pair being removed is the head and updates the head to the next pair before removing
         * if not it just removes the pair 
         */
        public void RemoveWebsite(int key)
        {
            //check is pair being removed is head then 
            if (key == this._head)
            {
                //update the head to the next pair
                this._head = this.Next(this._head);

                //remove the pair form dictionary
                this._history.Remove(key);

            } else
            {
                //remove pair from dictionary
                this._history.Remove(key);
            }


        }


        /* This method gets the next pair in the dictionary
         * It loops incrementing i until it finds the next pair returning 
         * the key or breaks if there is no next pair (returning -1 in this case)
         */
        public int Next(int key)
        {
            //set i to 1 
            int i = 1;
            //init max
            int max = -1;
            //try to get max key in dictionary
            try
            {
                max = this._history.Keys.Max();
            }
            catch
            {
                //send warning to user
                MessageBox.Show("No History Available");
                //return error case
                return -1;
            }
            
            //loop while
            while (true)
            {
                //if dictioanry contains a pair with the incremented key then
                if (this._history.ContainsKey(key + i))
                {
                    //return the key
                    return key + i;
                }
                //if gone through all pair in dictionary then 
                else if (max < key + i) {
                    break;
                }
                //increment i 
                i++;
            }
            //return the error case
            return -1;
        }

        /*This method returns the previous pair in the dictionary 
         * It loops through the dictionary until if finds the previous pair or if i becomes a 
         * negative (as we no there is no negative keys in dictionary) returns -1 in this case
         */
        public int Prev(int key)
        {
            //init i to 1 
            int i = 1;

            //loop while
            while (true)
            {
                //if the dictionary contains a pair with this new key then
                if (this._history.ContainsKey(key - i))
                {
                    //return this new key
                    return key - i;
                }
                //if new key is now negative then
                else if (key - i < 0)
                {
                    break;
                }

                //increment i 
                i++;
            }
            //return error case
            return -1;
        }


        /*This method is for saving the history to a file 
         * It serializes the history dicitionary and writes to a file
         */
        public void SaveHistory()
        {

            string fileName = @".\\history.json";
            string savedHist = JsonConvert.SerializeObject(this._history, Formatting.Indented);
            File.WriteAllText(fileName, savedHist);
        }


        /*This method is for the loading the history from a file
         * It deserializes the history dictionary and then assigns it the _history attribute
         * It also checks there exists a save history file
         */
        public void LoadHistory()
        {

            string fileName = @".\\history.json";
            try
            {
                String json = String.Join("", File.ReadLines(fileName));
                Dictionary<int, Website> deserialized = JsonConvert.DeserializeObject<Dictionary<int, Website>>(json);
                this._history = deserialized;
            }
            catch
            {
                //no History
            }
            
        }

    }
}
