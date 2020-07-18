using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ref_Person = new Person(new Pen());//aggragation inja new shod
            ref_Person.Ref_Hand.fingerNumbers = 10;
            ref_Person.Ref_Pen.Color = "red";
            ref_Person.GetPen().Color="blue";
        }
    }
}
