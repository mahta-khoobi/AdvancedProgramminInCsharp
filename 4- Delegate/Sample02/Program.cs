using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample02
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ref_Person = new Person("Ali", "Mohseni", 12);
            ref_Person.ShowDetails(ref_Person);
            System.Console.ReadLine();
        }
    }
}
