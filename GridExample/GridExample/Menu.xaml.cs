using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GridExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
            Sound();
        }

        private async void ClickbtnNewGame(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }

        //private void btnConfig(object sender, EventArgs e)
        //{

        //}

        //private void btnExit(object sender, EventArgs e)
        //{

        //}

        private void Sound()
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            System.IO.Stream audioStream = assembly.GetManifestResourceStream("GridExample.GreatLittleChallenge.ogg");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            //var audio = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            audio.Load(audioStream);
            audio.Play();
            audio.Loop = true;

        }
    }
}