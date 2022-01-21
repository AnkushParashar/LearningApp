using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LearningApp
{
    class Program
    {
        abstract class User
        {
            public string name { get; set; }
            public int age;
            public Gender gender;
            public User(string Name, int Age, Gender Gender)
            {
                name = Name;
                age = Age;
                gender = Gender;
            }
        }
        class Admin : User
        {
            public Admin(int age, Gender gender) : base("Ankush", age, gender) { }

        }
        class TestInterface : ISample
        {
            public string i { get; set; }

            public void sample()
            {
                Console.Beep();
            }
        }
        static void CallandCheckInheritance()
        {
            Admin a = new Admin(25, Gender.Male);
            Console.Write(a.name + " " + a.age + " " + a.gender);
            ISample s = new TestInterface();
            s.sample();
            /*
            Stack st = new Stack();
            st.Push('y');
            */
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("A");
            foreach (string y in linkedList)
            {
                Console.Write(y);
            }
        }

        public delegate bool isPromoted(Employee emp);
        private static void DelegatesExample()
        {
            List<Employee> emps = new List<Employee>();
            emps.Add(new Employee { ID = 101, Name = "Ankush", Salary = 2000, Experience = 2 });
            emps.Add(new Employee { ID = 102, Name = "Abhishek", Salary = 3000, Experience = 3 });
            emps.Add(new Employee { ID = 103, Name = "Praveen", Salary = 4000, Experience = 5 });
            emps.Add(new Employee { ID = 104, Name = "Raj", Salary = 5000, Experience = 6 });

            Employee.GetListOfEmployes(emps,  x => x.Experience >= 5);
        }

        private static void Ext_MethodsExample()
        {
            string name = "Ankush";
            name = name.getFormat();
            Console.WriteLine(name);
        }

        private static void singleInstaceMethdods()
        {
            PRConstructors.data = "";
            PRConstructors.getInstance().NonStaticData = "";
            PRConstructors.getInstance().NonStaticData = "12";

            Class_static.data = "";

            //Sealed class can be intantiated
            Class_sealed s = new Class_sealed();

            //Static class can not be intantiated
            //Class_static ss = new Class_static();

            UserService.userId = 12;
        }
        //STRINGS
        #region String Programs
        static string reverseString(string str)
        {
            string rev = "";
            int len = str.Length;
            for (int i = len - 1; i >= 0; i--)
            {
                rev = rev + str[i];
            }
            return rev;
        }
        public string Sortstring(string str)
        {
            string sorted = "";
            char[] ar = str.ToCharArray();
            Array.Sort(ar);
            sorted = String.Join("", ar);

            return new string(ar);
        }
        public int reverseNumber(int num)
        {
            int rev = 0;
            //21
            while (num > 0)
            {
                int rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }

            return rev;
        }
        public int sortOneNumber(int num)
        {
            string str = num.ToString();
            return int.Parse(Sortstring(str));
        }
        #endregion

        #region async Programming

        private static int GetValue()
        {
            int value= 0;
            Thread.Sleep(2000);
            return value;
        }
        static async void aSynExample()
        {
            Task<int> task = new Task<int>(GetValue);
            task.Start();

            Console.Write("Please wait...");
            int data = await task;
            Console.Write("processing done!");
        }
        #endregion

        static void Main(string[] args)
        {
            Numbers nums = new Numbers();
            StringPrograms sp = new StringPrograms();
            Files f = new Files();
            Console.Write("Enter program number: ");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                //STRINGS
                case 0: CallandCheckInheritance(); break;
                case 1: sp.sortingManupulations(); break;
                case 2: sp.getmaxOccurance(); break;
                case 3: sp.findLengthfromStart(); break;
                case 4: sp.numberOfBrackets(); break;
                case 5: sp.StringProgram(); break;
                case 6: sp.countMax1s(); break;
                case 7: sp.getHSL(); break;
                case 8: sp.stockPrice(); break;
                case 9: nums.getSumList(); break;
                case 10: sp.convertToNumber(); break;
                case 11: sp.divideandMerge(); break;
               
                //Numbers
                case 12: nums.getMaxOccurance(); break;
                case 13: nums.getSeries(); ; break;
                case 14: nums.getLeader(); break;
                case 15: nums.getCrownNumber(); break;
                case 16: nums.matrix(); break;
                case 17: nums.getProductOfDigits(); break;
                case 18: nums.maxthree(); break;
                case 19: nums.getNum(); break;

                //Files
                case 20: f.FileProgram(); break;
                case 21: DelegatesExample(); break;
                case 22: Ext_MethodsExample(); break;
                case 23: aSynExample(); break;


                default:
                    return;
            }
            Console.ReadKey();
        }
    }
    public enum Gender
    {
        Male,
        Female,
        Others
    }
}