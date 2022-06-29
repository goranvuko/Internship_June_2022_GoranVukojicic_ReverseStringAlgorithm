using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseStringAlgorithm
{
    public class ReverseString
    {
        public static string reverseMethod()
        {
            string str = ""; 
            string revString = "";
            
            Console.WriteLine("Enter string:");
            str = Console.ReadLine();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                revString += str[i];
            }
            
            return revString;
            
        }
    }
}
