using DesktopContactsApp.Classes;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesktopContactsApp.Controls
{
	/// <summary>
	/// ContactControl.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class ContactControl : UserControl
	{

		public Contact Contact
		{
			get { return (Contact)GetValue(ContactProperty); }
			set { SetValue(ContactProperty, value); }
		}

		// Using a DependencyProperty as the backing store for Contact.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty ContactProperty =
			DependencyProperty.Register("Contact", typeof(Contact), typeof(ContactControl), new PropertyMetadata(new Contact() { Name="홍길동", Email="example@domain.com", Phone="(123) 456 7890" }, SetText));

		private static void SetText(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			ContactControl control = d as ContactControl;

			if (control != null)
			{
				control.nameTextBlock.Text = (e.NewValue as Contact).Name;
				control.emailTextBlock.Text = (e.NewValue as Contact).Email;
				control.phoneTextBlock.Text = (e.NewValue as Contact).Phone;
			}
		}

		public ContactControl()
		{
			InitializeComponent();
		}
	}
}
