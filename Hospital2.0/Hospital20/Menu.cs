using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital20
{
    
    class Menu
    {
        Hospital h;

        public void UI()
        {
            h = new Hospital();
            int op;

            do
            {
                Console.WriteLine("----- Bem-vindo ----");
                Console.WriteLine("1 - Registar Paciente");
                Console.WriteLine("2 - Listar Pacientes");
                Console.WriteLine("3 - Atualizar Pacientes");
                //Console.WriteLine("4 - Novo Médico");
                Console.WriteLine("0 - Exit");

                Console.WriteLine("Opção: ");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        RegistaPacientes();
                        break;
                    case 2:
                        h.MostraFicha();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

            } while (op != 0);
        }

        public void RegistaPacientes()
        {
            int op;

            Console.Clear();
            Console.WriteLine("----- Resgistar Novo Paciente ----");
            Console.WriteLine("Em que área?");
            Console.WriteLine("1 - Cardiologia");
            Console.WriteLine("2 - Neurologia");
            Console.WriteLine("3 - Psicologia");
            Console.WriteLine("4 - Pediatria");
            Console.WriteLine("0 - Exit");

            Console.Write("Introduza uma opção: ");
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("----- Resgisto de um novo paciente em CARDIOLOGIA ----");
                    Console.Write("Nome: ");
                    string n = Console.ReadLine();
                    Console.Write("Idade: ");
                    int i = Int32.Parse(Console.ReadLine());
                    Console.Write("CC: ");
                    int cc = Int32.Parse(Console.ReadLine());
                    Console.Write("NIF: ");
                    int nif = Int32.Parse(Console.ReadLine());
                    Console.Write("ADSE: ");
                    bool adse = bool.Parse(Console.ReadLine());

                    Paciente pc = new Paciente(nif, cc, n, i, adse);
                    h.AdicionaP(pc);
                    break;
                case 2:
                    Console.WriteLine("----- Resgisto de um novo paciente em NEUROLOGIA ----");
                    Console.Write("Nome: ");
                    string nn = Console.ReadLine();
                    Console.Write("Idade: ");
                    int inn = Int32.Parse(Console.ReadLine());
                    Console.Write("CC: ");
                    int ccn = Int32.Parse(Console.ReadLine());
                    Console.Write("NIF: ");
                    int nifn = Int32.Parse(Console.ReadLine());
                    Console.Write("ADSE: ");
                    bool adsen = bool.Parse(Console.ReadLine());

                    Paciente pn = new Paciente(nifn, ccn, nn, inn, adsen);
                    h.AdicionaP(pn);

                    break;
                case 3:
                    Console.WriteLine("----- Resgisto de um novo paciente em PSICOLOGIA ----");
                    Console.Write("Nome: ");
                    string np = Console.ReadLine();
                    Console.Write("Idade: ");
                    int ip = Int32.Parse(Console.ReadLine());
                    Console.Write("CC: ");
                    int ccp = Int32.Parse(Console.ReadLine());
                    Console.Write("NIF: ");
                    int nifp = Int32.Parse(Console.ReadLine());
                    Console.Write("ADSE: ");
                    bool adsep = bool.Parse(Console.ReadLine());

                    Paciente pp = new Paciente(nifp, ccp, np, ip, adsep);
                    h.AdicionaP(pp);

                    break;
                case 4:
                    Console.WriteLine("----- Resgisto de um novo paciente em PEDIATRIA" +
                        " ----");
                    Console.Write("Nome: ");
                    string npe = Console.ReadLine();
                    Console.Write("Idade: ");
                    int ipe = Int32.Parse(Console.ReadLine());
                    Console.Write("CC: ");
                    int ccpe = Int32.Parse(Console.ReadLine());
                    Console.Write("NIF: ");
                    int nifpe = Int32.Parse(Console.ReadLine());
                    Console.Write("ADSE: ");
                    bool adsepe = bool.Parse(Console.ReadLine());

                    Paciente ppe = new Paciente(nifpe, ccpe, npe, ipe, adsepe);
                    h.AdicionaP(ppe);

                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
