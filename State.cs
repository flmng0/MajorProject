using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

// This file really needs to be renamed to "Shared" or something similar.
//
// While state is normally shared throughout the application, half of this
// file is just type definitions :/

namespace Galc {
    using mXparserFunction = org.mariuszgromada.math.mxparser.Function;

    [Serializable]
    public struct GridLineProperties {
        public Color Color;
        public float Width;

        public GridLineProperties(Color color, float width) {
            Color = color;
            Width = width;
        }
    }

    [Serializable]
    public class Function {
        [NonSerialized]
        private mXparserFunction InnerFunction;
        public string FunctionDefinition;
        public Color Color;
        public DashStyle Style;
        public float Width;

        public Function(string definition, Color color, DashStyle style = DashStyle.Solid, float width = 1.0f) {
            FunctionDefinition = "f(x)=" + definition;
            InnerFunction = new mXparserFunction(FunctionDefinition);
            Color = color;
            Style = style;
            Width = width;
        }

        [OnDeserialized]
        internal void OnDeserialized(StreamingContext context) {
            InnerFunction = new mXparserFunction("f(x)=" + FunctionDefinition);
        }

        public bool Redefine(string definition) {
            InnerFunction = new mXparserFunction("f(x)=" + definition);

            if (InnerFunction.checkSyntax()) {
                FunctionDefinition = definition;

                return true;
            }

            return false;
        }

        public double Calculate(double x) {
            InnerFunction.setArgumentValue(0, x);
            return InnerFunction.calculate();
        }
    }

    /// <summary>
    /// Global state and constants.
    /// </summary>
    /// 
    /// Any non user-visible data is put here, along with constants.
    public static class State {
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
        /// The save path that is stored when settings are loaded.
        /// </summary>
        public static string SavePath = null;

        /// <summary>
        /// Settings that the user can manipulate in any way.
        /// </summary>
        public static Settings Settings = new Settings();
    }

    /// <summary>
    /// Global settings for the calculator.
    /// </summary>
    /// 
    /// Global state that is visible and modifiable by the end user.
    [Serializable]
    public class Settings {

        /// <summary>
        /// Line width for the second thickest line style, used for minor grid lines.
        /// </summary>
        public GridLineProperties MinorGridLine = new GridLineProperties(Color.FromArgb(140, Color.Black), 1f);

        /// <summary>
        /// Line width for major grid lines.
        /// </summary>
        public GridLineProperties MajorGridLine = new GridLineProperties(Color.FromArgb(240, Color.Black), 2f);

        /// <summary>
        /// The step between each drawn grid line.
        /// </summary>
        public PointF GridStep = new PointF(1.0f, 1.0f);

        /// <summary>
        /// List of functions for the application.
        /// </summary>
        /// 
        /// Whilst this is not a state by the lamen definition, it is user-modifiable.
        /// Also, it's included in the data that is serialized when saving.
        public Dictionary<int, Function> Functions = new Dictionary<int, Function>();

        /// <summary>
        /// The next available ID for a function. Used to store the key to access functions
        /// in the Functions dictionary.
        /// </summary>
        public int NextID = 0;
    }
}
