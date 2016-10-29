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
        }
    }
}
