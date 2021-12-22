namespace Windows_Contact_Tracing_Records_Viewer
{
    partial class WindowsContactTracingRecordsViewer
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
            this.Data = new System.Windows.Forms.RichTextBox();
            this.BtnCheckRecord = new System.Windows.Forms.Button();
            this.BtnClearData = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.Container = new System.Windows.Forms.GroupBox();
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.BackColor = System.Drawing.Color.PaleGreen;
            this.Data.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Data.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.Location = new System.Drawing.Point(12, 145);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(627, 305);
            this.Data.TabIndex = 0;
            this.Data.Text = "";
            // 
            // BtnCheckRecord
            // 
            this.BtnCheckRecord.Location = new System.Drawing.Point(62, 470);
            this.BtnCheckRecord.Name = "BtnCheckRecord";
            this.BtnCheckRecord.Size = new System.Drawing.Size(208, 43);
            this.BtnCheckRecord.TabIndex = 1;
            this.BtnCheckRecord.Text = "Check Record";
            this.BtnCheckRecord.UseVisualStyleBackColor = true;
            this.BtnCheckRecord.Click += new System.EventHandler(this.BtnCheckRecord_Click);
            // 
            // BtnClearData
            // 
            this.BtnClearData.Location = new System.Drawing.Point(327, 470);
            this.BtnClearData.Name = "BtnClearData";
            this.BtnClearData.Size = new System.Drawing.Size(107, 43);
            this.BtnClearData.TabIndex = 2;
            this.BtnClearData.Text = "Clear Data";
            this.BtnClearData.UseVisualStyleBackColor = true;
            this.BtnClearData.Click += new System.EventHandler(this.BtnClearData_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(480, 470);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(107, 43);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.PaleGreen;
            this.Container.Controls.Add(this.LogoBox);
            this.Container.Controls.Add(this.label1);
            this.Container.Controls.Add(this.Title);
            this.Container.Location = new System.Drawing.Point(12, 12);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(627, 100);
            this.Container.TabIndex = 4;
            this.Container.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(98, 21);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(340, 29);
            this.Title.TabIndex = 0;
            this.Title.Text = "Windows Contact Tracing";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = " Records Viewer";
            // 
            // LogoBox
            // 
            this.LogoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogoBox.Image = global::Windows_Contact_Tracing_Records_Viewer.Properties.Resources.unnamed;
            this.LogoBox.Location = new System.Drawing.Point(489, 3);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(132, 97);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoBox.TabIndex = 5;
            this.LogoBox.TabStop = false;
            this.LogoBox.WaitOnLoad = true;
            // 
            // WindowsContactTracingRecordsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(651, 526);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClearData);
            this.Controls.Add(this.BtnCheckRecord);
            this.Controls.Add(this.Data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WindowsContactTracingRecordsViewer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Contact Tracing Records Viewer";
            this.Container.ResumeLayout(false);
            this.Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Data;
        private System.Windows.Forms.Button BtnCheckRecord;
        private System.Windows.Forms.Button BtnClearData;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox Container;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox LogoBox;
    }
}

