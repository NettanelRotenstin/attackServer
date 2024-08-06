using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace attackServer
{
    internal class Program
    {
          static async Task Main(string[] args)
        {





            //2
            //string path = "C:\\Users\\INTERNET\\source\\Core8\\attackServer\\TextFile1.txt";

            //Console.WriteLine("reading the file");
            //string a =  await  ReadFileAsync(path);
            //Console.WriteLine(a);
            //Console.ReadLine();

            //3
            Task<string> TaskA = GetDataFromServiceAAsync();
            Task<string> TaskB = GetDataFromServiceBAsync();
            await Task.WhenAll(TaskA, TaskB);

        }

        public static async Task<string>  Getdata(string stringa)
        {
            await Task.Delay(2000);
            return stringa;
        }

       
        public static async Task<string> ReadFileAsync(string path)
        {  

            string result = await Task.Run( () => File.ReadAllText(path));
            return result;
        }

        public static async Task<string> GetDataFromServiceAAsync( )
        {
            await Task.Delay(1000);
            return " from A";
        }

        public static async Task<string> GetDataFromServiceBAsync( )
        {
            await Task.Delay(2000);
            return " from B";
        }
    }
}
 