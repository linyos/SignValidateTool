using System.Management.Automation;
using System.Drawing;

namespace SignValidateTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            notifyIcon.Icon = SystemIcons.Application;
            notifyIcon.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtDllFolder.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnSelectSignTool_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtSignToolPath.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnRunPowerShell_Click(object sender, EventArgs e)
        {
            // 更新UI狀態
            txtOutput.Text = "";
            btnRunPowerShell.Enabled = false;
            progressBar.Visible = true;
            statusLabel.Text = "正在執行驗證...";

            string dllFolder = txtDllFolder.Text;
            string signToolPath = txtSignToolPath.Text;

            if (!Directory.Exists(dllFolder) || !Directory.Exists(signToolPath))
            {
                MessageBox.Show("請確認路徑正確！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetUI();
                return;
            }
            signToolPath = Path.Combine(signToolPath, "SignDotNet.exe");

            Task.Run(() =>
            {
                try
                {
                    var dllFiles = Directory.GetFiles(dllFolder, "*.dll");
                    int totalCount = dllFiles.Length;
                    int currentCount = 0;

                    foreach (var dllFile in dllFiles)
                    {
                        currentCount++;
                        string fileName = Path.GetFileName(dllFile);
                        AppendText($"處理中 ({currentCount}/{totalCount}): {fileName}");

                        var psi = new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = signToolPath,
                            Arguments = $"-verify \"{dllFile}\"",
                            RedirectStandardOutput = true,
                            RedirectStandardError = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        using (var process = System.Diagnostics.Process.Start(psi))
                        {
                            string output = process.StandardOutput.ReadToEnd();
                            string error = process.StandardError.ReadToEnd();
                            process.WaitForExit();

                            AppendText($"結果: {output}");
                            if (!string.IsNullOrWhiteSpace(error))
                                AppendText($"錯誤: {error}");
                            AppendText("------------------------------");
                        }
                    }

                    this.Invoke(new Action(() =>
                    {
                        statusLabel.Text = "驗證完成";
                        progressBar.Visible = false;
                        btnRunPowerShell.Enabled = true;
                    }));
                }
                catch (Exception ex)
                {
                    this.Invoke(new Action(() =>
                    {
                        MessageBox.Show("執行失敗：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ResetUI();
                    }));
                }
            });
        }

        private void ResetUI()
        {
            statusLabel.Text = "就緒";
            progressBar.Visible = false;
            btnRunPowerShell.Enabled = true;
        }

        private void AppendText(string text)
        {
            if (txtOutput.InvokeRequired)
            {
                txtOutput.Invoke(new Action(() => AppendText(text)));
            }
            else
            {
                txtOutput.AppendText(text + Environment.NewLine);
            }
        }

        private void Form1_Resize(object? sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                ShowInTaskbar = false;
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_DoubleClick(object? sender, EventArgs e)
        {
            RestoreFromTray();
        }

        private void menuItemRestore_Click(object? sender, EventArgs e)
        {
            RestoreFromTray();
        }

        private void menuItemExit_Click(object? sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Application.Exit();
        }

        private void RestoreFromTray()
        {
            Show();
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            notifyIcon.Visible = false;
        }
    }
}