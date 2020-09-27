using System;
namespace _03_class_and_interface_ex.Model
{
    public class Cat : Pet
    {
        public Cat(string name) : base(name)
        {
        }

        public void Jump()
        {
            Console.WriteLine($"Cat '{Name}' is jumping...");
        }

        public override void Move()
        {
            base.Move();
            Jump();
        }
    }
}
