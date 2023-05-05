using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_10_POO
{
    class Cliente: Persona
    {
        private int tel;

        public Cliente(string nom,int edad,int tel)
        {
            this. Nom = nom;
            this.Edad = edad;
            this.Tel = tel;
        }

        public int Tel { get => tel; set => tel = value; }
         
        public void Mostrar()
        {
            Console.WriteLine(this.Nom);
            Console.WriteLine(this.Edad);
            Console.WriteLine(this.Tel);
        }
    }
}
