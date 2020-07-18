using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample02
{
    public class Person
    {
        #region [- ctor -]
        public Person(string name,string surname , int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        #endregion

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public EventPublisher Ref_EventPublisher { get; set; }
        public A Ref_A { get; set; }
        public B Ref_B { get; set; }
        public C Ref_C { get; set; }

        #region [- BindEventHandler() -]
        private void BindEventHandler()
        {
            Ref_EventPublisher = new EventPublisher();
            Ref_A = new A();
            Ref_B = new B();
            Ref_C = new C();

            Ref_EventPublisher.ShowDetailEvent += new PersonDelegate(Ref_A.PrintName);
            Ref_EventPublisher.ShowDetailEvent += new PersonDelegate(Ref_B.PrintSurname);
            Ref_EventPublisher.ShowDetailEvent += new PersonDelegate(Ref_C.PrintAge);




        }
        #endregion

        #region [-ShowDetails(Person ref_Person)-]
        public void ShowDetails(Person ref_Person)
        {
            BindEventHandler();
            Ref_EventPublisher.ShowDetails(ref_Person);
        } 
        #endregion



    }
}
