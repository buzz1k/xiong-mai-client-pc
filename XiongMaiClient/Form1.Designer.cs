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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deviceList1
            // 
            this.deviceList1.Location = new System.Drawing.Point(720, 12);
            this.deviceList1.Name = "deviceList1";
            this.deviceList1.Size = new System.Drawing.Size(202, 436);
            this.deviceList1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(720, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Устройства";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 636);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deviceList1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Controlls.DeviceList deviceList1;
        private System.Windows.Forms.Button button1;
    }
}
