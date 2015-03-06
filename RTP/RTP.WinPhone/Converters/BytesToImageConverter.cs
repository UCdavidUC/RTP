using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace RTP.WinPhone.Converters
{
	public class BytesToImageConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			if (value != null && value is byte[])
			{
				byte[] bytes = value as byte[];
				MemoryStream stream = new MemoryStream(bytes);
				BitmapImage image = new BitmapImage();

				image.SetSource(stream);

				return image;
			}

			return null;

		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
