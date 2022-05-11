/*
 * Criado por SharpDevelop.
 * Usuário: Usuario1
 * Data: 25/04/2021
 * Hora: 20:16
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections;
using System.Data;
using MySql.Data.MySqlClient;

namespace LojaPdv.core.model.dao
{
	/// <summary>
	/// Description of ClienteDAO.
	/// </summary>
	public class ClienteDAO : Conexao
	{
		DataSet mDataSet;
		MySqlDataAdapter mAdapter;
		
		public DataTable getListaClienteDAO()
		{
			String query = "SELECT codigo, nome, endereco, bairro, cidade, uf, cep, telefone FROM Clientes;";
			conectar();
			return executarQuerySQL(query);
		}
	}
}
