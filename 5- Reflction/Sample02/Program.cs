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
            Infrastructor.Reflector ref_Reflector = new Infrastructor.Reflector("Sample02.Person");
            ref_Reflector.CreateInstance();
            ref_Reflector.SetProperties("FName", "Maryam");
            ref_Reflector.SetProperties("Age",  12);
            ref_Reflector.GetProperty();
            Console.WriteLine();

        }
    }
}
