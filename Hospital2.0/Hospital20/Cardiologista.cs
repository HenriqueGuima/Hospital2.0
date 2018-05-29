using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital20
{
    /// <summary>
    /// Classe que constrói o objeto cardiologista
    /// </summary>
    class Cardiologista : Medico, IOrgaosVitais
    {
        /// <summary>
        /// Especialização 
        /// Cirurgião, Supervisor, Intervencionista
        /// </summary>
        internal string esp;

        /// <summary>
        /// Construtor para Cardiologista
        /// </summary>
        /// <param name="nome">Nome</param>
        /// <param name="idade">Idade</param>
        /// <param name="sexo">Sexo</param>
        /// <param name="salario">Salario</param>
        public Cardiologista(string nome, int idade, string sexo, double salario, string esp) : base(nome, idade, sexo, salario, esp)
        {
            this.esp = esp;
        }

        /// <summary>
        /// Retornar os valores inseridos para cardiologista
        /// </summary>
        /// <returns></returns>
        public string Orgao()
        {
            StringBuilder Cardio = new StringBuilder();
            Cardio.AppendLine("Médico: ");
            Cardio.AppendLine(this.GetType().Name);
            Cardio.AppendLine(nome);
            Cardio.AppendLine(idade.ToString());
            Cardio.AppendLine(sexo);
            Cardio.AppendLine(salario.ToString());
            Cardio.AppendLine(esp);

            //return "Coração";
            return Cardio.ToString();
        }
    }
}
