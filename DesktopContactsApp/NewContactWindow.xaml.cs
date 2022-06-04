using DesktopContactsApp.Classes;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DesktopContactsApp
{
	/// <summary>
	/// NewContactWindow.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class NewContactWindow : Window
	{
		public NewContactWindow()
		{
			InitializeComponent();

			Owner = Application.Current.MainWindow;
			WindowStartupLocation = WindowStartupLocation.CenterOwner;
		}

		private void SaveButton_Click(object sender, RoutedEventArgs e)
		{
			Contact contact = new Contact()
			{
				Name = nameTextBox.Text,
				Email = emailTextBox.Text,
				Phone = phoneTextBox.Text
			};

			using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
			{
				connection.CreateTable<Contact>();
				connection.Insert(contact);
			}

			Close();
		}
	}
}
