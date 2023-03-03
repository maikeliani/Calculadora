// See https://aka.ms/new-console-template for more information
double n1, n2;

Console.WriteLine("Informe o primeiro valor");
n1 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo valor");
n2 = double.Parse(Console.ReadLine());


Console.WriteLine(" A soma dos valores é: " + (n1 + n2).ToString("F2") );
Console.WriteLine(" A subtração dos valores é : " + (n1 - n2).ToString("F2"));
Console.WriteLine(  " A multiplicação dos valores é: " + ( n1 * n2).ToString("F2"));

if( n2 != 0)
{
    Console.WriteLine(" A divisão dos valores é : + " + (n1 / n2).ToString("F2"));
}
else
{
    Console.WriteLine(" Não pode dividir por zero");
}
