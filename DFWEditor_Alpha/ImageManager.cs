using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace DFWEditor_Alpha
{
    class ImageManager
    {
        public static void Cut(Image img, int width, int height, string fileExt, List<Image> imgList)
        {
            Bitmap bitmap = new Bitmap(img);
            Decimal MaxRow = Math.Ceiling((Decimal)bitmap.Height / height);
            Decimal MaxColumn = Math.Ceiling((decimal)bitmap.Width / width);
            for (decimal i = 0; i < MaxRow; i++)
            {
                for (decimal j = 0; j < MaxColumn; j++)
                {
                    String fileName = (i * MaxColumn + j + 1).ToString() + "." + fileExt;
                    Bitmap bmp = new Bitmap(width, height);

                    for (int offsetX = 0; offsetX < width; offsetX++)
                    {
                        for (int offsetY = 0; offsetY < height; offsetY++)
                        {
                            if (((j * width + offsetX) < bitmap.Width) && ((i * height + offsetY) < bitmap.Height))
                            {
                                bmp.SetPixel(offsetX, offsetY, bitmap.GetPixel((int)(j * width + offsetX), (int)(i * height + offsetY)));
                            }
                        }
                    }
                    Graphics g = Graphics.FromImage(bmp);
                    ImageFormat format = ImageFormat.Png;
                    Stream stream = new System.IO.MemoryStream();

                    switch (fileExt.ToLower())
                    {
                        case "png":
                            format = ImageFormat.Png;
                            break;
                        case "bmp":
                            format = ImageFormat.Bmp;
                            break;
                        case "gif":
                            format = ImageFormat.Gif;
                            break;

                    }
                    bmp.Save(stream, format);

                    Image streamImg = Image.FromStream(stream);
                    imgList.Add(streamImg);
                }
            }

        }
    }
}
