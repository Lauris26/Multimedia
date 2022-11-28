using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using System.Resources;
using Multimedia.Properties;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace Multimedia
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        int puntuacionEN = 0;
        int puntuacionFRA = 0;
        int puntuacionIT = 0;
        int puntuacionKO = 0;

        private void ContentFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        private readonly List<(string Tag, Type Page)> _pages = new List<(string Tag, Type Page)>
        {
            ("inicio", typeof (Pagina1)),
            ("pregunta1", typeof(Pregunta1)),
            ("pregunta2", typeof(Pregunta2)),
            ("pregunta3", typeof(Pregunta3)),
            ("pregunta4", typeof(Pregunta4)),
            ("pregunta5", typeof(Pregunta5)),
        };

        private void NavView_Loaded(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigated += On_Navigated;
            NavView.SelectedItem = NavView.MenuItems[0];
            NavView_Navigate("inicio", new EntranceNavigationTransitionInfo());

            Window.Current.CoreWindow.Dispatcher.AcceleratorKeyActivated += CoreDispatcher_AcceleratorKeyActivated;
            Window.Current.CoreWindow.PointerPressed += CoreWindow_PointerPressed;
            SystemNavigationManager.GetForCurrentView().BackRequested += System_BackRequested;
        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.InvokedItemContainer != null)
            {
                var navItemTag = args.InvokedItemContainer.Tag.ToString();
                NavView_Navigate(navItemTag, args.RecommendedNavigationTransitionInfo);
            }
        }

        private void NavView_Navigate(string navItemTag, NavigationTransitionInfo transitionInfo)
        {
            Type _page = null;
            var item = _pages.FirstOrDefault(p => p.Tag.Equals(navItemTag));
            _page = item.Page;

            var preNavPageType = ContentFrame.CurrentSourcePageType;
            

            if (!(_page is null) && !Type.Equals(preNavPageType, _page))
            {
                ContentFrame.Navigate(_page, null, transitionInfo);
            }
        }

        private void NavView_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
            TryGoBack();
        }

        private void CoreDispatcher_AcceleratorKeyActivated(CoreDispatcher sender, AcceleratorKeyEventArgs e)
        {
            if (e.EventType == CoreAcceleratorKeyEventType.SystemKeyDown && e.VirtualKey == VirtualKey.Left && e.KeyStatus.IsMenuKeyDown == true && !e.Handled)
            {
                e.Handled = TryGoBack();
            }
        }

        private void System_BackRequested(object sender, BackRequestedEventArgs e)
        {
            if (!e.Handled)
            {
                e.Handled = TryGoBack();
            }
        }

        private void CoreWindow_PointerPressed(CoreWindow sender, PointerEventArgs e)
        {
            // Handle mouse back button.
            if (e.CurrentPoint.Properties.IsXButton1Pressed)
            {
                e.Handled = TryGoBack();
            }
        }

        private bool TryGoBack()
        {
            if (!ContentFrame.CanGoBack)
                return false;

            if (NavView.IsPaneOpen && (NavView.DisplayMode == NavigationViewDisplayMode.Compact || NavView.DisplayMode == NavigationViewDisplayMode.Minimal))
                return false;

            ContentFrame.GoBack();
            return true;
        }

        private void On_Navigated(object sender, NavigationEventArgs e)
        {
            NavView.IsBackEnabled = ContentFrame.CanGoBack;
            if (ContentFrame.SourcePageType != null)
            {
                var item = _pages.FirstOrDefault(p => p.Page == e.SourcePageType);
                NavView.SelectedItem = NavView.MenuItems.OfType<NavigationViewItem>().First(n => n.Tag.Equals(item.Tag));
            }
        }

        public void Traduccion_IT()
        {
            ResourceManager testresource = new ResourceManager(typeof(ResourcesIT));

            if (ContentFrame.CurrentSourcePageType.Name == "Pregunta1")
            {
                Pregunta1 pagina = (Pregunta1)ContentFrame.Content;
                pagina.traduIT();
            }

            if (ContentFrame.CurrentSourcePageType.Name == "Pregunta2")
            {
                Pregunta2 pagina = (Pregunta2)ContentFrame.Content;
                pagina.traduIT();
            }

            if (ContentFrame.CurrentSourcePageType.Name == "Pregunta3")
            {
                Pregunta3 pagina = (Pregunta3)ContentFrame.Content;
                pagina.traduIT();
            }
            
            if (ContentFrame.CurrentSourcePageType.Name == "Pregunta4")
            {
                Pregunta4 pagina = (Pregunta4)ContentFrame.Content;
                pagina.traduIT();
            }
            if (ContentFrame.CurrentSourcePageType.Name == "Pregunta5")
            {
                Pregunta5 pagina = (Pregunta5)ContentFrame.Content;
                pagina.traduIT();
            }
        }

        
        public void Traduccion_EN()
        {
            ResourceManager testresource = new ResourceManager(typeof(ResourcesEN));

            if (ContentFrame.CurrentSourcePageType.Name == "Pregunta1")
            {
                Pregunta1 pagina = (Pregunta1)ContentFrame.Content;
                pagina.traduEN();
            }

            if (ContentFrame.CurrentSourcePageType.Name == "Pregunta2")
            {
                Pregunta2 pagina = (Pregunta2)ContentFrame.Content;
                pagina.traduEN();
            }

            if (ContentFrame.CurrentSourcePageType.Name == "Pregunta3")
            {
                Pregunta3 pagina = (Pregunta3)ContentFrame.Content;
                pagina.traduEN();
            }

            if (ContentFrame.CurrentSourcePageType.Name == "Pregunta4")
            {
                Pregunta4 pagina = (Pregunta4)ContentFrame.Content;
                pagina.traduEN();
            }
            if (ContentFrame.CurrentSourcePageType.Name == "Pregunta5")
            {
                Pregunta5 pagina = (Pregunta5)ContentFrame.Content;
                pagina.traduEN();
            }

        }

        public void Traduccion_KO()
        {
            ResourceManager testresource = new ResourceManager(typeof(ResourcesKO));

            if (ContentFrame.CurrentSourcePageType.Name == "Pregunta1")
            {
                Pregunta1 pagina = (Pregunta1)ContentFrame.Content;
                pagina.traduKO();
            }

            if (ContentFrame.CurrentSourcePageType.Name == "Pregunta2")
            { 
                Pregunta2 pagina = (Pregunta2)ContentFrame.Content;
                pagina.traduKO();
            }

            if (ContentFrame.CurrentSourcePageType.Name == "Pregunta3")
            {
                Pregunta3 pagina = (Pregunta3)ContentFrame.Content;
                pagina.traduKO();
            }

            if (ContentFrame.CurrentSourcePageType.Name == "Pregunta4")
            {
                Pregunta4 pagina = (Pregunta4)ContentFrame.Content;
                pagina.traduKO();
            }
            if (ContentFrame.CurrentSourcePageType.Name == "Pregunta5")
            {
                Pregunta5 pagina = (Pregunta5)ContentFrame.Content;
                pagina.traduKO();
            }
        }

        public void Traduccion_FRA()
        {
            ResourceManager testresource = new ResourceManager(typeof(ResourcesFRA));

            if (ContentFrame.CurrentSourcePageType.Name == "Pregunta1")
            {
                Pregunta1 pagina = (Pregunta1)ContentFrame.Content;
                pagina.traduFRA();
            }

            if (ContentFrame.CurrentSourcePageType.Name == "Pregunta2")
            {
                Pregunta2 pagina = (Pregunta2)ContentFrame.Content;
                pagina.traduFRA();
            }

            if (ContentFrame.CurrentSourcePageType.Name == "Pregunta3")
            {
                Pregunta3 pagina = (Pregunta3)ContentFrame.Content;
                pagina.traduFRA();
            }

            if (ContentFrame.CurrentSourcePageType.Name == "Pregunta4")
            {
                Pregunta4 pagina = (Pregunta4)ContentFrame.Content;
                pagina.traduFRA();
            }
            if (ContentFrame.CurrentSourcePageType.Name == "Pregunta5")
            {
                Pregunta5 pagina = (Pregunta5)ContentFrame.Content;
                pagina.traduFRA();
            }
        }

        private void idioma(object sender, SelectionChangedEventArgs e)
        {
            if (seleccionIdioma.SelectedIndex == 0)
            {
                Traduccion_IT();
            }
            else if (seleccionIdioma.SelectedIndex == 1)
            {
                Traduccion_EN();
            }
            else if (seleccionIdioma.SelectedIndex == 2)
            {
                Traduccion_FRA();
            }else
            {
                Traduccion_KO();
            }
        }

        private void actualizar_Click(object sender, RoutedEventArgs e)
        {
            if (ContentFrame.CurrentSourcePageType.Name == "Pregunta1")
            {
                Pregunta1 pagina = (Pregunta1)ContentFrame.Content;
                puntuacionEN += pagina.aciertosEN();
                puntuacionFRA += pagina.aciertosFRA();
                puntuacionIT += pagina.aciertosIT();
                puntuacionKO += pagina.aciertosKO();

                punt1.Text = puntuacionEN.ToString();
                punt2.Text = puntuacionFRA.ToString();
                punt3.Text = puntuacionIT.ToString();
                punt4.Text = puntuacionKO.ToString();
            }

            if (ContentFrame.CurrentSourcePageType.Name == "Pregunta2")
            {
                Pregunta2 pagina = (Pregunta2)ContentFrame.Content;
                puntuacionEN += pagina.aciertosEN();
                puntuacionFRA += pagina.aciertosFRA();
                puntuacionIT += pagina.aciertosIT();
                puntuacionKO += pagina.aciertosKO();

                punt1.Text = puntuacionEN.ToString();
                punt2.Text = puntuacionFRA.ToString();
                punt3.Text = puntuacionIT.ToString();
                punt4.Text = puntuacionKO.ToString();
            }

            if (ContentFrame.CurrentSourcePageType.Name == "Pregunta3")
            {
                Pregunta3 pagina = (Pregunta3)ContentFrame.Content;
                puntuacionEN += pagina.aciertosEN();
                puntuacionFRA += pagina.aciertosFRA();
                puntuacionIT += pagina.aciertosIT();
                puntuacionKO += pagina.aciertosKO();

                punt1.Text = puntuacionEN.ToString();
                punt2.Text = puntuacionFRA.ToString();
                punt3.Text = puntuacionIT.ToString();
                punt4.Text = puntuacionKO.ToString();
            }

            if (ContentFrame.CurrentSourcePageType.Name == "Pregunta4")
            {
                Pregunta4 pagina = (Pregunta4)ContentFrame.Content;
                puntuacionEN += pagina.aciertosEN();
                puntuacionFRA += pagina.aciertosFRA();
                puntuacionIT += pagina.aciertosIT();
                puntuacionKO += pagina.aciertosKO();

                punt1.Text = puntuacionEN.ToString();
                punt2.Text = puntuacionFRA.ToString();
                punt3.Text = puntuacionIT.ToString();
                punt4.Text = puntuacionKO.ToString();
            }
            if (ContentFrame.CurrentSourcePageType.Name == "Pregunta5")
            {
                Pregunta5 pagina = (Pregunta5)ContentFrame.Content;
                puntuacionEN += pagina.aciertosEN();
                puntuacionFRA += pagina.aciertosFRA();
                puntuacionIT += pagina.aciertosIT();
                puntuacionKO += pagina.aciertosKO();

                punt1.Text = puntuacionEN.ToString();
                punt2.Text = puntuacionFRA.ToString();
                punt3.Text = puntuacionIT.ToString();
                punt4.Text = puntuacionKO.ToString();
            }
        }
    }
}
