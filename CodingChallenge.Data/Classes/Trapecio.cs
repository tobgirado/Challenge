using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : Forma
    {
        public Trapecio(decimal ancho) : base(ancho)
        {
            Tipo = Formas.Trapecio;
        }
    }
}
