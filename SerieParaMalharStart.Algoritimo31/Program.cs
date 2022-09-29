using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.Algoritimo31 {
    internal class Program {
        static void Main(string[] args) {
            
            
            Console.WriteLine("Digite o primeiro número: ");
            double numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            double numero3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"A média é: {(numero1 + numero2 + numero3) / 3}");
        }
    }
}
