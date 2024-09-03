// 1) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...)
// , escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e
// retorne uma mensagem avisando se o número informado pertence ou não a sequência.

using System;

class PrimeiroDesafio
{
    static void Main()
    {
        Console.WriteLine("Digite um número para verificar se pertence à sequência de Fibonacci:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (IsFibonacci(number))
            {
                Console.WriteLine($"{number} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{number} não pertence à sequência de Fibonacci.");
            }
        }
        else
        {
            Console.WriteLine("Número inválido. Por favor, insira um número inteiro.");
        }
    }

    static bool IsFibonacci(int number)
    {
        if (number < 0) return false;

        int a = 0, b = 1;

        if (number == a || number == b) return true;

        while (b < number)
        {
            int next = a + b;
            a = b;
            b = next;

            if (b == number) return true;
        }

        return false;
    }
}