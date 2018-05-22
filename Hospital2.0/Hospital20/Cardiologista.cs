using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital20
{
    class Cardiologista : Médico, IOrgaosVitais
    {
        /// <summary>
        /// Especialização 
        /// Cirurgião, Supervisor, Intervencionista
        /// </summary>
        internal string Esp;

        /// <summary>
        /// Construtor para Cardiologista
        /// </summary>
        /// <param name="Cnome">Nome</param>
        /// <param name="Cidade">Idade</param>
        /// <param name="Csexo">Sexo</param>
        /// <param name="Csalario">Salario</param>
        public Cardiologista(string Cnome, int Cidade, string Csexo, double Csalario, string esp) : base(Cnome, Cidade, Csexo, Csalario)
        {
            this.Esp = esp;
        }

        public string Orgao()
        {
            StringBuilder Cardio = new StringBuilder();
            Cardio.AppendLine("Médico: ");
            Cardio.AppendLine(this.GetType().Name);
            Cardio.AppendLine(nome);
            Cardio.AppendLine(idade.ToString());
            Cardio.AppendLine(sexo);
            Cardio.AppendLine(Salario.ToString());
            Cardio.AppendLine(Esp);

            //return "Coração";
            return Cardio.ToString();
        }
    }
}
