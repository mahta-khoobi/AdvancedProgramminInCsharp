using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01.Framework
{
    public class BaseEducationClass : IEducationClass<string, int, string, int, IEmployee<string, int>, IStudent<string, int>, int>
    {
        #region [- ctor -]
        public BaseEducationClass(int unitCost)
        {
            UnitCost = unitCost;
        }
        #endregion

        #region [- props -]
        public IEmployee<string, int> Trainer { get; set; }
        public List<IStudent<string, int>> Students { get; set; }

        public int TotalCost
        {
            get
            {
                int totalCost = 0;
                foreach (var item in Students)
                {
                    totalCost = +UnitCost;
                }
                return totalCost;
            }
        }

        public int UnitCost { get; set; }

        #endregion

        #region [-AddStudent(IStudent<string, int> item)-]
        public void AddStudent(IStudent<string, int> item)
        {
            Students.Add(item);
        }
        #endregion

        #region [- SetTrainer(IEmployee<string, int> trainer) -]
        public void SetTrainer(IEmployee<string, int> trainer)
        {
            Trainer = trainer;

        } 
        #endregion

        #region [-InitializeStudents(List<IStudent<string, int>> students)-]
        public void InitializeStudents(List<IStudent<string, int>> students)
        {
            Students = students;
        }
        #endregion

        #region [-ShowListOfStudents()-]
        public void ShowListOfStudents()
        {
            foreach (var item in Students)
            {
                Console.WriteLine(string.Format("Code:{0},Name:{1},Surname:{2}", item.StudentCode, item.Name, item.Surname));
            }
        } 
        #endregion

    }
}
