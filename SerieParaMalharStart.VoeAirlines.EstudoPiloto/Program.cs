using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.EstudoPiloto {
    //API
    //Tabela: Piloto
    //ID, Nome e Matrícula
    internal class Program {

        //Propriedade automática
        //Encapsulamento
        //set       get
        //Propriedade é privada
        //get e set é público
        //Encapsulamento

        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        //void - retorno vazio
        //return - funçao - retorna

        /*
         *Estruturado
        if
        for
        while
        do while
        estrutura de dados
        funções/procedimentos
        */
        
        public string GerarNomeCompleto() 
        {
            return $"{Nome}{Sobrenome}".ToUpper();
        }

        public string GerarNomeCompletoMinusculo() {
            return $"{Nome}{Sobrenome}".ToLower();
        }



        static void Main(string[] args) {

            
        }
    }
}
