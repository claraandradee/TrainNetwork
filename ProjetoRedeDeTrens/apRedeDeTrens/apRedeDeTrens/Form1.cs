using System.Text.Json.Serialization;
using System.Windows.Forms;

//Nome: Clara Andrade Sant'Anna Santos RA:22124
//Nome: Julia Enriquetto de Brito      RA:22139 

namespace apRedeDeTrens
{
    public partial class FrmMapeamentoCidades : Form
    {
        ListaDupla<Cidade> cidades; //lista de cidades
        Cidade[] vetorCidades; // vetor para os índices das cidades
        int[,] adjacencias; // matriz
        PilhaLista<Movimento> caminhoSelecionado; //movimentos do trajeto

        public FrmMapeamentoCidades()
        {
            InitializeComponent();
        }

        //metodo para pegar os indices da cidade
        private int ObterIndiceCidade(string id)
        {
            // for que percorre o vetor de cidades
            for (int i = 0; i < vetorCidades.Length; i++)
                // se encontrou uma cidade com o mesmo nome do id procurado
                if (vetorCidades[i].Nome == id)
                    return i; // retorna o i da posição atual

            return -1; // -1, pois o índice da cidade não existe;
        }

        private void FrmMapeamentoCidades_Load(object sender, EventArgs e)
        {
            //para abrir o arquivo de cidades
            if (dlgCidades.ShowDialog() == DialogResult.OK) //na hora que o formulário abrir 
            {
                try
                {
                    cidades = new ListaDupla<Cidade>(); //instaciar a lista de cidades

                    cidades.LerDados(dlgCidades.FileName); //ler dados do arquivo 

                    cidades.ExibirDados(lsbCidades); //exibir os dados no listbox

                    // instância o vetor dos índices das cidades com o tamanho da lista de cidades
                    vetorCidades = new Cidade[cidades.Tamanho];
                    int i = 0;
                    cidades.PosicionarNoPrimeiro();
                    while (cidades.DadoAtual() != null) //percorrer todos os dados 
                    {
                        Cidade cidade = cidades.DadoAtual();

                        vetorCidades[i++] = cidade;

                        cbOrigem.Items.Add(cidade.Nome);
                        cbDestino.Items.Add(cidade.Nome);

                        cidades.AvancarPosicao();
                    }

                    pbMapa.Refresh();
                }
                catch (IOException) //caso de erro na hora de ler o arquivo 
                {
                    Console.WriteLine("Erro de leitura no arquivo");
                }
            }

            //para abrir o arquivo de caminhos 
            if (dlgCaminhos.ShowDialog() == DialogResult.OK) //na hora que o formulário abrir 
            {
                StreamReader arquivoCaminhos = new StreamReader(dlgCaminhos.FileName); //ler o arquivo de caminhos 
                adjacencias = new int[cidades.Tamanho, cidades.Tamanho]; //fazer a matriz de adjacencias 

                while (!arquivoCaminhos.EndOfStream) //enquanto não acabar o arquivo vai lendo os arquivos 
                {
                    Ligacao ligacao = new Ligacao();
                    ligacao.LerRegistro(arquivoCaminhos);

                    // obtém os índices relativos às cidades na matriz de adjacências
                    int indiceOrigem = ObterIndiceCidade(ligacao.IdCidadeOrigem);
                    int indiceDestino = ObterIndiceCidade(ligacao.IdCidadeDestino);

                    // monta a matriz de adjacências
                    adjacencias[indiceOrigem, indiceDestino] = ligacao.Distancia;
                }
            }
        }

        //metodo para exibir os dados da cidade 
        private void ExibirCidade(Cidade cidade)
        {
            if (cidade != null)
            {
                txtNomeCidade.Text = cidade.Nome;
                udCoordenadaX.Value = cidade.X;
                udCoordenadaY.Value = cidade.Y;
            }
            else
            {
                txtNomeCidade.Clear();
                udCoordenadaX.Value = 0;
                udCoordenadaY.Value = 0;
            }
        }

        //posicionar no primeiro elemento do arquivo 
        private void btnInicio_Click(object sender, EventArgs e)
        {
            //todas as outras verificações já foram feitas no load
            //então o arquivo tem que estar correto 
            cidades.PosicionarNoPrimeiro();
            ExibirCidade(cidades.DadoAtual());
        }

        //retroceder uma posição 
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            cidades.RetrocederPosicao();
            ExibirCidade(cidades.DadoAtual());
        }

        //avançar uma posição 
        private void btnProximo_Click(object sender, EventArgs e)
        {
            cidades.AvancarPosicao();
            ExibirCidade(cidades.DadoAtual());
        }

        //posicionar no ultimo elemento do arquivo 
        private void btnUltimo_Click(object sender, EventArgs e)
        {
            cidades.PosicionarNoUltimo();
            ExibirCidade(cidades.DadoAtual());
        }

        //procurar cidade 
        private void btnProcurar_Click(object sender, EventArgs e)
        {
            int ondeEsta = Convert.ToInt32(udCoordenadaX.Value);
            if (txtNomeCidade.Text == " ") //se não tem nada para procurar
                MessageBox.Show("Coloque os dados antes de procurar a cidade");
            else //caso esteja preenchido 
            {
                if (cidades.Existe(new Cidade(txtNomeCidade.Text, 0, 0), out ondeEsta)) //podemos procurar a cidade
                    ExibirCidade(cidades.DadoAtual());
            }
            
        }

        //criar uma nova cidade no arquivo 
        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtNomeCidade.Text != "" && udCoordenadaX.Value != 0 && udCoordenadaY.Value != 0)
                cidades.Incluir(new Cidade(txtNomeCidade.Text, udCoordenadaX.Value, udCoordenadaY.Value));

            else
                MessageBox.Show("");

            cidades.ExibirDados(lsbCidades);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //limpa todos os campos
            txtNomeCidade.Clear();
            udCoordenadaX.Value = 0;
            udCoordenadaY.Value = 0;
            lsbCidades.Items.Clear();
        }

        //salvar as alterações
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cidades != null && dlgCidades.FileName != "")
                cidades.GravarDados(dlgCidades.FileName);
        }

        //excluir uma cidade que deseja 
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            cidades.Excluir(new Cidade(txtNomeCidade.Text, 0, 0));
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close(); //para sair do formulário
        }

        //pegar as coordenadas das cidades 
        private void pbMapa_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouse = (MouseEventArgs)e;

            decimal w = pbMapa.Width;
            decimal h = pbMapa.Height;
            decimal x = mouse.Location.X;
            decimal y = mouse.Location.Y;

            decimal xUd = x / w;
            decimal yUd = y / h;

            udCoordenadaX.Value = Math.Round(xUd, 3);
            udCoordenadaY.Value = Math.Round(yUd, 3);
        }
        
        //desenhar na tela os movimentos  
        private void pbMapaPaint(object sender, PaintEventArgs e)
        {
            cidades.PosicionarNoPrimeiro(); //colocar na primeira cidade

            while (cidades.DadoAtual() != null) //percorrer as cidades 
            {
                decimal x = cidades.DadoAtual().X; //pegar o dado de X da cidade 
                decimal y = cidades.DadoAtual().Y; //pegar o dado de Y da cidade 

                e.Graphics.DrawEllipse(new Pen(Brushes.Red), (int)(pbMapa.Width * x), (int)(pbMapa.Height * y), 5, 5); //desenhar as bolinhas das cidades 

                cidades.AvancarPosicao(); //ir para a proxima posição 
            }

            if (caminhoSelecionado != null) //percorrer os caminhos 
                foreach (Movimento movimento in caminhoSelecionado.DadosDaPilha()) //percorrer os movimentos dos dados da pilha 
                {
                    var cidadeOrigem = vetorCidades[movimento.Origem];   //instanciar a cidade de origem 
                    var cidadeDestino = vetorCidades[movimento.Destino]; //instanciar a cidade de destino  

                    int xOrigem = (int)(cidadeOrigem.X * pbMapa.Width);   //pegar os dados de X da cidade de origem 
                    int yOrigem = (int)(cidadeOrigem.Y * pbMapa.Height);  //pegar os dados de Y da cidade de origem 

                    int xDestino = (int)(cidadeDestino.X * pbMapa.Width); //pegar os dados de X da cidade de destino  
                    int yDestino = (int)(cidadeDestino.Y * pbMapa.Height);//pegar os dados de Y da cidade de destino  

                    e.Graphics.DrawLine(new Pen(Brushes.Red, 2), xOrigem, yOrigem, xDestino, yDestino); //desenhar as linhas dos caminhos  
                }
        }

        private void lsbCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            cidades.PosicionarEm(lsbCidades.SelectedIndex);
            ExibirCidade(cidades.DadoAtual());
        }

        //metodo para desabilitar os botoes superiores
        private void DefinirBotoes(bool habilitado)
        {
            btnInicio.Enabled = habilitado;
            btnProximo.Enabled = habilitado;
            btnAnterior.Enabled = habilitado;
            btnUltimo.Enabled = habilitado;
            btnProcurar.Enabled = habilitado;
            btnNovo.Enabled = habilitado;
            btnCancelar.Enabled = habilitado;
            btnSalvar.Enabled = habilitado;
            btnExcluir.Enabled = habilitado;
        }

        //metodo par achar um caminho 
        private void btnAcharCaminhos_Click(object sender, EventArgs e)
        {
            string cidadeOrigem = cbOrigem.SelectedItem.ToString();
            string cidadeDestino = cbDestino.SelectedItem.ToString();
            DefinirBotoes(false); //desabilitar os botoes superiores do programa, para o usuario não ter acesso

            //se a cidade de origem e a cidade de destino forem nulas
            if(cidadeOrigem != "" && cidadeDestino != "")
            {
                //se a cidade de origem for a mesma que a de destino
                if(cidadeOrigem == cidadeDestino)
                    MessageBox.Show("Selecione um cidade de origem diferente da cidade de destino");
                else //se não forem iguais
                {
                    //limpa dgv
                    dgvMelhorCaminho.Rows.Clear();
                    dgvCaminhosEncontrados.Rows.Clear();
                    dgvCaminhosEncontrados.Columns.Clear();

                    //reseta label 
                    lbMelhorCaminho.Text = $"Melhor caminho (yyyyy km)";
                    lbKmCaminhoSelecionado.Text = $"Km do caminho selecionado (xxxxx km)";

                    //instanciar os dados do backtracking 
                    var grafo = new GrafoBacktracking(adjacencias, vetorCidades.Length);

                    int indiceOrigem = ObterIndiceCidade(cidadeOrigem);
                    int indiceDestino = ObterIndiceCidade(cidadeDestino);

                    PilhaLista<Movimento> caminhoCidade = grafo.BuscarCaminho(indiceOrigem, indiceDestino);

                    //caso não existir nenhum caminho 
                    if (caminhoCidade.EstaVazia)
                    {
                        MessageBox.Show("Nenhum caminho existente!");
                        caminhoSelecionado = null;
                        lbKmCaminhoSelecionado.Text = "Km do caminho selecionado: (xxxxx) KM";
                        upDistancia.Value = 0;
                    }
                    //caso existir caminho 
                    else
                    {
                        caminhoSelecionado = caminhoCidade;

                        dgvCaminhosEncontrados.RowCount = 1;
                        dgvMelhorCaminho.RowCount = dgvCaminhosEncontrados.ColumnCount = caminhoCidade.Tamanho + 1;

                        int i = 0;
                        foreach (Movimento movimento in caminhoCidade.DadosDaPilha())
                        {
                            dgvMelhorCaminho.Rows[i].Cells[0].Value = vetorCidades[movimento.Origem].Nome;
                            dgvCaminhosEncontrados.Rows[0].Cells[i++].Value = vetorCidades[movimento.Origem].Nome;
                        }

                        dgvMelhorCaminho.Rows[i].Cells[0].Value = cbDestino.SelectedItem.ToString();
                        dgvCaminhosEncontrados.Rows[0].Cells[i].Value = cbDestino.SelectedItem.ToString();


                        // define o valor do numeric up down de distância
                        int distancia = 0;

                        foreach (Movimento movimento in caminhoSelecionado.DadosDaPilha())
                            distancia += adjacencias[movimento.Origem, movimento.Destino];

                        upDistancia.Value = distancia;
                    }

                    pbMapa.Refresh();
                }
            }
        }

        private void dgvCaminhosEncontrados_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (caminhoSelecionado != null)
            {
                int distancia = 0;

                foreach (Movimento movimento in caminhoSelecionado.DadosDaPilha())
                    distancia += adjacencias[movimento.Origem, movimento.Destino];

                lbKmCaminhoSelecionado.Text = "Km do caminho selecionado: " + distancia.ToString() + "KM";
            }
        }

        private void tpCaminhos_Enter(object sender, EventArgs e)
        {
            DefinirBotoes(false);
        }

        private void tpCidades_Enter(object sender, EventArgs e)
        {
            DefinirBotoes(true);
        }
    }
}