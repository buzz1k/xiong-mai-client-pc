namespace XiongMaiClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deviceList1 = new XiongMaiClient.Controlls.DeviceList();
            this.showManageDeviceForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deviceList1
            // 
            this.deviceList1.Location = new System.Drawing.Point(720, 12);
            this.deviceList1.Name = "deviceList1";
            this.deviceList1.Size = new System.Drawing.Size(202, 436);
            this.deviceList1.TabIndex = 0;
            // 
            // showManageDeviceForm
            // 
            this.showManageDeviceForm.Location = new System.Drawing.Point(720, 454);
            this.showManageDeviceForm.Name = "showManageDeviceForm";
            this.showManageDeviceForm.Size = new System.Drawing.Size(202, 35);
            this.showManageDeviceForm.TabIndex = 1;
            this.showManageDeviceForm.Text = "Устройства";
            this.showManageDeviceForm.UseVisualStyleBackColor = true;
            this.showManageDeviceForm.Click += new System.EventHandler(this.showManageDeviceForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 636);
            this.Controls.Add(this.showManageDeviceForm);
            this.Controls.Add(this.deviceList1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Controlls.DeviceList deviceList1;
        private System.Windows.Forms.Button showManageDeviceForm;
    }
}
