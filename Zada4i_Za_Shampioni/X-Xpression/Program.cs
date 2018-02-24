using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_Xpression
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal result = 0;
            int expressionOperator = '+';
            int symbol = Console.Read();

            while (symbol != '=')
            {
                
                if (symbol == '(')
                {
                    decimal innerResult = 0;
                    int innerOperator = '+';
                    //symbol = Console.Read();
                    while (symbol != ')')
                    {
                        symbol = Console.Read();
                        if (0 <= symbol - '0' && symbol - '0' <= 9)
                        {
                            switch (innerOperator)
                            {
                                case '+':
                                    innerResult += symbol - '0';
                                    break;
                                case '-':
                                    innerResult -= symbol - '0';
                                    break;
                                case '*':
                                    innerResult *= symbol - '0';
                                    break;
                                case '/':
                                    innerResult /= symbol - '0';
                                    break;
                            }
                        }
                        else if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/')
                        {
                            innerOperator = symbol;
                        }

                    }
                    if (symbol == ')')
                    {
                        switch (expressionOperator)
                        {
                            case '+':
                                result += innerResult;
                                break;
                            case '-':
                                result -= innerResult;
                                break;
                            case '*':
                                result *= innerResult;
                                break;
                            case '/':
                                result /= innerResult;
                                break;
                        }
                        
                    }
                }
                 
                else if (0 <= symbol - '0' && symbol - '0' <= 9)
                {
                    switch (expressionOperator)
                    {
                        case '+':
                            result += symbol - '0';
                            break;
                        case '-':
                            result -= symbol - '0';
                            break;
                        case '*':
                            result *= symbol - '0';
                            break;
                        case '/':
                            result /= symbol - '0';
                            break;
                    }
                }
                else if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/')
                {
                    expressionOperator = symbol;
                }
                symbol = Console.Read();

            }
            Console.WriteLine($"{result:F2}");
            Console.WriteLine("Cykni enter za izlizane.");
            Console.ReadKey();
            
        }
    }
}
