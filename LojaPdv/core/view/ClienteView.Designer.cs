/*
 * Criado por SharpDevelop.
 * Usuário: Usuario1
 * Data: 25/04/2021
 * Hora: 20:31
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace LojaPdv.core.view
{
	partial class ClienteView
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tfCodigo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tfNome;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tfEndereco;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tfBairro;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tfCidade;
		private System.Windows.Forms.TextBox tfUf;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tfCep;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tfTelefone;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tfPesquisar;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.DataGridView tblClientes;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
		private System.Windows.Forms.DataGridViewTextBoxColumn Uf;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnCancelar;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.tfCodigo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tfNome = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tfEndereco = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tfBairro = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tfCidade = new System.Windows.Forms.TextBox();
			this.tfUf = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tfCep = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tfTelefone = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tfPesquisar = new System.Windows.Forms.TextBox();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.tblClientes = new System.Windows.Forms.DataGridView();
			this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnNovo = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.tblClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Código:";
			// 
			// tfCodigo
			// 
			this.tfCodigo.Location = new System.Drawing.Point(12, 35);
			this.tfCodigo.Name = "tfCodigo";
			this.tfCodigo.Size = new System.Drawing.Size(79, 20);
			this.tfCodigo.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(97, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nome:";
			// 
			// tfNome
			// 
			this.tfNome.Location = new System.Drawing.Point(97, 35);
			this.tfNome.Name = "tfNome";
			this.tfNome.Size = new System.Drawing.Size(437, 20);
			this.tfNome.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Endereço:";
			// 
			// tfEndereco
			// 
			this.tfEndereco.Location = new System.Drawing.Point(12, 93);
			this.tfEndereco.Name = "tfEndereco";
			this.tfEndereco.Size = new System.Drawing.Size(272, 20);
			this.tfEndereco.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(290, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Bairro:";
			// 
			// tfBairro
			// 
			this.tfBairro.Location = new System.Drawing.Point(290, 93);
			this.tfBairro.Name = "tfBairro";
			this.tfBairro.Size = new System.Drawing.Size(244, 20);
			this.tfBairro.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 125);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Cidade:";
			// 
			// tfCidade
			// 
			this.tfCidade.Location = new System.Drawing.Point(12, 151);
			this.tfCidade.Name = "tfCidade";
			this.tfCidade.Size = new System.Drawing.Size(227, 20);
			this.tfCidade.TabIndex = 9;
			// 
			// tfUf
			// 
			this.tfUf.Location = new System.Drawing.Point(245, 151);
			this.tfUf.Name = "tfUf";
			this.tfUf.Size = new System.Drawing.Size(39, 20);
			this.tfUf.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(245, 125);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "UF:";
			// 
			// tfCep
			// 
			this.tfCep.Location = new System.Drawing.Point(290, 151);
			this.tfCep.Name = "tfCep";
			this.tfCep.Size = new System.Drawing.Size(89, 20);
			this.tfCep.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(290, 125);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 13;
			this.label7.Text = "CEP:";
			// 
			// tfTelefone
			// 
			this.tfTelefone.Location = new System.Drawing.Point(385, 151);
			this.tfTelefone.Name = "tfTelefone";
			this.tfTelefone.Size = new System.Drawing.Size(149, 20);
			this.tfTelefone.TabIndex = 14;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(385, 125);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 15;
			this.label8.Text = "Telefone:";
			// 
			// tfPesquisar
			// 
			this.tfPesquisar.Location = new System.Drawing.Point(12, 186);
			this.tfPesquisar.Name = "tfPesquisar";
			this.tfPesquisar.Size = new System.Drawing.Size(367, 20);
			this.tfPesquisar.TabIndex = 16;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.btnPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnPesquisar.Location = new System.Drawing.Point(385, 186);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(149, 23);
			this.btnPesquisar.TabIndex = 17;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			// 
			// tblClientes
			// 
			this.tblClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tblClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Codigo,
			this.Nome,
			this.Cidade,
			this.Uf});
			this.tblClientes.Location = new System.Drawing.Point(12, 220);
			this.tblClientes.Name = "tblClientes";
			this.tblClientes.Size = new System.Drawing.Size(522, 163);
			this.tblClientes.TabIndex = 18;
			// 
			// Codigo
			// 
			this.Codigo.HeaderText = "Código";
			this.Codigo.Name = "Codigo";
			// 
			// Nome
			// 
			this.Nome.HeaderText = "Nome";
			this.Nome.Name = "Nome";
			// 
			// Cidade
			// 
			this.Cidade.HeaderText = "Cidade";
			this.Cidade.Name = "Cidade";
			// 
			// Uf
			// 
			this.Uf.HeaderText = "UF";
			this.Uf.Name = "Uf";
			// 
			// btnNovo
			// 
			this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.btnNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnNovo.Location = new System.Drawing.Point(12, 405);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(75, 25);
			this.btnNovo.TabIndex = 19;
			this.btnNovo.Text = "Novo";
			this.btnNovo.UseVisualStyleBackColor = true;
			this.btnNovo.Click += new System.EventHandler(this.BtnNovoClick);
			// 
			// btnExcluir
			// 
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnExcluir.Location = new System.Drawing.Point(133, 405);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 25);
			this.btnExcluir.TabIndex = 20;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			// 
			// btnAlterar
			// 
			this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnAlterar.Location = new System.Drawing.Point(235, 405);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(75, 25);
			this.btnAlterar.TabIndex = 21;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseVisualStyleBackColor = true;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnSalvar.Location = new System.Drawing.Point(336, 405);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 25);
			this.btnSalvar.TabIndex = 22;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnCancelar.Location = new System.Drawing.Point(459, 405);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 25);
			this.btnCancelar.TabIndex = 23;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// ClienteView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(546, 440);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnNovo);
			this.Controls.Add(this.tblClientes);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.tfPesquisar);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.tfTelefone);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.tfCep);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tfUf);
			this.Controls.Add(this.tfCidade);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tfBairro);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tfEndereco);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tfNome);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tfCodigo);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.Name = "ClienteView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ClienteView";
			((System.ComponentModel.ISupportInitialize)(this.tblClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
