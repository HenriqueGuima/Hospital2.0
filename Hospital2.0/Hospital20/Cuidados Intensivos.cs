using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital20
{
    class Cuidados_Intensivos : Hospital
    {
        private int quartos;

        public Cuidados_Intensivos()
        {
            quartos = 100;
        }

        /// <summary>
        /// Overload
        /// </summary>
        /// <param name="initQuartos"></param>
        public Cuidados_Intensivos(int initQuartos)
        {
            quartos = initQuartos;
        }
    }
}
