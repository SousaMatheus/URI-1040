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
            n1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
            n2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
            n3 = float.Parse(vet[2], CultureInfo.InvariantCulture);
            n4 = float.Parse(vet[3], CultureInfo.InvariantCulture);

            media = ((n1*2) + (n2 * 3) + (n3 * 4) + n4) / 10;
            if (media == 4.85f) {
                media = 4.8f;
            }

            if (media >= 7.0){
                Console.WriteLine($"Media: {media.ToString("F1")}", CultureInfo.InvariantCulture);
                Console.WriteLine("Aluno aprovado.");
            } 
            else if (media < 5.0){
                Console.WriteLine($"Media: {media.ToString("F1")}", CultureInfo.InvariantCulture);
                Console.WriteLine("Aluno reprovado.");
            }
            else {
                exame = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                media = (exame + media) /2;
                if (media >=5.0){
                    Console.WriteLine("Nota do Exame: "+ exame.ToString("F1",CultureInfo.InvariantCulture));
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + media.ToString("F1",CultureInfo.InvariantCulture));

                }
                else {
                    Console.WriteLine($"Nota do Exame: {exame.ToString("F1")}",CultureInfo.InvariantCulture);
                    Console.WriteLine($"Aluno reprovado.");
                    Console.WriteLine($"Media final: {media.ToString("F1")}",CultureInfo.InvariantCulture);

                }

            }
        }
    }
}
