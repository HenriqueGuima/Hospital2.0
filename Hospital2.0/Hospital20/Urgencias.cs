using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital20
{
    class Urgencias : Hospital
    {
        private int quartos;

        public Urgencias()
        {
            quartos = 100;
        }

        /// <summary>
        /// Overload
        /// </summary>
        /// <param name="initQuartos"></param>
        public Urgencias(int initQuartos)
        {
            quartos = initQuartos;
        }
    }
}
