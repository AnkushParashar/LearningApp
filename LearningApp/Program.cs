using System;
namespace LearningApp
{
    class Program
    {
        //STRINGS
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
        
        static string Sortstring(string str)
        {
            string sorted="";
            char[] ar = str.ToCharArray();
            Array.Sort(ar);
            sorted = String.Join("", ar);

            return new string(ar);
        }
        static int reverseNumber(int num)
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
        static int sortNumber(int num)
        {
            string str = num.ToString();
            return int.Parse(Sortstring(str));
        }
        static void Main(string[] args)
        {
            string[] allNames = new string[] { "ABHISHEK", "ANJU", "ACHHAR" };
            //Console.WriteLine(myName.CompareTo(nyName2));
            //Console.WriteLine(a.Replace("67", "").ToString());

            var entredString = (Console.ReadLine()).ToString();
            entredString = reverseNumber(int.Parse(entredString)).ToString();
            //Console.WriteLine("reverse is\n" + entredString);

            Console.Write("after individual words sort\n");
            string[] newArray= new string[allNames.Length];
            for(int i = 0; i < allNames.Length; i++)
            {
                newArray[i] = Sortstring(allNames[i]);
                Console.Write(newArray[i] + " ");
            }
            Array.Sort(newArray);
            //Array.Reverse(newArray);
            Console.Write("\nafter sort\n");
            foreach (string str in newArray)
            {
                Console.Write(str + " ");
            }
            Console.ReadKey();
            
            //CREATING INTEGER ARRAY
            
            

        }
    }
}
