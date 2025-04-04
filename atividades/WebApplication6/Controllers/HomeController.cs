using System;

class HomeController

{
    // Função recursiva para imprimir números decrescentes
    static void ImprimirDecrescente(int n)
    {
        if (n < 1) return;
        Console.WriteLine(n);
        ImprimirDecrescente(n - 1);
    }

    // Função recursiva para somar números de 1 a n
    static int SomarNumeros(int n)
    {
        if (n == 1) return 1;
        return n + SomarNumeros(n - 1);
    }

    // Função recursiva para contar caracteres em uma string
    static int ContarCaracteres(string str, int index = 0)
    {
        if (index == str.Length) return 0;
        return 1 + ContarCaracteres(str, index + 1);
    }

    // Função recursiva para verificar se uma palavra é palíndromo
    static bool EhPalindromo(string palavra, int inicio, int fim)
    {
        if (inicio >= fim) return true;
        if (palavra[inicio] != palavra[fim]) return false;
        return EhPalindromo(palavra, inicio + 1, fim - 1);
    }

    static void Main()
    {
        // Parte 1: Imprimir números decrescentes
        Console.WriteLine("Imprimir números de n até 1:");
        int n = 10; // Valor inicial
        ImprimirDecrescente(n);

        // Parte 2: Somar números de 1 a n
        Console.WriteLine($"\nSoma de 1 até {n}: {SomarNumeros(n)}");

        // Parte 3: Contar caracteres em uma string
        string texto = "Exemplo de texto"; // Texto para análise
        Console.WriteLine($"\nA string '{texto}' contém {ContarCaracteres(texto)} caracteres.");

        // Parte 4: Verificar se uma palavra é um palíndromo
        string palavra = "ARARA"; // Palavra para análise
        if (EhPalindromo(palavra.ToUpper(), 0, palavra.Length - 1))
            Console.WriteLine($"\n'{palavra}' é um palíndromo.");
        else
            Console.WriteLine($"\n'{palavra}' não é um palíndromo.");
    }
}
