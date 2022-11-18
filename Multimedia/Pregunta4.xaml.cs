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
    public sealed partial class Pregunta4 : Page
    {
        public Pregunta4()
        {
            this.InitializeComponent();
        }

        public void traduIT()
        {
            ResourceManager testresource = new ResourceManager(typeof(ResourcesIT));
            cambioLabels(testresource);
        }

        public void traduFRA()
        {
            ResourceManager testresource = new ResourceManager(typeof(ResourcesFRA));
            cambioLabels(testresource);
        }

        public void traduEN()
        {
            ResourceManager testresource = new ResourceManager(typeof(ResourcesEN));
            cambioLabels(testresource);
        }

        public void traduKO()
        {
            ResourceManager testresource = new ResourceManager(typeof(ResourcesKO));
            cambioLabels(testresource);
        }

        private void cambioLabels(ResourceManager testresource)
        {
            opcion1.Content = testresource.GetString("String20");
            opcion2.Content = testresource.GetString("String17");
            opcion3.Content = testresource.GetString("String18");
            opcion4.Content = testresource.GetString("String19");
            opcion1Respuesta.Content = testresource.GetString("String20");
            opcion2Respuesta.Content = testresource.GetString("String17");
            opcion3Respuesta.Content = testresource.GetString("String18");
            opcion4Respuesta.Content = testresource.GetString("String19");

            opcion1Respuesta.Visibility = Visibility.Collapsed;
            opcion2Respuesta.Visibility = Visibility.Collapsed;
            opcion3Respuesta.Visibility = Visibility.Collapsed;
            opcion4Respuesta.Visibility = Visibility.Collapsed;
        }

        private void opcion1_Click(object sender, RoutedEventArgs e)
        {
            opcion1Respuesta.Visibility = Visibility.Visible;
            opcion2Respuesta.Visibility = Visibility.Visible;
            opcion3Respuesta.Visibility = Visibility.Visible;
            opcion4Respuesta.Visibility = Visibility.Visible;
        }

        private void opcion2_Click(object sender, RoutedEventArgs e)
        {
            opcion1Respuesta.Visibility = Visibility.Visible;
            opcion2Respuesta.Visibility = Visibility.Visible;
            opcion3Respuesta.Visibility = Visibility.Visible;
            opcion4Respuesta.Visibility = Visibility.Visible;
        }

        private void opcion3_Click(object sender, RoutedEventArgs e)
        {
            opcion1Respuesta.Visibility = Visibility.Visible;
            opcion2Respuesta.Visibility = Visibility.Visible;
            opcion3Respuesta.Visibility = Visibility.Visible;
            opcion4Respuesta.Visibility = Visibility.Visible;
        }

        private void opcion4_Click(object sender, RoutedEventArgs e)
        {
            opcion1Respuesta.Visibility = Visibility.Visible;
            opcion2Respuesta.Visibility = Visibility.Visible;
            opcion3Respuesta.Visibility = Visibility.Visible;
            opcion4Respuesta.Visibility = Visibility.Visible;
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            opcion1Respuesta.Visibility = Visibility.Collapsed;
            opcion2Respuesta.Visibility = Visibility.Collapsed;
            opcion3Respuesta.Visibility = Visibility.Collapsed;
            opcion4Respuesta.Visibility = Visibility.Collapsed;
        }
    }
}
