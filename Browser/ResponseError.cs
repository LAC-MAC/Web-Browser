using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace Browser
{
    class ResponseError
    {
        //attribute for the text explanition of code
        private string _text;
        //attribute for the html code
        private int _code;

        //getter and setter method for _text attribute
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }

        //getter and setter method for _code attribute
        public int Code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }

        /*This method is for interpreting the web exception given by HTTPWebResponse
         * its sets this._code to the response status code 
         * it sets this._text to the response status description
         */
        public ResponseError(System.Net.WebException e)
        {
            //check the response was complete
            if (e.Status == WebExceptionStatus.ProtocolError)
            {
                //create a varaible for the response
                var response = (HttpWebResponse)e.Response;

                //set this._code to the response status code
                this._code = (int) response.StatusCode;
                //set this._text to the response status description
                this._text = response.StatusDescription;

            }
            

        }
    }
}
