using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital20
{
    class Cardiologista : Médicos, IOrgaosVitais
    {
        public string Orgao()
        {
            return "Coração";
        }
    }
}
