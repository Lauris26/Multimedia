﻿using System;
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
    public sealed partial class Menu : Page
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
