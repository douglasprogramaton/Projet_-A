using System;
using System.Collections.Generic;

namespace Projeto_Exercitando
{
    class Guerra
    {

        public static int baixas;
        public static string nsoldadobr;      //
        public static string nsoldadofarc;   //
        public static int idadeb;
        public static int idadef;
        public static int idadefarc;       //         ATRIBUTOS DA CLASS.
        public static dynamic Items = new List<dynamic>();                        //
        public static void Start()
        {


            List<string> soldadobr = new List<string>();
            List<int> idadebr = new List<int>();
            List<string> nomesfarc = new List<string>();
            List<int> idadefarc = new List<int>();

            string data = String.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);


            Console.WriteLine("Inicio de uma Guerra No territorio amazonico ");
            Console.ReadLine();
            Console.WriteLine("=============================================");
            Console.ReadLine();
            Console.WriteLine($"Digite a quantidade de soldados Brasileiros");
            int QuantidadeBR = int.Parse(Console.ReadLine());
            List<int> Qtdesd = new List<int>();
            for (int i = 0; i < QuantidadeBR; i++)
            {

                Qtdesd.Add(QuantidadeBR + 1);


                Console.WriteLine("Digite a Patente e o Nome do soldadoBR");
                nsoldadobr = Console.ReadLine();

                Console.WriteLine("digite a idade ");
                idadeb = int.Parse(Console.ReadLine());
                idadebr.Add(idadeb);

                DateTime dataEntrada = DateTime.Now;
                Console.WriteLine(dataEntrada);
                Console.WriteLine("Data e horario de entrada na Guerra");
            }

            Console.WriteLine("Inicio de uma Guerra No territorio amazonico ");
            Console.WriteLine("=============================================");
            Console.WriteLine($"Digite a quantidade de soldados das Forças Farc");
            int Quantidadefarc = int.Parse(Console.ReadLine());
            List<int> Qtdes = new List<int>();
            for (int i = 0; i < Quantidadefarc; i++)
            {

                Qtdes.Add(Quantidadefarc + 1);

                Console.WriteLine("Digite a Patente e o Nome do soldadoFarc");
                nsoldadofarc = Console.ReadLine();
                Console.WriteLine("digite a idade ");
                idadef = int.Parse(Console.ReadLine());
                idadefarc.Add(idadef);



            }
        }
    }

}


















