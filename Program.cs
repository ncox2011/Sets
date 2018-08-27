using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Showroom = new HashSet<string>();
            Showroom.Add("Tesla Model 3");
            Showroom.Add("Honda Civic");
            Showroom.Add("Dodge Ram");
            Showroom.Add("Nissan Cube");

            Console.WriteLine(Showroom.Count);
            foreach (string car in Showroom)
            {
                Console.WriteLine(car);
            }
            
            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("Nissan Quest");
            UsedLot.Add("Acura TL");

            HashSet<string> AllCars = new HashSet<string>(Showroom);
            AllCars.UnionWith(UsedLot);

        foreach (string i in AllCars)
        {
            Console.WriteLine(i);
        }

        AllCars.Remove("Acura TL");

        foreach (string i in AllCars)
        {
            Console.WriteLine(i);
        }


        HashSet<string> JunkYard = new HashSet<string>();
        JunkYard.Add("Honda Accord");
        JunkYard.Add("Nissan Quest");
        JunkYard.Add("Acura TL");
        JunkYard.Add("Maybach");
        JunkYard.Add("Honda CRV");

        HashSet<string> clone = new HashSet<string>(Showroom);
        clone.IntersectWith(JunkYard);

        foreach (string car in clone)
        {
            Console.WriteLine(car);
        }

        HashSet<string> newInventory = new HashSet<string>(clone);
        newInventory.UnionWith(JunkYard);

        foreach (string car in newInventory)
        {
            Console.WriteLine(car);
        }

        newInventory.Remove("Maybach");
        foreach (string car in newInventory)
        {
            Console.WriteLine(car);
        }

        }
        
    }
}
