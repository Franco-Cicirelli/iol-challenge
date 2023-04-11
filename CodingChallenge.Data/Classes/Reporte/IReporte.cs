using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Reporte
{
    public interface IReporte
    {
        string Imprimir(List<FormaGeometrica> formas);
    }
}
