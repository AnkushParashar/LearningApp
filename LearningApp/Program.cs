using System;
using System.Collections.Generic;
using System.Linq;

namespace LearningApp
{
    class Program
    {
        class test
        {
            public int a;
            public int b; 
            public void print()
            { }
        }
        static void Main(string[] args)
        {
            string myName = "ANKUSH";
            string nyName2 = "ANKUSH";
            string a = "MyName is ankush Parashar675853467";
            string[] names = new [] { "ABHISHEK", "ANJU", "ACHHAR" };
            List<string> abc = new List<string>();
            List<test> tests = new List<test>();
            myName.ToLower(); 
            test t = tests.Where(x => x.a == 2).FirstOrDefault();

            //CREATING AND ARRAY
            
            var entredString = Console.ReadLine();
            entredString.Split(' ');
            //Console.WriteLine(myName.CompareTo(nyName2));
            //Console.WriteLine(a.Replace("67", "").ToString());
        }
    }
}
