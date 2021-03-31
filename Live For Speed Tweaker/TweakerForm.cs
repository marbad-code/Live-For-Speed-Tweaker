using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Live_For_Speed_Tweaker
{
    public partial class TweakerForm : Form
    {
        public TweakerForm()
        {
            InitializeComponent();
        }

        private void steerLockCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (steerLockCheck.Checked)
            {
                steerLockTrackBar.Enabled = true;
                steerLockPointNum.Enabled = true;
            }
            else
            {
                steerLockTrackBar.Enabled = false;
                steerLockPointNum.Enabled = false;
            }
        }

        private void steerLockTrackBar_Scroll(object sender, EventArgs e)
        {
            steerLockPointNum.Value = steerLockTrackBar.Value;
        }

        private void TweakerForm_Shown(object sender, EventArgs e)
        {
            steerLockPointNum.Value = steerLockTrackBar.Value;
        }
    }
}
