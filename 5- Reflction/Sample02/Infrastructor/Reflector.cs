using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sample02.Infrastructor
{
    public class Reflector
    {
        #region [- ctor -]
        public Reflector(string fullNameOfClass)
        {
            FullNameOfClass = fullNameOfClass;
        }
        #endregion

        #region [-props-]
        public string FullNameOfClass { get; set; }
        public Type TypeOfClass { get; set; }
        public object RefOfClass { get; set; } 
        #endregion

        #region [-CreateInstance()-]
        public void CreateInstance()
        {
            TypeOfClass = Type.GetType(FullNameOfClass);
            RefOfClass = Activator.CreateInstance(TypeOfClass);

        }
        #endregion

        #region [-SetProperties<T>(string propertyName, T propertyValue)-]
        public void SetProperties<T>(string propertyName, T propertyValue)
        {
            TypeOfClass.GetProperty(propertyName).SetValue(RefOfClass, propertyValue, null);
        }
        #endregion

        #region [-GetProperty()-]
        public void GetProperty()
        {
            Console.WriteLine(" Properties:");
            PropertyInfo[] pi = TypeOfClass.GetProperties();
            foreach (PropertyInfo property in pi)
            {
                Console.WriteLine(property.Name);
            }
            Console.WriteLine("");
        }
        #endregion
    }
}
