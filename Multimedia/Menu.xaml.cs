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

// La plantilla de elemento Control de usuario está documentada en https://go.microsoft.com/fwlink/?LinkId=234236

namespace Multimedia
{
    public sealed partial class Menu : UserControl
    {
        public Menu()
        {
            this.InitializeComponent();
        }

        int idioma = 0;

        private void eleccion_IT(object sender, PointerRoutedEventArgs e)
        {
            idioma = 3;
        }

        private void eleccion_EN(object sender, PointerRoutedEventArgs e)
        {
            idioma = 1;
        }

        private void eleccion_FRA(object sender, PointerRoutedEventArgs e)
        {
            idioma = 0;
        }

        private void eleccion_KO(object sender, PointerRoutedEventArgs e)
        {
            idioma = 2;
        }

        public int eleccion()
        {
            return idioma;
        }
    }
}
