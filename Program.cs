using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Soma();
            Subtracao();
            Divisao();
            Multiplicacao();
            Porcentagem();
            Raiz();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Qual operação você deseja realizar?");
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtracao");
            Console.WriteLine("3. Divisão");
            Console.WriteLine("4. Multiplicação");
            Console.WriteLine("5. Porcentagem");
            Console.WriteLine("6. Raiz");
            Console.WriteLine("7. Sair");

            Console.WriteLine("---------");
            Console.WriteLine("Selecione uma opção");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Porcentagem(); break;
                case 6: Raiz(); break;
                case 7: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }


        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segudo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 + valor2;
            Console.WriteLine($"O resultado da soma é {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segudo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 - valor2;
            Console.WriteLine($"O resultado da subtração é {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            if (valor2 != 0)
            {
                float resultado = valor1 / valor2;
                Console.WriteLine($"O resultado da divisão é {resultado}");
            }
            else
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }

            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 * valor2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Porcentagem()
        {

            Console.Clear();

            Console.WriteLine("Porcentagem: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float valorPorcentagem = valor1 / 100;

            float resultado = valorPorcentagem * valor2;
            Console.WriteLine($"{valor1}% de {valor2} é {resultado}");

            Console.ReadKey();
            Menu();

        }

        static void Raiz()
        {
            Console.Clear();

            Console.WriteLine("Número que deseja encontrar a raiz: ");
            float valor1 = float.Parse(Console.ReadLine());

            double resultado = Math.Sqrt(valor1);

            Console.WriteLine("");


            Console.WriteLine($"O resultado da raiz é {resultado}");

            Console.ReadKey();
            Menu();
        }

    }
}
