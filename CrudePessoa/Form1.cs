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
            txtId.Text = "";
            txtNome.Text = "";
            txtCpf.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";
            txtRua.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Pessoa pessoa = new Pessoa();
            if (txtId.Text.Equals(""))
            {
                pessoa.Id = 0;
            } 
            else
            {
                pessoa.Id = Convert.ToInt32(txtId.Text);
            }
            pessoa.Nome = txtNome.Text;
            pessoa.Cpf = txtCpf.Text;
            pessoa.Cidade = txtCidade.Text;
            pessoa.Bairro = txtBairro.Text;
            pessoa.Rua = txtRua.Text;

            if(pessoa.Id == 0)
            {
                MySqlConnectionStringBuilder conexaoDb = ConexaoDb();
                MySqlConnection realizaConexaoDb = new MySqlConnection(conexaoDb.ToString()); // Realizando a conexão através da cadeia de strings do Db
                try
                {
                    realizaConexaoDb.Open(); // Abrindo a conexão

                    MySqlCommand comando = realizaConexaoDb.CreateCommand(); // Criando a variável para realizar comandos
                    comando.CommandText = "INSERT INTO pessoas (id, nome, cpf, cidade, bairro, rua) " + "VALUES('" + pessoa.Id + "','" + pessoa.Nome + "','" + pessoa.Cpf + "','" + pessoa.Cidade + "','" + pessoa.Bairro + "','" + pessoa.Rua + "')";
                    comando.ExecuteNonQuery(); //Função do Sql para executar o comando

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
            else
            {
                MySqlConnectionStringBuilder conexaoDb = ConexaoDb();
                MySqlConnection realizaConexaoDb = new MySqlConnection(conexaoDb.ToString()); // Realizando a conexão através da cadeia de strings do Db
                try
                {
                    realizaConexaoDb.Open(); // Abrindo a conexão

                    MySqlCommand comando = realizaConexaoDb.CreateCommand(); // Criando a variável para realizar comandos
                    comando.CommandText = "UPDATE pessoas SET id= '" + pessoa.Id + "', nome= '" + pessoa.Nome + "', cpf= '" + pessoa.Cpf + "', cidade= '" + pessoa.Cidade + "', bairro= '" + pessoa.Bairro + "', rua= '" + pessoa.Rua + "' WHERE id = '" + pessoa.Id + "'";
                    comando.ExecuteNonQuery(); //Função do Sql para executar o comando

                    realizaConexaoDb.Close(); // Fechando o Db
                    MessageBox.Show("Editado com Sucesso");
                    Limpar(); //Limpar os campos após salvar 
                    AtualizaGrid();
                }
                catch (Exception) // Caso dê erro na conexão, gera a mensagem.
                {
                    MessageBox.Show("Não conseguimos nos conectar com o banco de dados, tente novamente mais tarde.");
                }
            }
        }

        private void dgPessoas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = ConexaoDb();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());


            realizaConexacoBD.Open();
            MySqlCommand comando = realizaConexacoBD.CreateCommand();
            comando.CommandText = "SELECT * FROM `pessoas`";
            MySqlDataReader reader = comando.ExecuteReader();

            dgPessoas.Rows.Clear();

            List<Pessoa> lista = new List<Pessoa>();

            while (reader.Read())
            {
                Pessoa pessoa = new Pessoa();

                pessoa.Id = reader.GetInt32(0);
                pessoa.Nome = reader.GetString(1);
                pessoa.Cpf = reader.GetString(2);
                pessoa.Cidade = reader.GetString(3);
                pessoa.Bairro = reader.GetString(4);
                pessoa.Rua = reader.GetString(5);

                lista.Add(pessoa);

            }
            realizaConexacoBD.Close();
            
            if (e.ColumnIndex == 6)
            {

                Pessoa model = lista[e.RowIndex];
                txtId.Text = Convert.ToString(model.Id);
                txtNome.Text = model.Nome;
                txtCpf.Text = model.Cpf;
                txtCidade.Text = model.Cidade;
                txtBairro.Text = model.Bairro;
                txtRua.Text = model.Rua;

                AtualizaGrid();
            }
            if(e.ColumnIndex == 7)
            {
                MySqlConnectionStringBuilder conexaoDbDelete = ConexaoDb();
                MySqlConnection realizaConexacoDbDelete = new MySqlConnection(conexaoDbDelete.ToString());

                Pessoa model = lista[e.RowIndex];

                realizaConexacoDbDelete.Open();
                MySqlCommand comandoDelete = realizaConexacoDbDelete.CreateCommand();
                comandoDelete.CommandText = "DELETE FROM pessoas WHERE id = '" + model.Id + "'";
                comandoDelete.ExecuteNonQuery();
                realizaConexacoDbDelete.Close();

                AtualizaGrid();
            }
        } 
    }
}