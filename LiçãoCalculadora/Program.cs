using System;
using System.Globalization;

namespace LiçãoCalculadora {
    class Program {
        static void Main(string[] args) {
            ExibirMenu();
            CalculadoraIMC();
            CalculadoraRaio();
            CalculadoraRegraDe3();
        }
        static void ExibirMenu() {
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
                    CalculadoraRegraDe3();
                }
                else {
                    Console.WriteLine("opção invalida");
                }

            }
        }
        static float CIMC(float altura, float peso) {
            return (peso / (altura * altura));
        }
        static void CalculadoraIMC() {
            float altura, peso, imc;

            Console.Write("Digite seu peso:");
            peso = float.Parse(Console.ReadLine());

            Console.Write("Digite sua altura no formato 0.00: ");
            altura = float.Parse(Console.ReadLine());
            imc = CIMC(altura, peso);

            Console.WriteLine("Seu IMC É:" + imc);
            if (imc < 18.5) {
                Console.WriteLine("Peso abaixo do normal");
            }
            else if ((imc > 18.5) && (imc < 25)) {
                Console.WriteLine("Peso normal");
            }
            else if ((imc > 25) && (imc < 30)) {
                Console.WriteLine("Sobre o Peso");
            }
            else if ((imc > 30) && (imc < 35)) {
                Console.WriteLine("Grau de Obesidade I");
            }
            else if ((imc > 35) && (imc < 40)) {
                Console.WriteLine("Grau de Obesidade II");
            }
            else if (imc > 40) {
                Console.WriteLine("Obesidade Grau III");
            }
        }
        static double CRaio(double raio) {
            return Math.PI * (raio * raio);
        }
        static void CalculadoraRaio() {
            Console.WriteLine("Digite o raio no formato 0.0: ");
            double raio = double.Parse(Console.ReadLine());

            var areaDoCirculo = CRaio(raio);
            Console.WriteLine("Raio = " + areaDoCirculo.ToString("F4", CultureInfo.InvariantCulture));
        }

        static int CRegra3(int X, int Y, int Z) {
            return (X * Y) / Z;
        }
        static void CalculadoraRegraDe3() {
            int X, Y, Z, Resultado;
            Console.WriteLine("Digite o valor de X:");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de Y");
            Y = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de Z");
            Z = int.Parse(Console.ReadLine());
            Resultado = CRegra3(X, Y, Z);

            Console.WriteLine("Resultado:" + Resultado);
        }
    }
}
