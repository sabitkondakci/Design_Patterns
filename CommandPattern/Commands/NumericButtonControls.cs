using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Receivers;

namespace CommandPattern.Commands
{
    class NumericButtonControls:TV,ICommand
    {
        public void Execute()
        {
            TvAction();
        }

        public void Revoke()
        {
            Console.WriteLine("Numeric Button Control Has Been Revoked");
        }
    }
}
