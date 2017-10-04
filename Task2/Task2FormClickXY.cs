using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Task2FormClickXY : Form
    {
        public Task2FormClickXY()
        {
            InitializeComponent();
        }

        private void FormXY_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Ширина ={ClientSize.Width}, Высота={ClientSize.Height}");
        }
    }
}
