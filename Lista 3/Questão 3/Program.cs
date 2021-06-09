using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pilha = new Stack<int>();

            string textoLido = "1+ (5 +3 - (8-5)*4 - ((3+7)*(3-1)))";

            char[] chars = textoLido.ToCharArray();

            foreach (char c in chars)
            {
                if (c == '(')
                {
                    pilha.Push(0);
                }
                if (c == ')')
                {
                    if (pilha.Count > 0)
                    {
                        pilha.Pop();
                    }
                    else
                    {
                        Console.WriteLine("Parenteses incorretos.");
                        Console.ReadLine();
                        return;
                    }
                }
            }

            if (pilha.Count == 0)
            {
                Console.WriteLine("Parenteses corretos.");
            }
            else
            {
                Console.WriteLine("Parenteses incorretos.");
            }

            Console.ReadLine();

        }




    }
}
