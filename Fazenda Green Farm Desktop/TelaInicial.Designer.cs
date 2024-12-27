using System.Windows.Forms;

namespace Fazenda4
{
    partial class TelaInicial
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.painelLogin = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.aviso = new System.Windows.Forms.Label();
            this.btnNovoCadastro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.painelCadastro = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.painelFazendaCadastro = new System.Windows.Forms.Panel();
            this.lbContador = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.txtDescriFazenda = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtUfFazenda = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNúmeroCasaFazenda = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtRuaFazenda = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCepFazenda = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEmailFazenda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNomeFazenda = new System.Windows.Forms.TextBox();
            this.btnCadastrarFazenda = new System.Windows.Forms.Button();
            this.painelCadastroUsuario = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTelefoneUsuario = new System.Windows.Forms.TextBox();
            this.dtNascimentoUsu = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.txtEmailUsuario = new System.Windows.Forms.TextBox();
            this.btnVoltarCadastro = new System.Windows.Forms.Button();
            this.txtCPFusuario = new System.Windows.Forms.TextBox();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.txtSenhaUsuarioRepetir = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.AvisoCadastro = new System.Windows.Forms.Label();
            this.painelDash2 = new System.Windows.Forms.Panel();
            this.painelVendas = new System.Windows.Forms.Panel();
            this.painelAdicionarVenda = new System.Windows.Forms.Panel();
            this.RBSVP = new System.Windows.Forms.RadioButton();
            this.RBSVF = new System.Windows.Forms.RadioButton();
            this.painelAPAV = new System.Windows.Forms.Panel();
            this.nbAQAV = new System.Windows.Forms.NumericUpDown();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.cbAPAV = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.btnCAPAV = new System.Windows.Forms.Button();
            this.btnAddAPAV = new System.Windows.Forms.Button();
            this.btnAddProdutoVenda = new System.Windows.Forms.Button();
            this.btnAddVenda = new System.Windows.Forms.Button();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.listViewPV = new System.Windows.Forms.ListView();
            this.label34 = new System.Windows.Forms.Label();
            this.btnExcluirVenda = new System.Windows.Forms.Button();
            this.Vendas = new System.Windows.Forms.Label();
            this.btnAdicionarVenda = new System.Windows.Forms.Button();
            this.listViewpv2 = new System.Windows.Forms.ListView();
            this.painelSuporte = new System.Windows.Forms.Panel();
            this.label48 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.btnCancelarSup = new System.Windows.Forms.Button();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.painelRelatorio = new System.Windows.Forms.Panel();
            this.btnEstaGerais = new System.Windows.Forms.Button();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.salvarRelatorio = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbProdutosVendidosMes = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LBVendasMes = new System.Windows.Forms.Label();
            this.dtGrafico = new System.Windows.Forms.DateTimePicker();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.lvVMLM = new System.Windows.Forms.ListView();
            this.lvPMV = new System.Windows.Forms.ListView();
            this.painelProdutos = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label38 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lbPlantioSugerido = new System.Windows.Forms.Label();
            this.lbbemvindo = new System.Windows.Forms.Label();
            this.cbestacao = new System.Windows.Forms.ComboBox();
            this.cbRegiao = new System.Windows.Forms.ComboBox();
            this.lbNF = new System.Windows.Forms.Label();
            this.lbClima = new System.Windows.Forms.Label();
            this.textSugestao = new System.Windows.Forms.Label();
            this.painelProdutosLista = new System.Windows.Forms.Panel();
            this.painelAdicionarProduto = new System.Windows.Forms.Panel();
            this.painelAlterarProduto = new System.Windows.Forms.Panel();
            this.txtANP = new System.Windows.Forms.TextBox();
            this.btnUpdateProduto = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.cbAlterarProduto = new System.Windows.Forms.ComboBox();
            this.btnCAP = new System.Windows.Forms.Button();
            this.cbAlterarCategoria = new System.Windows.Forms.ComboBox();
            this.txtAVP = new System.Windows.Forms.TextBox();
            this.txtAQP = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.btnCancelarProduto = new System.Windows.Forms.Button();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.txtQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.txtValorProduto = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.btnAlterarProduto = new System.Windows.Forms.Button();
            this.listViewProdutos = new System.Windows.Forms.ListView();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fazendaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.suporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.painelLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.painelCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.painelFazendaCadastro.SuspendLayout();
            this.painelCadastroUsuario.SuspendLayout();
            this.painelDash2.SuspendLayout();
            this.painelVendas.SuspendLayout();
            this.painelAdicionarVenda.SuspendLayout();
            this.painelAPAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbAQAV)).BeginInit();
            this.painelSuporte.SuspendLayout();
            this.painelRelatorio.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.painelProdutos.SuspendLayout();
            this.painelProdutosLista.SuspendLayout();
            this.painelAdicionarProduto.SuspendLayout();
            this.painelAlterarProduto.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelLogin
            // 
            this.painelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(238)))), ((int)(((byte)(180)))));
            this.painelLogin.Controls.Add(this.panel1);
            this.painelLogin.Controls.Add(this.pictureBox1);
            this.painelLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.painelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelLogin.Location = new System.Drawing.Point(0, 0);
            this.painelLogin.Name = "painelLogin";
            this.painelLogin.Size = new System.Drawing.Size(1350, 749);
            this.painelLogin.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel1.Controls.Add(this.aviso);
            this.panel1.Controls.Add(this.btnNovoCadastro);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnEntrar);
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(766, -16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 772);
            this.panel1.TabIndex = 1;
            // 
            // aviso
            // 
            this.aviso.AutoSize = true;
            this.aviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.aviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aviso.Location = new System.Drawing.Point(213, 441);
            this.aviso.Name = "aviso";
            this.aviso.Size = new System.Drawing.Size(13, 20);
            this.aviso.TabIndex = 9;
            this.aviso.Text = " ";
            this.aviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNovoCadastro
            // 
            this.btnNovoCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(171)))));
            this.btnNovoCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoCadastro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNovoCadastro.FlatAppearance.BorderSize = 90;
            this.btnNovoCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNovoCadastro.Location = new System.Drawing.Point(309, 497);
            this.btnNovoCadastro.Name = "btnNovoCadastro";
            this.btnNovoCadastro.Size = new System.Drawing.Size(122, 34);
            this.btnNovoCadastro.TabIndex = 7;
            this.btnNovoCadastro.Text = "NOVA CONTA";
            this.btnNovoCadastro.UseVisualStyleBackColor = false;
            this.btnNovoCadastro.Click += new System.EventHandler(this.btnNovoCadastro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 61);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(153, 400);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(298, 31);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(171)))));
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEntrar.FlatAppearance.BorderSize = 90;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEntrar.Location = new System.Drawing.Point(167, 497);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(101, 34);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.txtLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(153, 298);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(298, 31);
            this.txtLogin.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Fazenda4.Properties.Resources._DAC1ED_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(93, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(608, 530);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(63, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 35);
            this.label4.TabIndex = 45;
            this.label4.Text = "Preencha os dados para se cadastrar";
            // 
            // painelCadastro
            // 
            this.painelCadastro.BackColor = System.Drawing.Color.MediumAquamarine;
            this.painelCadastro.Controls.Add(this.pictureBox2);
            this.painelCadastro.Controls.Add(this.painelFazendaCadastro);
            this.painelCadastro.Controls.Add(this.painelCadastroUsuario);
            this.painelCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelCadastro.Location = new System.Drawing.Point(0, 0);
            this.painelCadastro.Name = "painelCadastro";
            this.painelCadastro.Size = new System.Drawing.Size(1350, 749);
            this.painelCadastro.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Fazenda4.Properties.Resources.adm__1_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(587, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(722, 691);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // painelFazendaCadastro
            // 
            this.painelFazendaCadastro.Controls.Add(this.lbContador);
            this.painelFazendaCadastro.Controls.Add(this.label99);
            this.painelFazendaCadastro.Controls.Add(this.txtDescriFazenda);
            this.painelFazendaCadastro.Controls.Add(this.label18);
            this.painelFazendaCadastro.Controls.Add(this.txtUfFazenda);
            this.painelFazendaCadastro.Controls.Add(this.label17);
            this.painelFazendaCadastro.Controls.Add(this.txtNúmeroCasaFazenda);
            this.painelFazendaCadastro.Controls.Add(this.label16);
            this.painelFazendaCadastro.Controls.Add(this.txtRuaFazenda);
            this.painelFazendaCadastro.Controls.Add(this.label15);
            this.painelFazendaCadastro.Controls.Add(this.txtCepFazenda);
            this.painelFazendaCadastro.Controls.Add(this.label14);
            this.painelFazendaCadastro.Controls.Add(this.txtEmailFazenda);
            this.painelFazendaCadastro.Controls.Add(this.label11);
            this.painelFazendaCadastro.Controls.Add(this.label12);
            this.painelFazendaCadastro.Controls.Add(this.label13);
            this.painelFazendaCadastro.Controls.Add(this.txtNomeFazenda);
            this.painelFazendaCadastro.Controls.Add(this.btnCadastrarFazenda);
            this.painelFazendaCadastro.Location = new System.Drawing.Point(0, 0);
            this.painelFazendaCadastro.Name = "painelFazendaCadastro";
            this.painelFazendaCadastro.Size = new System.Drawing.Size(587, 749);
            this.painelFazendaCadastro.TabIndex = 86;
            this.painelFazendaCadastro.Visible = false;
            // 
            // lbContador
            // 
            this.lbContador.AutoSize = true;
            this.lbContador.BackColor = System.Drawing.Color.Transparent;
            this.lbContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbContador.Location = new System.Drawing.Point(64, 614);
            this.lbContador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbContador.Name = "lbContador";
            this.lbContador.Size = new System.Drawing.Size(13, 20);
            this.lbContador.TabIndex = 102;
            this.lbContador.Text = " ";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.BackColor = System.Drawing.Color.Transparent;
            this.label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label99.Location = new System.Drawing.Point(65, 492);
            this.label99.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(409, 20);
            this.label99.TabIndex = 101;
            this.label99.Text = "DESCREVA OS PONTOS FORTES DA SUA FAZENDA";
            // 
            // txtDescriFazenda
            // 
            this.txtDescriFazenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriFazenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDescriFazenda.Location = new System.Drawing.Point(65, 514);
            this.txtDescriFazenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescriFazenda.MaxLength = 250;
            this.txtDescriFazenda.Multiline = true;
            this.txtDescriFazenda.Name = "txtDescriFazenda";
            this.txtDescriFazenda.Size = new System.Drawing.Size(240, 93);
            this.txtDescriFazenda.TabIndex = 100;
            this.txtDescriFazenda.TextChanged += new System.EventHandler(this.txtDescriFazenda_TextChanged);
            this.txtDescriFazenda.Enter += new System.EventHandler(this.txtDescriFazenda_Enter);
            this.txtDescriFazenda.Leave += new System.EventHandler(this.txtDescriFazenda_Leave);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(65, 419);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 20);
            this.label18.TabIndex = 97;
            this.label18.Text = "UF";
            // 
            // txtUfFazenda
            // 
            this.txtUfFazenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUfFazenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtUfFazenda.Location = new System.Drawing.Point(63, 444);
            this.txtUfFazenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtUfFazenda.Name = "txtUfFazenda";
            this.txtUfFazenda.Size = new System.Drawing.Size(240, 29);
            this.txtUfFazenda.TabIndex = 98;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(65, 357);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 20);
            this.label17.TabIndex = 95;
            this.label17.Text = "NÚMERO";
            // 
            // txtNúmeroCasaFazenda
            // 
            this.txtNúmeroCasaFazenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNúmeroCasaFazenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNúmeroCasaFazenda.Location = new System.Drawing.Point(63, 379);
            this.txtNúmeroCasaFazenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtNúmeroCasaFazenda.Name = "txtNúmeroCasaFazenda";
            this.txtNúmeroCasaFazenda.Size = new System.Drawing.Size(240, 29);
            this.txtNúmeroCasaFazenda.TabIndex = 96;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(65, 294);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 20);
            this.label16.TabIndex = 93;
            this.label16.Text = "RUA";
            // 
            // txtRuaFazenda
            // 
            this.txtRuaFazenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuaFazenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtRuaFazenda.Location = new System.Drawing.Point(64, 316);
            this.txtRuaFazenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtRuaFazenda.Name = "txtRuaFazenda";
            this.txtRuaFazenda.Size = new System.Drawing.Size(240, 29);
            this.txtRuaFazenda.TabIndex = 94;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(65, 235);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 20);
            this.label15.TabIndex = 91;
            this.label15.Text = "CEP";
            // 
            // txtCepFazenda
            // 
            this.txtCepFazenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCepFazenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCepFazenda.Location = new System.Drawing.Point(64, 257);
            this.txtCepFazenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtCepFazenda.Name = "txtCepFazenda";
            this.txtCepFazenda.Size = new System.Drawing.Size(240, 29);
            this.txtCepFazenda.TabIndex = 92;
            this.txtCepFazenda.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(64, 171);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 20);
            this.label14.TabIndex = 89;
            this.label14.Text = "EMAIL";
            // 
            // txtEmailFazenda
            // 
            this.txtEmailFazenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailFazenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtEmailFazenda.Location = new System.Drawing.Point(63, 193);
            this.txtEmailFazenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailFazenda.Name = "txtEmailFazenda";
            this.txtEmailFazenda.Size = new System.Drawing.Size(240, 29);
            this.txtEmailFazenda.TabIndex = 90;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(63, 64);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(301, 35);
            this.label11.TabIndex = 47;
            this.label11.Text = "Preencha os dados da sua fazenda\r\n";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.2F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(59, 37);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(290, 35);
            this.label12.TabIndex = 46;
            this.label12.Text = "Bem Vindo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(64, 111);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(163, 20);
            this.label13.TabIndex = 87;
            this.label13.Text = "NOME DA FAZENDA";
            // 
            // txtNomeFazenda
            // 
            this.txtNomeFazenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFazenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNomeFazenda.Location = new System.Drawing.Point(63, 133);
            this.txtNomeFazenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeFazenda.Name = "txtNomeFazenda";
            this.txtNomeFazenda.Size = new System.Drawing.Size(240, 29);
            this.txtNomeFazenda.TabIndex = 88;
            // 
            // btnCadastrarFazenda
            // 
            this.btnCadastrarFazenda.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrarFazenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarFazenda.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadastrarFazenda.FlatAppearance.BorderSize = 90;
            this.btnCadastrarFazenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarFazenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFazenda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrarFazenda.Location = new System.Drawing.Point(136, 639);
            this.btnCadastrarFazenda.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrarFazenda.Name = "btnCadastrarFazenda";
            this.btnCadastrarFazenda.Size = new System.Drawing.Size(97, 28);
            this.btnCadastrarFazenda.TabIndex = 99;
            this.btnCadastrarFazenda.Text = "CADASTRAR";
            this.btnCadastrarFazenda.UseVisualStyleBackColor = false;
            this.btnCadastrarFazenda.Click += new System.EventHandler(this.btnCadastrarFazenda_Click);
            // 
            // painelCadastroUsuario
            // 
            this.painelCadastroUsuario.Controls.Add(this.label20);
            this.painelCadastroUsuario.Controls.Add(this.txtTelefoneUsuario);
            this.painelCadastroUsuario.Controls.Add(this.dtNascimentoUsu);
            this.painelCadastroUsuario.Controls.Add(this.label19);
            this.painelCadastroUsuario.Controls.Add(this.label10);
            this.painelCadastroUsuario.Controls.Add(this.label4);
            this.painelCadastroUsuario.Controls.Add(this.label5);
            this.painelCadastroUsuario.Controls.Add(this.label6);
            this.painelCadastroUsuario.Controls.Add(this.label7);
            this.painelCadastroUsuario.Controls.Add(this.label8);
            this.painelCadastroUsuario.Controls.Add(this.label9);
            this.painelCadastroUsuario.Controls.Add(this.txtNomeUsuario);
            this.painelCadastroUsuario.Controls.Add(this.txtEmailUsuario);
            this.painelCadastroUsuario.Controls.Add(this.btnVoltarCadastro);
            this.painelCadastroUsuario.Controls.Add(this.txtCPFusuario);
            this.painelCadastroUsuario.Controls.Add(this.txtSenhaUsuario);
            this.painelCadastroUsuario.Controls.Add(this.txtSenhaUsuarioRepetir);
            this.painelCadastroUsuario.Controls.Add(this.btnCadastrar);
            this.painelCadastroUsuario.Controls.Add(this.AvisoCadastro);
            this.painelCadastroUsuario.Location = new System.Drawing.Point(0, 0);
            this.painelCadastroUsuario.Name = "painelCadastroUsuario";
            this.painelCadastroUsuario.Size = new System.Drawing.Size(590, 749);
            this.painelCadastroUsuario.TabIndex = 100;
            this.painelCadastroUsuario.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(58, 367);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 20);
            this.label20.TabIndex = 90;
            this.label20.Text = "TELEFONE";
            // 
            // txtTelefoneUsuario
            // 
            this.txtTelefoneUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTelefoneUsuario.Location = new System.Drawing.Point(62, 389);
            this.txtTelefoneUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefoneUsuario.MaxLength = 15;
            this.txtTelefoneUsuario.Name = "txtTelefoneUsuario";
            this.txtTelefoneUsuario.Size = new System.Drawing.Size(240, 29);
            this.txtTelefoneUsuario.TabIndex = 89;
            this.txtTelefoneUsuario.TextChanged += new System.EventHandler(this.txtTelefoneUsuario_TextChanged);
            this.txtTelefoneUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefoneUsuario_KeyPress);
            // 
            // dtNascimentoUsu
            // 
            this.dtNascimentoUsu.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNascimentoUsu.CustomFormat = "dd/mm/yyy";
            this.dtNascimentoUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNascimentoUsu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimentoUsu.Location = new System.Drawing.Point(62, 264);
            this.dtNascimentoUsu.MaxDate = new System.DateTime(2024, 11, 6, 0, 0, 0, 0);
            this.dtNascimentoUsu.Name = "dtNascimentoUsu";
            this.dtNascimentoUsu.Size = new System.Drawing.Size(240, 29);
            this.dtNascimentoUsu.TabIndex = 88;
            this.dtNascimentoUsu.Value = new System.DateTime(2024, 10, 3, 0, 0, 0, 0);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(62, 241);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(188, 20);
            this.label19.TabIndex = 87;
            this.label19.Text = "DATA DE NASCIMENTO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(62, 304);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 85;
            this.label10.Text = "EMAIL";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(59, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bem Vindo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(63, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "NOME";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(61, 176);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "CPF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(59, 430);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "SENHA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(58, 491);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "CONFIRME A SENHA";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNomeUsuario.Location = new System.Drawing.Point(62, 133);
            this.txtNomeUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(240, 29);
            this.txtNomeUsuario.TabIndex = 17;
            this.txtNomeUsuario.TextChanged += new System.EventHandler(this.txtNomeUsuario_TextChanged);
            this.txtNomeUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeUsuario_KeyPress);
            // 
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtEmailUsuario.Location = new System.Drawing.Point(62, 326);
            this.txtEmailUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.Size = new System.Drawing.Size(240, 29);
            this.txtEmailUsuario.TabIndex = 35;
            this.txtEmailUsuario.Leave += new System.EventHandler(this.txtEmailUsuario_Leave);
            // 
            // btnVoltarCadastro
            // 
            this.btnVoltarCadastro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVoltarCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltarCadastro.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVoltarCadastro.FlatAppearance.BorderSize = 90;
            this.btnVoltarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarCadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVoltarCadastro.Location = new System.Drawing.Point(190, 567);
            this.btnVoltarCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltarCadastro.Name = "btnVoltarCadastro";
            this.btnVoltarCadastro.Size = new System.Drawing.Size(97, 28);
            this.btnVoltarCadastro.TabIndex = 83;
            this.btnVoltarCadastro.Text = "VOLTAR";
            this.btnVoltarCadastro.UseVisualStyleBackColor = false;
            this.btnVoltarCadastro.Click += new System.EventHandler(this.btnVoltarCadastro_Click);
            // 
            // txtCPFusuario
            // 
            this.txtCPFusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPFusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCPFusuario.Location = new System.Drawing.Point(63, 201);
            this.txtCPFusuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtCPFusuario.MaxLength = 14;
            this.txtCPFusuario.Name = "txtCPFusuario";
            this.txtCPFusuario.Size = new System.Drawing.Size(240, 29);
            this.txtCPFusuario.TabIndex = 84;
            this.txtCPFusuario.TextChanged += new System.EventHandler(this.txtCPFusuario_TextChanged);
            this.txtCPFusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefoneUsuario_KeyPress);
            this.txtCPFusuario.Leave += new System.EventHandler(this.txtCPFusuario_Leave);
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtSenhaUsuario.Location = new System.Drawing.Point(63, 452);
            this.txtSenhaUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.Size = new System.Drawing.Size(240, 29);
            this.txtSenhaUsuario.TabIndex = 37;
            // 
            // txtSenhaUsuarioRepetir
            // 
            this.txtSenhaUsuarioRepetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaUsuarioRepetir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtSenhaUsuarioRepetir.Location = new System.Drawing.Point(62, 513);
            this.txtSenhaUsuarioRepetir.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenhaUsuarioRepetir.Name = "txtSenhaUsuarioRepetir";
            this.txtSenhaUsuarioRepetir.Size = new System.Drawing.Size(240, 29);
            this.txtSenhaUsuarioRepetir.TabIndex = 40;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadastrar.FlatAppearance.BorderSize = 90;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrar.Location = new System.Drawing.Point(77, 567);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(97, 28);
            this.btnCadastrar.TabIndex = 82;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // AvisoCadastro
            // 
            this.AvisoCadastro.AutoSize = true;
            this.AvisoCadastro.BackColor = System.Drawing.Color.Transparent;
            this.AvisoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvisoCadastro.Location = new System.Drawing.Point(103, 545);
            this.AvisoCadastro.Name = "AvisoCadastro";
            this.AvisoCadastro.Size = new System.Drawing.Size(13, 20);
            this.AvisoCadastro.TabIndex = 10;
            this.AvisoCadastro.Text = " ";
            this.AvisoCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // painelDash2
            // 
            this.painelDash2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.painelDash2.Controls.Add(this.painelVendas);
            this.painelDash2.Controls.Add(this.painelSuporte);
            this.painelDash2.Controls.Add(this.painelRelatorio);
            this.painelDash2.Controls.Add(this.painelProdutos);
            this.painelDash2.Controls.Add(this.painelProdutosLista);
            this.painelDash2.Controls.Add(this.menuStrip1);
            this.painelDash2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelDash2.Location = new System.Drawing.Point(0, 0);
            this.painelDash2.Name = "painelDash2";
            this.painelDash2.Size = new System.Drawing.Size(1350, 749);
            this.painelDash2.TabIndex = 0;
            this.painelDash2.Visible = false;
            // 
            // painelVendas
            // 
            this.painelVendas.Controls.Add(this.painelAdicionarVenda);
            this.painelVendas.Controls.Add(this.btnExcluirVenda);
            this.painelVendas.Controls.Add(this.Vendas);
            this.painelVendas.Controls.Add(this.btnAdicionarVenda);
            this.painelVendas.Controls.Add(this.listViewpv2);
            this.painelVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelVendas.Location = new System.Drawing.Point(0, 28);
            this.painelVendas.Name = "painelVendas";
            this.painelVendas.Size = new System.Drawing.Size(1350, 721);
            this.painelVendas.TabIndex = 3;
            this.painelVendas.Visible = false;
            // 
            // painelAdicionarVenda
            // 
            this.painelAdicionarVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelAdicionarVenda.Controls.Add(this.RBSVP);
            this.painelAdicionarVenda.Controls.Add(this.RBSVF);
            this.painelAdicionarVenda.Controls.Add(this.painelAPAV);
            this.painelAdicionarVenda.Controls.Add(this.btnAddProdutoVenda);
            this.painelAdicionarVenda.Controls.Add(this.btnAddVenda);
            this.painelAdicionarVenda.Controls.Add(this.btnCancelarVenda);
            this.painelAdicionarVenda.Controls.Add(this.listViewPV);
            this.painelAdicionarVenda.Controls.Add(this.label34);
            this.painelAdicionarVenda.Location = new System.Drawing.Point(339, 114);
            this.painelAdicionarVenda.Name = "painelAdicionarVenda";
            this.painelAdicionarVenda.Size = new System.Drawing.Size(574, 403);
            this.painelAdicionarVenda.TabIndex = 16;
            this.painelAdicionarVenda.Visible = false;
            // 
            // RBSVP
            // 
            this.RBSVP.AutoSize = true;
            this.RBSVP.Location = new System.Drawing.Point(86, 352);
            this.RBSVP.Name = "RBSVP";
            this.RBSVP.Size = new System.Drawing.Size(83, 20);
            this.RBSVP.TabIndex = 49;
            this.RBSVP.Text = "Pendente";
            this.RBSVP.UseVisualStyleBackColor = true;
            // 
            // RBSVF
            // 
            this.RBSVF.AutoSize = true;
            this.RBSVF.Checked = true;
            this.RBSVF.Location = new System.Drawing.Point(24, 352);
            this.RBSVF.Name = "RBSVF";
            this.RBSVF.Size = new System.Drawing.Size(55, 20);
            this.RBSVF.TabIndex = 48;
            this.RBSVF.TabStop = true;
            this.RBSVF.Text = "Feita";
            this.RBSVF.UseVisualStyleBackColor = true;
            // 
            // painelAPAV
            // 
            this.painelAPAV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelAPAV.Controls.Add(this.nbAQAV);
            this.painelAPAV.Controls.Add(this.label37);
            this.painelAPAV.Controls.Add(this.label36);
            this.painelAPAV.Controls.Add(this.cbAPAV);
            this.painelAPAV.Controls.Add(this.label35);
            this.painelAPAV.Controls.Add(this.btnCAPAV);
            this.painelAPAV.Controls.Add(this.btnAddAPAV);
            this.painelAPAV.Location = new System.Drawing.Point(-1, -1);
            this.painelAPAV.Name = "painelAPAV";
            this.painelAPAV.Size = new System.Drawing.Size(573, 243);
            this.painelAPAV.TabIndex = 47;
            this.painelAPAV.Visible = false;
            // 
            // nbAQAV
            // 
            this.nbAQAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbAQAV.Location = new System.Drawing.Point(159, 121);
            this.nbAQAV.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nbAQAV.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbAQAV.Name = "nbAQAV";
            this.nbAQAV.Size = new System.Drawing.Size(119, 26);
            this.nbAQAV.TabIndex = 53;
            this.nbAQAV.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(58, 74);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(85, 22);
            this.label37.TabIndex = 52;
            this.label37.Text = "Produto";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(26, 124);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(117, 22);
            this.label36.TabIndex = 51;
            this.label36.Text = "Quantidade";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbAPAV
            // 
            this.cbAPAV.BackColor = System.Drawing.SystemColors.Window;
            this.cbAPAV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAPAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAPAV.FormattingEnabled = true;
            this.cbAPAV.Location = new System.Drawing.Point(159, 71);
            this.cbAPAV.Name = "cbAPAV";
            this.cbAPAV.Size = new System.Drawing.Size(248, 32);
            this.cbAPAV.TabIndex = 49;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(70, 17);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(424, 34);
            this.label35.TabIndex = 48;
            this.label35.Text = "Adicione um produto a venda";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCAPAV
            // 
            this.btnCAPAV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(171)))));
            this.btnCAPAV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCAPAV.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCAPAV.FlatAppearance.BorderSize = 90;
            this.btnCAPAV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCAPAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCAPAV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCAPAV.Location = new System.Drawing.Point(458, 178);
            this.btnCAPAV.Name = "btnCAPAV";
            this.btnCAPAV.Size = new System.Drawing.Size(96, 33);
            this.btnCAPAV.TabIndex = 48;
            this.btnCAPAV.Text = "CANCELAR";
            this.btnCAPAV.UseVisualStyleBackColor = true;
            this.btnCAPAV.Click += new System.EventHandler(this.btnCAPAV_Click);
            // 
            // btnAddAPAV
            // 
            this.btnAddAPAV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(171)))));
            this.btnAddAPAV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAPAV.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddAPAV.FlatAppearance.BorderSize = 90;
            this.btnAddAPAV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAPAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAPAV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddAPAV.Location = new System.Drawing.Point(344, 178);
            this.btnAddAPAV.Name = "btnAddAPAV";
            this.btnAddAPAV.Size = new System.Drawing.Size(96, 33);
            this.btnAddAPAV.TabIndex = 46;
            this.btnAddAPAV.Text = "ADICIONAR";
            this.btnAddAPAV.UseVisualStyleBackColor = true;
            this.btnAddAPAV.Click += new System.EventHandler(this.btnAddAPAV_Click);
            // 
            // btnAddProdutoVenda
            // 
            this.btnAddProdutoVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(171)))));
            this.btnAddProdutoVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProdutoVenda.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddProdutoVenda.FlatAppearance.BorderSize = 90;
            this.btnAddProdutoVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddProdutoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProdutoVenda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddProdutoVenda.Location = new System.Drawing.Point(24, 70);
            this.btnAddProdutoVenda.Name = "btnAddProdutoVenda";
            this.btnAddProdutoVenda.Size = new System.Drawing.Size(157, 33);
            this.btnAddProdutoVenda.TabIndex = 46;
            this.btnAddProdutoVenda.Text = "ADICIONAR PRODUTO";
            this.btnAddProdutoVenda.UseVisualStyleBackColor = true;
            this.btnAddProdutoVenda.Click += new System.EventHandler(this.btnAddProdutoVenda_Click);
            // 
            // btnAddVenda
            // 
            this.btnAddVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(171)))));
            this.btnAddVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddVenda.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddVenda.FlatAppearance.BorderSize = 90;
            this.btnAddVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVenda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddVenda.Location = new System.Drawing.Point(343, 354);
            this.btnAddVenda.Name = "btnAddVenda";
            this.btnAddVenda.Size = new System.Drawing.Size(96, 33);
            this.btnAddVenda.TabIndex = 45;
            this.btnAddVenda.Text = "FINALIZAR";
            this.btnAddVenda.UseVisualStyleBackColor = true;
            this.btnAddVenda.Click += new System.EventHandler(this.btnAddVenda_Click);
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(171)))));
            this.btnCancelarVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarVenda.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelarVenda.FlatAppearance.BorderSize = 90;
            this.btnCancelarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVenda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelarVenda.Location = new System.Drawing.Point(457, 354);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(96, 33);
            this.btnCancelarVenda.TabIndex = 44;
            this.btnCancelarVenda.Text = "CANCELAR";
            this.btnCancelarVenda.UseVisualStyleBackColor = true;
            this.btnCancelarVenda.Click += new System.EventHandler(this.btnCancelarVenda_Click);
            // 
            // listViewPV
            // 
            this.listViewPV.HideSelection = false;
            this.listViewPV.Location = new System.Drawing.Point(24, 113);
            this.listViewPV.Name = "listViewPV";
            this.listViewPV.Size = new System.Drawing.Size(529, 223);
            this.listViewPV.TabIndex = 43;
            this.listViewPV.UseCompatibleStateImageBehavior = false;
            this.listViewPV.View = System.Windows.Forms.View.Details;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(172, 10);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(240, 34);
            this.label34.TabIndex = 42;
            this.label34.Text = "Adicionar Venda";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExcluirVenda
            // 
            this.btnExcluirVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(171)))));
            this.btnExcluirVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirVenda.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluirVenda.FlatAppearance.BorderSize = 90;
            this.btnExcluirVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluirVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirVenda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluirVenda.Location = new System.Drawing.Point(181, 573);
            this.btnExcluirVenda.Name = "btnExcluirVenda";
            this.btnExcluirVenda.Size = new System.Drawing.Size(75, 33);
            this.btnExcluirVenda.TabIndex = 14;
            this.btnExcluirVenda.Text = "EXCLUIR";
            this.btnExcluirVenda.UseVisualStyleBackColor = true;
            this.btnExcluirVenda.Click += new System.EventHandler(this.btnExcluirVenda_Click);
            // 
            // Vendas
            // 
            this.Vendas.AutoSize = true;
            this.Vendas.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vendas.Location = new System.Drawing.Point(596, 9);
            this.Vendas.Name = "Vendas";
            this.Vendas.Size = new System.Drawing.Size(116, 34);
            this.Vendas.TabIndex = 13;
            this.Vendas.Text = "Vendas";
            this.Vendas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdicionarVenda
            // 
            this.btnAdicionarVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(171)))));
            this.btnAdicionarVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarVenda.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdicionarVenda.FlatAppearance.BorderSize = 90;
            this.btnAdicionarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarVenda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdicionarVenda.Location = new System.Drawing.Point(64, 573);
            this.btnAdicionarVenda.Name = "btnAdicionarVenda";
            this.btnAdicionarVenda.Size = new System.Drawing.Size(86, 33);
            this.btnAdicionarVenda.TabIndex = 11;
            this.btnAdicionarVenda.Text = "ADICIONAR";
            this.btnAdicionarVenda.UseVisualStyleBackColor = true;
            this.btnAdicionarVenda.Click += new System.EventHandler(this.btnAdicionarVenda_Click);
            // 
            // listViewpv2
            // 
            this.listViewpv2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewpv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewpv2.HideSelection = false;
            this.listViewpv2.Location = new System.Drawing.Point(12, 54);
            this.listViewpv2.Name = "listViewpv2";
            this.listViewpv2.Size = new System.Drawing.Size(1326, 502);
            this.listViewpv2.TabIndex = 12;
            this.listViewpv2.UseCompatibleStateImageBehavior = false;
            this.listViewpv2.View = System.Windows.Forms.View.Details;
            this.listViewpv2.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewpv2_ItemSelectionChanged);
            // 
            // painelSuporte
            // 
            this.painelSuporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelSuporte.Controls.Add(this.label48);
            this.painelSuporte.Controls.Add(this.label45);
            this.painelSuporte.Controls.Add(this.label43);
            this.painelSuporte.Controls.Add(this.label44);
            this.painelSuporte.Controls.Add(this.btnCancelarSup);
            this.painelSuporte.Controls.Add(this.label46);
            this.painelSuporte.Controls.Add(this.label47);
            this.painelSuporte.Location = new System.Drawing.Point(61, 93);
            this.painelSuporte.Name = "painelSuporte";
            this.painelSuporte.Size = new System.Drawing.Size(572, 279);
            this.painelSuporte.TabIndex = 40;
            this.painelSuporte.Visible = false;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(201, 156);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(153, 22);
            this.label48.TabIndex = 44;
            this.label48.Text = "(11) 91233-2123";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(181, 115);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(245, 22);
            this.label45.TabIndex = 43;
            this.label45.Text = " GreenFarms@gmail.com";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(42, 50);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(506, 44);
            this.label43.TabIndex = 42;
            this.label43.Text = "Entre em contato com nossos meios de comunicação\r\npara melhor suporte";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(225, 7);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(125, 34);
            this.label44.TabIndex = 41;
            this.label44.Text = "Suporte";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelarSup
            // 
            this.btnCancelarSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(171)))));
            this.btnCancelarSup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarSup.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelarSup.FlatAppearance.BorderSize = 90;
            this.btnCancelarSup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarSup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelarSup.Location = new System.Drawing.Point(231, 219);
            this.btnCancelarSup.Name = "btnCancelarSup";
            this.btnCancelarSup.Size = new System.Drawing.Size(96, 33);
            this.btnCancelarSup.TabIndex = 41;
            this.btnCancelarSup.Text = "CANCELAR";
            this.btnCancelarSup.UseVisualStyleBackColor = true;
            this.btnCancelarSup.Click += new System.EventHandler(this.btnCancelarSup_Click);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(98, 156);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(97, 22);
            this.label46.TabIndex = 41;
            this.label46.Text = "Telefone:";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(98, 115);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(68, 22);
            this.label47.TabIndex = 41;
            this.label47.Text = "Email:";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // painelRelatorio
            // 
            this.painelRelatorio.Controls.Add(this.btnEstaGerais);
            this.painelRelatorio.Controls.Add(this.label42);
            this.painelRelatorio.Controls.Add(this.label41);
            this.painelRelatorio.Controls.Add(this.salvarRelatorio);
            this.painelRelatorio.Controls.Add(this.panel4);
            this.painelRelatorio.Controls.Add(this.panel3);
            this.painelRelatorio.Controls.Add(this.panel2);
            this.painelRelatorio.Controls.Add(this.dtGrafico);
            this.painelRelatorio.Controls.Add(this.label40);
            this.painelRelatorio.Controls.Add(this.label39);
            this.painelRelatorio.Controls.Add(this.lvVMLM);
            this.painelRelatorio.Controls.Add(this.lvPMV);
            this.painelRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painelRelatorio.Location = new System.Drawing.Point(0, 28);
            this.painelRelatorio.Name = "painelRelatorio";
            this.painelRelatorio.Size = new System.Drawing.Size(1350, 721);
            this.painelRelatorio.TabIndex = 1;
            this.painelRelatorio.Visible = false;
            // 
            // btnEstaGerais
            // 
            this.btnEstaGerais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(171)))));
            this.btnEstaGerais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstaGerais.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEstaGerais.FlatAppearance.BorderSize = 90;
            this.btnEstaGerais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEstaGerais.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstaGerais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEstaGerais.Location = new System.Drawing.Point(416, 54);
            this.btnEstaGerais.Name = "btnEstaGerais";
            this.btnEstaGerais.Size = new System.Drawing.Size(157, 26);
            this.btnEstaGerais.TabIndex = 50;
            this.btnEstaGerais.Text = "ESTATÍSTICAS GERAIS";
            this.btnEstaGerais.UseVisualStyleBackColor = true;
            this.btnEstaGerais.Click += new System.EventHandler(this.btnEstaGerais_Click);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(27, 102);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(119, 20);
            this.label42.TabIndex = 49;
            this.label42.Text = "Total de Ganho";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(387, 102);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(205, 20);
            this.label41.TabIndex = 48;
            this.label41.Text = "Total de Produtos Vendidos";
            // 
            // salvarRelatorio
            // 
            this.salvarRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(171)))));
            this.salvarRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salvarRelatorio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.salvarRelatorio.FlatAppearance.BorderSize = 90;
            this.salvarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salvarRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarRelatorio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salvarRelatorio.Location = new System.Drawing.Point(246, 54);
            this.salvarRelatorio.Name = "salvarRelatorio";
            this.salvarRelatorio.Size = new System.Drawing.Size(157, 26);
            this.salvarRelatorio.TabIndex = 47;
            this.salvarRelatorio.Text = "SALVAR RELATORIO";
            this.salvarRelatorio.UseVisualStyleBackColor = true;
            this.salvarRelatorio.Click += new System.EventHandler(this.salvarRelatorio_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.chart1);
            this.panel4.Location = new System.Drawing.Point(28, 393);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(691, 248);
            this.panel4.TabIndex = 10;
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.chart1.Size = new System.Drawing.Size(683, 240);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "asda";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbProdutosVendidosMes);
            this.panel3.Location = new System.Drawing.Point(391, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 213);
            this.panel3.TabIndex = 9;
            // 
            // lbProdutosVendidosMes
            // 
            this.lbProdutosVendidosMes.AutoSize = true;
            this.lbProdutosVendidosMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProdutosVendidosMes.Location = new System.Drawing.Point(101, 76);
            this.lbProdutosVendidosMes.Name = "lbProdutosVendidosMes";
            this.lbProdutosVendidosMes.Size = new System.Drawing.Size(21, 31);
            this.lbProdutosVendidosMes.TabIndex = 1;
            this.lbProdutosVendidosMes.Text = " ";
            this.lbProdutosVendidosMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LBVendasMes);
            this.panel2.Location = new System.Drawing.Point(28, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 213);
            this.panel2.TabIndex = 8;
            // 
            // LBVendasMes
            // 
            this.LBVendasMes.AutoSize = true;
            this.LBVendasMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBVendasMes.Location = new System.Drawing.Point(37, 86);
            this.LBVendasMes.Name = "LBVendasMes";
            this.LBVendasMes.Size = new System.Drawing.Size(21, 31);
            this.LBVendasMes.TabIndex = 2;
            this.LBVendasMes.Text = " ";
            // 
            // dtGrafico
            // 
            this.dtGrafico.CustomFormat = "MMMM / yyyy";
            this.dtGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGrafico.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtGrafico.Location = new System.Drawing.Point(28, 54);
            this.dtGrafico.Name = "dtGrafico";
            this.dtGrafico.Size = new System.Drawing.Size(200, 26);
            this.dtGrafico.TabIndex = 7;
            this.dtGrafico.ValueChanged += new System.EventHandler(this.dtGrafico_ValueChanged);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(769, 370);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(233, 20);
            this.label40.TabIndex = 6;
            this.label40.Text = "Vendas Mais Lucrativas do Mês";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(769, 72);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(181, 20);
            this.label39.TabIndex = 5;
            this.label39.Text = "Produtos Mais Vendidos";
            // 
            // lvVMLM
            // 
            this.lvVMLM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvVMLM.HideSelection = false;
            this.lvVMLM.Location = new System.Drawing.Point(773, 393);
            this.lvVMLM.Name = "lvVMLM";
            this.lvVMLM.Size = new System.Drawing.Size(551, 248);
            this.lvVMLM.TabIndex = 4;
            this.lvVMLM.UseCompatibleStateImageBehavior = false;
            this.lvVMLM.View = System.Windows.Forms.View.Details;
            // 
            // lvPMV
            // 
            this.lvPMV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPMV.HideSelection = false;
            this.lvPMV.Location = new System.Drawing.Point(773, 95);
            this.lvPMV.Name = "lvPMV";
            this.lvPMV.Size = new System.Drawing.Size(551, 247);
            this.lvPMV.TabIndex = 3;
            this.lvPMV.UseCompatibleStateImageBehavior = false;
            this.lvPMV.View = System.Windows.Forms.View.Details;
            // 
            // painelProdutos
            // 
            this.painelProdutos.BackgroundImage = global::Fazenda4.Properties.Resources.MarcaOpaca3;
            this.painelProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.painelProdutos.Controls.Add(this.button1);
            this.painelProdutos.Controls.Add(this.label38);
            this.painelProdutos.Controls.Add(this.label33);
            this.painelProdutos.Controls.Add(this.label29);
            this.painelProdutos.Controls.Add(this.lbPlantioSugerido);
            this.painelProdutos.Controls.Add(this.lbbemvindo);
            this.painelProdutos.Controls.Add(this.cbestacao);
            this.painelProdutos.Controls.Add(this.cbRegiao);
            this.painelProdutos.Controls.Add(this.lbNF);
            this.painelProdutos.Controls.Add(this.lbClima);
            this.painelProdutos.Controls.Add(this.textSugestao);
            this.painelProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelProdutos.Location = new System.Drawing.Point(0, 28);
            this.painelProdutos.Name = "painelProdutos";
            this.painelProdutos.Size = new System.Drawing.Size(1350, 721);
            this.painelProdutos.TabIndex = 4;
            this.painelProdutos.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(171)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 90;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(64, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "PESQUISAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(837, 210);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(68, 20);
            this.label38.TabIndex = 13;
            this.label38.Text = "Estação";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(60, 210);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(60, 20);
            this.label33.TabIndex = 12;
            this.label33.Text = "Região";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(60, 146);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(87, 20);
            this.label29.TabIndex = 11;
            this.label29.Text = "Bem Vindo";
            // 
            // lbPlantioSugerido
            // 
            this.lbPlantioSugerido.AutoSize = true;
            this.lbPlantioSugerido.BackColor = System.Drawing.Color.Transparent;
            this.lbPlantioSugerido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlantioSugerido.Location = new System.Drawing.Point(61, 356);
            this.lbPlantioSugerido.Name = "lbPlantioSugerido";
            this.lbPlantioSugerido.Size = new System.Drawing.Size(13, 20);
            this.lbPlantioSugerido.TabIndex = 10;
            this.lbPlantioSugerido.Text = " ";
            // 
            // lbbemvindo
            // 
            this.lbbemvindo.AutoSize = true;
            this.lbbemvindo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.lbbemvindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbemvindo.Location = new System.Drawing.Point(61, 169);
            this.lbbemvindo.Name = "lbbemvindo";
            this.lbbemvindo.Size = new System.Drawing.Size(643, 20);
            this.lbbemvindo.TabIndex = 9;
            this.lbbemvindo.Text = "Escolha sua região e qual estação do ano estamos para ver quais cultivos recomend" +
    "amos";
            // 
            // cbestacao
            // 
            this.cbestacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbestacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbestacao.FormattingEnabled = true;
            this.cbestacao.Items.AddRange(new object[] {
            "Primavera",
            "Verão",
            "Outono",
            "Inverno"});
            this.cbestacao.Location = new System.Drawing.Point(841, 233);
            this.cbestacao.Name = "cbestacao";
            this.cbestacao.Size = new System.Drawing.Size(415, 28);
            this.cbestacao.TabIndex = 8;
            // 
            // cbRegiao
            // 
            this.cbRegiao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRegiao.FormattingEnabled = true;
            this.cbRegiao.Items.AddRange(new object[] {
            "Norte",
            "Nordeste",
            "Centro-Oeste",
            "Sudeste",
            "Sul"});
            this.cbRegiao.Location = new System.Drawing.Point(64, 233);
            this.cbRegiao.Name = "cbRegiao";
            this.cbRegiao.Size = new System.Drawing.Size(415, 28);
            this.cbRegiao.TabIndex = 7;
            // 
            // lbNF
            // 
            this.lbNF.AutoSize = true;
            this.lbNF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNF.Location = new System.Drawing.Point(61, 36);
            this.lbNF.Name = "lbNF";
            this.lbNF.Size = new System.Drawing.Size(13, 20);
            this.lbNF.TabIndex = 6;
            this.lbNF.Text = " ";
            // 
            // lbClima
            // 
            this.lbClima.AutoSize = true;
            this.lbClima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClima.Location = new System.Drawing.Point(1072, 32);
            this.lbClima.Name = "lbClima";
            this.lbClima.Size = new System.Drawing.Size(104, 60);
            this.lbClima.TabIndex = 5;
            this.lbClima.Text = "Temperatura:\r\nClima:\r\n\r\n";
            // 
            // textSugestao
            // 
            this.textSugestao.AutoSize = true;
            this.textSugestao.Location = new System.Drawing.Point(62, 387);
            this.textSugestao.Name = "textSugestao";
            this.textSugestao.Size = new System.Drawing.Size(10, 16);
            this.textSugestao.TabIndex = 4;
            this.textSugestao.Text = " ";
            this.textSugestao.Visible = false;
            // 
            // painelProdutosLista
            // 
            this.painelProdutosLista.Controls.Add(this.painelAdicionarProduto);
            this.painelProdutosLista.Controls.Add(this.btnAlterarProduto);
            this.painelProdutosLista.Controls.Add(this.listViewProdutos);
            this.painelProdutosLista.Controls.Add(this.btnExcluirProduto);
            this.painelProdutosLista.Controls.Add(this.btnAdicionarProduto);
            this.painelProdutosLista.Controls.Add(this.label21);
            this.painelProdutosLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelProdutosLista.Location = new System.Drawing.Point(0, 28);
            this.painelProdutosLista.Name = "painelProdutosLista";
            this.painelProdutosLista.Size = new System.Drawing.Size(1350, 721);
            this.painelProdutosLista.TabIndex = 5;
            // 
            // painelAdicionarProduto
            // 
            this.painelAdicionarProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelAdicionarProduto.Controls.Add(this.painelAlterarProduto);
            this.painelAdicionarProduto.Controls.Add(this.btnCancelarProduto);
            this.painelAdicionarProduto.Controls.Add(this.cbCategoria);
            this.painelAdicionarProduto.Controls.Add(this.btnAddProduto);
            this.painelAdicionarProduto.Controls.Add(this.txtQuantidadeProduto);
            this.painelAdicionarProduto.Controls.Add(this.txtValorProduto);
            this.painelAdicionarProduto.Controls.Add(this.label26);
            this.painelAdicionarProduto.Controls.Add(this.label25);
            this.painelAdicionarProduto.Controls.Add(this.label24);
            this.painelAdicionarProduto.Controls.Add(this.label23);
            this.painelAdicionarProduto.Controls.Add(this.label22);
            this.painelAdicionarProduto.Controls.Add(this.txtNomeProduto);
            this.painelAdicionarProduto.Location = new System.Drawing.Point(339, 114);
            this.painelAdicionarProduto.Name = "painelAdicionarProduto";
            this.painelAdicionarProduto.Size = new System.Drawing.Size(574, 362);
            this.painelAdicionarProduto.TabIndex = 8;
            this.painelAdicionarProduto.Visible = false;
            // 
            // painelAlterarProduto
            // 
            this.painelAlterarProduto.Controls.Add(this.txtANP);
            this.painelAlterarProduto.Controls.Add(this.btnUpdateProduto);
            this.painelAlterarProduto.Controls.Add(this.label32);
            this.painelAlterarProduto.Controls.Add(this.label27);
            this.painelAlterarProduto.Controls.Add(this.cbAlterarProduto);
            this.painelAlterarProduto.Controls.Add(this.btnCAP);
            this.painelAlterarProduto.Controls.Add(this.cbAlterarCategoria);
            this.painelAlterarProduto.Controls.Add(this.txtAVP);
            this.painelAlterarProduto.Controls.Add(this.txtAQP);
            this.painelAlterarProduto.Controls.Add(this.label28);
            this.painelAlterarProduto.Controls.Add(this.label30);
            this.painelAlterarProduto.Controls.Add(this.label31);
            this.painelAlterarProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelAlterarProduto.Location = new System.Drawing.Point(0, 0);
            this.painelAlterarProduto.Name = "painelAlterarProduto";
            this.painelAlterarProduto.Size = new System.Drawing.Size(572, 360);
            this.painelAlterarProduto.TabIndex = 40;
            this.painelAlterarProduto.Visible = false;
            // 
            // txtANP
            // 
            this.txtANP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtANP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtANP.Location = new System.Drawing.Point(222, 84);
            this.txtANP.Margin = new System.Windows.Forms.Padding(2);
            this.txtANP.Name = "txtANP";
            this.txtANP.Size = new System.Drawing.Size(177, 29);
            this.txtANP.TabIndex = 42;
            // 
            // btnUpdateProduto
            // 
            this.btnUpdateProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(171)))));
            this.btnUpdateProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateProduto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdateProduto.FlatAppearance.BorderSize = 90;
            this.btnUpdateProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateProduto.Location = new System.Drawing.Point(121, 302);
            this.btnUpdateProduto.Name = "btnUpdateProduto";
            this.btnUpdateProduto.Size = new System.Drawing.Size(96, 33);
            this.btnUpdateProduto.TabIndex = 41;
            this.btnUpdateProduto.Text = "ALTERAR";
            this.btnUpdateProduto.UseVisualStyleBackColor = true;
            this.btnUpdateProduto.Click += new System.EventHandler(this.btnUpdateProduto_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(72, 181);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(120, 44);
            this.label32.TabIndex = 41;
            this.label32.Text = "Quantidade\r\nem Estoque";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(172, 10);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(226, 34);
            this.label27.TabIndex = 41;
            this.label27.Text = "Alterar Produto";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbAlterarProduto
            // 
            this.cbAlterarProduto.BackColor = System.Drawing.SystemColors.Window;
            this.cbAlterarProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlterarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlterarProduto.FormattingEnabled = true;
            this.cbAlterarProduto.Location = new System.Drawing.Point(159, 44);
            this.cbAlterarProduto.Name = "cbAlterarProduto";
            this.cbAlterarProduto.Size = new System.Drawing.Size(248, 32);
            this.cbAlterarProduto.TabIndex = 41;
            this.cbAlterarProduto.SelectedIndexChanged += new System.EventHandler(this.cbAlterarProduto_SelectedIndexChanged);
            // 
            // btnCAP
            // 
            this.btnCAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(171)))));
            this.btnCAP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCAP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCAP.FlatAppearance.BorderSize = 90;
            this.btnCAP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCAP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCAP.Location = new System.Drawing.Point(283, 302);
            this.btnCAP.Name = "btnCAP";
            this.btnCAP.Size = new System.Drawing.Size(96, 33);
            this.btnCAP.TabIndex = 41;
            this.btnCAP.Text = "CANCELAR";
            this.btnCAP.UseVisualStyleBackColor = true;
            this.btnCAP.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbAlterarCategoria
            // 
            this.cbAlterarCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlterarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlterarCategoria.FormattingEnabled = true;
            this.cbAlterarCategoria.Location = new System.Drawing.Point(222, 241);
            this.cbAlterarCategoria.Name = "cbAlterarCategoria";
            this.cbAlterarCategoria.Size = new System.Drawing.Size(177, 32);
            this.cbAlterarCategoria.TabIndex = 41;
            // 
            // txtAVP
            // 
            this.txtAVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAVP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAVP.Location = new System.Drawing.Point(222, 135);
            this.txtAVP.Margin = new System.Windows.Forms.Padding(2);
            this.txtAVP.Name = "txtAVP";
            this.txtAVP.Size = new System.Drawing.Size(177, 29);
            this.txtAVP.TabIndex = 41;
            this.txtAVP.TextChanged += new System.EventHandler(this.txtAVP_TextChanged);
            this.txtAVP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeProduto_KeyPress);
            // 
            // txtAQP
            // 
            this.txtAQP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAQP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAQP.Location = new System.Drawing.Point(222, 188);
            this.txtAQP.Margin = new System.Windows.Forms.Padding(2);
            this.txtAQP.Name = "txtAQP";
            this.txtAQP.Size = new System.Drawing.Size(177, 29);
            this.txtAQP.TabIndex = 41;
            this.txtAQP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeProduto_KeyPress);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(82, 246);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(100, 22);
            this.label28.TabIndex = 41;
            this.label28.Text = "Categoria";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(99, 135);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(58, 22);
            this.label30.TabIndex = 41;
            this.label30.Text = "Valor";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(98, 87);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(63, 22);
            this.label31.TabIndex = 41;
            this.label31.Text = "Nome";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelarProduto
            // 
            this.btnCancelarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(171)))));
            this.btnCancelarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarProduto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelarProduto.FlatAppearance.BorderSize = 90;
            this.btnCancelarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelarProduto.Location = new System.Drawing.Point(283, 302);
            this.btnCancelarProduto.Name = "btnCancelarProduto";
            this.btnCancelarProduto.Size = new System.Drawing.Size(96, 33);
            this.btnCancelarProduto.TabIndex = 10;
            this.btnCancelarProduto.Text = "CANCELAR";
            this.btnCancelarProduto.UseVisualStyleBackColor = true;
            this.btnCancelarProduto.Click += new System.EventHandler(this.btnCancelarProduto_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(222, 241);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(177, 32);
            this.cbCategoria.TabIndex = 39;
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(171)))));
            this.btnAddProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddProduto.FlatAppearance.BorderSize = 90;
            this.btnAddProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddProduto.Location = new System.Drawing.Point(121, 302);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(96, 33);
            this.btnAddProduto.TabIndex = 9;
            this.btnAddProduto.Text = "ADICIONAR";
            this.btnAddProduto.UseVisualStyleBackColor = true;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // txtQuantidadeProduto
            // 
            this.txtQuantidadeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtQuantidadeProduto.Location = new System.Drawing.Point(222, 188);
            this.txtQuantidadeProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantidadeProduto.Name = "txtQuantidadeProduto";
            this.txtQuantidadeProduto.Size = new System.Drawing.Size(177, 29);
            this.txtQuantidadeProduto.TabIndex = 38;
            this.txtQuantidadeProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeProduto_KeyPress);
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtValorProduto.Location = new System.Drawing.Point(222, 135);
            this.txtValorProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Size = new System.Drawing.Size(177, 29);
            this.txtValorProduto.TabIndex = 37;
            this.txtValorProduto.TextChanged += new System.EventHandler(this.txtValorProduto_TextChanged);
            this.txtValorProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeProduto_KeyPress);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(82, 246);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(100, 22);
            this.label26.TabIndex = 13;
            this.label26.Text = "Categoria";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(72, 181);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(120, 44);
            this.label25.TabIndex = 12;
            this.label25.Text = "Quantidade\r\nem Estoque";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(99, 135);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 22);
            this.label24.TabIndex = 11;
            this.label24.Text = "Valor";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(99, 88);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 22);
            this.label23.TabIndex = 10;
            this.label23.Text = "Nome";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(153, 12);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(267, 34);
            this.label22.TabIndex = 9;
            this.label22.Text = "Adicionar Produto";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNomeProduto.Location = new System.Drawing.Point(222, 87);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(177, 29);
            this.txtNomeProduto.TabIndex = 36;
            // 
            // btnAlterarProduto
            // 
            this.btnAlterarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(171)))));
            this.btnAlterarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarProduto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlterarProduto.FlatAppearance.BorderSize = 90;
            this.btnAlterarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAlterarProduto.Location = new System.Drawing.Point(280, 573);
            this.btnAlterarProduto.Name = "btnAlterarProduto";
            this.btnAlterarProduto.Size = new System.Drawing.Size(86, 33);
            this.btnAlterarProduto.TabIndex = 10;
            this.btnAlterarProduto.Text = "ALTERAR";
            this.btnAlterarProduto.UseVisualStyleBackColor = true;
            this.btnAlterarProduto.Click += new System.EventHandler(this.btnAlterarProduto_Click);
            // 
            // listViewProdutos
            // 
            this.listViewProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewProdutos.FullRowSelect = true;
            this.listViewProdutos.HideSelection = false;
            this.listViewProdutos.Location = new System.Drawing.Point(12, 54);
            this.listViewProdutos.MultiSelect = false;
            this.listViewProdutos.Name = "listViewProdutos";
            this.listViewProdutos.Size = new System.Drawing.Size(1326, 502);
            this.listViewProdutos.TabIndex = 9;
            this.listViewProdutos.UseCompatibleStateImageBehavior = false;
            this.listViewProdutos.View = System.Windows.Forms.View.Details;
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(171)))));
            this.btnExcluirProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirProduto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluirProduto.FlatAppearance.BorderSize = 90;
            this.btnExcluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluirProduto.Location = new System.Drawing.Point(181, 573);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(75, 33);
            this.btnExcluirProduto.TabIndex = 7;
            this.btnExcluirProduto.Text = "EXCLUIR";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(171)))));
            this.btnAdicionarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarProduto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdicionarProduto.FlatAppearance.BorderSize = 90;
            this.btnAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdicionarProduto.Location = new System.Drawing.Point(64, 573);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(86, 33);
            this.btnAdicionarProduto.TabIndex = 2;
            this.btnAdicionarProduto.Text = "ADICIONAR";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(596, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(143, 34);
            this.label21.TabIndex = 5;
            this.label21.Text = "Produtos";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackgroundImage = global::Fazenda4.Properties.Resources.barras;
            this.toolStripMenuItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fazendaToolStripMenuItem1,
            this.relatoriosToolStripMenuItem,
            this.vendasToolStripMenuItem3});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(29, 24);
            this.toolStripMenuItem2.Text = "  ";
            // 
            // fazendaToolStripMenuItem1
            // 
            this.fazendaToolStripMenuItem1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.fazendaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.produtosToolStripMenuItem2});
            this.fazendaToolStripMenuItem1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fazendaToolStripMenuItem1.Name = "fazendaToolStripMenuItem1";
            this.fazendaToolStripMenuItem1.Size = new System.Drawing.Size(156, 24);
            this.fazendaToolStripMenuItem1.Text = "Fazenda";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 24);
            this.toolStripMenuItem3.Text = "Home";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // produtosToolStripMenuItem2
            // 
            this.produtosToolStripMenuItem2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.produtosToolStripMenuItem2.Name = "produtosToolStripMenuItem2";
            this.produtosToolStripMenuItem2.Size = new System.Drawing.Size(149, 24);
            this.produtosToolStripMenuItem2.Text = "Produtos";
            this.produtosToolStripMenuItem2.Click += new System.EventHandler(this.produtosToolStripMenuItem2_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.relatoriosToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            this.relatoriosToolStripMenuItem.Click += new System.EventHandler(this.relatoriosToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem3
            // 
            this.vendasToolStripMenuItem3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.vendasToolStripMenuItem3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendasToolStripMenuItem3.Name = "vendasToolStripMenuItem3";
            this.vendasToolStripMenuItem3.Size = new System.Drawing.Size(156, 24);
            this.vendasToolStripMenuItem3.Text = "Vendas";
            this.vendasToolStripMenuItem3.Click += new System.EventHandler(this.vendasToolStripMenuItem3_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem1,
            this.suporteToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 24);
            this.toolStripMenuItem1.Text = "Conta";
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(139, 24);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // suporteToolStripMenuItem
            // 
            this.suporteToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.suporteToolStripMenuItem.Name = "suporteToolStripMenuItem";
            this.suporteToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.suporteToolStripMenuItem.Text = "Suporte";
            this.suporteToolStripMenuItem.Click += new System.EventHandler(this.suporteToolStripMenuItem_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1350, 749);
            this.Controls.Add(this.painelCadastro);
            this.Controls.Add(this.painelDash2);
            this.Controls.Add(this.painelLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TelaInicial";
            this.Text = "Green Farm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.painelLogin.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.painelCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.painelFazendaCadastro.ResumeLayout(false);
            this.painelFazendaCadastro.PerformLayout();
            this.painelCadastroUsuario.ResumeLayout(false);
            this.painelCadastroUsuario.PerformLayout();
            this.painelDash2.ResumeLayout(false);
            this.painelDash2.PerformLayout();
            this.painelVendas.ResumeLayout(false);
            this.painelVendas.PerformLayout();
            this.painelAdicionarVenda.ResumeLayout(false);
            this.painelAdicionarVenda.PerformLayout();
            this.painelAPAV.ResumeLayout(false);
            this.painelAPAV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbAQAV)).EndInit();
            this.painelSuporte.ResumeLayout(false);
            this.painelSuporte.PerformLayout();
            this.painelRelatorio.ResumeLayout(false);
            this.painelRelatorio.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.painelProdutos.ResumeLayout(false);
            this.painelProdutos.PerformLayout();
            this.painelProdutosLista.ResumeLayout(false);
            this.painelProdutosLista.PerformLayout();
            this.painelAdicionarProduto.ResumeLayout(false);
            this.painelAdicionarProduto.PerformLayout();
            this.painelAlterarProduto.ResumeLayout(false);
            this.painelAlterarProduto.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Panel painelLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNovoCadastro;
        private System.Windows.Forms.Panel painelCadastro;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmailUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSenhaUsuarioRepetir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltarCadastro;
        private System.Windows.Forms.Label aviso;
        private System.Windows.Forms.Panel painelProdutos;
        private System.Windows.Forms.Panel painelDash2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem fazendaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.Panel painelVendas;
        private System.Windows.Forms.Panel painelRelatorio;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label textSugestao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCPFusuario;
        private System.Windows.Forms.Label AvisoCadastro;
        private System.Windows.Forms.Panel painelFazendaCadastro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNomeFazenda;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRuaFazenda;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCepFazenda;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEmailFazenda;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtUfFazenda;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNúmeroCasaFazenda;
        private System.Windows.Forms.Button btnCadastrarFazenda;
        private System.Windows.Forms.Panel painelCadastroUsuario;
        private System.Windows.Forms.DateTimePicker dtNascimentoUsu;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTelefoneUsuario;
        private System.Windows.Forms.Panel painelProdutosLista;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private Panel painelAdicionarProduto;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label26;
        private ComboBox cbCategoria;
        private TextBox txtQuantidadeProduto;
        private TextBox txtValorProduto;
        private TextBox txtNomeProduto;
        private Button btnCancelarProduto;
        private Button btnAddProduto;
        private ListView listViewProdutos;
        private Panel painelAlterarProduto;
        private Label label27;
        private ComboBox cbAlterarProduto;
        private Button btnCAP;
        private ComboBox cbAlterarCategoria;
        private TextBox txtAVP;
        private TextBox txtAQP;
        private Label label28;
        private Label label30;
        private Label label31;
        private Label label32;
        private Button btnUpdateProduto;
        private Button btnAlterarProduto;
        private TextBox txtANP;
        private Label Vendas;
        private Button btnAdicionarVenda;
        private ListView listViewpv2;
        private Button btnExcluirVenda;
        private Panel painelAdicionarVenda;
        private Label label34;
        private ListView listViewPV;
        private Button btnAddProdutoVenda;
        private Button btnAddVenda;
        private Button btnCancelarVenda;
        private Panel painelAPAV;
        private Button btnCAPAV;
        private Button btnAddAPAV;
        private Label label35;
        private Label label37;
        private Label label36;
        private ComboBox cbAPAV;
        private NumericUpDown nbAQAV;
        private Label lbClima;
        private Label lbNF;
        private ToolStripMenuItem toolStripMenuItem3;
        private ComboBox cbestacao;
        private ComboBox cbRegiao;
        private Label lbbemvindo;
        private Label lbPlantioSugerido;
        private Label label29;
        private Label label33;
        private Label label38;
        private Button button1;
        private Label label40;
        private Label label39;
        private ListView lvVMLM;
        private ListView lvPMV;
        private DateTimePicker dtGrafico;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Label lbProdutosVendidosMes;
        private Label LBVendasMes;
        private Button salvarRelatorio;
        private Label label41;
        private Label label42;
        private Button btnEstaGerais;
        private TextBox txtDescriFazenda;
        private Label label99;
        private Label lbContador;
        private ToolStripMenuItem suporteToolStripMenuItem;
        private Panel painelSuporte;
        private Label label43;
        private Label label44;
        private Button btnCancelarSup;
        private Label label46;
        private Label label47;
        private Label label45;
        private Label label48;
        private RadioButton RBSVF;
        private RadioButton RBSVP;
    }
}

