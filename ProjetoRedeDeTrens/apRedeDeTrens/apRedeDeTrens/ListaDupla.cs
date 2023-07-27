using System;
using System.Windows.Forms;

//Nome: Clara Andrade Sant'Anna Santos RA:22124
//Nome: Julia Enriquetto de Brito      RA:22139 
class ListaDupla<Dado> : IDados<Dado>
                where Dado : IComparable<Dado>, IRegistro<Dado>, new()
{
    NoDuplo<Dado> primeiro, ultimo, atual;
    int quantosNos, posicaoAtual;
    Situacao situacaoAtual;

    public ListaDupla()
    {
        primeiro = ultimo = atual = null;
        quantosNos = 0; 
    }

    public Situacao SituacaoAtual { get => situacaoAtual; set => situacaoAtual = value; }
    public int PosicaoAtual { get => posicaoAtual; set => posicaoAtual = value; }
    public bool EstaNoInicio { get => atual == primeiro; }
    public bool EstaNoFim { get => atual == ultimo; }
    public bool EstaVazio { get => quantosNos == 0;  }          // (bool) Verificar se está vazia
    public int Tamanho { get => quantosNos;  }

    public void LerDados(string nomeArquivo)    // fará a leitura e armazenamento dos dados do arquivo cujo nome é passado por parâmetro
    {
        if(nomeArquivo != null)
        {
           situacaoAtual = Situacao.editando;

          StreamReader arq = new StreamReader(nomeArquivo);

          while(!arq.EndOfStream)
          {
            Incluir(new Dado().LerRegistro(arq));
          }

          arq.Close();
        }
    }
    public void GravarDados(string nomeArquivo)  // gravará sequencialmente, no arquivo cujo nome é passado por parâmetro, os dados armazenados na lista
    {
      if(nomeArquivo != null)
      {
        situacaoAtual = Situacao.editando;

        StreamWriter arq = new StreamWriter(nomeArquivo);

        PosicionarNoPrimeiro();

        while(atual != null)
        {
          DadoAtual().GravarRegistro(arq);
          AvancarPosicao();
        }

        arq.Close();
      }
    }
    public void PosicionarNoPrimeiro()        // Posicionar atual no primeiro nó para ser acessado
    {
      atual = primeiro;
      posicaoAtual = 0;
    }
    public void RetrocederPosicao()        // Retroceder atual para o nó anterior para ser acessado
    {
        if(atual != null)
        {
          atual = atual.Ant;
          posicaoAtual--;
        }
    }
    public void AvancarPosicao()
    {
        if(atual != null)
        {
          atual = atual.Prox;
          posicaoAtual++;
        }
    }
    public void PosicionarNoUltimo()        // posicionar atual no último nó para ser acessado
    {
      atual = ultimo;
      posicaoAtual = Tamanho;
    }
    public void PosicionarEm(int posicaoDesejada)
    {
        if(posicaoDesejada < Tamanho)
        {
          PosicionarNoPrimeiro();
          
          for(int i=0; i < posicaoDesejada; i++)
          {
            AvancarPosicao();
          }
        }
    }

    // (bool) Pesquisar Dado procurado em ordem crescente; a pesquisa
    // posicionará o ponteiro atual no nó procurado quando este
    // or encontrado ou, se não achar, no nó seguinte a local
    // onde deveria estar o nó procurado
    public bool Existe(Dado procurado, out int ondeEsta)
    {
      situacaoAtual = Situacao.pesquisando;

      PosicionarNoPrimeiro();

      if(EstaVazio || procurado == null)
      {
        ondeEsta = -1;
        return false;
      }

      if(procurado.CompareTo(primeiro.Info) < 0)
      {
        ondeEsta = -1;
        return false;
      }

      if(procurado.CompareTo(ultimo.Info) > 0 )
      {
        PosicionarNoUltimo();
        ondeEsta = -1;
        return false;
      }

      bool achou = false;
      bool fim = false;
      ondeEsta = 0;

      while(!achou && !fim)
      {
        if (atual == null)
          fim = true;
        else
        {
          if (procurado.CompareTo(DadoAtual()) == 0)
            achou = true;
          else
            if (DadoAtual().CompareTo(procurado) > 0)
              fim = true;
            else{
              ondeEsta++;
              AvancarPosicao();
            }
        }        
      }

      return achou;
    }
    public bool Excluir(Dado dadoAExcluir)
    {
      if (dadoAExcluir == null)
        return false;

      if(Existe(dadoAExcluir, out _))
      {
        situacaoAtual = Situacao.excluindo;

        if(EstaNoInicio)
        {
          primeiro = atual.Prox;

          if (primeiro != null)
            primeiro.Ant = null;
        }
        else
        {
          atual.Ant.Prox = atual.Prox;

          if (EstaNoFim)
            ultimo = atual.Ant;
          else
            atual.Prox.Ant = atual.Ant;
        }

        quantosNos--;
        AvancarPosicao();
        return true;
      }
      return false; 
    }
    public bool IncluirNoInicio(Dado novoValor)
    {
      situacaoAtual = Situacao.incluindo;

      if (novoValor == null)
        return false;

      NoDuplo<Dado> novoNo = new NoDuplo<Dado>(novoValor);

      if (EstaVazio)
        primeiro = ultimo = novoNo;
      else
      {
        primeiro.Ant = novoNo;
        novoNo.Prox = primeiro;
        primeiro = novoNo;
      }

      quantosNos++;
      return true;
    }
    public bool IncluirAposFim(Dado novoValor)
    {
      situacaoAtual = Situacao.incluindo;

      if(novoValor == null)
        return false;

      NoDuplo<Dado> novoNo = new NoDuplo<Dado>(novoValor);

      if (EstaVazio)
        primeiro = novoNo;
      else
      {
        ultimo.Prox = novoNo;
        novoNo.Ant = ultimo;
      }

      ultimo = novoNo;
      quantosNos++;
      return true;
    }
    public bool Incluir(Dado novoValor)         // (bool) Inserir nó com Dado em ordem crescente
    {
      situacaoAtual = Situacao.incluindo;

      if(novoValor == null)
        return false;

      if(!Existe(novoValor, out int ondeEsta))
      {
        if (EstaVazio)
          return IncluirNoInicio(novoValor);

        else
        {
          if(EstaNoFim && ondeEsta == -1)
            return IncluirAposFim(novoValor);
          else 
            if(EstaNoInicio && ondeEsta == -1)
              return IncluirNoInicio(novoValor);
            else
            {
              NoDuplo<Dado> novoNo = new NoDuplo<Dado>(novoValor);

              novoNo.Ant = atual.Ant;

              if (novoNo != null)
                novoNo.Ant.Prox = novoNo;

              novoNo.Prox = atual;
              atual.Ant = novoNo;
              atual = novoNo;

              return true;
            }
        }
      }

      return false;
    }
    public bool Incluir(Dado novoValor, int posicaoDeInclusao)  // inclui novo nó na posição indicada da lista
    {
      situacaoAtual = Situacao.incluindo;

      if (novoValor == null)
        return false;

      if (posicaoDeInclusao < 0 || posicaoDeInclusao > Tamanho - 1)
        return false;

      if(!Existe(novoValor, out _))
      {
        PosicionarEm(posicaoDeInclusao);

        NoDuplo<Dado> novoNo = new NoDuplo<Dado>(novoValor);

        novoNo.Ant = atual.Ant;

        if(novoNo.Ant != null)
          novoNo.Ant.Prox = novoNo;

        novoNo.Prox = atual;
        atual.Ant = novoNo;
        atual = novoNo;
        quantosNos++;

        return true;
      }
      return false;
    }
    public Dado this[int indice]
    {
      get
      {
        if(indice >= 0 && indice < Tamanho)
        {
          PosicionarEm(indice);
          return DadoAtual();
        }
        return default;
      }
      set
      {
        if(indice >= 0 && indice < Tamanho)
        {
          PosicionarEm(indice);
          atual.Info = value;
        }
      }
    }
    public Dado DadoAtual()  // retorna o dado atualmente visitado
    {
      if (atual != null)
        return atual.Info;

      return default;
    }
    public void ExibirDados()   // lista os dados armazenados na lista em modo console
    {
      situacaoAtual = Situacao.navegando;

      PosicionarNoPrimeiro();

      Console.Clear();
      while(atual != null)
      {
        Console.WriteLine($"{DadoAtual()}\n");
        AvancarPosicao();
      }
    }
    public void ExibirDados(ListBox lista)  // lista os dados armazenados na lista no listbox passado como parâmetro
    {
      situacaoAtual = Situacao.navegando;

      PosicionarNoPrimeiro();

      lista.Items.Clear();
      while (atual != null)
      {
        lista.Items.Add($"{DadoAtual().ToString()}");
        AvancarPosicao();
      }
    }
    public void ExibirDados(ComboBox lista) // lista os dados armazenados na lista no combobox passado como parâmetro
    {
      situacaoAtual = Situacao.navegando;

      PosicionarNoPrimeiro();

      lista.Items.Clear();
      while (atual != null)
      {
        lista.Items.Add($"{DadoAtual().ToString()}");
        AvancarPosicao();
      }
  }
    public void ExibirDados(TextBox lista)
    {
      situacaoAtual = Situacao.navegando;

      PosicionarNoPrimeiro();

      lista.Clear();
      while (atual != null)
      {
        lista.Text += $"{DadoAtual()}\n";
        AvancarPosicao();
      }
  }
    public void Ordenar()
    {
      situacaoAtual = Situacao.editando;

      ListaDupla<Dado> ordenada = new ListaDupla<Dado>();
      PosicionarNoPrimeiro();

      while(atual != null)
      {
        ordenada.Incluir(DadoAtual());
        AvancarPosicao();
      }

      primeiro = ordenada.primeiro;
      ultimo = ordenada.ultimo;
     }
}