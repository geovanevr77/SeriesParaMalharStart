using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.Algoritimo28 {

    
    internal class Program {

        
        static void Main(string[] args) {
            
            Sigla s = new Sigla();
            s.Descricao = "Senai";
            Console.WriteLine(s.mostrarSignificado());
            Console.ReadKey();

            
        }
    }
}
