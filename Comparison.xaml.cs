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
    public sealed partial class Comparison : Page
    {
        List<People> ppl = new List<People>();
        static int CompareLeft = 0;
        static int CompareRight = 0;
        int imagedTapped1;
        int imagedTapped2;
        List<string> LeftEvolution = new List<string>();
        List<string> RightEvolution = new List<string>();
        People pplLeft;
        People pplRight;
        public Comparison()
        {
            LeftEvolution.Add("1");
            LeftEvolution.Add("2");
            RightEvolution.Add("1");
            RightEvolution.Add("2");
            this.InitializeComponent();
            ppl = DataAccess.ReadAll();
            CompareRight = RandomNumberRight();
            CompareLeft = RandomNumberLeft();
            SetItem(CompareLeft, CompareRight);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pplLeft.Score += 1;
            TimeCount();
            Update();
            CompareRight = RandomNumberRight();
            CompareLeft = RandomNumberLeft();
            SetItem(CompareLeft, CompareRight);
            CountReset();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            pplRight.Score += 1;
            TimeCount();
            Update();
            CompareRight = RandomNumberRight();
            CompareLeft = RandomNumberLeft();
            SetItem(CompareLeft, CompareRight);
            CountReset();
        }

        private int RandomNumberLeft()
        {
            Random random = new Random();
            int c = random.Next(0, (ppl.Count));
            if (c != CompareRight)
            {
                return c;
            }
            else
            {
                return RandomNumberLeft();
            }
        }

        private int RandomNumberRight()
        {
            Random random = new Random();
            return random.Next(0, (ppl.Count));
        }

        private void SetItem(int left, int right)
        {
            pplLeft = ppl.ElementAt(left);
            pplRight = ppl.ElementAt(right);
            btn1.Content = pplLeft.Name;
            btn2.Content = pplRight.Name;
            if (pplLeft.evolution1 != null)
            {
                LeftEvolution[0] = (pplLeft.evolution1);
                if (pplLeft.evolution2 != null)
                {
                    LeftEvolution[1] = (pplLeft.evolution2);
                }
                else
                {
                    LeftEvolution[1] = null;
                }
            }
            else
            {
                LeftEvolution[0] = null;
                LeftEvolution[1] = null;
            }
            if (pplRight.evolution1 != null)
            {
                RightEvolution[0] = (pplRight.evolution1);
                if (pplRight.evolution2 != null)
                {
                    RightEvolution[1] = (pplRight.evolution2);
                }
                else
                {
                    RightEvolution[1]=null;
                }
            }
            else
            {
                RightEvolution[0] = null;
                RightEvolution[1] = null;
            }
            img1.Source = new BitmapImage(new Uri("ms-appx:///" + pplLeft.Thumbnail));
            img2.Source = new BitmapImage(new Uri("ms-appx:///" + pplRight.Thumbnail));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ShowPage));
        }

        private void TimeCount()
        {
            pplLeft.TotalTime += 1;
            pplRight.TotalTime += 1;
            pplLeft.Rating = ((decimal)pplLeft.Score / (decimal)pplLeft.TotalTime) * 100;
            pplRight.Rating = ((decimal)pplRight.Score / (decimal)pplRight.TotalTime) * 100;
        }

        private void Update()
        {
            DataAccess.UpdateDetails(pplRight);
            DataAccess.UpdateDetails(pplLeft);
        }

        private void CountReset()
        {
            imagedTapped1 = 0;
            imagedTapped2 = 0;
        }
        private void img1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            imagedTapped1++;
            switch (imagedTapped1)
            {
                case 1:
                    if (LeftEvolution[0] != null)
                    {
                        img1.Source = new BitmapImage(new Uri("ms-appx:///" + LeftEvolution[0]));
                    }
                    break;
                case 2:
                    if (LeftEvolution[1] != null)
                    {
                        img1.Source = new BitmapImage(new Uri("ms-appx:///" + LeftEvolution[1]));
                    }else{
                        img1.Source = new BitmapImage(new Uri("ms-appx:///" + pplLeft.Thumbnail));
                        imagedTapped1 = 0;
                        break;
                    }
                    break;
                case 3:
                    imagedTapped1 = 0;
                    img1.Source = new BitmapImage(new Uri("ms-appx:///" + pplLeft.Thumbnail));
                    break;
                default:
                    img1.Source = new BitmapImage(new Uri("ms-appx:///" + pplLeft.Thumbnail));
                    break;
            }
        }

        private void img2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            imagedTapped2++;
            switch (imagedTapped2)
            {
                case 1:
                    if (RightEvolution[0] != null)
                    {
                        img2.Source = new BitmapImage(new Uri("ms-appx:///" + RightEvolution[0]));
                    }
                    break;
                case 2:
                    if (RightEvolution[1] != null)
                    {
                        img2.Source = new BitmapImage(new Uri("ms-appx:///" + RightEvolution[1]));
                    }else{
                        img2.Source = new BitmapImage(new Uri("ms-appx:///" + pplRight.Thumbnail));
                        imagedTapped2 = 0;
                        break;
                    }
                    break;
                case 3:
                    imagedTapped2 = 0;
                    img2.Source = new BitmapImage(new Uri("ms-appx:///" + pplRight.Thumbnail));
                    break;
                default:
                    img2.Source = new BitmapImage(new Uri("ms-appx:///" + pplRight.Thumbnail));
                    break;
            }
        }
    }
}
