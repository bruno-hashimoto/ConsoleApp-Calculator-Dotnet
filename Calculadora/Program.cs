using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            bool restart = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Digite o número correspondente ao tipo de operação desejada: ");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Substração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");

                // Recebe a entrada de dados
                string inputOperacao = Console.ReadLine();

                string opcaoSelecionada = "default";

                // Verifica se é um número
                if (Int32.TryParse(inputOperacao, out int number))
                {
                    // Passa string para int
                    int tipoOperacao = int.Parse(inputOperacao);

                    // Informando opção selecionada
                    if (tipoOperacao == 1)
                    {
                        Console.Clear();
                        opcaoSelecionada = "Soma";
                    }
                    else if (tipoOperacao == 2)
                    {
                        Console.Clear();
                        opcaoSelecionada = "Subtração";
                    }
                    else if (tipoOperacao == 3)
                    {
                        Console.Clear();
                        opcaoSelecionada = "Multiplicação";
                    }
                    else if (tipoOperacao == 4)
                    {
                        Console.Clear();
                        opcaoSelecionada = "Divisão";
                    }
                    Console.WriteLine($"{opcaoSelecionada}");

                    switch (tipoOperacao)
                    {
                        case 1:
                            Soma();
                            break;
                        case 2:
                            Subtracao();
                            break;
                        case 3:
                            Multiplicacao();
                            break;
                        case 4:
                            Divisao();
                            break;
                        default:
                            Console.WriteLine("Opção não encontrada");
                            break;
                    }

                    Console.WriteLine("Pressione enter para continuar.");
                    Console.ReadKey();
                    restart = true;
                }
                else
                {
                    Console.WriteLine("Digite somente números.");
                    Console.WriteLine("Pressione enter para continuar.");
                    Console.ReadKey();
                    restart = true;
                }

            } while (restart == true);
        }

        static void Soma()
        {

            Console.Write("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = primeiroValor + segundoValor;
            Console.WriteLine($"A soma dos valores é: {resultado}");

        }

        static void Subtracao()
        {

            Console.Write("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = primeiroValor - segundoValor;
            Console.WriteLine($"O Resultado da subtração é: {resultado}");

        }

        static void Multiplicacao()
        {

            Console.Write("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = primeiroValor * segundoValor;
            Console.WriteLine($"O Resultado da multiplicação é: {resultado}");

        }

        static void Divisao()
        {

            Console.Write("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = primeiroValor / segundoValor;
            Console.WriteLine($"O Resultado da divisão é: {resultado}");

        }
    }

}