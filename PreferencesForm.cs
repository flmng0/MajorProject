using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace Galc {
    public partial class PreferencesForm : Form {
        public PreferencesForm() {
            InitializeComponent();

            InitFromSettings(State.Settings);
        }

        private void InitFromSettings(Settings s) {
            var step = s.GridStep;
            GridXInput.Text = step.X.ToString();
            GridYInput.Text = step.Y.ToString();

            var view = s.Viewport;
            MinXInput.Text = view.MinX.ToString();
            MaxXInput.Text = view.MaxX.ToString();
            MinYInput.Text = view.MinY.ToString();
            MaxYInput.Text = view.MaxY.ToString();
        }

        private double GetExpressionOutput(string expression) {
            var expr = new Expression(expression);

            if (!expr.checkSyntax()) {
                throw new ArgumentException("Invalid syntax in expression: " + expression);
            }

            return expr.calculate();
        }

        private void OKButton_Click(object sender, EventArgs e) {
            var settings = State.Settings;

            try {
                // For some reason, GridStep can't be aliased and modified.
                settings.GridStep.X = (float)GetExpressionOutput(GridXInput.Text);
                settings.GridStep.Y = (float)GetExpressionOutput(GridYInput.Text);

                var view = settings.Viewport;
                view.MinX = (float)GetExpressionOutput(MinXInput.Text);
                view.MaxX = (float)GetExpressionOutput(MaxXInput.Text);
                view.MinY = (float)GetExpressionOutput(MinYInput.Text);
                view.MaxY = (float)GetExpressionOutput(MaxYInput.Text);

                State.Settings = settings;
                State.MainForm.Refresh();

                Close();   
            }
            catch (Exception err) {
                var result = MessageBox.Show(
                    err.Message,
                    "Invalid expression",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
