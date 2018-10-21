using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Ingles : Lenguaje
    {

        public override Idiomas Tipo { get { return Idiomas.Ingles; } }


        public override string ObtenerEncabezado(bool formas)
        {
            return formas ? "<h1>Shapes report</h1>" : "<h1>Empty list of shapes!</h1>";
        }



        protected override string TraducirForma(Formas tipo, int cantidad)
        {
            switch (tipo)
            {
                case Formas.Cuadrado:
                    return cantidad == 1 ? "Square" : "Squares";
                case Formas.TrianguloEquilatero:
                    return cantidad == 1 ? "Triangle" : "Triangles";
                case Formas.Circulo:
                    return cantidad == 1 ? "Circle" : "Circles";

            }

            return string.Empty;
        }
        public override string ObtenerLinea(int cantidad, decimal area, decimal perimetro, Formas tipo)
        {

            return (cantidad > 0) ? $"{cantidad} {TraducirForma(tipo, cantidad)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>" : string.Empty;
        }


    }
}
