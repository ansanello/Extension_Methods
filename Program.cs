using System;
using System.Collections.Generic;

namespace Metodos_Extensao
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "Apenas fazendo um teste !";

            int NumeroDeCaracteres = frase.ContaCaracteres();
            int NumeroDePalavras = frase.ContaPalavras();

            Console.WriteLine("Na frase : " + frase);
            Console.WriteLine("temos : ");
            Console.WriteLine(NumeroDeCaracteres  + " caracteres ");
            Console.WriteLine(NumeroDePalavras + " palavras ");

            Console.ReadKey();

            //------------------------------------------------------------------------------
            Console.WriteLine("");
            Console.WriteLine("Usando o método de extensão : AummentaValorLista() ");
            Console.WriteLine("");
            
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
            
            Console.WriteLine(" 1  2  3  4  5") ;
            Console.WriteLine(" Aumentando os valores 10 unidades ");

            //usando o método de extensão 
            numeros.AumentarValorLista(10);
            foreach (int n in numeros)
            {
                Console.Write(n + " ");
            }
            Console.ReadKey();

            //------------------------------------------------------------------------------
            Console.WriteLine("");
            Console.WriteLine("Usando o método de extensão : ToString<int>");
            //usando o método de extensão 
            Console.WriteLine("");
            Console.WriteLine(numeros.ToString<int>());

            Console.ReadKey();
        }
    }
}
