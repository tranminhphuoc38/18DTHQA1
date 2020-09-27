using System;
namespace _03_class_and_interface_ex.Model
{
    public abstract class BaseAnimal : IAnimal
    {
        public BaseAnimal()
        {
            Birthdate = DateTime.Today;
        }

        public DateTime Birthdate { get; set; } 

        public abstract void Move();

        public void Speak()
        {
            Console.WriteLine($"{this.GetType().Name} is speaking...");
        }
    }
}
