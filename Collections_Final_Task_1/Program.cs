using System.Diagnostics;
using System.Collections.Generic;
using System;
using System.IO;

namespace Collections_Final_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\Akul'\Desktop\Text1.txt";
            var list = new List<string>();
            var linkedlist = new LinkedList<string>();


            var stopwatch_list = Stopwatch.StartNew();
            using (StreamReader sr = File.OpenText(filepath))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                {
                    list.Add(str);
                }
            }

            Console.WriteLine("Время затраченное на добавление текста в лист: " + stopwatch_list.Elapsed.TotalMilliseconds + " ms");

            var stopwatch_linked_list = Stopwatch.StartNew();
            using (StreamReader sr = File.OpenText(filepath))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                {
                    linkedlist.AddFirst(str);
                }
            }
            Console.WriteLine("Время затраченное на добавление текста в линкованный лист: " + stopwatch_linked_list.Elapsed.TotalMilliseconds + " ms");
            Console.ReadLine();

        }
    }
}
