using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.Algoritimo28 {

    //A class é um conjunto de objetos.

    //Classe - a parte mais importante, ela organiza todo o corpo da programação
    //É conjunto de objetos
    internal class Sigla {
        //Método é uma ação de um determinado objeto.

        //Dados - Propriedades automáticas. Set - atribuir Get - Pegar
        public int Id { get; set; }

        public string Descricao { get; set; }

        //Métodos

        public string mostrarSignificado() {

            string resultado = "Outra Sigla";

            //Código desacoplado principalmente da **Interface**
            if (Descricao.Equals("Senai")) {
                resultado = "SERVOÇO NACIONAL DE APRENDIZADO INDUSTRIAL.";
                
            } else {
                resultado = "SERVOÇO NACIONAL DE APRENDIZADO RURAL.";

            }
            return null;
        }
    }
}

