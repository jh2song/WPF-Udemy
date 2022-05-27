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

namespace Calculator
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		double lastNumber;
		double result;

		public MainWindow()
		{
			InitializeComponent();

			ACButton.Click += ACButton_Click;
			negativeButton.Click += NegativeButton_Click;
			percentButton.Click += PercentButton_Click;
			equalButton.Click += EqualButton_Click;
		}

		private void EqualButton_Click(object sender, RoutedEventArgs e)
		{
			throw new NotImplementedException();
		}

		private void PercentButton_Click(object sender, RoutedEventArgs e)
		{
			if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
			{
				lastNumber = lastNumber / 100;
				resultLabel.Content = lastNumber.ToString();
			}
		}

		private void NegativeButton_Click(object sender, RoutedEventArgs e)
		{
			if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
			{
				lastNumber = lastNumber * -1;
				resultLabel.Content = lastNumber.ToString();
			}
		}

		private void ACButton_Click(object sender, RoutedEventArgs e)
		{
			resultLabel.Content = "0";
		}

		private void sevenButton_Click(object sender, RoutedEventArgs e)
		{
			if (resultLabel.Content.ToString() == "0")
			{
				resultLabel.Content = "7";
			}
			else
			{
				resultLabel.Content = $"{resultLabel.Content}7";
			}
		}
	}
}
