using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LearningApp
{
    public class Files
    {
        internal void FileProgram()
        {
            string file = @"C:\files\input.txt";
            string[] lines = { };
            string Person = "";
            int Count = 0;
            Dictionary<string, int> names = new Dictionary<string, int>();
            if (File.Exists(file))
            {
                lines = File.ReadAllLines(file);
            }
            foreach (string line in lines)
            {
                string[] words = line.Split(',');
                
                if (names.ContainsKey(words[3]))
                {
                    int value = names[words[3]];
                    names.Remove(words[3]);
                    names.Add(words[3], value + 1);
                }
                else
                {
                    names.Add(words[3], 1);
                }
            }
            KeyValuePair<string, int> ou;
            foreach (KeyValuePair<string, int> item in names)
            {
                int max = -1;
                if (item.Value > max)
                {
                    max = item.Value;
                    ou = item;
                    Person = item.Key;
                    Count = item.Value;
                }
            }
            string outfile = @"C:\files\output.txt";

            File.WriteAllText(outfile, Person + ":" + Count);
        }
    }
}
