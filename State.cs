using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;

namespace Galc {
    public struct GridLineProperties {
        public Color Color;
        public float Width;

        public GridLineProperties(Color color, float width) {
            Color = color;
            Width = width;
        }
    }

    /// <summary>
    /// Global settings for the calculator.
    /// </summary>
    public static class Settings {
        /// <summary>
        /// Step between each `x` input to functions.
        /// </summary>
        public static double StepX = 1.0f;

        /// <summary>
        /// Line width for minor grid line subdivisions.
        /// </summary>
        public static GridLineProperties SubGridLine = new GridLineProperties(Color.FromArgb(150, Color.Black), 1.0f);

        /// <summary>
        /// Line width for the second thickest line style, used for minor grid lines.
        /// </summary>
        public static GridLineProperties MinorGridLine = new GridLineProperties(Color.FromArgb(195, Color.Black), 2f);

        /// <summary>
        /// Line width for major grid lines.
        /// </summary>
        public static GridLineProperties MajorGridLine = new GridLineProperties(Color.FromArgb(240, Color.Black), 3f);

        public static float SubdivisionLevel = 1.0f;
        public static PointF GridDivisions = new Point(5, 5);

        /// <summary>
        /// The step between each drawn grid line.
        /// </summary>
        public static PointF GridStep = new PointF(1.0f, 1.0f);

        /// <summary>
        /// List of functions for the application.
        /// </summary>
        public static List<Function> Functions = new List<Function>();
    }
}
