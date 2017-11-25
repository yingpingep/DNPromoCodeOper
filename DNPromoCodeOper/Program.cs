using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNPromoCodeOper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me a path: ");
            string readFilePath = Console.ReadLine();
            string outputFilePath = readFilePath.Substring(0, readFilePath.Length - 4) + "_out.txt";

            StreamReader sr = new StreamReader(readFilePath);
            string context = sr.ReadLine();
            var newContext = context.Split(',');
            sr.Close();

            StreamWriter sw = new StreamWriter(outputFilePath);
            foreach (var item in newContext)
            {
                sw.WriteLine(item.Trim());
            }

            sw.Close();
            Console.WriteLine("Finish.");
            Console.ReadLine();
        }
    }
}
