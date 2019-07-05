using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace GridExample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        private int step = 0;
        private int pointsPlayer1 = 0;
        private int pointsPlayer2 = 0;
        private bool winner = false;

        private Label move1 = new Label();
        private Label move2 = new Label();
        private Label move3 = new Label();
        private Label move4 = new Label();
        private Label move5 = new Label();
        private Label move6 = new Label();
        private Label move7 = new Label();
        private Label move8 = new Label();
        private Label move9 = new Label();

        //private StackLayout layout1 = new StackLayout();
        //private StackLayout layout2 = new StackLayout();
        //private StackLayout layout3 = new StackLayout();
        //private StackLayout layout4 = new StackLayout();
        //private StackLayout layout5 = new StackLayout();
        //private StackLayout layout6 = new StackLayout();
        //private StackLayout layout7= new StackLayout();
        //private StackLayout layout8 = new StackLayout();
        //private StackLayout layout9 = new StackLayout();

        private int left1 ;
        private int left2 ;
        private int left3 ;
        private int left4;
        private int left5 ;
        private int left6 ;
        private int left7 ;
        private int left8 ;
        private int left9 ;

        private int top1;
        private int top2 ;
        private int top3 ;
        private int top4 ;
        private int top5 ;
        private int top6 ;
        private int top7 ;
        private int top8 ;
        private int top9 ;


        public MainPage()
        {
            InitializeComponent();

            label_name_player1.TextColor = Color.Blue;
            label_name_player2.TextColor = Color.Gray;

            framePointO.BorderColor = Color.Blue;
            framePointX.BorderColor = Color.Gray;

            //Sound();
            //DisplayAlert("Warning!", "This game must be played with two people", "OK");

        }

        private void OnTapped_box0_0(object sender, EventArgs e)
        { 
            Move(box0_0, stackLayout0_0, 0, 0);
            Turn();
            step++;
            Winner();
        }

        private void OnTapped_box0_1(object sender, EventArgs e)
        {
            Move(box0_1, stackLayout0_1, 0, 1);
            Turn();
            step++;
            Winner();
        }
        private void OnTapped_box0_2(object sender, EventArgs e)
        {
            Move(box0_2, stackLayout0_2, 0, 2);
            Turn();
            step++;
            Winner();
        }

        private void OnTapped_box1_0(object sender, EventArgs e)
        {
            Move(box1_0, stackLayout1_0, 1, 0);
            Turn();
            step++; 
            Winner();
        }

        private void OnTapped_box1_1(object sender, EventArgs e)
        {
            Move(box1_1, stackLayout1_1, 1, 1);
            Turn();
            step++;
            Winner();
        }

        private void OnTapped_box1_2(object sender, EventArgs e)
        {
            Move(box1_2, stackLayout1_2, 1, 2);
            Turn();
            step++;
            Winner();
        }

        private void OnTapped_box2_0(object sender, EventArgs e)
        {
            Move(box2_0, stackLayout2_0, 2, 0);
            Turn();
            step++;
            Winner();
        }

        private void OnTapped_box2_1(object sender, EventArgs e)
        {
            Move(box2_1, stackLayout2_1, 2, 1);
            Turn();
            step++;
            Winner();
        }

        private void OnTapped_box2_2(object sender, EventArgs e)
        {
            Move(box2_2, stackLayout2_2, 2, 2);
            Turn();
            step++;
            Winner();
        }

        async private void Winner()
        {
            if (box0_0.Color == Color.Blue && box0_1.Color == Color.Blue && box0_2.Color == Color.Blue)
            {


                Winner_O();  
            }
            else if (box0_0.Color == Color.Red && box0_1.Color == Color.Red && box0_2.Color == Color.Red)
            {
                Winner_X();
            }
            else if (box1_0.Color == Color.Blue && box1_1.Color == Color.Blue && box1_2.Color == Color.Blue)
            {
                Winner_O();         
            }
            else if (box1_0.Color == Color.Red && box1_1.Color == Color.Red && box1_2.Color == Color.Red)
            {
                Winner_X();
            }
            else if (box2_0.Color == Color.Blue && box2_1.Color == Color.Blue && box2_2.Color == Color.Blue)
            {
                Winner_O();
            }
            else if (box2_0.Color == Color.Red && box2_1.Color == Color.Red && box2_2.Color == Color.Red)
            {
                Winner_X();
            }
            else if (box0_0.Color == Color.Blue && box1_0.Color == Color.Blue && box2_0.Color == Color.Blue)
            {
                Winner_O();
            }
            else if (box0_0.Color == Color.Red && box1_0.Color == Color.Red && box2_0.Color == Color.Red)
            {
                Winner_X();
            }
            else if (box0_1.Color == Color.Blue && box1_1.Color == Color.Blue && box2_1.Color == Color.Blue)
            {
                Winner_O();
            }
            else if (box0_1.Color == Color.Red && box1_1.Color == Color.Red && box2_1.Color == Color.Red)
            {
                Winner_X();
            }
            else if (box0_2.Color == Color.Blue && box1_2.Color == Color.Blue && box2_2.Color == Color.Blue)
            {
                Winner_O();
            }
            else if (box0_2.Color == Color.Red && box1_2.Color == Color.Red && box2_2.Color == Color.Red)
            {
                Winner_X();
            }
            else if (box0_0.Color == Color.Blue && box1_1.Color == Color.Blue && box2_2.Color == Color.Blue)
            {
                Winner_O();
            }
            else if (box0_0.Color == Color.Red && box1_1.Color == Color.Red && box2_2.Color == Color.Red)
            {
                Winner_X();
            }
            else if (box0_2.Color == Color.Blue && box1_1.Color == Color.Blue && box2_0.Color == Color.Blue)
            {
                Winner_O();
            }
            else if (box0_2.Color == Color.Red && box1_1.Color == Color.Red && box2_0.Color == Color.Red)
            {
                Winner_X();
            }
            else if (step == 9 && winner == false)
            {
                var gameOverPage = new GameOverPage();

                gameOverPage.Init();

                gameOverPage.GetGrid(move1, move2, move3, move4, move5, move6, move7, move8, move9,
                    left1, left2, left3, left4, left5, left6, left7, left8, left8,
                    top1, top2, top3, top4, top5, top6, top7, top8, top9);

                await Navigation.PushModalAsync(gameOverPage);

                Restart();
            }

        }

        private void Restart()
        {
            Initializer();

            winner = false;
            step = 0;
            box0_0.Color = Color.White;
            box0_1.Color = Color.White;
            box0_2.Color = Color.White;
            box1_0.Color = Color.White;
            box1_1.Color = Color.White;
            box1_2.Color = Color.White;
            box2_0.Color = Color.White;
            box2_1.Color = Color.White;
            box2_2.Color = Color.White;

            label_name_player1.TextColor = Color.Gray;
            label_name_player2.TextColor = Color.Gray;
            label_name_player1.TextColor = Color.Blue;

            framePointO.BorderColor = Color.Blue;

            box0_0.IsEnabled = true;
            box0_1.IsEnabled = true;
            box0_2.IsEnabled = true;
            box1_0.IsEnabled = true;
            box1_1.IsEnabled = true;
            box1_2.IsEnabled = true;
            box2_0.IsEnabled = true;
            box2_1.IsEnabled = true;
            box2_2.IsEnabled = true;

            left1 = 0;
            left2 = 0;
            left3 = 0;
            left4 = 0;
            left5 = 0;
            left6 = 0;
            left7 = 0;
            left8 = 0;
            left9 = 0;

            top1 = 0;
            top2 = 0;
            top3 = 0;
            top4 = 0;
            top5 = 0;
            top6 = 0;
            top7 = 0;
            top8 = 0;
            top9 = 0;

            move1 = new Label();
            move2 = new Label();
            move3 = new Label();
            move4 = new Label();
            move5 = new Label();
            move6 = new Label();
            move7 = new Label();
            move8 = new Label();
            move9 = new Label();


        }

        private void Turn()
        {
            if (step == 0)
            { 
                label_name_player2.TextColor = Color.Red;
                label_name_player1.TextColor = Color.Gray;

                framePointX.BorderColor = Color.Red;
                framePointO.BorderColor = Color.Gray;
                
            }
            else if (step == 1)
            {  
                label_name_player1.TextColor = Color.Blue;
                label_name_player2.TextColor = Color.Gray;

                framePointO.BorderColor = Color.Blue;
                framePointX.BorderColor = Color.Gray;
            }
            else if (step == 2)
            {               
                label_name_player2.TextColor = Color.Red;
                label_name_player1.TextColor = Color.Gray;

                framePointX.BorderColor = Color.Red;
                framePointO.BorderColor = Color.Gray;
            }
            else if (step == 3)
            {
                
                label_name_player1.TextColor = Color.Blue;
                label_name_player2.TextColor = Color.Gray;

                framePointO.BorderColor = Color.Blue;
                framePointX.BorderColor = Color.Gray;
            }
            else if (step == 4)
            {
                
                label_name_player2.TextColor = Color.Red;
                label_name_player1.TextColor = Color.Gray;

                framePointX.BorderColor = Color.Red;
                framePointO.BorderColor = Color.Gray;
            }
            else if (step == 5)
            {
                
                label_name_player1.TextColor = Color.Blue;
                label_name_player2.TextColor = Color.Gray;

                framePointO.BorderColor = Color.Blue;
                framePointX.BorderColor = Color.Gray;
            }
            else if (step == 6)
            {
                
                label_name_player2.TextColor = Color.Red;
                label_name_player1.TextColor = Color.Gray;

                framePointX.BorderColor = Color.Red;
                framePointO.BorderColor = Color.Gray;
            }
            else if (step == 7)
            {
                
                label_name_player1.TextColor = Color.Blue;
                label_name_player2.TextColor = Color.Gray;

                framePointO.BorderColor = Color.Blue;
                framePointX.BorderColor = Color.Gray;
            }
            else if (step == 8)
            {
                
                label_name_player2.TextColor = Color.Red;
                label_name_player1.TextColor = Color.Gray;

                framePointX.BorderColor = Color.Red;
                framePointO.BorderColor = Color.Gray;
            }
        }

        private  void Sound()
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            Stream audioStream = assembly.GetManifestResourceStream("GridExample.CentralCity.ogg");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            //var audio = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            audio.Load(audioStream);
            audio.Play();
            //audio.Loop = true;

        }

        [Obsolete]
        private void Move(BoxView box, StackLayout layout, int left, int top)
        {
            if (step == 0)
            {
                var duration = TimeSpan.FromMilliseconds(200);
                Vibration.Vibrate(duration);

                var Player_O = new Label
                {
                    Text = "O",
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                };

                Device.OnPlatform(iOS: () => Player_O.Font = Font.OfSize("AgentOrange", NamedSize.Large));
                Device.OnPlatform(Android: () => Player_O.Font = Font.OfSize("Font/AgentOrange.ttf#Agent Orange", NamedSize.Large));
                Player_O.FontSize = 75;

                box.IsVisible = false;
                box.IsEnabled = false;

                GridGame.Children.Add(Player_O, left, top);
                layout.Children.Add(Player_O);

                move1 = Player_O;
                //layout1 = layout;
                left1 = left;
                top1 = top;

                Player_O.TextColor = Color.FromHex("#2ECCFA"); // Blue
                
                box.Color = Color.Blue;
               
            }
            else if (step == 1)
            {
                var duration = TimeSpan.FromMilliseconds(200);
                Vibration.Vibrate(duration);

                var Player_X = new Label
                {
                    Text = "X",
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                };

                Device.OnPlatform(iOS: () => Player_X.Font = Font.OfSize("AgentOrange", NamedSize.Large));
                Device.OnPlatform(Android: () => Player_X.Font = Font.OfSize("Font/AgentOrange.ttf#Agent Orange", NamedSize.Large));
                Player_X.FontSize = 75;

                box.IsVisible = false;
                box.IsEnabled = false;

                GridGame.Children.Add(Player_X, left, top);
                layout.Children.Add(Player_X);

                move2 = Player_X;
                //layout2 = layout;
                left2 = left;
                top2 = top;


                Player_X.TextColor = Color.Red;

                box.Color = Color.Red;

            }
            else if (step == 2)
            {
                var duration = TimeSpan.FromMilliseconds(200);
                Vibration.Vibrate(duration);

                var Player_O = new Label
                {
                    Text = "O",
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                };

                Device.OnPlatform(iOS: () => Player_O.Font = Font.OfSize("AgentOrange", NamedSize.Large));
                Device.OnPlatform(Android: () => Player_O.Font = Font.OfSize("Font/AgentOrange.ttf#Agent Orange", NamedSize.Large));
                Player_O.FontSize = 75;

                box.IsVisible = false;
                box.IsEnabled = false;

                GridGame.Children.Add(Player_O, left, top);
                layout.Children.Add(Player_O);

                move3 = Player_O;
                //layout3 = layout;
                left3 = left;
                top3 = top;

                Player_O.TextColor = Color.FromHex("#2ECCFA"); // Blue

                box.Color = Color.Blue;

            }
            else if (step == 3)
            {
                var duration = TimeSpan.FromMilliseconds(200);
                Vibration.Vibrate(duration);

                var Player_X = new Label
                {
                    Text = "X",
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                };

                Device.OnPlatform(iOS: () => Player_X.Font = Font.OfSize("AgentOrange", NamedSize.Large));
                Device.OnPlatform(Android: () => Player_X.Font = Font.OfSize("Font/AgentOrange.ttf#Agent Orange", NamedSize.Large));
                Player_X.FontSize = 75;

                box.IsVisible = false;
                box.IsEnabled = false;

                GridGame.Children.Add(Player_X, left, top);
                layout.Children.Add(Player_X);

                move4 = Player_X;
                //layout4 = layout;
                left4 = left;
                top4 = top;

                Player_X.TextColor = Color.Red;

                box.Color = Color.Red;

            }
            else if (step == 4)
            {
                var duration = TimeSpan.FromMilliseconds(200);
                Vibration.Vibrate(duration);

                var Player_O = new Label
                {
                    Text = "O",
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                };

                Device.OnPlatform(iOS: () => Player_O.Font = Font.OfSize("AgentOrange", NamedSize.Large));
                Device.OnPlatform(Android: () => Player_O.Font = Font.OfSize("Font/AgentOrange.ttf#Agent Orange", NamedSize.Large));
                Player_O.FontSize = 75;

                box.IsVisible = false;
                box.IsEnabled = false;

                GridGame.Children.Add(Player_O, left, top);
                layout.Children.Add(Player_O);

                move5 = Player_O;
               // layout5 = layout;
                left5 = left;
                top5 = top;

                Player_O.TextColor = Color.FromHex("#2ECCFA"); // Blue

                box.Color = Color.Blue;

            }
            else if (step == 5)
            {
                var duration = TimeSpan.FromMilliseconds(200);
                Vibration.Vibrate(duration);

                var Player_X = new Label
                {
                    Text = "X",
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                };

                Device.OnPlatform(iOS: () => Player_X.Font = Font.OfSize("AgentOrange", NamedSize.Large));
                Device.OnPlatform(Android: () => Player_X.Font = Font.OfSize("Font/AgentOrange.ttf#Agent Orange", NamedSize.Large));
                Player_X.FontSize = 75;

                box.IsVisible = false;
                box.IsEnabled = false;

                GridGame.Children.Add(Player_X, left, top);
                layout.Children.Add(Player_X);

                move6 = Player_X;
                //layout6 = layout;
                left6 = left;
                top6 = top;

                Player_X.TextColor = Color.Red;

                box.Color = Color.Red;

            }
            else if (step == 6)
            {
                var duration = TimeSpan.FromMilliseconds(200);
                Vibration.Vibrate(duration);

                var Player_O = new Label
                {
                    Text = "O",
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                };

                Device.OnPlatform(iOS: () => Player_O.Font = Font.OfSize("AgentOrange", NamedSize.Large));
                Device.OnPlatform(Android: () => Player_O.Font = Font.OfSize("Font/AgentOrange.ttf#Agent Orange", NamedSize.Large));
                Player_O.FontSize = 75;

                box.IsVisible = false;
                box.IsEnabled = false;

                GridGame.Children.Add(Player_O, left, top);
                layout.Children.Add(Player_O);

                move7 = Player_O;
                //layout7 = layout;
                left7 = left;
                top7 = top;

                Player_O.TextColor = Color.FromHex("#2ECCFA"); // Blue

                box.Color = Color.Blue;
            }
            else if (step == 7)
            {
                var duration = TimeSpan.FromMilliseconds(200);
                Vibration.Vibrate(duration);

                var Player_X = new Label
                {
                    Text = "X",
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                };

                Device.OnPlatform(iOS: () => Player_X.Font = Font.OfSize("AgentOrange", NamedSize.Large));
                Device.OnPlatform(Android: () => Player_X.Font = Font.OfSize("Font/AgentOrange.ttf#Agent Orange", NamedSize.Large));
                Player_X.FontSize = 75;

                box.IsVisible = false;
                box.IsEnabled = false;

                GridGame.Children.Add(Player_X, left, top);
                layout.Children.Add(Player_X);

                move8 = Player_X;
                //layout8 = layout;
                left8 = left;
                top8 = top;

                Player_X.TextColor = Color.Red;

                box.Color = Color.Red;
            }
            else if (step == 8)
            {
                var duration = TimeSpan.FromMilliseconds(200);
                Vibration.Vibrate(duration);

                var Player_O = new Label
                {
                    Text = "O",
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                };

                Device.OnPlatform(iOS: () => Player_O.Font = Font.OfSize("AgentOrange", NamedSize.Large));
                Device.OnPlatform(Android: () => Player_O.Font = Font.OfSize("Font/AgentOrange.ttf#Agent Orange", NamedSize.Large));
                Player_O.FontSize = 75;

                box.IsVisible = false;
                box.IsEnabled = false;

                GridGame.Children.Add(Player_O, left, top);
                layout.Children.Add(Player_O);

                move9 = Player_O;
               // layout9 = layout;
                left9 = left;
                top9 = top;

                Player_O.TextColor = Color.FromHex("#2ECCFA"); // Blue

                box.Color = Color.Blue;
            }

            box.IsEnabled = false;

        }

        private async void Winner_O()
        {
            var winnerOPage = new WinnerOPage();

            winnerOPage.Init();

            winnerOPage.GetGrid(move1, move2, move3, move4, move5, move6, move7, move8, move9,
                left1, left2, left3, left4, left5, left6, left7, left8, left8,
                top1, top2, top3, top4, top5, top6, top7, top8, top9);

            await Navigation.PushModalAsync(winnerOPage);

            pointsPlayer1++;
            winner = true;
            Restart();
            label_point_player1.Text = pointsPlayer1.ToString();
        }

        private async void Winner_X()
        {
            var winnerXPage = new WinnerXPage();

            winnerXPage.Init();

            winnerXPage.GetGrid(move1, move2, move3, move4, move5, move6, move7, move8, move9,
                left1, left2, left3, left4, left5, left6, left7, left8, left8,
                top1, top2, top3, top4, top5, top6, top7, top8, top9);

            await Navigation.PushModalAsync(winnerXPage);

            pointsPlayer2++;
            winner = true;
            Restart();
            label_point_player2.Text = pointsPlayer2.ToString();
        }

        private void Initializer()
        {
            InitializeComponent();
            label_point_player1.Text = pointsPlayer1.ToString();
            label_point_player2.Text = pointsPlayer2.ToString();
        }

        private async void OnTapped_btnBack(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Exit", "Sure you want to leave this game.", "Yes", "No");

            if (answer == true)
            {
                await Navigation.PopModalAsync();
            }
            
        }

        private void OnTapped_btnSetting(object sender, EventArgs e)
        {
            //...
        }
    }
}
