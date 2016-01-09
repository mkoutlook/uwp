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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Know10UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ViewBox : Page
    {
        public ViewBox()
        {
            this.InitializeComponent();
        }
        private void stretchNone(object sender, RoutedEventArgs e)
        {
            vb1.Stretch = Stretch.None;
            vb2.Stretch = Stretch.None;
            vb3.Stretch = Stretch.None;
            txt1.Text = "Stretch is now set to None.";
        }

        //Setting the Stretch property to Fill
        private void stretchFill(object sender, RoutedEventArgs e)
        {
            vb1.Stretch = Stretch.Fill;
            vb2.Stretch = Stretch.Fill;
            vb3.Stretch = Stretch.Fill;
            txt1.Text = "Stretch is now set to Fill.";
        }

        //Setting the Stretch property to Uniform
        private void stretchUni(object sender, RoutedEventArgs e)
        {
            vb1.Stretch = Stretch.Uniform;
            vb2.Stretch = Stretch.Uniform;
            vb3.Stretch = Stretch.Uniform;
            txt1.Text = "Stretch is now set to Uniform.";
        }

        //Setting the Stretch property to UniformToFill
        private void stretchUniFill(object sender, RoutedEventArgs e)
        {
            vb1.Stretch = Stretch.UniformToFill;
            vb2.Stretch = Stretch.UniformToFill;
            vb3.Stretch = Stretch.UniformToFill;
            txt1.Text = "Stretch is now set to UniformToFill.";
        }

        //Setting the StretchDirection property to UpOnly
        private void sdUpOnly(object sender, RoutedEventArgs e)
        {
            vb1.StretchDirection = StretchDirection.UpOnly;
            vb2.StretchDirection = StretchDirection.UpOnly;
            vb3.StretchDirection = StretchDirection.UpOnly;
            txt2.Text = "StretchDirection is now UpOnly.";
        }

        //Setting the StretchDirection property to DownOnly
        private void sdDownOnly(object sender, RoutedEventArgs e)
        {
            vb1.StretchDirection = StretchDirection.DownOnly;
            vb2.StretchDirection = StretchDirection.DownOnly;
            vb3.StretchDirection = StretchDirection.DownOnly;
            txt2.Text = "StretchDirection is now DownOnly.";
        }

        //Setting the StretchDirection property to Both
        private void sdBoth(object sender, RoutedEventArgs e)
        {
            vb1.StretchDirection = StretchDirection.Both;
            vb2.StretchDirection = StretchDirection.Both;
            vb3.StretchDirection = StretchDirection.Both;
            txt2.Text = "StretchDirection is now Both.";
        }

    }
}
