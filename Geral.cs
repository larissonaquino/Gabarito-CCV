using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabarito_CCV
{
    public static class Geral
    {
        public static string versao = "1.0.1";
        private static double pontos;
        private static int erradas;

        public static Dictionary<int, string> dicionario_gabarito; // Definição do gabarito oficial
        public static Dictionary<int, string> dicionario_resposta; // Gabarito do usuário
        public static List<string> lista_dicionario;

        public static bool gabarito_preenchido { get; set; }
        public static bool resposta_preenchido { get; set; }

        public static double CalcularPontos()
        {
            if(!(gabarito_preenchido && resposta_preenchido))
            {
                System.Windows.Forms.MessageBox.Show("Você precisa definir os gabaritos!", "ERRO!",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return -1;
            }

            lista_dicionario = new List<string>();

            pontos = 0.0;
            erradas = 0;
            for(int i = 1; i <= 30; i++)
            {
                if (dicionario_resposta[i] == dicionario_gabarito[i])
                {
                    if (i >= 1 && i <= 5)
                        pontos += 0.5;
                    else if (i >= 6 && i <= 10)
                        pontos += 1.5;
                    else if (i >= 11 && i <= 20)
                        pontos += 3.0;
                    else if (i >= 21 && i <= 30)
                        pontos += 4.0;

                    lista_dicionario.Add(i + " - (" + dicionario_resposta[i] + ")");
                }
                else
                {
                    erradas++;
                    lista_dicionario.Add(i + " - (" + dicionario_resposta[i] +
                        ") - Correta: (" + dicionario_gabarito[i] + ")");
                    continue;
                }

            }

            return pontos;
        }

        public static int getErradas()
        {
            return erradas;
        }
    }
}
