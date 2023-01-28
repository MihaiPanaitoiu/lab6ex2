using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab6ex2
{
    class Autoturism
    {
        private static Random random = new Random();

        private readonly string marca;
        private string numarInmatriculare = NumarRosu(6);
        private readonly int capacitateCilindrica;

        public Autoturism(string marca, string numarInmatriculare, int capacitateCilindrica)
        {
            this.marca = marca;
            this.numarInmatriculare = numarInmatriculare;
            this.capacitateCilindrica = capacitateCilindrica;
        }

        public void Tipareste()
        {
            Console.WriteLine($"{marca}, {numarInmatriculare}, {capacitateCilindrica}");
        }


        public void SetNumarInmatriculare(string newNumarInmatriculare)
        {
            if (numarInmatriculare == newNumarInmatriculare)
            {
                Console.WriteLine("ce ai facut bossule, ai deja numarul asta de inmatriculare");
                return;
            } else
            {
                numarInmatriculare = newNumarInmatriculare;
            }
        }

        private static string NumarRosu(int length)
        {
            const string caractere = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(caractere, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }


}
