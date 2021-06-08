using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ImageList;

namespace TiZip
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            this.toolStrip1.ImageList = this.imageList1;
            this.toolStripDownButton.ImageIndex = 0;
            this.toolStripUpButton.ImageIndex = 1;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
