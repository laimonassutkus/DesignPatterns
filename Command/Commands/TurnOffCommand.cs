using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Commands
{
    class TurnOffCommand : AbstractCommand
    {
        public TurnOffCommand(IReceiverDevice receiver) : base(receiver)
        {
        }

        public override void ExecuteCommand()
        {
            receiver.Off();
        }
    }
}
