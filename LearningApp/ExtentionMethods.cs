using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp
{
    public static class ExtentionMethods
    {
        public static string getFormat(this string str)
        {
            return "MyString : " + str;
        }
    }
}
