using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication.Modelos;
using WebApplication.Negocio;

namespace WebApplication.Controller
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string retorno = "";
        bool processado = true;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnItens_Click(object sender, EventArgs e)
        {
            //Valida se foi marcada alguma opção
            if (rdoItens.SelectedValue.Equals(string.Empty))
            {
                txtMensagem.Text = "Nenhum item selecionado, verifique";
                pnlMensagem.Visible = true;
                return;
            }
            RetornoItens retornoItens = new RetornoItens();
            //Valida qual o item selecionado para chamar os métodos
            switch (rdoItens.SelectedValue)
            {

                //Retorna o maior número inteiro de um array
                case "Item01":
                    Item01_Negocio item01_Negocio = new Item01_Negocio();
                    retornoItens = item01_Negocio.Processar();
                    break;
                //Passa a lista de arquivos texto em um diretório específico quem possuem em seu conteúdo números de telefone em um formato específico
                case "Item02":
                    Item02_Negocio item02_Negocio = new Item02_Negocio();
                    retornoItens = item02_Negocio.Processar();
                    break;
                //Dentro do “C:” cria uma pasta dinamicamente e copia as imagens de um determinado diretório
                case "Item03":
                    Item03_Negocio item03_Negocio = new Item03_Negocio();
                    retornoItens = item03_Negocio.Processar();
                    break;
                //Popula uma caixa de seleção através de uma requisição Ajax a um arquivo JSON
                case "Item04":
                    Item04_Negocio item04_Negocio = new Item04_Negocio();
                    retornoItens = item04_Negocio.Processar();
                    break;
                //Retorna o SQL com a soma dos salários recebidos por colaborador e estado no ano de 2014
                case "Item05":
                    Item05_Negocio item05_Negocio = new Item05_Negocio();
                    retornoItens = item05_Negocio.Processar();
                    break;
            }
        }
        protected void btnOkMsg_Click(object sender, EventArgs e)
        {
            txtMensagem.Text = "";
            pnlMensagem.Visible = false;
        }
    }
}