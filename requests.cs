using System;
using System.IO;
using System.Net;


namespace EXEMPLO
{
    class requests
    {
        public string get(string url)
        {
            WebRequest request = WebRequest.Create(
              url);
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;

            // Get the response.
            WebResponse response = request.GetResponse();

            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            response.Close();
            return responseFromServer;
            
        }
    }
}
