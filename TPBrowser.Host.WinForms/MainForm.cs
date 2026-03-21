namespace TPBrowser.Host.WinForms;

public partial class MainForm : Form
{
    // P/Invoke for window dragging
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    private static extern bool ReleaseCapture();

    [System.Runtime.InteropServices.DllImport("user32.dll")]
    private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    private const int WM_NCLBUTTONDOWN = 0xA1;
    private const int HTCAPTION = 0x2;

    public MainForm()
    {
        InitializeComponent();
    }

    private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
    }

    private void BtnMinimize_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void BtnMaximize_Click(object sender, EventArgs e)
    {
        if (this.WindowState == FormWindowState.Maximized)
        {
            this.WindowState = FormWindowState.Normal;
        }
        else
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }

    private void BtnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void ApplyButtonHover(Button btn, Color normal, Color hover)
    {
        btn.UseVisualStyleBackColor = false;
        btn.FlatStyle = FlatStyle.Flat;
        btn.FlatAppearance.BorderSize = 0;

        btn.BackColor = normal;
        btn.ForeColor = Color.White;

        btn.MouseEnter += (s, e) =>
        {
            btn.BackColor = hover;
        };

        btn.MouseLeave += (s, e) =>
        {
            btn.BackColor = normal;
        };
    }

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources =
            new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        panelTitleBar = new System.Windows.Forms.Panel();
        panelLeft = new System.Windows.Forms.Panel();
        appIcon = new System.Windows.Forms.PictureBox();
        appTitleLabel = new System.Windows.Forms.Label();
        panelWindowButtons = new System.Windows.Forms.Panel();
        btnClose = new System.Windows.Forms.Button();
        btnMaximize = new System.Windows.Forms.Button();
        btnMinimize = new System.Windows.Forms.Button();
        panelTitleBar.SuspendLayout();
        panelLeft.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)appIcon).BeginInit();
        panelWindowButtons.SuspendLayout();
        SuspendLayout();
        // 
        // panelTitleBar
        // 
        panelTitleBar.BackColor =
            System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        panelTitleBar.Controls.Add(panelWindowButtons);
        panelTitleBar.Controls.Add(panelLeft);
        panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
        panelTitleBar.Location = new System.Drawing.Point(0, 0);
        panelTitleBar.Name = "panelTitleBar";
        panelTitleBar.Size = new System.Drawing.Size(1100, 40);
        panelTitleBar.TabIndex = 0;
        // 
        // panelLeft
        // 
        panelLeft.BackColor = System.Drawing.Color.Transparent;
        panelLeft.Controls.Add(appTitleLabel);
        panelLeft.Controls.Add(appIcon);
        panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
        panelLeft.Location = new System.Drawing.Point(0, 0);
        panelLeft.Name = "panelLeft";
        panelLeft.Size = new System.Drawing.Size(288, 40);
        panelLeft.TabIndex = 0;
        // 
        // appIcon
        // 
        appIcon.Dock = System.Windows.Forms.DockStyle.Left;
        appIcon.Image = ((System.Drawing.Image)resources.GetObject("appIcon.Image"));
        appIcon.Location = new System.Drawing.Point(0, 0);
        appIcon.Name = "appIcon";
        appIcon.Size = new System.Drawing.Size(40, 40);
        appIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        appIcon.TabIndex = 1;
        appIcon.TabStop = false;
        // 
        // appTitleLabel
        // 
        appTitleLabel.Dock = System.Windows.Forms.DockStyle.Left;
        appTitleLabel.Font = new System.Drawing.Font("에이투지체 4 Regular", 15.749998F, System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point, ((byte)129));
        appTitleLabel.ForeColor = System.Drawing.Color.White;
        appTitleLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        appTitleLabel.Location = new System.Drawing.Point(40, 0);
        appTitleLabel.Name = "appTitleLabel";
        appTitleLabel.Size = new System.Drawing.Size(245, 40);
        appTitleLabel.TabIndex = 2;
        appTitleLabel.Text = "작 고 소 중 한 브 라 우 저";
        appTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panelWindowButtons
        // 
        panelWindowButtons.BackColor = System.Drawing.Color.Transparent;
        panelWindowButtons.Controls.Add(btnMinimize);
        panelWindowButtons.Controls.Add(btnMaximize);
        panelWindowButtons.Controls.Add(btnClose);
        panelWindowButtons.Dock = System.Windows.Forms.DockStyle.Right;
        panelWindowButtons.Location = new System.Drawing.Point(920, 0);
        panelWindowButtons.Name = "panelWindowButtons";
        panelWindowButtons.Size = new System.Drawing.Size(180, 40);
        panelWindowButtons.TabIndex = 1;
        // 
        // btnClose
        // 
        btnClose.BackColor = System.Drawing.Color.Transparent;
        btnClose.Dock = System.Windows.Forms.DockStyle.Right;
        btnClose.FlatAppearance.BorderSize = 0;
        btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnClose.Font = new System.Drawing.Font("에이투지체 5 Medium", 14.25F, System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point, ((byte)129));
        btnClose.ForeColor = System.Drawing.Color.Transparent;
        btnClose.Image = ((System.Drawing.Image)resources.GetObject("btnClose.Image"));
        btnClose.Location = new System.Drawing.Point(120, 0);
        btnClose.Name = "btnClose";
        btnClose.Size = new System.Drawing.Size(60, 40);
        btnClose.TabIndex = 1;
        btnClose.UseVisualStyleBackColor = false;
        // 
        // btnMaximize
        // 
        btnMaximize.BackColor = System.Drawing.Color.Transparent;
        btnMaximize.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnMaximize.BackgroundImage"));
        btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
        btnMaximize.FlatAppearance.BorderSize = 0;
        btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnMaximize.Font = new System.Drawing.Font("에이투지체 5 Medium", 14.25F, System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point, ((byte)129));
        btnMaximize.ForeColor = System.Drawing.Color.Transparent;
        btnMaximize.Location = new System.Drawing.Point(60, 0);
        btnMaximize.Name = "btnMaximize";
        btnMaximize.Size = new System.Drawing.Size(60, 40);
        btnMaximize.TabIndex = 2;
        btnMaximize.UseVisualStyleBackColor = false;
        // 
        // btnMinimize
        // 
        btnMinimize.BackColor = System.Drawing.Color.Transparent;
        btnMinimize.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnMinimize.BackgroundImage"));
        btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
        btnMinimize.FlatAppearance.BorderSize = 0;
        btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnMinimize.Font = new System.Drawing.Font("에이투지체 5 Medium", 14.25F, System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point, ((byte)129));
        btnMinimize.ForeColor = System.Drawing.Color.Transparent;
        btnMinimize.Location = new System.Drawing.Point(0, 0);
        btnMinimize.Name = "btnMinimize";
        btnMinimize.Size = new System.Drawing.Size(60, 40);
        btnMinimize.TabIndex = 3;
        btnMinimize.TabStop = false;
        btnMinimize.UseVisualStyleBackColor = false;
        // 
        // MainForm
        // 
        BackColor = System.Drawing.Color.DarkGray;
        ClientSize = new System.Drawing.Size(1100, 700);
        Controls.Add(panelTitleBar);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "작고소중한브라우저";
        panelTitleBar.ResumeLayout(false);
        panelLeft.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)appIcon).EndInit();
        panelWindowButtons.ResumeLayout(false);
        ResumeLayout(false);

        ApplyButtonHover(btnMinimize,
            Color.Transparent,
            Color.FromArgb(180, 67, 54));

        ApplyButtonHover(btnMaximize,
            Color.Transparent,
            Color.FromArgb(180, 67, 54));

        ApplyButtonHover(btnClose,
            Color.Transparent,
            Color.FromArgb(180, 67, 54));

        // Wire up event handlers
        panelTitleBar.MouseDown += PanelTitleBar_MouseDown;
        btnMinimize.Click += BtnMinimize_Click;
        btnMaximize.Click += BtnMaximize_Click;
        btnClose.Click += BtnClose_Click;
    }

    private System.Windows.Forms.Button btnMaximize;
    private System.Windows.Forms.Button btnMinimize;

    private System.Windows.Forms.Button btnClose;

    private System.Windows.Forms.Panel panelWindowButtons;

    private System.Windows.Forms.PictureBox appIcon;

    private System.Windows.Forms.Label appTitleLabel;

    private System.Windows.Forms.Panel panelLeft;

    private System.Windows.Forms.Panel panelTitleBar;
}