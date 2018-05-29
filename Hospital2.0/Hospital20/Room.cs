using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital20
{
    public class Room
    {

        List<Room> rooms = new List<Room>();

        //Room room = new Room()
        //{
        //    Staffs = new List<Staff>()
        //    {
        //        new Staff()
        //        {
        //            nome = "José",
        //            Medicos = new List<Medico>()
        //            {
        //                new Medico("", 0, "", 0, ""),
        //            }
        //        },
        //    },

        //    Pacientes = new List<Paciente>()
        //    {
        //        new Paciente(0, 0, "", 0, true),
        //    }

        //};

        private int num;
        private int v;
        private Medico medico;

        //public List<Medico> Medicos { get; private set; }
        public List<Staff> Staffs { get; private set; }
        public List<Paciente> Pacientes { get; private set; }
        //internal int num;

        public Room(int num, Medico m, Paciente p)
        {
            this.num = num;

        }

        public Room(int v, Medico medico)
        {
            this.v = v;
            this.medico = medico;
        }
    }
}
