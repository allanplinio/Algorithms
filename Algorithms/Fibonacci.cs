using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class Fibonacci
    {
        public Fibonacci()
        {
            var lista = new List<int>();

            for (int i = 1; i < 10; i++)
            {
                if (i == 1)
                {
                    lista.Add(i);
                }
                else if (i == 2)
                {
                    lista.Add(1);
                }
                else
                {
                    var total = lista[i - 3] + lista[i - 2];
                    lista.Add(total);
                }
            }


            Console.WriteLine(string.Join(", ", lista));
        }
    }
}
