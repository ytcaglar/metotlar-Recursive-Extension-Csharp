using System;

namespace metotlar_recursive_extension
{
    class Program
    {
        static void Main(string[] args)
        {
            // Recursive - Öz yinelemeli
            // 3^4

            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result*= 3;
            }
            System.Console.WriteLine(result);
            Islemler ex = new();

            int sonuc1 = ex.Expo(3,4);
            System.Console.WriteLine(sonuc1);

            //Extension : Sayesinde metotlara hızlı bir şekilde erişim yapmamız sağlanmış olur.
            // Extension class ve metodu static olmalıdır.

            var ifade = "Yusuf        Tolunay Çağlar          ";
            bool sonuc2 = ifade.CheckSpace();
            if(sonuc2){
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }else{
                Console.WriteLine(ifade);
            }

            var ifade2 = "Yusuf Tolunay Çağlar";
            System.Console.WriteLine(ifade2.MakeLowerCase());
            System.Console.WriteLine(ifade2.MakeUpperCase()); 

            int[] dizi = {9,3,6,1,8,4,7,5,2};
            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi = 12;
            sayi.IsEvenNumber().EkranaYazdir();

            ifade2.GetFirstCharacter().EkranaYazdir();

            ifade2.GetFirstWord().EkranaYazdir();
        }
    }

    class Islemler
    {
        public int Expo(int sayi, int us){
            System.Console.WriteLine(us);
            if (us < 2){
                return sayi;
            }
            return Expo(sayi,us-1) * sayi; 
        }
    }
    
    public static class Extensions{
        public static bool CheckSpace(this string param){
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param){
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }

        public static string MakeUpperCase(this string param){
            
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param){ 
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param){
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param){
            foreach(var item in param){
                System.Console.WriteLine(item);
            }
        }
        public static void EkranaYazdir(this int param){
            System.Console.WriteLine(param);
        }

        public static void EkranaYazdir(this bool param){
            System.Console.WriteLine(param);
        }

        public static void EkranaYazdir(this string param){
            System.Console.WriteLine(param);
        }

        public static bool IsEvenNumber(this int param){
            return param % 2 == 0;
        }

        public static string GetFirstCharacter(this string param){
            return param.Substring(0,1);
        }

        public static string GetFirstWord(this string param){
            string[] dizi = param.Split();
            return dizi[0];
        }
    }
}

