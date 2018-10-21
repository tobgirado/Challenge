using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Castellano : Lenguaje
    {
       
        public override Idiomas Tipo { get { return Idiomas.Castellano; } }

        public override string ObtenerEncabezado(bool formas)
        {
            return formas ? "<h1>Reporte de Formas</h1>" : "<h1>Lista vacía de formas!</h1>";
        }

        public override string ObtenerLinea(int cantidad, decimal area, decimal perimetro, Formas tipo)
        {
            return (cantidad > 0) ? $"{cantidad} {TraducirForma(tipo, cantidad)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>" : string.Empty;
        }

        protected override string TraducirForma(Formas tipo, int cantidad)
        {
            switch (tipo)
            {
                case  Formas.Cuadrado:
                    return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                case Formas.TrianguloEquilatero :
                    return cantidad == 1 ? "Triángulo" : "Triángulos";
                case Formas.Circulo:
                    return cantidad == 1 ? "Círculo" : "Círculos";
            }
            return string.Empty;
        }
    }
}
