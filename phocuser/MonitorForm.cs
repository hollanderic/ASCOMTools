using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace ASCOM.phocuser
{

    public partial class MonitorForm : Form
    {
        internal Focuser f;
        internal System.Timers.Timer statTimer;

        public MonitorForm(Focuser F)
        {
            InitializeComponent();
            f = F;
            Position.Text = f.Position.ToString();
            statTimer = new System.Timers.Timer(500);
            statTimer.Elapsed += OnStatTimer;
            statTimer.AutoReset = true;
            statTimer.Enabled = true;
        }

        private void OnStatTimer(Object source, ElapsedEventArgs e)
        {
            Position.Text = f.Position.ToString();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
