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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Universal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void BtnPick_Click(object sender, RoutedEventArgs e)
        {
            //Create an instance of the Random() class:
            Random rnd = new Random();
            //Create an array seq to hold 60 values 0-59:
            int[] seq = new int[59];
            
            //Fill the array with randomized values:
            for (int i = 1; i < 60; i++) seq[i - 1] = i;
            for(int i = 0; i < 59; i++)
            {
                int j = (rnd.Next() % 59);
                int k = seq[i];
                seq[i] = seq[j];
                seq[j] = k;
            }

            //Assign 6 random elements one to each text box:
            TextBlock1.Text = seq[1].ToString();
            TextBlock2.Text = seq[2].ToString();
            TextBlock3.Text = seq[3].ToString();
            TextBlock4.Text = seq[4].ToString();
            TextBlock5.Text = seq[5].ToString();
            TextBlock6.Text = seq[6].ToString();

            //Switch button functionality:
            BtnPick.IsEnabled = false;
            BtnReset.IsEnabled = true;


        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            //Set all text boxes blank:
            TextBlock1.Text = "...";
            TextBlock2.Text = "...";
            TextBlock3.Text = "...";
            TextBlock4.Text = "...";
            TextBlock5.Text = "...";
            TextBlock6.Text = "...";

            //Enable picking number functionality:
            BtnPick.IsEnabled = true;
            BtnReset.IsEnabled = false;
        }
    }
}
