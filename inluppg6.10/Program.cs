using System;

namespace inluppg6_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en text. Du kommer att få hur många tal som finns i den");
            string text = Console.ReadLine();
            Console.WriteLine(AntalTalIText(text));
        }

        static int AntalTalIText(string text)
        {
            int konverteratSkrap;
            float konverteratFloat = 0;
            int cunt = 0;
            string[] splitString = text.Split(' ');
            foreach (string s in splitString)
            {
                if (int.TryParse(s, out konverteratSkrap))
                {
                    cunt++;
                }
                else if (float.TryParse(s, out konverteratFloat))
                {
                    cunt++;
                }
            }
            return cunt;
        }
    }
}