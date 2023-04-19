using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double raio;
            double diametro;
            double area;

            Console.Write("coloque o valor do diâmetro: ");
            diametro = double.Parse(Console.ReadLine());
            raio = diametro / 2;
            area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine("o valor da área é: {0}", area);
        }
    }
}
