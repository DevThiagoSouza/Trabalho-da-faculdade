
namespace Engenharia_SoftWare_modern
{
    partial class teste
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
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.tbcnpj = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numero = new System.Windows.Forms.TextBox();
            this.rua = new System.Windows.Forms.TextBox();
            this.complemento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cep = new System.Windows.Forms.TextBox();
            this.cidade = new System.Windows.Forms.TextBox();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.telefone = new System.Windows.Forms.TextBox();
            this.tableUpdateStatementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nome_fantasia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableUpdateStatementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(122, 53);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(233, 27);
            this.lblFornecedor.TabIndex = 0;
            this.lblFornecedor.Text = "Cadastro Fornecedor\r\n";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(85, 96);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(330, 20);
            this.nome.TabIndex = 1;
            this.nome.Text = "Nome";
            this.nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbcnpj
            // 
            this.tbcnpj.Location = new System.Drawing.Point(85, 148);
            this.tbcnpj.Name = "tbcnpj";
            this.tbcnpj.Size = new System.Drawing.Size(330, 20);
            this.tbcnpj.TabIndex = 2;
            this.tbcnpj.Text = "CNPJ";
            this.tbcnpj.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(421, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(340, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(85, 252);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(62, 20);
            this.numero.TabIndex = 5;
            this.numero.Text = "Numero";
            // 
            // rua
            // 
            this.rua.Location = new System.Drawing.Point(85, 226);
            this.rua.Name = "rua";
            this.rua.Size = new System.Drawing.Size(330, 20);
            this.rua.TabIndex = 6;
            this.rua.Text = "Rua";
            // 
            // complemento
            // 
            this.complemento.Location = new System.Drawing.Point(153, 252);
            this.complemento.Name = "complemento";
            this.complemento.Size = new System.Drawing.Size(179, 20);
            this.complemento.TabIndex = 7;
            this.complemento.Text = "Complemento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Endereço";
            // 
            // cep
            // 
            this.cep.Location = new System.Drawing.Point(85, 278);
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(132, 20);
            this.cep.TabIndex = 9;
            this.cep.Text = "CEP";
            // 
            // cidade
            // 
            this.cidade.Location = new System.Drawing.Point(223, 278);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(132, 20);
            this.cidade.TabIndex = 10;
            this.cidade.Text = "Cidade";
            // 
            // cbUF
            // 
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Items.AddRange(new object[] {
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
            this.cbUF.Location = new System.Drawing.Point(361, 277);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(54, 21);
            this.cbUF.TabIndex = 11;
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(85, 174);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(170, 20);
            this.telefone.TabIndex = 12;
            this.telefone.Text = "Telefone";
            // 
            // tableUpdateStatementBindingSource
            // 
            this.tableUpdateStatementBindingSource.DataSource = typeof(MySqlX.XDevAPI.Relational.TableUpdateStatement);
            // 
            // nome_fantasia
            // 
            this.nome_fantasia.Location = new System.Drawing.Point(85, 122);
            this.nome_fantasia.Name = "nome_fantasia";
            this.nome_fantasia.Size = new System.Drawing.Size(330, 20);
            this.nome_fantasia.TabIndex = 13;
            this.nome_fantasia.Text = "Nome Fantasia";
            // 
            // teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.nome_fantasia);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.cbUF);
            this.Controls.Add(this.cidade);
            this.Controls.Add(this.cep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.complemento);
            this.Controls.Add(this.rua);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbcnpj);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.lblFornecedor);
            this.Name = "teste";
            this.Size = new System.Drawing.Size(550, 414);
            this.Load += new System.EventHandler(this.teste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableUpdateStatementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox tbcnpj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.TextBox rua;
        private System.Windows.Forms.TextBox complemento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cep;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.BindingSource tableUpdateStatementBindingSource;
        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.TextBox nome_fantasia;
    }
}
