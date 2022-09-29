using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.Algoritimo33 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"O número antecessor é: {numero - 1 }, e o número sucessor é: {numero + 1 }");
            
        }
    }
}
