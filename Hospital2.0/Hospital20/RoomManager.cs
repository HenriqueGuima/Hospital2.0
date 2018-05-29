using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Hospital20
{
    
    public class RoomManager
    {
        Hashtable rm;

        public RoomManager()
        {
            rm = new Hashtable();
            //Room r = new Room();
        }

        public void AddRoom(int num, Medico m, Paciente p)
        {
            Room r = new Room(num, m, p);
        }
    }
}
