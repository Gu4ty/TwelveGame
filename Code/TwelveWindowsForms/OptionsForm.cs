using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twelve.GameEngine;

namespace TwelveWindowsForms
{
    public partial class frmOptions : Form
    {
        public int height;
        public int width;
        public GameMode mode;
        public bool start;

        public frmOptions()
        {
            mode = new GameMode();
            start = false;
            InitializeComponent();
            
        }

        private void rbtnNormal_Click(object sender, EventArgs e)
        {
            mode = GameMode.Normal;
        }

        private void rbtnAggressive_Click(object sender, EventArgs e)
        {
            mode= GameMode.Aggressive;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            start = true;
            width = (int)nupWidth.Value;
            height = (int)nupHeight.Value;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            start = false;
            this.Close();
        }
    }
}
