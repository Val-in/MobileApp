using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace MobileApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           // LoadImage();
        }

        private async Task LoadImage()
        {
           /* try
            {
                var client = new HttpClient();
                var response = await client.GetAsync("https://th.bing.com/th/id/OIP.CDeAgNnAG-yyCgEXPq9dhwHaHa?rs=1&pid=ImgDetMain");

                if (response.IsSuccessStatusCode)
                {
                    var imageBytes = await response.Content.ReadAsByteArrayAsync();
                    var imageSource = ImageSource.FromStream(() => new System.IO.MemoryStream(imageBytes));
                    imageControl.Source = imageSource;

                    messageLabel.Text = "Изображение загружено";
                }
                else
                {
                    messageLabel.Text = "Ошибка при загрузке изображения";
                }
            }
            catch (Exception ex)
            {
                messageLabel.Text = $"Ошибка: {ex.Message}";
            } */



            /*try
            {
                var client = new HttpClient();
                var response = await client.GetAsync("https://th.bing.com/th/id/OIP.CDeAgNnAG-yyCgEXPq9dhwHaHa?rs=1&pid=ImgDetMain");

                if (response.IsSuccessStatusCode)
                {
                    var imageBytes = await response.Content.ReadAsByteArrayAsync();
                    var imageSource = ImageSource.FromStream(() => new System.IO.MemoryStream(imageBytes));

                    // Присваиваем изображение контролу Image
                    imageControl.Source = imageSource;
                }
                else
                {
                    Console.WriteLine("Ошибка при загрузке изображения");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }*/
        }
    }
    

}
