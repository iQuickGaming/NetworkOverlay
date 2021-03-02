using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NetworkOverlay
{
    public partial class NetworkIndicator : Form
    {

        private byte _alpha = 200;

        private enum GetWindowLong
        {
            GWL_EXSTYLE = -20
        }

        private enum ExtendedWindowStyles
        {
            WS_EX_TRANSPARENT = 0x20,
            WS_EX_LAYERED = 0x80000
        }

        private enum LayeredWindowAttributes
        {
            LWA_COLORKEY = 0x1,
            LWA_ALPHA = 0x2
        }

        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        private static extern int User32_GetWindowLong(IntPtr hWnd, GetWindowLong nIndex);

        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        private static extern int User32_SetWindowLong(IntPtr hWnd, GetWindowLong nIndex, int dwNewLong);

        [DllImport("user32.dll", EntryPoint = "SetLayeredWindowAttributes")]
        private static extern bool User32_SetLayeredWindowAttributes(IntPtr hWnd, int crKey, byte bAlpha, LayeredWindowAttributes dwFlags);
        public NetworkIndicator()
        {
            InitializeComponent();
            StatsRefresh.Tick += StatsRefresh_Tick;
            int wl = User32_GetWindowLong(this.Handle, GetWindowLong.GWL_EXSTYLE);

            User32_SetWindowLong(this.Handle, GetWindowLong.GWL_EXSTYLE, wl | (int)ExtendedWindowStyles.WS_EX_LAYERED | (int)ExtendedWindowStyles.WS_EX_TRANSPARENT);


            User32_SetLayeredWindowAttributes(this.Handle, (TransparencyKey.B << 16) + (TransparencyKey.G << 8) + TransparencyKey.R, _alpha, LayeredWindowAttributes.LWA_COLORKEY | LayeredWindowAttributes.LWA_ALPHA);
        }

        bool drag = false;
        Point start_point = new Point(0, 0);

        private void dragpanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void dragpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void dragpanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        long bytesSent = 0, bytesReceived = 0;

        internal void StatsRefresh_Tick(object sender, EventArgs e)
        {

            if (!NetworkInterface.GetIsNetworkAvailable())
                return;

            NetworkInterface[] interfaces
            = NetworkInterface.GetAllNetworkInterfaces();

            var selectedInterfaces = interfaces.Where(i => i.NetworkInterfaceType == NetworkInterfaceType.Ethernet);
            var currentBytesSent = selectedInterfaces.Sum(i => i.GetIPv4Statistics().BytesSent);
            var currentBytesReceived = selectedInterfaces.Sum(i => i.GetIPv4Statistics().BytesReceived);

            uploadvalue.Text = ((currentBytesSent - bytesSent) / 1_048_576D).ToString("0.##") + "MB/s";
            downloadvalue.Text = ((currentBytesReceived - bytesReceived) / 1_048_576D).ToString("0.##") + "MB/s";

            bytesSent = currentBytesSent;
            bytesReceived = currentBytesReceived;

        }
    }
}
