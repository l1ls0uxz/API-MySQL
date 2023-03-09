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
            this.txtID = new System.Windows.Forms.TextBox();
            this.ckbReport = new System.Windows.Forms.CheckBox();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.btnGet = new System.Windows.Forms.Button();
            this.dtView = new System.Windows.Forms.DataGridView();
            this.grbButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtView)).BeginInit();
            this.SuspendLayout();
            // 
            // grbButton
            // 
            this.grbButton.Controls.Add(this.txtID);
            this.grbButton.Controls.Add(this.ckbReport);
            this.grbButton.Controls.Add(this.dateTo);
            this.grbButton.Controls.Add(this.dateFrom);
            this.grbButton.Controls.Add(this.btnGet);
            this.grbButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbButton.Location = new System.Drawing.Point(12, 462);
            this.grbButton.Name = "grbButton";
            this.grbButton.Size = new System.Drawing.Size(960, 90);
            this.grbButton.TabIndex = 0;
            this.grbButton.TabStop = false;
            this.grbButton.Text = "Group";
            this.grbButton.Enter += new System.EventHandler(this.grbButton_Enter);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(700, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 21);
            this.txtID.TabIndex = 4;
            // 
            // ckbReport
            // 
            this.ckbReport.AutoSize = true;
            this.ckbReport.Location = new System.Drawing.Point(25, 37);
            this.ckbReport.Name = "ckbReport";
            this.ckbReport.Size = new System.Drawing.Size(63, 19);
            this.ckbReport.TabIndex = 3;
            this.ckbReport.Text = "Report";
            this.ckbReport.UseVisualStyleBackColor = true;
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(439, 37);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(210, 21);
            this.dateTo.TabIndex = 2;
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(182, 37);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(210, 21);
            this.dateFrom.TabIndex = 1;
            // 
            // btnGet
            // 
            this.btnGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Location = new System.Drawing.Point(869, 24);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(80, 50);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // dtView
            // 
            this.dtView.AllowUserToAddRows = false;
            this.dtView.AllowUserToDeleteRows = false;
            this.dtView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtView.Location = new System.Drawing.Point(12, 12);
            this.dtView.Name = "dtView";
            this.dtView.ReadOnly = true;
            this.dtView.Size = new System.Drawing.Size(960, 444);
            this.dtView.TabIndex = 1;
            // 
            // ApiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dtView);
            this.Controls.Add(this.grbButton);
            this.Name = "ApiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "API Form";
            this.Load += new System.EventHandler(this.ApiForm_Load);
            this.grbButton.ResumeLayout(false);
            this.grbButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbButton;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.CheckBox ckbReport;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DataGridView dtView;
        private System.Windows.Forms.TextBox txtID;
    }
}

