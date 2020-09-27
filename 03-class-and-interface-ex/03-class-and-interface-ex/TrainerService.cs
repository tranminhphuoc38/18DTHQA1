using System;
using _03_class_and_interface_ex.Model;

namespace _03_class_and_interface_ex
{
    public class TrainerService
    {
        public TrainerService()
        {
        }

        public void AskToMove(IAnimal animal)
        {
            animal.Move();
        }
    }
}
