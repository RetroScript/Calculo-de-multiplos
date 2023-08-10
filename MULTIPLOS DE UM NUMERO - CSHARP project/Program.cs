
Console.WriteLine("Hello, world!");
Console.WriteLine("Insira um numero para ver seus multiplos");

string? userInput;
int numeroEscolhido;
int multiploResultante;

Console.WriteLine("O numero escolhido é: ");
userInput = Console.ReadLine();
numeroEscolhido = Convert.ToInt32(userInput);

Console.WriteLine($"TABUADA DO: {numeroEscolhido}");

for (int i = 0; i <= 10; i++)
{
    multiploResultante = numeroEscolhido * i;

    Console.WriteLine($"{numeroEscolhido} X {i} = {multiploResultante}");
}
