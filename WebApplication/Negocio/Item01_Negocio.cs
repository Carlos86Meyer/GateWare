using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Modelos;

namespace WebApplication.Negocio
{
    public class Item01_Negocio
    {
        public RetornoItens Processar()
        {
            RetornoItens retornoItem01 = new RetornoItens();
            retornoItem01.NumItem = 1;
            int aux = 0;
            try
            {
                //primeiro alimenta um array com números randômicos
                int[] numeros = new int[10];
                numeros = CriarArrayRandom();
                //agora busca qual o maior número dentro dele
                for (int contador = 0; contador < 11; contador++)
                {
                    if (numeros[contador] > aux)
                    {
                        aux = numeros[contador];
                    }
                }
                retornoItem01.Sucesso = true;
                retornoItem01.Mensagem = "OK";
                retornoItem01.Retorno = aux.ToString();
            }
            catch (Exception ex)
            {
                retornoItem01.Sucesso = false;
                retornoItem01.Mensagem = ex.Message;
            }
            return retornoItem01;
        }

        //cria um array de inteiros com números randomicos
        public int[] CriarArrayRandom()
        {
            int[] array = new int[10];
            Random random = new Random();
            for (int contador = 0; contador < 10; contador++)
            {
                array[contador] = random.Next(1, 1000);
            }
            return array;
        }

    }
}