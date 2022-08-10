using System;
using System.Globalization;

namespace LiçãoCalculadora {
    class Program {
        static void Main(string[] args) {
            int opção = 1;
            while (opção != 0) {
                Console.WriteLine("Bem vindo Selecione uma das seguintes opções");
                Console.WriteLine("1 - Calculador IMC");
                Console.WriteLine("2 - Calculador Raio");
                Console.WriteLine("3 - Calculador Regra de 3");
                Console.WriteLine("4 - Sair");
                opção = int.Parse(Console.ReadLine());

                if (opção == 4) {
                    Console.WriteLine("FINALIZADO COM SUCESSO!");
                    break;
                }
                else if (opção == 1) {
                    CalculadoraIMC();
                }
                else if (opção == 2) {
                    CalculadoraRaio();
                }
                else if (opção == 3) {
                    CalculadorRegraDe3();
                }
                else {
                    Console.WriteLine("opção invalida");
                }
                CalculadoraIMC();
                CalculadoraRaio();
                CalculadorRegraDe3();
            }

            static void CalculadoraIMC() {
                float altura, peso, imc;

                Console.Write("Digite o seu peso:");
                peso = float.Parse(Console.ReadLine());

                Console.Write("Digite sua altura no formato 0.00: ");
                altura = float.Parse(Console.ReadLine());

                imc = (peso / (altura * altura));
                Console.WriteLine("Seu IMC É:{0}", imc.ToString("F2"));
            }
            static void CalculadoraRaio() {
                Console.WriteLine("Digite o raio no formato 0.0: ");
                double raio = double.Parse(Console.ReadLine());

                double areaDoCirculo = Math.PI * (raio * raio);
                Console.WriteLine("Raio = " + areaDoCirculo.ToString("F4", CultureInfo.InvariantCulture));
            }
            static void CalculadorRegraDe3() {

            }
        }

    }
}