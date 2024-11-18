using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_Herança
{
    public class Program
    {
        static Processar p=new Processar();
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Número..........: ");
                    p.numero=int.Parse(Console.ReadLine());
                Console.Write("Nome............: ");
                    p.nome = Console.ReadLine();
                while (p.n1 < 0 || p.n1 > 10 || p.n2 < 0 || p.n2 > 10)
                {
                    Console.Write("Primeira Nota...: ");
                    p.n1 = int.Parse(Console.ReadLine());
                    Console.Write("Segunda Nota....: ");
                    p.n2 = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("\n");
                Console.WriteLine("A média do Aluno " + p.nome + " é " + p.Media(p.CalcularMedia(p.n1, p.n2)));
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
