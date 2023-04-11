using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data
{
    public  class ReporteTemplate
    {
        public string EmptyListMessage;

        public  string Header;

        public  string Formas;

        public  string Perimeter;

        public  string Total;

        public  string Area;

        public ReporteTemplate(string emptyListMessage, string header, string formas, string perimeter, string total, string area)
        {
            EmptyListMessage = emptyListMessage;
            Header = header;
            Formas = formas;
            Perimeter = perimeter;
            Total = total;
            Area = area;
        }
    }
}
