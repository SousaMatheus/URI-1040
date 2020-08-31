using System;
using System.Globalization;

namespace URI_1040
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, media, exame;

            string [] vet = Console.ReadLine().Split(' ');
            n1 = double.Parse(vet[0]);
            n2 = double.Parse(vet[1]);
            n3 = double.Parse(vet[2]);
            n4 = double.Parse(vet[3]);

            media = ((n1*2) + (n2 * 3) + (n3 * 4) + n4) / 100;

            if (media >= 7.0){
                Console.WriteLine($"Media: {media}");
                Console.WriteLine("Aluno aprovado.");
            } 
            else if (media < 5.0){
                Console.WriteLine($"Media: {media}");
                Console.WriteLine("Aluno reprovado.");
            }
            else {
                exame = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                media = (exame + media) /2;
                if (media >=5.0){
                    Console.WriteLine($"Nota do Exame: {exame}");
                    Console.WriteLine($"Aluno aprovado.");
                    Console.WriteLine($"Media final: {media}");

                }
                else {
                    Console.WriteLine($"Nota do Exame: {exame}");
                    Console.WriteLine($"Aluno reprovado.");
                    Console.WriteLine($"Media final: {media}");

                }

            }
        }
    }
}
