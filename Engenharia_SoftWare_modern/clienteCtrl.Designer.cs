﻿
namespace Engenharia_SoftWare_modern
{
    partial class clienteCtrl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DtGridFornecedor = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobre_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1 = new Engenharia_SoftWare_modern.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.boxpesquisa = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAtivo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DtGridFornecedor
            // 
            this.DtGridFornecedor.AllowUserToOrderColumns = true;
            this.DtGridFornecedor.AutoGenerateColumns = false;
            this.DtGridFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGridFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.sobre_nome,
            this.cpf,
            this.telefone,
            this.rua,
            this.complemento,
            this.numero});
            this.DtGridFornecedor.DataSource = this.dataSet1;
            this.DtGridFornecedor.Location = new System.Drawing.Point(3, 60);
            this.DtGridFornecedor.Name = "DtGridFornecedor";
            this.DtGridFornecedor.Size = new System.Drawing.Size(593, 290);
            this.DtGridFornecedor.TabIndex = 1;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "nome";
            this.nome.Name = "nome";
            // 
            // sobre_nome
            // 
            this.sobre_nome.DataPropertyName = "sobre_nome";
            this.sobre_nome.HeaderText = "sobre nome";
            this.sobre_nome.Name = "sobre_nome";
            // 
            // cpf
            // 
            this.cpf.DataPropertyName = "cpf";
            this.cpf.HeaderText = "cpf";
            this.cpf.Name = "cpf";
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            // 
            // rua
            // 
            this.rua.DataPropertyName = "rua";
            this.rua.HeaderText = "rua";
            this.rua.Name = "rua";
            this.rua.ReadOnly = true;
            // 
            // complemento
            // 
            this.complemento.DataPropertyName = "complemneto";
            this.complemento.HeaderText = "complemento";
            this.complemento.Name = "complemento";
            this.complemento.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "numero";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.boxpesquisa);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnAtivo);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 54);
            this.panel1.TabIndex = 5;
            // 
            // boxpesquisa
            // 
            this.boxpesquisa.Location = new System.Drawing.Point(396, 19);
            this.boxpesquisa.MaxLength = 30;
            this.boxpesquisa.Name = "boxpesquisa";
            this.boxpesquisa.Size = new System.Drawing.Size(158, 20);
            this.boxpesquisa.TabIndex = 5;
            this.boxpesquisa.Text = "insira nome ou cnpj";
            this.boxpesquisa.TextChanged += new System.EventHandler(this.boxpesquisa_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Engenharia_SoftWare_modern.Properties.Resources.icons8_pesquisar_mais_24;
            this.pictureBox1.Location = new System.Drawing.Point(560, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 23);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnAtivo
            // 
            this.btnAtivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnAtivo.FlatAppearance.BorderSize = 0;
            this.btnAtivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtivo.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtivo.ForeColor = System.Drawing.Color.White;
            this.btnAtivo.Location = new System.Drawing.Point(3, 19);
            this.btnAtivo.Name = "btnAtivo";
            this.btnAtivo.Size = new System.Drawing.Size(75, 23);
            this.btnAtivo.TabIndex = 3;
            this.btnAtivo.Text = "Ativo";
            this.btnAtivo.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(84, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // clienteCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DtGridFornecedor);
            this.Name = "clienteCtrl";
            this.Size = new System.Drawing.Size(599, 380);
            this.Load += new System.EventHandler(this.clienteCtrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtGridFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtGridFornecedor;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobre_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox boxpesquisa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAtivo;
        private System.Windows.Forms.Button button1;
    }
}
