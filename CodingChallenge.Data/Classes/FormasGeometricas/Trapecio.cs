using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica
    {
        private decimal _lado;
        private decimal _baseMayor;
        private decimal _baseMenor;
        public Trapecio(decimal lado, decimal baseMenor, decimal baseMayor)
        {
            _lado = lado;
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
        }

        public override decimal CalcularArea()
        {
            return (_baseMayor + _baseMenor) * (_lado / 2)*2;
        }

        public override decimal CalcularPerimetro()
        {
            return (_lado)*2 + _baseMayor + _baseMenor;
        }

        
    }
}
