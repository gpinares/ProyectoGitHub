using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCreadoLocalmente
{
    class Estudiante
    {
        private string name;
        private double nota1;
        private double nota2;
        private double nota3;

        public Estudiante(double n1, double n2, double n3)
        {
            Nota1 = n1;
            Nota2 = n2;
            Nota3 = n3;
        }

        public double Nota1
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

        public double Nota2
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

        public double Nota3
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

        /// <summary>
        /// Esta funcion obtiene el promedio de las 3 notas del alumno
        /// </summary>
        /// <returns></returns>
        public double getAverage()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }
    }
}
