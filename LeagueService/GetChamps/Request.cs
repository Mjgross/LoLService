using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace GetChamps
{
    public class Request
    {
        //Grabs and Processes the request
        public string getRequest(string path)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(path);
            request.Method = "Get";
            request.Accept = "*/*";
            WebResponse response = (WebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();

            //stream reader
            StreamReader reader = new StreamReader(responseStream);
            string res = reader.ReadToEnd();
            responseStream.Close();

            return res;
        }

        //Grabs API URL
        public string requester(string url)
        {

            var request = new Request();

            string data = request.getRequest(url);
            return data;
        }

    }
}