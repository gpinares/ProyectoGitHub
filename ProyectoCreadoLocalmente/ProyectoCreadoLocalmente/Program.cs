using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCreadoLocalmente
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante(11.1, 10.5, 9.5);
            Console.WriteLine("Promedio del estudiante: "+ estudiante1.getAverage());
            Console.ReadLine();
        }
    }
}
