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

namespace Prac001
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		public void RGB_Click(object sender, RoutedEventArgs e)
		{
			Color color;
			if (sender == redButton)
				color = Color.FromRgb(255, 0, 0);
			if (sender == greenButton)
				color = Color.FromRgb(0, 255, 0);
			if (sender == blueButton)
				color = Color.FromRgb(0, 0, 255);

			SolidColorBrush brush = new SolidColorBrush(color);
			panel.Background = brush;
		}
	}
}
