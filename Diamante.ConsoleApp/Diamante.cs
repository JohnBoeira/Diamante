using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamante.ConsoleApp
{
    public class Diamante
    {
        int aux = 0;

        List<string> letrinhas = new List<string>
        {
            {"A"}, {"B"}, {"C"}, {"D"}, {"E"},
            {"F"}, {"G"}, {"H"}, {"I"}, {"J"},
            {"K"}, {"L"}, {"M"}, {"N"}, {"O"},
            {"P"}, {"Q"}, {"R"}, {"S"}, {"T"},
            {"U"}, {"V"}, {"W"}, {"X"}, {"Y"},
            {"Z"}

        };

        public string separadorEntreLetras(int valorLetra)
        {
            aux = valorLetra;
            if (valorLetra == 1)
            {
            }
            else if (valorLetra == 2)
            {
                valorLetra++;
            }
            else if (valorLetra == 3)
            {
                valorLetra = valorLetra + 2;
            }
            else
            {
                valorLetra = valorLetra + aux - 1;
            }
            string espacos = "";
            for (int i = 0; i < valorLetra; i++)
            {
                espacos += " ";
            }
            return espacos;
        }

        public string separadorMargem(int valor)
        {
            string espacos = "";

            for (int i = 0; i < valor; i++)
            {
              
                    espacos += " ";
                
            }
            return espacos;
        }
        public int valorLetraParaFor(char letra)
        {
            switch (letra)
            {
                case 'A': return 0;
                case 'B': return 1;
                case 'C': return 2;
                case 'D': return 3;
                case 'E': return 4;
                case 'F': return 5;
                case 'G': return 6;
                case 'H': return 7;
                case 'I': return 8;
                case 'J': return 9;
                case 'K': return 10;
                case 'L': return 11;
                case 'M': return 12;
                case 'N': return 13;
                case 'O': return 14;
                case 'P': return 15;
                case 'Q': return 16;
                case 'R': return 17;
                case 'S': return 18;
                case 'T': return 19;
                case 'U': return 20;
                case 'V': return 21;
                case 'W': return 22;
                case 'X': return 23;
                case 'Y': return 24;
                case 'Z': return 25;
                default: return 999;
            }

        }

        public void GeraDiamante(char letra)
        {
            //PARTE DE CIMA
            int espacosDoA = 0;
            for (int i = 0; i <= valorLetraParaFor(letra); i++)
            {
                if (letrinhas[i] == "A")
                {
                    espacosDoA = valorLetraParaFor(letra);
                    Console.WriteLine(separadorMargem(valorLetraParaFor(letra)) + letrinhas[i]);
                }
                else if (letrinhas[i] == letra.ToString())
                {
                    char letra1 = Convert.ToChar(letrinhas[i]);
                    Console.WriteLine(letrinhas[i] + separadorEntreLetras(valorLetraParaFor(letra1)) + letrinhas[i]);
                }
                else
                {
                    char letra1 = Convert.ToChar(letrinhas[i]);
                    Console.WriteLine(separadorMargem(espacosDoA - valorLetraParaFor(letra1)) + letrinhas[i] + separadorEntreLetras(valorLetraParaFor(letra1)) + letrinhas[i]);

                }
            }
            //PARTE DE BAIXO
            for (int i = valorLetraParaFor(letra) - 1; i >= 0; i--)
            {
                if (letrinhas[i] == "A")
                {
                    espacosDoA = valorLetraParaFor(letra);
                    Console.WriteLine(separadorMargem(valorLetraParaFor(letra)) + letrinhas[i]);
                }
                else if (letrinhas[i] == letra.ToString())
                {
                    char letra1 = Convert.ToChar(letrinhas[i]);
                    Console.WriteLine(letrinhas[i] + separadorEntreLetras(valorLetraParaFor(letra1)) + letrinhas[i]);
                }
                else
                {
                    char letra1 = Convert.ToChar(letrinhas[i]);
                    Console.WriteLine(separadorMargem(espacosDoA - valorLetraParaFor(letra1)) + letrinhas[i] + separadorEntreLetras(valorLetraParaFor(letra1)) + letrinhas[i]);

                }
            }
        }
    }
}
