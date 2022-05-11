/*
 * Criado por SharpDevelop.
 * Usuário: Usuario1
 * Data: 25/04/2021
 * Hora: 19:06
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LojaPdv.core.view;

namespace LojaPdv
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.WindowState = FormWindowState.Maximized; /*para Abrir Maximizado*/
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ClientesToolStripMenuItemClick(object sender, EventArgs e)
		{
			new ClienteView().Show();
		}
	}
}
