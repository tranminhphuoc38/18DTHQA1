using System;
namespace _03_class_and_interface_ex.Model
{
    public class Monkey : BaseAnimal
    {
        public Monkey()
        {
        }

        public void Climb()
        {
            Console.WriteLine($"{this.GetType().Name} is climbing...");
        }

        public override void Move()
        {
            Climb();
        }
    }
}
