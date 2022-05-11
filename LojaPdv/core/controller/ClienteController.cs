/*
 * Criado por SharpDevelop.
 * Usuário: Usuario1
 * Data: 25/04/2021
 * Hora: 20:14
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections;
using System.Data;
using LojaPdv.core.model.dao;

namespace LojaPdv.core.controller
{
	/// <summary>
	/// Description of ClienteController.
	/// </summary>
	public class ClienteController
	{
		ClienteDAO clienteDAO = new ClienteDAO();
		
		public ClienteController()
		{
		}
		
		public DataTable getListaClientes(){
			return clienteDAO.getListaClienteDAO();
		}
	}
}
