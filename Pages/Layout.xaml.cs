using Baitapnhom.Models;
using Baitapnhom.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Baitapnhom.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Layout : Page
    {
        public Layout()
        {
            this.InitializeComponent();
            GetMenu();
        }
        public async void GetMenu()
        {
            Service service = new Service();
            Menu menu = await service.GetMenu();
            if (service.GetMenu() != null)
            {
                listMenu.ItemsSource = menu.data;
            }
        }
        public async void Button_Click_Menu(object sender, RoutedEventArgs e)
        {
            SplitView_Menu.IsPaneOpen = !SplitView_Menu.IsPaneOpen;
            MediaElement mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Hello !");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

        public void Listview_Tapped(object sender, RoutedEventArgs e)
        {
            Item item = listMenu.SelectedItem as Item; // Onclick 
            switch (item.name)
            {
                case "Burger": MainFrame.Navigate(typeof(Pages.Home), "THIS IS HOME PAGE"); break;
                case "Dessert": MainFrame.Navigate(typeof(Pages.Eat_In), "THIS IS EAT-IN PAGE"); break;
                case "Rice": MainFrame.Navigate(typeof(Pages.Collection), "THIS IS COLLECTION PAGE"); break;
                case "Drinks": MainFrame.Navigate(typeof(Pages.Delivery), "THIS IS DELIVERY PAGE"); break;
                case "Chicken": MainFrame.Navigate(typeof(Pages.Take_Away), "THIS IS TAKE AWAY PAGE"); break;
                case "driverpayment": MainFrame.Navigate(typeof(Pages.Driver_Payment), "THIS IS DRIVER PAYMENT PAGE"); break;
                case "customers": MainFrame.Navigate(typeof(Pages.Customers), "THIS IS CUSTOMER PAGE"); break;
            }
        }
        public void Image_Loaded(object sender, RoutedEventArgs e)
        {
            Image img = sender as Image;
            if (img != null)
            {
                BitmapImage bitmapImage = new BitmapImage();
                img.Width = bitmapImage.DecodePixelWidth = 280;
                bitmapImage.UriSource = new Uri("ms-appx:///Assets/jolibee.png");
                img.Source = bitmapImage;
            }
        }
    }
}
