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
    public sealed partial class Pregunta2 : UserControl
    {
        public Pregunta2()
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
            opcion1.Content = testresource.GetString("String5");
            opcion2.Content = testresource.GetString("String6");
            opcion3.Content = testresource.GetString("String7");
            opcion4.Content = testresource.GetString("String8");
        }
    }
}
