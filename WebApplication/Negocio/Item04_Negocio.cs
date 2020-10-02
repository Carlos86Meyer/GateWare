using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Modelos;

namespace WebApplication.Negocio
{
    public class Item04_Negocio
    {
        //Com Javascript e/ou Jquery, ao clicar em um botão, popule uma caixa de seleção através de uma requisição Ajax a um arquivo JSON
        public RetornoItens Processar()
        {
            RetornoItens retornoItens = new RetornoItens();
            retornoItens.NumItem = 4;
            try
            {
                retornoItens.Sucesso = true;
                retornoItens.Mensagem = "OK";
            }
            catch(Exception ex)
            {
                retornoItens.Sucesso = false;
                retornoItens.Mensagem = "ERRO: " + ex.Message;
            }
            return retornoItens;
        }
    }
}