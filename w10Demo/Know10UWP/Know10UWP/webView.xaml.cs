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
    public sealed partial class webView : Page
    {
        public webView()
        {
            this.InitializeComponent();
        }
        void ComboBox1_DropDownOpened(object sender, object e)
        {
            if (Rect1.Visibility == Windows.UI.Xaml.Visibility.Visible)
            {
                WebViewBrush b = new WebViewBrush();
                b.SourceName = "WebView6";
                b.Redraw();
                Rect1.Fill = b;
                WebView6.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
        }

        void ComboBox1_DropDownClosed(object sender, object e)
        {
            WebView6.Visibility = Windows.UI.Xaml.Visibility.Visible;
            Rect1.Fill = new SolidColorBrush(Windows.UI.Colors.Transparent);
        }
    }
}
