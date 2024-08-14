using System;
using dotNetExtensionsMethods.Extensions;

namespace dotNetExtensionsMethods
{
    class Program
    {
        public enum DaysOfWeek
        {
            Pazartesi,
            Sali,
            Carsamba,
            Persembe,
            Cuma,
            Cumartesi,
            Pazar
        }

        public enum LetterCodes
        {
            A = 65,  // ASCII for 'A'
            B = 66   // ASCII for 'B'
        }

       

        static void Main(string[] args)
        {
            //ConvertToChars Methodu: Diziden Karakter Dizisine dönüşüm
            char[] dizi = "Merhaba".ConvertToChars();            
            foreach (var item in dizi)
            {
                Console.WriteLine(item); // Çıktı her bir harf olacak, örneğin: M, e, r, h, a, b, a
            }


            //AsString<T> Methodu:
            Console.WriteLine(DaysOfWeek.Pazartesi.AsString());  // Çıktı: Pazartesi


            //ToEnum<TEnum> Methodu (string value parametresi ile):
            string day = "Cuma";
            DaysOfWeek dayOfWeek = day.ToEnum<DaysOfWeek>();
            Console.WriteLine(dayOfWeek);  // Çıktı: Cuma


            //ToEnum<TEnum> Methodu (string value ve defaultValue parametreleri ile):
            string day2 = "Bazengün";
            DaysOfWeek dayOfWeek2 = day2.ToEnum<DaysOfWeek>(DaysOfWeek.Pazar);
            Console.WriteLine(dayOfWeek2);  // Çıktı: Pazar (default değer)


            //AsEnum<T> Methodu:
            int code = 65;
            LetterCodes letter = code.AsEnum<LetterCodes>();
            Console.WriteLine(letter);  // Çıktı: A


            //AsInt<T> Methodu:
            int asciiCode = LetterCodes.B.AsInt();
            Console.WriteLine(asciiCode);  // Çıktı: 66


            //AsChar<T> Methodu:
            char letter2 = LetterCodes.A.AsChar();
            Console.WriteLine(letter2);  // Çıktı: A







        }
    }
}
