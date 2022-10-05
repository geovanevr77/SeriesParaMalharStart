using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerieParaMalharStart.VoeAirlines.Entities;
using SerieParaMalharStart.VoeAirlines.Entities.Enum;
using SerieParaMalharStart.VoeAirlines.Entities.Enums;

namespace SerieParaMalharStart.VoeAirlines {
    internal class Program {
        static void Main(string[] args) {

            Aeronave aero = new Aeronave();
            //Aeronave: classe
            //Aero: objeto da classe
            // = : atribuição
            // new: Operador de instanciação - é um objeto, ele define o objeto (concretização de uma classe)
            // Aeronave(): chamada ao construtor 

            //Interface de usuario
            Console.WriteLine("Digite o fabricante: ");
            var entradaFabricante = Console.ReadLine();
            Console.WriteLine("Digite a matrícula: ");
            var entradaMatricula = Console.ReadLine();
            Console.WriteLine("Digite o modelo: ");
            var entradaModelo = Console.ReadLine();
            Console.WriteLine("Digite o código: ");
            var entradaCodigo= Console.ReadLine();
            Console.WriteLine("Digite a quantidade de passageiros: ");
            var entradaQtdePassageiros = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome do propietário");
            var entradaCelebridade = Console.ReadLine();

            //Atribuições
            aero.Fabricante = entradaFabricante;
            aero.Matricula = entradaMatricula;
            aero.Modelo = entradaModelo;
            aero.Codigo = entradaCodigo;
            aero.Capacidade = entradaQtdePassageiros;
            aero.Celebridade = entradaCelebridade;

            //Noticia
            Console.WriteLine($"Jatinho executuvo do Messi é um {aero.Modelo}- {aero.Codigo}" +
                $"fabricado pela {aero.Fabricante} de matrícula {aero.Matricula}. ");
            Console.ReadKey();
        }
    }
}
