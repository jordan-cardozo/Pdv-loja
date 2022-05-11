/*
 * Criado por SharpDevelop.
 * Usuário: Usuario1
 * Data: 25/04/2021
 * Hora: 20:31
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using LojaPdv.core.controller;

namespace LojaPdv.core.view
{
	/// <summary>
	/// Description of ClienteView.
	/// </summary>
	public partial class ClienteView : Form
	{
		ClienteController clienteController = new ClienteController();
		
		public ClienteView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			layoutInicial();
			carregarClientesTabela();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public void BtnNovoClick(object sender, EventArgs e)
		{
			habilitarBotoes(true,false,false,true,true,false);
			habilitarCampos(false,true,true,true,true,true,true,true,false);
		}
		
		public void habilitarCampos(bool codigo, bool nome, bool endereco, bool bairro, bool cidade, bool uf, bool cep, bool telefone, bool pesquisa){
			tfCodigo.Enabled = codigo;
			tfNome.Enabled = nome;
			tfEndereco.Enabled = endereco;
			tfBairro.Enabled = bairro;
			tfCidade.Enabled = cidade;
			tfUf.Enabled = uf;
			tfCep.Enabled = cep;
			tfTelefone.Enabled = telefone;
			tfPesquisar.Enabled = pesquisa;

		}
		
		public void habilitarBotoes(bool novo, bool excluir, bool alterar, bool salvar, bool cancelar, bool pesquisar){
			btnNovo.Enabled = novo;
			btnExcluir.Enabled = excluir;
			btnAlterar.Enabled = alterar;
			btnSalvar.Enabled = salvar;
			btnCancelar.Enabled = cancelar;
			btnPesquisar.Enabled = pesquisar;
		}
		
		public void limparCampos(){
			tfCodigo.Text = "";
			tfNome.Text = "";
			tfEndereco.Text = "";
			tfBairro.Text = "";
			tfCidade.Text = "";
			tfUf.Text = "";
			tfCep.Text = "";
			tfTelefone.Text = "";
		}
		
		public void layoutInicial(){
			habilitarCampos(false,false,false,false,false,false,false,false,true);
			habilitarBotoes(true,false,false,false,true,true);
		}
		
		public void BtnCancelarClick(object sender, EventArgs e)
		{
			limparCampos();
			tfPesquisar.Text = "";
			layoutInicial();
			
		}
		
		public DataTable arrayListToDataTable(ArrayList lista){
			 DataTable dt = new DataTable();
              dt.Columns.Add("Codigo");
              dt.Columns.Add("Nome");
              dt.Columns.Add("Cidade");
              dt.Columns.Add("Uf");
              foreach (ArrayList ds in lista) 
              {
                  DataRow dRow = dt.NewRow();
                  dRow["Codigo"] = ds.ToString();
                  dRow["Nome"] = ds.ToString();
                  dRow["Cidade"] = ds.ToString();
                  dRow["Uf"] = ds.ToString();
                  dt.Rows.Add(dRow);
             }
              return dt;
		}

		public void carregarClientesTabela(){
			ArrayList clientesLista;
			DataTable dt;
			dt = clienteController.getListaClientes();
			
			
//			dt = arrayListToDataTable(clientesLista);
			
			
			tblClientes.DataSource = dt;
//			tblClientes.DataMember = "Clientes";
//			tblClientes.Refresh();
			MessageBox.Show("Teste");
		}
		
	}
}
