using System;
namespace _03_class_and_interface_ex.Model
{
    public class Pet : BaseAnimal
    {
        public Pet(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public override void Move()
        {
            Console.WriteLine($"{this.GetType().Name} '{Name}' is moving with four legs...");
        }
    }
}
