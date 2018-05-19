using System;
using System.Collections;

namespace Hospital20
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu m = new Menu();
            m.UI();

            //Hospital h;
            //h = new Hospital();

            //Cardiologista Cardio = new Cardiologista("Matias", 45, "Masculino", 9.000, "Cirurgião");
            //IOrgaosVitais iCardio = Cardio;



            //Paciente p2 = new Paciente();
            //Cria uma nova Hastable de pacientes pré-definida
            //Hashtable pp = new Hashtable() {{p2.Nome = "Leonardo", p2.ADSE = true}, {"Joana", 45},{"Henrique", 17}, {"Diana", 15}};

            //Adiciona pacientes novos à hastable
            //Paciente p1 = new Paciente();
            //Console.WriteLine("CC");
            //p1.CC = int.Parse(Console.ReadLine());
            
            //Hashtable pacientes = new Hashtable();
            //pacientes.Add("1", p1.CC);

            //foreach (DictionaryEntry entry in pacientes)
            //{
            //    Console.WriteLine("\nHash: {0}", p1.CC);//((Paciente)entry.Value).CC);

            //}

            Console.ReadKey();
        }
    }
}
