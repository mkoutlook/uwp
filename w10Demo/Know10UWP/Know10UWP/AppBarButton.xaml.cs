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
    public sealed partial class AppBarButton : Page
    {
        public AppBarButton()
        {
            this.InitializeComponent();
        }
        
        void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle button click.
        }
        private void PlayPauseButton_Click(object sender, RoutedEventArgs e)
        {
            // Using the Tag property value lets you localize the Label value
            // without affecting the app code.
            if ((string)PlayPauseButton.Tag == "play")
            {
                PlayPauseButton.Icon = new SymbolIcon(Symbol.Pause);
                PlayPauseButton.Label = "Pause";
                PlayPauseButton.Tag = "pause";
            }
            else
            {
                PlayPauseButton.Icon = new SymbolIcon(Symbol.Play);
                PlayPauseButton.Label = "Play";
                PlayPauseButton.Tag = "play";
            }
        }
        void StopButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle button click.
        }
        /*
        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            CommandBar bottomAppBar = this.BottomAppBar as CommandBar;

            if (bottomAppBar != null)
            {
                // SymbolIcon
                AppBarButton button1 = new AppBarButton();
                button1.Icon = new SymbolIcon(Symbol.Like);
                button1.Label = "SymbolIcon";
                button1.Click += AppBarButton_Click;
                bottomAppBar.PrimaryCommands.Add(button1);

                // BitmapIcon
                BitmapIcon bi = new BitmapIcon();
                bi.UriSource = new Uri("ms-appx:///Assets/Slices.png");

                AppBarButton button2 = new AppBarButton();
                button2.Icon = bi;
                button2.Label = "BitmapIcon";
                button2.Click += AppBarButton_Click;
                bottomAppBar.PrimaryCommands.Add(button2);

                // FontIcon  
                FontIcon fi = new FontIcon();
                fi.FontFamily = new Windows.UI.Xaml.Media.FontFamily("Candara");
                fi.FontSize = 16;
                fi.Glyph = "\u2211";

                AppBarButton button3 = new AppBarButton();
                button3.Icon = fi;
                button3.Label = "FontIcon";
                button3.Click += AppBarButton_Click;
                bottomAppBar.PrimaryCommands.Add(button3);

                // PathIcon
                PathIcon pi = new PathIcon();

                PathGeometry pg = new PathGeometry();
                PathFigure pf = new PathFigure();
                pf.IsFilled = true;
                pf.IsClosed = true;
                pf.StartPoint = new Windows.Foundation.Point(16.0, 12.0);
                LineSegment s1 = new LineSegment();
                s1.Point = new Windows.Foundation.Point(20.0, 2.0);
                LineSegment s2 = new LineSegment();
                s2.Point = new Windows.Foundation.Point(20.0, 16.0);
                LineSegment s3 = new LineSegment();
                s3.Point = new Windows.Foundation.Point(1.0, 16.0);
                pf.Segments.Add(s1);
                pf.Segments.Add(s2);
                pf.Segments.Add(s3);
                pg.Figures.Add(pf);

                pi.Data = pg;
                pi.HorizontalAlignment = HorizontalAlignment.Center;

                AppBarButton button4 = new AppBarButton();
                button4.Icon = pi;
                button4.Label = "PathIcon";
                button4.Click += AppBarButton_Click;
                bottomAppBar.PrimaryCommands.Add(button4);
            }
        }
        */

    }
}
