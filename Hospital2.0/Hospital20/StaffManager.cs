using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Hospital20
{
    internal class StaffManager
    {
        Hashtable stf;

        public StaffManager()
        {
            //var staff = new List<Staff>();
            //for (int i = 0; i < 2; i++)
            //{
            //    staff.Add(new Staff());
            //}

            stf = new Hashtable();

            Staff s = new Staff();

            foreach (DictionaryEntry item in stf)
            {
                string name = (string)item.Key;
                int age = (int)item.Value;
                Console.WriteLine("Name: {0}, Age: {1}", name, age);
            }

            //stf.Add(, stf);

        }

        public void AddMedico(Médico m)
        {
            Médico medic = new Médico("", 0, "", 0.0, "");
            stf.Add(m, medic);
            //Console.WriteLine(medic);
        }

        public void AddCardio(Cardiologista cd)
        {
            Cardiologista card = new Cardiologista("", 0, "", 0.0, "");
            stf.Add(cd, card);
        }
    }
}
