namespace WinCredFirefoxPwd {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wndLbl = new System.Windows.Forms.Label();
            this.wndFileLbl = new System.Windows.Forms.Label();
            this.readPwdBtn = new System.Windows.Forms.Button();
            this.checkWindowTimer = new System.Windows.Forms.Timer(this.components);
            this.passwordLbl = new System.Windows.Forms.Label();
            this.clearPwdBtn = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "FG title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "FG file:";
            // 
            // wndLbl
            // 
            this.wndLbl.AutoSize = true;
            this.wndLbl.Location = new System.Drawing.Point(114, 9);
            this.wndLbl.Name = "wndLbl";
            this.wndLbl.Size = new System.Drawing.Size(0, 29);
            this.wndLbl.TabIndex = 2;
            // 
            // wndFileLbl
            // 
            this.wndFileLbl.AutoSize = true;
            this.wndFileLbl.Location = new System.Drawing.Point(114, 50);
            this.wndFileLbl.Name = "wndFileLbl";
            this.wndFileLbl.Size = new System.Drawing.Size(0, 29);
            this.wndFileLbl.TabIndex = 3;
            // 
            // readPwdBtn
            // 
            this.readPwdBtn.Location = new System.Drawing.Point(395, 102);
            this.readPwdBtn.Name = "readPwdBtn";
            this.readPwdBtn.Size = new System.Drawing.Size(96, 41);
            this.readPwdBtn.TabIndex = 4;
            this.readPwdBtn.Text = "Read";
            this.readPwdBtn.UseVisualStyleBackColor = true;
            this.readPwdBtn.Click += new System.EventHandler(this.readPwdBtn_Click);
            // 
            // checkWindowTimer
            // 
            this.checkWindowTimer.Enabled = true;
            this.checkWindowTimer.Interval = 1000;
            this.checkWindowTimer.Tick += new System.EventHandler(this.checkWindowTimer_Tick);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(12, 108);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(0, 29);
            this.passwordLbl.TabIndex = 5;
            // 
            // clearPwdBtn
            // 
            this.clearPwdBtn.Location = new System.Drawing.Point(497, 102);
            this.clearPwdBtn.Name = "clearPwdBtn";
            this.clearPwdBtn.Size = new System.Drawing.Size(96, 41);
            this.clearPwdBtn.TabIndex = 6;
            this.clearPwdBtn.Text = "Clear";
            this.clearPwdBtn.UseVisualStyleBackColor = true;
            this.clearPwdBtn.Click += new System.EventHandler(this.clearPwdBtn_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "WinCred Firefox Pwd";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 155);
            this.Controls.Add(this.clearPwdBtn);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.readPwdBtn);
            this.Controls.Add(this.wndFileLbl);
            this.Controls.Add(this.wndLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinCred Firefox Pwd";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label wndLbl;
        private System.Windows.Forms.Label wndFileLbl;
        private System.Windows.Forms.Button readPwdBtn;
        private System.Windows.Forms.Timer checkWindowTimer;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Button clearPwdBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

