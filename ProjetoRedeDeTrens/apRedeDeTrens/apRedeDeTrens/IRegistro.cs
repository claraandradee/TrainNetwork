using System.IO;

//Nome: Clara Andrade Sant'Anna Santos RA:22124
//Nome: Julia Enriquetto de Brito      RA:22139 
public interface IRegistro<Dado>
{
    Dado LerRegistro(StreamReader arquivo);
    string ParaArquivo();
    void GravarRegistro(StreamWriter arquivo);
}