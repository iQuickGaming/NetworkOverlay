
namespace NetworkOverlay
{
    partial class NetworkIndicator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetworkIndicator));
            this.downloadlabel = new System.Windows.Forms.Label();
            this.uploadlabel = new System.Windows.Forms.Label();
            this.uploadvalue = new System.Windows.Forms.Label();
            this.downloadvalue = new System.Windows.Forms.Label();
            this.StatsRefresh = new System.Windows.Forms.Timer(this.components);
            this.dragpanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // downloadlabel
            // 
            this.downloadlabel.AutoSize = true;
            this.downloadlabel.BackColor = System.Drawing.Color.Transparent;
            this.downloadlabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.downloadlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadlabel.ForeColor = System.Drawing.Color.White;
            this.downloadlabel.Location = new System.Drawing.Point(7, 4);
            this.downloadlabel.Margin = new System.Windows.Forms.Padding(0);
            this.downloadlabel.Name = "downloadlabel";
            this.downloadlabel.Size = new System.Drawing.Size(74, 16);
            this.downloadlabel.TabIndex = 0;
            this.downloadlabel.Text = "Incoming:";
            // 
            // uploadlabel
            // 
            this.uploadlabel.AutoSize = true;
            this.uploadlabel.BackColor = System.Drawing.Color.Transparent;
            this.uploadlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadlabel.ForeColor = System.Drawing.Color.White;
            this.uploadlabel.Location = new System.Drawing.Point(7, 20);
            this.uploadlabel.Margin = new System.Windows.Forms.Padding(0);
            this.uploadlabel.Name = "uploadlabel";
            this.uploadlabel.Size = new System.Drawing.Size(74, 16);
            this.uploadlabel.TabIndex = 1;
            this.uploadlabel.Text = "Outgoing:";
            // 
            // uploadvalue
            // 
            this.uploadvalue.AutoSize = true;
            this.uploadvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadvalue.ForeColor = System.Drawing.Color.White;
            this.uploadvalue.Location = new System.Drawing.Point(80, 21);
            this.uploadvalue.Margin = new System.Windows.Forms.Padding(0);
            this.uploadvalue.Name = "uploadvalue";
            this.uploadvalue.Size = new System.Drawing.Size(66, 16);
            this.uploadvalue.TabIndex = 4;
            this.uploadvalue.Text = "0.00 MB/s";
            // 
            // downloadvalue
            // 
            this.downloadvalue.AutoSize = true;
            this.downloadvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadvalue.ForeColor = System.Drawing.Color.White;
            this.downloadvalue.Location = new System.Drawing.Point(79, 5);
            this.downloadvalue.Margin = new System.Windows.Forms.Padding(0);
            this.downloadvalue.Name = "downloadvalue";
            this.downloadvalue.Size = new System.Drawing.Size(66, 16);
            this.downloadvalue.TabIndex = 5;
            this.downloadvalue.Text = "0.00 MB/s";
            // 
            // StatsRefresh
            // 
            this.StatsRefresh.Enabled = true;
            this.StatsRefresh.Interval = 1000;
            // 
            // dragpanel
            // 
            this.dragpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(107)))), ((int)(((byte)(238)))));
            this.dragpanel.Location = new System.Drawing.Point(-1, 0);
            this.dragpanel.Name = "dragpanel";
            this.dragpanel.Size = new System.Drawing.Size(5, 40);
            this.dragpanel.TabIndex = 2;
            this.dragpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragpanel_MouseDown);
            this.dragpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragpanel_MouseMove);
            this.dragpanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dragpanel_MouseUp);
            // 
            // NetworkIndicator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(160, 40);
            this.Controls.Add(this.downloadvalue);
            this.Controls.Add(this.uploadvalue);
            this.Controls.Add(this.dragpanel);
            this.Controls.Add(this.uploadlabel);
            this.Controls.Add(this.downloadlabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NetworkIndicator";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetworkIndicator";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Timer StatsRefresh;
        public System.Windows.Forms.Panel dragpanel;
        internal System.Windows.Forms.Label downloadlabel;
        internal System.Windows.Forms.Label uploadlabel;
        internal System.Windows.Forms.Label uploadvalue;
        internal System.Windows.Forms.Label downloadvalue;
    }
}