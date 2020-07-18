using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample03
{
    class Program
    {
        static void Main(string[] args)
        {
            Lifecycle.Teacher ref_Teacher = new Lifecycle.Teacher("ALi","Amiri",2000000);
            Console.WriteLine(ref_Teacher.ShowFullInfo());

            Lifecycle.Student ref_Student = new Lifecycle.Student("Mahsa","Mahmoudi");
            Console.WriteLine(ref_Student.ShowFullInfo());
        }
    }
}
