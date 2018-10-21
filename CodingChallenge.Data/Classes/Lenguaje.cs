using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public  abstract class Lenguaje
    {
        public abstract Idiomas Tipo { get;}
        public abstract string ObtenerEncabezado(bool formas);
        protected abstract string TraducirForma(Formas tipo, int cantidad);
        public abstract string ObtenerLinea(int cantidad, decimal area, decimal perimetro, Formas tipo);
    }
}
