using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital20
{
    class Hospital
    {
        private int compartimentos;
        int lid = 1;

        Registo reg = new Registo();


        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Hospital() 
        {
            compartimentos = 200;
        }

        /// <summary>
        /// Overload do Construtor
        /// </summary>
        /// <param name="initCompartimentos"></param>
        public Hospital(int initCompartimentos)
        {
            compartimentos = initCompartimentos;
        }

        internal void AdicionaP(Paciente p)
        {
            p.SetId(++lid);
            reg.AdicionaPacienteRegisto(p, 0);
        }

        internal void MostraFicha()
        {
            reg.MostraFichas();
        }

        internal void GuardaFichas(string file)
        {
            reg.GuardaFichas(file);
        }
        
        internal void LeFichas(string file)
        {
            lid = reg.Info(file);
        }
    }
}
