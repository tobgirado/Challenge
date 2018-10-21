using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CodingChallenge.Data.Classes
{
    public class Reportes
    {

        public static string Imprimir(List<Forma> formas, Lenguaje idioma)
        {
            var sb = new StringBuilder();
            var acumulador = new Acumulador();
            if (!formas.Any())
            {
                sb.Append(idioma.ObtenerEncabezado(formas.Any()));
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER

                sb.Append(idioma.ObtenerEncabezado(formas.Any()));

                foreach (var forma in formas)
                {

                    acumulador.Acumular(forma);
                }

                foreach (var figurina in acumulador.m)
                {
                    sb.Append(idioma.ObtenerLinea(figurina.Numero, figurina.Area, figurina.Perimetro,figurina.Forma.Tipo));
                }


                // FOOTER
                sb.Append("TOTAL:<br/>");
                sb.Append(acumulador.m.Sum(x => x.Numero) + " " + (idioma.Tipo == Idiomas.Castellano ? "formas" : "shapes") + " ");
                sb.Append((idioma.Tipo == Idiomas.Castellano ? "Perimetro " : "Perimeter ") + acumulador.m.Sum(x => x.Perimetro).ToString("#.##") + " ");
                sb.Append("Area " + acumulador.m.Sum(x => x.Area).ToString("#.##"));
            }

            return sb.ToString();
        }
    }
}
