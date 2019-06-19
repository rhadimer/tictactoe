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

        //private Label Player_O = new Label {
        //    Text = "O",
        //    FontSize = 80,
        //    VerticalOptions = LayoutOptions.CenterAndExpand,
        //    HorizontalOptions = LayoutOptions.CenterAndExpand };

        //private Label Player_X = new Label
        //{
        //    Text = "X",
        //    FontSize = 80,
        //    VerticalOptions = LayoutOptions.CenterAndExpand,
        //    HorizontalOptions = LayoutOptions.CenterAndExpand
        //};

        public MainPage()
        {
            InitializeComponent();

            label_name_player1.TextColor = Color.Blue;
            label_name_player2.TextColor = Color.Gray;
        
            //Sound();

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
                await DisplayAlert("Game Over", "Nobody won", "OK");
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

            box0_0.IsEnabled = true;
            box0_1.IsEnabled = true;
            box0_2.IsEnabled = true;
            box1_0.IsEnabled = true;
            box1_1.IsEnabled = true;
            box1_2.IsEnabled = true;
            box2_0.IsEnabled = true;
            box2_1.IsEnabled = true;
            box2_2.IsEnabled = true;

            
        }

        private void Turn()
        {
            if (step == 0)
            { 
                label_name_player2.TextColor = Color.Red;
                label_name_player1.TextColor = Color.Gray;
            }
            else if (step == 1)
            {  
                label_name_player1.TextColor = Color.Blue;
                label_name_player2.TextColor = Color.Gray;
            }
            else if (step == 2)
            {               
                label_name_player2.TextColor = Color.Red;
                label_name_player1.TextColor = Color.Gray;
            }
            else if (step == 3)
            {
                
                label_name_player1.TextColor = Color.Blue;
                label_name_player2.TextColor = Color.Gray;
            }
            else if (step == 4)
            {
                
                label_name_player2.TextColor = Color.Red;
                label_name_player1.TextColor = Color.Gray;
            }
            else if (step == 5)
            {
                
                label_name_player1.TextColor = Color.Blue;
                label_name_player2.TextColor = Color.Gray;
            }
            else if (step == 6)
            {
                
                label_name_player2.TextColor = Color.Red;
                label_name_player1.TextColor = Color.Gray;
            }
            else if (step == 7)
            {
                
                label_name_player1.TextColor = Color.Blue;
                label_name_player2.TextColor = Color.Gray;
            }
            else if (step == 8)
            {
                
                label_name_player2.TextColor = Color.Red;
                label_name_player1.TextColor = Color.Gray;
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

            //while (audio.CurrentPosition <= 26)
            //{
            //    if (audio.CurrentPosition == 26)
            //    {
            //        audio.Play();
            //    }
            //}

        }

        private void Move(BoxView box, StackLayout layout, int left, int top)
        {
            if (step == 0)
            {
                var Player_O = new Label
                {
                    Text = "O",
                    FontSize = 80,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                };

                box.IsVisible = false;
                box.IsEnabled = false;

                GridGame.Children.Add(Player_O, left, top);
                layout.Children.Add(Player_O);

                Player_O.TextColor = Color.Blue;
                
                box.Color = Color.Blue;
               
            }
            else if (step == 1)
            {
                var Player_X = new Label
                {
                    Text = "X",
                    FontSize = 80,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                };

                box.IsVisible = false;
                box.IsEnabled = false;

                GridGame.Children.Add(Player_X, left, top);
                layout.Children.Add(Player_X);

                Player_X.TextColor = Color.Red;

                box.Color = Color.Red;

            }
            else if (step == 2)
            {
                var Player_O = new Label
                {
                    Text = "O",
                    FontSize = 80,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                };

                box.IsVisible = false;
                box.IsEnabled = false;

                GridGame.Children.Add(Player_O, left, top);
                layout.Children.Add(Player_O);

                Player_O.TextColor = Color.Blue;

                box.Color = Color.Blue;

            }
            else if (step == 3)
            {
                var Player_X = new Label
                {
                    Text = "X",
                    FontSize = 80,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                };

                box.IsVisible = false;
                box.IsEnabled = false;

                GridGame.Children.Add(Player_X, left, top);
                layout.Children.Add(Player_X);

                Player_X.TextColor = Color.Red;

                box.Color = Color.Red;

            }
            else if (step == 4)
            {
                var Player_O = new Label
                {
                    Text = "O",
                    FontSize = 80,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                };

                box.IsVisible = false;
                box.IsEnabled = false;

                GridGame.Children.Add(Player_O, left, top);
                layout.Children.Add(Player_O);

                Player_O.TextColor = Color.Blue;

                box.Color = Color.Blue;

            }
            else if (step == 5)
            {
                var Player_X = new Label
                {
                    Text = "X",
                    FontSize = 80,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                };

                box.IsVisible = false;
                box.IsEnabled = false;

                GridGame.Children.Add(Player_X, left, top);
                layout.Children.Add(Player_X);

                Player_X.TextColor = Color.Red;

                box.Color = Color.Red;

            }
            else if (step == 6)
            {
                var Player_O = new Label
                {
                    Text = "O",
                    FontSize = 80,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                };

                box.IsVisible = false;
                box.IsEnabled = false;

                GridGame.Children.Add(Player_O, left, top);
                layout.Children.Add(Player_O);

                Player_O.TextColor = Color.Blue;

                box.Color = Color.Blue;
            }
            else if (step == 7)
            {
                var Player_X = new Label
                {
                    Text = "X",
                    FontSize = 80,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                };

                box.IsVisible = false;
                box.IsEnabled = false;

                GridGame.Children.Add(Player_X, left, top);
                layout.Children.Add(Player_X);

                Player_X.TextColor = Color.Red;

                box.Color = Color.Red;
            }
            else if (step == 8)
            {
                var Player_O = new Label
                {
                    Text = "O",
                    FontSize = 80,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                };

                box.IsVisible = false;
                box.IsEnabled = false;

                GridGame.Children.Add(Player_O, left, top);
                layout.Children.Add(Player_O);

                Player_O.TextColor = Color.Blue;

                box.Color = Color.Blue;
            }

            box.IsEnabled = false;


        }

        private async void Winner_O()
        {
            await DisplayAlert("Game Over", "The player O is the winner", "OK");
            pointsPlayer1++;
            winner = true;
            Restart();
            label_point_player1.Text = pointsPlayer1.ToString();
        }

        private async void Winner_X()
        {
            await DisplayAlert("Game Over", "The player X is the winner", "OK");
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

    }
}
