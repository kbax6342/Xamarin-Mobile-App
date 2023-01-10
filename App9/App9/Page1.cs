using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

using Xamarin.Forms;

namespace App9
{
    public class Page1 : ContentPage
    {
        public Page1()
        {
            
            Label labelLarge = new Label
            {
                Text = "Knots",
                FontSize = 40,
                HorizontalOptions = LayoutOptions.Center
            };

            Label labelSmall = new Label
            {
                Text = "This calculator converts Knots into Miles.",
                FontSize = 20,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            Button button = new Button
            {
                Text = "Calculate",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
            };

            Entry entry = new Entry
            {
               
                VerticalOptions = LayoutOptions.Center,
                Keyboard = Keyboard.Numeric
            };

            Label labelSmall2 = new Label
            {
                
                FontSize = 20,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };



            button.Clicked += (sender, args) =>
            {

                labelSmall2.Text = "Miles: " + (int.Parse(entry.Text) * 1.15077945);
               
            };


            Content = new StackLayout
            {
                 

            Children = {
                    labelLarge,
                    labelSmall,
                    entry,
                    button,
                    labelSmall2

                },
                HeightRequest = 1500


            };

          

          
        }
    }
}