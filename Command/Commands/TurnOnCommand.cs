using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Commands
{
    class TurnOnCommand : AbstractCommand
    {
        public TurnOnCommand(IReceiverDevice receiver) : base(receiver)
        {
        }

        public override void ExecuteCommand()
        {
            receiver.On();
        }
    }
}
