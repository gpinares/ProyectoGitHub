using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoInicial
{
    class Estudiante
    {
        private string name;
        private int nota1;
        private int nota2;
        private int nota3;
        private int nota4;

        public Estudiante(int n1, int n2, int n3, int n4) {
            Nota1 = n1;
            Nota2 = n2;
            Nota3 = n3;
            Nota4 = n4;

        }
        /// <summary>
        /// Obtiene el promedio de las 3 notas, retornando un double
        /// </summary>
        /// <returns></returns>
        public double getAverage()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }
        public int Nota1
        {
            get
            {
                return nota1;
            }

            set
            {
                nota1 = value;
            }
        }

        public int Nota2
        {
            get
            {
                return nota2;
            }

            set
            {
                nota2 = value;
            }
        }

        public int Nota3
        {
            get
            {
                return nota3;
            }

            set
            {
                nota3 = value;
            }
        }

        public int Nota4
        {
            get
            {
                return nota4;
            }

            set
            {
                nota4 = value;
            }
        }
    }
}
