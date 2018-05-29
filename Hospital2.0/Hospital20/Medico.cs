using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital20
{
    public class Medico : Staff
    {
        internal double salario;
        internal string especialidade;

        /// <summary>
        /// Construtor para Médico
        /// </summary>
        /// <param name="nome">Nome</param>
        /// <param name="idade">Idade</param>
        /// <param name="sexo">Sexo</param>
        /// <param name="salario">Salário</param>
        /// 
        public Medico(string nome, int idade, string sexo, double salario, string especialidade)
        {
            base.nome = nome;
            base.idade = idade;
            base.sexo = sexo;
            this.especialidade = especialidade;
            this.salario = salario;
        }

        public Medico()
        {
        }

        public void MostraDadosMedico()
        {
            Console.WriteLine("\n Nome: " + this.nome + "\nIdade: " + this.idade + "\nEspecialidade: " + this.especialidade + "\nSexo: " + this.sexo + "\nSalário base: " + this.salario);
        }

        public override string ToString()
        {
            string s = base.ToString();
            s += "Salário: " + this.Salario + "\n";
            return s;
        }

        public string Salario { get; set; }
        //public IList<Medico> Medicos{ get; set; }

        //public override double GetSalario()
        //{
        //    return this.Salario;
        //}
    }
}
