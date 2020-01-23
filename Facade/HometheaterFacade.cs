using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class HometheaterFacade
    {
        // the classes declared as properties.
        private Dimmer _dimmer;
        private Dvd _dvd;
        private DvdPlayer _dvdPlayer;

        // then classes used as parameters.
        public HometheaterFacade(Dimmer dimmer, Dvd dvd, DvdPlayer dvdplayer)
        {
            _dimmer = dimmer;
            _dvd = dvd;
            _dvdPlayer = dvdplayer;
        }
        public void WatchMovie()
        {
            _dimmer.Dim(5);
            _dvdPlayer.On();
            _dvdPlayer.Insert(_dvd);
            _dvdPlayer.Play();
        }
        public void Pause()
        {
            _dimmer.Dim(10);
            _dvdPlayer.Pause();
        }
        public void Resume()
        {
            _dimmer.Dim(5);
            _dvdPlayer.Resume();
        }

    }

}
