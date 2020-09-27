using System;
using System.Collections.Generic;
using _03_class_and_interface_ex.Model;

namespace _03_class_and_interface_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the zoo!");

            // Init animals
            IList<IAnimal> animals = new List<IAnimal>();
            animals.Add(new Dog());
            animals.Add(new Cat("Meo meo"));
            animals.Add(new Monkey());
            animals.Add(new Dog("Gau gau", Common.Color.Black));

            // Circus Show
            var dogTrainer = new TrainerService();
            foreach (var animal in animals)
            {
                if (animal is Dog)
                {
                    dogTrainer.AskToMove(animal);
                }
            }
        }
    }
}
