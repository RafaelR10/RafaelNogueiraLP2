﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Carro
{
    class Program
    {
        static void Main(string[] args)
        {
            string modelo;
            double quilometragem;
            int potencia;

            Console.Write("Insira o modelo do veículo");
            modelo = Console.ReadLine();
            Console.Write("Insira a quilometragem do veículo");
            quilometragem = double.Parse(Console.ReadLine());
            Console.Write("Insira a potencia do veículo");
            potencia = int.Parse(Console.ReadLine());

            Console.Write("{0} - ", modelo);

            if (quilometragem > 25000)
            {
                Console.Write("velho -");
            }
            else if (quilometragem <= 500)
            {
                Console.Write("Novo -");
            }
            else
            {
                Console.Write("seminovo - ");
            }

            if (potencia > 170)
            {
                Console.WriteLine("Potente");
            }

            else if (potencia < 90)
            {
                Console.WriteLine("Popular");
            }
            else
            {
                Console.WriteLine("Médio");
            }
        }
    }
}
