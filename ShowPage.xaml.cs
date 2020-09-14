using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace HotRater
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ShowPage : Page
    {

        People SelectedGirl = new People();
        public ShowPage()
        {
            this.InitializeComponent();
            List<People> SortedList = DataAccess.ReadAll().OrderByDescending(o=>o.Rating).ToList();
            listBoxobj.ItemsSource = SortedList;
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void listBoxobj_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBoxobj.SelectedIndex != -1)
            {
                SelectedGirl = listBoxobj.SelectedItem as People;
                List<People> SortedList = DataAccess.ReadAll().OrderByDescending(o => o.Rating).ToList();
                int index = SortedList.FindIndex(a => a.Id == SelectedGirl.Id)  +1;
                display(index);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<People> SortedList = DataAccess.ReadAll().OrderByDescending(o => o.Rating).ToList();
            int index = SortedList.FindIndex(a => a.Name.Contains(SearchName.Text));
            if (index != -1)
            {
                SelectedGirl = SortedList.ElementAt(index);
                display(index + 1);
            }else {
                Name.Text = "Does not exist";
                Image.Source = new BitmapImage(new Uri("ms-appx:///Assets/StoreLogo.png"));
            }
            
        }

        private void display(int index)
        {
            Image.Source = new BitmapImage(new Uri("ms-appx:///" + SelectedGirl.Thumbnail));
            Name.Text = SelectedGirl.Name + " (Rank:" + index + "/" + DataAccess.ReadAll().Count + ")";
        }
    }
}
