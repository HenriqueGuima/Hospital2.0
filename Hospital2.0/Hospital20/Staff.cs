﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace Hospital20
{
    class Staff
    {
        internal string nome;
        internal int idade;
        internal string sexo;

        public override string ToString()
        {
            string s = "Nome: " + this.nome + "\n";
            s += "Idade: " + this.idade + "\n";
            s += "Sexo: " + this.sexo + "\n";

            return s;
        }

        
    }
}
