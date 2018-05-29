using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace Hospital20
{
    public class Staff
    {
        internal string nome;
        internal int idade;
        internal string sexo;
        internal List<Medico> Medicos;

        public Staff()
        {
            nome = "";
            idade = 0;
            sexo = "";

        }

        public Staff(string nome, int idade, string sexo)
        {
            this.nome = nome;
            this.idade = idade;
            this.sexo = sexo;
        }

        public override string ToString()
        {
            string s = "Nome: " + this.nome + "\n";
            s += "Idade: " + this.idade + "\n";
            s += "Sexo: " + this.sexo + "\n";

            return s;
        }

    }
}
