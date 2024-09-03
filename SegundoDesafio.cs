// 2) Escreva um programa que verifique, em uma string, a existência da letra ‘a’, seja maiúscula ou minúscula
// , além de informar a quantidade de vezes em que ela ocorre.

using System;


namespace DesafiosTecnicos
{
    class SegundoDesafio
    {
        static void Main()
        {
            Console.WriteLine("Digite uma string para verificar a ocorrência da letra 'a':");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                int count = CountLetterA(input);
                bool containsA = count > 0;

                Console.WriteLine($"A letra 'a' aparece {count} vez(es) na string.");
                if (containsA)
                {
                    Console.WriteLine("A string contém a letra 'a'.");
                }
                else
                {
                    Console.WriteLine("A string não contém a letra 'a'.");
                }
            }
            else
            {
                Console.WriteLine("A string está vazia ou inválida.");
            }

        }

        static int CountLetterA(string input)
        {
            int count = 0;

            foreach (char c in input)
            {
                if (c == 'a' || c == 'A')
                {
                    count++;
                }
            }

            return count;
        }

    }
}