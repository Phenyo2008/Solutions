using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(GetTeamsFromCSV("TestFile.txt"));
            Console.ReadLine();
            
        }
        public static int getDifference(string line)
        {
            var list = new List<int>();
            foreach (var item in line)
                list.Add(int.Parse(item.ToString()));
            var orderdeList = list.OrderBy(x => x).ToList();
            return orderdeList.Last() - orderdeList.First();
        }

        public static int GetTeamsFromCSV(string filePath)
        {
            var array = new List<int>();
            var myFile = File.Open(filePath, FileMode.Open);
            using (StreamReader myStream = new StreamReader(myFile))
            {
                if (File.Exists(filePath))
                {
                    string line;
                    while ((line = myStream.ReadLine()) != null)
                    {
                        array.Add(getDifference(line));
                    }
                }
            }
            return array.Sum();
        }
    }
}
