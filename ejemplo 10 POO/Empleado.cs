using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_10_POO
{
    class Empleado: Persona 
    {
        private double salario;

        
        public Empleado(string nom,int edad,double salario, Directivo direc)
        {
            this.Nom = nom;
            this.Edad = edad;
            this.Salario = salario;
        }

        public double Salario { get => salario; set => salario = value; }

        public void Mostrar()
        {
            Console.WriteLine(this.salario);
        }
        public void Cal_sal_neto()
        {
            Console.WriteLine("El salario bruto es de: {0}", this.Salario);
        }

    }
}
