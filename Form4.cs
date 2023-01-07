using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XanaduUniverse
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NN nn = new NN();
            nn.writecode();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NN nn = new NN();
            nn.socialize();
        }
    }
}
