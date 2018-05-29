using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Hospital20
{
    internal class StaffManager
    {
        Hashtable stf;
        private List<Medico> med;

        public StaffManager()
        {
            //var staff = new List<Staff>();
            //for (int i = 0; i < 2; i++)
            //{
            //    staff.Add(new Staff());
            //}

            //stf = new Hashtable();

            var stf = new List<Staff>();

            //Staff s = new Staff();

            //foreach (DictionaryEntry item in stf)
            //{
            //    string name = (string)item.Key;
            //    int age = (int)item.Value;
            //    Console.WriteLine("Name: {0}, Age: {1}", name, age);
            //}

            //stf.Add(, stf);

            var staff = new Staff
            {
                Medicos = med,

            };
            stf.Add(staff);

        }

        public void AddMedico(Medico m)
        {
            Medico medic = new Medico("", 0, "", 0.0, "");
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
