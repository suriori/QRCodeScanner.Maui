using AndroidX.Camera.Core;
#if MONOANDROID
using Xamarin.Google.MLKit.Vision.BarCode;
#else
using Xamarin.Google.MLKit.Vision.Barcode.Common;
#endif

namespace QRCodeScanner.Core
{
    public static class Configuration
    {
        public static int BarcodeFormats = Barcode.FormatAllFormats;
    }
}
