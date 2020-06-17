namespace Galc {
    partial class MainOutputForm {
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

                _bufferedGraphics.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.AddFunctionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddFunctionButton
            // 
            this.AddFunctionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFunctionButton.Location = new System.Drawing.Point(524, 406);
            this.AddFunctionButton.Name = "AddFunctionButton";
            this.AddFunctionButton.Size = new System.Drawing.Size(88, 23);
            this.AddFunctionButton.TabIndex = 0;
            this.AddFunctionButton.Text = "Add Function";
            this.AddFunctionButton.UseVisualStyleBackColor = true;
            this.AddFunctionButton.Click += new System.EventHandler(this.AddFunctionButton_Click);
            // 
            // MainOutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.AddFunctionButton);
            this.DoubleBuffered = true;
            this.Name = "MainOutputForm";
            this.Text = "Galc - Main Sketching Window";
            this.ClientSizeChanged += new System.EventHandler(this.MainOutputForm_ClientSizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainOutputForm_Paint);
            this.MouseEnter += new System.EventHandler(this.MainOutputForm_MouseEnter);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainOutputForm_MouseMove);
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.MainOutputForm_MouseWheel);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddFunctionButton;
    }
}