namespace FormApi4._7
{
    partial class ApiForm
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
            this.grbButton = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grbButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbButton
            // 
            this.grbButton.Controls.Add(this.button1);
            this.grbButton.Location = new System.Drawing.Point(12, 399);
            this.grbButton.Name = "grbButton";
            this.grbButton.Size = new System.Drawing.Size(960, 100);
            this.grbButton.TabIndex = 0;
            this.grbButton.TabStop = false;
            this.grbButton.Text = "Button";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(874, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ApiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.grbButton);
            this.Name = "ApiForm";
            this.Text = "API Form";
            this.grbButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbButton;
        private System.Windows.Forms.Button button1;
    }
}

