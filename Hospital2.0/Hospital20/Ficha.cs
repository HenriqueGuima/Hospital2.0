using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital20
{
    class Ficha
    {
        Paciente paciente;
        int nr;

        public Paciente GetPaciente()
        {
            return paciente;
        }

        public int GetNumero()
        {
            return nr;
        }

        public Ficha(Paciente pt, int nu)
        {
            paciente = pt;
            nr = nu;
        }

        public override string ToString()
        {
            string s = "-------------------------\n";
            s += "Quantidade: " + nr.ToString() + "\n";
            s += paciente.ToString();
            s += "-------------------------";

            return s;
        }
    }
}
