using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            SettlerUnit settlerUnit = new SettlerUnit();
            settlerUnit.Move();
            Console.WriteLine("SettlerUnit Health: " + settlerUnit.Health);
            Console.WriteLine("SettlerUnit Cost: " + settlerUnit.Cost);

            MilitaryUnit militaryUnit = new MilitaryUnit(3, 6, 7);
            militaryUnit.Move();
            Console.WriteLine("MilitaryUnit Health: " + militaryUnit.Health);
            Console.WriteLine("MilitaryUnit Cost: " + militaryUnit.Cost);

        }
    }
}