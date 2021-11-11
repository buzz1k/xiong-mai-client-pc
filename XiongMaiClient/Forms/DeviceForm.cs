using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XiongMaiClient.Forms
{
    public partial class DeviceForm : Form
    {
        public static List<DeviceGroup> deviceGroup = new List<DeviceGroup>();


        public static void AddGroupToList()
        { 
            
        }

        public DeviceForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddGroupForm addGroupForm = new();
            addGroupForm.Show();
        }

        private void DeviceForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
