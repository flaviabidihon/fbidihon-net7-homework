using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_intro___homework
{
    public class Animal
    {
        public string name;
        public string species;
        public string breed;
        public int age;
        public string color;
        public double weight;
        public bool isSpayedOrNeutered;

        public Animal(string name, string species, string breed, int age, string color, double weight, bool isSpayedOrNeutered)
        {
            this.name = name;
            this.species = species;
            this.breed = breed;
            this.age = age;
            this.color = color;
            this.weight = weight;
            this.isSpayedOrNeutered = isSpayedOrNeutered;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetSpecies()
        {
            return this.species;
        }

        public string GetBreed()
        {
            return this.breed;
        }

        public int GetAge()
        {
            return this.age;
        }

        public string GetColor()
        {
            return this.color;
        }

        public double GetWeight()
        {
            return this.weight;
        }

        public bool IsSpayedOrNeutered()
        {
            return this.isSpayedOrNeutered;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetSpecies(string species)
        {
            this.species = species;
        }

        public void SetBreed(string breed)
        {
            this.breed = breed;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public void SetWeight(double weight)
        {
            this.weight = weight;
        }

        public void SetIsSpayedOrNeutered(bool isSpayedOrNeutered)
        {
            this.isSpayedOrNeutered = isSpayedOrNeutered;
        }
    }
}
