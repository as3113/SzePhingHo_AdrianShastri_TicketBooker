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
using System.Windows.Shapes;
using System.Drawing;
using Aspose.BarCode.Generation;

namespace TicketTest
{
    /// <summary>
    /// Interaction logic for ETicket.xaml
    /// </summary>
    public partial class ETicket : Window
    {
        public ETicket()
        {
            InitializeComponent();
            GenerateBarcode("1001000010000010001");

           
        }
        private void GenerateBarcode(string barcodeValue)
        {
            using (var barcodeGenerator = new BarcodeGenerator(EncodeTypes.Code128))
            {
                barcodeGenerator.CodeText = barcodeValue;

             /*   // Optional: Set barcode size and margins using separate properties
                barcodeGenerator.Parameters.Barcode.XDimension.Millimeters = 1.0f;
                barcodeGenerator.Parameters.Margin.Top.Millimeters = 5;
                barcodeGenerator.Parameters.Margin.Bottom.Millimeters = 5;
                barcodeGenerator.Parameters.Margin.Left.Millimeters = 5;
                barcodeGenerator.Parameters.Margin.Right.Millimeters = 5;*/

                // Generate the barcode image
                using (var barcodeImageStream = new System.IO.MemoryStream())
                {
                    barcodeGenerator.Save(barcodeImageStream, BarCodeImageFormat.Png);

                    // Convert the barcode image stream to BitmapImage
                    BitmapImage barcodeBitmapImage = new BitmapImage();
                    barcodeBitmapImage.BeginInit();
                    barcodeBitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                    barcodeBitmapImage.StreamSource = barcodeImageStream;
                    barcodeBitmapImage.EndInit();

                    // Set the BitmapImage as the source for the Image control (assuming you have an Image control named "barcodeImage")
                    barcodeImage.Source = barcodeBitmapImage;
                }
            }
        }
    }
}
