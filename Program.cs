
Console.WriteLine("*** rolando dado ***");

Console.WriteLine();

Console.Write("quantos lados? ");

int lados = Convert.ToInt32(Console.ReadLine());
int rolagem = RandomNumberGenerator.GetInt32(1, lados + 1);

Console.WriteLine($"\nRolagem: {rolagem}");
