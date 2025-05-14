using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace MobileApp
{
    public partial class MainPage : ContentPage
    {
        Button button;

        public MainPage()
        {
            InitializeComponent();
        }

        //protected override void OnAppearing()
        //{
        //    StackLayout views = new StackLayout();
        //    Label label = new Label();

        //    label.Text = "Hello World";
        //    label.TextTransform = TextTransform.Uppercase;
        //    label.FontSize = 25;

        //    button = new Button();
        //    button.Text = "Нажми меня";
        //    button.FontSize = 25;
        //    button.TextColor = Color.FromRgb(200, 150, 30);
        //    button.Clicked += ButtonClick;


        //    views.Children.Add(label);
        //    views.Children.Add(button);

        //    Content = views;

        //}

        private async void ButtonClick(object? sender, EventArgs e)
        {
            //button.Text = "Нажали!";
            //button.TextColor = Color.FromRgb(30, 150, 255);

            if (string.IsNullOrEmpty(nameField.Text))
                errorField.Text = "Name field is empty!";
            else if (string.IsNullOrEmpty(emailField.Text))
                errorField.Text = "Email field is empty!";
            else if (string.IsNullOrEmpty(passwordField.Text))
                errorField.Text = "Password field is empty!";
            else if (!checkField.IsChecked)
                errorField.Text = "Check Box field is empty!";
            else
            {
                errorField.Text = "";
                buttonSend.Text = "DONE";
                buttonSend.TextColor = Color.FromRgb(30, 210, 255);
                await DisplayAlert("Данные из формы", "Все данные получены", "Ок");
            }
        }
    }
}
