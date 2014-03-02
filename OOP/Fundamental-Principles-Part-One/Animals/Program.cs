using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog[] dogs = new Dog[]
            {
                new Dog(5,"Chiko","Male"),
                new Dog(14,"Miko","Female"),
                new Dog(13,"Sharo","Male"),
                new Dog(2,"Kleopatra","Female"),
                new Dog(1,"Djaro","Male"),
                new Dog(21,"Elena","Female"),

            };

            Kitten[] kittens = new Kitten[]
            {
                new Kitten(3,"Mitka"),
                new Kitten(28,"Vitka"),
                new Kitten(1,"Kirka"),
                new Kitten(56,"Kleopatra"),
                new Kitten(34,"Hoika"),
                new Kitten(0,"Dimitri4ka"),

            };

            Tomcat[] tomcats = new Tomcat[]
            {
                new Tomcat(5,"Chiko"),
                new Tomcat(11,"Miko"),
                new Tomcat(3,"Sharo"),
                new Tomcat(2,"Maro"),
                new Tomcat(1,"Djaro"),
                new Tomcat(2,"Dimitro4ko"),
            };

            Frog[] frogs = new Frog[]
            {
                new Frog(56,"Chiko","Male"),
                new Frog(14,"Miko","Female"),
                new Frog(28,"Sharo","Male"),
                new Frog(2,"Kleopatra","Female"),
                new Frog(1,"Djaro","Male"),
                new Frog(21,"Elena","Female"),
            };

            Dictionary<String, Double> averageAges = new Dictionary<string, double>();
            averageAges.Add("Kittens",CalculateAverageAge(kittens));
            averageAges.Add("Tomcats",CalculateAverageAge(tomcats));
            averageAges.Add("Dogs",CalculateAverageAge(dogs));
            averageAges.Add("Frogs",CalculateAverageAge(frogs));

            foreach (var item in averageAges)
            {
                Console.WriteLine("{0} ---> {1} years (average)",item.Key,item.Value);
            }

        }

        static double CalculateAverageAge(Animal[] animals)
        {
            var newAnimals = animals.Select(animal => animal.Age);
            double averageAge = 0;
            double count = 0;

            foreach (var age in newAnimals)
            {
                averageAge += age;
                count++;
            }

            return averageAge / count;
        }
    }
}
