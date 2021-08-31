
namespace CrudePessoa
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbRua = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbCadastro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Deletar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(89, 56);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(67, 24);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(162, 56);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(214, 25);
            this.txtNome.TabIndex = 2;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(162, 89);
            this.txtCpf.Multiline = true;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(214, 25);
            this.txtCpf.TabIndex = 4;
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpf.Location = new System.Drawing.Point(104, 89);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(52, 24);
            this.lbCpf.TabIndex = 3;
            this.lbCpf.Text = "CPF:";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCidade.Location = new System.Drawing.Point(441, 51);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(75, 24);
            this.lbCidade.TabIndex = 5;
            this.lbCidade.Text = "Cidade:";
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRua.Location = new System.Drawing.Point(467, 117);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(49, 24);
            this.lbRua.TabIndex = 9;
            this.lbRua.Text = "Rua:";
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBairro.Location = new System.Drawing.Point(452, 84);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(64, 24);
            this.lbBairro.TabIndex = 7;
            this.lbBairro.Text = "Bairro:";
            // 
            // lbCadastro
            // 
            this.lbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastro.Location = new System.Drawing.Point(311, 9);
            this.lbCadastro.Name = "lbCadastro";
            this.lbCadastro.Size = new System.Drawing.Size(201, 23);
            this.lbCadastro.TabIndex = 11;
            this.lbCadastro.Text = "Cadastro de Pessoas";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(518, 84);
            this.txtBairro.Multiline = true;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(214, 25);
            this.txtBairro.TabIndex = 13;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(518, 51);
            this.txtCidade.Multiline = true;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(214, 25);
            this.txtCidade.TabIndex = 12;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(518, 117);
            this.txtRua.Multiline = true;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(214, 25);
            this.txtRua.TabIndex = 14;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(416, 150);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(372, 40);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(18, 150);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(392, 40);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nome,
            this.CPF,
            this.Cidade,
            this.Bairro,
            this.Rua,
            this.Editar,
            this.Deletar});
            this.dataGridView1.Location = new System.Drawing.Point(12, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(778, 225);
            this.dataGridView1.TabIndex = 18;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 40;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            // 
            // Bairro
            // 
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            // 
            // Rua
            // 
            this.Rua.HeaderText = "Rua";
            this.Rua.Name = "Rua";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            // 
            // Deletar
            // 
            this.Deletar.HeaderText = "Deletar";
            this.Deletar.Name = "Deletar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lbCadastro);
            this.Controls.Add(this.lbRua);
            this.Controls.Add(this.lbBairro);
            this.Controls.Add(this.lbCidade);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbNome);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbCadastro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rua;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Deletar;
    }
}

