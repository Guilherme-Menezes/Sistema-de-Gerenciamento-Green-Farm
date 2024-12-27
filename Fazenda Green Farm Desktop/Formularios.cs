using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using static Fazenda4.Formularios;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json;
using System.Net.Http;
using System.IO;
using System.Net.Sockets;
namespace Fazenda4
{
    internal class Formularios
    {
        //CHAMADA DA CALASSE db
        DB db = new DB();
       
        public class Fazenda
        {
            public int IdFazenda { get; set; }
            public string Nome { get; set; }
            public int Região { get; set; }

        }


        public class ProdutoVenda
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public decimal Valor { get; set; }
            public int Qtde { get; set; }
            public decimal SubTotal { get; set; }

            public override string ToString()
            {
                return Nome;
            }
        }

        public class Venda
        {
            public int Id { get; set; }
            public string Data { get; set; }
            public int QtdeItens { get; set; }
            public decimal ValorTotal { get; set; }
        }


        public class Produto
        {
            public int IdProduto { get; set; }
            public string Nome { get; set; }
            public int Quantidade { get; set; }
            public decimal Valor { get; set; }
            public string Categoria { get; set; }
            public int qtdeVenda { get; set; } 
        }

        public class ProdutoComboBoxItem
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Valor { get; set; }
            public string Qtde { get; set; }

            public override string ToString()
            {
                return Nome;
            }
        }

        public class SugestaoPlantio
        {
            public string Estacao { get; set; }
            public string Regiao { get; set; }
            public List<string> Produtos { get; set; }
        }

        public class RelatorioGeral
        {
            public int ProC { get; set; }
            public int VenC { get; set; }
            public int VenS { get; set; }
            public int itensV { get; set; }
        }


        //METODO PARA CONSEGUIR LOCALIZAÇÃO
        public async Task<string> ObterLocalizacao()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://ipinfo.io/json"; 
                string jsonResponse = await client.GetStringAsync(url);
                dynamic dadosLocalizacao = JsonConvert.DeserializeObject(jsonResponse);

                
                return dadosLocalizacao.loc; 
            }
        }

        //METODO PARA OBTER CLIMA
        public async Task<string> ObterClima(string localizacao)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiKey = "db5bbc2675007bf768427af08d92fd2d"; 
                string url = $"https://api.openweathermap.org/data/2.5/weather?lat={localizacao.Split(',')[0]}&lon={localizacao.Split(',')[1]}&appid={apiKey}&units=metric&lang=pt"; // Para Celsius
                string jsonResponse = await client.GetStringAsync(url);
                dynamic dadosClima = JsonConvert.DeserializeObject(jsonResponse);

                // Formata a resposta
                string temperatura = dadosClima["main"]["temp"].ToString();
                string clima = dadosClima["weather"][0]["description"].ToString();
               

                return $"Temperatura: {temperatura}°C\nClima: {clima}";
            }
        }

        //INSERIR USUARIO
        public bool InserirUsuario(String nome, String cpf, String email, String senha, DateTime data, String telefone)
        {

            try
            {

                db.OpenConnection();

                string query = "INSERT INTO tbUsuario (nomeUsuario, cpfUsuario, emailUsuario, senhaUsuario, dtNascimento) VALUES(@nome, @cpf, @email, @senha, @data)";
                SqlCommand cm = new SqlCommand(query, db.Connection);



                cm.Parameters.AddWithValue("@nome", nome);
                cm.Parameters.AddWithValue("@cpf", cpf);
                cm.Parameters.AddWithValue("@email", email);
                cm.Parameters.AddWithValue("@senha", senha);
                cm.Parameters.AddWithValue("@data", data);

                SqlDataReader dr = cm.ExecuteReader();

                db.CloseConnection();
                bool telefonesucesso = InserirTelefone(telefone, cpf);
                if (telefonesucesso)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir usuário: {ex.Message}");
                db.CloseConnection();
                return false;
            }
        }

        //Pegar o id do usuário com o cpf
        public int EncontrarIDUsuario(String cpf)
        {

            db.OpenConnection();
            int idUsuario = 0;


            String query = "SELECT idUsuario FROM tbUsuario WHERE cpfUsuario = @cpf";

            using (SqlCommand cmd = new SqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@cpf", cpf);

              
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    idUsuario = (int)result;  
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado.");
                }


            }
            return idUsuario;

        }

        //iNSERIR TELEFONE DO USUARIO
        public bool InserirTelefone(String telefone, String cpf)
        {

            try
            {
                int id = EncontrarIDUsuario(cpf);
                if (id == 0)
                {
                    db.CloseConnection();
                    return false;
                }
                db.OpenConnection();
                String query = "INSERT INTO tbTelefoneUsuario (numeroTelefone, idUsuario) VALUES (@numero, @idUsuario)";
                SqlCommand cm = new SqlCommand(query, db.Connection);


                cm.Parameters.AddWithValue("@numero", telefone);
                cm.Parameters.AddWithValue("@idUsuario", id);

                SqlDataReader dr = cm.ExecuteReader();

                db.CloseConnection();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
                db.CloseConnection();
                return false;
            }


        }

        //INSERIR FAZENDA
        public bool InserirFazenda(String nome, String email, String logradouro, String numero, String cep, String uf, String CPF, String dcFazenda)
        {

            try
            {
                int id = EncontrarIDUsuario(CPF);
                if (id == 0)
                {
                    db.CloseConnection();
                    return false;
                }
                db.OpenConnection();
                String query = "INSERT INTO tbFazenda (nomeFazenda, emailFazenda, logradouro, numero, cep, uf, idUsuario, descFazenda) VALUES(@nomeFazenda, @emailFazenda, @logradouro, @numero, @cep, @uf, @idUsuario, @dcFazenda)";
                SqlCommand cm = new SqlCommand(query, db.Connection);



                cm.Parameters.AddWithValue("@nomeFazenda", nome);
                cm.Parameters.AddWithValue("@emailFazenda", email);
                cm.Parameters.AddWithValue("@logradouro", logradouro);
                cm.Parameters.AddWithValue("@numero", numero);
                cm.Parameters.AddWithValue("@cep", cep);
                cm.Parameters.AddWithValue("@uf", uf);
                cm.Parameters.AddWithValue("@dcFazenda", dcFazenda);
                cm.Parameters.AddWithValue("@idUsuario", id);

                SqlDataReader dr = cm.ExecuteReader();

                db.CloseConnection();


                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir fazenda: {ex.Message}");
                db.CloseConnection();
                return false;
            }
        }

        //PUXA INFORMAÇÕES DA FAZENDA
        public List<Fazenda> InfoFazenda(String cpf)
        {

            int idUsuario = EncontrarIDUsuario(cpf);
            List<Fazenda> Fazendas = new List<Fazenda>();
            string query = "select idFazenda, NomeFazenda from tbFazenda where idUsuario = @idUsuario";


            using (SqlCommand cm = new SqlCommand(query, db.Connection))
            {
                db.OpenConnection();
                cm.Parameters.AddWithValue("@idUsuario", idUsuario);
                using (SqlDataReader dr = cm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Fazenda fazenda = new Fazenda
                        {
                            IdFazenda = Convert.ToInt32(dr["idFazenda"]),
                            Nome = dr["nomeFazenda"].ToString(),
                            
                        };
                        Fazendas.Add(fazenda);
                    }
                }
                db.CloseConnection();
            }

            return Fazendas;
        }

        //ENCONTRAR CPF DO USUARIO LOGADO
        public String EncontrarcpfUsuario(String txtLogin)
        {

            DB db = new DB();
            db.OpenConnection();
            string cpfUsuarioLogado = "";


            String query = "SELECT cpfUsuario FROM tbUsuario WHERE emailUsuario = @login";

            using (SqlCommand cmd = new SqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@login", txtLogin);

                // Executar o SELECT e obter o ID do usuário
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    cpfUsuarioLogado = result.ToString();
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado.");
                }


            }
            return cpfUsuarioLogado;
        }
        //ENCONTRAR ID FAZENDA
        public int EncontrarIDFazenda(String cpf)
        {

            db.OpenConnection();


            int idFazenda = 0;
            int idUsuario = EncontrarIDUsuario(cpf);

            String query = "SELECT idFazenda FROM tbFazenda inner Join tbUsuario on tbFazenda.idUsuario = tbUsuario.idUsuario WHERE tbFazenda.idUsuario = @idUsuario";

            using (SqlCommand cmd = new SqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);


                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    idFazenda = (int)result;
                }



            }
            return idFazenda;

        }

        //INSERIR PRODUTO
        public bool InserirProduto(String nomeProduto, String Valor, String quantidade, int cbc, String cpfUsuLog)
        {

            try
            {
                int id = EncontrarIDFazenda(cpfUsuLog);
                if (id == 0)
                {
                    db.CloseConnection();
                    return false;
                }
                string valorSemFormatacao = Valor.Replace("R$", "").Trim();
                decimal valorProduto = decimal.Parse(valorSemFormatacao);
                db.OpenConnection();
                String query = "INSERT INTO tbProduto (descricaoProduto, valorProduto, quantidade, idFazenda, idCategoria) VALUES(@nomeProduto, @valorProduto, @qtde, @idF, @idCate)";
                SqlCommand cm = new SqlCommand(query, db.Connection);



                cm.Parameters.AddWithValue("@nomeProduto", nomeProduto);
                cm.Parameters.AddWithValue("@valorProduto", valorProduto);
                cm.Parameters.AddWithValue("@qtde", quantidade);
                cm.Parameters.AddWithValue("@idF", id);
                cm.Parameters.AddWithValue("@idCate", cbc);


                SqlDataReader dr = cm.ExecuteReader();

                db.CloseConnection();


                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir fazenda: {ex.Message}");
                db.CloseConnection();
                return false;
            }
        }


        ///TABELA DOS PRODUTOS <summary>
        /// TABELA DOS PRODUTOS
        /// </summary>
        /// <returns></returns>
        /// 

       

        public List<Produto> CarregarProdutos(String id = null)
        {


            List<Produto> produtos = new List<Produto>();
            string query = "SELECT idProduto, descricaoProduto, valorProduto, quantidade, descricaoCategoria FROM tbProduto join tbCategoria on tbProduto.idCategoria = tbCategoria.idCategoria where tbProduto.idFazenda = @idFazenda";


            using (SqlCommand cm = new SqlCommand(query, db.Connection))
            {
                db.OpenConnection();
                cm.Parameters.AddWithValue("@idFazenda", id);
                using (SqlDataReader dr = cm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Produto produto = new Produto
                        {
                            IdProduto = Convert.ToInt32(dr["idProduto"]),
                            Nome = dr["descricaoProduto"].ToString(),
                            Quantidade = Convert.ToInt32(dr["quantidade"]),
                            Valor = +Convert.ToDecimal(dr["valorProduto"]),
                            Categoria = dr["descricaoCategoria"].ToString()
                        };
                        produtos.Add(produto);
                    }
                }
                db.CloseConnection();
            }

            return produtos;
        }
        
        //Carregar melhores produtos
        public List<Produto> carregarProdutosTOP(String id = null)
        {
            List<Produto> produtos = new List<Produto>();
            string query = "SELECT tbProduto.idProduto, descricaoProduto,  COUNT(*) AS TotalVendas FROM tbItensVenda\r\n\tinner join tbProduto on tbProduto.idProduto = tbItensVenda.idProduto\r\n\t\tinner join tbVenda on tbVenda.idVenda = tbItensVenda.idVenda\r\n\t\t\twhere idUsuario = @id\r\nGROUP BY \r\n   tbProduto.idProduto, descricaoProduto\r\nORDER BY \r\n    TotalVendas DESC\r\nOFFSET 0 ROWS\r\nFETCH NEXT 5 ROWS ONLY;";


            using (SqlCommand cm = new SqlCommand(query, db.Connection))
            {
                db.OpenConnection();
                cm.Parameters.AddWithValue("@id", id);
                using (SqlDataReader dr = cm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Produto produto = new Produto
                        {
                           
                            Nome = dr["descricaoProduto"].ToString(),
                            qtdeVenda = Convert.ToInt32(dr["TotalVendas"]),
                          
                        };
                        produtos.Add(produto);
                    }
                }
                db.CloseConnection();
            }

            return produtos;
        }


        

        //CARREGAR COMBOBOXS
        //Carregar categorias no combobox
        public void CarregarCategoriasNoComboBox(System.Windows.Forms.ComboBox comboBoxCategorias)
        {

            db.OpenConnection();


            string query = "SELECT descricaoCategoria FROM tbCategoria";

            using (SqlCommand cmd = new SqlCommand(query, db.Connection))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    comboBoxCategorias.Items.Clear();


                    while (dr.Read())
                    {
                        comboBoxCategorias.Items.Add(dr["descricaoCategoria"].ToString());
                    }
                }
            }

            db.CloseConnection();
        }

        //Carregar produtos na combobox
        public void CarregarProdutosNoComboBox(System.Windows.Forms.ComboBox comboBoxProdutos, int idFazenda)
        {

            db.OpenConnection();


            string query = "SELECT idproduto, descricaoProduto  FROM tbProduto where idFazenda = @id";



            using (SqlCommand cm = new SqlCommand(query, db.Connection))
            {
                db.OpenConnection();
                cm.Parameters.AddWithValue("@id", idFazenda);
                using (SqlDataReader dr = cm.ExecuteReader())
                {
                    comboBoxProdutos.Items.Clear();
                    while (dr.Read())
                    {
                        ProdutoComboBoxItem item = new ProdutoComboBoxItem
                        {
                            Id = (int)dr["idproduto"],
                            Nome = dr["descricaoProduto"].ToString()
                        };

                        comboBoxProdutos.Items.Add(item);
                    }
                }
            }


            db.CloseConnection();
        }

        //PEGAR OS NOMES DOS PRODUTOS E COLOCAR NAS TEXTBOXS
        public ProdutoComboBoxItem CarregarProdutosDetalhes(int idFazenda, int idProduto)
        {



            string query = "SELECT idproduto, descricaoProduto, valorProduto, quantidade FROM tbProduto where idFazenda = @idf AND idProduto = @idp";

            ProdutoComboBoxItem item = null;

            using (SqlCommand cm = new SqlCommand(query, db.Connection))
            {
                cm.Parameters.AddWithValue("@idf", idFazenda);
                cm.Parameters.AddWithValue("@idp", idProduto);

                using (SqlDataReader dr = cm.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        item = new ProdutoComboBoxItem
                        {
                            Id = (int)dr["idproduto"],
                            Nome = dr["descricaoProduto"].ToString(),
                            Valor = dr["valorProduto"].ToString().Replace(".", ","),
                            Qtde = dr["quantidade"].ToString()
                        };
                    }
                }
            }

            db.CloseConnection();
            return item;
        }

        //ALTERAR PRODUTOS
        public bool AlterarProduto(String nomeP, String quantidade, String Valor, int cbc, int idFazenda, int idProduto)
        {

            try
            {

                string valorSemFormatacao = Valor.Replace("R$", "").Trim();
                decimal valorProduto = decimal.Parse(valorSemFormatacao);
                db.OpenConnection();
                String query = "update tbProduto set descricaoProduto = @nomeProduto, quantidade =@qtde, valorProduto= @valorProduto, idCategoria = @idCate where  idFazenda = @idf AND idProduto = @idP";
                SqlCommand cm = new SqlCommand(query, db.Connection);



                cm.Parameters.AddWithValue("@nomeProduto", nomeP);
                cm.Parameters.AddWithValue("@qtde", quantidade);
                cm.Parameters.AddWithValue("@valorProduto", valorProduto);
                cm.Parameters.AddWithValue("@idCate", cbc);
                cm.Parameters.AddWithValue("@idf", idFazenda);
                cm.Parameters.AddWithValue("@idp", idProduto);

                SqlDataReader dr = cm.ExecuteReader();

                db.CloseConnection();


                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Alterar Produto: {ex.Message}");
                db.CloseConnection();
                return false;
            }
        }

        //EXCLUIR PRODUTOS
        public bool ExcluirProduto(int idFazenda, int idProduto)
        {

            try
            {


                db.OpenConnection();
                String query = "DELETE tbItensVenda where idProduto = @idP";

                SqlCommand cm = new SqlCommand(query, db.Connection);
                cm.Parameters.AddWithValue("@idp", idProduto);

                cm.ExecuteNonQuery();
                query = "DELETE tbProduto where  idFazenda = @idf AND idProduto = @idP";

                 cm = new SqlCommand(query, db.Connection);


                cm.Parameters.AddWithValue("@idf", idFazenda);
                cm.Parameters.AddWithValue("@idp", idProduto);

                cm.ExecuteNonQuery();

                db.CloseConnection();


                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir Produto: {ex.Message}");
                db.CloseConnection();
                return false;
            }
        }

        //INICIAR VENDA
        public int RealizarVenda(string cpfUsuario)
        {
            int idUsuario = EncontrarIDUsuario(cpfUsuario);
            int idVenda;

            db.OpenConnection();

            string queryVenda = "INSERT INTO tbVenda (dtVenda, idUsuario, situacaoVenda) VALUES (@dataVenda, @idUsuario, 0)";
            SqlCommand cmVenda = new SqlCommand(queryVenda, db.Connection);
            cmVenda.Parameters.AddWithValue("@dataVenda", DateTime.Now);
            cmVenda.Parameters.AddWithValue("@idUsuario", idUsuario);

            SqlDataReader dr = cmVenda.ExecuteReader();
            db.CloseConnection();
            db.OpenConnection();
            string query = "SELECT MAX(idVenda) FROM tbVenda WHERE idUsuario = @idUsuario";
            SqlCommand cm = new SqlCommand(query, db.Connection);
            cm.Parameters.AddWithValue("@idUsuario", idUsuario);

            idVenda = (int)cm.ExecuteScalar();


            return idVenda;

        }

        //FINALIZAR VENDA
        public bool FinalizarVenda(int idVenda, int situVenda)
        {

            db.OpenConnection();
            try
            {
                string query = "SELECT SUM(subtotal) FROM tbItensVenda WHERE idVenda = @idVenda";

                decimal valorTotal;

                using (SqlCommand cmd = new SqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@idVenda", idVenda);
                    valorTotal = (decimal)cmd.ExecuteScalar();
                }

                //Atualiza o valor da venda já existente
                query = "UPDATE tbVenda SET valorPedido = @valorTotal, situacaoVenda = @situvenda WHERE idVenda = @idVenda";

                using (SqlCommand cmd = new SqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@valorTotal", valorTotal);
                    cmd.Parameters.AddWithValue("@situvenda", situVenda);
                    cmd.Parameters.AddWithValue("@idVenda", idVenda); 
                    cmd.ExecuteNonQuery();
                }


                //Criar uma lista para armazenar o id do produto e a quantidade que foi na venda
                var itensVenda = new List<(int idProduto, int quantidadeVendida)>();

                // Atualizar estoque para cada item da venda
                query = "SELECT idProduto, qtdeItensVenda FROM tbItensVenda WHERE idVenda = @idVenda";
                using (SqlCommand cmd = new SqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@idVenda", idVenda);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idProduto = reader.GetInt32(0);
                            int quantidadeVendida = Convert.ToInt32(reader["qtdeItensVenda"]);
                            itensVenda.Add((idProduto, quantidadeVendida));

                        }
                    }
                }

                
                foreach (var item in itensVenda)
                {
                    // Tirar a quantidade vendida do estoque
                    string atualizaProQuery = "UPDATE tbProduto SET quantidade = quantidade - @quantidadeVendida WHERE idProduto = @idProduto";
                    using (SqlCommand cmdEstoque = new SqlCommand(atualizaProQuery, db.Connection))
                    {
                        cmdEstoque.Parameters.AddWithValue("@quantidadeVendida", item.quantidadeVendida);
                        cmdEstoque.Parameters.AddWithValue("@idProduto", item.idProduto);
                        cmdEstoque.ExecuteNonQuery();
                    }
                }


                db.CloseConnection();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
                db.CloseConnection();
                return false;
            }
        }

        //INSERIR ITEM NA VENDA
        public bool AdicionarItemVenda(int idVenda, int idProduto, int quantidade)
        {

            db.OpenConnection();

            try
            {

                // Verificar a quantidade disponível no estoque
                string queryEstoque = "SELECT quantidade FROM tbProduto WHERE idProduto = @idProduto";
                int quantidadeEstoque;

                using (SqlCommand cmdEstoque = new SqlCommand(queryEstoque, db.Connection))
                {
                    cmdEstoque.Parameters.AddWithValue("@idProduto", idProduto);
                    quantidadeEstoque = (int)cmdEstoque.ExecuteScalar();
                }

                if (quantidade > quantidadeEstoque)
                {
                    MessageBox.Show("Quantidade insuficiente em estoque.");
                    db.CloseConnection();
                    return false;
                }

                    //Pega o valor do produto para inserir
                string query = "SELECT valorProduto FROM tbProduto WHERE idProduto = @idProduto";
                decimal valorProduto;

                using (SqlCommand cmd = new SqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@idProduto", idProduto);
                    valorProduto = (decimal)cmd.ExecuteScalar();
                }

                decimal subtotal = valorProduto * quantidade;


                //Inserir item a venda
                query = "INSERT INTO tbItensVenda (idVenda, idProduto, qtdeItensVenda, subtotal) VALUES (@idVenda, @idProduto, @quantidade, @subtotal)";

                using (SqlCommand cmd = new SqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@idVenda", idVenda);
                    cmd.Parameters.AddWithValue("@idProduto", idProduto);
                    cmd.Parameters.AddWithValue("@quantidade", quantidade);
                    cmd.Parameters.AddWithValue("@subtotal", subtotal);
                    cmd.ExecuteNonQuery();
                }

                db.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
                db.CloseConnection();
                return false;
            }
        }
        // EXCLUIR VENDAS VAZIASS 
        public bool ExcluirVendasVazias()
        {

            db.OpenConnection();

            try
            {

                string query = query = "DELETE tbItensVenda where idVenda = (Select idVenda from tbVenda where ValorPedido is null )";
                SqlCommand cmd = new SqlCommand(query, db.Connection);


                cmd.ExecuteNonQuery();

                query = "DELETE tbVenda where ValorPedido is null";
                cmd = new SqlCommand(query, db.Connection);
                cmd.ExecuteNonQuery();
                db.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
                db.CloseConnection();
                return false;
            }



          
        }

        //EXCLUIR VENDAS
        public bool ExcluirVenda( int idVenda)
        {

            try
            {
                db.OpenConnection();
                String query = "DELETE tbItensVenda where idVenda = @idv";

                SqlCommand cm = new SqlCommand(query, db.Connection);
                cm.Parameters.AddWithValue("@idv", idVenda);

                cm.ExecuteNonQuery();
                query = "DELETE tbVenda where idVenda = @idv ";

                cm = new SqlCommand(query, db.Connection);


                cm.Parameters.AddWithValue("@idv", idVenda);

                cm.ExecuteNonQuery();

                db.CloseConnection();


                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir Produto: {ex.Message}");
                db.CloseConnection();
                return false;
            }
        }

        /// <summary>
        /// /PUXAR OS ITENS PARA A VENDA
        /// </summary>
        
       
        public List<ProdutoVenda> CarregarProdutosVendas(String id = null)
        {


            List<ProdutoVenda> produtos = new List<ProdutoVenda>();
            string query = "select descricaoProduto, qtdeItensVenda, valorProduto, subtotal from tbItensVenda\r\n\tinner join tbProduto on \r\n\t\t\ttbProduto.idProduto = tbItensVenda.idProduto where idVenda = @idVenda";


            using (SqlCommand cm = new SqlCommand(query, db.Connection))
            {
                db.OpenConnection();
                cm.Parameters.AddWithValue("@idVenda", id);
                using (SqlDataReader dr = cm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        ProdutoVenda produtoVenda = new ProdutoVenda
                        {
                            Nome = dr["descricaoProduto"].ToString(),
                            Qtde = Convert.ToInt32(dr["qtdeItensVenda"]),
                            Valor = Convert.ToDecimal(dr["valorProduto"]),

                            SubTotal = Convert.ToDecimal(dr["subtotal"].ToString())
                        };
                        produtos.Add(produtoVenda);
                    }
                }
                db.CloseConnection();
            }

            return produtos;
        }

        //carregar vendas na tabela
        public List<Venda> CarregarVendas(String id = null)
        {
            int idUsuario = EncontrarIDUsuario(id);

            List<Venda> vendas = new List<Venda>();
            string query = "SELECT tbVenda.idVenda,  FORMAT(DtVenda, 'dd/MM/yyyy HH:mm') as DATA, count(idProduto) AS Itens, ValorPedido from tbVenda join tbItensVenda on tbItensVenda.idVenda = tbVenda.idVenda\r\nWHERE idUsuario = @idUsuario GROUP BY tbVenda.idVenda, DtVenda, ValorPedido ";


            using (SqlCommand cm = new SqlCommand(query, db.Connection))
            {
                db.OpenConnection();
                cm.Parameters.AddWithValue("@idUsuario", idUsuario);
                using (SqlDataReader dr = cm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Venda venda = new Venda
                        {
                            Id = Convert.ToInt32(dr["idVenda"]),
                            Data = dr["Data"].ToString(),
                            QtdeItens = Convert.ToInt32(dr["Itens"]),
                            ValorTotal = Convert.ToDecimal(dr["ValorPedido"])
                        };
                        vendas.Add(venda);
                    }
                }
                db.CloseConnection();
            }


            return vendas;
        }

        //metodos para saber quantos produtos vendidos
        public string qtdeProdVenMes(int mes, int ano, string id = null)
        {
            String idUsuAtual = EncontrarcpfUsuario(id);
            int idUsuario = EncontrarIDUsuario(idUsuAtual);
            string pqm= "";
            string query = "select SUM(qtdeItensVenda) from tbVenda\r\n\tinner join tbItensVenda on tbVenda.idVenda = tbItensVenda.idVenda\r\n\t\tinner join tbProduto on tbItensVenda.idProduto = tbProduto.idProduto\r\n\t\t\twhere MONTH(dtVenda) = @mes AND YEAR(dtVenda) = @ano AND idUsuario = @id";
            using (SqlCommand cmd = new SqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@mes", mes);
                cmd.Parameters.AddWithValue("@ano", ano);
                cmd.Parameters.AddWithValue("@id", idUsuario);


                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                   pqm = result.ToString();
                }
            }

            return pqm;
           


        }
        //metodos para saber faturamento no mes
        public string qtdeVenMes(int mes, int ano, string id = null)
        {
            String idUsuAtual = EncontrarcpfUsuario(id);
            int idUsuario = EncontrarIDUsuario(idUsuAtual);
            string vqm = "";
            string query = "select SUM(ValorPedido) from tbVenda\r\n\tinner join tbItensVenda on tbVenda.idVenda = tbItensVenda.idVenda\r\n\t\tinner join tbProduto on tbItensVenda.idProduto = tbProduto.idProduto\r\n\t\t\twhere MONTH(dtVenda) = @mes AND YEAR(dtVenda) = @ano AND idUsuario = @id";
            using (SqlCommand cmd = new SqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@mes", mes);
                cmd.Parameters.AddWithValue("@ano", ano);
                cmd.Parameters.AddWithValue("@id", idUsuario);


                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    vqm = result.ToString();
                }
            }

            return vqm;



        }
        //carregar as melhores vendas
        public List<Venda> carregarVendasTop(int mes, int ano, string id = null)
        {
            int idUsuario = EncontrarIDUsuario(id);
           
            List<Venda> vendas = new List<Venda>();
            string query = "select TOP 5 tbVenda.idVenda, DtVenda, ValorPedido From tbVenda \r\n\twhere idUsuario = @id AND MONTH(DtVenda) =@mes  AND YEAR(DtVenda) = @ano\r\n\torder by \r\n\t\tValorPedido DESC";


            using (SqlCommand cm = new SqlCommand(query, db.Connection))
            {
                db.OpenConnection();
                cm.Parameters.AddWithValue("@id", idUsuario);
                cm.Parameters.AddWithValue("@mes", mes);
                cm.Parameters.AddWithValue("@ano", ano);
                using (SqlDataReader dr = cm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Venda venda = new Venda
                        {
                            Id = Convert.ToInt32(dr["idVenda"]),
                            Data = dr["DtVenda"].ToString(),
                           
                            ValorTotal = Convert.ToDecimal(dr["ValorPedido"])
                        };
                        vendas.Add(venda);
                    }
                }
                db.CloseConnection();
            }


            return vendas;
        }


        //ENCONTRAR ID DA VENDA
        public int EncontrarIDVenda(String txtLogin, int op)
        {
            String idUsuAtual = EncontrarcpfUsuario(txtLogin);
            int idUsuario = EncontrarIDUsuario(idUsuAtual);
            int idVenda;
            string query;
            SqlCommand cm;
            if (op == 0)
            {
                query = "SELECT MAX(idVenda) FROM tbVenda WHERE idUsuario = @idUsuario";
                cm = new SqlCommand(query, db.Connection);
                cm.Parameters.AddWithValue("@idUsuario", idUsuario);

                idVenda = (int)cm.ExecuteScalar();
            }
            else { 
            query = "SELECT idVenda FROM tbVenda WHERE idUsuario = @idUsuario";
            cm = new SqlCommand(query, db.Connection);
            cm.Parameters.AddWithValue("@idUsuario", idUsuario);

            idVenda = (int)cm.ExecuteScalar();
            }

            return idVenda;
        }

        //AJUSTAR E COLOCAR TABLEAS -> a logica é ( qual elemento (tabela), a opção e de qual usuario está puxando)
        //a opção se refere ao tipo da tabela ex: 1  para produtos, 2 para vendas etc.
        public void AdicionarColunasListView(System.Windows.Forms.ListView listViewProdutos, int op, string txtLogin)
        {

            if (op == 1)
            {
                //se nao tiver cabeçalho ela adiciona
                if (listViewProdutos.Columns.Count == 0)
                {
                    int lvpSize = listViewProdutos.Width;
                    listViewProdutos.Columns.Add("NOME", -2, HorizontalAlignment.Center);
                    listViewProdutos.Columns.Add("QUANTIDADE", -2, HorizontalAlignment.Center);
                    listViewProdutos.Columns.Add("VALOR", -2, HorizontalAlignment.Center);
                    listViewProdutos.Columns.Add("CATEGORIA", -2, HorizontalAlignment.Center);

                    listViewProdutos.Columns[0].Width = (int)(lvpSize * 0.25);
                    listViewProdutos.Columns[1].Width = (int)(lvpSize * 0.25);
                    listViewProdutos.Columns[2].Width = (int)(lvpSize * 0.25);
                    listViewProdutos.Columns[3].Width = (int)(lvpSize * 0.25);

                    
                }
                //popula a tabela 
                AjustarColunasListView(listViewProdutos, op, txtLogin);
            }
            else if (op == 2)
            {
                if (listViewProdutos.Columns.Count == 0)
                {


                    int lvpSize = listViewProdutos.Width;
                    listViewProdutos.Columns.Add("NOME", -2, HorizontalAlignment.Center);
                    listViewProdutos.Columns.Add("QUANTIDADE", -2, HorizontalAlignment.Center);
                    listViewProdutos.Columns.Add("VALOR", -2, HorizontalAlignment.Center);
                    listViewProdutos.Columns.Add("VALOR TOTAL", -2, HorizontalAlignment.Center);

                    listViewProdutos.Columns[0].Width = (int)(lvpSize * 0.25);
                    listViewProdutos.Columns[1].Width = (int)(lvpSize * 0.25);
                    listViewProdutos.Columns[2].Width = (int)(lvpSize * 0.25);
                    listViewProdutos.Columns[3].Width = (int)(lvpSize * 0.25);

                    
                }
                AjustarColunasListView(listViewProdutos, op, txtLogin);
            }
            else if (op == 3)
            {
                if (listViewProdutos.Columns.Count == 0)
                {


                    int lvpSize = listViewProdutos.Width;
                    listViewProdutos.Columns.Add("CODIGO", -2, HorizontalAlignment.Center);
                    listViewProdutos.Columns.Add("DATA", -2, HorizontalAlignment.Center);
                    listViewProdutos.Columns.Add("ITENS", -2, HorizontalAlignment.Center);
                    listViewProdutos.Columns.Add("VALOR TOTAL", -2, HorizontalAlignment.Center);

                    listViewProdutos.Columns[0].Width = (int)(lvpSize * 0.25);
                    listViewProdutos.Columns[1].Width = (int)(lvpSize * 0.25);
                    listViewProdutos.Columns[2].Width = (int)(lvpSize * 0.25);
                    listViewProdutos.Columns[3].Width = (int)(lvpSize * 0.25);
                  
                }
                AjustarColunasListView(listViewProdutos, 3, txtLogin);
            }else if(op == 4)
            {
                if (listViewProdutos.Columns.Count == 0)
                {


                    int lvpSize = listViewProdutos.Width;
                    listViewProdutos.Columns.Add("Produto", -2, HorizontalAlignment.Center);
                    listViewProdutos.Columns.Add("Quantidade de Vendas", -2, HorizontalAlignment.Center);
                   

                    listViewProdutos.Columns[0].Width = (int)(lvpSize * 0.50);
                    listViewProdutos.Columns[1].Width = (int)(lvpSize * 0.50);
                   

                }
                AjustarColunasListView(listViewProdutos, 4, txtLogin);
            }
        }
        public void AjustarColunasListView(System.Windows.Forms.ListView listViewProdutos, int op, String txtLogin)
        {
            if (op == 1)
            {
                //3 chamadas -> encontrar o cpf do usuario -> para encontrar o id da fazenda -> para carregar os produtos
                String idUsuAtual = EncontrarcpfUsuario(txtLogin);
                int idFazenda = EncontrarIDFazenda(idUsuAtual);
                List<Produto> produtos = CarregarProdutos(idFazenda.ToString());

                listViewProdutos.Items.Clear(); // Limpa os itens antigos

                foreach (var produto in produtos)
                {
                    ListViewItem item = new ListViewItem(produto.Nome);
                    item.SubItems.Add(produto.Quantidade.ToString());
                    item.SubItems.Add($"R$ {produto.Valor:F2}");
                    item.SubItems.Add(produto.Categoria.ToString());

                    item.Tag = produto.IdProduto;
                    listViewProdutos.Items.Add(item);
                }

            }
            else if (op == 2)
            {
                int vendaAtual = EncontrarIDVenda(txtLogin, 0);
                List<ProdutoVenda> produtos = CarregarProdutosVendas(vendaAtual.ToString());

                listViewProdutos.Items.Clear(); // Limpa os itens antigos

                foreach (var produto in produtos)
                {
                    ListViewItem item = new ListViewItem(produto.Nome);
                    item.SubItems.Add(produto.Qtde.ToString());
                    item.SubItems.Add($"R$ {produto.Valor:F2}");
                    item.SubItems.Add($"R$ {produto.SubTotal:F2}");
                    listViewProdutos.Items.Add(item);
                }
            }
            else if (op == 3)
            {
                String idUsuAtual = EncontrarcpfUsuario(txtLogin);
                List<Venda> vendas = CarregarVendas(idUsuAtual);

                listViewProdutos.Items.Clear(); // Limpa os itens antigos

                foreach (var venda in vendas)
                {
                    ListViewItem item = new ListViewItem(venda.Id.ToString());
                    item.SubItems.Add(venda.Data);
                    item.SubItems.Add(venda.QtdeItens.ToString());
                    item.SubItems.Add($"R$ {venda.ValorTotal:F2}");

                    listViewProdutos.Items.Add(item);
                }
                listViewProdutos.FullRowSelect = true;
                listViewProdutos.MultiSelect = false;

            }
            else if (op == 4)
            {
                int idUsu = EncontrarIDUsuario(EncontrarcpfUsuario(txtLogin));
                List<Produto> produtos = carregarProdutosTOP(idUsu.ToString());

                listViewProdutos.Items.Clear();

                foreach (var produto in produtos)
                {
                    ListViewItem item = new ListViewItem(produto.Nome);
                    item.SubItems.Add(produto.qtdeVenda.ToString());

                    listViewProdutos.Items.Add(item);
                }


            }
           
               
        }

        //METODO PARA PEGAR TOP VENDAS
        public void TopVendas(String emailLogin, System.Windows.Forms.ListView listViewProdutos, int mes, int ano)
        {
            if (listViewProdutos.Columns.Count == 0)
            {


                int lvpSize = listViewProdutos.Width;
                listViewProdutos.Columns.Add("CODIGO", -2, HorizontalAlignment.Center);
                listViewProdutos.Columns.Add("DATA", -2, HorizontalAlignment.Center);
                listViewProdutos.Columns.Add("VALOR TOTAL", -2, HorizontalAlignment.Center);

                listViewProdutos.Columns[0].Width = (int)(lvpSize * 0.333);
                listViewProdutos.Columns[1].Width = (int)(lvpSize * 0.333);
                listViewProdutos.Columns[2].Width = (int)(lvpSize * 0.333);


            }
            String idUsuAtual = EncontrarcpfUsuario(emailLogin);
            List<Venda> vendas = carregarVendasTop(mes, ano, idUsuAtual);

            listViewProdutos.Items.Clear();

            foreach (var venda in vendas)
            {
                ListViewItem item = new ListViewItem(venda.Id.ToString());
                item.SubItems.Add(venda.Data);

                item.SubItems.Add($"R$ {venda.ValorTotal:F2}");

                listViewProdutos.Items.Add(item);
            }
            listViewProdutos.FullRowSelect = true;
        }

        


        //Sugestão de Plantio -> leitura do txt para as sugestões
        private List<SugestaoPlantio> sugestoesPlantio = new List<SugestaoPlantio>();
        public void CarregarSugestoesDePlantio(string caminhoArquivo)
        {
            if (File.Exists(caminhoArquivo))
            {
                string[] linhas = File.ReadAllLines(caminhoArquivo);

                foreach (string linha in linhas)
                {
                   
                    string[] partes = linha.Split(',');

                    if (partes.Length >= 3)
                    {
                       
                        SugestaoPlantio sugestao = new SugestaoPlantio
                        {
                            Estacao = partes[0],
                            Regiao = partes[1],
                            Produtos = partes.Skip(2).ToList() 
                        };

                        sugestoesPlantio.Add(sugestao);
                    }
                }
            }
        }

        //MEtodo para ver qual õpção foi escolhida
        public string ObterSugestaoPlantio(string estacao, string regiao)
        {
           
            var sugestao = sugestoesPlantio.FirstOrDefault(s => s.Estacao == estacao && s.Regiao == regiao);

            if (sugestao != null)
            {
                return string.Join(Environment.NewLine, sugestao.Produtos);
            }

            return "Nenhuma sugestão disponível para essa combinação.";
        }

        ///Carregar o relatorio geral.
        public List<RelatorioGeral> CarregarRelatorioGeral(String id = null)
        {
            string Usu = EncontrarcpfUsuario(id);
            int idUsuario = EncontrarIDUsuario(Usu);
            List<RelatorioGeral> relatorio = new List<RelatorioGeral>();
            string query = " select (SELECT COUNT(*) FROM tbProduto WHERE idUsuario = @id) AS NumeroProduto,\r\n\t\tcount(distinct tbVenda.idVenda) AS NumeroVendas,\r\n\t\tSUM(valorPedido) AS TotalVendas,\r\n\t\tSUM(qtdeItensVenda) AS TotalItens\r\n\t\tfrom tbVenda\r\n\tinner join tbItensVenda on tbItensVenda.idVenda = tbVenda.idVenda\t\r\n\tinner join tbProduto on tbProduto.idProduto = tbItensVenda.idProduto\r\n\t\t\twhere tbVenda.idUsuario = @id Group by tbVenda.idUsuario";


            using (SqlCommand cm = new SqlCommand(query, db.Connection))
            {
                db.OpenConnection();
                cm.Parameters.AddWithValue("@id", idUsuario);
                using (SqlDataReader dr = cm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                       RelatorioGeral RelaGeral = new RelatorioGeral
                        {

                            ProC = Convert.ToInt32(dr["NumeroProduto"]),
                            VenC = Convert.ToInt32(dr["NumeroVendas"]),
                            VenS = Convert.ToInt32(dr["TotalVendas"]),
                            itensV = Convert.ToInt32(dr["TotalItens"])
                        };
                        relatorio.Add(RelaGeral);
                    }
                }
                db.CloseConnection();
            }

            return relatorio;
        }

        //Metodos para verificar se todos os txt dos formularios de cadastros estao preenchidos
        public bool VerificarCamposPreenchidos(List<Control> campos)
        {
            foreach (Control campo in campos)
            {
                // Verifica se o campo é uma TextBox e se está vazio
                if (campo is System.Windows.Forms.TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show($"Por favor, preencha todos os campos");
                    return false;
                }
              
            }
            return true; 
        }


        //Metodo de verificaão cpf
        public bool ValidarCPF(string cpf)
        {
            //tira os espaços
            cpf = cpf.Replace(".", "").Replace("-", "");

            //Verifica se tem tamanho adequado
            if (cpf.Length != 11 || new string(cpf[0], 11) == cpf) return false;

            //Logica do cpf
            int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            // Calcula o primeiro dígito verificador
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            }

            int resto = soma % 11;
            int digito = resto < 2 ? 0 : 11 - resto;
            tempCpf += digito;

            soma = 0;

            // Calcula o segundo dígito verificador
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            }

            resto = soma % 11;
            digito = resto < 2 ? 0 : 11 - resto;

            return cpf.EndsWith(digito.ToString());
        }

        //Metodo para verificar se o usuario já está no sistema 
        public bool VerificarUsuarioExistente(string cpf)
        {
          
            db.OpenConnection();

            string query = "SELECT * FROM tbUsuario WHERE cpfUsuario = @cpf";
            SqlCommand cm = new SqlCommand(query, db.Connection);



            cm.Parameters.AddWithValue("@cpf", cpf);

            SqlDataReader dr = cm.ExecuteReader();

            if (dr.HasRows)
            {
                db.CloseConnection();
                return false;
            }
            else
            {
                db.CloseConnection();
                return true;
            }

            
        }
    }
}

