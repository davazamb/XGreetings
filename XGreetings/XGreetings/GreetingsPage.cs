using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XGreetings
{
    public class GreetingsPage : ContentPage
    {
        public GreetingsPage()
        {
            var MyLabel = new Label();
            MyLabel.Text = "Greetings, Xamarin Forms!";
            this.Content = MyLabel;


            //>>>>>Solucion 3<<<<<

            //Padding = new Thickness(0, 20, 0, 0);
            //Padding = Device.OnPlatform<Thickness>(
            //    new Thickness(0, 20, 0, 0),
            //    new Thickness(0),
            //    new Thickness(0));

            //Device.OnPlatform(() =>
            //{
            //    Padding = new Thickness(0, 20, 0, 0);
            //});

            //>>>>>Solucion 4<<<<<

            //MyLabel.HorizontalOptions = LayoutOptions.Center;
            //MyLabel.VerticalOptions = LayoutOptions.Center;

            //>>>>>Solucion 5<<<<<

            MyLabel.HorizontalTextAlignment = TextAlignment.Center;
            MyLabel.VerticalTextAlignment = TextAlignment.Center;
        }
    }
}
