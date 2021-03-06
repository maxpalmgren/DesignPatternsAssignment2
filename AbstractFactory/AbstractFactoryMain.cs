using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    class AbstractFactoryMain
    {
        // Skapa två fabriker som kan köra CreateAnimal() den ena fabriken ska skapa en hund och den andra en katt skapa sedan en abstract factory där man
        // får tillbaka en av de 2 fabrikerna beroende på ett sträng argument
        
        public void Run()
        {
            var cat = FactoryFactory.GetFactory("Cat");
            var cat1 = cat.CreateAnimal("Findus");
            var dog = FactoryFactory.GetFactory("Dog");
            var dog1 = dog.CreateAnimal("Fido");
            Console.WriteLine(cat1.Name + " " + dog1.Name);
        }
    }
}
