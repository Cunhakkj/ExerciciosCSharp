using System.Reflection.Metadata;
using System.Xml.Linq;

string nome;
float nota1, nota2, nota3, total;
Console.WriteLine("Digite o número A: ");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o número B: ");
nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o número C: ");
nota3 = float.Parse(Console.ReadLine());

if (nota1 + nota2 >= nota3)
{
    Console.WriteLine("A soma de A + B é maior que C.");
}
 if (nota1 + nota2 <= nota3)
{
    Console.WriteLine("A soma de A + B é menor que C.");
}
if (nota1 + nota2 == nota3)
{
    Console.WriteLine("A soma de A + B é igual a C.");
}