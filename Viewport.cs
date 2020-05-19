using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galc {
    class Viewport {
        public float MinX { get; set; }
        public float MaxX { get; set; }

        public float MinY { get; set; }
        public float MaxY { get; set; }

        public float Width {
            get { return MaxX - MinX; }
            set {
                var centerX = MinX + Width / 2.0f;

                MinX = centerX - value / 2.0f;
                MaxX = centerX + value / 2.0f;
            }
        }

        public float Height {
            get { return MaxY - MinY; }
            set {
                var centerY = MinY + Height / 2.0f;

                MinY = centerY - value / 2.0f;
                MaxY = centerY + value / 2.0f;
            }
        }

        public Viewport(float aspectRatio, float extent = 5.0f) {
            MinX = -extent * aspectRatio;
            MaxX = extent * aspectRatio;
            MinY = -extent;
            MaxY = extent;
        }

        public float ScreenToViewX(float xCoord, int screenWidth) {
            return MinX + (xCoord / screenWidth) * Width;
        }
        public float ScreenToViewY(float yCoord, int screenHeight) {
            return MinY + (yCoord / screenHeight) * Height;
        }

        public PointF ScreenToView(PointF screenPoint, Size screenSize) {
            return new PointF(
                ScreenToViewX(screenPoint.X, screenSize.Width),
                ScreenToViewY(screenPoint.Y, screenSize.Height)
            );
        }

        public float ViewToScreenX(float xCoord, int screenWidth) {
            return screenWidth * (xCoord - MinX) / Width;
        }
        public float ViewToScreenY(float yCoord, int screenHeight) {
            return screenHeight * (yCoord - MinY) / Height;
        }

        public PointF ViewToScreen(PointF viewPoint, Size screenSize) {
            return new PointF(
                ViewToScreenX(viewPoint.X, screenSize.Width),
                ViewToScreenY(viewPoint.Y, screenSize.Height)    
            );
        }

        public void Scale(float factor) {
            if (factor <= float.Epsilon) {
                // It would be better practice to throw an exception like this, however,
                // there's no need, as it could just be ignored and then the viewport just
                // won't be scaled.
                //
                // throw new ArgumentOutOfRangeException("factor", factor, "Scale factor must be greater than 0");

                Console.WriteLine("Early return Viewport::Scale");
                return;
            }

            Width *= factor;
            Height *= factor;
        }

        public void Translate(PointF delta) {
            var width = Width;
            MinX += delta.X;
            MaxX = MinX + width;

            var height = Height;
            MinY += delta.Y;
            MaxY = MinY + height;
        }
    }
}
