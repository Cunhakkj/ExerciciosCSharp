string nome;
float N;
Console.WriteLine("Digite o valor de N: ");
N = float.Parse(Console.ReadLine());
if (N <= 10) 
{
    Console.WriteLine("Termina-se F1");
}
if (N > 10 && N <= 100) 
{ 
    Console.WriteLine("Termina-se F2");
} 

if (N > 100) 
{
    Console.WriteLine("Termina-se F3");
}
