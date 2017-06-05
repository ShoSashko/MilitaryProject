using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryProject
{
    static class Tools
    {
       public static Dictionary<string, double> dictionary = new Dictionary<string, double>();
        static public Dictionary<string,double> Parsing(string names ,params string[] values)
        {
            string[] name = names.Split(' ');

           
            for (int i = 0; i < values.Length; i++)
            {
                dictionary.Add(name[i], Double.Parse(values[i]));
            }
            return dictionary;
        }
    }
}
