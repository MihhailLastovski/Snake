
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Snake
{
    public class Sound
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        private string pathToMedia;



        public Sound(string pathToResources)
        {
            pathToMedia = pathToResources;
        }
        public void Play()
        {
            System.Media.SoundPlayer superplayer = new System.Media.SoundPlayer(pathToMedia);
        }
        public void Play(string songName)
        {
            player.URL = pathToMedia + songName + "theme.mp3";
            player.controls.play();
        }
        public void Deads()
        {
            player.URL = pathToMedia + "dead.mp3";
            player.settings.volume = 100;
            player.controls.play();
        }
        public void PlayEat()
        {
            player.URL = pathToMedia + "eat.mp3";
            player.settings.volume = 100;
            player.controls.play();
        }
    }
}