using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Modelos;

namespace WebApplication.Negocio
{
    public class Item05_Negocio
    {
        public RetornoItens Processar()
        {
            RetornoItens retornoItens = new RetornoItens();
            retornoItens.NumItem = 5;
            try
            {                
                    retornoItens.Sucesso = true;
                    retornoItens.Mensagem = "OK";
                    retornoItens.Retorno = "SELECT                                                    " +
                                           "  clb.nome_colaborador,                                   " +
                                           "  ldt.uf,                                                 " +
                                           "  SUM(slr.valor_pago) as valor_pago                       " +
                                           "FROM                                                      " +
                                           "  salarios slr,                                           " +
                                           "  colaboradores clb,                                      " +
                                           "  local_de_trabalho ldt                                   " +
                                           "WHERE                                                     " +
                                           "    TRUE                                                  " +
                                           "AND slr.id_colaborador = clb.id_colaborador               " +
                                           "AND clb.id_colaborador = local_de_trabalho.id_colaborador " +
                                           "AND EXTRACT(YEAR FROM slr.data_pagamento) = '2014'        " +
                                           "GROUP BY 1,2                                              ";
            }
            catch (Exception ex)
            {
                retornoItens.Sucesso = false;
                retornoItens.Mensagem = ex.Message;
            }
            return retornoItens;
        }
    }
}