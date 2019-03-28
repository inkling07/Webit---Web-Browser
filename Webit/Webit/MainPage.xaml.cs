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

// Il modello di elemento Pagina vuota è documentato all'indirizzo https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x410

namespace Webit
{
    /// <summary>
    /// Pagina vuota che può essere usata autonomamente oppure per l'esplorazione all'interno di un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            
        }
        

        private void serarch(object sender, RoutedEventArgs e)
        {

            texturl.Text = "http://" + textboxsearch.Text;
            webview.Navigate(new Uri(texturl.Text));
            


            //--</ load website >--
        }

        private void backwebview(object sender, RoutedEventArgs e)
        {
            webview.GoBack();
        }

        private void forwardwebview(object sender, RoutedEventArgs e)
        {
            webview.GoForward();
        }

        private void loading(WebView sender, WebViewContentLoadingEventArgs args)
        {
            progressweb.IsActive = true;
        }

        private void finish(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            progressweb.IsActive = false;
        }
    }

        
    }

