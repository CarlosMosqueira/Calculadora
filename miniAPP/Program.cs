using System;

namespace miniAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            String opcaoUsuario =  opcoes();
            while(opcaoUsuario != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        adicao();
                        break;
                    case "2":
                        subtracao();
                        break;
                    case "3":
                        multiplicacao();
                        break;
                    case "4":
                        divisao();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = opcoes();
            }

            Console.WriteLine("Obrigado por Utilizar Nossos Serviços");
            Console.ReadLine();
        }

        private static void divisao()
        {
            Console.WriteLine("Informe o primeiro número: ");
            int div1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            int div2 = int.Parse(Console.ReadLine());

            int resultado = div1 / div2;
            Console.WriteLine($"A divisao entre {div1} e {div2} é {resultado}");
        }

        private static void multiplicacao()
        {
            Console.WriteLine("Informe o primeiro número: ");
            int mult1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            int mult2 = int.Parse(Console.ReadLine());

            int resultado = mult1 + mult2;
            Console.WriteLine($"A multiplicacao entre {mult1} e {mult2} é {resultado}");
        }

        private static void subtracao()
        {
            Console.WriteLine("Informe o primeiro número: ");
            int sub1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            int sub2 = int.Parse(Console.ReadLine());

            int resultado = sub1 + sub2;
            Console.WriteLine($"A subtração entre {sub1} e {sub2} é {resultado}");
        }

        private static void adicao()
        {
            Console.WriteLine("Informe o primeiro número: ");
            int adicao1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            int adicao2 = int.Parse(Console.ReadLine());

            int resultado = adicao1 + adicao2;
            Console.WriteLine($"A adição entre {adicao1} e {adicao2} é {resultado}");   
        }

        private static string opcoes()
        {
            Console.WriteLine();
            Console.WriteLine("Bem vindo a calculadora");
            Console.WriteLine();

            Console.WriteLine("1 - ADIÇÃO");
            Console.WriteLine("2 - SUBTRAÇÃO");
            Console.WriteLine("3 - MULTIPLICAÇÃO");
            Console.WriteLine("4 - DIVISÃO");
            Console.WriteLine("C - LIMPAR");
            Console.WriteLine("X - SAIR");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
