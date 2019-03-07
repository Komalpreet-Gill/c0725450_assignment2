using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0725450_assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student name-Komalpreet Gill(c0725450)
            //CSD3354 Section1
            //Assignment2
            //March 7,2019
            DelegateExercises a = new DelegateExercises();
            a.Method2();


        }
    }

    public class DelegateExercises
    {
        public delegate void MyDelegate();

        void Method1( int i)
        {
            Console.WriteLine("Method1"); 
            Console.ReadLine();
        }

        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }
}
