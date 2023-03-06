

internal class Program
{
    private static void Main(string[] args)
    {
        double n1=0, n2 = 0;
        int opcao = 0;

        int Menu()
        {
            Console.Clear();
            Console.WriteLine(" 1 - SOMAR");
            Console.WriteLine(" 2 - SUBTRAIR");
            Console.WriteLine(" 3 - MULTIPLICAR");
            Console.WriteLine(" 4 - DIVIDIR");
            Console.WriteLine(" 5 - SAIR");
            Console.WriteLine("Escolha uma opcao: ");
            return int.Parse(Console.ReadLine());
            
        }

        double somar()
        {
            return n1 + n2;
        }

        double subtrair()
        {
            return n1 - n2;
        }

        double multiplicar()
        {
            return n1 * n2;
        }

        double dividir()
        {
            return n1 / n2;
        }


        do
        {

            opcao = Menu();

            if(opcao != 5)
            {
                Console.WriteLine(" Informe o primeiro numero: ");
                n1 = double.Parse(Console.ReadLine());

                Console.WriteLine(" Informe o segundo numero: ");
                n2 = double.Parse(Console.ReadLine());
            }
            
            
            switch (opcao)
            {


                case 1:
                    Console.WriteLine(" A soma dos numeros é: " + somar().ToString("F2"));
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine(" A subtração dos numeros é: " + subtrair().ToString("F2"));
                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine(" A multiplicação  dos numeros é: " + multiplicar().ToString("F2"));
                    Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine(" A divisao  dos numeros é: " + dividir().ToString("F2"));
                    Console.ReadLine();
                    break;

                case 5:
                    Console.WriteLine(" Até logo!");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    Console.ReadLine();
                    break;

            }
        } while (opcao != 5);


    }
}