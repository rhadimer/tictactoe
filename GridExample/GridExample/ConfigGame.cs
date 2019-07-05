using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace GridExample
{
    public class ConfigGame
    {
        public ConfigGame()
        {
           

        }

        public void Sound(string filename, bool loop)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            System.IO.Stream audioStream = assembly.GetManifestResourceStream("GridExample." + filename);
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(audioStream);
            audio.Play();
            audio.Loop = loop;

        }
    }
}
