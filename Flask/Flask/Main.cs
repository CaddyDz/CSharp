using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flask.FrontEnd.HTML;
using System.IO;

namespace Flask
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void HelloWorldBtn_Click(object sender, EventArgs e)
        {
            HTML_Writer HW = new HTML_Writer();
            HW.Create("wow");
        }
    }
}
