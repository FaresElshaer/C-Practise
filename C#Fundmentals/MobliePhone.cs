using System;
namespace CSharpFundamentals;

internal class MobilePhone: IDevice
{
    // Constructor
    public MobilePhone()
    {
        Console.WriteLine("Mobile Phone object created.");
    }

    // Method
    public void TurnOn()
    {
        Console.WriteLine("Mobile Phone is turned on.");
    }

    // Method
    public void TurnOff()
    {
        Console.WriteLine("Mobile Phone is turned off.");
    }
}
