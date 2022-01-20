using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Browser
{
    public class Website
    {
        //Attribute for the url of the website
        private string _webUrl;

        //attribute for the html stream of the website
        private string _stream;

        //attribute for the title of the website
        private string _title;
        
        //attribute for the html code of the website
        private string _code;

        
        //constructor
        public Website(String URL, String stream, String code)
        {
            //this._webUrl equals the url passed in
            this._webUrl = URL;

            //this._stream equals the html stream passed in 
            this._stream = stream;

            //this._code equals the html code passed in
            this._code = code;

            //run titleMatch method to get the title for the webpage
            titleMatch();
        }


        /*This method is for getting the title of the website between the title tags in the html stream
         * It uses a regex to get a match and then assigns it to the title attribute
         */
        public void titleMatch()
        {  
            //create new regex 
            // ?<= <title>, positive lookbehind 
            //?=</title>, positive lookahead 
            //.+, any single character this isnt newline one or more times
            Regex rx =new Regex(@"(?<=<title>).+(?=<\/title>)");
            try
            {
                //
                MatchCollection matches = rx.Matches(this._stream);
                if (matches.Count == 1)
                {
                    //set title attribute to the matched string
                    this._title = matches[0].ToString();
                    
                }
            }
            catch
            {
                
            }
            
        }

        //getter and setter for WebURL attribute
        public string WebUrl
        {
            get
            {
                return this._webUrl;
            }
            set
            {
                this._webUrl = value;
            }
        }

        //getter and setter for html stream attribute
        public string Stream
        {
            get
            {
                return this._stream;
            }
            set
            {
                this._stream = value;
            }
        }

        //getter and setter for the title attribute
        public string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                this._title = value;
            }
        }

        //getter and setter for the code attribute
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
    }
}
