using System;
using System.Windows.Forms;
using System.IO;

//Nome: Clara Andrade Sant'Anna Santos RA:22124
//Nome: Julia Enriquetto de Brito      RA:22139 
public enum Situacao
{
    navegando, incluindo, pesquisando, editando, excluindo
}
interface IDados<Dado> where Dado : IComparable<Dado>, IRegistro<Dado>, new()
{
    void PosicionarNoPrimeiro();
    void RetrocederPosicao();
    void AvancarPosicao();
    void PosicionarNoUltimo();
    void PosicionarEm(int posicaoDesejada);
    Dado DadoAtual();  // retorna o dado atualmente visitado
    Dado this[int indice] { get; set; }  // acessa e retorna o indice-ésimo Dado
    void ExibirDados();
    void ExibirDados(ListBox lista);
    void ExibirDados(ComboBox lista);
    void ExibirDados(TextBox lista);
    bool Existe(Dado procurado, out int ondeEsta);
    bool Excluir(Dado dadoAExcluir);             // excluirá o Dado atualmente visitado
    bool IncluirNoInicio(Dado novoValor);   // Inserir novo dado antes do primeiro dado armazenado
    bool IncluirAposFim(Dado novoValor);    // Inserir novo dado após o último dado armazenado
    bool Incluir(Dado novoValor);   // incluirá na ordem dada pelo método comparador
    bool Incluir(Dado novoValor, int posicaoDeInclusao);
    void Ordenar();
    void LerDados(string nomeArquivo);
    void GravarDados(string nomeArquivo);
    Situacao SituacaoAtual { get; set; }
    int PosicaoAtual { get; set; }
    bool EstaNoInicio { get; }
    bool EstaNoFim { get; }
    bool EstaVazio { get; }
    int Tamanho { get; }
}