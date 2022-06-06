using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
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

namespace LandmarkAI
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

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Image file (*.png, *.jpg)|*.png;*.jpg;*.jpeg|All files (*.*)|*.*";
			dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

			if (dialog.ShowDialog() == true)
			{
				string fileName = dialog.FileName;
				selectedImage.Source = new BitmapImage(new Uri(fileName));

				MakePredictionAsync(fileName);
			}
		}

		private async void MakePredictionAsync(string fileName)
		{
			string url = "https://japaneast.api.cognitive.microsoft.com/customvision/v3.0/Prediction/d0264aa9-d053-4e65-8400-34b969e33890/classify/iterations/Iteration1/image";
			string prediction_key = "50c65eb74c344c189d213e5f04599ddc";
			string content_type = "application/octet-stream";
			var file = File.ReadAllBytes(fileName);

			using (HttpClient client = new HttpClient())
			{
				client.DefaultRequestHeaders.Add("Prediction-Key", prediction_key);

				using (var content = new ByteArrayContent(file))
				{
					content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(content_type);
					var response = await client.PostAsync(url, content);

					var responseString = await response.Content.ReadAsStringAsync();
				}
			}

		}
	}
}
