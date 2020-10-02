<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication.Controller.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <script type="text/javascript">

        </script>
        <div id="divIndex" title="Questionário Técnico - Index" style="font-size: 12px; display: none;">
            <div class="divItens">
                <asp:UpdatePanel runat="server" UpdateMode="Always">
                    <ContentTemplate>
                        <asp:HiddenField ID="hddMensagem" runat="server"/>
                    </ContentTemplate>                  
                    <Table style="width: 100%;">
                        <tr style="height: 30px;" id="trItens" runat="server">
                        <td>
                            Itens:
                        </td>
                        <td>
                            <asp:RadioButtonList ID="rdoItens" runat="server" AutoPostBack="true">
                                <asp:ListItem Text="Item 1 - Maior número de um array" Value="Item01" />
                                <asp:ListItem Text="Item 2 - Lista de arquivos no diretório" Value="Item02" />
                                <asp:ListItem Text="Item 3 - Criar pasta dinamicamente" Value="Item03" />
                                <asp:ListItem Text="Item 4 - JavaScript" Value="Item04" />
                                <asp:ListItem Text="Item 5 - Comando SQL" Value="Item05" />
                            </asp:RadioButtonList>                            
                        </td>
                            </tr>
                        <tr style="height: 30px;">
                            <td colspan="2" align="center" style="border: 1px solid black;">
                                <asp:button ID="btnItens" runat="server" OnClick="btnItens_Click" Text="Processar"/>
                            </td>
                        </tr>
                    </Table>
                    <!-- Panel para as mensagens -->
                    <asp:Panel ID="pnlMensagem" Visible="false" runat="server">
                        <table style="width: 100%;">
                            <tr>
                                <td>
                                    ATENÇÃO!!
                                </td>
                                </tr>
                            <tr>
                                <td align="center">
                                <asp:TextBox ID="txtMensagem" runat="server" Width="100%">
                                </asp:TextBox>
                            </td>                            
                        </tr>                        
                        <tr>
                            <td align="center">
                                <asp:Button ID="btnOkMsg" runat="server" Text="OK" OnClick="btnOkMsg_Click" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
                <!-- Panel para o Item 4 -->
                <asp:Panel ID="pnlItem04" visible="false" runat="server">
                    <table style=""width: 100%;">
                        <tr>
                            <td>
                                Itens selecionaveis carregados apartir do JSON
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:DropDownList ID="ddlItem04" runat="server" ClientIDMode="Static" 
                                    DataValueField="cod_tipo_ramo_atividade" DataTextField="des_tipo_ramo_atividade">
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
                </asp:UpdatePanel>
            </div>
        </div>
    </form>
</body>
</html>
