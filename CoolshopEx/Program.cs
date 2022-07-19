using System;

namespace CoolshopEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = args[0];

            string[] lines = System.IO.File.ReadAllLines(path);
            int nColumns = lines[0].Split(',').Length;
            bool found = false;

            if (int.Parse(args[1]) >= nColumns)
            {
                Console.Error.WriteLine("Column's index greater than number of columns");
                return;

            }

            foreach (string line in lines)
            {
                
                string[] columns = line.Split(',');
                columns[nColumns - 1] = columns[nColumns - 1].TrimEnd(';');



                if (columns[int.Parse(args[1])].Equals(args[2]))
                {
                    Console.WriteLine(line);
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("Occurency not found! Try again");

            return;
            
        }
    }
}
