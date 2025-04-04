using System;

class HomeController

{
    // Fun��o recursiva para imprimir n�meros decrescentes
    static void ImprimirDecrescente(int n)
    {
        if (n < 1) return;
        Console.WriteLine(n);
        ImprimirDecrescente(n - 1);
    }

    // Fun��o recursiva para somar n�meros de 1 a n
    static int SomarNumeros(int n)
    {
        if (n == 1) return 1;
        return n + SomarNumeros(n - 1);
    }

    // Fun��o recursiva para contar caracteres em uma string
    static int ContarCaracteres(string str, int index = 0)
    {
        if (index == str.Length) return 0;
        return 1 + ContarCaracteres(str, index + 1);
    }

    // Fun��o recursiva para verificar se uma palavra � pal�ndromo
    static bool EhPalindromo(string palavra, int inicio, int fim)
    {
        if (inicio >= fim) return true;
        if (palavra[inicio] != palavra[fim]) return false;
        return EhPalindromo(palavra, inicio + 1, fim - 1);
    }

    static void Main()
    {
        // Parte 1: Imprimir n�meros decrescentes
        Console.WriteLine("Imprimir n�meros de n at� 1:");
        int n = 10; // Valor inicial
        ImprimirDecrescente(n);

        // Parte 2: Somar n�meros de 1 a n
        Console.WriteLine($"\nSoma de 1 at� {n}: {SomarNumeros(n)}");

        // Parte 3: Contar caracteres em uma string
        string texto = "Exemplo de texto"; // Texto para an�lise
        Console.WriteLine($"\nA string '{texto}' cont�m {ContarCaracteres(texto)} caracteres.");

        // Parte 4: Verificar se uma palavra � um pal�ndromo
        string palavra = "ARARA"; // Palavra para an�lise
        if (EhPalindromo(palavra.ToUpper(), 0, palavra.Length - 1))
            Console.WriteLine($"\n'{palavra}' � um pal�ndromo.");
        else
            Console.WriteLine($"\n'{palavra}' n�o � um pal�ndromo.");
    }
}
