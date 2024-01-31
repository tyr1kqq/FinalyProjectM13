using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

namespace FinalyProjectM13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Timer = Stopwatch.StartNew();

            StreamReader sr = new StreamReader(@"C:\\Users\tyr1k_qq\Desktop\List\test.txt");
            ListTimer(sr);

            Console.WriteLine($"Вставка в List T :  {Timer.Elapsed.TotalMilliseconds}  мс");

            Timer.Restart();
            Timer.Start();

            LinkedListTimer(sr);
            Console.WriteLine($"Вставка в LinkedList T :  {Timer.Elapsed.TotalMilliseconds}  мс");

        }
        static void ListTimer(StreamReader sr)
        {

            List<String> list = new List<String>();
            while (!sr.EndOfStream)
            {
                list.Add(sr.ReadLine());
            }
        }

        static void LinkedListTimer(StreamReader sr)
        {
            LinkedList<String> LinkList = new LinkedList<String>();
            while (!sr.EndOfStream)
            {
                LinkList.AddLast(sr.ReadLine());
            }
        }
    }
}