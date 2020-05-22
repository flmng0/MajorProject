using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Galc {
    using mXparserFunction = org.mariuszgromada.math.mxparser.Function;


    public partial class FunctionInputForm : Form {
        public const string DefaultFunctionString = "cos(x)";
        private readonly int _functionID;

        public FunctionInputForm() {
            InitializeComponent();

            _functionID = Settings.NextID++;
        }

        private void FunctionInputForm_Load(object sender, EventArgs e) {
            mXparserFunction innerFunction = new mXparserFunction(DefaultFunctionString);
            var function = new Function(innerFunction, Color.Blue);

            Settings.Functions.Add(_functionID, function);

            FunctionInputBox.Text = DefaultFunctionString;

            LineStyleSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (var style in Settings.DashStyleNames) {
                LineStyleSelector.Items.Add(style);
            }
            LineStyleSelector.SelectedIndex = 0;

            ColorPreviewBox.BackColor = function.Color;
        }

        private void FunctionInputBox_TextChanged(object sender, EventArgs e) {
            var function = new mXparserFunction("f(x)=" + FunctionInputBox.Text);

            if (function.checkSyntax()) {
                ErrorToolTip.Hide(this);
                ErrorToolTip.SetToolTip(this, "");
                Settings.Functions[_functionID].InnerFunction = function;

                Settings.MainForm.Refresh();
            }
        }

        private void ColorSelectButton_Click(object sender, EventArgs e) {
            if (ColorPicker.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                ColorPreviewBox.BackColor = ColorPicker.Color;
                Settings.Functions[_functionID].Color = ColorPicker.Color;

                Settings.MainForm.Refresh();
            }
        }

        private void LineStyleSelector_SelectedIndexChanged(object sender, EventArgs e) {
            var lineStyle = (DashStyle)LineStyleSelector.SelectedIndex;
            Settings.Functions[_functionID].Style = lineStyle;

            Settings.MainForm.Refresh();
        }

        private void LineWidthSelector_ValueChanged(object sender, EventArgs e) {
            Settings.Functions[_functionID].Width = (float)LineWidthSelector.Value;

            Settings.MainForm.Refresh();
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void ResetButton_Click(object sender, EventArgs e) {
            FunctionInputBox.Text = DefaultFunctionString;
            var innerFunction = new mXparserFunction(FunctionInputBox.Text);

            var function = Settings.Functions[_functionID];
            function.InnerFunction = innerFunction;
            function.Color = Color.Black;
            function.Style = DashStyle.Solid;
            function.Width = 1.0f;

            LineStyleSelector.SelectedIndex = 0;
            LineWidthSelector.Value = 1;

            ColorPreviewBox.BackColor = function.Color;

            Settings.MainForm.Refresh();
        }

        private void FunctionInputForm_FormClosed(object sender, FormClosedEventArgs e) {
            Settings.Functions.Remove(_functionID);

            Settings.MainForm.Refresh();
        }
    }

}
