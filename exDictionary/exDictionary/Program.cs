using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exDictionary
{
    class Program
    {
        class Package
        {
            public string Company { get; set; }
            public double Weight { get; set; }
            public long TrackingNumber { get; set; }
        }

        static void Main(string[] args)
        {
            List<Package> packages =
                new List<Package>
                        { new Package { Company = "Coho Vineyard", Weight = 25.2, TrackingNumber = 89453312L },
                          new Package { Company = "Lucerne Publishing", Weight = 18.7, TrackingNumber = 89112755L },
                          new Package { Company = "Wingtip Toys", Weight = 6.0, TrackingNumber = 299456122L },
                          new Package { Company = "Adventure Works", Weight = 33.8, TrackingNumber = 4665518773L } };

            // Create a Dictionary of Package objects, 
            // using TrackingNumber as the key.
            Dictionary<long, Package> dictionary =
                packages.ToDictionary(p => p.TrackingNumber);//对packages这个List中的所有要素进行遍历了一遍

            foreach (KeyValuePair<long, Package> kvp in dictionary)
            {
                Console.WriteLine(
                    "Key {0}: {1}, {2} pounds",
                    kvp.Key,
                    kvp.Value.Company,
                    kvp.Value.Weight);
            }

            //另一种写法
            Console.WriteLine(
                    "Key {0}: {1}, {2} pounds",
                    dictionary[89453312L].TrackingNumber,
                    dictionary[89453312L].Company,
                    dictionary[89453312L].Weight);
            Console.ReadLine();
        }
    }
}
