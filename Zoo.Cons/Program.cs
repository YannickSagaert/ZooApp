using System;
using Zoo.lib;

namespace Zoo.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            PublicZoo zoo = new PublicZoo(39M);
            Console.WriteLine($"Hello Tourist! \n\n " +
                                $"Buy a ticket for {zoo.EntranceFee} euro\n\n" +
                                $"Take a look at our animals.\n\n");

            foreach (Lion lion in zoo.LionCage.Lions)
            {
                Console.WriteLine($"Grrrrrrrrr... I am {lion.Name}, my sex is {lion.Sex}");
            }

        }
    }
}
