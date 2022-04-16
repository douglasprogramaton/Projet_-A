using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Exercitando
{
    class Armamentos
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        public string munição { get; set; }
        public List<Armamentos> armamentos;
        public List<Armamentos> ItemsArmas { get; set; }




        Armamentos()
        {
            ItemsArmas = new List<Armamentos>();
            armamentos.Add(new Armamentos { Id = 1, });
        }
    }
}





