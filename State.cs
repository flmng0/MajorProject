using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This file really needs to be renamed to "Shared" or something similar.
//
// While state is normally shared throughout the application, half of this
// file is just type definitions :/

namespace Galc {
    using mXparserFunction = org.mariuszgromada.math.mxparser.Function;

    public struct GridLineProperties {
        public Color Color;
        public float Width;

        public GridLineProperties(Color color, float width) {
            Color = color;
            Width = width;
        }
    }

    public class Function {
        public mXparserFunction InnerFunction;
        public Color Color;
        public DashStyle Style;
        public float Width;

        public Function(mXparserFunction inner, Color color, DashStyle style = DashStyle.Solid, float width = 1.0f) {
            InnerFunction = inner;
            Color = color;
            Style = style;
            Width = width;
        }
    }

    /// <summary>
    /// Global settings for the calculator.
    /// </summary>
    public static class Settings {
        /// <summary>
        /// The main output form. This is set in the entry point of Program.cs
        /// </summary>
        public static MainOutputForm MainForm = null;

        /// <summary>
        /// Static line styles array. An array of line styles as a string.
        /// </summary>
        // This is pretty bad practice since the DashStyles enum and the names indices have
        // to be manually synced on every addition/change.
        public static readonly string[] DashStyleNames = {
            "Solid",
            "Dashed",
            "Dotted",
            "Alternating Dashes and Dots",
            "Alternating Dashes and two Dots",
        };

        /// <summary>
        /// Amount of points to draw for each function.
        /// </summary>
        public static int Tolerance = 1024;

        /// <summary>
        /// Line width for the second thickest line style, used for minor grid lines.
        /// </summary>
        public static GridLineProperties MinorGridLine = new GridLineProperties(Color.FromArgb(140, Color.Black), 1f);

        /// <summary>
        /// Line width for major grid lines.
        /// </summary>
        public static GridLineProperties MajorGridLine = new GridLineProperties(Color.FromArgb(240, Color.Black), 2f);

        /// <summary>
        /// The step between each drawn grid line.
        /// </summary>
        public static PointF GridStep = new PointF(1.0f, 1.0f);

        /// <summary>
        /// List of functions for the application.
        /// </summary>
        public static Dictionary<int, Function> Functions = new Dictionary<int, Function>();

        /// <summary>
        /// The next available ID for a function. Used to store the key to access functions
        /// in the Functions dictionary.
        /// </summary>
        public static int NextID = 0;
    }
}
