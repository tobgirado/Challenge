using System;

namespace CodingChallenge.Data.Classes
{
    public abstract class Forma
    {
        protected readonly decimal _lado;
        
        public Formas Tipo { get; set; }

        public Forma(decimal ancho)
        {            
            _lado = ancho;
        }

        public virtual decimal CalcularArea() {
            throw new ArgumentOutOfRangeException(@"Forma desconocida");
        }

        public virtual decimal CalcularPerimetro() {
            throw new ArgumentOutOfRangeException(@"Forma desconocida");
        }

    }
}
