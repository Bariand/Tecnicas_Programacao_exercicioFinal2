/*      2. Crie um programa que armazene 4 números digitados pelo usuário em dois vetores: um somente para números pares, 
 *      e outro somente para números ímpares. Após, exiba os valores dos dois vetores na tela, em sequência.
        a. As posições que não receberem valores exibirão o número zero. Não se preocupe com isso por enquanto.
*/

int[] numerosPares = new int[4];
int[] numerosImpares = new int[4];
string numeroString = "";
bool boolValue = false;

for (int i = 0; i < numerosPares.Length; i++)
{
        Console.WriteLine($"Insira o {i + 1}º número inteiro positivo:");
        numeroString = Console.ReadLine();

        boolValue = int.TryParse(numeroString, out int numeroOut);

        if (boolValue)
        {
            if (numeroOut >= 0)
            {
                numerosPares[i] = numeroOut;
            }
            else
            {
                i--;
                Console.WriteLine("O número precisa ser positivo.");
            }
        }
        else
        {
            i--;
            Console.WriteLine("O valor inserido não é um número inteiro.");
        };
};

for (int i = 0; i < numerosImpares.Length; i++)
{
    Console.WriteLine($"Insira o {i + 1}º número inteiro negativo:");
    numeroString = Console.ReadLine();

    boolValue = int.TryParse(numeroString, out int numeroOut);

    if (boolValue)
    {
        if (numeroOut < 0)
        {
            numerosImpares[i] = numeroOut;
        }
        else
        {
            i--;
            Console.WriteLine("O número precisa ser negativo.");
        }
    }
    else
    {
        i--;
        Console.WriteLine("O valor inserido não é um número inteiro.");
    };
};

for (int y = 0; y < numerosPares.Length; y++)
{
    Console.WriteLine($"{y + 1} valor: {numerosPares[y]}");
}
for (int y = 0; y < numerosImpares.Length; y++)
{
    Console.WriteLine($"{y + 1} valor: {numerosImpares[y]}");
}
Console.ReadLine();