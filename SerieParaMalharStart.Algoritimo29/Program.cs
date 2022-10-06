using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.Algoritimo29 {
    internal class Program {
        static void Main(string[] args) {
            var soma = 0.0m;
            var subtracao = 0.0m;
            var multi = 0.0m;
            var div = 0.0m;


            //Console.WriteLine("Qual seu nome?");
            //string nome = Console.ReadLine();
            //Console.WriteLine($"Seu nome é: {nome}");
            //var materias = new[]{"C#, "Banco de Dados"};
            int[] numeros = new int[10];
            numeros[0] = 1;
            numeros[1] = 37;
            numeros[2] = 19;
            numeros[3] = 73;
            numeros[4] = 81;
            numeros[5] = 24;
            numeros[6] = 66;
            numeros[7] = 92;
            numeros[8] = 17;
            numeros[9] = 22;
            /*Console.WriteLine(numeros[0]);
            Console.WriteLine(numeros[1]);
            Console.WriteLine(numeros[2]);
            Console.WriteLine(numeros[3]);
            Console.WriteLine(numeros[4]);
            Console.WriteLine(numeros[5]);
            Console.WriteLine(numeros[6]);
            Console.WriteLine(numeros[7]);
            Console.WriteLine(numeros[8]);
            Console.WriteLine(numeros[9]);
            */

            //Looping:
            //Repetição cíclica de algo
            //infinito geralmente é um erro
            //looping é executado quando tem uma função
            //Resultado:o looping tem uma função repetitiva até que tenha uma parada.

            //Considerações do professor: 
            /*========================================================================
             * 
             * Vamos trabalhar com esse dois:
             * Looping finito com controle de sentinela.
             * Looping sem controle de sentinela.
             * 
             * =======================================================================
             * 
             * Podemos enfrentar esses dois:
             * Looping infinito como um erro
             * Looping infinito com algum proposito científico ou usado em mainframes.
             * =======================================================================
             */
            int op;

            do {
                Console.WriteLine("1- Listar 2- Processar: 3-Somar: 4-Multiplicar:  5-Dividir:  6-Subtrair:  7-Sair: ");
                op = int.Parse(Console.ReadLine());

                switch (op) {
                    case 1:
                        Console.WriteLine("Mostrando valores");

                        for (var i = 0; i < numeros.Length; i++) {
                            Console.WriteLine(numeros[i]);
                        }
                        break;

                    case 2:
                        Console.WriteLine("Processando valores");
                        foreach (var item in numeros) {
                            soma = soma + item;
                            subtracao = subtracao + item;
                            multi = multi + item;
                            div = Convert.ToDecimal(div) / (item);

                        }
                        break;

                    case 3: {

                            Console.WriteLine($"O valor da soma é: {soma}");
                        }
                        break;

                    case 4: {

                            Console.WriteLine($"O valor da subtração é: {subtracao}");
                        }
                        break;

                    case 5: {
                            Console.WriteLine($"O valor da multiplicação é: {multi}");
                        }
                        break;

                    case 6: {

                            Console.WriteLine($"O valor da divisão é: {div}");

                        }
                        break;

                    case 7: {
                            Console.WriteLine("Programa finalizado");

                        }
                        break;




                }



                Console.WriteLine("_____________");
                Console.WriteLine($"A soma é: " + soma);

                Console.WriteLine("_____________");
                Console.WriteLine($"A subtração é: " + subtracao);

                Console.WriteLine("_____________");
                Console.WriteLine($"A multiplicação é: " + multi);

                Console.WriteLine("_____________");
                Console.WriteLine($"A divisão é: " + div);
                Console.WriteLine("_____________");

            } while (op != 7);
        }
    }
}
