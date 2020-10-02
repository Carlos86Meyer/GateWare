using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using WebApplication.Modelos;

namespace WebApplication.Negocio
{
    public class Item02_Negocio
    {
        //Como não foi definido, está considerando apenas txt
        public RetornoItens Processar()
        {
            RetornoItens retornoItens = new RetornoItens();
            retornoItens.NumItem = 2;
            string aux = "";
            try
            {
                aux = ListarArquivos();
                if (aux.Contains("ERRO"))
                {
                    retornoItens.Sucesso = false;
                    retornoItens.Mensagem = aux;
                }
                else
                {
                    retornoItens.Sucesso = true;
                    retornoItens.Mensagem = "OK";
                    retornoItens.Retorno = aux;
                }
            }
            catch (Exception ex)
            {
                retornoItens.Sucesso = false;
                retornoItens.Mensagem = ex.Message;
            }
            return retornoItens;
        }

        //lista os arquivos do diretório. Vai retornar os arquivos separados por ;
        public string ListarArquivos()
        {
            string retorno = "";
            List<string> arquivosRetorno = new List<string>();
            string diretorio = @"C:\";
            try
            {
                string[] arquivos = Directory.GetFiles(diretorio, "*.txt");
                foreach (string arquivo in arquivos)
                {
                    //valida se retorna valor
                    if (ProcurarTelefone(arquivo))
                    {
                        arquivosRetorno.Add(arquivo);
                    }
                }
                retorno = string.Join(";", arquivosRetorno);
            }
            catch(Exception ex)
            {
                retorno = "ERRO: " + ex.Message.ToString();
            }
            return retorno;
        }

        //lê o conteudo do arquivo a procura de telefone        
        public bool ProcurarTelefone(string NomeArquivo)
        {
            string[] linhas = File.ReadAllLines(NomeArquivo);
            bool retorno = false;
            foreach (string line in linhas)
            {
                if (line.ToLower().Contains("ddd") || 
                    line.ToLower().Contains("fone") ||
                    line.ToLower().Contains("cel"))
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
    }
}