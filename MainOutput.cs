using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace Galc {
    public partial class MainOutputForm : Form {
        private Viewport _viewport;
        // Disposed of in the MainOutpu.Designer.cs file.
        private BufferedGraphics _bufferedGraphics;

        public MainOutputForm() {
            InitializeComponent();

            var size = ClientSize;
            var aspectRatio = (float)size.Width / (float)size.Height;

            _viewport = new Viewport(aspectRatio);

            UpdateBufferedGraphics();
        }

        private void UpdateBufferedGraphics() {
            var context = BufferedGraphicsManager.Current;
            context.MaximumBuffer = ClientSize;

            _bufferedGraphics = context.Allocate(CreateGraphics(), DisplayRectangle);
            _bufferedGraphics.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            _bufferedGraphics.Graphics.Clear(Color.White);
        }

        private void DrawGridLines(Graphics g) {
            var steps = Settings.GridStep;
            var size = ClientSize;

            var minorStep = new PointF(steps.X, steps.Y);

            using (var pen = new Pen(Brushes.Black)) {
                // Vertical grid lines.
                var startX = Math.Floor(_viewport.MinX / minorStep.X) * minorStep.X;
                var lineCountX = Math.Ceiling(_viewport.Width / minorStep.X) + 1.0f;

                for (var lineIndex = 0; lineIndex < lineCountX; lineIndex++) {
                    var viewX = startX + lineIndex * minorStep.X;

                    var isMajorGridLine = Math.Abs(viewX) <= double.Epsilon;
                    var lineProperties = isMajorGridLine ? Settings.MajorGridLine : Settings.MinorGridLine;

                    pen.Width = lineProperties.Width;
                    pen.Color = lineProperties.Color;

                    var screenX = _viewport.ViewToScreenX((float)viewX, size.Width);
                    g.DrawLine(pen, screenX, 0, screenX, size.Height);
                }


                // Horizontal grid lines.
                var startY = Math.Floor(_viewport.MinY / minorStep.Y) * minorStep.Y;
                var lineCountY = Math.Ceiling(_viewport.Height / minorStep.Y) + 1.0f;

                for (var lineIndex = 0; lineIndex < lineCountY; lineIndex++) {
                    var viewY = startY + lineIndex * minorStep.Y;

                    var isMajorGridLine = Math.Abs(viewY) <= double.Epsilon;
                    var lineProperties = isMajorGridLine ? Settings.MajorGridLine : Settings.MinorGridLine;

                    pen.Width = lineProperties.Width;
                    pen.Color = lineProperties.Color;

                    var screenY = _viewport.ViewToScreenY((float)viewY, size.Height);
                    g.DrawLine(pen, 0, screenY, size.Width, screenY);
                }
            }
        }

        private void DrawFunctions(Graphics g, Dictionary<int, Function> functions) {
            var stepX = _viewport.Width / Settings.Tolerance;

            foreach (var item in functions) {
                var function = item.Value;
                var points = new List<PointF>();

                var inner = function.InnerFunction;
                PointF? previous = null;

                var pen = new Pen(function.Color);
                pen.DashStyle = function.Style;
                pen.Width = function.Width;

                for (int i = 0; i <= Settings.Tolerance; ++i) {
                    // Stop floating point errors when looping with floats, even if just a little.
                    var xInput = _viewport.MinX + i * stepX;

                    inner.setArgumentValue(0, xInput);
                    var result = -(float)inner.calculate();

                    if (float.IsNaN(result))
                        continue;

                    var viewPoint = new PointF(xInput, result);
                    var screenPoint = _viewport.ViewToScreen(viewPoint, ClientSize);

                    if (previous.HasValue) {
                        if (previous.Value.Y - screenPoint.Y > Settings.MaxYDelta) {
                            g.DrawCurve(pen, points.ToArray());
                            points.Clear();
                        }
                    }

                    points.Add(screenPoint);
                    previous = screenPoint;
                }

                if (points.Count > 0)
                    g.DrawCurve(pen, points.ToArray());
            }
        }

        private void MainOutputForm_Paint(object sender, PaintEventArgs e) {
            var g = _bufferedGraphics.Graphics;
            g.Clear(Color.White);

            DrawGridLines(g);
            DrawFunctions(g, Settings.Functions);

            _bufferedGraphics.Render(e.Graphics);
        }

        private void MainOutputForm_MouseWheel(object sender, MouseEventArgs e) {
            if (e.Delta == 0) {
                return;
            }

            float delta = -(float)e.Delta / (float)SystemInformation.MouseWheelScrollDelta;

            var scaleFactor = (float)Math.Pow(1.25, delta);
            _viewport.Scale(scaleFactor);

            Refresh();
        }

        private void MainOutputForm_ClientSizeChanged(object sender, EventArgs e) {
            if (ClientSize.Width == 0 && ClientSize.Height == 0)
                return;

            // !!! Is this reliable? Does it get changed by the system during runtime? !!!
            var previousSize = BufferedGraphicsManager.Current.MaximumBuffer;
            var newSize = ClientSize;

            var viewSize = _viewport.ScreenToView(new PointF(newSize.Width, newSize.Height), previousSize);

            _viewport.MaxX = viewSize.X;
            _viewport.MaxY = viewSize.Y;

            UpdateBufferedGraphics();

            Refresh();
        }

        private PointF? previousMouseViewPos = null;
        private void MainOutputForm_MouseMove(object sender, MouseEventArgs e) {
            var size = ClientSize;

            if (e.Button == MouseButtons.Left) {
                if (previousMouseViewPos.HasValue) {
                    var previous = previousMouseViewPos.Value;
                    var viewMousePos = _viewport.ScreenToView(e.Location, size);

                    var delta = new PointF(
                        previous.X - viewMousePos.X,
                        previous.Y - viewMousePos.Y
                    );

                    _viewport.Translate(delta);

                    // Refresh is used rather than invalidate so that the buttons
                    // overlayed on the form are also redrawn.
                    Refresh();
                }
            }

            previousMouseViewPos = _viewport.ScreenToView(e.Location, size);
        }

        private void MainOutputForm_MouseEnter(object sender, EventArgs e) {
            if (ContainsFocus)
                Focus();
        }

        private void AddFunctionButton_Click(object sender, EventArgs e) {
            var inputForm = new FunctionInputForm();
            inputForm.Show();
        }

        public void UpdateFunctions() {
            Refresh();
        }
    }
}
