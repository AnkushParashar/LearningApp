using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp
{
    class PRConstructors
    {
        public static string data;
        public string NonStaticData;
        public static PRConstructors instance = null; 
        private PRConstructors()
        {
            data = "Single Instance Class";
            NonStaticData = "";
        }

        public static PRConstructors getInstance()
        {
            if (instance==null)
            {
                instance = new PRConstructors();
            }
            
            return instance;
        }


    }
    static class Class_static
    {
        public static string data;
        static Class_static()
        {
            data = "Single Instace Class";
        }
        public static void getData()
        {
            Console.Write(data);
        }
    }
    
}
