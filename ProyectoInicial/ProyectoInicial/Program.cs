using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoInicial
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante(11,12,13);
            Console.WriteLine("Nota del estudiante 1: " + estudiante1.getAverage());
            Console.ReadLine();
        }
    }
}
