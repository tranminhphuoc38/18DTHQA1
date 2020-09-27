using System;
namespace _03_class_and_interface_ex.Model
{
    public interface IAnimal
    {
        DateTime Birthdate { get; set; }

        void Move();

        void Speak();
    }
}
