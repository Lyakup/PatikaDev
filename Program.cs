using System;

namespace PatikaDev_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba, İsminizi Giriniz ?");
            string inputName = Console.ReadLine();

            Console.WriteLine("Hoşgeldin!");
            Console.WriteLine(inputName);

            Console.WriteLine("yazılış tarihi : 25/01/2020 - 08:46");
        }
    }
}
