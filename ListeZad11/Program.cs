using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeZad11
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, int> gradovi = new SortedList<string, int>(new DescStringComparer())
            {
                {"Kraljevo", 40000 },
                {"Nis", 1400000 },
                {"Beograd", 2000000 }
            };
            foreach (var grad in gradovi)
                Console.WriteLine(grad);

            Console.ReadLine();
        }
    }
}
