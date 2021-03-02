
namespace NetworkOverlay
{
    partial class NetworkOverlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetworkOverlay));
            this.maindragpanel = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.shownetworkindicatortoggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.shownetworkindicatorlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.showdragpaneltoggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.setcolor = new Guna.UI2.WinForms.Guna2Button();
            this.coordX = new Guna.UI2.WinForms.Guna2TextBox();
            this.coordY = new Guna.UI2.WinForms.Guna2TextBox();
            this.setpos = new Guna.UI2.WinForms.Guna2Button();
            this.makeindicatorclickthroughlabel = new System.Windows.Forms.Label();
            this.clickthroughtoggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.infocontainer = new Guna.UI2.WinForms.Guna2GroupBox();
            this.bootlaunchtoggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.colorsgroupbox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.setopacity = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.opacitylabel = new System.Windows.Forms.Label();
            this.setbackcolor = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SystemTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.maindragpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.infocontainer.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.colorsgroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // maindragpanel
            // 
            this.maindragpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.maindragpanel.Controls.Add(this.minimize);
            this.maindragpanel.Controls.Add(this.close);
            this.maindragpanel.Location = new System.Drawing.Point(-4, -1);
            this.maindragpanel.Name = "maindragpanel";
            this.maindragpanel.Size = new System.Drawing.Size(458, 30);
            this.maindragpanel.TabIndex = 0;
            this.maindragpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.maindragpanel_MouseDown);
            this.maindragpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.maindragpanel_MouseMove);
            this.maindragpanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.maindragpanel_MouseUp);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(388, 3);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(25, 25);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize.TabIndex = 45;
            this.minimize.TabStop = false;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(420, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(25, 25);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 44;
            this.close.TabStop = false;
            // 
            // shownetworkindicatortoggle
            // 
            this.shownetworkindicatortoggle.Animated = true;
            this.shownetworkindicatortoggle.BackColor = System.Drawing.Color.Transparent;
            this.shownetworkindicatortoggle.Checked = true;
            this.shownetworkindicatortoggle.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.shownetworkindicatortoggle.CheckedState.FillColor = System.Drawing.Color.LimeGreen;
            this.shownetworkindicatortoggle.CheckedState.InnerBorderColor = System.Drawing.Color.Black;
            this.shownetworkindicatortoggle.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.shownetworkindicatortoggle.CheckedState.Parent = this.shownetworkindicatortoggle;
            this.shownetworkindicatortoggle.Location = new System.Drawing.Point(144, 72);
            this.shownetworkindicatortoggle.Name = "shownetworkindicatortoggle";
            this.shownetworkindicatortoggle.ShadowDecoration.Parent = this.shownetworkindicatortoggle;
            this.shownetworkindicatortoggle.Size = new System.Drawing.Size(35, 20);
            this.shownetworkindicatortoggle.TabIndex = 1;
            this.shownetworkindicatortoggle.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.shownetworkindicatortoggle.UncheckedState.FillColor = System.Drawing.Color.Red;
            this.shownetworkindicatortoggle.UncheckedState.InnerBorderColor = System.Drawing.Color.Black;
            this.shownetworkindicatortoggle.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.shownetworkindicatortoggle.UncheckedState.Parent = this.shownetworkindicatortoggle;
            this.shownetworkindicatortoggle.UseTransparentBackground = true;
            this.shownetworkindicatortoggle.CheckedChanged += new System.EventHandler(this.shownetworkindicatortoggle_CheckedChanged);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox1.BorderRadius = 6;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(93, 84);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "#";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(60, 20);
            this.guna2TextBox1.TabIndex = 2;
            // 
            // shownetworkindicatorlabel
            // 
            this.shownetworkindicatorlabel.AutoSize = true;
            this.shownetworkindicatorlabel.ForeColor = System.Drawing.Color.White;
            this.shownetworkindicatorlabel.Location = new System.Drawing.Point(13, 76);
            this.shownetworkindicatorlabel.Name = "shownetworkindicatorlabel";
            this.shownetworkindicatorlabel.Size = new System.Drawing.Size(121, 13);
            this.shownetworkindicatorlabel.TabIndex = 3;
            this.shownetworkindicatorlabel.Text = "Show Network Indicator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Color";
            // 
            // showdragpaneltoggle
            // 
            this.showdragpaneltoggle.Animated = true;
            this.showdragpaneltoggle.BackColor = System.Drawing.Color.Transparent;
            this.showdragpaneltoggle.Checked = true;
            this.showdragpaneltoggle.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.showdragpaneltoggle.CheckedState.FillColor = System.Drawing.Color.LimeGreen;
            this.showdragpaneltoggle.CheckedState.InnerBorderColor = System.Drawing.Color.Black;
            this.showdragpaneltoggle.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.showdragpaneltoggle.CheckedState.Parent = this.showdragpaneltoggle;
            this.showdragpaneltoggle.Location = new System.Drawing.Point(144, 98);
            this.showdragpaneltoggle.Name = "showdragpaneltoggle";
            this.showdragpaneltoggle.ShadowDecoration.Parent = this.showdragpaneltoggle;
            this.showdragpaneltoggle.Size = new System.Drawing.Size(35, 20);
            this.showdragpaneltoggle.TabIndex = 6;
            this.showdragpaneltoggle.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.showdragpaneltoggle.UncheckedState.FillColor = System.Drawing.Color.Red;
            this.showdragpaneltoggle.UncheckedState.InnerBorderColor = System.Drawing.Color.Black;
            this.showdragpaneltoggle.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.showdragpaneltoggle.UncheckedState.Parent = this.showdragpaneltoggle;
            this.showdragpaneltoggle.UseTransparentBackground = true;
            this.showdragpaneltoggle.CheckedChanged += new System.EventHandler(this.showdragpaneltoggle_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Show DragPanel";
            // 
            // setcolor
            // 
            this.setcolor.Animated = true;
            this.setcolor.AnimatedGIF = true;
            this.setcolor.BackColor = System.Drawing.Color.Transparent;
            this.setcolor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(115)))), ((int)(((byte)(202)))));
            this.setcolor.BorderRadius = 6;
            this.setcolor.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.setcolor.CheckedState.Parent = this.setcolor;
            this.setcolor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setcolor.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("setcolor.CustomImages.Image")));
            this.setcolor.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.setcolor.CustomImages.ImageOffset = new System.Drawing.Point(0, 3);
            this.setcolor.CustomImages.ImageSize = new System.Drawing.Size(15, 15);
            this.setcolor.CustomImages.Parent = this.setcolor;
            this.setcolor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.setcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setcolor.ForeColor = System.Drawing.Color.Transparent;
            this.setcolor.HoverState.Parent = this.setcolor;
            this.setcolor.Location = new System.Drawing.Point(159, 84);
            this.setcolor.Name = "setcolor";
            this.setcolor.PressedColor = System.Drawing.Color.Aqua;
            this.setcolor.PressedDepth = 255;
            this.setcolor.ShadowDecoration.BorderRadius = 10;
            this.setcolor.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(242)))));
            this.setcolor.ShadowDecoration.Depth = 15;
            this.setcolor.ShadowDecoration.Enabled = true;
            this.setcolor.ShadowDecoration.Parent = this.setcolor;
            this.setcolor.Size = new System.Drawing.Size(38, 20);
            this.setcolor.TabIndex = 21;
            this.setcolor.UseTransparentBackground = true;
            // 
            // coordX
            // 
            this.coordX.Animated = true;
            this.coordX.BorderColor = System.Drawing.Color.Black;
            this.coordX.BorderRadius = 6;
            this.coordX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.coordX.DefaultText = "";
            this.coordX.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.coordX.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.coordX.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.coordX.DisabledState.Parent = this.coordX;
            this.coordX.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.coordX.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.coordX.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.coordX.FocusedState.Parent = this.coordX;
            this.coordX.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.coordX.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.coordX.HoverState.Parent = this.coordX;
            this.coordX.Location = new System.Drawing.Point(8, 31);
            this.coordX.Name = "coordX";
            this.coordX.PasswordChar = '\0';
            this.coordX.PlaceholderText = "X";
            this.coordX.SelectedText = "";
            this.coordX.ShadowDecoration.Parent = this.coordX;
            this.coordX.Size = new System.Drawing.Size(50, 20);
            this.coordX.TabIndex = 22;
            // 
            // coordY
            // 
            this.coordY.Animated = true;
            this.coordY.BorderColor = System.Drawing.Color.Black;
            this.coordY.BorderRadius = 6;
            this.coordY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.coordY.DefaultText = "";
            this.coordY.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.coordY.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.coordY.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.coordY.DisabledState.Parent = this.coordY;
            this.coordY.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.coordY.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.coordY.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.coordY.FocusedState.Parent = this.coordY;
            this.coordY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.coordY.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.coordY.HoverState.Parent = this.coordY;
            this.coordY.Location = new System.Drawing.Point(64, 31);
            this.coordY.Name = "coordY";
            this.coordY.PasswordChar = '\0';
            this.coordY.PlaceholderText = "Y";
            this.coordY.SelectedText = "";
            this.coordY.ShadowDecoration.Parent = this.coordY;
            this.coordY.Size = new System.Drawing.Size(50, 20);
            this.coordY.TabIndex = 23;
            // 
            // setpos
            // 
            this.setpos.Animated = true;
            this.setpos.AnimatedGIF = true;
            this.setpos.BackColor = System.Drawing.Color.Transparent;
            this.setpos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(115)))), ((int)(((byte)(202)))));
            this.setpos.BorderRadius = 6;
            this.setpos.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.setpos.CheckedState.Parent = this.setpos;
            this.setpos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setpos.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("setpos.CustomImages.Image")));
            this.setpos.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.setpos.CustomImages.ImageOffset = new System.Drawing.Point(0, 3);
            this.setpos.CustomImages.ImageSize = new System.Drawing.Size(15, 15);
            this.setpos.CustomImages.Parent = this.setpos;
            this.setpos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.setpos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setpos.ForeColor = System.Drawing.Color.Transparent;
            this.setpos.HoverState.Parent = this.setpos;
            this.setpos.Location = new System.Drawing.Point(121, 31);
            this.setpos.Name = "setpos";
            this.setpos.PressedColor = System.Drawing.Color.Aqua;
            this.setpos.PressedDepth = 255;
            this.setpos.ShadowDecoration.BorderRadius = 10;
            this.setpos.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(242)))));
            this.setpos.ShadowDecoration.Depth = 15;
            this.setpos.ShadowDecoration.Enabled = true;
            this.setpos.ShadowDecoration.Parent = this.setpos;
            this.setpos.Size = new System.Drawing.Size(38, 20);
            this.setpos.TabIndex = 24;
            this.setpos.UseTransparentBackground = true;
            this.setpos.Click += new System.EventHandler(this.setpos_Click);
            // 
            // makeindicatorclickthroughlabel
            // 
            this.makeindicatorclickthroughlabel.AutoSize = true;
            this.makeindicatorclickthroughlabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.makeindicatorclickthroughlabel.ForeColor = System.Drawing.Color.White;
            this.makeindicatorclickthroughlabel.Location = new System.Drawing.Point(13, 125);
            this.makeindicatorclickthroughlabel.Name = "makeindicatorclickthroughlabel";
            this.makeindicatorclickthroughlabel.Size = new System.Drawing.Size(106, 15);
            this.makeindicatorclickthroughlabel.TabIndex = 25;
            this.makeindicatorclickthroughlabel.Text = "Click-Through Ind.";
            // 
            // clickthroughtoggle
            // 
            this.clickthroughtoggle.Animated = true;
            this.clickthroughtoggle.BackColor = System.Drawing.Color.Transparent;
            this.clickthroughtoggle.Checked = true;
            this.clickthroughtoggle.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.clickthroughtoggle.CheckedState.FillColor = System.Drawing.Color.LimeGreen;
            this.clickthroughtoggle.CheckedState.InnerBorderColor = System.Drawing.Color.Black;
            this.clickthroughtoggle.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.clickthroughtoggle.CheckedState.Parent = this.clickthroughtoggle;
            this.clickthroughtoggle.Location = new System.Drawing.Point(144, 124);
            this.clickthroughtoggle.Name = "clickthroughtoggle";
            this.clickthroughtoggle.ShadowDecoration.Parent = this.clickthroughtoggle;
            this.clickthroughtoggle.Size = new System.Drawing.Size(35, 20);
            this.clickthroughtoggle.TabIndex = 26;
            this.clickthroughtoggle.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.clickthroughtoggle.UncheckedState.FillColor = System.Drawing.Color.Red;
            this.clickthroughtoggle.UncheckedState.InnerBorderColor = System.Drawing.Color.Black;
            this.clickthroughtoggle.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.clickthroughtoggle.UncheckedState.Parent = this.clickthroughtoggle;
            this.clickthroughtoggle.UseTransparentBackground = true;
            // 
            // infocontainer
            // 
            this.infocontainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.infocontainer.BorderRadius = 8;
            this.infocontainer.Controls.Add(this.bootlaunchtoggle);
            this.infocontainer.Controls.Add(this.label4);
            this.infocontainer.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.infocontainer.CustomBorderThickness = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.infocontainer.FillColor = System.Drawing.Color.Transparent;
            this.infocontainer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.infocontainer.ForeColor = System.Drawing.Color.White;
            this.infocontainer.Location = new System.Drawing.Point(9, 42);
            this.infocontainer.Name = "infocontainer";
            this.infocontainer.ShadowDecoration.Parent = this.infocontainer;
            this.infocontainer.Size = new System.Drawing.Size(187, 133);
            this.infocontainer.TabIndex = 49;
            this.infocontainer.Text = "Toggles";
            this.infocontainer.TextOffset = new System.Drawing.Point(55, -8);
            // 
            // bootlaunchtoggle
            // 
            this.bootlaunchtoggle.Animated = true;
            this.bootlaunchtoggle.BackColor = System.Drawing.Color.Transparent;
            this.bootlaunchtoggle.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.bootlaunchtoggle.CheckedState.FillColor = System.Drawing.Color.LimeGreen;
            this.bootlaunchtoggle.CheckedState.InnerBorderColor = System.Drawing.Color.Black;
            this.bootlaunchtoggle.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bootlaunchtoggle.CheckedState.Parent = this.bootlaunchtoggle;
            this.bootlaunchtoggle.Location = new System.Drawing.Point(135, 107);
            this.bootlaunchtoggle.Name = "bootlaunchtoggle";
            this.bootlaunchtoggle.ShadowDecoration.Parent = this.bootlaunchtoggle;
            this.bootlaunchtoggle.Size = new System.Drawing.Size(35, 20);
            this.bootlaunchtoggle.TabIndex = 52;
            this.bootlaunchtoggle.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.bootlaunchtoggle.UncheckedState.FillColor = System.Drawing.Color.Red;
            this.bootlaunchtoggle.UncheckedState.InnerBorderColor = System.Drawing.Color.Black;
            this.bootlaunchtoggle.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bootlaunchtoggle.UncheckedState.Parent = this.bootlaunchtoggle;
            this.bootlaunchtoggle.UseTransparentBackground = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 52;
            this.label4.Text = "Launch on Boot";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2GroupBox1.BorderRadius = 8;
            this.guna2GroupBox1.Controls.Add(this.coordX);
            this.guna2GroupBox1.Controls.Add(this.coordY);
            this.guna2GroupBox1.Controls.Add(this.setpos);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(271, 42);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(167, 60);
            this.guna2GroupBox1.TabIndex = 50;
            this.guna2GroupBox1.Text = "Position";
            this.guna2GroupBox1.TextOffset = new System.Drawing.Point(50, -8);
            // 
            // colorsgroupbox
            // 
            this.colorsgroupbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.colorsgroupbox.BorderRadius = 8;
            this.colorsgroupbox.Controls.Add(this.setopacity);
            this.colorsgroupbox.Controls.Add(this.guna2TextBox3);
            this.colorsgroupbox.Controls.Add(this.setcolor);
            this.colorsgroupbox.Controls.Add(this.opacitylabel);
            this.colorsgroupbox.Controls.Add(this.setbackcolor);
            this.colorsgroupbox.Controls.Add(this.guna2TextBox2);
            this.colorsgroupbox.Controls.Add(this.label1);
            this.colorsgroupbox.Controls.Add(this.label3);
            this.colorsgroupbox.Controls.Add(this.guna2TextBox1);
            this.colorsgroupbox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.colorsgroupbox.CustomBorderThickness = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.colorsgroupbox.FillColor = System.Drawing.Color.Transparent;
            this.colorsgroupbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.colorsgroupbox.ForeColor = System.Drawing.Color.White;
            this.colorsgroupbox.Location = new System.Drawing.Point(234, 174);
            this.colorsgroupbox.Name = "colorsgroupbox";
            this.colorsgroupbox.ShadowDecoration.Parent = this.colorsgroupbox;
            this.colorsgroupbox.Size = new System.Drawing.Size(204, 114);
            this.colorsgroupbox.TabIndex = 51;
            this.colorsgroupbox.Text = "Style";
            this.colorsgroupbox.TextOffset = new System.Drawing.Point(73, -8);
            // 
            // setopacity
            // 
            this.setopacity.Animated = true;
            this.setopacity.AnimatedGIF = true;
            this.setopacity.BackColor = System.Drawing.Color.Transparent;
            this.setopacity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(115)))), ((int)(((byte)(202)))));
            this.setopacity.BorderRadius = 6;
            this.setopacity.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.setopacity.CheckedState.Parent = this.setopacity;
            this.setopacity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setopacity.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("setopacity.CustomImages.Image")));
            this.setopacity.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.setopacity.CustomImages.ImageOffset = new System.Drawing.Point(0, 3);
            this.setopacity.CustomImages.ImageSize = new System.Drawing.Size(15, 15);
            this.setopacity.CustomImages.Parent = this.setopacity;
            this.setopacity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.setopacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setopacity.ForeColor = System.Drawing.Color.Transparent;
            this.setopacity.HoverState.Parent = this.setopacity;
            this.setopacity.Location = new System.Drawing.Point(159, 32);
            this.setopacity.Name = "setopacity";
            this.setopacity.PressedColor = System.Drawing.Color.Aqua;
            this.setopacity.PressedDepth = 255;
            this.setopacity.ShadowDecoration.BorderRadius = 10;
            this.setopacity.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(242)))));
            this.setopacity.ShadowDecoration.Depth = 15;
            this.setopacity.ShadowDecoration.Enabled = true;
            this.setopacity.ShadowDecoration.Parent = this.setopacity;
            this.setopacity.Size = new System.Drawing.Size(38, 20);
            this.setopacity.TabIndex = 52;
            this.setopacity.UseTransparentBackground = true;
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.Animated = true;
            this.guna2TextBox3.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox3.BorderRadius = 6;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.FocusedState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.HoverState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Location = new System.Drawing.Point(93, 32);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderText = "0-255";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.ShadowDecoration.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Size = new System.Drawing.Size(60, 20);
            this.guna2TextBox3.TabIndex = 53;
            // 
            // opacitylabel
            // 
            this.opacitylabel.AutoSize = true;
            this.opacitylabel.ForeColor = System.Drawing.Color.White;
            this.opacitylabel.Location = new System.Drawing.Point(7, 37);
            this.opacitylabel.Name = "opacitylabel";
            this.opacitylabel.Size = new System.Drawing.Size(48, 15);
            this.opacitylabel.TabIndex = 52;
            this.opacitylabel.Text = "Opacity";
            // 
            // setbackcolor
            // 
            this.setbackcolor.Animated = true;
            this.setbackcolor.AnimatedGIF = true;
            this.setbackcolor.BackColor = System.Drawing.Color.Transparent;
            this.setbackcolor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(115)))), ((int)(((byte)(202)))));
            this.setbackcolor.BorderRadius = 6;
            this.setbackcolor.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.setbackcolor.CheckedState.Parent = this.setbackcolor;
            this.setbackcolor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setbackcolor.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("setbackcolor.CustomImages.Image")));
            this.setbackcolor.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.setbackcolor.CustomImages.ImageOffset = new System.Drawing.Point(0, 3);
            this.setbackcolor.CustomImages.ImageSize = new System.Drawing.Size(15, 15);
            this.setbackcolor.CustomImages.Parent = this.setbackcolor;
            this.setbackcolor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.setbackcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setbackcolor.ForeColor = System.Drawing.Color.Transparent;
            this.setbackcolor.HoverState.Parent = this.setbackcolor;
            this.setbackcolor.Location = new System.Drawing.Point(159, 57);
            this.setbackcolor.Name = "setbackcolor";
            this.setbackcolor.PressedColor = System.Drawing.Color.Aqua;
            this.setbackcolor.PressedDepth = 255;
            this.setbackcolor.ShadowDecoration.BorderRadius = 10;
            this.setbackcolor.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(242)))));
            this.setbackcolor.ShadowDecoration.Depth = 15;
            this.setbackcolor.ShadowDecoration.Enabled = true;
            this.setbackcolor.ShadowDecoration.Parent = this.setbackcolor;
            this.setbackcolor.Size = new System.Drawing.Size(38, 20);
            this.setbackcolor.TabIndex = 52;
            this.setbackcolor.UseTransparentBackground = true;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Animated = true;
            this.guna2TextBox2.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox2.BorderRadius = 6;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Location = new System.Drawing.Point(93, 58);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "#";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(60, 20);
            this.guna2TextBox2.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = " BackColor";
            // 
            // SystemTrayIcon
            // 
            this.SystemTrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SystemTrayIcon.BalloonTipText = "cock had been detected. Unplug to disconnect\r\n";
            this.SystemTrayIcon.BalloonTipTitle = "NetworkOverlay";
            this.SystemTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("SystemTrayIcon.Icon")));
            this.SystemTrayIcon.Text = "NetworkOverlay";
            this.SystemTrayIcon.Visible = true;
            // 
            // NetworkOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.clickthroughtoggle);
            this.Controls.Add(this.makeindicatorclickthroughlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.showdragpaneltoggle);
            this.Controls.Add(this.shownetworkindicatorlabel);
            this.Controls.Add(this.shownetworkindicatortoggle);
            this.Controls.Add(this.maindragpanel);
            this.Controls.Add(this.infocontainer);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.colorsgroupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NetworkOverlay";
            this.Text = "Network Overlay";
            this.maindragpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.infocontainer.ResumeLayout(false);
            this.infocontainer.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.colorsgroupbox.ResumeLayout(false);
            this.colorsgroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel maindragpanel;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox close;
        private Guna.UI2.WinForms.Guna2ToggleSwitch shownetworkindicatortoggle;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label shownetworkindicatorlabel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch showdragpaneltoggle;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button setcolor;
        private Guna.UI2.WinForms.Guna2TextBox coordX;
        private Guna.UI2.WinForms.Guna2TextBox coordY;
        private Guna.UI2.WinForms.Guna2Button setpos;
        private System.Windows.Forms.Label makeindicatorclickthroughlabel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch clickthroughtoggle;
        private Guna.UI2.WinForms.Guna2GroupBox infocontainer;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox colorsgroupbox;
        private Guna.UI2.WinForms.Guna2Button setopacity;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private System.Windows.Forms.Label opacitylabel;
        private Guna.UI2.WinForms.Guna2Button setbackcolor;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ToggleSwitch bootlaunchtoggle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon SystemTrayIcon;
    }
}

