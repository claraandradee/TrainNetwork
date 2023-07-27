using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Nome: Clara Andrade Sant'Anna Santos RA:22124
//Nome: Julia Enriquetto de Brito      RA:22139 
public interface IStack<Dado>
    {
        void Empilhar(Dado dado);  
        Dado Desempilhar();      
        Dado OTopo();             
        int Tamanho { get; }     
        bool EstaVazia { get; }    
        List<Dado> DadosDaPilha();  
                                
    }

