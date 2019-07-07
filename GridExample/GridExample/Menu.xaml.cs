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
        public static bool theme1 = true;
        public static  bool theme2 = false;
        public static string nameTheme1 = "low.jpg";
        public static string nameTheme2 = "low3.jpg";

        public Menu()
        {
            InitializeComponent();
            Sound("GreatLittleChallenge.ogg",true);
            ConfigTheme();
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

        private async void btnConfigTheme(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Choose a theme", "Cancel", null, "Theme 1", "Theme 2");

            if (action == "Theme 1")
            {
                theme1 = true;
                theme2 = false;
                ConfigTheme();
            }
            else if (action == "Theme 2")
            {
                theme2 = true;
                theme1 = false;
                ConfigTheme();
            }
        }

        [Obsolete]
        public  void ConfigTheme()
        {

            if (theme1 == true)
            {
                BgImage.Source = "low.jpg";
                theme2 = false;
                Device.OnPlatform(iOS: () => TitleName1.Font = Font.OfSize("AgentOrange", NamedSize.Large));
                Device.OnPlatform(Android: () => TitleName1.Font = Font.OfSize("Font/AgentOrange.ttf#Agent Orange", NamedSize.Large));

                Device.OnPlatform(iOS: () => TitleName2.Font = Font.OfSize("AgentOrange", NamedSize.Large));
                Device.OnPlatform(Android: () => TitleName2.Font = Font.OfSize("Font/AgentOrange.ttf#Agent Orange", NamedSize.Large));

                TitleName1.TextColor = Color.FromHex("#F8B300");
                TitleName2.TextColor = Color.FromHex("#F8B300");

                TitleName1.FontSize = 50;
                TitleName2.FontSize = 50;


            }
            else if (theme2 == true)
            {
                BgImage.Source = "low3.jpg";
                theme1 = false;
                Device.OnPlatform(iOS: () => TitleName1.Font = Font.OfSize("FunnyKid", NamedSize.Large));
                Device.OnPlatform(Android: () => TitleName1.Font = Font.OfSize("Font/FunnyKid.ttf#Agent Orange", NamedSize.Large));

                Device.OnPlatform(iOS: () => TitleName2.Font = Font.OfSize("FunnyKid", NamedSize.Large));
                Device.OnPlatform(Android: () => TitleName2.Font = Font.OfSize("Font/FunnyKid.ttf#Agent Orange", NamedSize.Large));

                TitleName1.TextColor = Color.FromHex("#8007AA");
                TitleName2.TextColor = Color.FromHex("#8007AA");

                TitleName1.FontSize = 80;
                TitleName2.FontSize = 80;
            }


        }
    }

}