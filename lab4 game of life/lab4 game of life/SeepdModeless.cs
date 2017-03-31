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
    public partial class SpeedModeless : Form
    {
        public delegate void DelVoidInt(int i);
        public DelVoidInt _dGetSpeed;
        public SpeedModeless()
        {
            InitializeComponent();
        }

        private void SpeedModeless_Load(object sender, EventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (_dGetSpeed!=null)
            {
                _dGetSpeed.Invoke(trackBar1.Value);
            }

        }

        private void SpeedModeless_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
