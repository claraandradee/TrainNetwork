using System;
using System.IO;

//Nome: Clara Andrade Sant'Anna Santos RA:22124
//Nome: Julia Enriquetto de Brito      RA:22139 

class Cidade : IComparable<Cidade>, IRegistro<Cidade>
  {
    //instancias 
    const int
              tamNome = 15,
              tamX = 5,
              tamY = 5;

    const int iniNome = 0,
              iniX = iniNome + tamNome,
              iniY = iniX + tamX;

    string nome;
    decimal x, y;

    public string Nome   { get => nome; set => nome = value.PadRight(tamNome, ' ').Substring(0, tamNome); }
    public decimal X         { get => x; set => x = value; }
    public decimal Y         { get => y; set => y = value; }

    //construtores
    public Cidade(string nome, decimal x, decimal y)
    {
         Nome = nome;
        X = x;
        Y = y;
    }

    public Cidade()
    {
        nome = " ";
        x = 0;
        y = 0;
    }

    public int CompareTo(Cidade outro)
    {
        return nome.ToUpperInvariant().CompareTo(outro.nome.ToUpperInvariant());
    }

    public Cidade LerRegistro(StreamReader arquivo)
    {
      if (arquivo != null) //se o arquivo não for nulo
      {
        //le as linhas
        string linha = arquivo.ReadLine();
        Nome = linha.Substring(iniNome, tamNome);
        X = decimal.Parse(linha.Substring(iniX, tamX));
        Y = decimal.Parse(linha.Substring(iniY));
        return this; // retorna o próprio objeto Contato, com os dados
      }
      return default(Cidade);
    }

    public void GravarRegistro(StreamWriter arq)
    {
      if (arq != null)  
      {
        arq.WriteLine(ParaArquivo()); //grava dados no arquivo txt
      }
    }
    public string ParaArquivo() 
    {
      return Nome + X.ToString() + Y.ToString();
    }

    public override string ToString()
    {
      return Nome + " " + X.ToString().PadLeft(tamX,' ') + ' ' + Y.ToString().PadLeft(tamY, ' ');
    }
  }
