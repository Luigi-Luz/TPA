using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_Herança
{
    public class Processar:Aluno
    {
        public float CalcularMedia(float nota1, float nota2)
        {
            return (nota1 + nota2) / 2;
        }
        public string Media(float conceito)
        {
            if (conceito < 4)
            {
                return "I - Insatisfatório";
            }
            if (conceito >= 4 && conceito < 7)
            {
                return "R - Regular";
            }
            if (conceito >= 7 && conceito < 10)
            {
                return "B - Bom";
            }
            if (conceito == 10)
            {
                return "MB - Muito Bom";
            }
            else
            {
                return "Valor Inválido";
            }
        }
    }
}
