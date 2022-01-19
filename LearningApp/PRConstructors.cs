﻿using System;
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
        public static dynamic Obj;
        static Class_static()
        {
            data = "Single Instace Class";
        }
        public static void getData()
        {
            Console.Write(data);
        }
        public static void tt(dynamic test)
        {

        }
    }

    sealed class Class_sealed
    {
        public string data;
        void getString()
        {

        }
    }

    //Exmple of single instance Class
    public sealed class UserService
    {
       private static UserService instance = null;
       public static string userName { get; set; }
       public static int userId { get; set; }
       private UserService() { }
       public static UserService getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserService();
                }
                return instance;
            }
        }
        
    }

}
