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
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;
using System.Net.Http;
using Newtonsoft.Json;
using System.Runtime.ConstrainedExecution;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Fazenda4.Formularios;
using System.IO;
using System.Drawing.Imaging;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Globalization;

namespace Fazenda4
{


    public partial class TelaInicial : Form
    {

        String txtExemploDesc = "Minha fazenda tem produtos de qualidade, como verduras e frutas";
        public TelaInicial()
        {
            InitializeComponent();
            painelLogin.Visible = true;
            painelCadastro.Visible = false;
            
            toolStripMenuItem2.Tag = "comImagemFundo";
            menuStrip1.Renderer = new CustomToolStripRenderer();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            dtNascimentoUsu.MaxDate = DateTime.Now;
            dtNascimentoUsu.Value = DateTime.Now;




        }

        //classe para salvar o endereço da fazenda
        public class Endereco
        {
            public string logradouro { get; set; }

            public string uf { get; set; }
        }

        //Chama os metodos dos formularios
        Formularios fm = new Formularios();
        int vendaAtual = 0;
        String emailLogin;
        //Botão de verificação ou Login
        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.OpenConnection();

            string query = "SELECT * FROM tbUsuario WHERE emailUsuario = @login AND senhaUsuario = @senha";
            SqlCommand cm = new SqlCommand(query, db.Connection);



            cm.Parameters.AddWithValue("@login", txtLogin.Text);
            cm.Parameters.AddWithValue("@senha", txtSenha.Text);

            SqlDataReader dr = cm.ExecuteReader();

            if (dr.HasRows)
            {
                painelLogin.Visible = false;
                painelDash2.Visible = true;
                painelProdutos.Visible = true;
                painelProdutosLista.Visible = false;
                listViewProdutos.Items.Clear();
                aviso.Text = " ";
                emailLogin = txtLogin.Text;
                string localizacao = await fm.ObterLocalizacao();
                string clima = await fm.ObterClima(localizacao);
                lbClima.Text = clima;
                List<Fazenda> fazenda = fm.InfoFazenda(fm.EncontrarcpfUsuario(emailLogin));

                lbNF.Text = "Fazenda: "+fazenda[0].Nome;

                txtLogin.Text = "";
                txtSenha.Text = "";
               
            }
            else
            {
                aviso.Text = "Senha ou Usuario Errado";
            }

            db.CloseConnection();

        }

        //Botão para novo cadastro
        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            painelCadastro.Visible = true;
            painelCadastroUsuario.Visible = true;
            painelLogin.Visible = false;
            //Reseta o formulario de cadastro
            txtNomeUsuario.Text = "";
            txtCPFusuario.Text = "";
            txtEmailUsuario.Text = "";
            txtSenhaUsuario.Text = "";
            txtSenhaUsuarioRepetir.Text = "";
            AvisoCadastro.Text = "";

        }

        private void btnVoltarCadastro_Click(object sender, EventArgs e)
        {

            painelLogin.Visible = true;
            painelCadastro.Visible = false;

        }


        private void produtosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            painelProdutos.Visible = false;
            painelProdutosLista.Visible = true;
            painelVendas.Visible = false;
            painelRelatorio.Visible = false;
            //Formatar a tabela de produtos
            fm.AdicionarColunasListView(listViewProdutos, 1, emailLogin);

        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Top = 0; 
            this.Left = 0;

            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;




        }

        //BOTAO SAIR, DEIXANDO TODAS AS TELAS OCULTAS
        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            painelLogin.Visible = true;
            painelDash2.Visible = false;
            painelVendas.Visible = false;
            painelProdutos.Visible = false;
            painelProdutosLista.Visible = false;
            cbestacao.SelectedIndex = -1;
            cbRegiao.SelectedIndex = -1;
            lbPlantioSugerido.Text = "";
            chart1.Visible = false;
        }

        private void vendasToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            painelVendas.Visible = true;
            painelProdutos.Visible = false;
            painelProdutosLista.Visible = false;
            painelRelatorio.Visible = false;
            //FORMATAR A TABELA DE VENDAS
            fm.AdicionarColunasListView(listViewpv2, 3, emailLogin);
            

        }

       

        /// <summary>
        /// /GERAÇão de grafico
        /// 
        /// </summary>
        private void GerarGrafico(int ano, int mes)
        {
            var vendas = new Vendas();
            var lista = vendas.VendasMensais(ano, mes, emailLogin);  // Buscar dados filtrados pelo mês

            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Legends.Clear();
            chart1.Annotations.Clear();

            // Título do Gráfico
            var titulo = new Title();
            titulo.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            chart1.Titles.Add(titulo);

            if (lista == null || lista.Count == 0)
            {
                // Se não houver dados, exibir mensagem no gráfico
                titulo.Text = "Não há dados disponíveis para o período selecionado.";

                chart1.Series.Add("Vazio");
                chart1.Series[0].Points.AddXY("", 0);
                chart1.Series[0].IsVisibleInLegend = false; 
                
                return;
            }
            var setores = vendas.getNomeSetores(lista);
            var valores = vendas.getValoresSetores(lista);

            chart1.Series.Clear();  // Limpa os dados do gráfico

            // Titulo do Grafico 
           
            titulo.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            titulo.Text = "Vendas de " + new DateTime(ano, mes, 1).ToString("MMMM yyyy");
            chart1.Titles.Clear();
            chart1.Titles.Add(titulo);


            //Legendas
            chart1.Legends.Clear();
            chart1.Legends.Add("Legenda");
            chart1.Legends[0].Title = "Categoria";

            chart1.Series.Add("Vendas");
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            //mostrar valores sobre as fatias da pizza
            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.Series[0].Label = "#VALY{C0}";
            chart1.Series[0].Points.DataBindXY(setores, valores);
            for (int i = 0; i < setores.Length; i++)
            {
                chart1.Series[0].Points[i].LegendText = setores[i]; // Definir o nome da categoria na legenda
            }
            //Deixa o grafico 3d
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            chart1.ChartAreas[0].Area3DStyle.Inclination = 30;
            
        
    }

        private void RelatoriovendasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            

        }


        // MENU COM IMAGEM
        public class CustomToolStripRenderer : ToolStripProfessionalRenderer
        {
            // Sobrescreve a renderização do item de menu para aplicar uma imagem de fundo
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                // Verifica se o item atual é o que deve ter a imagem de fundo
                if (e.Item.Tag != null && e.Item.Tag.ToString() == "comImagemFundo")
                {
                    // Desenha a imagem de fundo
                    System.Drawing.Image backgroundImage = Properties.Resources.barras;
                    e.Graphics.DrawImage(backgroundImage, e.Item.ContentRectangle);

                    // Desenha o texto do item
                    TextRenderer.DrawText(e.Graphics, e.Item.Text, e.Item.Font, e.Item.ContentRectangle, e.Item.ForeColor);

                    // Previne a renderização padrão
                    return;
                }

                // Se não for o item com imagem de fundo, usa a renderização padrão
                base.OnRenderMenuItemBackground(e);
            }
        }

        
        //CADASTRAR USUARIO NOVO
        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            DateTime dataNascimento = dtNascimentoUsu.Value;
            DateTime dataMinima = DateTime.Today.AddYears(-18);
            //VERIFICAR A IDADE
            if (dataNascimento > dataMinima)
            {
                MessageBox.Show("Você precisa ter pelo menos 18 anos. Data inválida, tente novamente.");
                return;
            }
            //VERIFICAR SE TODOS OS CAMPOS ESTÃO PREENCHIDOS
            List<Control> camposFormUsuario = new List<Control> {txtNomeUsuario, txtCPFusuario, txtEmailUsuario, txtSenhaUsuario, txtTelefoneUsuario, txtSenhaUsuarioRepetir};

            //verificar senhas iguais
            if (fm.VerificarCamposPreenchidos(camposFormUsuario)){ 
                if(!(txtSenhaUsuario.Text == txtSenhaUsuarioRepetir.Text))
                {
                    MessageBox.Show("As senhas não coincidem");
                    return;
                }
                //tira pontos do cpf
                string cpf = txtCPFusuario.Text;
                string cpfFormatado = cpf.Replace(".", "").Replace("-", "");
                string telefoneFormatado = txtTelefoneUsuario.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
                //VERIFICAR USUARIO JÁ CADASTRADO E INSERIR ELE
                if (fm.VerificarUsuarioExistente(txtCPFusuario.Text)){
                    bool usuarioCadastro = fm.InserirUsuario(txtNomeUsuario.Text, cpfFormatado, txtEmailUsuario.Text, txtSenhaUsuario.Text, dataNascimento, telefoneFormatado);
                    if (usuarioCadastro)
                    {
                        MessageBox.Show("Usuario Cadastrado com sucesso");
                        painelCadastroUsuario.Visible = false;
                        painelFazendaCadastro.Visible = true;
                        txtDescriFazenda.Text = txtExemploDesc;
                        txtDescriFazenda.ForeColor = Color.Gray;
                    }
                }
           
            }

        }


        //MUDAR FORMULARIO
        private async void txtCep_Leave(object sender, EventArgs e)
        {
            // Pegar o valor do CEP digitado
            string cep = txtCepFazenda.Text;

            if (!string.IsNullOrWhiteSpace(cep) && cep.Length == 8)
            {
                try
                {
                    // Chamar a API do ViaCEP
                    using (HttpClient client = new HttpClient())
                    {
                        string url = $"https://viacep.com.br/ws/{cep}/json/";
                        HttpResponseMessage response = await client.GetAsync(url);

                        if (response.IsSuccessStatusCode)
                        {
                            string jsonResult = await response.Content.ReadAsStringAsync();

                            // separar a resposta JSON
                            Endereco endereco = JsonConvert.DeserializeObject<Endereco>(jsonResult);

                            // Preencher os campos do formulário
                            txtRuaFazenda.Text = endereco.logradouro;
                            txtUfFazenda.Text = endereco.uf;
                            txtRuaFazenda.Enabled = false;
                            txtUfFazenda.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("CEP não encontrado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao buscar CEP: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um CEP válido.");
            }
        }
        //BOTAO DE CADASTRAR NOVA FAZENDA
        private void btnCadastrarFazenda_Click(object sender, EventArgs e)
        {

            List<Control> camposFormFazenda = new List<Control> { txtNomeFazenda, txtEmailFazenda, txtRuaFazenda, txtNúmeroCasaFazenda, txtCepFazenda, txtUfFazenda, txtDescriFazenda };

            //INSERI FAZENDA
            if (fm.VerificarCamposPreenchidos(camposFormFazenda)) {
                string cpf = txtCPFusuario.Text;
                string cpfFormatado = cpf.Replace(".", "").Replace("-", "");
                bool fazendaCadastro = fm.InserirFazenda(txtNomeFazenda.Text, txtEmailFazenda.Text, txtRuaFazenda.Text, txtNúmeroCasaFazenda.Text, txtCepFazenda.Text, txtUfFazenda.Text, cpfFormatado, txtDescriFazenda.Text);


            if (fazendaCadastro)
            {
                MessageBox.Show("Fazenda Cadastrada com Sucesso");

                painelLogin.Visible = true;
                painelCadastro.Visible = false;
            }
            }


        }

        //METODO PARA PEGAR O PAINEL PARA TRANSFORMAR EM PDF / PNG
        private Bitmap CapturarPainel(Panel painel)
        {
            Bitmap bitmap = new Bitmap(painel.Width, painel.Height);
            painel.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, painel.Width, painel.Height));
            return bitmap;
        }



        //CHAMADA DE METODOS PARA IMPEDIR NUMEROS OU LETRAS EM FORMULARIOS ESPECIFICOS EX: TELEFONE, CPF, ETC.
        private void txtNomeUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            impedirNumero(e);
        }
        private void txtNomeUsuario_TextChanged(object sender, EventArgs e)
        {
            txtNomeUsuario.Text = RemoveNumeros(txtNomeUsuario.Text);
        }

        private void txtTelefoneUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            impedirLetra(e);
        }


        private void txtQuantidadeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            impedirLetra(e);
                
               
            }
        

        private void txtValorProduto_TextChanged(object sender, EventArgs e)
        {
            formatMoeda(txtValorProduto);
            
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            if(painelAdicionarProduto.Visible == true)
            {
                return;
            }
            painelAdicionarProduto.Visible = true;
            //POPULAR O COMBOBOX COM AS CATEGORIAS
            fm.CarregarCategoriasNoComboBox(cbCategoria);

        }

        private void btnCancelarProduto_Click(object sender, EventArgs e)
        {
            txtNomeProduto.Clear();
            txtValorProduto.Clear();
            txtQuantidadeProduto.Clear();
            cbCategoria.SelectedIndex = -1;
            painelAdicionarProduto.Visible = false;


        }
        //ADICIONAR PRODUTO
        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            //VERIFICAR SE OS FORMULARIO ESTÁ PREENCHIDO
            if (string.IsNullOrWhiteSpace(txtNomeProduto.Text) ||
       string.IsNullOrWhiteSpace(txtValorProduto.Text) ||
       string.IsNullOrWhiteSpace(txtQuantidadeProduto.Text) ||
       cbCategoria.SelectedIndex == -1) 
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de adicionar o produto.");
                return; 
            }
            int cbc = cbCategoria.SelectedIndex;
          //ENCONTRAR O CPF DO USUARIO
            String cpfUsu = fm.EncontrarcpfUsuario(emailLogin);
            //INSERIR PRODUTO
            bool sucesso = fm.InserirProduto(txtNomeProduto.Text, txtValorProduto.Text, txtQuantidadeProduto.Text, (cbc + 1), cpfUsu);
            if (sucesso)
            {
                //RESETAR O FORMULARIO
                txtNomeProduto.Clear();
                txtValorProduto.Clear();
                txtQuantidadeProduto.Clear();
                cbCategoria.SelectedIndex = -1;
                fm.AjustarColunasListView(listViewProdutos, 1, emailLogin);
                MessageBox.Show("Produto Cadastrado com Sucesso");
            }

            
        }

        //CHAMA ALTERAR PRODUTO
        private void btnAlterarProduto_Click(object sender, EventArgs e)
        {
            if (painelAdicionarProduto.Visible == true && painelAlterarProduto.Visible ==  true)
            {
                return;
            }
            painelAdicionarProduto.Visible = true;
            painelAlterarProduto.Visible = true;
           
            //CHAMADA DE 4 METODOS (ENCONTRAR O CPF DO USUARIO -> PARA ENCONTRA O ID DA FAZENDA -> CARREGAR CATEGORIAS NO COMBOBOX E POR FIM CARREGAR PRODUTOS DA FAZENDA(ID) EM OUTRA COMBOBOX.
            String idUsuAtual = fm.EncontrarcpfUsuario(emailLogin);
            int idFazenda = fm.EncontrarIDFazenda(idUsuAtual);
            fm.CarregarCategoriasNoComboBox(cbAlterarCategoria);
            fm.CarregarProdutosNoComboBox(cbAlterarProduto, idFazenda);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //RESETA FORMULARIO
            painelAlterarProduto.Visible = false;
            painelAdicionarProduto.Visible = false;
            txtANP.Clear();
            txtAQP.Clear();
            txtAVP.Clear();
            cbAlterarCategoria.SelectedIndex = -1;
            cbAlterarProduto.SelectedIndex = -1;
        }

        //aLTERAR PRODUTO
        private void btnUpdateProduto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtANP.Text) ||
       string.IsNullOrWhiteSpace(txtAVP.Text) ||
       string.IsNullOrWhiteSpace(txtAQP.Text) ||
       cbAlterarCategoria.SelectedIndex == -1 || cbAlterarProduto.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de alterar o produto.");
                return;
            }

            ProdutoComboBoxItem selectedItem = (ProdutoComboBoxItem)cbAlterarProduto.SelectedItem;
            int idProduto = selectedItem.Id;
           
            String idUsuAtual = fm.EncontrarcpfUsuario(emailLogin);
            int idFazenda = fm.EncontrarIDFazenda(idUsuAtual);
            int cbc = cbAlterarCategoria.SelectedIndex;

            bool sucesso = fm.AlterarProduto(txtANP.Text, txtAQP.Text, txtAVP.Text, (cbc+1),idFazenda, idProduto);

            if (sucesso)
            {
                txtANP.Clear();
                txtAQP.Clear();
                txtAVP.Clear();
                cbAlterarCategoria.SelectedIndex = -1;
                cbAlterarProduto.SelectedIndex = -1;
                fm.AjustarColunasListView(listViewProdutos, 1, emailLogin);
                MessageBox.Show("Produto Alterado com Sucesso");
            }
        }

        private void txtAVP_TextChanged(object sender, EventArgs e)
        {
            formatMoeda(txtAVP);
        }

        //METODO PARA FORMATAÇÃO DE MOEDA PARA CAMPOS QUE ENVOLVAM DINHEIRO
        public void formatMoeda(System.Windows.Forms.TextBox valorProduto)
        {
            string valor = valorProduto.Text.Replace("R$", "").Replace(",", "").Replace(".", "").TrimStart('0');


            if (decimal.TryParse(valor, out decimal valorNumerico))
            {

                valorNumerico /= 100;

                valorProduto.TextChanged -= txtAVP_TextChanged; 
                valorProduto.Text = string.Format("{0:C2}", valorNumerico);
                valorProduto.TextChanged += txtAVP_TextChanged;
                
                valorProduto.SelectionStart = valorProduto.Text.Length;
            }
        }

       
        //EXCLUIR PRODUTO
        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            
           
            String idUsuAtual = fm.EncontrarcpfUsuario(emailLogin);    
            int idFazenda = fm.EncontrarIDFazenda(idUsuAtual);
            if (listViewProdutos.SelectedItems.Count > 0)
            {
              
                ListViewItem selectedItem = listViewProdutos.SelectedItems[0];

               //CONFIRMAÇÃO DA EXCLUSÃO
                int idProduto = (int)selectedItem.Tag;
                DialogResult result = MessageBox.Show("Você tem certeza que deseja excluir este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool sucesso = fm.ExcluirProduto(idFazenda, idProduto);

                    if (sucesso)
                    {
                        MessageBox.Show("Produto excluído com sucesso.");
                        listViewProdutos.Items.Remove(selectedItem);
                    }
                   
                }
              
            }
            else
            {
                MessageBox.Show("Selecione um produto para excluir.");
            }
        }
        //COMBOBOX DE PRODUTOS PARA O ALTERAR PRODUTO
        private void cbAlterarProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProdutoComboBoxItem selectedItem = (ProdutoComboBoxItem)cbAlterarProduto.SelectedItem;
            if (selectedItem != null)
            {
                int idProduto = selectedItem.Id;
               
                String idUsuAtual = fm.EncontrarcpfUsuario(emailLogin);
                int idFazenda = fm.EncontrarIDFazenda(idUsuAtual);
                ProdutoComboBoxItem produtoDetalhes = fm.CarregarProdutosDetalhes(idFazenda, idProduto);

                
                
                
                txtANP.Text = produtoDetalhes.Nome;
                txtAVP.TextChanged -= txtAVP_TextChanged;
                txtAVP.Text = decimal.Parse(produtoDetalhes.Valor).ToString("C2");
                txtAVP.TextChanged += txtAVP_TextChanged;
                txtAQP.Text = produtoDetalhes.Qtde.ToString();
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //CHAMADA DO ADICIONAR VENDA
        private void btnAdicionarVenda_Click(object sender, EventArgs e)
        {
            if(painelAlterarProduto.Visible == true)
            {
                return;
            }
            painelAdicionarVenda.Visible = true;
            listViewPV.Items.Clear();
            
             String idUsuAtual = fm.EncontrarcpfUsuario(emailLogin);
            vendaAtual = fm.RealizarVenda(idUsuAtual);
            fm.AdicionarColunasListView(listViewPV, 2, emailLogin);
            

        }
        //BOTAO DE CANCELAR VENDA
        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            painelAdicionarVenda.Visible = false;
            painelAPAV.Visible = false;
            listViewPV.Items.Clear();
            //METODO EXCLUIR VENDAS VAZIAS 
            fm.ExcluirVendasVazias();
        }

        //cHAMADA DE PRODUTOS NA VENDA
        private void btnAddProdutoVenda_Click(object sender, EventArgs e)
        {
            painelAPAV.Visible = true;
            
            String idUsuAtual = fm.EncontrarcpfUsuario(emailLogin);    
            int idFazenda = fm.EncontrarIDFazenda(idUsuAtual);

            fm.CarregarProdutosNoComboBox(cbAPAV, idFazenda);

        }

        private void btnCAPAV_Click(object sender, EventArgs e)
        {
            painelAPAV.Visible = false;
            


        }

        //CHAMADA DO METODO DE ADICIONAR ITEM A VENDA
        private void btnAddAPAV_Click(object sender, EventArgs e)
        {
            ProdutoComboBoxItem selectedItem = (ProdutoComboBoxItem)cbAPAV.SelectedItem;
            int idProduto = selectedItem.Id;

            bool sucesso  = fm.AdicionarItemVenda(vendaAtual, idProduto, (int)nbAQAV.Value);
            if (sucesso)
            {
                painelAPAV.Visible = false;
                cbAPAV.SelectedIndex = -1;
                fm.AjustarColunasListView(listViewPV, 2, emailLogin);

            }
        }

       
        //FINALIZAR VENDA
        private void btnAddVenda_Click(object sender, EventArgs e)
        {
            int situacaoVenda = 0;
            if (RBSVF.Checked)
            {
                situacaoVenda = 1; 
            }
            else if (RBSVP.Checked)
            {
                situacaoVenda = 0; 
            }
         


            bool sucesso = fm.FinalizarVenda(vendaAtual, situacaoVenda);
            if (sucesso)
            {
                MessageBox.Show("Venda Cadastrada com sucesso");
                painelAdicionarVenda.Visible = false;
                fm.AjustarColunasListView(listViewpv2, 3, emailLogin);

            }
        }

        //CHAMADA PARA QUANDO CLICAR EM UMA VENDA APARECE OS DETALHES
        private void listViewpv2_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listViewpv2.SelectedItems.Count > 0) 
            {
                ListViewItem selectedItem = listViewpv2.SelectedItems[0];
                string idVenda = selectedItem.SubItems[0].Text;
                List<ProdutoVenda> produtosVenda = fm.CarregarProdutosVendas(idVenda);

                string mensagem = $"Venda ID: {idVenda}\n\nProdutos:\n";

                foreach (var produto in produtosVenda)
                {
                    mensagem += $"{produto.Nome}: {produto.Qtde} unidades / {produto.SubTotal:F2}\n";
                }
               
                MessageBox.Show(mensagem, "Detalhes da Venda", MessageBoxButtons.OK);
            }
        }

        //EXCLUIR VENDA
        private void btnExcluirVenda_Click(object sender, EventArgs e)
        {
            if (listViewpv2.SelectedItems.Count > 0)
            {

                ListViewItem selectedItem = listViewpv2.SelectedItems[0];
                int idVenda = Convert.ToInt32(selectedItem.SubItems[0].Text);
                //cONFIRMAÇÃO DA EXCLUSAO 
                DialogResult result = MessageBox.Show("Você tem certeza que deseja excluir esta venda?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool sucesso = fm.ExcluirVenda(idVenda);

                    if (sucesso)
                    {
                        MessageBox.Show("Venda excluída com sucesso.");
                        listViewpv2.Items.Remove(selectedItem);
                    }

                }

            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
            painelVendas.Visible = false;
            painelProdutosLista.Visible = false;
            painelProdutos.Visible = true;
            painelRelatorio.Visible = false;

        }

        private void btnAlterarVenda_Click(object sender, EventArgs e)
        {

        }

        //CHAMADA AO CLICAR NO BOTAO PESQUISAR (DA TELA INICIAL) ONDE ELE LERÁ UM TXT COM AS SUGESTÕES.
        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                // Verifica se os valores dos ComboBox estão selecionados
                if (cbestacao.SelectedItem == null || cbRegiao.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecione uma estação e uma região.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //CHAMADA PARA PEGAR O ENDEREÇO DO TXT
                string caminhoAtual = Directory.GetCurrentDirectory();
                string diretorioProjeto = Directory.GetParent(caminhoAtual).Parent.FullName;
                string sugestao = $" Recomendado para a Região {cbRegiao.SelectedItem.ToString()} na estação {cbestacao.SelectedItem.ToString()}.\n";

                string caminhoArquivo = Path.Combine(diretorioProjeto, "PlantioSugestao.txt");
               
                fm.CarregarSugestoesDePlantio(caminhoArquivo);
                


                lbPlantioSugerido.Text = sugestao + fm.ObterSugestaoPlantio(cbestacao.SelectedItem.ToString(), cbRegiao.SelectedItem.ToString());

            }catch (Exception ex)
            {
                
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtGrafico_ValueChanged(object sender, EventArgs e)
        {
            int anoG = dtGrafico.Value.Year;
            int mesG = dtGrafico.Value.Month;
            chart1.Visible = true;
            lbProdutosVendidosMes.Text = fm.qtdeProdVenMes(mesG, anoG, emailLogin) + "\nProdutos";
            string vm = fm.qtdeVenMes(mesG, anoG, emailLogin);
            if (decimal.TryParse(vm, out decimal valorDecimal))
            {
               
                LBVendasMes.Text = valorDecimal.ToString("C", new CultureInfo("pt-BR"));
            }
           
               
          
            GerarGrafico(anoG, mesG);
            fm.TopVendas(emailLogin, lvVMLM, mesG, anoG);
           
        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            painelVendas.Visible = false;
            painelProdutosLista.Visible = false;
            painelProdutos.Visible = false;
            painelRelatorio.Visible = true;

            fm.AdicionarColunasListView(lvPMV, 4, emailLogin);
        }

        //Metodo para salvar o relatorio em pdf

        private void salvarRelatorio_Click(object sender, EventArgs e)
        {
            string caminhoAtual = Directory.GetCurrentDirectory();
            string diretorioProjeto = Directory.GetParent(caminhoAtual).Parent.FullName;
            
            string caminhoPersonalizado = Path.Combine(diretorioProjeto, "Relatorio");
           
            if (!Directory.Exists(caminhoPersonalizado))
            {
                Directory.CreateDirectory(caminhoPersonalizado);
            }


            Bitmap imagemPainel = CapturarPainel(painelRelatorio);
            imagemPainel.Save(Path.Combine(caminhoPersonalizado, "Vendas do Mes.png"), ImageFormat.Png);


            // Criar documento PDF
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(Path.Combine(caminhoPersonalizado, "Vendas do Mes.pdf"), FileMode.Create));
            doc.Open();
            iTextSharp.text.Image panelImage = iTextSharp.text.Image.GetInstance(Path.Combine(caminhoPersonalizado, "Vendas do Mes.png"));

            // Ajustar o tamanho da imagem para caber no PDF, se necessário
            panelImage.ScaleToFit(500f, 500f);
            doc.Add(panelImage);

         
            doc.Close();
            MessageBox.Show("Salvo em PDF na pasta de relatórios");        }


        //CHAMADA DO BOTAO ESTATISTICAS GERAIS
        private void btnEstaGerais_Click(object sender, EventArgs e)
        {
 
            List<RelatorioGeral> relatorio = fm.CarregarRelatorioGeral(emailLogin);

            if (relatorio.Count > 0)
            {
                
                RelatorioGeral rel = relatorio[0];
                string mensagem = $"Relatório Geral da Fazenda\nNúmero de Produtos: {rel.ProC}\n" +
                                  $"Número de Vendas: {rel.VenC}\n" +
                                  $"Total das Vendas: {rel.VenS:C}\n" +  
                                  $"Total de Itens Vendidos: {rel.itensV}";
                MessageBox.Show(mensagem, "Relatório Geral", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nenhum dado encontrado!", "Relatório Geral", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       


        //METODOS DE FORMATAÇÂO PARA REMOVER OU IMPEDIR NUMEROS OU LETRAS

        private string RemoveNumeros(string texto)
        {
           
            return new string(texto.Where(c => !char.IsDigit(c)).ToArray());
        }
        private void impedirNumero(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            };

        }
        private void impedirLetra(KeyPressEventArgs e) {
         if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                  
                    e.Handled = true;
                }

        }

        //Metodos para a descrição do cadastro de fazenda
        private void txtDescriFazenda_TextChanged(object sender, EventArgs e)
        {
            if (txtDescriFazenda.Focused)
            {
                //CONTADOR DE CARACTER
                int caracteresRestantes = txtDescriFazenda.MaxLength - txtDescriFazenda.Text.Length;
                lbContador.Text = $"Caracteres restantes: {caracteresRestantes}";
            }
        }

        private void txtDescriFazenda_Enter(object sender, EventArgs e)
        {
            if (txtDescriFazenda.Text == txtExemploDesc)
            {
                txtDescriFazenda.Text = "";
                txtDescriFazenda.ForeColor = Color.Black;
            }
        }

        private void txtDescriFazenda_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescriFazenda.Text))
            {
                txtDescriFazenda.Text = txtExemploDesc;
                txtDescriFazenda.ForeColor = Color.Gray;
            }

        }


        //Formatar cpf
        private void txtCPFusuario_TextChanged(object sender, EventArgs e)
        {
            string cpf = txtCPFusuario.Text.Replace(".", "").Replace("-", "");
            if (cpf.Length <= 11)
            {
                txtCPFusuario.Text = FormatarCPF(cpf);
                txtCPFusuario.SelectionStart = txtCPFusuario.Text.Length; 
            }
        }
        
        private string FormatarCPF(string cpf)
        {
            if (cpf.Length <= 3) return cpf;
            if (cpf.Length <= 6) return $"{cpf.Substring(0, 3)}.{cpf.Substring(3)}";
            if (cpf.Length <= 9) return $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6)}";
            return $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9)}";
        }

        private void txtCPFusuario_Leave(object sender, EventArgs e)
        {
            //CHAMADA DE VALIDAÇÃO DO CPF
            if (!fm.ValidarCPF(txtCPFusuario.Text))
            {
                MessageBox.Show("CPF Inválido, por favor insira novamente");
                txtCPFusuario.Clear();
            }
        }

        //CHAMADA DA TELA DE SUPORTE
        private void suporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            painelSuporte.Visible = true;
            painelSuporte.BringToFront();

        }

        private void btnCancelarSup_Click(object sender, EventArgs e)
        {
            painelSuporte.Visible =false;
        }

        //FORMATAÇÃO DO TELEFONE
        private void txtTelefoneUsuario_TextChanged(object sender, EventArgs e)
        {
            string telefone = txtTelefoneUsuario.Text;

            telefone = telefone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

            if (telefone.Length > 11)
                telefone = telefone.Substring(0, 11);

            // Aplica a formatação (11) 99999-9999
            if (telefone.Length <= 2)
                telefone = $"({telefone}";
            else if (telefone.Length <= 7)
                telefone = $"({telefone.Substring(0, 2)}) {telefone.Substring(2)}";
            else if (telefone.Length <= 11)
                telefone = $"({telefone.Substring(0, 2)}) {telefone.Substring(2, 5)}-{telefone.Substring(7)}";

            txtTelefoneUsuario.Text = telefone;

            txtTelefoneUsuario.SelectionStart = txtTelefoneUsuario.Text.Length;
        }

        //FORMATAÇÃO DO EMAIL
        private void txtEmailUsuario_Leave(object sender, EventArgs e)
        {
            string email = txtEmailUsuario.Text;

            
            if (!email.Contains("@") || !email.EndsWith(".com"))
            {
                MessageBox.Show("Por favor, insira um e-mail válido", "Email Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmailUsuario.Focus(); 
            }
        }
    }
    
    }
    
