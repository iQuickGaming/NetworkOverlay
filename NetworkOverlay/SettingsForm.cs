using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkOverlay
{
    public partial class NetworkOverlay : Form
    {

       internal Form NetworkIndicator = new NetworkIndicator();

        [DllImport("Gdi32.dll")]
        internal static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect,     // x-coordinate of upper-left corner
    int nTopRect,      // y-coordinate of upper-left corner
    int nRightRect,    // x-coordinate of lower-right corner
    int nBottomRect,   // y-coordinate of lower-right corner
    int nWidthEllipse, // height of ellipse
    int nHeightEllipse // width of ellipse
);


        public NetworkOverlay()
        {
            InitializeComponent();
            NetworkIndicator.Show();
            close.Click += close_Click;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            coordX.Text = Properties.Settings.Default.networkindicatorX.ToString();
            coordY.Text = Properties.Settings.Default.networkindicatorY.ToString();
            NetworkIndicator.Location = new Point(Properties.Settings.Default.networkindicatorX, Properties.Settings.Default.networkindicatorY);
            showdragpaneltoggle.Checked = Properties.Settings.Default.showdragpanel;
            SystemTrayIcon.Visible = true;
        }


        bool drag = false;
        Point start_point = new Point(0, 0);

        private void maindragpanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void maindragpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void maindragpanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void setpos_Click(object sender, EventArgs e)
        {
            if (coordX.TextLength == 0 || coordY.TextLength == 0)
            {
                return;
            }

            Properties.Settings.Default.networkindicatorX = int.Parse(coordX.Text);
            Properties.Settings.Default.networkindicatorY = int.Parse(coordY.Text);
            Properties.Settings.Default.Save();
            NetworkIndicator.Location = new Point(Properties.Settings.Default.networkindicatorX, Properties.Settings.Default.networkindicatorY);
        }

        private void shownetworkindicatortoggle_CheckedChanged(object sender, EventArgs e)
        {
            if (shownetworkindicatortoggle.Checked == false)
                NetworkIndicator.Hide();
            else
                NetworkIndicator.Show();
        }

        private void showdragpaneltoggle_CheckedChanged(object sender, EventArgs e)
        {
            if (showdragpaneltoggle.Checked == false)
                Properties.Settings.Default.showdragpanel = false;
            else
                Properties.Settings.Default.showdragpanel = true;
            Properties.Settings.Default.Save();
        }
    }
}
