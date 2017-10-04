using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Task1FormAndPanel : Form
    {
        public Task1FormAndPanel()
        {
            InitializeComponent();
        }
       

        private void Panel_Click(object sender, EventArgs e)
        {
            if (Control.ModifierKeys  == Keys.Control) // если нажата клавиша ctrl
            {
                Close();
            }
            MessageBox.Show("Внутри прямоугольника");
        }

        private void Task1FormAndPanel_Click(object sender, EventArgs e)
        {
            if (Control.ModifierKeys  == Keys.Control) // если нажата клавиша ctrl
            {
                Close();
            }
            MessageBox.Show("Снаружи прямоугольника");
        }
    }
}
