using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital20
{
    abstract class Staff
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
