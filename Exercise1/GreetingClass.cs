using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    public class GreetingClass
    {
        public static string Greet(string name)
        {
            if (String.IsNullOrEmpty(name))
                return "Hello, my friend.";
            if (IsStringInUpperCase(name))
                return "HELLO " + name + '!';
            return "Hello, " + name + ".";
        }
        public static bool IsStringInUpperCase(string str)
        {
            if (String.IsNullOrEmpty(str))
                return false;
            foreach(var character in str)
            {
                if (!Char.IsUpper(character))
                    return false;
            }
            return true;
        }
    }
}
