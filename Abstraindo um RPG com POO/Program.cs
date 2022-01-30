using System;
using Abstraindo_um_RPG_com_POO.Source.Entities;

namespace Abstraindo_um_RPG_com_POO
{
    class Program
    {
        static void Main(string [] args)
        {
           Hero character = new Hero("Lumine", 55, "Sword", "Geo/Anemo", "Unknown");
           
           Console.Write(character);
        }
    }
}
