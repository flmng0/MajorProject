namespace Galc {
    partial class PreferencesForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.GridXInput = new System.Windows.Forms.TextBox();
            this.GridYInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MinXInput = new System.Windows.Forms.TextBox();
            this.MaxXInput = new System.Windows.Forms.TextBox();
            this.MinYInput = new System.Windows.Forms.TextBox();
            this.MaxYInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grid Step (x axis):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Grid Step (y axis):";
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(188, 177);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(107, 177);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // GridXInput
            // 
            this.GridXInput.Location = new System.Drawing.Point(108, 12);
            this.GridXInput.Name = "GridXInput";
            this.GridXInput.Size = new System.Drawing.Size(155, 20);
            this.GridXInput.TabIndex = 6;
            // 
            // GridYInput
            // 
            this.GridYInput.Location = new System.Drawing.Point(108, 38);
            this.GridYInput.Name = "GridYInput";
            this.GridYInput.Size = new System.Drawing.Size(155, 20);
            this.GridYInput.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "X Axis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Y Axis:";
            // 
            // MinXInput
            // 
            this.MinXInput.Location = new System.Drawing.Point(59, 99);
            this.MinXInput.Name = "MinXInput";
            this.MinXInput.Size = new System.Drawing.Size(100, 20);
            this.MinXInput.TabIndex = 10;
            // 
            // MaxXInput
            // 
            this.MaxXInput.Location = new System.Drawing.Point(166, 99);
            this.MaxXInput.Name = "MaxXInput";
            this.MaxXInput.Size = new System.Drawing.Size(100, 20);
            this.MaxXInput.TabIndex = 11;
            // 
            // MinYInput
            // 
            this.MinYInput.Location = new System.Drawing.Point(59, 126);
            this.MinYInput.Name = "MinYInput";
            this.MinYInput.Size = new System.Drawing.Size(100, 20);
            this.MinYInput.TabIndex = 12;
            // 
            // MaxYInput
            // 
            this.MaxYInput.Location = new System.Drawing.Point(166, 126);
            this.MaxYInput.Name = "MaxYInput";
            this.MaxYInput.Size = new System.Drawing.Size(100, 20);
            this.MaxYInput.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Minimum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Maximum";
            // 
            // PreferencesForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 212);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MaxYInput);
            this.Controls.Add(this.MinYInput);
            this.Controls.Add(this.MaxXInput);
            this.Controls.Add(this.MinXInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GridYInput);
            this.Controls.Add(this.GridXInput);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreferencesForm";
            this.Text = "PreferencesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox GridXInput;
        private System.Windows.Forms.TextBox GridYInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MinXInput;
        private System.Windows.Forms.TextBox MaxXInput;
        private System.Windows.Forms.TextBox MinYInput;
        private System.Windows.Forms.TextBox MaxYInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}