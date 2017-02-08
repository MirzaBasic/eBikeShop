using PeP_PCL.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Imaging;

namespace PeP_Mobile.Products
{
   public class ImageConverter: IValueConverter
    {


     public object  Convert(System.Object value, Type targetType, System.Object parameter, System.String language)
        {

            MemoryStream ms = new MemoryStream(((Proizvodi)value).SlikaThumb);
            BitmapImage image = new BitmapImage();
        image.SetSourceAsync(ms.AsRandomAccessStream());
            return image;

        }


        public object ConvertBack(System.Object value, Type targetType, System.Object parameter, System.String language)
        {


            return null;
        }
    }
}
