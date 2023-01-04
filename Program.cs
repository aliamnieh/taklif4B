using System;

namespace payment_of_karmand
{
    class Program
    {
        static void Main(string[] args)
        {
            //برنامه ای بنویسید که در یک کلاس حقوق ناخالص کارمند را دریافت و حقوق نهایی را محاسبه کند
            KRMND arash = new KRMND();
            Console.WriteLine("enter the id of worker : ");
            arash.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name : ");
            arash.Name = Console.ReadLine();
            Console.WriteLine("enter family : ");
            arash.Family = Console.ReadLine();
            Console.WriteLine("enter basepay : ");
            arash.basepay = ulong.Parse(Console.ReadLine());
            Console.WriteLine("the final pay is : " + arash.finalpay());
            Console.ReadKey();
        }
    }
}
