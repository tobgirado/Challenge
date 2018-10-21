using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Acumulador
    {

        public List<Modelo> m = new List<Modelo>();

        public void Acumular(Forma forma)
        {
            if (m.Any(x => x.Forma.Tipo == forma.Tipo))
            {
                var yx = m.Where(x => x.Forma.Tipo == forma.Tipo).FirstOrDefault();
                yx.Incrementar(1, forma.CalcularArea(), forma.CalcularPerimetro());
            }
            else
            {
                m.Add(new Modelo(forma, 1, forma.CalcularArea(), forma.CalcularPerimetro()));
            }
        }


    }
   
}
