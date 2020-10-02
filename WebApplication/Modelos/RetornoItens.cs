using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Modelos
{
    public class RetornoItens
    {
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public int NumItem { get; set; }
        public string Retorno { get; set; }
    }
}