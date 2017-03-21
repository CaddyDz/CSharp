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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }
        
        private void panel1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
        }

        private void test_Load(object sender, EventArgs e)
        {

            label1.Draggable(true);
            
        }

        private void label1_Move(object sender, EventArgs e)
        {
        }
    }
}
