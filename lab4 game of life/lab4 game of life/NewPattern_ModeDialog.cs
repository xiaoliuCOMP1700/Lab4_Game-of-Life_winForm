using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_game_of_life
{
    public partial class NewPattern_ModeDialog : Form
    {

        public Color _color;
        public int _cellNumber;
        public NewPattern_ModeDialog()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void rbt_Red_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_Red.Checked)
            {
                _color = Color.Red;
            }

        }

        private void rbt_Green_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_Green.Checked)
            {
                _color = Color.Green;
            }
        }

        private void rbt_Grey_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_Grey.Checked)
            {
                _color = Color.Gray;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _cellNumber = trackBar1.Value;
        }
    }
}
