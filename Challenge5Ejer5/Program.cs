using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5Ejer5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro perro = new Perro();
            Console.WriteLine("Indique el nombre del perro");
            perro.SetNombre(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(perro.GetNombre());
            perro.Comer();

            Console.ReadKey();
        }
    }
}
