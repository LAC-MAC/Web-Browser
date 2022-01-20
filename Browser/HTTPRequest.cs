using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;


namespace Browser
{
    public class HTTPRequest
    {
        //attribute for the response from the HTTP request
        private HttpWebResponse _response;

        //attribute for the code returned by the request
        private int _code;

        //attribute for the length of the response
        private long _lengthBytes;
       
       //getter and setter for response attribute
        public HttpWebResponse Response
        {
            get
            {
                return this._response;
            }
            set
            {
                this._response = value;
            }
        }

        //getter and setter method for code attribute
        public int Code
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
        //getter and setter method for lengthBytes attribute
        public long LengthBytes
        {
            get
            {
                return this._lengthBytes;
            }
            set
            {
                this._lengthBytes = value;
            }
        }


        public String StreamOfHTML(HttpWebResponse response)
        {
            //init stream reader object
            StreamReader reader;

            //get the response stream 
            Stream getStream = response.GetResponseStream();
            
            //check if then response has any encoding in its header
            if (response.CharacterSet != null)
            {
                //assign a new stream reader object to reader with the encoding of that the stream header specified
                reader = new StreamReader(getStream, Encoding.GetEncoding(response.CharacterSet));
            }
            else
            {
                //assign a new stream reader object to reader with no encoding
                reader = new StreamReader(getStream);
            }
                
            //read the stream into a string
            String htmlStream = reader.ReadToEnd();

            //close stream
            reader.Close();

            //close response 
            response.Close();

            //return the stream as a string
            return htmlStream;

        }


        public String getResponse(String URL)
        {
            //init uribuilder object 
            Uri urlBuild;

            //Surround URIBuilder in a try catch 
            try
            {
                //create a uri builder for the url specified by the user 
                urlBuild = new UriBuilder(URL).Uri;
            }
            catch (Exception e)
            {

                // return any expections caused by UriBuilder
                return e.Message;
            }
            //Surround HTTpWebRequest in a try catch
            try
            {
                //assign response attribute to the reuslt of HttpWebRequest using built url 
                this._response = (HttpWebResponse)HttpWebRequest.Create(urlBuild).GetResponse();

                //get the length of the response content and assign it to the lenghtBytes attribute
                this._lengthBytes = this._response.ContentLength;

                //get the html code of the reponse and assign it to the code attribute
                this._code = (int)this._response.StatusCode;

                //call the stream of HTML method to get the response as a string then return it
                return StreamOfHTML(this._response);
                
             
            }
            catch (WebException e)
            {

                //create new Response Error object to deal with web Exception
                var webError = new ResponseError(e);

                //get the html code of the response and assign it to the code attribute
                this._code = webError.Code;

                //return the error 
                return webError.Text;

            }
 
        }

 
        
    }
}
