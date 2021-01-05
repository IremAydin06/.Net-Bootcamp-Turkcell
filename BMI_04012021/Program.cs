using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_04012021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kilonuzu Giriniz (kg cinsinden):");
            double kilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Boyunuzu Giriniz (cm cinsinden):");
            double boy = Convert.ToDouble(Console.ReadLine());
            double bmi = kilo / (boy * boy);
            bmi = Math.Round(bmi, 4);

            Console.WriteLine("Vücut Kitle İndeksiniz:");
            Console.WriteLine(bmi.ToString());

            if (bmi < 18.5)
                Console.WriteLine("Zayıfsınız.");
            else if (18.5 <= bmi && bmi <= 24.9)
                Console.WriteLine("Kilonuz normal.");
            else if (25 <= bmi && bmi <= 25.9)
                Console.WriteLine("Kilolusunuz.");
            else if (30 <= bmi && bmi <= 34.9)
                Console.WriteLine("Obezsiniz.");
            else
                Console.WriteLine("Aşırı Obezsiniz."); 

            Console.ReadLine();
        }

        private static void NewMethod()
        {
            Console.WriteLine("Boyunuzu Giriniz:");
        }
    }
}
