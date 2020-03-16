namespace Wisej.Web.Ext.NavigationBar
{
	partial class NavigationBar
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

		#region Wisej Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.user = new Wisej.Web.FlexLayoutPanel();
            this.userInfo = new Wisej.Web.FlexLayoutPanel();
            this.userName = new Wisej.Web.Label();
            this.userStatus = new Wisej.Web.FlexLayoutPanel();
            this.userStatusName = new Wisej.Web.Label();
            this.items = new Wisej.Web.FlexLayoutPanel();
            this.slideBar = new Wisej.Web.SlideBar();
            this.header = new Wisej.Web.Panel();
            this.logo = new Wisej.Web.PictureBox();
            this.picCompact = new Wisej.Web.PictureBox();
            this.user.SuspendLayout();
            this.userInfo.SuspendLayout();
            this.userStatus.SuspendLayout();
            this.slideBar.SuspendLayout();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompact)).BeginInit();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.Controls.Add(this.userInfo);
            this.user.Cursor = Wisej.Web.Cursors.Hand;
            this.user.LayoutStyle = Wisej.Web.FlexLayoutStyle.Horizontal;
            this.user.Location = new System.Drawing.Point(0, 307);
            this.user.Margin = new Wisej.Web.Padding(0);
            this.user.Name = "user";
            this.user.Padding = new Wisej.Web.Padding(20, 12, 20, 12);
            this.user.Size = new System.Drawing.Size(320, 94);
            this.user.TabIndex = 1;
            this.user.TabStop = true;
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // userInfo
            // 
            this.userInfo.Anonymous = true;
            this.userInfo.Controls.Add(this.userName);
            this.userInfo.Controls.Add(this.userStatus);
            this.user.SetFillWeight(this.userInfo, 1);
            this.userInfo.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
            this.userInfo.Location = new System.Drawing.Point(23, 15);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(274, 64);
            this.userInfo.Spacing = 0;
            this.userInfo.TabIndex = 1;
            this.userInfo.TabStop = true;
            // 
            // userName
            // 
            this.userName.Anonymous = true;
            this.userName.AutoEllipsis = true;
            this.userInfo.SetFillWeight(this.userName, 1);
            this.userName.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.userName.Location = new System.Drawing.Point(0, 0);
            this.userName.Margin = new Wisej.Web.Padding(0, 0, 0, 5);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(274, 29);
            this.userName.TabIndex = 1;
            this.userName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userStatus
            // 
            this.userStatus.Anonymous = true;
            this.userStatus.Controls.Add(this.userStatusName);
            this.userInfo.SetFillWeight(this.userStatus, 1);
            this.userStatus.LayoutStyle = Wisej.Web.FlexLayoutStyle.Horizontal;
            this.userStatus.Location = new System.Drawing.Point(0, 34);
            this.userStatus.Margin = new Wisej.Web.Padding(0);
            this.userStatus.Name = "userStatus";
            this.userStatus.Size = new System.Drawing.Size(274, 30);
            this.userStatus.TabIndex = 3;
            this.userStatus.TabStop = true;
            // 
            // userStatusName
            // 
            this.userStatusName.Anonymous = true;
            this.userStatus.SetFillWeight(this.userStatusName, 1);
            this.userStatusName.Location = new System.Drawing.Point(3, 3);
            this.userStatusName.Name = "userStatusName";
            this.userStatusName.Size = new System.Drawing.Size(268, 24);
            this.userStatusName.TabIndex = 1;
            this.userStatusName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // items
            // 
            this.items.AutoSize = true;
            this.items.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.items.Dock = Wisej.Web.DockStyle.Left;
            this.items.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
            this.items.Location = new System.Drawing.Point(3, 3);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(314, 0);
            this.items.Spacing = 0;
            this.items.TabIndex = 2;
            this.items.TabStop = true;
            this.items.ControlAdded += new Wisej.Web.ControlEventHandler(this.items_ControlAdded);
            // 
            // slideBar
            // 
            this.slideBar.Controls.Add(this.items);
            this.SetFillWeight(this.slideBar, 1);
            this.slideBar.Location = new System.Drawing.Point(0, 74);
            this.slideBar.Margin = new Wisej.Web.Padding(0);
            this.slideBar.Name = "slideBar";
            this.slideBar.Orientation = Wisej.Web.Orientation.Vertical;
            this.slideBar.Size = new System.Drawing.Size(320, 223);
            this.slideBar.TabIndex = 3;
            // 
            // header
            // 
            this.header.Controls.Add(this.picCompact);
            this.header.Controls.Add(this.logo);
            this.header.Cursor = Wisej.Web.Cursors.Hand;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new Wisej.Web.Padding(0);
            this.header.Name = "header";
            this.header.Padding = new Wisej.Web.Padding(5);
            this.header.Size = new System.Drawing.Size(320, 64);
            this.header.TabIndex = 0;
            this.header.TabStop = true;
            this.header.Click += new System.EventHandler(this.header_Click);
            // 
            // logo
            // 
            this.logo.Dock = Wisej.Web.DockStyle.Fill;
            this.logo.ImageSource = "auditgen_flat.png";
            this.logo.Location = new System.Drawing.Point(5, 5);
            this.logo.Margin = new Wisej.Web.Padding(0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(310, 54);
            this.logo.SizeMode = Wisej.Web.PictureBoxSizeMode.CenterImage;
            // 
            // picCompact
            // 
            this.picCompact.Dock = Wisej.Web.DockStyle.Right;
            this.picCompact.ImageSource = "icon-justify-fill";
            this.picCompact.Location = new System.Drawing.Point(259, 5);
            this.picCompact.Margin = new Wisej.Web.Padding(0);
            this.picCompact.Name = "picCompact";
            this.picCompact.Size = new System.Drawing.Size(56, 54);
            this.picCompact.SizeMode = Wisej.Web.PictureBoxSizeMode.CenterImage;
            // 
            // NavigationBar
            // 
            this.AppearanceKey = "navbar";
            this.Controls.Add(this.header);
            this.Controls.Add(this.slideBar);
            this.Controls.Add(this.user);
            this.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
            this.Name = "NavigationBar";
            this.Size = new System.Drawing.Size(320, 401);
            this.user.ResumeLayout(false);
            this.userInfo.ResumeLayout(false);
            this.userStatus.ResumeLayout(false);
            this.slideBar.ResumeLayout(false);
            this.slideBar.PerformLayout();
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompact)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private FlexLayoutPanel user;
		protected FlexLayoutPanel items;
		protected FlexLayoutPanel userInfo;
		protected Label userName;
        protected FlexLayoutPanel userStatus;
		protected Label userStatusName;
		private SlideBar slideBar;
        protected Panel header;
        private PictureBox logo;
        private PictureBox picCompact;
    }
}
