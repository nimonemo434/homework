using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homwork_07_24_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            tree alpha = new tree();
            alpha.Name = "소나무";
            Console.WriteLine(alpha.Name);
        }
    }
    class tree
    { 
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        private string _Name;
    }
}
