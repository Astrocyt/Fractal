using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace FractalCreator.Data
{
    public class BitmapEditor
    {
        private Bitmap _bitmap;
        private IntPtr _ptr;
        private BitmapData _bitmapData;
        private byte[] _pixels;
        private int _depth;
        private int _width;
        private int _height;




        public BitmapEditor(Bitmap bitmap)
        {
            this._bitmap = bitmap;
        }

        public void LockBits()
        {
            this._depth = Bitmap.GetPixelFormatSize(_bitmap.PixelFormat);
            this._width = _bitmap.Width;
            this._height = _bitmap.Height;
            this._bitmapData = _bitmap.LockBits(
                new Rectangle(0, 0, _width, _height), ImageLockMode.ReadWrite, _bitmap.PixelFormat);

            int pixelCount = _bitmap.Width * _bitmap.Height;
            int step = _depth / 8;
            this._pixels = new byte[pixelCount * step];
            this._ptr = _bitmapData.Scan0;
            Marshal.Copy(_ptr, _pixels, 0, _pixels.Length);
        }
        public void UnlockBits()
        {
            Marshal.Copy(_pixels,0,_ptr,_pixels.Length);
            _bitmap.UnlockBits(_bitmapData);
        }
        public void SetPixel(int x,int y,Color color)
        {
            int cCount = _depth / 8;

            // Get start index of the specified pixel
            int i = ((y * _width) + x) * cCount;

            if (_depth == 32) // For 32 bpp set Red, Green, Blue and Alpha
            {
                _pixels[i] = color.B;
                _pixels[i + 1] = color.G;
                _pixels[i + 2] = color.R;
                _pixels[i + 3] = color.A;
            }
            else if (_depth == 24) // For 24 bpp set Red, Green and Blue
            {
                _pixels[i] = color.B;
                _pixels[i + 1] = color.G;
                _pixels[i + 2] = color.R;
            }
            else if (_depth == 8)
            // For 8 bpp set color value (Red, Green and Blue values are the same)
            {
                _pixels[i] = color.B;
            }
        }
    }
}
