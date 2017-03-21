using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FlaskForm
{
    public partial class init : Form
    {
        public init()
        {
            InitializeComponent();
        }

        private void init_Load(object sender, EventArgs e)
        {
            string docsDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Directory.CreateDirectory(docsDir + "\test");
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            projectTemplates pt = new projectTemplates();
            pt.ShowDialog();
        }
    }
}
