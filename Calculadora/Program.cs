using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        double n1, n2;
        int opcao = 0;

        void Menu()
        {
            Console.Clear();
            Console.WriteLine(" 1 - SOMAR");
            Console.WriteLine(" 2 - SUBTRAIR");
            Console.WriteLine(" 3 - MULTIPLICAR");
            Console.WriteLine(" 4 - DIVIDIR");
            Console.WriteLine(" 5 - SAIR");
            Console.WriteLine("Escolha uma opcao: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {

                default:
                    Console.WriteLine("Opção inválida!");
                    Console.ReadLine();
                    break;

                case 1:
                    Console.WriteLine(" A soma dos numeros é: " + (n1 + n2));
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine(" A subtração dos numeros é: " + (n1 - n2));
                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine(" A multiplicação  dos numeros é: " + (n1 * n2));
                    Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine(" A divisao  dos numeros é: " + (n1 / n2));
                    Console.ReadLine();
                    break;

                case 5:
                    Console.WriteLine(" Até logo!");
                    Console.ReadLine();
                    break;

            }
        }


        Console.WriteLine(" Informe o primeiro numero: ");
        n1 = double.Parse(Console.ReadLine());

        Console.WriteLine(" Informe o segundo numero: ");
        n2 = double.Parse(Console.ReadLine());

        while (opcao != 5)
        {
            Menu();
        }


    }
}