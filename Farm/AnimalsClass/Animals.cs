using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsClass
{
    public class Animals
    {
        public string Animal { get; set; } 
        public string Name { get; set; }
        public string Color { get; set; }
        public string Sound { get; set; }
        public string Food { get; set; }
        public string Product { get; set; }
        
        public Animals()
        {
         
        }

        public string GetAnimal()
        {
            if (this.Animal == "1") return "Cow";
            if (this.Animal == "2") return "Dog";
            if (this.Animal == "3") return "Horse";
            if (this.Animal == "4") return "Pig";
            return Animal;
        }

        public string GetName()
        {
            if (this.Name == "1") return "Rex";
            if (this.Name == "2") return "Jenney";
            if (this.Name == "3") return "Billy";
            if (this.Name == "4") return "Chesty";
            return Name;
        }

        public string GetColor()
        {
            if (this.Color == "1") return "Black";
            if (this.Color == "2") return "Brown";
            if (this.Color == "3") return "Grey";
            if (this.Color == "4") return "Orange Spotted";
            return Color;
        }

        public string GetSound()
        {
            if (this.Animal == "1") return this.Sound = "Moo!";
            if (this.Animal == "2") return this.Sound = "Woof!";
            if (this.Animal == "3") return this.Sound = "Neigh!";
            if (this.Animal == "4") return this.Sound = "Oink!";
            return Sound;
        }

        public string GetFood()
        {
            if (this.Animal == "1") return this.Food = "grass";
            if (this.Animal == "2") return this.Food = "dog chow";
            if (this.Animal == "3") return this.Food = "hay";
            if (this.Animal == "4") return this.Food = "oats";
            return Food;
        }

        public string GetProduct()
        {
            if (this.Animal == "1") return this.Product = "beef";
            if (this.Animal == "2") return this.Product = "company";
            if (this.Animal == "3") return this.Product = "rides";
            if (this.Animal == "4") return this.Product = "bacon";
            return Product;
        }
    }
}
