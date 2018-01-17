using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class InvokerDevice
    {
        private List<ICommand> commandList;

        public InvokerDevice()
        {
            commandList = new List<ICommand>();
        }

        public void SetCommand(ICommand command)
        {
            commandList.Add(command);
        }

        public void ExecuteCommands()
        {
            foreach (var command in commandList)
            {
                command.ExecuteCommand();
            }
        }
    }
}
