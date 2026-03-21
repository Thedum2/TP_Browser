namespace TPBrowser.Host.WinForms;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        ConfigureTextBoxes();
        CenterTextBoxesVertically();

        panelLeft.Resize += (_, _) => CenterTextBoxesVertically();
        urlPanel.Resize += (_, _) => CenterTextBoxesVertically();
    }

    private void ConfigureTextBoxes()
    {
        appTextBox.BackColor = panelTitleBar.BackColor;
        appTextBox.BorderStyle = BorderStyle.None;
        appTextBox.Multiline = false;
        appTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;

        urlTextBox.BackColor = urlPanel.BackColor;
        urlTextBox.BorderStyle = BorderStyle.None;
        urlTextBox.Multiline = false;
        urlTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    }

    private void CenterTextBoxesVertically()
    {
        CenterTextBoxInParent(appTextBox);
        CenterTextBoxInParent(urlTextBox);
    }

    private static void CenterTextBoxInParent(TextBox textBox)
    {
        if (textBox.Parent is null)
        {
            return;
        }

        int preferredHeight = TextRenderer.MeasureText("A", textBox.Font).Height + 2;
        textBox.Height = preferredHeight;
        textBox.Top = Math.Max(0, (textBox.Parent.ClientSize.Height - textBox.Height) / 2);
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        panelTitleBar = new System.Windows.Forms.Panel();
        panelWindowButtons = new System.Windows.Forms.Panel();
        btnMinimize = new System.Windows.Forms.Button();
        btnMaximize = new System.Windows.Forms.Button();
        btnClose = new System.Windows.Forms.Button();
        panelLeft = new System.Windows.Forms.Panel();
        appTextBox = new System.Windows.Forms.TextBox();
        appIcon = new System.Windows.Forms.PictureBox();
        button1 = new System.Windows.Forms.Button();
        urlPanel = new TPBrowser.Host.WinForms.Component.RoundedPanel();
        urlTextBox = new System.Windows.Forms.TextBox();
        urlLeftBtn = new System.Windows.Forms.Button();
        urlRightBtn = new System.Windows.Forms.Button();
        panel2 = new System.Windows.Forms.Panel();
        urlRefreshBtn = new System.Windows.Forms.Button();
        panel1 = new System.Windows.Forms.Panel();
        panelTitleBar.SuspendLayout();
        panelWindowButtons.SuspendLayout();
        panelLeft.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)appIcon).BeginInit();
        urlPanel.SuspendLayout();
        panel2.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panelTitleBar
        // 
        panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        panelTitleBar.Controls.Add(panelWindowButtons);
        panelTitleBar.Controls.Add(panelLeft);
        panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
        panelTitleBar.Location = new System.Drawing.Point(0, 0);
        panelTitleBar.Name = "panelTitleBar";
        panelTitleBar.Size = new System.Drawing.Size(1100, 40);
        panelTitleBar.TabIndex = 0;
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
        // btnMinimize
        // 
        btnMinimize.BackColor = System.Drawing.Color.Transparent;
        btnMinimize.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnMinimize.BackgroundImage"));
        btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
        btnMinimize.FlatAppearance.BorderSize = 0;
        btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)129));
        btnMinimize.ForeColor = System.Drawing.Color.Transparent;
        btnMinimize.Location = new System.Drawing.Point(0, 0);
        btnMinimize.Name = "btnMinimize";
        btnMinimize.Size = new System.Drawing.Size(60, 40);
        btnMinimize.TabIndex = 3;
        btnMinimize.TabStop = false;
        btnMinimize.UseVisualStyleBackColor = false;
        // 
        // btnMaximize
        // 
        btnMaximize.BackColor = System.Drawing.Color.Transparent;
        btnMaximize.BackgroundImage = ((System.Drawing.Image)resources.GetObject("btnMaximize.BackgroundImage"));
        btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
        btnMaximize.FlatAppearance.BorderSize = 0;
        btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)129));
        btnMaximize.ForeColor = System.Drawing.Color.Transparent;
        btnMaximize.Location = new System.Drawing.Point(60, 0);
        btnMaximize.Name = "btnMaximize";
        btnMaximize.Size = new System.Drawing.Size(60, 40);
        btnMaximize.TabIndex = 2;
        btnMaximize.UseVisualStyleBackColor = false;
        // 
        // btnClose
        // 
        btnClose.BackColor = System.Drawing.Color.Transparent;
        btnClose.Dock = System.Windows.Forms.DockStyle.Right;
        btnClose.FlatAppearance.BorderSize = 0;
        btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)129));
        btnClose.ForeColor = System.Drawing.Color.Transparent;
        btnClose.Image = ((System.Drawing.Image)resources.GetObject("btnClose.Image"));
        btnClose.Location = new System.Drawing.Point(120, 0);
        btnClose.Name = "btnClose";
        btnClose.Size = new System.Drawing.Size(60, 40);
        btnClose.TabIndex = 1;
        btnClose.UseVisualStyleBackColor = false;
        btnClose.Click += btnClose_Click;
        // 
        // panelLeft
        // 
        panelLeft.BackColor = System.Drawing.Color.Transparent;
        panelLeft.Controls.Add(appTextBox);
        panelLeft.Controls.Add(appIcon);
        panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
        panelLeft.Location = new System.Drawing.Point(0, 0);
        panelLeft.Name = "panelLeft";
        panelLeft.Size = new System.Drawing.Size(288, 40);
        panelLeft.TabIndex = 0;
        // 
        // appTextBox
        // 
        appTextBox.BackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        appTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
        appTextBox.Font = new System.Drawing.Font("에이투지체 6 SemiBold", 15.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        appTextBox.ForeColor = System.Drawing.Color.White;
        appTextBox.Location = new System.Drawing.Point(46, 7);
        appTextBox.Margin = new System.Windows.Forms.Padding(0);
        appTextBox.Name = "appTextBox";
        appTextBox.Size = new System.Drawing.Size(248, 26);
        appTextBox.TabIndex = 2;
        appTextBox.Text = "작 고 소 중 한 브 라 우 저";
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
        // button1
        // 
        button1.BackColor = System.Drawing.Color.Transparent;
        button1.BackgroundImage = ((System.Drawing.Image)resources.GetObject("button1.BackgroundImage"));
        button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        button1.Dock = System.Windows.Forms.DockStyle.Left;
        button1.FlatAppearance.BorderSize = 0;
        button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)129));
        button1.ForeColor = System.Drawing.Color.Transparent;
        button1.Location = new System.Drawing.Point(8, 6);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(32, 18);
        button1.TabIndex = 4;
        button1.UseVisualStyleBackColor = false;
        // 
        // urlPanel
        // 
        urlPanel.BackColor = System.Drawing.Color.White;
        urlPanel.Controls.Add(urlTextBox);
        urlPanel.Controls.Add(button1);
        urlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        urlPanel.Location = new System.Drawing.Point(10, 5);
        urlPanel.Margin = new System.Windows.Forms.Padding(0);
        urlPanel.Name = "urlPanel";
        urlPanel.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
        urlPanel.Radius = 13;
        urlPanel.Size = new System.Drawing.Size(965, 30);
        urlPanel.TabIndex = 2;
        // 
        // urlTextBox
        // 
        urlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        urlTextBox.BackColor = System.Drawing.Color.White;
        urlTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
        urlTextBox.Font = new System.Drawing.Font("에이투지체 6 SemiBold", 13F, System.Drawing.FontStyle.Bold);
        urlTextBox.Location = new System.Drawing.Point(43, 5);
        urlTextBox.Margin = new System.Windows.Forms.Padding(0);
        urlTextBox.Name = "urlTextBox";
        urlTextBox.Size = new System.Drawing.Size(901, 21);
        urlTextBox.TabIndex = 2;
        urlTextBox.Text = "https://www.naver.com";
        // 
        // urlLeftBtn
        // 
        urlLeftBtn.BackColor = System.Drawing.Color.Transparent;
        urlLeftBtn.BackgroundImage = ((System.Drawing.Image)resources.GetObject("urlLeftBtn.BackgroundImage"));
        urlLeftBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        urlLeftBtn.Dock = System.Windows.Forms.DockStyle.Left;
        urlLeftBtn.FlatAppearance.BorderSize = 0;
        urlLeftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        urlLeftBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)129));
        urlLeftBtn.ForeColor = System.Drawing.Color.Transparent;
        urlLeftBtn.Location = new System.Drawing.Point(0, 0);
        urlLeftBtn.Name = "urlLeftBtn";
        urlLeftBtn.Size = new System.Drawing.Size(40, 40);
        urlLeftBtn.TabIndex = 4;
        urlLeftBtn.TabStop = false;
        urlLeftBtn.UseVisualStyleBackColor = false;
        // 
        // urlRightBtn
        // 
        urlRightBtn.BackColor = System.Drawing.Color.Transparent;
        urlRightBtn.BackgroundImage = ((System.Drawing.Image)resources.GetObject("urlRightBtn.BackgroundImage"));
        urlRightBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        urlRightBtn.Dock = System.Windows.Forms.DockStyle.Left;
        urlRightBtn.FlatAppearance.BorderSize = 0;
        urlRightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        urlRightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)129));
        urlRightBtn.ForeColor = System.Drawing.Color.Transparent;
        urlRightBtn.Location = new System.Drawing.Point(40, 0);
        urlRightBtn.Name = "urlRightBtn";
        urlRightBtn.Size = new System.Drawing.Size(40, 40);
        urlRightBtn.TabIndex = 5;
        urlRightBtn.TabStop = false;
        urlRightBtn.UseVisualStyleBackColor = false;
        // 
        // panel2
        // 
        panel2.Controls.Add(urlPanel);
        panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        panel2.Location = new System.Drawing.Point(120, 0);
        panel2.Name = "panel2";
        panel2.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
        panel2.Size = new System.Drawing.Size(980, 40);
        panel2.TabIndex = 2;
        // 
        // urlRefreshBtn
        // 
        urlRefreshBtn.BackColor = System.Drawing.Color.Transparent;
        urlRefreshBtn.BackgroundImage = ((System.Drawing.Image)resources.GetObject("urlRefreshBtn.BackgroundImage"));
        urlRefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        urlRefreshBtn.Dock = System.Windows.Forms.DockStyle.Left;
        urlRefreshBtn.FlatAppearance.BorderSize = 0;
        urlRefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        urlRefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)129));
        urlRefreshBtn.ForeColor = System.Drawing.Color.Transparent;
        urlRefreshBtn.Location = new System.Drawing.Point(80, 0);
        urlRefreshBtn.Name = "urlRefreshBtn";
        urlRefreshBtn.Size = new System.Drawing.Size(40, 40);
        urlRefreshBtn.TabIndex = 6;
        urlRefreshBtn.TabStop = false;
        urlRefreshBtn.UseVisualStyleBackColor = false;
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.Gray;
        panel1.Controls.Add(panel2);
        panel1.Controls.Add(urlRefreshBtn);
        panel1.Controls.Add(urlRightBtn);
        panel1.Controls.Add(urlLeftBtn);
        panel1.Dock = System.Windows.Forms.DockStyle.Top;
        panel1.Location = new System.Drawing.Point(0, 40);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(1100, 40);
        panel1.TabIndex = 1;
        // 
        // MainForm
        // 
        BackColor = System.Drawing.Color.DarkGray;
        ClientSize = new System.Drawing.Size(1100, 700);
        Controls.Add(panel1);
        Controls.Add(panelTitleBar);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Location = new System.Drawing.Point(15, 15);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        panelTitleBar.ResumeLayout(false);
        panelWindowButtons.ResumeLayout(false);
        panelLeft.ResumeLayout(false);
        panelLeft.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)appIcon).EndInit();
        urlPanel.ResumeLayout(false);
        urlPanel.PerformLayout();
        panel2.ResumeLayout(false);
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.TextBox urlTextBox;

    private System.Windows.Forms.TextBox appTextBox;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Panel panel2;

    private TPBrowser.Host.WinForms.Component.RoundedPanel urlPanel;

    private System.Windows.Forms.Button urlRefreshBtn;

    private System.Windows.Forms.Button urlRightBtn;

    private System.Windows.Forms.Button urlLeftBtn;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.Button btnMaximize;
    private System.Windows.Forms.Button btnMinimize;

    private System.Windows.Forms.Button btnClose;

    private System.Windows.Forms.Panel panelWindowButtons;

    private System.Windows.Forms.PictureBox appIcon;

    private System.Windows.Forms.Panel panelLeft;

    private System.Windows.Forms.Panel panelTitleBar;

    private void btnClose_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}












