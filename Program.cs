using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
             var amount = int.Parse(Console.ReadLine());
             var results = new decimal[amount];
             for (int i = 0; i < amount; i++)
             {
                 var bodylength = int.Parse(Console.ReadLine());
                 var bodywidth = decimal.Parse(Console.ReadLine());
                 var winglength = decimal.Parse(Console.ReadLine());
                 var totalyears =(decimal) bodylength*bodylength * ((decimal)bodywidth + (2 * winglength));
                 results[i] = totalyears;
             }
                Console.WriteLine(string.Join("\n",results));
            
            
        }
    }
}

