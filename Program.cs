using System;
namespace recursive_extension_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif - Öz yinelemeli

            int result =1;
            for (int i = 1; i < 5; i++)
            result=result * 3;
            Console.WriteLine(result);
            
            Islemler instance =new();
            Console.WriteLine(instance.Expo(3,4));

            //Extension Metotlar
            string ifade = "Muhammed Solmaz";
            bool sonuc=ifade.check();
            Console.WriteLine(sonuc);
            if(sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
                Console.WriteLine(ifade.MakeUpperCase());
                Console.WriteLine(ifade.MakeLowerCase());
            }
        }
    }

    public class Islemler
    {
     public int Expo(int sayi, int üs)
     {
        if (üs<2)
     return sayi;
     return Expo(sayi, üs-1)* sayi; 
     }      
    }

    public static class Extension
    {
        public static bool check(this string param)
        {
         return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
        
    }
}

