using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Exercitando
{
    public class Armamentos
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        public string Municao { get; set; }
        public List<Armamentos> Armamento { get; set; }
        public static List<Armamentos> ItemsArmas { get; set; }

    
       

        public void  Armament()
        {
            

            
            Armamento.Add(new Armamentos { Id = 1, Nome = "AK - 47", Municao = "calibere 7,62mm" });
            Armamento.Add(new Armamentos { Id = 2, Nome = "Colt AR-15", Municao = "calibere 5,52mm" });
            Armamento.Add(new Armamentos { Id = 3, Nome = "FN FAL", Municao = "calivere 7,62mm" });
            Armamento.Add(new Armamentos { Id = 4, Nome = " Koch PSG1", Municao = "calivere 7,62mm" });
            Armamento.Add(new Armamentos { Id = 5, Nome = "Heckler & Koch HK416", Municao = "calivere 7,62mm" });
            Armamento.Add(new Armamentos { Id = 6, Nome = "M4A1", Municao = "calivere 5,56mm" });
            Armamento.Add(new Armamentos { Id = 7, Nome = "M16A1", Municao = "calivere 5,56mm" });
            Armamento.Add(new Armamentos { Id = 8, Nome = "SIG Sauer SIGM400", Municao = "calivere 5,56mm" });
            Armamento.Add(new Armamentos { Id = 9, Nome = "Winchester Model 1910", Municao = "calivere 7,2mm" });
            Armamento.Add(new Armamentos { Id = 10, Nome = "QBU-88", Municao = "calivere 7,62mm" });
         
        }
        public class Outros:Armamentos
        {
            
            static bool armasEequipamentos=true;

            public static void Outro()
            {
                Console.WriteLine("Quantas armas serao utilizadas");
                List<int> Qtdea = new List<int>();
                int armasadd = int.Parse(Console.ReadLine());
                for (int i = 0; i < armasadd; i++)
                {

                    Qtdea.Add(armasadd + 1);

                    Console.WriteLine("Adicione os armatentos e equipamentos desejados");
                    int valor = int.Parse(Console.ReadLine());
                    
                    foreach (var item in ItemsArmas)
                    {
                        ItemsArmas = new List<Armamentos>();
                        
                        Console.WriteLine($" Código: { item.Id } - Item: { item.Nome } - Municao: { item.   Municao } ");
                        Console.ReadLine();
                    }
                    do
                    {
                        if(armasadd== valor) { 
                            Console.WriteLine("Digite o Codigo do aramamento:");
                            int codarmr = int.Parse(Console.ReadLine());
                            var item = (from Armamentos in ItemsArmas where Armamentos.Id == codarmr select Armamentos).SingleOrDefault();
                            Console.WriteLine("---Adicionar mais algum equipamento?\n S-Sim ou qualquer tecla para Nao---");
                            armasEequipamentos = Console.ReadLine().ToUpper() == "S" ? true : false;
                        }
                        else
                        {
                            Console.WriteLine("opção errada");
                            armasEequipamentos = true;
                        }
                    } while (armasEequipamentos);

        

                }

            }
        }

    }
}





