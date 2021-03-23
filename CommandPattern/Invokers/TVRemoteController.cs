using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Invokers
{
    class TVRemoteController
    {
        private readonly ICommand _mediaButtonControls;
        private readonly ICommand _numericButtonControls;

        public TVRemoteController(ICommand mediaButtonControls,ICommand numericButtonControls)
        {
            this._mediaButtonControls = mediaButtonControls;
            this._numericButtonControls = numericButtonControls;
        }

        public void SwitchChannel(int channel)
        {
            // specific channel
            try
            {
                _numericButtonControls.Execute(); // channel switch
            }
            catch 
            {
               _numericButtonControls.Revoke();
            }
            
        }

        public void StitchMediaPlayer(int media)
        {
            // specific media button
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
