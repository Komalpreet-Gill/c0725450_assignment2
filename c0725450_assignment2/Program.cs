using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0725450_assignment2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Student name-Komalpreet Gill(c0725450)
            //CSD3354 Section1
            //Assignment2
            //March 7,2019
            DelegateExercises delegateExercises = new DelegateExercises();
            try
            {
                delegateExercises.Method3();
                Console.ReadLine();
            }
            catch(System.Exception ex)
            {
                System.Console.WriteLine("Exception occured.");
                Console.ReadLine();
            }
        }
    }
    public delegate int MyDelegate();

    public class DelegateExercises
    {
        

        void Method1()
        {
            throw new System.Exception();
        }

        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }
}
