string nome;
float valorA, valorB;
Console.WriteLine("Digite o valor de A: ");
valorA = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o Valor de B: ");
valorB = float.Parse(Console.ReadLine());

if (valorA >= valorB) 
{
    Console.WriteLine("Tem o valor maior: " + valorA);
}
else if (valorB >= valorA)
{
    Console.WriteLine("Tem o valor maior: " + valorB);
}
