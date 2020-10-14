using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinCredFirefoxPwd {
    public partial class MainForm : Form {
        private const string TargetTitle = "Password Required - Mozilla Firefox";
        private const string TargetFile = @"C:\Program Files\Mozilla Firefox\firefox.exe";

        public MainForm() {
            InitializeComponent();
        }

        private void checkWindowTimer_Tick(object sender, EventArgs e) {
            var title = WinApi.GetForegroundWindowText();
            wndLbl.Text = title;

            var titleMatches = title == TargetTitle;
            wndLbl.ForeColor = titleMatches ? Color.Green : Color.Black;
            if (!titleMatches) {
                wndFileLbl.Text = "";
                return;
            }

            var file = WinApi.GetForegroundWindowFile();
            wndFileLbl.Text = file;

            var fileMatches = file == TargetFile;
            wndFileLbl.ForeColor = fileMatches ? Color.Green : Color.Red;

            if (!fileMatches) {
                return;
            }

            if (!TryGetPassword(out var pwd)) {
                return;
            }

            SendKeys.Send(pwd);
            SendKeys.Send("\n");
        }

        private bool TryGetPassword(out string pwd) {
            pwd = CredApi.GetPassword("firefox-master");
            return pwd != null;
        }

        private void readPwdBtn_Click(object sender, EventArgs e) {
            if (TryGetPassword(out var pwd)) {
                passwordLbl.Text = pwd;
            }
            else {
                passwordLbl.Text = "(failed to read)";
            }
        }

        private void clearPwdBtn_Click(object sender, EventArgs e) {
            passwordLbl.Text = "";
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            Show();
            Activate();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Minimized) {
                ShowInTaskbar = false;
                Hide();
            }
        }
    }
}
