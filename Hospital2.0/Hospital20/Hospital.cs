using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital20
{
    class Hospital
    {
        private int compartimentos;

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
        
    }
}
