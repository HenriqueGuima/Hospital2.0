using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital20
{
    public class Médico : Staff
    {
        internal double Salario;
        internal string especialidade;

        /// <summary>
        /// Construtor para Médico
        /// </summary>
        /// <param name="Mnome">Nome</param>
        /// <param name="Midade">Idade</param>
        /// <param name="Msexo">Sexo</param>
        /// <param name="salario">Salário</param>
        /// 
        public Médico(string nome, int idade, string sexo, double salario, string especialidade)
        {
            base.nome = nome;
            base.idade = idade;
            base.sexo = sexo;
            this.especialidade = especialidade;
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
