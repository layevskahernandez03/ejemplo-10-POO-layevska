using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_10_POO
{
    class Directivo
    {
        private string categoria;

        public Directivo(string categoria)
        {
            this.Categoria = categoria;
        }

        public string Categoria { get => categoria; set => categoria = value; }

        public void Mostar()
        {
            Console.WriteLine("el puesto que tiene el empliado es: {0}", this.Categoria);
        }
    }
}
