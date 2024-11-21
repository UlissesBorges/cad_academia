using MySqlConnector;
using System;
using System.Configuration;
using System.Data.SqlClient; // Alterado para SQL Server
using System.Windows.Forms;
using System.Data;


namespace ProjetoDePratica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bCadastrarM_Click(object sender, EventArgs e)
        {
            // Obtendo a string de conexão configurada no app.config
            string conn = ConfigurationManager.ConnectionStrings["SqlServerConnectionString"].ToString(); // Ajuste o nome da string de conexão para o correto
            SqlConnection conexao = new SqlConnection(conn);

            try
            {
                conexao.Open(); // Abrindo a conexão
                MessageBox.Show("Conexão foi criada");

                // Criando o comando SQL para inserir os dados
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao; // Associando a conexão ao comando SQL
                comando.CommandText = "INSERT INTO morador (CPF, Nome, Endereco, Bloco, Email, Telefone, Ativo, Pago) " +
                       "VALUES (@cpf, @nome, @endereco, @bloco, @email, @telefone, @ativo, @pago);";

                // Adicionando parâmetros ao comando SQL
                comando.Parameters.AddWithValue("@cpf", tbCPF.Text.Trim());
                comando.Parameters.AddWithValue("@nome", tbNome.Text.Trim());
                comando.Parameters.AddWithValue("@endereco", tbEndereco.Text.Trim());
                comando.Parameters.AddWithValue("@bloco", tbBloco.Text.Trim());
                comando.Parameters.AddWithValue("@email", tbEmail.Text.Trim());
                comando.Parameters.AddWithValue("@telefone", tbTelefone.Text.Trim());
                comando.Parameters.AddWithValue("@ativo", int.TryParse(tbAtivo.Text.Trim(), out int ativo) ? ativo : 0);
                comando.Parameters.AddWithValue("@pago", int.TryParse(tbPago.Text.Trim(), out int pago) ? pago : 0);

                // Executando o comando SQL
                int valorRetorno = comando.ExecuteNonQuery();

                // Verificando se a inserção foi bem-sucedida
                if (valorRetorno < 1)
                    MessageBox.Show("Erro ao inserir");
                else
                    MessageBox.Show("Cadastro realizado");
            }
            catch (SqlException sqle) // Alterado para SqlException
            {
                MessageBox.Show("Erro de acesso ao banco de dados: " + sqle.Message, "Erro");
            }
            finally
            {
                conexao.Close(); // Fechando a conexão
            }
        }

        private void bConsultarM_Click(object sender, EventArgs e)
        {
            // Obtendo a string de conexão configurada no app.config
            string conn = ConfigurationManager.ConnectionStrings["SqlServerConnectionString"].ToString();
            SqlConnection conexao = new SqlConnection(conn);

            try
            {
                // Verificando se o CPF foi informado
                if (string.IsNullOrEmpty(tbCPF.Text.Trim()))
                {
                    throw new System.Exception("Você esqueceu de digitar o CPF.");
                }

                conexao.Open(); // Abrindo a conexão
                MessageBox.Show("Conexão foi criada");

                // Criando o comando SQL para consultar os dados
                string comando = "SELECT CPF, Nome, Endereco, Bloco, Email, Telefone FROM morador WHERE CPF = @cpf";
                SqlCommand sqlCommand = new SqlCommand(comando, conexao);

                // Adicionando o parâmetro ao comando SQL
                sqlCommand.Parameters.AddWithValue("@cpf", tbCPF.Text.Trim());

                // Executando o comando SQL
                SqlDataReader reader = sqlCommand.ExecuteReader();

                // Verificando se o CPF foi encontrado
                if (!reader.HasRows)
                {
                    throw new System.Exception("CPF não encontrado.");
                }

                // Lendo os dados retornados e preenchendo os campos
                if (reader.Read())
                {
                    tbCPF.Text = reader["CPF"].ToString();
                    tbNome.Text = reader["Nome"].ToString();
                    tbEndereco.Text = reader["Endereco"].ToString();
                    tbBloco.Text = reader["Bloco"].ToString();
                    tbEmail.Text = reader["Email"].ToString();
                    tbTelefone.Text = reader["Telefone"].ToString();
                }
            }
            catch (SqlException sqle) // Tratando erros específicos de SQL Server
            {
                MessageBox.Show("Erro de acesso ao banco de dados: " + sqle.Message, "Erro");
            }
            catch (System.Exception ex) // Tratando outros erros gerais
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conexao.Close(); // Fechando a conexão
            }
        }


        private void bExcluirM_Click(object sender, System.EventArgs e)
        {
            // Obtendo a string de conexão do arquivo de configuração
            string conn = ConfigurationManager.ConnectionStrings["SqlServerConnectionString"].ToString();
            SqlConnection conexao = new SqlConnection(conn);

            try
            {
                // Verificando se o CPF foi informado
                if (string.IsNullOrEmpty(tbCPF.Text.Trim()))
                {
                    throw new Exception("Você esqueceu de digitar o CPF.");
                }

                // Confirmando a exclusão
                var confirmResult = MessageBox.Show(
                    "Tem certeza que deseja excluir o cadastro?",
                    "Confirmação de exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.No)
                {
                    return; // Cancela a operação se o usuário não confirmar
                }

                // Abrindo a conexão
                conexao.Open();
                MessageBox.Show("Conexão foi criada com sucesso.");

                // Criando o comando para exclusão
                string comandoSQL = "DELETE FROM morador WHERE CPF = @cpf;";
                SqlCommand comando = new SqlCommand(comandoSQL, conexao);
                comando.Parameters.AddWithValue("@cpf", tbCPF.Text.Trim());

                // Executando o comando
                int rowsAffected = comando.ExecuteNonQuery();

                // Verificando se o registro foi excluído
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cadastro deletado com sucesso!");
                    LimparCampos(); // Função para limpar os campos após exclusão
                }
                else
                {
                    MessageBox.Show("CPF não encontrado no banco de dados.");
                }
            }
            catch (SqlException sqle)
            {
                // Tratando erros relacionados ao SQL Server
                MessageBox.Show($"Erro de acesso ao SQL Server: {sqle.Message}", "Erro");
            }
            catch (Exception ex)
            {
                // Tratando outros erros
                MessageBox.Show($"Erro: {ex.Message}");
            }
            finally
            {
                // Fechando a conexão
                if (conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                }
            }

        }

        private void LimparCampos()
        {
            tbCPF.Clear();
            tbNome.Clear();
            tbEndereco.Clear();
            tbBloco.Clear();
            tbEmail.Clear();
            tbTelefone.Clear();
        }


        private void bAlterarM_Click(object sender, System.EventArgs e)
        {
            // Obtendo a string de conexão configurada no app.config
            string conn = ConfigurationManager.ConnectionStrings["SqlServerConnectionString"].ToString();
            SqlConnection conexao = new SqlConnection(conn);

            try
            {
                // Abrindo a conexão com o banco de dados
                conexao.Open();
                MessageBox.Show("Conexão foi criada com sucesso.");

                // Criando o comando SQL para atualizar o registro
                string comandoSQL = @"
            UPDATE morador 
            SET Nome = @nome, 
                Endereco = @endereco, 
                Bloco = @bloco, 
                Email = @email, 
                Telefone = @telefone
            WHERE CPF = @cpf;";
                SqlCommand comando = new SqlCommand(comandoSQL, conexao);

                // Adicionando parâmetros ao comando
                comando.Parameters.AddWithValue("@cpf", tbCPF.Text.Trim());
                comando.Parameters.AddWithValue("@nome", tbNome.Text.Trim());
                comando.Parameters.AddWithValue("@endereco", tbEndereco.Text.Trim());
                comando.Parameters.AddWithValue("@bloco", tbBloco.Text.Trim());
                comando.Parameters.AddWithValue("@email", tbEmail.Text.Trim());
                comando.Parameters.AddWithValue("@telefone", tbTelefone.Text.Trim());

                // Executando o comando e verificando o retorno
                int valorRetorno = comando.ExecuteNonQuery();
                if (valorRetorno < 1)
                    MessageBox.Show("Erro ao atualizar o registro. Verifique se o CPF está correto.");
                else
                    MessageBox.Show("Registro atualizado com sucesso!");
            }
            catch (SqlException sqle)
            {
                // Tratando erros relacionados ao SQL Server
                MessageBox.Show("Erro de acesso ao SQL Server: " + sqle.Message, "Erro");
            }
            catch (Exception ex)
            {
                // Tratando outros tipos de erro
                MessageBox.Show("Erro: " + ex.Message, "Erro");
            }
            finally
            {
                // Fechando a conexão com o banco de dados
                if (conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }


        private void bCadastrarE_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["SqlServerConnectionString"].ToString(); // Altere para o nome correto da connection string
            using (MySqlConnection conexao = new MySqlConnection(connString))
            {
                try
                {
                    // Validação de campos obrigatórios
                    if (string.IsNullOrWhiteSpace(tbCPF.Text) || string.IsNullOrWhiteSpace(tbNome.Text))
                    {
                        MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Abrir a conexão
                    conexao.Open();

                    // Criar o comando SQL
                    string comandoSQL = "INSERT INTO morador (CPF, Nome, Endereco, Bloco, Email, Telefone) " +
                                        "VALUES (@cpf, @nome, @endereco, @bloco, @email, @telefone)";
                    using (MySqlCommand comando = new MySqlCommand(comandoSQL, conexao))
                    {
                        // Adicionar parâmetros de forma segura
                        comando.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = tbCPF.Text.Trim();
                        comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = tbNome.Text.Trim();
                        comando.Parameters.Add("@endereco", MySqlDbType.VarChar).Value = tbEndereco.Text.Trim();
                        comando.Parameters.Add("@bloco", MySqlDbType.VarChar).Value = tbBloco.Text.Trim();
                        comando.Parameters.Add("@email", MySqlDbType.VarChar).Value = tbEmail.Text.Trim();
                        comando.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = tbTelefone.Text.Trim();

                        // Executar o comando
                        int valorRetorno = comando.ExecuteNonQuery();
                        if (valorRetorno < 1)
                            MessageBox.Show("Erro ao inserir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (MySqlException msqle)
                {
                    // Erro de banco de dados
                    MessageBox.Show("Erro de acesso ao banco de dados: " + msqle.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    // Outros erros
                    MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void bConsultarE_Click(object sender, System.EventArgs e)
        {
            // Obtendo a string de conexão configurada no app.config
            string conn = ConfigurationManager.ConnectionStrings["SqlServerConnectionString"].ToString();
            SqlConnection con = new SqlConnection(conn);

            try
            {
                con.Open(); // Abrindo a conexão
                MessageBox.Show("Conexão foi criada com sucesso.");

                // Comando SQL com parâmetro
                string comando = "SELECT * FROM evento WHERE dataEvento = @data";
                SqlCommand com = new SqlCommand(comando, con);

                // Formatando a data para o parâmetro
                DateTime dataSelecionada = monthCalendar1.SelectionStart;
                com.Parameters.AddWithValue("@data", dataSelecionada);

                // Executando o comando e lendo os resultados
                SqlDataReader cs = com.ExecuteReader();

                if (!cs.HasRows)
                {
                    throw new Exception("Não há evento na data selecionada.");
                }
                else
                {
                    cs.Read();
                    tbEnderecoE.Text = cs["enderecoEvento"].ToString();
                    tbBlocoE.Text = cs["blocoEvento"].ToString();
                    numericUpDown1.Value = Convert.ToDecimal(cs["pessoasEvento"]);
                    comboBox1.Text = cs["tipoEvento"].ToString();
                    MessageBox.Show("Consulta realizada com sucesso.");
                }
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Erro de acesso ao banco de dados: " + sqle.Message, "Erro");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
            finally
            {
                // Fechando a conexão
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void bExcluirE_Click(object sender, System.EventArgs e)
        {
            // Obtendo a string de conexão configurada no app.config
            string conn = ConfigurationManager.ConnectionStrings["SqlServerConnectionString"].ToString();
            SqlConnection conexao = new SqlConnection(conn);

            try
            {
                // Abrindo a conexão com o banco de dados
                conexao.Open();
                MessageBox.Show("Conexão foi criada com sucesso.");

                // Criando o comando SQL para exclusão
                string comandoSQL = "DELETE FROM evento WHERE DataEvento = @data;";
                SqlCommand comando = new SqlCommand(comandoSQL, conexao);

                // Convertendo a data selecionada no MonthCalendar para o formato adequado
                string dataFormatada = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
                comando.Parameters.AddWithValue("@data", dataFormatada);

                // Executando o comando
                int rowsAffected = comando.ExecuteNonQuery();

                // Verificando se o registro foi excluído
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Evento excluído com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhum evento encontrado para a data selecionada.");
                }
            }
            catch (SqlException sqle)
            {
                // Tratando erros relacionados ao SQL Server
                MessageBox.Show("Erro de acesso ao SQL Server: " + sqle.Message, "Erro");
            }
            catch (Exception ex)
            {
                // Tratando outros erros
                MessageBox.Show("Erro: " + ex.Message, "Erro");
            }
            finally
            {
                // Fechando a conexão com o banco de dados
                if (conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }


        private void bAlterarE_Click(object sender, System.EventArgs e)
        {
            // Obtendo a string de conexão configurada no app.config
            string conn = ConfigurationManager.ConnectionStrings["SqlServerConnectionString"].ToString();
            SqlConnection conexao = new SqlConnection(conn);

            try
            {
                // Abrindo a conexão com o banco de dados
                conexao.Open();
                MessageBox.Show("Conexão foi criada com sucesso.");

                // Criando o comando SQL para atualização
                string comandoSQL = @"
            UPDATE evento 
            SET DataEvento = @novaData, 
                EnderecoEvento = @endereco, 
                BlocoEvento = @bloco, 
                TipoEvento = @tipo, 
                PessoasEvento = @pessoas 
            WHERE DataEvento = @dataOriginal;";
                SqlCommand comando = new SqlCommand(comandoSQL, conexao);

                // Adicionando parâmetros ao comando SQL
                comando.Parameters.AddWithValue("@endereco", tbEnderecoE.Text.Trim());
                comando.Parameters.AddWithValue("@bloco", tbBlocoE.Text.Trim());
                comando.Parameters.AddWithValue("@tipo", comboBox1.Text.Trim());
                comando.Parameters.AddWithValue("@pessoas", numericUpDown1.Value); // Usando o valor numérico do controle

                // Convertendo as datas selecionadas no MonthCalendar
                string novaData = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
                string dataOriginal = monthCalendar1.SelectionEnd.ToString("yyyy-MM-dd");
                comando.Parameters.AddWithValue("@novaData", novaData);
                comando.Parameters.AddWithValue("@dataOriginal", dataOriginal);

                // Executando o comando e verificando o retorno
                int valorRetorno = comando.ExecuteNonQuery();
                if (valorRetorno < 1)
                    MessageBox.Show("Erro ao atualizar o evento. Verifique se a data original está correta.");
                else
                    MessageBox.Show("Evento atualizado com sucesso!");
            }
            catch (SqlException sqle)
            {
                // Tratando erros relacionados ao SQL Server
                MessageBox.Show("Erro de acesso ao SQL Server: " + sqle.Message, "Erro");
            }
            catch (Exception ex)
            {
                // Tratando outros erros
                MessageBox.Show("Erro: " + ex.Message, "Erro");
            }
            finally
            {
                // Fechando a conexão com o banco de dados
                if (conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }

        private MySqlDataAdapter da, da2;
        BindingSource bsource = new BindingSource();
        BindingSource bsource2 = new BindingSource();

        DataSet ds, ds2 = null;

        private void bCarregarE_Click(object sender, System.EventArgs e)
        {
            CarregarDadosEvento();
        }//fim botão carregar evento

        string sql, sql2;


        private void bCarregarM_Click(object sender, System.EventArgs e)
        {
            CarregarDadosMorador();
        }//fim botão carregar morador

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbBlocoE_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void CarregarDadosEvento()
        {
            string conn = "Server=WKS-CTGI-DEV08;Database=Proj_Acad;User Id=sa;Password=cidadao;Connect Timeout=30;";
            SqlConnection conexao = new SqlConnection(conn);
            string sql = "SELECT * FROM evento";

            try
            {
                // Criando o DataAdapter para o SQL Server
                SqlDataAdapter da = new SqlDataAdapter(sql, conexao);
                DataSet ds = new DataSet();

                // Criando o CommandBuilder (permite atualização automática de comandos)
                new SqlCommandBuilder(da);

                // Preenchendo o DataSet
                da.Fill(ds, "evento");

                // Vinculando os dados ao DataGridView
                BindingSource bsource = new BindingSource
                {
                    DataSource = ds.Tables["evento"]
                };
                dataGridView1.DataSource = bsource;
            }
            catch (SqlException sqle)
            {
                // Tratamento de erros de SQL Server
                MessageBox.Show($"Erro ao carregar dados do evento: {sqle.Message}", "Erro");
            }
            finally
            {
                // Fechar a conexão (não é estritamente necessário aqui, pois o DataAdapter gerencia)
                if (conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }


        private void CarregarDadosMorador()
        {
            string conn = "Server=WKS-CTGI-DEV08;Database=Proj_Acad;User Id=sa;Password=cidadao;Connect Timeout=30;";
            SqlConnection conexao = new SqlConnection(conn);
            string sql2 = "SELECT * FROM morador";

            try
            {
                // Criando o DataAdapter para o SQL Server
                SqlDataAdapter da = new SqlDataAdapter(sql2, conexao);
                DataSet ds2 = new DataSet();

                // Criando o CommandBuilder (permite atualização automática de comandos)
                new SqlCommandBuilder(da);

                // Preenchendo o DataSet
                da.Fill(ds2, "morador");

                // Vinculando os dados ao DataGridView
                BindingSource bsource2 = new BindingSource
                {
                    DataSource = ds2.Tables["morador"]
                };
                dataGridView1.DataSource = bsource2;
            }
            catch (SqlException sqle)
            {
                // Tratamento de erros de SQL Server
                MessageBox.Show($"Erro ao carregar dados do morador: {sqle.Message}", "Erro");
            }
            finally
            {
                // Fechar a conexão (não é estritamente necessário aqui, pois o DataAdapter gerencia)
                if (conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }

        // Evento de clique do botão Liberar Catraca
        private void bCatraca_Click(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["SqlServerConnectionString"].ToString();
            SqlConnection conexao = new SqlConnection(conn);

            try
            {
                // Abrir a conexão com o banco de dados
                conexao.Open();
                MessageBox.Show("Conexão foi criada com sucesso.");

                // Exemplo: Atualizando o status do morador ou evento para 'liberado' no banco
                // Este é um exemplo, o comando SQL pode ser alterado conforme sua necessidade

                string comandoSQL = "UPDATE morador SET Catraca = 1 WHERE CPF = @cpf;";
                SqlCommand comando = new SqlCommand(comandoSQL, conexao);

                // Substitua tbCPF.Text por um valor que represente o CPF ou identificação do morador
                comando.Parameters.AddWithValue("@cpf", tbCPF.Text.Trim());

                // Executando o comando SQL para liberar a catraca
                int rowsAffected = comando.ExecuteNonQuery();

                // Verificando se a operação foi bem-sucedida
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Catraca liberada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possível liberar a catraca. CPF não encontrado.");
                }
            }
            catch (SqlException sqle)
            {
                // Tratamento de erro para o SQL
                MessageBox.Show("Erro de acesso ao banco de dados: " + sqle.Message, "Erro");
            }
            finally
            {
                // Fechar a conexão
                if (conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                }
            }

        }


    }//fim class form1

}//fim projetodepratica
