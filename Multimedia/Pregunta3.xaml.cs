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
using System.Resources;
using Multimedia.Properties;
// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace Multimedia
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Pregunta3 : Page
    {
        public Pregunta3()
        {
            this.InitializeComponent();
        }

        int idioma = 0;

        public void traduIT()
        {
            ResourceManager testresource = new ResourceManager(typeof(ResourcesIT));
            cambioLabels(testresource);
            idioma = 2;
        }

        public void traduFRA()
        {
            ResourceManager testresource = new ResourceManager(typeof(ResourcesFRA));
            cambioLabels(testresource);
            idioma = 3;
        }

        public void traduEN()
        {
            ResourceManager testresource = new ResourceManager(typeof(ResourcesEN));
            cambioLabels(testresource);
            idioma = 1;
        }

        public void traduKO()
        {
            ResourceManager testresource = new ResourceManager(typeof(ResourcesKO));
            cambioLabels(testresource);
            idioma = 4;
        }

        private void cambioLabels(ResourceManager testresource)
        {
            opcion1.Content = testresource.GetString("String9");
            opcion2.Content = testresource.GetString("String10");
            opcion3.Content = testresource.GetString("String11");
            opcion4.Content = testresource.GetString("String12");
            opcion1Fallo.Content = testresource.GetString("String9");
            opcion2Fallo.Content = testresource.GetString("String10");
            opcion3Fallo.Content = testresource.GetString("String11");
            opcion4Fallo.Content = testresource.GetString("String12");
            opcion1Correcta.Content = testresource.GetString("String9");
            opcion2Correcta.Content = testresource.GetString("String10");
            opcion3Correcta.Content = testresource.GetString("String11");
            opcion4Correcta.Content = testresource.GetString("String12");

            opcion1Fallo.Visibility = Visibility.Collapsed;
            opcion2Fallo.Visibility = Visibility.Collapsed;
            opcion3Fallo.Visibility = Visibility.Collapsed;
            opcion4Fallo.Visibility = Visibility.Collapsed;
            opcion1Correcta.Visibility = Visibility.Collapsed;
            opcion2Correcta.Visibility = Visibility.Collapsed;
            opcion3Correcta.Visibility = Visibility.Collapsed;
            opcion4Correcta.Visibility = Visibility.Collapsed;
        }

        private void opcion1_Click(object sender, RoutedEventArgs e)
        {
            Frame contentFrame = Window.Current.Content as Frame;
            MainPage mainPage = contentFrame.Content as MainPage;

            if (idioma == 1)
            {
                opcion1Fallo.Visibility = Visibility.Visible;
                opcion2Fallo.Visibility = Visibility.Visible;
                opcion3Fallo.Visibility = Visibility.Visible;
                opcion4Correcta.Visibility = Visibility.Visible;

                mainPage.actu(idioma, 0);
            }
            else if (idioma == 3)
            {
                opcion1Correcta.Visibility = Visibility.Visible;
                opcion2Fallo.Visibility = Visibility.Visible;
                opcion3Fallo.Visibility = Visibility.Visible;
                opcion4Fallo.Visibility = Visibility.Visible;

                mainPage.actu(idioma, 1);
            }
            else if (idioma == 2)
            {
                opcion1Fallo.Visibility = Visibility.Visible;
                opcion2Fallo.Visibility = Visibility.Visible;
                opcion3Correcta.Visibility = Visibility.Visible;
                opcion4Fallo.Visibility = Visibility.Visible;

                mainPage.actu(idioma, 0);
            }
            else if (idioma == 4)
            {
                opcion1Fallo.Visibility = Visibility.Visible;
                opcion2Correcta.Visibility = Visibility.Visible;
                opcion3Fallo.Visibility = Visibility.Visible;
                opcion4Fallo.Visibility = Visibility.Visible;

                mainPage.actu(idioma, 0);
            }
        }

        private void opcion2_Click(object sender, RoutedEventArgs e)
        {
            Frame contentFrame = Window.Current.Content as Frame;
            MainPage mainPage = contentFrame.Content as MainPage;

            if (idioma == 1)
            {
                opcion1Fallo.Visibility = Visibility.Visible;
                opcion2Fallo.Visibility = Visibility.Visible;
                opcion3Fallo.Visibility = Visibility.Visible;
                opcion4Correcta.Visibility = Visibility.Visible;

                mainPage.actu(idioma, 0);
            }
            else if (idioma == 3)
            {
                opcion1Correcta.Visibility = Visibility.Visible;
                opcion2Fallo.Visibility = Visibility.Visible;
                opcion3Fallo.Visibility = Visibility.Visible;
                opcion4Fallo.Visibility = Visibility.Visible;

                mainPage.actu(idioma, 0);
            }
            else if (idioma == 2)
            {
                opcion1Fallo.Visibility = Visibility.Visible;
                opcion2Fallo.Visibility = Visibility.Visible;
                opcion3Correcta.Visibility = Visibility.Visible;
                opcion4Fallo.Visibility = Visibility.Visible;

                mainPage.actu(idioma, 0);
            }
            else if (idioma == 4)
            {
                opcion1Fallo.Visibility = Visibility.Visible;
                opcion2Correcta.Visibility = Visibility.Visible;
                opcion3Fallo.Visibility = Visibility.Visible;
                opcion4Fallo.Visibility = Visibility.Visible;

                mainPage.actu(idioma, 1);
            }
        }

        private void opcion3_Click(object sender, RoutedEventArgs e)
        {
            Frame contentFrame = Window.Current.Content as Frame;
            MainPage mainPage = contentFrame.Content as MainPage;

            if (idioma == 1)
            {
                opcion1Fallo.Visibility = Visibility.Visible;
                opcion2Fallo.Visibility = Visibility.Visible;
                opcion3Fallo.Visibility = Visibility.Visible;
                opcion4Correcta.Visibility = Visibility.Visible;

                mainPage.actu(idioma, 0);
            }
            else if (idioma == 3)
            {
                opcion1Correcta.Visibility = Visibility.Visible;
                opcion2Fallo.Visibility = Visibility.Visible;
                opcion3Fallo.Visibility = Visibility.Visible;
                opcion4Fallo.Visibility = Visibility.Visible;

                mainPage.actu(idioma, 0);
            }
            else if (idioma == 2)
            {
                opcion1Fallo.Visibility = Visibility.Visible;
                opcion2Fallo.Visibility = Visibility.Visible;
                opcion3Correcta.Visibility = Visibility.Visible;
                opcion4Fallo.Visibility = Visibility.Visible;

                mainPage.actu(idioma, 1);
            }
            else if (idioma == 4)
            {
                opcion1Fallo.Visibility = Visibility.Visible;
                opcion2Correcta.Visibility = Visibility.Visible;
                opcion3Fallo.Visibility = Visibility.Visible;
                opcion4Fallo.Visibility = Visibility.Visible;

                mainPage.actu(idioma, 0);
            }
        }

        private void opcion4_Click(object sender, RoutedEventArgs e)
        {
            Frame contentFrame = Window.Current.Content as Frame;
            MainPage mainPage = contentFrame.Content as MainPage;

            if (idioma == 1)
            {
                opcion1Fallo.Visibility = Visibility.Visible;
                opcion2Fallo.Visibility = Visibility.Visible;
                opcion3Fallo.Visibility = Visibility.Visible;
                opcion4Correcta.Visibility = Visibility.Visible;

                mainPage.actu(idioma, 1);
            }
            else if (idioma == 3)
            {
                opcion1Correcta.Visibility = Visibility.Visible;
                opcion2Fallo.Visibility = Visibility.Visible;
                opcion3Fallo.Visibility = Visibility.Visible;
                opcion4Fallo.Visibility = Visibility.Visible;

                mainPage.actu(idioma, 0);
            }
            else if (idioma == 2)
            {
                opcion1Fallo.Visibility = Visibility.Visible;
                opcion2Fallo.Visibility = Visibility.Visible;
                opcion3Correcta.Visibility = Visibility.Visible;
                opcion4Fallo.Visibility = Visibility.Visible;

                mainPage.actu(idioma, 0);
            }
            else if (idioma == 4)
            {
                opcion1Fallo.Visibility = Visibility.Visible;
                opcion2Correcta.Visibility = Visibility.Visible;
                opcion3Fallo.Visibility = Visibility.Visible;
                opcion4Fallo.Visibility = Visibility.Visible;

                mainPage.actu(idioma, 0);
            }
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            opcion1Fallo.Visibility = Visibility.Collapsed;
            opcion2Fallo.Visibility = Visibility.Collapsed;
            opcion3Fallo.Visibility = Visibility.Collapsed;
            opcion4Fallo.Visibility = Visibility.Collapsed;
            opcion1Correcta.Visibility = Visibility.Collapsed;
            opcion2Correcta.Visibility = Visibility.Collapsed;
            opcion3Correcta.Visibility = Visibility.Collapsed;
            opcion4Correcta.Visibility = Visibility.Collapsed;
        }
    }
}
