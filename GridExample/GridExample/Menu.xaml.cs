using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace GridExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
            Sound("GreatLittleChallenge.ogg",true);
        }

        private async void ClickbtnNewGame(object sender, EventArgs e)
        {
            //var soundTap = new ConfigGame();
            //soundTap.Sound("bubblepop.mp3",false);
            await Navigation.PushModalAsync(new MainPage());
        }

        private void ClickbtnExit(object sender, EventArgs e)
        {
            
           //Sound("bubblepop.mp3",false);
            OnBackButtonPressed();
        }


        private void Sound(string filename, bool loop)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            System.IO.Stream audioStream = assembly.GetManifestResourceStream("GridExample." + filename);
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(audioStream);
            audio.Play();
            audio.Loop = loop;

        }
       

        [Obsolete]
        protected override bool OnBackButtonPressed() // Metodo para salir de la aplicacion cuando se presiona el boton back en la pagina principa de la app
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await DisplayAlert("", "Would you like to exit from game?", "Yes", "No");
                if (result)
                {
                    if (Device.OS == TargetPlatform.Android)
                    {
                        Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
                    }
                    else if (Device.OS == TargetPlatform.iOS)
                    {
                        Thread.CurrentThread.Abort();
                    }
                }
            });
            return true;
        }

        private void ClickbtnCredits(object sender, EventArgs e)
        {
            DisplayAlert("Credits", "Rhadimer Antigua Sánchez TicTacToe! Version 1.0", "OK");
        }
    }
}