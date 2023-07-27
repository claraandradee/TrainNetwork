using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Nome: Clara Andrade Sant'Anna Santos RA:22124
//Nome: Julia Enriquetto de Brito      RA:22139 

namespace apRedeDeTrens
{
    class GrafoBacktracking
    {
        int qtasCidades;
        int[,] matriz; //MATRIZ

        //construtor
        public GrafoBacktracking(int[,] matriz, int qtasCidades)
        {
            this.qtasCidades = qtasCidades;
            this.matriz = matriz;
        }

        //get e set
        public int QtasCidades { get => qtasCidades; set => qtasCidades = value; }
        public int[,] Matriz { get => matriz; set => matriz = value; }

        public PilhaLista<Movimento> BuscarCaminho(int origem, int destino) //busca caminhos
        {
            int cidadeAtual, saidaAtual;
            bool achouCaminho = false,
            naoTemSaida = false;
            bool[] passou = new bool[qtasCidades];
            // inicia os valores de “passou” pois ainda não foi em nenhuma cidade
            for (int indice = 0; indice < qtasCidades; indice++)
                passou[indice] = false;
            cidadeAtual = origem;
            saidaAtual = 0;
            var pilha = new PilhaLista<Movimento>();
            while (!achouCaminho && !naoTemSaida)
            {
                naoTemSaida = (cidadeAtual == origem && saidaAtual == qtasCidades && pilha.EstaVazia);
                if (!naoTemSaida)
                {
                    while ((saidaAtual < qtasCidades) && !achouCaminho)
                    {
                        if (matriz[cidadeAtual, saidaAtual] == 0)
                            saidaAtual++;
                        else
                            // se já passou pela cidade testada, vê se a próxima cidade permite saída
                            if (passou[saidaAtual])
                            saidaAtual++;
                        else
                                // se chegou na cidade desejada, empilha o local
                                // e termina o processo de procura de caminho
                                if (saidaAtual == destino)
                        {

                            Movimento movim = new Movimento(cidadeAtual, saidaAtual);
                            pilha.Empilhar(movim);
                            achouCaminho = true;
                        }
                        else
                        {

                            Movimento movim = new Movimento(cidadeAtual, saidaAtual);
                            pilha.Empilhar(movim);
                            passou[cidadeAtual] = true;
                            cidadeAtual = saidaAtual; // muda para a nova cidade
                            saidaAtual = 0; // reinicia busca de saídas da nova
                                            // cidade a partir da primeira cidade

                        }
                    }
                } /// if ! naoTemSaida
                if (!achouCaminho)
                    if (!pilha.EstaVazia)
                    {
                        var movim = pilha.Desempilhar();
                        saidaAtual = movim.Destino;
                        cidadeAtual = movim.Origem;
                        saidaAtual++;
                    }
            }
            var saida = new PilhaLista<Movimento>();
            if (achouCaminho)
            { // desempilha a configuração atual da pilha
              // para a pilha da lista de parâmetros
                while (!pilha.EstaVazia)
                {
                    Movimento movim = pilha.Desempilhar();
                    saida.Empilhar(movim);
                }
            }
            return saida;
        }

        // tentativa sem sucesso de buscar todos os caminhos a partir de um caminho encontrado
        // fazendo um backtracking para evitar que a mesma saída que levou o destino seja utilizada,
        // repetindo a operação para cada movimento no caminho original e buscando cada novo caminho
        public List<PilhaLista<Movimento>> BuscarTodosOsCaminhos(int origem, int destino, PilhaLista<Movimento> caminhoOriginal)
        {
            List<PilhaLista<Movimento>> todosCaminhos = new List<PilhaLista<Movimento>>();

            caminhoOriginal.Inverter();
            Movimento mov = caminhoOriginal.Desempilhar();
            List<int> jaVisitou = new List<int>();
            jaVisitou.Add(mov.Origem); // marca que a saída que levou ao destino já foi visitada

            while (!caminhoOriginal.EstaVazia)
            {
                Movimento anterior = caminhoOriginal.Desempilhar();

                // recomeça a busca a partir da origem do movimento anterior, evitando as saída já visitadas
                PilhaLista<Movimento> novoCaminho = BuscarCaminhoEvitandoSaida(anterior.Origem, destino, jaVisitou, caminhoOriginal.Clonar());
                jaVisitou.Add(anterior.Origem);

                // se há um caminho, o inclui da lista de caminhos
                if (!novoCaminho.EstaVazia)
                    todosCaminhos.Add(novoCaminho);
            }

            return todosCaminhos;
        }

        public PilhaLista<Movimento> BuscarCaminhoEvitandoSaida(int origem, int destino, List<int> evitarSaidas, PilhaLista<Movimento> caminhoAnterior)
        {
            int cidadeAtual, saidaAtual;
            bool achouCaminho = false, naoTemSaida = false;
            bool[] passou = new bool[qtasCidades];

            // Inicia os valores de "passou" pois ainda não foi em nenhuma cidade
            for (int indice = 0; indice < qtasCidades; indice++)
                passou[indice] = false;

            // para cada saída já visitada, marca como true no vetor lógico
            foreach (int jaVisitou in evitarSaidas)
                passou[jaVisitou] = true;

            cidadeAtual = origem;
            saidaAtual = 0;

            while (!achouCaminho && !naoTemSaida)
            {
                naoTemSaida = (cidadeAtual == origem && saidaAtual == qtasCidades && caminhoAnterior.EstaVazia);

                if (!naoTemSaida)
                {
                    while ((saidaAtual < qtasCidades) && !achouCaminho)
                    {
                        // Se não há saída pela cidade testada, verifica a próxima
                        if (matriz[cidadeAtual, saidaAtual] == 0)
                            saidaAtual++;
                        else
                        // Se já passou pela cidade testada, vê se a próxima cidade permite saída
                        if (passou[saidaAtual])
                            saidaAtual++;
                        else
                        // Se chegou na cidade desejada, empilha o local
                        // e termina o processo de procura de caminho
                        if (saidaAtual == destino)
                        {
                            Movimento movim = new Movimento(cidadeAtual, saidaAtual);
                            caminhoAnterior.Empilhar(movim);
                            achouCaminho = true;
                        }
                        else
                        {
                            Movimento movim = new Movimento(cidadeAtual, saidaAtual);
                            caminhoAnterior.Empilhar(movim);
                            passou[cidadeAtual] = true;
                            cidadeAtual = saidaAtual; // Muda para a nova cidade
                            saidaAtual = 0; // Reinicia busca de saídas da nova cidade a partir da primeira cidade
                        }
                    }
                }

                if (!achouCaminho)
                {
                    if (!caminhoAnterior.EstaVazia)
                    {
                        var movim = caminhoAnterior.Desempilhar();
                        saidaAtual = movim.Destino;
                        cidadeAtual = movim.Origem;
                        saidaAtual++;
                    }
                }
            }

            var saida = new PilhaLista<Movimento>();

            if (achouCaminho)
            { // Desempilha a configuração atual da pilha
              // Para a pilha da lista de parâmetros
                while (!caminhoAnterior.EstaVazia)
                {
                    Movimento movim = caminhoAnterior.Desempilhar();
                    saida.Empilhar(movim);
                }
            }

            return saida;
        }
    }
}
