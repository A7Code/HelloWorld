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
            textBox1.Text = "http://www.1keydata.com/css-tutorial/tw/syntax.php";

            if (_centerMaster.setURL(textBox1.Text))
            {
                richTextBox1.Text = _centerMaster.showA();

                List<string> getLabel = _centerMaster.showB();
                for (int i = 0; i < getLabel.Count; i++)
                    treeView1.Nodes.Add(new TreeNode(getLabel[i]));
            }
        }
    }
}
