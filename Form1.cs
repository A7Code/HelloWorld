using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloWorld
{
    public partial class Form1 : Form
    {
        a7HTML _centerMaster = new a7HTML();
        public Form1()
        {
            InitializeComponent();
            Message.setForm(this.richTextBox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_centerMaster.setURL(textBox1.Text))
                richTextBox1.Text = _centerMaster.show();
        }
    }
}
