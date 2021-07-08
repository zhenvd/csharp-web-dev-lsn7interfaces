using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.

            FlavorComparer comparer = new FlavorComparer();
            Console.WriteLine("Before:\n");
            foreach(Flavor flavors in availableFlavors)
            {
                Console.WriteLine(flavors.Name);
            }
            availableFlavors.Sort(comparer);
            Console.WriteLine("\nAfter:\n");
            foreach (Flavor flavors in availableFlavors)
            {
                Console.WriteLine(flavors.Name);
            }
            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.

            ConeComparer comparer1 = new ConeComparer();
            Console.WriteLine("Before:\n");
            foreach (Cone cost in availableCones)
            {
                Console.WriteLine($"{cost.Name}: ${cost.Cost}");
            }
            availableCones.Sort(comparer1);
            Console.WriteLine("\nAfter:\n");
            foreach (Cone cost in availableCones)
            {
                Console.WriteLine($"{cost.Name}: ${cost.Cost}");
            }

            AllergenComparer comparer2 = new AllergenComparer();
            Console.WriteLine("\nBefore:\n");
            foreach (Flavor allergen in availableFlavors)
            {
                Console.WriteLine($"{allergen.Name}");
            }
            availableFlavors.Sort(comparer2);
            Console.WriteLine("\nAfter:\n");
            foreach (Flavor allergen in availableFlavors)
            {
                Console.WriteLine($"{allergen.Name}");
            }
            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
        }
    }
}
