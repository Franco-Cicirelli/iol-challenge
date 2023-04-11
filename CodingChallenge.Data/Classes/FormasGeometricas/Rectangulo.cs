using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometrica
    {
        private decimal _altura;
        private decimal _base;
        public Rectangulo(decimal altura, decimal baseRectangulo) 
        {
            _altura = altura;
            _base = baseRectangulo;
        }

        public override decimal CalcularArea()
        {
            return _base * _altura;
        }

        public override decimal CalcularPerimetro()
        {
            return 2 * _base + 2 * _altura;
        }

        
    }
}
