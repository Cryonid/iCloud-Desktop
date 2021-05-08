using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace iCloud_Desktop {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();

			StateChanged += MainWindow_StateChanged;
		}

		private void MainWindow_StateChanged(object sender, EventArgs e) {
			if (WindowState == WindowState.Maximized) {
				Border borderContent = (Border)Template.FindName("ContentBorder", this);
				borderContent.Margin = new Thickness(
					SystemParameters.WindowNonClientFrameThickness.Left,
					SystemParameters.WindowNonClientFrameThickness.Top + 7,
					SystemParameters.WindowNonClientFrameThickness.Right,
					SystemParameters.WindowNonClientFrameThickness.Bottom
				);

				Border borderLeftItems = (Border)Template.FindName("TitleBarBorder_LeftItems", this);
				borderLeftItems.Margin = new Thickness(7);

				Border borderRightItems = (Border)Template.FindName("TitleBarBorder_RightItems", this);
				borderRightItems.Margin = new Thickness(7);
			} else if (WindowState == WindowState.Normal) {
				Border borderContent = (Border)Template.FindName("ContentBorder", this);
				borderContent.Margin = new Thickness(
					SystemParameters.WindowNonClientFrameThickness.Left,
					SystemParameters.WindowNonClientFrameThickness.Top,
					SystemParameters.WindowNonClientFrameThickness.Right,
					SystemParameters.WindowNonClientFrameThickness.Bottom
				);

				Border borderLeftItems = (Border)Template.FindName("TitleBarBorder_LeftItems", this);
				borderLeftItems.Margin = new Thickness(0);

				Border borderRightItems = (Border)Template.FindName("TitleBarBorder_RightItems", this);
				borderRightItems.Margin = new Thickness(0);
			}
		}

		#region Web browser Events
		private void WebBrowser_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e) {
			WebBrowser.CoreWebView2.DocumentTitleChanged += CoreWebView2_DocumentTitleChanged;
		}

		private void CoreWebView2_DocumentTitleChanged(object sender, object e) {
			Title = (WebBrowser.CoreWebView2.DocumentTitle == "iCloud") ? "iCloud Desktop" : WebBrowser.CoreWebView2.DocumentTitle;
		}
		#endregion

		#region Button Events
		private void BackButton_Click(object sender, RoutedEventArgs e) {
			WebBrowser.GoBack();
		}

		private void ReloadButton_Click(object sender, RoutedEventArgs e) {
			WebBrowser.Reload();
		}

		private void HomeButton_Click(object sender, RoutedEventArgs e) {
			WebBrowser.Source = new Uri("https://www.icloud.com");
		}

		private void MinimizeButton_Click(object sender, RoutedEventArgs e) {
			WindowState = WindowState.Minimized;
		}

		private void MaximizeButton_Click(object sender, RoutedEventArgs e) {
			WindowState = (WindowState == WindowState.Normal) ? WindowState.Maximized : WindowState.Normal;
		}

		private void CloseButton_Click(object sender, RoutedEventArgs e) {
			Close();
		}
		#endregion
	}
}