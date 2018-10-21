using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Modelo
    {
        public Forma Forma { get; set; }
        public int Numero { get; set; }
        public decimal Area { get; set; }
        public decimal Perimetro { get; set; }
        public Modelo(Forma f, int n, decimal a, decimal p)
        {
            Forma = f;
            Numero = n;
            Area = a;
            Perimetro = p;
        }
        public void Incrementar(int n, decimal a, decimal p)
        {
            Numero += n;
            Area += a;
            Perimetro += p;
        }
    }
}
