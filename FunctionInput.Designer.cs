namespace Galc
{
    partial class FunctionInputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FunctionInputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LineStyleSelector = new System.Windows.Forms.ComboBox();
            this.ColorPreviewBox = new System.Windows.Forms.TextBox();
            this.ColorSelectButton = new System.Windows.Forms.Button();
            this.ColorPicker = new System.Windows.Forms.ColorDialog();
            this.ResetButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LineWidthSelector = new System.Windows.Forms.NumericUpDown();
            this.ErrorToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LineWidthSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // FunctionInputBox
            // 
            this.FunctionInputBox.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FunctionInputBox.Location = new System.Drawing.Point(74, 13);
            this.FunctionInputBox.Name = "FunctionInputBox";
            this.FunctionInputBox.Size = new System.Drawing.Size(261, 21);
            this.FunctionInputBox.TabIndex = 0;
            this.FunctionInputBox.TextChanged += new System.EventHandler(this.FunctionInputBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Function:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Line Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Line Style:";
            // 
            // LineStyleSelector
            // 
            this.LineStyleSelector.FormattingEnabled = true;
            this.LineStyleSelector.Location = new System.Drawing.Point(75, 66);
            this.LineStyleSelector.Name = "LineStyleSelector";
            this.LineStyleSelector.Size = new System.Drawing.Size(259, 21);
            this.LineStyleSelector.TabIndex = 4;
            this.LineStyleSelector.SelectedIndexChanged += new System.EventHandler(this.LineStyleSelector_SelectedIndexChanged);
            // 
            // ColorPreviewBox
            // 
            this.ColorPreviewBox.Enabled = false;
            this.ColorPreviewBox.Location = new System.Drawing.Point(230, 40);
            this.ColorPreviewBox.Name = "ColorPreviewBox";
            this.ColorPreviewBox.ReadOnly = true;
            this.ColorPreviewBox.Size = new System.Drawing.Size(104, 20);
            this.ColorPreviewBox.TabIndex = 5;
            // 
            // ColorSelectButton
            // 
            this.ColorSelectButton.Location = new System.Drawing.Point(74, 40);
            this.ColorSelectButton.Name = "ColorSelectButton";
            this.ColorSelectButton.Size = new System.Drawing.Size(150, 20);
            this.ColorSelectButton.TabIndex = 6;
            this.ColorSelectButton.Text = "Select New";
            this.ColorSelectButton.UseVisualStyleBackColor = true;
            this.ColorSelectButton.Click += new System.EventHandler(this.ColorSelectButton_Click);
            // 
            // ColorPicker
            // 
            this.ColorPicker.AnyColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(178, 93);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(259, 93);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Line Width:";
            // 
            // LineWidthSelector
            // 
            this.LineWidthSelector.Location = new System.Drawing.Point(74, 94);
            this.LineWidthSelector.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.LineWidthSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LineWidthSelector.Name = "LineWidthSelector";
            this.LineWidthSelector.Size = new System.Drawing.Size(91, 20);
            this.LineWidthSelector.TabIndex = 10;
            this.LineWidthSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LineWidthSelector.ValueChanged += new System.EventHandler(this.LineWidthSelector_ValueChanged);
            // 
            // ErrorToolTip
            // 
            this.ErrorToolTip.ForeColor = System.Drawing.Color.Crimson;
            this.ErrorToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            // 
            // FunctionInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 128);
            this.Controls.Add(this.LineWidthSelector);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ColorSelectButton);
            this.Controls.Add(this.ColorPreviewBox);
            this.Controls.Add(this.LineStyleSelector);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FunctionInputBox);
            this.Name = "FunctionInputForm";
            this.Text = "Galc - Function";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FunctionInputForm_FormClosed);
            this.Load += new System.EventHandler(this.FunctionInputForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LineWidthSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FunctionInputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox LineStyleSelector;
        private System.Windows.Forms.TextBox ColorPreviewBox;
        private System.Windows.Forms.Button ColorSelectButton;
        private System.Windows.Forms.ColorDialog ColorPicker;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown LineWidthSelector;
        private System.Windows.Forms.ToolTip ErrorToolTip;
    }
}