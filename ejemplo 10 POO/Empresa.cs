﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_10_POO
{
    class Empresa
    {
        private string nom;

        public Empresa(string nom)
        {
            this.Nom = nom;
        }

        public string Nom { get => nom; set => nom = value; }
    }
}
