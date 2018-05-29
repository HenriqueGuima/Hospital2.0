using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Hospital20
{
    class ConsultaManager
    {
        //Hashtable cm;

        /// <summary>
        /// Gere a consulta criando uma hastable
        /// </summary>
        public ConsultaManager()
        {
            var cm = new Hashtable();
            Consulta c = new Consulta();

        }

        /// <summary>
        /// Método para adicionar uma consulta e respetivo médico e paciente à hastable
        /// </summary>
        /// <param name="cl">Consulta</param>
        /// <param name="m">Médico</param>
        /// <param name="p">Paciente</param>
        public void AddConsulta(Consulta cl, Medico m, Paciente p)
        {
            //var lConsultas = new List<Consulta>();

            //cl = new ConsultaManager
            //{
            //    Medico = m,
            //    Paciente = p;

            //};
            //cm.Add(cl, cm);
        }


    }
}
