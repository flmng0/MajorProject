using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace Galc {
    public partial class PreferencesForm : Form {
        public PreferencesForm() {
            InitializeComponent();

            AcceptButton = OKButton;

            var settings = State.Settings;

            GridXInput.Text = settings.GridStep.X.ToString();
            GridYInput.Text = settings.GridStep.Y.ToString();
        }

        private void OKButton_Click(object sender, EventArgs e) {
            var settings = State.Settings;

            { // Grid X Step
                var expr = new Expression(GridXInput.Text);

                if (expr.checkSyntax()) {
                    settings.GridStep.X = (float)expr.calculate();
                }
            }

            { // Grid Y Step
                var expr = new Expression(GridYInput.Text);

                if (expr.checkSyntax()) {
                    settings.GridStep.Y = (float)expr.calculate();
                }
            }

            State.Settings = settings;

            State.MainForm.Refresh();
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
