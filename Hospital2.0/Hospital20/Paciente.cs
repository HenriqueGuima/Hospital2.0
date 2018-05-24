using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Hospital20
{
    public class Paciente
    {
        //double saldo;
        int nif;
        int cc;
        string nome;
        int idade;
        bool adse;
        internal int id;

        public Paciente()
        {
            //saldo = 0.0;
            nif = 0;
            cc = 0;
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
        public Paciente(int nif, int cc, string nome, int idade, bool adse)
        {
            this.nif = nif;
            this.cc = cc;
            this.nome = nome;
            this.idade = idade;
            this.adse = adse;
        }

        internal object GetId()
        {
            return this.id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        

        //public double Saldo { get {return saldo; } set {saldo = value; } }
        public int NIF { get {return nif; } set {nif = value; } }
        public int CC { get {return cc; } set {cc = value; } }
        public string Nome { get {return nome; } set {nome = value; } }
        public int Idade{ get {return idade; } set {idade = value; } }
        public bool ADSE{ get {return adse; } set {adse = value; } }
    }

    //public string InscrevePaciente(int nif, int cc, string nome, int idd, bool adse)
    //{
    //    List<Paciente> pcs = new List<Paciente>();
    //    Console.WriteLine("Nome: ");
    //    nome = Console.ReadLine();
    //    pcs.Add(new Paciente { Nome = nome });

    //    return pcs;
    //}
}
