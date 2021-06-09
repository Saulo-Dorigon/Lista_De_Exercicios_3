using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string textoAAnalisar = "...Uma atividade livre, conscientemente tomada como “não-séria” e exterior à vida habitual, mas ao mesmo tempo capaz de absorver o jogador de maneira intensa e total. É uma atividade desligada de todo e qualquer interesse material, com a qual não se pode obter qualquer lucro, praticada dentro de limites espaciais e temporais próprios, segundo uma certa ordem e certas regras. Promove a formação de grupos sociais com tendência a rodearem-se de segredo e a sublinharem sua diferença em relação ao resto do mundo por meio de disfarces ou outros meios semelhantes.";

            Console.WriteLine("O texto possui " + QuantasPalavrasDiferentes(textoAAnalisar) + " palavras diferentes!");


            Console.ReadLine();

        }

        static int QuantasPalavrasDiferentes(string texto)
        {
            Dictionary<String, int> quantasPalavras = new Dictionary<string, int>();
            string[] palavras = texto.Split(' ', ',', '.');
            int palavrasDiferentes = 0;
            foreach (var item in palavras)
            {
                if (item.Length != 0)
                {
                    int count;
                    if (!quantasPalavras.TryGetValue(item, out count))
                    {
                        palavrasDiferentes++;
                        count = 0;
                    }
                    quantasPalavras[item] = count + 1;
                }

            }

            return palavrasDiferentes;
        }
    }
}
