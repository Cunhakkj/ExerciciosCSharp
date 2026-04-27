string nome;
float idade, soma, total;
Console.WriteLine("Digite a sua idade: ");
idade = float.Parse(Console.ReadLine());

soma = idade * 12;
total = soma * 30;
Console.WriteLine("Você tem " + total + " dias vividos");
