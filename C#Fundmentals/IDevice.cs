using System;

public interface IDevice
{
	void TurnOn()
	{
        Console.WriteLine(("Device is turned on."));
	}
	void TurnOff();
}
