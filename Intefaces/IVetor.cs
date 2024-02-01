using ConsoleAluguel.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAluguel.Intefaces
{
    interface IVetor
    {
        public void CreateList(); 
        public Task<List<string>> Getlist();
        public Vetor AdicionaVetor();
    }
}
