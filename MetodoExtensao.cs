using System;
using System.Collections.Generic;
using System.Text;

namespace Metodos_Extensao
{
    public static class MetodoExtensao
    {
        //indicado pela palavra this antes do nome do primeiro argumento do método
        public static int ContaCaracteres(this string texto)
        {
            var iContador = texto.Length;
            return iContador;
        } 

        //estende a classe string
        public static int ContaPalavras(this string texto)
        {
            return texto.Split(new char[] { ' ', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        //Metodo de extensao usando um tipo genérico 
        public static string ToString<T>(this IEnumerable<T> enumeration)
        {
            StringBuilder resultado = new StringBuilder();

            resultado.Append("[");
            
            foreach (var item in enumeration)
            {
                resultado.Append(item.ToString());
                resultado.Append(", ");
            }

            if (resultado.Length > 1)
            {
                resultado.Remove(resultado.Length - 2, 2);
            }

            resultado.Append("]");
            return resultado.ToString();
        }

    }

    public static class IListExtensao
    {
        //O método de extensão AumentarValorLista pode acessar somente os elementos incluidos na interface IList
        
	public static void AumentarValorLista(this IList<int> lista, int quantidade)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                lista[i] += quantidade;
            }
        }
    }
}
