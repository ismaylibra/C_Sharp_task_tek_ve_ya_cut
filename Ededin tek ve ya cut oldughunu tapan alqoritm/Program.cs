using System;

namespace Ededin_tek_ve_ya_cut_oldughunu_tapan_alqoritm
{
    class Program
    {
        static void Main(string[] args)
           
        {
            Console.WriteLine("Eded daxil edin");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num%2==0)
            {
                Console.WriteLine("Eded cutdur");

            }
            else
            {
                Console.WriteLine("Eded tekdir");
            }
        }
    }
}
