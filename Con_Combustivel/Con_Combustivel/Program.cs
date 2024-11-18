using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_Combustivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double KM = 0;
            double Litro = 0;
            double Consumo = 0;

            try
            {
                Console.WriteLine("   Calculadora   \n"+
                                  "        De       \n"+
                                  "     Consumo     \n\n");
                Console.Write("Digite os Litros gastos: ");
                Litro = double.Parse(Console.ReadLine());
                Console.Write("Digite os KMs percorridos: ");
                KM = double.Parse(Console.ReadLine());

                Consumo=KM / Litro;

                Console.WriteLine($"O Consumo foi de {Consumo} KM por Litro ");

            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("*** FIM ***");
                Console.ReadKey();
            }
        }
    }
}
