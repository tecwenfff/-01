using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace ch5
{
    public class DrawPicture
    {
        public static void DrawPictureForImage(Image img, string logoPath)
        {
            using (Image logoImage = Image.FromFile(logoPath))
            {
                int x = img.Width - logoImage.Width;
                int y = img.Height - logoImage.Height;
                using (Graphics g = Graphics.FromImage(img))
                {
                    g.DrawImage(logoImage, x, y, logoImage.Height, logoImage.Width);

                }
            }
        }
        public static Photo CreateImage(Image image, int width, int height, string imageName, string url, string path, string sign, string logoUrl = null)
        { 
            Image newImg;
            Photo ps = new Photo();
            ps.Title = imageName;
            ps.Url = url;
            ps.Sign = sign;
            newImg = image.GetThumbnailImage(width, height, null, new IntPtr());
            if (!string.IsNullOrEmpty(logoUrl))
            {
                DrawPictureForImage(newImg, logoUrl);
            }
            newImg.Save(path);
            newImg.Dispose();
            return ps;
        }
    }
}