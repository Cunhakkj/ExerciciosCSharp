string nome;
int a, b, c, troca;
float menor, meio, maior;
Console.WriteLine("Digite o primeiro número: ");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o terceiro número: ");
c = int.Parse(Console.ReadLine());

if (a > b) {
    troca = a;
    a = b;
    b = troca;
}
if (a > c) {
    troca = a;
    a = c;
    c = troca;
}
if (b > c) {
    troca = b;
    b = c;
    c = troca;
}
Console.WriteLine("Números em ordem crescente: ");
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
