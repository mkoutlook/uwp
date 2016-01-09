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
    public sealed partial class FlipView : Page
    {
        String Image = @"F:\Mayurdhvajsinh\practice\w10Demo\Know10UWP\Know10UWP\Assets\StoreLogo.png";
            String Name = "mayur";
        public FlipView()
        {
            
            this.InitializeComponent();
        }

        private void FlipView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
