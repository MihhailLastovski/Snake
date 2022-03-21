
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
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        private string pathToMedia;



        public Sound(string pathToResources)
        {
            pathToMedia = pathToResources;
        }
        public void Play()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(pathToMedia);
        }
        public void Play(string songName)
        {
            player.SoundLocation = pathToMedia + songName + "theme.mp3";
            player.Play();
        }
        public void Deads()
        {
            player.SoundLocation = pathToMedia + "dead.mp3";
            player.Play();
        }
        public void PlayEat()
        {
            player.SoundLocation = pathToMedia + "eat.mp3";
            player.Play();
        }
    }
}