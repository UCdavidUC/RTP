using Acr.MvvmCross.Plugins.BarCodeScanner;
using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;

namespace RTP.ViewModels
{
    public class QRViewModel : MvxViewModel
    {
		private Guid code;

		private byte[] imageBytes;
		public byte[] ImageBytes
		{
			get { return imageBytes; }
			set { imageBytes = value; RaisePropertyChanged(() => ImageBytes); }
		}

		private IBarCodeService service;
		private int width;
		private int height;

		public QRViewModel(IBarCodeService service)
		{
			this.service = service;
			this.width = 410;
			this.height = 410;
        }

		public void Init(Guid code)
		{
			this.code = code;

			//IBarcodeWriter writer = new BarcodeWriter
			//{
			//	Format = BarcodeFormat.QR_CODE,
			//	Options = { Height = 410, Width = 410 },
			//};
			//var result = writer.Encode("Hello");
			//var a = new ZXing.BinaryBitmap();
			//var barcodeBitmap = new Bitmap(result);
			//pictureBox1.Image = barcodeBitmap;


			//var encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
			//var asdf = encoder.Encode(code.ToString());
			

			//var cfg = new BarCodeCreateConfiguration
			//{
			//	BarCode = code.ToString(),
			//	Height = this.height,
			//	Width = this.width,
			//	Format = BarCodeFormat.QR_CODE,
			//	ImageType = ImageType.Png,
			//};

			//using (var stream = this.service.Create(cfg))
			//{
			//	using (var ms = new MemoryStream())
			//	{
			//		stream.CopyTo(ms);
			//		ms.Position = 0;
			//		this.ImageBytes = ms.ToArray();
			//	}
			//}
		}


    }
}
