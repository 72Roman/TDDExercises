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
        public static string Greet(string[] names)
        {
            string response = "Hello, ";
            if(names.Length == 2)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    response = response + names[i];
                    if (i == names.Length - 2)
                        response += " and ";
                }
            }
            else
            {
                for (int i = 0; i < names.Length; i++)
                {
                    response = response + names[i];
                    if (i <= names.Length - 2)
                        response += ", ";
                    if (i == names.Length - 2)
                        response += "and ";
                }
            } 
            response += ".";
            return response;
        }
        // public static string Greet(params string[] names) { }
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
