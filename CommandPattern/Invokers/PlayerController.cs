using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Invokers
{
    class PlayerController
    {
        private readonly ICommand _mediaButtonControls;

        public PlayerController(ICommand mediaButtonControls)
        {
            this._mediaButtonControls = mediaButtonControls;
        }

        public void Media(int media)
        {
            // media 
            try
            {
                _mediaButtonControls.Execute();
            }
            catch 
            {
                _mediaButtonControls.Revoke();
            }
        }
    }
}
