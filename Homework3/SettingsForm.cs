using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3
{
    public partial class SettingsForm : Form
    {
        public SettingsForm(uint precision, uint count)
        {
            InitializeComponent();
            this.Precision = precision;
            this.Count = count;

            numericUpDown1.Value = (int)precision;
            numericUpDown2.Value = (int)count;
        }

        public uint Precision { get; private set; }
        public uint Count { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Precision = (uint)numericUpDown1.Value;
            this.Count = (uint)numericUpDown2.Value;
            DialogResult = DialogResult.OK;
        }
    }
}
