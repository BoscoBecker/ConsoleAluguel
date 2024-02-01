using ConsoleAluguel.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAluguel.Entidades
{
    public class Vetor : IVetor
    {     
        Pensionato pensionato;
        List<string> RoomsBusy;

        public void CreateList()
        {
            RoomsBusy = new List<string>();
        }

        public async Task<List<string>> Getlist()
        {
            return RoomsBusy; 
        }

        public Vetor AdicionaVetor()
        {
            CreateList();
            Pensionato[] Vect = new Pensionato[9];
            for (int i = 0; i < 9; i++)
            {
                Console.Write("Infome seu Nome: ");
                string name;
                name = Console.ReadLine();

                Console.Write("Infome seu Email: ");
                string email;
                email = Console.ReadLine();

                Console.Write("Informe qual quarto deseja ficar: ");
                int room;
                room = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                Vect[room] = pensionato = new Pensionato { Name = name, Email = email, Room = room };
                RoomsBusy.Add("Nome: " + name + " Email: " + email + " Room: " + room);

                Console.WriteLine("Deseja reservar outro quarto ? S/N ");
                string Resultado = Console.ReadLine();

                if (Resultado == "N" || Resultado == "n") break;

            }
            return this;
        }
    }
}
