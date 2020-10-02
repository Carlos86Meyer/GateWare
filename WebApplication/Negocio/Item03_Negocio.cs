using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using WebApplication.Modelos;

namespace WebApplication.Negocio
{
    public class Item03_Negocio
    {
        //Em C#, Dentro do “C:” crie uma pasta dinamicamente e copie imagens de um determinado diretório para este, aplique TDD para executar os testes.
        public RetornoItens Processar()
        {
            RetornoItens retornoItens = new RetornoItens();
            retornoItens.NumItem = 3;
            try
            {
                string dirOrigem = @"C:\Imagens_Origem";
                string dirDestino = @"C:\Imagens_Destino";
                //primeiro lista os arquivos do diretorio
                IEnumerable<string> arquivos = ListarImagens(dirOrigem);
                int quantidade = 0;
                //se tiver arquivos, cria o destino
                if (arquivos != null)
                {
                    //cria o novo diretorio
                    if (!CriarDiretorio(dirDestino))
                    {
                        retornoItens.Sucesso = false;
                        retornoItens.Mensagem = "ERRO: problema ao criar novo diretório";
                    }
                    else
                    {
                        //copia os arquivos para o novo diretorio
                        foreach (string arquivo in arquivos)
                        {
                            CopiarArquivos(arquivo, dirOrigem, dirDestino);
                            quantidade++;
                        }
                    }
                }
                string totalArquivos = quantidade.ToString();
                retornoItens.Sucesso = true;
                retornoItens.Mensagem = "OK";
                retornoItens.Retorno = "Copiado(s) {totalArquivos} arquivo(s)";
            }
            catch (Exception ex)
            {
                retornoItens.Sucesso = false;
                retornoItens.Mensagem = ex.Message;
            }
            return retornoItens;
        }

        public bool CriarDiretorio(string diretorio)
        {
            bool retorno = true;
            try
            {
                Directory.CreateDirectory(diretorio);
            }
            catch
            {
                retorno = false;
            }
            return retorno;
        }

        public bool CopiarArquivos(string arquivo, string origem, string destino)
        {
            bool retorno = true;
            try
            {
                string caminho = destino + arquivo;

                if (!File.Exists(caminho))
                {
                    File.Copy(arquivo, caminho);
                }
            }
            catch
            {
                retorno = false;
            }
            return retorno;
        }

        public List<string> ListarImagens(string diretorio)
        {
            IEnumerable<string> extensoes = new string[] { "bmp", "gif", "jpg", "jpeg", "png" };
            List<string> arquivosRetorno = new List<string>();
            try
            {
                IEnumerable<string> arquivos = Directory.EnumerateFiles(diretorio, "*.*")
                    .Where(file => extensoes.Any(x => file.EndsWith(x, StringComparison.OrdinalIgnoreCase)));

                foreach (string arquivo in arquivos)
                {
                    arquivosRetorno.Add(arquivo);
                }
            }
            catch (Exception ex)
            {
                arquivosRetorno.Add("ERRO: " + ex.Message.ToString());
            }
            return arquivosRetorno;
        }
    }
}