using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwelveWindowsForms
{
    public partial class PlayerName : Form
    {
       public  string name;
        public PlayerName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlayerName_FormClosing(object sender, FormClosingEventArgs e)
        {
            name = txtboxName.Text;
            if (name == "")
                name = "NoName";
        }
    }
}
