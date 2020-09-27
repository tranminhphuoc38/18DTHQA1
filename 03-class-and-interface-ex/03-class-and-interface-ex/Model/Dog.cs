using System;
using _03_class_and_interface_ex.Common;

namespace _03_class_and_interface_ex.Model
{
    public class Dog : Pet
    {
        public Dog() : this("Kiki")
        {
        }

        public Dog(string name, Color color = Color.Yellow) : base(name)
        {
            Color = color;
        }

        public Color Color { get; set; }
    }
}
