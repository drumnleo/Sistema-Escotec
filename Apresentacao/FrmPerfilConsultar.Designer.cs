namespace Apresentacao
{
    partial class FrmPerfilConsultar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.Label_nome = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dataGridViewPerfil = new System.Windows.Forms.DataGridView();
            this.colIdPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbtnCadastrar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbtnConsultar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbtnExcluir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(54, 10);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(373, 20);
            this.textBoxPesquisa.TabIndex = 0;
            // 
            // Label_nome
            // 
            this.Label_nome.AutoSize = true;
            this.Label_nome.Location = new System.Drawing.Point(13, 13);
            this.Label_nome.Name = "Label_nome";
            this.Label_nome.Size = new System.Drawing.Size(35, 13);
            this.Label_nome.TabIndex = 1;
            this.Label_nome.Text = "Nome";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(452, 8);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dataGridViewPerfil
            // 
            this.dataGridViewPerfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPerfil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdPerfil,
            this.colNome,
            this.colbtnCadastrar,
            this.colbtnConsultar,
            this.colbtnExcluir});
            this.dataGridViewPerfil.Location = new System.Drawing.Point(12, 42);
            this.dataGridViewPerfil.Name = "dataGridViewPerfil";
            this.dataGridViewPerfil.Size = new System.Drawing.Size(548, 268);
            this.dataGridViewPerfil.TabIndex = 3;
            // 
            // colIdPerfil
            // 
            this.colIdPerfil.DataPropertyName = "Id_PerfilTipo";
            this.colIdPerfil.HeaderText = "Codigo";
            this.colIdPerfil.Name = "colIdPerfil";
            this.colIdPerfil.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "Nome";
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colbtnCadastrar
            // 
            this.colbtnCadastrar.DataPropertyName = "btnCadastrar";
            this.colbtnCadastrar.HeaderText = "Menu Cadastrar";
            this.colbtnCadastrar.Name = "colbtnCadastrar";
            this.colbtnCadastrar.ReadOnly = true;
            // 
            // colbtnConsultar
            // 
            this.colbtnConsultar.DataPropertyName = "btnConsultar";
            this.colbtnConsultar.HeaderText = "Menu Consultar";
            this.colbtnConsultar.Name = "colbtnConsultar";
            this.colbtnConsultar.ReadOnly = true;
            // 
            // colbtnExcluir
            // 
            this.colbtnExcluir.DataPropertyName = "btnExcluir";
            this.colbtnExcluir.HeaderText = "Menu Excluir";
            this.colbtnExcluir.Name = "colbtnExcluir";
            this.colbtnExcluir.ReadOnly = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(233, 334);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(314, 334);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(395, 334);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(476, 334);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(152, 334);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // FrmPerfilConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 368);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.dataGridViewPerfil);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.Label_nome);
            this.Controls.Add(this.textBoxPesquisa);
            this.Name = "FrmPerfilConsultar";
            this.Text = "PerfilConsultar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Label Label_nome;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dataGridViewPerfil;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbtnCadastrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbtnConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbtnExcluir;
    }
}