/*
 * Criado por SharpDevelop.
 * Usuário: Usuario1
 * Data: 25/04/2021
 * Hora: 20:15
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace LojaPdv.core.model.dao
{
	/// <summary>
	/// Description of conexao.
	/// </summary>
	public class Conexao
	{
		
        static String bdString = "server=localhost;uid=root;pwd=;database=LojaPdv;";

        protected MySqlConnection con = new MySqlConnection(bdString);
        
        public ArrayList lista;
		
		//Construtor
		public Conexao() 
		{
			
		}
		
		//Método para Conectar
		public Boolean conectar(){ 
			 if (con.State.Equals(ConnectionState.Closed))
                {
	             try {
					con.Open();
					Console.Out.WriteLine(con.State);
					if (con.State == ConnectionState.Open){
						MessageBox.Show("Conectou ao Banco de Dados!");
						return true;
					}
				} catch (Exception e) {
	                Console.Out.WriteLine("Impossível estabecer Conexão:" + e.Message);
				}
             }
			
			return false;
		}
		
		public MySqlConnection Con{
			get{
				return con;
			}
		}
		
		public DataTable executarQuerySQL(String pSQL){
			DataSet mDataSet;
			DataTable mDataTable;
			MySqlDataAdapter mAdapter;
			try{
				mDataTable = new DataTable();
				mDataSet = new DataSet();
				mAdapter = new MySqlDataAdapter(pSQL, Con);
				mAdapter.Fill(mDataTable);
				MessageBox.Show("Executando query!");
				
//				foreach (DataRow dtrow in mDataTable.Rows){
//					lista.Add(dtrow);
//				}
				MessageBox.Show("Executou query!");
				return mDataTable;
			} catch (Exception e) {
                Console.Out.WriteLine("Impossível executar a consulta:" + e.Message);
			}
			return null;			
		}
		
		
		//Método para desconectar
		public void desconectar(){
			
		}
	}
}
