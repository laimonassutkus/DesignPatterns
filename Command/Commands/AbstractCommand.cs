using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Commands
{
    abstract class AbstractCommand : ICommand
    {
        protected readonly IReceiverDevice receiver;

        public AbstractCommand(IReceiverDevice receiver)
        {
            this.receiver = receiver;
        }

        public abstract void ExecuteCommand();
    }
}
