using Command.Commands;
using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            InvokerDevice invokerDevice = new InvokerDevice();

            IReceiverDevice receiverDevice = new Lamp();

            ICommand turnOff = new TurnOffCommand(receiverDevice);
            ICommand turnOn = new TurnOnCommand(receiverDevice);

            invokerDevice.SetCommand(turnOn);
            invokerDevice.SetCommand(turnOff);

            invokerDevice.ExecuteCommands();
        }
    }
}
