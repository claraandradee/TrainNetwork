using System;
using System.IO;

//Nome: Clara Andrade Sant'Anna Santos RA:22124
//Nome: Julia Enriquetto de Brito      RA:22139 

internal class Ligacao
{
  const int tamCodigo = 15,
        tamDistancia = 5,
        tamCusto = 5;

  const int iniCodigoOrigem = 0,
            iniCodigoDestino = iniCodigoOrigem + tamCodigo,
            iniDistancia = iniCodigoDestino + tamCodigo,
            iniCusto = iniDistancia + tamDistancia;


  string idCidadeOrigem, idCidadeDestino;
  int distancia, custo;

  public Ligacao(string idCidadeOrigem, string idCidadeDestino, int distancia, int custo)
  {
    this.idCidadeOrigem = idCidadeOrigem;
    this.idCidadeDestino = idCidadeDestino;
    this.distancia = distancia;
    this.custo = custo;
  }
  public Ligacao() { }

  public string IdCidadeOrigem { get => idCidadeOrigem; set => idCidadeOrigem = value; }
  public string IdCidadeDestino { get => idCidadeDestino; set => idCidadeDestino = value; }
  public int Distancia { get => distancia; set => distancia = value; }
  public int Custo { get => custo; set => custo = value; }

  public int CompareTo(Ligacao outro)
  {
    return (idCidadeOrigem.ToUpperInvariant()+idCidadeDestino.ToUpperInvariant()).CompareTo(
            outro.idCidadeOrigem.ToUpperInvariant()+outro.idCidadeDestino.ToUpperInvariant());
  }

  public Ligacao LerRegistro(StreamReader arquivo)
  {
    if (arquivo != null) 
    {
      string linha = arquivo.ReadLine();
      IdCidadeOrigem = linha.Substring(iniCodigoOrigem, tamCodigo);
      IdCidadeDestino = linha.Substring(iniCodigoDestino, tamCodigo);
      Distancia = int.Parse(linha.Substring(iniDistancia, tamDistancia));
      Custo = int.Parse(linha.Substring(iniCusto));
      return this; // retorna o próprio objeto Contato, com os dados
    }
    return default(Ligacao);
  }
  public void GravarRegistro(StreamWriter arq)
  {
    if (arq != null) 
    {
      arq.WriteLine(ParaArquivo());
    }
  }
  public string ParaArquivo()
  {
    return $"{IdCidadeOrigem}{IdCidadeDestino}{Distancia:00000}{Custo:00000}";
  }

  public override string ToString()
  {
    return $"{IdCidadeOrigem} {IdCidadeDestino} {Distancia:00000} {Custo:00000}";
  }
}