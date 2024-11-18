using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_Fatoracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resul = 1;
            int fatorado = 0;
            string conta = "0 =";
            string conta2 = conta;
            try
            {
                while (fatorado <= 10)
                {
                    if (fatorado == 0)
                    {
                        resul = 1;
                        conta = null;
                        conta2 = null;
                    }
                    else
                    {
                        resul *= fatorado;
                        if(fatorado > 1) {
                        conta=fatorado+"."+conta;
                        }else{
                            conta="1 ";
                        }
                        conta2 = conta + "=";
                    }
                    Console.WriteLine("!" + fatorado +"="+ conta2 +" "+ resul);
                    fatorado++;
                }
            }catch(Exception)
            {
                Console.WriteLine("Error 201");
            }
            finally
            {
                Console.WriteLine("*** FIM *** \n(Pressione Enter para fechar)");
                Console.ReadLine();
            }
        }
    }
}