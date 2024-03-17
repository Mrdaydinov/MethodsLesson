using System.Reflection.Metadata;

namespace MethodsLesson
{
    internal class Program
    {

        static void IsPrime(int n)
        {
            bool flag = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    flag = false;
            }
            Console.WriteLine(flag);
        }

        static void CalcAvg(params int[] arr)
        {
            float sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            if(sum / arr.Length > 60)
                Console.WriteLine("Mezun oldunuz");
            else
                Console.WriteLine("Mezun ola bilmediniz");
        }


        static void Main(string[] args)
        {

            /* Task - 1
            IsPrime metodu -parametr olaraq integer value qəbul edir.Göndərilmiş integer dəyərin sadə olub olmadığını qaytarır.
            Ədəd sadədirsə true, deyilsə false qayıtmalıdır */

            //IsPrime();


            /*Task - 2
            CalcAvg metodu - Göndərilmiş imtahanlar qiyməti siyahısına (integer array) əsasən həmin qiymətlərin ortalamasını qaytaran metod yazın. 
            Main metodunda bu metodu call edib, burdan qayıdan dəyərə əsasən ortalama 
            60-dan böyükdürsə console-da "Mezun oldunuz" əks halda "Mezun ola bilmediniz" yazısı yazdırın */

            //CalcAvg();

        }
    }
}
