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
using Windows.UI.Xaml.Navigation;
using Baitapnhom.Models;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Baitapnhom.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class fromAddCustomer : Page
    {
        public fromAddCustomer()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string msg = e.Parameter as string;
            




        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string name = input1.Text;
            string address = input2.Text;
            string phone = input3.Text;
            string age = input4.Text;
            string type = input5.Text;
            Customer customer = new Customer(name, address, phone, age, type);
            this.Frame.Navigate(typeof(ListCustomer),customer);
        
                }
    }
}
