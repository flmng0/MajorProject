using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Galc {
    using mXparserFunction = org.mariuszgromada.math.mxparser.Function;

    public partial class FunctionInputForm : Form {
        public const string DefaultFunctionString = "cos(x)";
        private readonly int _functionID;

        public FunctionInputForm(int? ID = null) {
            InitializeComponent();
            
            LineStyleSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (var style in State.DashStyleNames) {
                LineStyleSelector.Items.Add(style);
            }

            if (ID.HasValue) {
                _functionID = ID.Value;

                var function = State.Settings.Functions[_functionID];

                FunctionInputBox.Text = function.FunctionDefinition;
                LineStyleSelector.SelectedIndex = (int)function.Style;
                ColorPreviewBox.BackColor = function.Color;
                LineWidthSelector.Value = (decimal)function.Width;
            }
            else {
                _functionID = State.Settings.NextID++;

                var function = new Function(DefaultFunctionString, Color.Blue);
                State.Settings.Functions.Add(_functionID, function);

                FunctionInputBox.Text = DefaultFunctionString;
                LineStyleSelector.SelectedIndex = 0;
                ColorPreviewBox.BackColor = function.Color;
            }
        }

        private void FunctionInputBox_TextChanged(object sender, EventArgs e) {
            var function = State.Settings.Functions[_functionID];

            if (function.Redefine(FunctionInputBox.Text)) {
                State.MainForm.Refresh();
            }
        }

        private void ColorSelectButton_Click(object sender, EventArgs e) {
            if (ColorPicker.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                ColorPreviewBox.BackColor = ColorPicker.Color;
                State.Settings.Functions[_functionID].Color = ColorPicker.Color;

                State.MainForm.Refresh();
            }
        }

        private void LineStyleSelector_SelectedIndexChanged(object sender, EventArgs e) {
            var lineStyle = (DashStyle)LineStyleSelector.SelectedIndex;
            State.Settings.Functions[_functionID].Style = lineStyle;

            State.MainForm.Refresh();
        }

        private void LineWidthSelector_ValueChanged(object sender, EventArgs e) {
            State.Settings.Functions[_functionID].Width = (float)LineWidthSelector.Value;

            State.MainForm.Refresh();
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void ResetButton_Click(object sender, EventArgs e) {
            FunctionInputBox.Text = DefaultFunctionString;
            var innerFunction = new mXparserFunction("f(x)=" + FunctionInputBox.Text);

            var function = State.Settings.Functions[_functionID];
            function.Redefine(FunctionInputBox.Text);
            function.Color = Color.Blue;
            function.Style = DashStyle.Solid;
            function.Width = 1.0f;

            LineStyleSelector.SelectedIndex = 0;
            LineWidthSelector.Value = 1;

            ColorPreviewBox.BackColor = function.Color;

            State.MainForm.Refresh();
        }

        private void FunctionInputForm_FormClosed(object sender, FormClosedEventArgs e) {
            State.Settings.Functions.Remove(_functionID);

            State.MainForm.Refresh();
        }
    }

}
