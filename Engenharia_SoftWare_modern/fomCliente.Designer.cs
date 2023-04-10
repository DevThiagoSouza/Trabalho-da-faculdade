
namespace Engenharia_SoftWare_modern
{
    partial class fomCliente
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
            this.telefone = new System.Windows.Forms.TextBox();
            this.uf = new System.Windows.Forms.ComboBox();
            this.cidade = new System.Windows.Forms.TextBox();
            this.cep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.complemento = new System.Windows.Forms.TextBox();
            this.rua = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cpf = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.sobrenome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(106, 189);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(170, 20);
            this.telefone.TabIndex = 25;
            this.telefone.Text = "Telefone";
            // 
            // uf
            // 
            this.uf.FormattingEnabled = true;
            this.uf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO",
            "DF"});
            this.uf.Location = new System.Drawing.Point(382, 292);
            this.uf.Name = "uf";
            this.uf.Size = new System.Drawing.Size(54, 21);
            this.uf.TabIndex = 24;
            // 
            // cidade
            // 
            this.cidade.Location = new System.Drawing.Point(244, 293);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(132, 20);
            this.cidade.TabIndex = 23;
            this.cidade.Text = "Cidade";
            // 
            // cep
            // 
            this.cep.Location = new System.Drawing.Point(106, 293);
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(132, 20);
            this.cep.TabIndex = 22;
            this.cep.Text = "CEP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Endereço";
            // 
            // complemento
            // 
            this.complemento.Location = new System.Drawing.Point(174, 267);
            this.complemento.Name = "complemento";
            this.complemento.Size = new System.Drawing.Size(179, 20);
            this.complemento.TabIndex = 20;
            this.complemento.Text = "Complemento";
            // 
            // rua
            // 
            this.rua.Location = new System.Drawing.Point(106, 241);
            this.rua.Name = "rua";
            this.rua.Size = new System.Drawing.Size(330, 20);
            this.rua.TabIndex = 19;
            this.rua.Text = "Rua";
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(106, 267);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(62, 20);
            this.numero.TabIndex = 18;
            this.numero.Text = "Numero";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(361, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(442, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cpf
            // 
            this.cpf.Location = new System.Drawing.Point(106, 163);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(330, 20);
            this.cpf.TabIndex = 15;
            this.cpf.Text = "CPF";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(106, 111);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(330, 20);
            this.nome.TabIndex = 14;
            this.nome.Text = "Nome";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(169, 58);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(199, 27);
            this.lblFornecedor.TabIndex = 13;
            this.lblFornecedor.Text = "  Cadastro Cliente\r\n";
            // 
            // sobrenome
            // 
            this.sobrenome.Location = new System.Drawing.Point(106, 137);
            this.sobrenome.Name = "sobrenome";
            this.sobrenome.Size = new System.Drawing.Size(330, 20);
            this.sobrenome.TabIndex = 26;
            this.sobrenome.Text = "Sobrenome";
            // 
            // fomCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.sobrenome);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.uf);
            this.Controls.Add(this.cidade);
            this.Controls.Add(this.cep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.complemento);
            this.Controls.Add(this.rua);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.lblFornecedor);
            this.Name = "fomCliente";
            this.Size = new System.Drawing.Size(538, 444);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.ComboBox uf;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.TextBox cep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox complemento;
        private System.Windows.Forms.TextBox rua;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cpf;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox sobrenome;
    }
}
