using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;

namespace primeiroAPP
{
    public class PYTHON
    {

        public string requests(string url)
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
        

        public void print(string text)
        {
            Console.Write(text);
        }

        public string input(string text)
        {
            print(text);
            string ouput = Console.ReadLine();
            return ouput;
        }

        public string popen(string Command)
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c " + Command;
            p.Start();
            // Do not wait for the child process to exit before
            // reading to the end of its redirected stream.
            // p.WaitForExit();
            // Read the output stream first and then wait.
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            return output;
        }

        public void open(string path)
        {
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
    }
}
