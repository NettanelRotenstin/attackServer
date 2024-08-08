using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


namespace attackServer
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
          Dictionary<string, int> _damage = new Dictionary<string, int>();
            _damage["barak1"] = 300;
            _damage["barak8"] = 350;
            _damage["gabriel"] = 200;
            _damage["derby"] = 390;


            string pathString = "C:\\Users\\INTERNET\\source\\Core8\\attackServer\\Missiles.json";

          string json = File.ReadAllText(pathString);

          List<Missiles> missileslist = JsonSerializer.Deserialize<List<Missiles>>(json);

            Console.WriteLine(missileslist[1].GetName());
            Console.ReadLine();

             




































            //Dictionary<string, int> ages = new Dictionary<string, int>();
            //ages["david"] = 17;
            //ages["nadav"] = 44;
            //ages["chana"] = 22;

            //PrintingJson(ages);
            //int a = ages["chana"];
            //int b = ages["david"];
            //ages["david"] = 33;

            //bool r = ages.ContainsKey("david");


            

            Queue<Missiles> missiles = new Queue<Missiles>();
               async Task<string> ReadFileAsync(string path)
            {
                Console.WriteLine("reading the file");
                string result = await Task.Run(() => File.ReadAllText(path));


                Console.WriteLine(result);
                return result;
            }



             
            //4
            Node<int> node2 = new Node<int>();
            Node<int> node = new Node<int>(16, node2);
            //Console.WriteLine(node.ToString());
            Console.ReadLine();




        }

        public static async Task<string> Getdata(string stringa)
        {
            await Task.Delay(2000);
            return stringa;
        }


        public static async Task<string> ReadFileAsync(string path)
        {

            string result = await Task.Run(() => File.ReadAllText(path));
            Console.WriteLine(result);
            return result;
        }

        public static async Task<string> GetDataFromServiceAAsync()
        {
            await Task.Delay(1000);
            return " from A";
        }

        public static async Task<string> GetDataFromServiceBAsync()
        {
            await Task.Delay(2000);
            return " from B";
        }





        //using dictionary and qeueu cs 

        //1 func gets qeueu and print it nicely

        public static void PrintQeueu(Queue<string> queue)
        {
            if (queue.GetCount() == 0)
            {
                Console.WriteLine("the qeueu is empty");
                return;
            }
            int count = queue.GetCount();
            for (int i = 0; i <= count; i++)
            {
                Node<string> node = new Node<string>();
                node.SetValue(queue.GetHead().GetValue());
                Console.WriteLine($"the value in posision {i + 1} is {queue.Dequeue()}");
                queue.Enqueue(node.GetValue());
            }
            return;
        }

        //2 func gets dict and print it like json printing like {"name: "david, "age" , 30}
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        public static void PrintingJson(Dictionary<string, int> dict)
        {
            Console.WriteLine("{");
            bool flag = true;
            foreach (string pair in dict.Keys)
            {
                if (!flag)
                {

                    Console.Write(",");
                    Console.WriteLine();

                }

                Console.Write($"    {pair} : {dict[pair]}");
               
                flag = false;
               
            }
            Console.WriteLine();

            Console.WriteLine("}");
        }
        //3 func gets tow qeueu one full and one empty and crossing it to the second

        public static void CutPasteQeueu(Queue<string> queue1, Queue<string> queue2)
        {
            string tmp;
            int count;
            if (queue1.GetCount() != 0 && queue2.GetCount() == 0)
            {
                PrintQeueu(queue1);
                count = queue1.GetCount();
                for (int i = 0; i <= count; i++)
                {
                    tmp = queue1.Dequeue();
                    queue2.Enqueue(tmp);
                }
                PrintQeueu(queue2 );
            }

            else if (queue1.GetCount() == 0 && queue2.GetCount() != 0)
            {
                PrintQeueu(queue2);
                count = queue2.GetCount();
                for (int i = 0; i <= count; i++)
                {
                    tmp = queue2.Dequeue();
                    queue1.Enqueue(tmp);
                }
                PrintQeueu(queue1);
            }
            else
            {
                Console.WriteLine("they both are full");
            }
        }

        //4 
        public static Queue<int> returnEven(Queue<int> qeueu)
        {
            int count = qeueu.GetCount();
            for(int i = 0;i <= count;i++)
            {
                int value = qeueu.Dequeue();
                if (value % 2 == 0)
                {

                    qeueu.Enqueue(value);
                
                }
            }
            return qeueu;
        }
        public static Queue<string> returnLength(Queue<string> qeueus, Queue<int> qeueui)
        {
            Queue<string> queueNew = new Queue<string>();
            int count = qeueus.GetCount();
            while( count > 0 )
            {
                string values = qeueus.Dequeue();
                int valuei = qeueui.Dequeue();
                if( valuei == values.Length)
                {
                    queueNew.Enqueue(values);
                }
                qeueus.Enqueue(values);
                qeueui.Enqueue(valuei);
                count--;
            }
            return queueNew;
        }

        public static Dictionary<string, int> Above30(Dictionary<string, int> dict)
        {
            foreach(string kvp in dict.Keys)
            {
                if (dict[kvp] <= 30)
                {
                    dict.Remove(kvp);
                }
            }
            return dict;
        }

        public static Queue<int> ascending(Queue<int> qeu1, Queue<int> qeu2)
        {
            int count = qeu1.GetCount();
            Queue<int> queueNew = new Queue<int>();
            while (count > 0)
            {
                if (qeu1.Peek() > qeu2.Peek())
                {
                    queueNew.Enqueue(qeu2.Dequeue());
                    count--;
                }
                if(qeu1.Peek() <= qeu2.Peek())
                {
                    queueNew.Enqueue(qeu1.Dequeue());
                    count--;
                }

            }
            return queueNew;
        }






    }
}
 