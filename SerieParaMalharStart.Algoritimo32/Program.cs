using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.Algoritimo32 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite um número: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine($"O {n1} é do tipo ", n1.GetType());
        }
    }
}
