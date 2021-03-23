using System;
using CommandPattern.Commands;
using CommandPattern.Invokers;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var tvController = new TVRemoteController(new MediaButtonControls(), new NumericButtonControls());
            var mediaController = new PlayerController(new MediaButtonControls());

            tvController.SwitchChannel(1); //TV Action
            tvController.StitchMediaPlayer(2); //Music Player Action

            mediaController.Media(1); //Music Player Action
            Console.Read();
        }
    }
}
