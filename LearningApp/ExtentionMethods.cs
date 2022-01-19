using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp
{
    public static class ExtentionMethods
    {
        public static string getFormat(this String str)
        {
            return "MyString : " + str;
        }

        //public static string Asformat(this Class_sealed str)
        //{
        //    return "MyString : "+str.data;
        //}
    }
}
