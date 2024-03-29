﻿namespace FormApi4._7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApiForm));
            this.grbButton = new System.Windows.Forms.GroupBox();
            this.cbxName = new System.Windows.Forms.ComboBox();
            this.pnReport = new System.Windows.Forms.Panel();
            this.btnGet2 = new System.Windows.Forms.Button();
            this.dateReport = new System.Windows.Forms.DateTimePicker();
            this.cbxTime = new System.Windows.Forms.ComboBox();
            this.ckbReport = new System.Windows.Forms.CheckBox();
            this.pnTime = new System.Windows.Forms.Panel();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.btnGet = new System.Windows.Forms.Button();
            this.dtView = new System.Windows.Forms.RichTextBox();
            this.grbButton.SuspendLayout();
            this.pnReport.SuspendLayout();
            this.pnTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbButton
            // 
            this.grbButton.Controls.Add(this.pnTime);
            this.grbButton.Controls.Add(this.cbxName);
            this.grbButton.Controls.Add(this.pnReport);
            this.grbButton.Controls.Add(this.ckbReport);
            this.grbButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbButton.Location = new System.Drawing.Point(0, 471);
            this.grbButton.Name = "grbButton";
            this.grbButton.Size = new System.Drawing.Size(984, 90);
            this.grbButton.TabIndex = 0;
            this.grbButton.TabStop = false;
            this.grbButton.Enter += new System.EventHandler(this.grbButton_Enter);
            // 
            // cbxName
            // 
            this.cbxName.FormattingEnabled = true;
            this.cbxName.Items.AddRange(new object[] {
            "B04",
            "B05"});
            this.cbxName.Location = new System.Drawing.Point(163, 33);
            this.cbxName.Name = "cbxName";
            this.cbxName.Size = new System.Drawing.Size(121, 23);
            this.cbxName.TabIndex = 6;
            this.cbxName.SelectedIndexChanged += new System.EventHandler(this.cbxName_SelectedIndexChanged);
            // 
            // pnReport
            // 
            this.pnReport.Controls.Add(this.btnGet2);
            this.pnReport.Controls.Add(this.dateReport);
            this.pnReport.Controls.Add(this.cbxTime);
            this.pnReport.Location = new System.Drawing.Point(390, 20);
            this.pnReport.Name = "pnReport";
            this.pnReport.Size = new System.Drawing.Size(559, 57);
            this.pnReport.TabIndex = 9;
            this.pnReport.Visible = false;
            // 
            // btnGet2
            // 
            this.btnGet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet2.Location = new System.Drawing.Point(476, 3);
            this.btnGet2.Name = "btnGet2";
            this.btnGet2.Size = new System.Drawing.Size(80, 49);
            this.btnGet2.TabIndex = 8;
            this.btnGet2.Text = "GET";
            this.btnGet2.UseVisualStyleBackColor = true;
            this.btnGet2.Click += new System.EventHandler(this.btnGet2_Click);
            // 
            // dateReport
            // 
            this.dateReport.CustomFormat = "dd-MM-yyyy";
            this.dateReport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateReport.Location = new System.Drawing.Point(28, 16);
            this.dateReport.Name = "dateReport";
            this.dateReport.Size = new System.Drawing.Size(126, 21);
            this.dateReport.TabIndex = 8;
            // 
            // cbxTime
            // 
            this.cbxTime.FormattingEnabled = true;
            this.cbxTime.Location = new System.Drawing.Point(282, 15);
            this.cbxTime.Name = "cbxTime";
            this.cbxTime.Size = new System.Drawing.Size(121, 23);
            this.cbxTime.TabIndex = 5;
            // 
            // ckbReport
            // 
            this.ckbReport.AutoSize = true;
            this.ckbReport.Location = new System.Drawing.Point(25, 39);
            this.ckbReport.Name = "ckbReport";
            this.ckbReport.Size = new System.Drawing.Size(63, 19);
            this.ckbReport.TabIndex = 3;
            this.ckbReport.Text = "Report";
            this.ckbReport.UseVisualStyleBackColor = true;
            this.ckbReport.CheckedChanged += new System.EventHandler(this.ckbReport_CheckedChanged);
            // 
            // pnTime
            // 
            this.pnTime.Controls.Add(this.dateTo);
            this.pnTime.Controls.Add(this.dateFrom);
            this.pnTime.Controls.Add(this.btnGet);
            this.pnTime.Location = new System.Drawing.Point(390, 20);
            this.pnTime.Name = "pnTime";
            this.pnTime.Size = new System.Drawing.Size(559, 57);
            this.pnTime.TabIndex = 10;
            // 
            // dateTo
            // 
            this.dateTo.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.Location = new System.Drawing.Point(228, 15);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(186, 21);
            this.dateTo.TabIndex = 7;
            this.dateTo.Value = new System.DateTime(2023, 3, 13, 11, 34, 0, 0);
            // 
            // dateFrom
            // 
            this.dateFrom.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(15, 15);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(186, 21);
            this.dateFrom.TabIndex = 2;
            this.dateFrom.Value = new System.DateTime(2023, 3, 13, 11, 34, 0, 0);
            // 
            // btnGet
            // 
            this.btnGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Location = new System.Drawing.Point(476, 3);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(80, 50);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // dtView
            // 
            this.dtView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtView.Location = new System.Drawing.Point(0, 0);
            this.dtView.Name = "dtView";
            this.dtView.Size = new System.Drawing.Size(984, 444);
            this.dtView.TabIndex = 1;
            this.dtView.Text = "";
            // 
            // ApiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dtView);
            this.Controls.Add(this.grbButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HondaPlus VN";
            this.Load += new System.EventHandler(this.ApiForm_Load);
            this.grbButton.ResumeLayout(false);
            this.grbButton.PerformLayout();
            this.pnReport.ResumeLayout(false);
            this.pnTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbButton;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.CheckBox ckbReport;
        private System.Windows.Forms.RichTextBox dtView;
        private System.Windows.Forms.Panel pnTime;
        private System.Windows.Forms.Panel pnReport;
        public System.Windows.Forms.DateTimePicker dateFrom;
        public System.Windows.Forms.DateTimePicker dateTo;
        public System.Windows.Forms.ComboBox cbxName;
        private System.Windows.Forms.Button btnGet2;
        private System.Windows.Forms.ComboBox cbxTime;
        public System.Windows.Forms.DateTimePicker dateReport;
    }
}

