using ExampleApp;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Know10UWP
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
        public void getList()
        {
          //  List<T> l = new List<T>();
        }

       

        private void buttonClick(object sender, RoutedEventArgs e)
        {
            textBox.Text = "clicked";
            this.Frame.Navigate(typeof(Button));
        }

        private void buttonHover(object sender, RoutedEventArgs e)
        {
            textBox.Text = "hover";
        }

        private void btnApbrBtn(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AppBarButton));
        }

        private void btnPivot_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pivot));
        }

        private void btnToggle_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ToggleSwitch));
        }

        private void btnSplitView_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SplitView));
        }

        private void btnListView_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ListView));
        }

        private void btnHyperLink_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HyperLink));
        }

        private void btnStackpanel_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(StackPanel));
        }

        private void btnAutoSuggestion_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AutoSuggestionBox));
        }

       

        private void btnBorderdemo(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BorderDemo));
        }

       

        private void btnCalenderDemo(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CalenderDatePicker));
        }

        private void btnCheckboxDemo(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CheckboxDemo));
        }

        private void btnComboboxDemo(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Combobox));
        }

        private void btnCommandbardemo(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CommandBar));
        }

        private void btnContentControldemo(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ContentControlDemo));
        }

        private void btnContentDialogdemo(object sender, RoutedEventArgs e)
        {
            //this.Frame.Navigate(typeof(ContentDialogDemo));
            this.Frame.Navigate(typeof(ContentDialog_2));
        }

      

        private void btnCustomDialogde(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SignInContentDialog));
        }

        private void btnHubdemo(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Hub));
        }

       

        private void btnMenuFlyout1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MenuFlyout));
        }

        private void btnFlipviewDemo(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FlipView));
        }

        private void btnViewBoxDemo(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ViewBox));
        }

        private void btnPopup_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(popup));
        }

        private void btnRichEdit_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RichEditBoxDemo));
        }

        private void btnRichEditBlock_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RichEditTxtBlock));
        }

        private void btnSearchbox_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SearchBox));
        }

        private void webviewClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(webView));
        }
    }
}
