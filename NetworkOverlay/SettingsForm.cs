using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NetworkOverlay
{
    public partial class NetworkOverlay : Form
    {

       internal Form NetworkIndicator = new NetworkIndicator();
       internal Form Credits = new Credits();

        [DllImport("Gdi32.dll")]
        internal static extern IntPtr CreateRoundRectRgn ( int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse );

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
            NetworkIndicator.Opacity = Properties.Settings.Default.networkindicatoropacity;
            clickthroughtoggle.Checked = Properties.Settings.Default.clickthroughindicator;
            bootlaunchtoggle.Checked = Properties.Settings.Default.launchonboot;
            opacitybox.Text = Properties.Settings.Default.networkindicatoropacity.ToString();
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

        private void setopacity_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.networkindicatoropacity = double.Parse(opacitybox.Text.ToString());
            Properties.Settings.Default.Save();
            NetworkIndicator.Opacity = double.Parse(opacitybox.Text.ToString());
            MessageBox.Show("To change this property a restart is required","Restart Required");
        }

        private void clickthroughtoggle_CheckedChanged(object sender, EventArgs e)
        {
            if (clickthroughtoggle.Checked == false)
                Properties.Settings.Default.clickthroughindicator = false;
            else
                Properties.Settings.Default.clickthroughindicator = true;
            Properties.Settings.Default.Save();
        }

        private void bootlaunchtoggle_CheckedChanged(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey startonbootkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (bootlaunchtoggle.Checked == false)
            {
                Properties.Settings.Default.launchonboot = false;
                Properties.Settings.Default.Save();
                startonbootkey.DeleteValue("NetworkOverlay", false);
            }
            else
            {
                Properties.Settings.Default.launchonboot = true;
                Properties.Settings.Default.Save();
                startonbootkey.SetValue("NetworkOverlay", Application.ExecutablePath.ToString());
            }
        }

        private void setbackcolor_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.networkindicatorbackcolor = ColorTranslator.FromHtml(backcolorbox.Text);
            Properties.Settings.Default.Save();
            NetworkIndicator.BackColor = ColorTranslator.FromHtml(backcolorbox.Text);
        }

        private void setcolor_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.networkindicatorlabelcolor = ColorTranslator.FromHtml(colorbox.Text);
            Properties.Settings.Default.Save();
        }

        private void SystemTrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void hidebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void creditslabel_Click(object sender, EventArgs e)
        {
            Credits.Show();
        }
    }
}
