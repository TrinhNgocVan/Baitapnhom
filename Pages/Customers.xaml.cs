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
    public sealed partial class Customers : Page
    {
        public Customers()
        {

            this.InitializeComponent();
            contentCustomer.Navigate(typeof(Pages.ListCustomer));
       
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string msg = e.Parameter as string;
           

        }

       

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            contentCustomer.Navigate(typeof(ListCustomer));
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            contentCustomer.Navigate(typeof(fromAddCustomer), contentCustomer );
        }

      

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (contentCustomer.CanGoBack)
            {
                contentCustomer.GoBack();
            }
        }

        
    }
}
