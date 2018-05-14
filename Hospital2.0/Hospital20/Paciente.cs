using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Hospital20
{
    public class Paciente
    {
        double saldo;
        int nif;
        int cc;
        string nome;
        int idade;
        bool adse;

        public Paciente()
        {
            saldo = 0.0;
            nif = 000000000;
            cc = 00000000;
            nome = "";
            idade = 0;
            adse = false;
        }

        /// <summary>
        /// Overload
        /// </summary>
        /// <param name="Osaldo"></param>
        /// <param name="Onif"></param>
        /// <param name="Occ"></param>
        /// <param name="Onome"></param>
        /// <param name="Oidade"></param>
        /// <param name="Oadse"></param>
        public Paciente(double Osaldo, int Onif, int Occ, string Onome, int Oidade, bool Oadse)
        {
            saldo = Osaldo;
            Onif = nif;
            Occ = cc;
            Onome = nome;
            Oidade = idade;
            Oadse = adse;
        }

        public double Saldo { get {return saldo; } set {saldo = value; } }
        public int NIF { get {return nif; } set {nif = value; } }
        public int CC { get {return cc; } set {cc = value; } }
        public string Nome { get {return nome; } set {nome = value; } }
        public int Idade{ get {return idade; } set {idade = value; } }
        public bool ADSE{ get {return adse; } set {adse = value; } }
    }
}
