using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoTriangulo
{
    internal class Triangulo
    {
        private int _ladoA;
        private int _ladoB;
        private int _ladoC;

        public Triangulo(int ladoA, int ladoB, int ladoC)
        {
            _ladoA = ladoA;
            _ladoB = ladoB;
            _ladoC = ladoC;
        }

        public string identificarTriangulo()
        {
            string tipoTriangulo;

            if (_ladoA == _ladoB && _ladoB == _ladoC)
            {
                tipoTriangulo = "Equilátero";
            }
            else if (_ladoA == _ladoB || _ladoA == _ladoC || _ladoB == _ladoC)
            {
                tipoTriangulo = "Isósceles";
            }
            else
            {
                tipoTriangulo = "Escaleno";
            }

            return tipoTriangulo;
        }
    }
}
