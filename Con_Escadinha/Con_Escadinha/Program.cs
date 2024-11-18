using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_Escadinha
{
    internal class Program
    {
        static void Main(string[] args)
        {

        for(int i = 8; i > 0; i--)
            {
                    Console.Write("".PadLeft(i));

                for(int j = 8; j <= 8; j--)
                {
                    if (j >= i)
                    {
                        Console.Write("■");
                    }
                    if(j==0)
                    {
                        Console.Write("\n");
                    }
                    else
                    {
                        Console.Write("FAZ U L  ")
                    }
                }
            }
        Console.ReadKey();
        }
    }
}
