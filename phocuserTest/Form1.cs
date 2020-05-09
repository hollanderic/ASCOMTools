using System;
using System.Windows.Forms;

namespace ASCOM.phocuser
{
    public partial class Form1 : Form
    {

        private ASCOM.DriverAccess.Focuser driver;

        public Form1()
        {
            InitializeComponent();
            SetUIState();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsConnected)
                driver.Connected = false;

            Properties.Settings.Default.Save();
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DriverId = ASCOM.DriverAccess.Focuser.Choose(Properties.Settings.Default.DriverId);
            SetUIState();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (IsConnected)
            {
                driver.Connected = false;
            }
            else
            {
                driver = new ASCOM.DriverAccess.Focuser(Properties.Settings.Default.DriverId);
                driver.Connected = true;
            }
            SetUIState();
        }

        private void SetUIState()
        {
            buttonConnect.Enabled = !string.IsNullOrEmpty(Properties.Settings.Default.DriverId);
            buttonChoose.Enabled = !IsConnected;
            buttonConnect.Text = IsConnected ? "Disconnect" : "Connect";
        }

        private bool IsConnected
        {
            get
            {
                return ((this.driver != null) && (driver.Connected == true));
            }
        }

        private void Position_Click(object sender, EventArgs e)
        {
            if (IsConnected) {
                int pos = driver.Position;
                DebugOut.Items.Add("Focuser at position "+ pos.ToString());
            } else
            {
                DebugOut.Items.Add("Focuser is NOT connected");
            }
        }

        private void SetPosition_Click(object sender, EventArgs e)
        {
            if (IsConnected)
            {
                driver.Move(decimal.ToInt32(PositionBox.Value));
                DebugOut.Items.Add("Focuser at position " + driver.Position.ToString());
            } else
            {
                DebugOut.Items.Add("Focuser is NOT connected");
            }
        }
    }
}
