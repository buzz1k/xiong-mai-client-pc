namespace XiongMaiClient.Forms
{
    partial class DeviceForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Список устройств");
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.deviceList = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить группу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавить устройство";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // deviceList
            // 
            this.deviceList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deviceList.Location = new System.Drawing.Point(12, 55);
            this.deviceList.Name = "deviceList";
            treeNode1.Name = "Узел0";
            treeNode1.Text = "Список устройств";
            this.deviceList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.deviceList.Size = new System.Drawing.Size(553, 357);
            this.deviceList.TabIndex = 2;
            // 
            // DeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 424);
            this.Controls.Add(this.deviceList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "DeviceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Устройства";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeviceForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TreeView deviceList;
    }
}