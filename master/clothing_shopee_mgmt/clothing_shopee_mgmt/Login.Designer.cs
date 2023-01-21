namespace clothing_shopee_mgmt
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usernameLbl = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.logoPb = new System.Windows.Forms.PictureBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.logintBtn = new System.Windows.Forms.Button();
            this.dateLbl = new System.Windows.Forms.Label();
            this.dateUpdate = new System.Windows.Forms.Timer(this.components);
            this.timeLbl = new System.Windows.Forms.Label();
            this.timeUpdate = new System.Windows.Forms.Timer(this.components);
            this.exitBtn = new System.Windows.Forms.Button();
            this.loginGb = new System.Windows.Forms.GroupBox();
            this.showPasswordChk = new System.Windows.Forms.CheckBox();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.signUpLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).BeginInit();
            this.loginGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLbl
            // 
            this.usernameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.usernameLbl.Location = new System.Drawing.Point(29, 46);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(104, 28);
            this.usernameLbl.TabIndex = 0;
            this.usernameLbl.Text = "Username";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(161, 43);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(362, 34);
            this.usernameTxt.TabIndex = 1;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(161, 131);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(362, 34);
            this.passwordTxt.TabIndex = 3;
            // 
            // passwordLbl
            // 
            this.passwordLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.passwordLbl.Location = new System.Drawing.Point(29, 134);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(97, 28);
            this.passwordLbl.TabIndex = 2;
            this.passwordLbl.Text = "Password";
            // 
            // logoPb
            // 
            this.logoPb.Image = ((System.Drawing.Image)(resources.GetObject("logoPb.Image")));
            this.logoPb.Location = new System.Drawing.Point(22, 12);
            this.logoPb.Name = "logoPb";
            this.logoPb.Size = new System.Drawing.Size(171, 171);
            this.logoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logoPb.TabIndex = 4;
            this.logoPb.TabStop = false;
            // 
            // resetBtn
            // 
            this.resetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.resetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.resetBtn.Location = new System.Drawing.Point(161, 229);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Padding = new System.Windows.Forms.Padding(2);
            this.resetBtn.Size = new System.Drawing.Size(94, 45);
            this.resetBtn.TabIndex = 6;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // logintBtn
            // 
            this.logintBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logintBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logintBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.logintBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logintBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logintBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.logintBtn.Location = new System.Drawing.Point(429, 229);
            this.logintBtn.Name = "logintBtn";
            this.logintBtn.Padding = new System.Windows.Forms.Padding(2);
            this.logintBtn.Size = new System.Drawing.Size(94, 45);
            this.logintBtn.TabIndex = 7;
            this.logintBtn.Text = "Login";
            this.logintBtn.UseVisualStyleBackColor = false;
            this.logintBtn.Click += new System.EventHandler(this.logintBtn_Click);
            // 
            // dateLbl
            // 
            this.dateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.dateLbl.Location = new System.Drawing.Point(1125, 41);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(187, 38);
            this.dateLbl.TabIndex = 9;
            this.dateLbl.Text = "dd/mm/yyyy";
            // 
            // dateUpdate
            // 
            this.dateUpdate.Interval = 1000;
            this.dateUpdate.Tick += new System.EventHandler(this.timeUpdate_Tick);
            // 
            // timeLbl
            // 
            this.timeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.timeLbl.Location = new System.Drawing.Point(1125, 95);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(129, 38);
            this.timeLbl.TabIndex = 10;
            this.timeLbl.Text = "00:00:00";
            // 
            // timeUpdate
            // 
            this.timeUpdate.Interval = 1000;
            this.timeUpdate.Tick += new System.EventHandler(this.timeUpdate_Tick_1);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitBtn.Location = new System.Drawing.Point(1120, 199);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 50);
            this.exitBtn.TabIndex = 60;
            this.exitBtn.Text = "Exit";
            this.exitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // loginGb
            // 
            this.loginGb.Controls.Add(this.showPasswordChk);
            this.loginGb.Controls.Add(this.signUpBtn);
            this.loginGb.Controls.Add(this.signUpLbl);
            this.loginGb.Controls.Add(this.logintBtn);
            this.loginGb.Controls.Add(this.resetBtn);
            this.loginGb.Controls.Add(this.passwordTxt);
            this.loginGb.Controls.Add(this.passwordLbl);
            this.loginGb.Controls.Add(this.usernameTxt);
            this.loginGb.Controls.Add(this.usernameLbl);
            this.loginGb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginGb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.loginGb.Location = new System.Drawing.Point(413, 199);
            this.loginGb.Name = "loginGb";
            this.loginGb.Size = new System.Drawing.Size(604, 398);
            this.loginGb.TabIndex = 39;
            this.loginGb.TabStop = false;
            this.loginGb.Text = "Welcome! Please insert valid details.";
            // 
            // showPasswordChk
            // 
            this.showPasswordChk.AutoSize = true;
            this.showPasswordChk.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPasswordChk.Location = new System.Drawing.Point(161, 182);
            this.showPasswordChk.Name = "showPasswordChk";
            this.showPasswordChk.Size = new System.Drawing.Size(175, 32);
            this.showPasswordChk.TabIndex = 10;
            this.showPasswordChk.Text = "Show Password";
            this.showPasswordChk.UseVisualStyleBackColor = true;
            this.showPasswordChk.CheckedChanged += new System.EventHandler(this.showPasswordChk_CheckedChanged);
            // 
            // signUpBtn
            // 
            this.signUpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.signUpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.signUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.signUpBtn.Location = new System.Drawing.Point(411, 316);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.signUpBtn.Size = new System.Drawing.Size(112, 43);
            this.signUpBtn.TabIndex = 9;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.UseVisualStyleBackColor = false;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // signUpLbl
            // 
            this.signUpLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signUpLbl.AutoSize = true;
            this.signUpLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.signUpLbl.Location = new System.Drawing.Point(296, 323);
            this.signUpLbl.Name = "signUpLbl";
            this.signUpLbl.Size = new System.Drawing.Size(112, 28);
            this.signUpLbl.TabIndex = 8;
            this.signUpLbl.Text = "New User?";
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1333, 714);
            this.Controls.Add(this.loginGb);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.logoPb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).EndInit();
            this.loginGb.ResumeLayout(false);
            this.loginGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.PictureBox logoPb;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button logintBtn;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Timer dateUpdate;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Timer timeUpdate;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.GroupBox loginGb;
        private System.Windows.Forms.CheckBox showPasswordChk;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Label signUpLbl;
    }
}

