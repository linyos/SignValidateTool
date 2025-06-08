// filepath: d:\Coding\CSharp\Side Project\SignValidateTool\SignValidateTool\Form1.Designer.cs
namespace SignValidateTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSelectDllFolder = new Button();
            btnSelectSignTool = new Button();
            txtSignToolPath = new TextBox();
            btnRunPowerShell = new Button();
            txtOutput = new RichTextBox();
            txtDllFolder = new TextBox();
            panel1 = new Panel();
            lblTitle = new Label();
            lblSignTool = new Label();
            lblDllFolder = new Label();
            progressBar = new ProgressBar();
            lblStatus = new Label();
            statusStrip = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            notifyIcon = new NotifyIcon(components);
            notifyIconMenu = new ContextMenuStrip(components);
            menuItemRestore = new ToolStripMenuItem();
            menuItemExit = new ToolStripMenuItem();
            panel1.SuspendLayout();
            statusStrip.SuspendLayout();
            notifyIconMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnSelectDllFolder
            // 
            btnSelectDllFolder.BackColor = Color.FromArgb(240, 240, 240);
            btnSelectDllFolder.Cursor = Cursors.Hand;
            btnSelectDllFolder.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnSelectDllFolder.FlatStyle = FlatStyle.Flat;
            btnSelectDllFolder.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSelectDllFolder.Location = new Point(630, 127);
            btnSelectDllFolder.Margin = new Padding(4);
            btnSelectDllFolder.Name = "btnSelectDllFolder";
            btnSelectDllFolder.Size = new Size(103, 35);
            btnSelectDllFolder.TabIndex = 0;
            btnSelectDllFolder.Text = "瀏覽...";
            btnSelectDllFolder.UseVisualStyleBackColor = false;
            btnSelectDllFolder.Click += button1_Click;
            // 
            // btnSelectSignTool
            // 
            btnSelectSignTool.BackColor = Color.FromArgb(240, 240, 240);
            btnSelectSignTool.Cursor = Cursors.Hand;
            btnSelectSignTool.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnSelectSignTool.FlatStyle = FlatStyle.Flat;
            btnSelectSignTool.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSelectSignTool.Location = new Point(630, 76);
            btnSelectSignTool.Margin = new Padding(4);
            btnSelectSignTool.Name = "btnSelectSignTool";
            btnSelectSignTool.Size = new Size(103, 35);
            btnSelectSignTool.TabIndex = 1;
            btnSelectSignTool.Text = "瀏覽...";
            btnSelectSignTool.UseVisualStyleBackColor = false;
            btnSelectSignTool.Click += btnSelectSignTool_Click;
            // 
            // txtSignToolPath
            // 
            txtSignToolPath.BorderStyle = BorderStyle.FixedSingle;
            txtSignToolPath.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSignToolPath.Location = new Point(167, 76);
            txtSignToolPath.Margin = new Padding(4);
            txtSignToolPath.Name = "txtSignToolPath";
            txtSignToolPath.Size = new Size(449, 27);
            txtSignToolPath.TabIndex = 2;
            // 
            // btnRunPowerShell
            // 
            btnRunPowerShell.BackColor = Color.FromArgb(0, 122, 204);
            btnRunPowerShell.Cursor = Cursors.Hand;
            btnRunPowerShell.FlatAppearance.BorderSize = 0;
            btnRunPowerShell.FlatStyle = FlatStyle.Flat;
            btnRunPowerShell.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnRunPowerShell.ForeColor = Color.White;
            btnRunPowerShell.Location = new Point(347, 177);
            btnRunPowerShell.Margin = new Padding(4);
            btnRunPowerShell.Name = "btnRunPowerShell";
            btnRunPowerShell.Size = new Size(154, 44);
            btnRunPowerShell.TabIndex = 3;
            btnRunPowerShell.Text = "執行驗證";
            btnRunPowerShell.UseVisualStyleBackColor = false;
            btnRunPowerShell.Click += btnRunPowerShell_Click;
            // 
            // txtOutput
            // 
            txtOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtOutput.BackColor = Color.FromArgb(248, 248, 248);
            txtOutput.BorderStyle = BorderStyle.FixedSingle;
            txtOutput.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtOutput.Location = new Point(26, 241);
            txtOutput.Margin = new Padding(4);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(783, 290);
            txtOutput.TabIndex = 4;
            txtOutput.Text = "";
            // 
            // txtDllFolder
            // 
            txtDllFolder.BorderStyle = BorderStyle.FixedSingle;
            txtDllFolder.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDllFolder.Location = new Point(167, 127);
            txtDllFolder.Margin = new Padding(4);
            txtDllFolder.Name = "txtDllFolder";
            txtDllFolder.Size = new Size(449, 27);
            txtDllFolder.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(836, 51);
            panel1.TabIndex = 6;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(26, 13);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(172, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "DLL 簽章驗證工具";
            // 
            // lblSignTool
            // 
            lblSignTool.AutoSize = true;
            lblSignTool.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSignTool.Location = new Point(26, 80);
            lblSignTool.Margin = new Padding(4, 0, 4, 0);
            lblSignTool.Name = "lblSignTool";
            lblSignTool.Size = new Size(99, 19);
            lblSignTool.TabIndex = 7;
            lblSignTool.Text = "驗證工具路徑";
            // 
            // lblDllFolder
            // 
            lblDllFolder.AutoSize = true;
            lblDllFolder.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDllFolder.Location = new Point(26, 130);
            lblDllFolder.Margin = new Padding(4, 0, 4, 0);
            lblDllFolder.Name = "lblDllFolder";
            lblDllFolder.Size = new Size(118, 19);
            lblDllFolder.TabIndex = 8;
            lblDllFolder.Text = "DLL 資料夾路徑:";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(26, 545);
            progressBar.Margin = new Padding(4);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(784, 13);
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.TabIndex = 9;
            progressBar.Visible = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.Location = new Point(26, 225);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(72, 19);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "執行結果:";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip.Location = new Point(0, 570);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 18, 0);
            statusStrip.Size = new Size(836, 25);
            statusStrip.TabIndex = 11;
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(39, 19);
            statusLabel.Text = "就緒";
            //
            // notifyIconMenu
            //
            notifyIconMenu.Items.AddRange(new ToolStripItem[] { menuItemRestore, menuItemExit });
            notifyIconMenu.Name = "notifyIconMenu";
            notifyIconMenu.Size = new Size(151, 48);
            //
            // menuItemRestore
            //
            menuItemRestore.Name = "menuItemRestore";
            menuItemRestore.Size = new Size(150, 22);
            menuItemRestore.Text = "還原";
            menuItemRestore.Click += menuItemRestore_Click;
            //
            // menuItemExit
            //
            menuItemExit.Name = "menuItemExit";
            menuItemExit.Size = new Size(150, 22);
            menuItemExit.Text = "離開";
            menuItemExit.Click += menuItemExit_Click;
            //
            // notifyIcon
            //
            notifyIcon.ContextMenuStrip = notifyIconMenu;
            notifyIcon.Icon = SystemIcons.Application;
            notifyIcon.Text = "DLL 簽章驗證工具";
            notifyIcon.Visible = false;
            notifyIcon.DoubleClick += notifyIcon_DoubleClick;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 595);
            Controls.Add(statusStrip);
            Controls.Add(lblStatus);
            Controls.Add(progressBar);
            Controls.Add(lblDllFolder);
            Controls.Add(lblSignTool);
            Controls.Add(panel1);
            Controls.Add(txtDllFolder);
            Controls.Add(txtOutput);
            Controls.Add(btnRunPowerShell);
            Controls.Add(txtSignToolPath);
            Controls.Add(btnSelectSignTool);
            Controls.Add(btnSelectDllFolder);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "DLL 簽章驗證工具";
            Resize += Form1_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            notifyIconMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectDllFolder;
        private Button btnSelectSignTool;
        private TextBox txtSignToolPath;
        private Button btnRunPowerShell;
        private RichTextBox txtOutput;
        private TextBox txtDllFolder;
        private Panel panel1;
        private Label lblTitle;
        private Label lblSignTool;
        private Label lblDllFolder;
        private ProgressBar progressBar;
        private Label lblStatus;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusLabel;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip notifyIconMenu;
        private ToolStripMenuItem menuItemRestore;
        private ToolStripMenuItem menuItemExit;
    }
}
