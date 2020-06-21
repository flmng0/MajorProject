namespace Galc {
    partial class ProjectSelectForm {
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
            this.ProjectLabel = new System.Windows.Forms.Label();
            this.SketchLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.ProjectCombo = new System.Windows.Forms.ComboBox();
            this.SketchCombo = new System.Windows.Forms.ComboBox();
            this.ScratchCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ProjectLabel
            // 
            this.ProjectLabel.AutoSize = true;
            this.ProjectLabel.Location = new System.Drawing.Point(12, 16);
            this.ProjectLabel.Name = "ProjectLabel";
            this.ProjectLabel.Size = new System.Drawing.Size(40, 13);
            this.ProjectLabel.TabIndex = 0;
            this.ProjectLabel.Text = "&Project";
            // 
            // SketchLabel
            // 
            this.SketchLabel.AutoSize = true;
            this.SketchLabel.Location = new System.Drawing.Point(12, 63);
            this.SketchLabel.Name = "SketchLabel";
            this.SketchLabel.Size = new System.Drawing.Size(72, 13);
            this.SketchLabel.TabIndex = 2;
            this.SketchLabel.Text = "&Sketch Name";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(170, 157);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(89, 157);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ProjectCombo
            // 
            this.ProjectCombo.FormattingEnabled = true;
            this.ProjectCombo.Location = new System.Drawing.Point(15, 32);
            this.ProjectCombo.Name = "ProjectCombo";
            this.ProjectCombo.Size = new System.Drawing.Size(230, 21);
            this.ProjectCombo.TabIndex = 1;
            this.ProjectCombo.SelectedIndexChanged += new System.EventHandler(this.ProjectCombo_SelectedIndexChanged);
            this.ProjectCombo.TextUpdate += new System.EventHandler(this.ProjectCombo_TextUpdate);
            // 
            // SketchCombo
            // 
            this.SketchCombo.Enabled = false;
            this.SketchCombo.FormattingEnabled = true;
            this.SketchCombo.Location = new System.Drawing.Point(15, 79);
            this.SketchCombo.Name = "SketchCombo";
            this.SketchCombo.Size = new System.Drawing.Size(230, 21);
            this.SketchCombo.TabIndex = 3;
            // 
            // ScratchCheck
            // 
            this.ScratchCheck.AutoSize = true;
            this.ScratchCheck.Location = new System.Drawing.Point(15, 119);
            this.ScratchCheck.Name = "ScratchCheck";
            this.ScratchCheck.Size = new System.Drawing.Size(192, 17);
            this.ScratchCheck.TabIndex = 4;
            this.ScratchCheck.Text = "Scratch Pad (Do not link to project)";
            this.ScratchCheck.UseVisualStyleBackColor = true;
            this.ScratchCheck.CheckedChanged += new System.EventHandler(this.ScratchCheck_CheckedChanged);
            // 
            // ProjectSelectForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 192);
            this.Controls.Add(this.ScratchCheck);
            this.Controls.Add(this.SketchCombo);
            this.Controls.Add(this.ProjectCombo);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SketchLabel);
            this.Controls.Add(this.ProjectLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectSelectForm";
            this.ShowIcon = false;
            this.Text = "Galc - Project Select";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProjectLabel;
        private System.Windows.Forms.Label SketchLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.ComboBox ProjectCombo;
        private System.Windows.Forms.ComboBox SketchCombo;
        private System.Windows.Forms.CheckBox ScratchCheck;
    }
}