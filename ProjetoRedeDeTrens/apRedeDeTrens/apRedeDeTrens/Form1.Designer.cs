namespace apRedeDeTrens
{
    partial class FrmMapeamentoCidades
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMapeamentoCidades));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnInicio = new System.Windows.Forms.ToolStripButton();
            this.btnAnterior = new System.Windows.Forms.ToolStripButton();
            this.btnProximo = new System.Windows.Forms.ToolStripButton();
            this.btnUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnProcurar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.udCoordenadaY = new System.Windows.Forms.NumericUpDown();
            this.udCoordenadaX = new System.Windows.Forms.NumericUpDown();
            this.lsbCidades = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCidade = new System.Windows.Forms.TextBox();
            this.pbMapa = new System.Windows.Forms.PictureBox();
            this.stMensagem = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCidades = new System.Windows.Forms.TabPage();
            this.tpCaminhos = new System.Windows.Forms.TabPage();
            this.dgvMelhorCaminho = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbMelhorCaminho = new System.Windows.Forms.Label();
            this.btnAcharCaminhos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbOrigem = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.upCusto = new System.Windows.Forms.NumericUpDown();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.upTempo = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.upDistancia = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.lbKmCaminhoSelecionado = new System.Windows.Forms.Label();
            this.dgvCaminhosEncontrados = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlgCidades = new System.Windows.Forms.OpenFileDialog();
            this.dlgCaminhos = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udCoordenadaY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCoordenadaX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).BeginInit();
            this.stMensagem.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpCidades.SuspendLayout();
            this.tpCaminhos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMelhorCaminho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upTempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDistancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaminhosEncontrados)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInicio,
            this.btnAnterior,
            this.btnProximo,
            this.btnUltimo,
            this.toolStripSeparator1,
            this.btnProcurar,
            this.toolStripSeparator2,
            this.btnNovo,
            this.btnCancelar,
            this.btnSalvar,
            this.toolStripSeparator3,
            this.btnExcluir,
            this.toolStripSeparator4,
            this.btnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1151, 53);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnInicio
            // 
            this.btnInicio.AutoSize = false;
            this.btnInicio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(50, 50);
            this.btnInicio.Text = "Início";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.AutoSize = false;
            this.btnAnterior.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(50, 50);
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.AutoSize = false;
            this.btnProximo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProximo.Image = ((System.Drawing.Image)(resources.GetObject("btnProximo.Image")));
            this.btnProximo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProximo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(50, 50);
            this.btnProximo.Text = "Próximo";
            this.btnProximo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProximo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.AutoSize = false;
            this.btnUltimo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
            this.btnUltimo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(50, 50);
            this.btnUltimo.Text = "Último";
            this.btnUltimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUltimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 53);
            // 
            // btnProcurar
            // 
            this.btnProcurar.AutoSize = false;
            this.btnProcurar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProcurar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurar.Image")));
            this.btnProcurar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProcurar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(50, 50);
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProcurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 53);
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = false;
            this.btnNovo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(50, 50);
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = false;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = false;
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(50, 50);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 53);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = false;
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(50, 50);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 53);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = false;
            this.btnSair.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 50);
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // udCoordenadaY
            // 
            this.udCoordenadaY.DecimalPlaces = 3;
            this.udCoordenadaY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.udCoordenadaY.Location = new System.Drawing.Point(154, 97);
            this.udCoordenadaY.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.udCoordenadaY.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udCoordenadaY.Name = "udCoordenadaY";
            this.udCoordenadaY.Size = new System.Drawing.Size(104, 26);
            this.udCoordenadaY.TabIndex = 8;
            // 
            // udCoordenadaX
            // 
            this.udCoordenadaX.DecimalPlaces = 3;
            this.udCoordenadaX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.udCoordenadaX.Location = new System.Drawing.Point(154, 52);
            this.udCoordenadaX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.udCoordenadaX.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udCoordenadaX.Name = "udCoordenadaX";
            this.udCoordenadaX.Size = new System.Drawing.Size(104, 26);
            this.udCoordenadaX.TabIndex = 7;
            // 
            // lsbCidades
            // 
            this.lsbCidades.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lsbCidades.FormattingEnabled = true;
            this.lsbCidades.ItemHeight = 19;
            this.lsbCidades.Location = new System.Drawing.Point(20, 142);
            this.lsbCidades.Name = "lsbCidades";
            this.lsbCidades.Size = new System.Drawing.Size(300, 251);
            this.lsbCidades.TabIndex = 6;
            this.lsbCidades.SelectedIndexChanged += new System.EventHandler(this.lsbCidades_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Coordenada Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Coordenada X: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome da cidade:";
            // 
            // txtNomeCidade
            // 
            this.txtNomeCidade.Location = new System.Drawing.Point(154, 15);
            this.txtNomeCidade.Name = "txtNomeCidade";
            this.txtNomeCidade.Size = new System.Drawing.Size(166, 26);
            this.txtNomeCidade.TabIndex = 1;
            // 
            // pbMapa
            // 
            this.pbMapa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMapa.Image = ((System.Drawing.Image)(resources.GetObject("pbMapa.Image")));
            this.pbMapa.Location = new System.Drawing.Point(368, 69);
            this.pbMapa.Name = "pbMapa";
            this.pbMapa.Size = new System.Drawing.Size(718, 580);
            this.pbMapa.TabIndex = 5;
            this.pbMapa.TabStop = false;
            this.pbMapa.Click += new System.EventHandler(this.pbMapa_Click);
            this.pbMapa.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMapaPaint);
            // 
            // stMensagem
            // 
            this.stMensagem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.stMensagem.Location = new System.Drawing.Point(0, 727);
            this.stMensagem.Name = "stMensagem";
            this.stMensagem.Size = new System.Drawing.Size(1151, 22);
            this.stMensagem.TabIndex = 6;
            this.stMensagem.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(76, 17);
            this.toolStripStatusLabel1.Text = "Registro 1/23";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCidades);
            this.tabControl1.Controls.Add(this.tpCaminhos);
            this.tabControl1.Location = new System.Drawing.Point(12, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(350, 520);
            this.tabControl1.TabIndex = 7;
            // 
            // tpCidades
            // 
            this.tpCidades.Controls.Add(this.lsbCidades);
            this.tpCidades.Controls.Add(this.udCoordenadaY);
            this.tpCidades.Controls.Add(this.label2);
            this.tpCidades.Controls.Add(this.udCoordenadaX);
            this.tpCidades.Controls.Add(this.label4);
            this.tpCidades.Controls.Add(this.txtNomeCidade);
            this.tpCidades.Controls.Add(this.label3);
            this.tpCidades.Location = new System.Drawing.Point(4, 27);
            this.tpCidades.Name = "tpCidades";
            this.tpCidades.Padding = new System.Windows.Forms.Padding(3);
            this.tpCidades.Size = new System.Drawing.Size(342, 489);
            this.tpCidades.TabIndex = 0;
            this.tpCidades.Text = "Cidades";
            this.tpCidades.UseVisualStyleBackColor = true;
            this.tpCidades.Enter += new System.EventHandler(this.tpCidades_Enter);
            // 
            // tpCaminhos
            // 
            this.tpCaminhos.Controls.Add(this.dgvMelhorCaminho);
            this.tpCaminhos.Controls.Add(this.lbMelhorCaminho);
            this.tpCaminhos.Controls.Add(this.btnAcharCaminhos);
            this.tpCaminhos.Controls.Add(this.label6);
            this.tpCaminhos.Controls.Add(this.cbOrigem);
            this.tpCaminhos.Controls.Add(this.label7);
            this.tpCaminhos.Controls.Add(this.upCusto);
            this.tpCaminhos.Controls.Add(this.cbDestino);
            this.tpCaminhos.Controls.Add(this.label10);
            this.tpCaminhos.Controls.Add(this.upTempo);
            this.tpCaminhos.Controls.Add(this.label8);
            this.tpCaminhos.Controls.Add(this.upDistancia);
            this.tpCaminhos.Controls.Add(this.label9);
            this.tpCaminhos.Location = new System.Drawing.Point(4, 27);
            this.tpCaminhos.Name = "tpCaminhos";
            this.tpCaminhos.Padding = new System.Windows.Forms.Padding(3);
            this.tpCaminhos.Size = new System.Drawing.Size(342, 489);
            this.tpCaminhos.TabIndex = 1;
            this.tpCaminhos.Text = "Busca";
            this.tpCaminhos.UseVisualStyleBackColor = true;
            this.tpCaminhos.Enter += new System.EventHandler(this.tpCaminhos_Enter);
            // 
            // dgvMelhorCaminho
            // 
            this.dgvMelhorCaminho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMelhorCaminho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvMelhorCaminho.Location = new System.Drawing.Point(113, 216);
            this.dgvMelhorCaminho.Name = "dgvMelhorCaminho";
            this.dgvMelhorCaminho.RowTemplate.Height = 25;
            this.dgvMelhorCaminho.Size = new System.Drawing.Size(208, 254);
            this.dgvMelhorCaminho.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Passando por";
            this.Column1.Name = "Column1";
            // 
            // lbMelhorCaminho
            // 
            this.lbMelhorCaminho.AutoSize = true;
            this.lbMelhorCaminho.Location = new System.Drawing.Point(113, 191);
            this.lbMelhorCaminho.Name = "lbMelhorCaminho";
            this.lbMelhorCaminho.Size = new System.Drawing.Size(196, 18);
            this.lbMelhorCaminho.TabIndex = 12;
            this.lbMelhorCaminho.Text = "Melhor caminho (yyyyy km):\r\n";
            // 
            // btnAcharCaminhos
            // 
            this.btnAcharCaminhos.Location = new System.Drawing.Point(15, 191);
            this.btnAcharCaminhos.Name = "btnAcharCaminhos";
            this.btnAcharCaminhos.Size = new System.Drawing.Size(92, 49);
            this.btnAcharCaminhos.TabIndex = 11;
            this.btnAcharCaminhos.Text = "Achar caminhos";
            this.btnAcharCaminhos.UseVisualStyleBackColor = true;
            this.btnAcharCaminhos.Click += new System.EventHandler(this.btnAcharCaminhos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Origem:";
            // 
            // cbOrigem
            // 
            this.cbOrigem.FormattingEnabled = true;
            this.cbOrigem.Location = new System.Drawing.Point(15, 38);
            this.cbOrigem.Name = "cbOrigem";
            this.cbOrigem.Size = new System.Drawing.Size(121, 26);
            this.cbOrigem.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Destino:";
            // 
            // upCusto
            // 
            this.upCusto.Location = new System.Drawing.Point(103, 147);
            this.upCusto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.upCusto.Name = "upCusto";
            this.upCusto.Size = new System.Drawing.Size(100, 26);
            this.upCusto.TabIndex = 10;
            // 
            // cbDestino
            // 
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(160, 38);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(121, 26);
            this.cbDestino.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "Custo:";
            // 
            // upTempo
            // 
            this.upTempo.Location = new System.Drawing.Point(103, 113);
            this.upTempo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.upTempo.Name = "upTempo";
            this.upTempo.Size = new System.Drawing.Size(100, 26);
            this.upTempo.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Distância: ";
            // 
            // upDistancia
            // 
            this.upDistancia.Location = new System.Drawing.Point(104, 79);
            this.upDistancia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.upDistancia.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.upDistancia.Name = "upDistancia";
            this.upDistancia.Size = new System.Drawing.Size(99, 26);
            this.upDistancia.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tempo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 590);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Caminhos encontrados";
            // 
            // lbKmCaminhoSelecionado
            // 
            this.lbKmCaminhoSelecionado.AutoSize = true;
            this.lbKmCaminhoSelecionado.Location = new System.Drawing.Point(78, 621);
            this.lbKmCaminhoSelecionado.Name = "lbKmCaminhoSelecionado";
            this.lbKmCaminhoSelecionado.Size = new System.Drawing.Size(284, 18);
            this.lbKmCaminhoSelecionado.TabIndex = 9;
            this.lbKmCaminhoSelecionado.Text = "Km do caminho selecionado (xxxxx km):";
            // 
            // dgvCaminhosEncontrados
            // 
            this.dgvCaminhosEncontrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaminhosEncontrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvCaminhosEncontrados.Location = new System.Drawing.Point(16, 662);
            this.dgvCaminhosEncontrados.Name = "dgvCaminhosEncontrados";
            this.dgvCaminhosEncontrados.RowTemplate.Height = 25;
            this.dgvCaminhosEncontrados.Size = new System.Drawing.Size(1070, 62);
            this.dgvCaminhosEncontrados.TabIndex = 10;
            this.dgvCaminhosEncontrados.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCaminhosEncontrados_RowHeaderMouseClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "1a";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "2a";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "3a";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "4a";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "5a";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "6a";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "7a";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "8a";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "9a";
            this.Column10.Name = "Column10";
            // 
            // dlgCidades
            // 
            this.dlgCidades.FileName = "openFileDialog1";
            // 
            // dlgCaminhos
            // 
            this.dlgCaminhos.FileName = "openFileDialog1";
            // 
            // FrmMapeamentoCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 749);
            this.Controls.Add(this.dgvCaminhosEncontrados);
            this.Controls.Add(this.lbKmCaminhoSelecionado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.stMensagem);
            this.Controls.Add(this.pbMapa);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMapeamentoCidades";
            this.Text = "Mapeamento de Cidades";
            this.Load += new System.EventHandler(this.FrmMapeamentoCidades_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udCoordenadaY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCoordenadaX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).EndInit();
            this.stMensagem.ResumeLayout(false);
            this.stMensagem.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpCidades.ResumeLayout(false);
            this.tpCidades.PerformLayout();
            this.tpCaminhos.ResumeLayout(false);
            this.tpCaminhos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMelhorCaminho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upTempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDistancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaminhosEncontrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnInicio;
        private ToolStripButton btnAnterior;
        private ToolStripButton btnProximo;
        private ToolStripButton btnUltimo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnProcurar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnNovo;
        private ToolStripButton btnCancelar;
        private ToolStripButton btnSalvar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnSair;
        private TextBox txtNomeCidade;
        private PictureBox pbMapa;
        private Label label2;
        private NumericUpDown udCoordenadaY;
        private NumericUpDown udCoordenadaX;
        private ListBox lsbCidades;
        private Label label4;
        private Label label3;
        private StatusStrip stMensagem;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TabControl tabControl1;
        private TabPage tpCidades;
        private TabPage tpCaminhos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label6;
        private ComboBox cbOrigem;
        private Label label7;
        private NumericUpDown upCusto;
        private ComboBox cbDestino;
        private Label label10;
        private NumericUpDown upTempo;
        private Label label8;
        private NumericUpDown upDistancia;
        private Label label9;
        private Label lbMelhorCaminho;
        private Button btnAcharCaminhos;
        private DataGridView dgvMelhorCaminho;
        private DataGridViewTextBoxColumn Column1;
        private Label label5;
        private Label lbKmCaminhoSelecionado;
        private DataGridView dgvCaminhosEncontrados;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private OpenFileDialog dlgCidades;
        private OpenFileDialog dlgCaminhos;
    }
}