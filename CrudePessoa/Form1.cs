using Data.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CrudePessoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AtualizaGrid();
        }
        private void AtualizaGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = ConexaoDb();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();
                MySqlCommand comando = realizaConexacoBD.CreateCommand();
                comando.CommandText = "SELECT * FROM `pessoas`";
                MySqlDataReader reader = comando.ExecuteReader();

                dgPessoas.Rows.Clear();
                Pessoa pessoa = new Pessoa();

                while (reader.Read())
                {
                    pessoa.Id = reader.GetInt32(0);
                    pessoa.Nome = reader.GetString(1);
                    pessoa.Cpf = reader.GetString(2);
                    pessoa.Cidade = reader.GetString(3);
                    pessoa.Bairro = reader.GetString(4);
                    pessoa.Rua = reader.GetString(5);

                    DataGridViewRow row = (DataGridViewRow)dgPessoas.Rows[0].Clone();
                    row.Cells[0].Value = pessoa.Id;
                    row.Cells[1].Value = pessoa.Nome;
                    row.Cells[2].Value = pessoa.Cpf;
                    row.Cells[3].Value = pessoa.Cidade;
                    row.Cells[4].Value = pessoa.Bairro;
                    row.Cells[5].Value = pessoa.Rua;
                    row.Cells[6].Value = "Editar";
                    row.Cells[7].Value = "Deletar";
                    dgPessoas.Rows.Add(row);
                }
                realizaConexacoBD.Close();

            }
            catch (Exception)
            {
               MessageBox.Show("Não conseguimos nos conectar com o banco de dados, tente novamente mais tarde.");
            }
        }
        private MySqlConnectionStringBuilder ConexaoDb() // Criando o metódo para a cadeia de string do Db
        {
            MySqlConnectionStringBuilder conexaoDb = new MySqlConnectionStringBuilder();
            conexaoDb.Server = "localhost";
            conexaoDb.Database = "banco_de_dados";
            conexaoDb.UserID = "root";
            conexaoDb.Password = "";
            conexaoDb.SslMode = 0;

            return conexaoDb;
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }       
        private void Limpar()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";
            txtRua.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Id = 0;
            pessoa.Nome = txtNome.Text;
            pessoa.Cpf = txtCpf.Text;
            pessoa.Cidade = txtCidade.Text;
            pessoa.Bairro = txtBairro.Text;
            pessoa.Rua = txtRua.Text;


            MySqlConnectionStringBuilder conexaoDb = ConexaoDb(); 
            MySqlConnection realizaConexaoDb = new MySqlConnection(conexaoDb.ToString()); // Realizando a conexão através da cadeia de strings do Db
            try
            {
                realizaConexaoDb.Open(); // Abrindo a conexão

                MySqlCommand comando = realizaConexaoDb.CreateCommand(); // Criando a variável para realizar comandos
                comando.CommandText = "INSERT INTO pessoas (id, nome, cpf, cidade, bairro, rua) " + "VALUES('" + pessoa.Id + "','" + pessoa.Nome + "','" + pessoa.Cpf + "','" + pessoa.Cidade + "','" + pessoa.Bairro + "','" + pessoa.Rua + "')"; 
                comando.ExecuteNonQuery(); //Funlão do Sql para executar o comando

                realizaConexaoDb.Close(); // Fechando o Db
                MessageBox.Show("Inserido com Sucesso"); 
                Limpar(); //Limpar os campos após salvar 
                AtualizaGrid();
            }
            catch (Exception) // Caso dê erro na conexão, gera a mensagem.
            {
                MessageBox.Show("Não conseguimos nos conectar com o banco de dados, tente novamente mais tarde.");
            }
        }

        private void dgPessoas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}