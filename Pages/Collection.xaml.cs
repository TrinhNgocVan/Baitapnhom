﻿using Baitapnhom.Models;
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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Baitapnhom.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Collection : Page
    {
        public Collection()
        {
            this.InitializeComponent();
            GetCategory();
        }
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            string msg = e.Parameter as string;
            Title.Text = msg;
        }
        public async void GetCategory()
        {
            Service service = new Service();
            Result cate = await service.GetCategory();
            if (service.GetCategory() != null)
            {
                listCate.ItemsSource = cate.data.foods;
            }
        }
    }
}
