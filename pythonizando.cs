using System;
using System.IO;
using System.Net;
using System.Diagnostics;


namespace EXEMPLO
{
    public class TESTES
    {
        public static void Main() 
        {
            requests requests = new requests();
            //string url = input("Insira um link: ");
            //string output = requests.get(url);

            //string[] splitado = output.Split('"');

            //foreach (string x in splitado)
            //{
            //    if( x.Contains("http") ) 
            //    {
            //        print(x + "\n");
            //    }
            //}




            /* AQUI É O QUE VAI SER RODADO */
            open("models.txt");
            input(" ");
        }

        static void print(string text)
        {
            Console.Write(text);
        }

        static string input(string text)
        {
            print(text);
            string ouput = Console.ReadLine();
            return ouput;
        }

        static string popen(string Command)
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

        static void open(string path)
        {
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
    }
}
