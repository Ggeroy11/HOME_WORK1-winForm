using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Task3FormCoordXY : Form
    {
        public Task3FormCoordXY()
        {
            InitializeComponent();
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            CoordX.Text = e.X.ToString();
            CoordY.Text = e.Y.ToString();
        }
    }
}
