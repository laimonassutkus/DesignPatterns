using Bridge.Remotes;
using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AbstractDevice radio = new Radio();
            AbstractDevice tv = new TV();


            AbstractRemote turnOffRemote = new RemoteToTurnOff(tv);
            turnOffRemote.arrowLeftPress();
            turnOffRemote.EnterPress();

            AbstractRemote muteRemote = new RemoteToMute(radio);
            AbstractRemote muteRemoteForTv = new RemoteToMute(tv);
            muteRemote.EnterPress();
            muteRemoteForTv.EnterPress();
        }
    }
}
