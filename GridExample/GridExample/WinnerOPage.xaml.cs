using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GridExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WinnerOPage : ContentPage
    {
        public WinnerOPage()
        {

            InitializeComponent();
            ConfigTheme();
        }

        private Image Move1 = new Image();
        private Image Move2 = new Image();
        private Image Move3 = new Image();
        private Image Move4 = new Image();
        private Image Move5 = new Image();
        private Image Move6 = new Image();
        private Image Move7 = new Image();
        private Image Move8 = new Image();
        private Image Move9 = new Image();

        //private StackLayout Layout1 = new StackLayout();
        //private StackLayout Layout2 = new StackLayout();
        //private StackLayout Layout3 = new StackLayout();
        //private StackLayout Layout4 = new StackLayout();
        //private StackLayout Layout5 = new StackLayout();
        //private StackLayout Layout6 = new StackLayout();
        //private StackLayout Layout7 = new StackLayout();
        //private StackLayout Layout8 = new StackLayout();
        //private StackLayout Layout9 = new StackLayout();

        private int Left1 ;
        private int Left2 ;
        private int Left3 ;
        private int Left4 ;
        private int Left5 ;
        private int Left6 ;
        private int Left7 ;
        private int Left8 ;
        private int Left9 ;

        private int Top1 ;
        private int Top2 ;
        private int Top3 ;
        private int Top4 ;
        private int Top5 ;
        private int Top6 ;
        private int Top7 ;
        private int Top8 ;
        private int Top9 ;

        public void GetGrid(Image move1, Image move2, Image move3, Image move4, Image move5, Image move6, Image move7, Image move8, Image move9,
                            int left1, int left2, int left3, int left4, int left5, int left6, int left7, int left8, int left9,
                            int top1, int top2, int top3, int top4, int top5, int top6, int top7, int top8, int top9)
        {
             //StackLayout layout1,
             //   StackLayout layout2, StackLayout layout3, StackLayout layout4, StackLayout layout5,
             //   StackLayout layout6, StackLayout layout7, StackLayout layout8, StackLayout layout9

            Move1 = move1;
            Move2 = move2;
            Move3 = move3;
            Move4 = move4;
            Move5 = move5;
            Move6 = move6;
            Move7 = move7;
            Move8 = move8;
            Move9 = move9;

            Left1 = left1;
            Left2 = left2;
            Left3 = left3;
            Left4 = left4;
            Left5 = left5;
            Left6 = left6;
            Left7 = left7;
            Left8 = left8;
            Left9 = left9;

            Top1 = top1;
            Top2 = top2;
            Top3 = top3;
            Top4 = top4;
            Top5 = top5;
            Top6 = top6;
            Top7 = top7;
            Top8 = top8;
            Top9 = top9;

            //Layout1 = layout1;
            //Layout2 = layout2;
            //Layout3 = layout3;
            //Layout4 = layout4;
            //Layout5 = layout5;
            //Layout6 = layout6;
            //Layout7 = layout7;
            //Layout8 = layout8;
            //Layout9 = layout9;

            box0_0.IsVisible = false;
            box0_1.IsVisible = false;
            box0_2.IsVisible = false;
            box1_0.IsVisible = false;
            box1_1.IsVisible = false;
            box1_2.IsVisible = false;
            box2_0.IsVisible = false;
            box2_1.IsVisible = false;
            box2_2.IsVisible = false;

            box0_0.IsEnabled = false;
            box0_1.IsEnabled = false;
            box0_2.IsEnabled = false;
            box1_0.IsEnabled = false;
            box1_1.IsEnabled = false;
            box1_2.IsEnabled = false;
            box2_0.IsEnabled = false;
            box2_1.IsEnabled = false;
            box2_2.IsEnabled = false;

            Move1.WidthRequest = 50;
            Move2.WidthRequest = 50;
            Move3.WidthRequest = 50;
            Move4.WidthRequest = 50;
            Move5.WidthRequest = 50;
            Move6.WidthRequest = 50;
            Move7.WidthRequest = 50;
            Move8.WidthRequest = 50;
            Move9.WidthRequest = 50;

            GridGameWinner_O.Children.Add(Move1, Top1, Left1); //le pase los parametros al reves porque la jugada salia al reves. lol
            //Layout1.Children.Add(Move1);
            //Move1.TextColor = Color.Blue;

            GridGameWinner_O.Children.Add(Move2, Top2, Left2);
            //Layout2.Children.Add(Move2);
            //Move2.TextColor = Color.Red;

            GridGameWinner_O.Children.Add(Move3, Top3, Left3);
            //Layout3.Children.Add(Move3);
            //Move3.TextColor = Color.Blue;

            GridGameWinner_O.Children.Add(Move4, Top4, Left4);
            //Layout4.Children.Add(Move4);
            //Move4.TextColor = Color.Red;

            GridGameWinner_O.Children.Add(Move5, Top5, Left5);
            //Layout5.Children.Add(Move5);
            //Move5.TextColor = Color.Blue;

            GridGameWinner_O.Children.Add(Move6, Top6, Left6);
            //Layout6.Children.Add(Move6);
            //Move6.TextColor = Color.Red;

            GridGameWinner_O.Children.Add(Move7, Top7, Left7);
            //Layout7.Children.Add(Move7);
            //Move7.TextColor = Color.Blue;

            GridGameWinner_O.Children.Add(Move8, Top8, Left8);
            //Layout8.Children.Add(Move8);
            //Move8.TextColor = Color.Red;

            GridGameWinner_O.Children.Add(Move9, Top9, Left9);
            //Layout9.Children.Add(Move9);
            //Move9.TextColor = Color.Blue;

        }

        private async void btnPlayAgain_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            
            await Navigation.PopModalAsync();
        }

        private async void btnReturMenu_Click(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Menu());
        }

        public void Init()
        {
            InitializeComponent();
            ConfigTheme();
        }

        public void ConfigTheme()
        {


            if (Menu.theme1 == true)
            {
                BgImage.Source = "low.jpg";
                Menu.theme2 = false;
            }
            else if (Menu.theme2 == true)
            {
                BgImage.Source = "low3.jpg";
                Menu.theme1 = false;
            }


        }

    }
}