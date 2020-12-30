using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeZad11
{
    class DescStringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return String.Compare(x, y) * -1;
        }
    }
}
