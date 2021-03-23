using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Receivers;

namespace CommandPattern.Commands
{
    class MediaButtonControls:MusicPlayer,ICommand
    {

        public void Execute()
        {
            MediaAction();
        }

        public void Revoke()
        {
            Console.WriteLine("Media Button Control Has Been Revoked");
        }
    }
}
