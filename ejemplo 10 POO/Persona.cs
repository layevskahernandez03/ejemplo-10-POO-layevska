using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_10_POO
{
    class Persona
    {
       private string nom;
       private  int edad;

        public Persona()
        {

        }
        public Persona(string nom, int edad)
        {
            this.Nom = nom;
            this.Edad = edad;
        }

        public string Nom { get => nom; set => nom = value; }
        public int Edad { get => edad; set => edad = value; }

        public void Mostra()
        {
            Console.WriteLine(this.nom);
            Console.WriteLine(this.Edad);
        }
    }
}
