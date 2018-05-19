using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.IO;

namespace Hospital20
{
    internal class Registo
    {
        Hashtable fichas;

        public Registo()
        {
            fichas = new Hashtable();
        }

        internal void AdicionaPacienteRegisto(Paciente p, int q)
        {
            Ficha f = new Ficha(p, q);
            fichas.Add(p.GetId(), f);
        }

        internal void MostraFichas()
        {
            Console.Clear();
            Console.WriteLine("--- Fichas -----");

            foreach (DictionaryEntry de in fichas)
            {
                Console.WriteLine(de.Value.ToString());
            }
            Console.WriteLine("--- Press enter to continue ---");
            Console.ReadLine();
        }

        internal void GuardaFichas(string fileName)
        {
            StreamWriter sw = File.CreateText(fileName);

            foreach (DictionaryEntry de in fichas)
            {
                Ficha fi = de.Value as Ficha;
                IGuardaInfo iguarda = fi.GetPaciente() as IGuardaInfo;
                if (iguarda != null)
                {
                    sw.WriteLine(fi.GetNumero());
                    sw.Write(iguarda.GenerateTextRepresentation());
                }
            }

            sw.Close();
        }

        internal int Info(string fileName)
        {
            int lid = 0;
            StreamReader sr = new StreamReader(fileName);
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                int qt = Convert.ToInt32(line);
                Paciente pc = new Paciente();

                if (pc != null)
                {
                    Ficha fi = new Ficha(pc, qt);
                    fichas.Add(pc.GetId(), fi);
                    lid = pc.id;
                }
            }
            sr.Close();

            return lid;
        }
    }
}
