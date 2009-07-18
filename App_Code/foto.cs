using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;

/// <summary>
/// Summary description for foto
/// </summary>
public class foto
{
    public static System.Drawing.Image oku(string fileName) //ikra!
    {
        System.Drawing.Image theImage = null;
        using (FileStream fileStream = new FileStream(fileName, FileMode.Open,
        FileAccess.Read))
        {
            byte[] img;
            img = new byte[fileStream.Length];
            fileStream.Read(img, 0, img.Length);
            fileStream.Close();
            theImage = System.Drawing.Image.FromStream(new MemoryStream(img));
            img = null;
        }
        GC.Collect();
        return theImage;
    }

        public static void SaveJpeg (string path, Image img, int quality)
        {
            if (quality<0  ||  quality>100)
                throw new ArgumentOutOfRangeException("quality must be between 0 and 100.");

            
            // Encoder parameter for image quality
            EncoderParameter qualityParam =
                new EncoderParameter (Encoder.Quality, quality);
            // Jpeg image codec
            ImageCodecInfo   jpegCodec = GetEncoderInfo("image/jpeg");

            EncoderParameters encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = qualityParam;

            img.Save (path, jpegCodec, encoderParams);
        }

        /// <summary>
        /// Returns the image codec with the given mime type
        /// </summary>
        private static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            // Get image codecs for all image formats
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

            // Find the correct image codec
            for(int i=0; i<codecs.Length; i++)
                if(codecs[i].MimeType == mimeType)
                    return codecs[i];
            return null;
        } 
}
