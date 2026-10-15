using System;

namespace CSharpFundamentals
{
    public class Computer:IDevice
    {

        public Computer()
        {
            Console.WriteLine("Computer object created.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Computer is turned on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Computer is turned off.");
        }
    }
}