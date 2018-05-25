using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Hospital20
{
    class ConsultaManager
    {
        Hashtable cm;

        public ConsultaManager()
        {
            cm = new Hashtable();
            Consulta c = new Consulta();
        }

        public void AddConsulta(Consulta cl, Médico m, Paciente p)
        {
            cm.Add(cl, cm);
        }


    }
}
