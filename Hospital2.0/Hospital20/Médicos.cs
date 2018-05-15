using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital20
{
    class Médicos : Staff
    {
        internal double Salario;

        /// <summary>
        /// Construtor para Médicos
        /// </summary>
        /// <param name="Mnome">Nome</param>
        /// <param name="Midade">Idade</param>
        /// <param name="Msexo">Sexo</param>
        /// <param name="salario">Salário</param>
        public Médicos(string Mnome, int Midade, string Msexo, double salario)
        {
            base.nome = Mnome;
            base.idade = Midade;
            base.sexo = Msexo;
            this.Salario = salario;
        }

        public override string ToString()
        {
            string s = base.ToString();
            s += "Salário: " + this.Salario + "\n";
            return s;
        }

        //public override double GetSalario()
        //{
        //    return this.Salario;
        //}
    }
}
