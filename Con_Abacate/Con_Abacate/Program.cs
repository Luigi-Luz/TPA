using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_Abacate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ganhou = false;
            bool Xjoga = true;
            string jogo = "+=================+\n" +
                          "|     |     |     |\n" +
                          "|-----------------|\n" +
                          "|     |     |     |\n" +
                          "|-----------------|\n" +
                          "|     |     |     |\n" +
                          "+=================+";
            string jogoPOS = "+=================+\n" +
                             "|  1  |  4  |  7  |\n" +
                             "|-----------------|\n" +
                             "|  2  |  5  |  8  |\n" +
                             "|-----------------|\n" +
                             "|  3  |  6  |  9  |\n" +
                             "+=================+";

            try
            {

                while (ganhou == false)
                {
                    if (Xjoga == true)
                    {
                        Console.WriteLine("Escolha onde jogar");
                        Console.WriteLine(jogoPOS);
                        Console.ReadLine();
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.Write("*** FIM ***");
                Console.ReadKey();
            }
        }
    }
}
