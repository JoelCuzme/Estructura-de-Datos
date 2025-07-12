using System;
using System.Collections.Generic;

public class Verificador
{
    public static void Main(string[] args)
    {
        string expression1 = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";
        string expression2 = "{[()]}";
        

        Console.WriteLine($"Formula: {expression1} -> { (balaceado(expression1) ? "Balanceada." : "No balanceada.")}");
        Console.WriteLine($"Formula: {expression2} -> { (balaceado(expression2) ? "Balanceada." : "No balanceada.")}");
        
    }

    public static bool balaceado(string expression)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in expression)
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

                char topChar = stack.Pop();

                if ((c == ')' && topChar != '(') ||
                    (c == '}' && topChar != '{') ||
                    (c == ']' && topChar != '['))
                {
                    return false; 
                }
            }
        }

        return stack.Count == 0; 
    }
}