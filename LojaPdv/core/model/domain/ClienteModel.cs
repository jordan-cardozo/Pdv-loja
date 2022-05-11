/*
 * Criado por SharpDevelop.
 * Usuário: Usuario1
 * Data: 25/04/2021
 * Hora: 20:18
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace LojaPdv.core.model.domain
{
	/// <summary>
	/// Description of ClienteModel.
	/// </summary>
	public class ClienteModel
	{
		private int codigo;
		private string nome;
		private string endereco;
		private string bairro;
		private string cidade;
		private string uf;
		private string cep;
		private string telefone;
		private string cpf;
		
		//Construtor
		public ClienteModel()
		{
		}

		public int Codigo {
			get {
				return codigo;
			}
			
			set {
				codigo = value;
			}
		}
	}
}
