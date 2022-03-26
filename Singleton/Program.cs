using System;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Basic Singleton Patterm
            //Singleton instance1 = Singleton.getSingleInstance;
            //instance1.PrintDetails("singleton instance 1");

            //Singleton instance2 = Singleton.getSingleInstance;
            //instance1.PrintDetails("singleton instance 2");

            #endregion

            #region thread safe singleton pattern
            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentDetails()
            );
            #endregion



            #region below code for experiment purpose :: why singleton class are "sealed", we already used private constructor?

            //WhySealedClass instance3 = WhySealedClass.getSingleInstance;
            //instance3.PrintDetails("singleton instance 3");

            //WhySealedClass instance4 = WhySealedClass.getSingleInstance;
            //instance4.PrintDetails("singleton instance 4");

            // here is the voilation of singleton pattern

            //WhySealedClass.DerivedSingleton violateSingleton = new WhySealedClass.DerivedSingleton();
            //violateSingleton.PrintDetails("singleton instance 5");

            #endregion
        }

        private static void PrintTeacherDetails()
        {
            Singleton fromTeacher = Singleton.getSingleInstance;
            fromTeacher.PrintDetails("From Teacher");
        }
        private static void PrintStudentDetails()
        {
            Singleton fromStudent = Singleton.getSingleInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
