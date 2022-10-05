using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerieParaMalharStart.VoeAirlines.Entities.Enums;
using SerieParaMalharStart.VoeAirlines.Entities.Enum;


namespace SerieParaMalharStart.VoeAirlines.Entities {

    //É um conjunto de objetos
    internal class Aeronave {

        //Propriedades / PascalCasing

        public string Modelo;
        public string Fabricante;
        public decimal ValorAprox;
        public string Matricula;
        public decimal Envergadura;
        public decimal Comprimento;
        public decimal Altura;
        public int Capacidade;
        public double VelocidadeMax;
        public double VelocidadeCruzeiro;
        public double AltitudeCruzeiro;
        public string Codigo;
        public string LocalFabricacao;
        public DateTime DataFabricacao;
        public TipoAeronave Tipo;
        public string Celebridade;
       

    }
}
