```C#
using System;
using System.Collections.Generic;

namespace ValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            bool isValid = IsValidParentheses(input);

            if (isValid)
            {
                Console.WriteLine("The string has valid parentheses.");
            }
            else
            {
                Console.WriteLine("The string does not have valid parentheses.");
            }
        }

        static bool IsValidParentheses(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char openBracket = stack.Pop();

                    if (c == ')' && openBracket != '(')
                    {
                        return false;
                    }
                    else if (c == '}' && openBracket != '{')
                    {
                        return false;
                    }
                    else if (c == ']' && openBracket != '[')
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
```