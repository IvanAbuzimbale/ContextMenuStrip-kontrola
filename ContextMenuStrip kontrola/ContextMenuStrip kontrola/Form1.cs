using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextMenuStrip_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lijevoDesnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBoxDesno.Text = TextBoxLijevo.Text;
        }

        private void desnoLijevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBoxLijevo.Text = TextBoxDesno.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
