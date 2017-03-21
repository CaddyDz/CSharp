using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlaskForm
{
    public partial class projectTemplates : Form
    {
        public projectTemplates()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "sampleProject" + 1;
            string projectName = textBox1.Text;
        }
    }
}
