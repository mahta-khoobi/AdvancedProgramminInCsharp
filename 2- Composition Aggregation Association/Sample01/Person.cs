using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01
{
    public class Person
    {
        //private Hand ref_Hand = new Hand();//immidiate composition

        #region [- ctor -]
        public Person(Pen ref_pen)
        {
            Ref_Hand = new Hand();//eager composition
            Ref_Pen = ref_pen;//eager aggragation
        }
        #endregion
        #region [- props -]
        public string Name { get; set; }
        public int Age { get; set; }
        public Hand Ref_Hand { get; set; }//for composition
        public Pen Ref_Pen { get; set; }//for aggragation 
        #endregion

        #region [-Initializer(Pen pen)-]
        public void Initializer(Pen pen)
        {
            Ref_Hand = new Hand();//lazy composition
            Ref_Pen = pen;//lazy aggragation

        } 
        #endregion
        public Pen GetPen()
        {
            return new Pen();
        }

    }
}
