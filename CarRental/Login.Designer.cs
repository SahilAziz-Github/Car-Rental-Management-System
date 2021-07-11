namespace CarRental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelLoginImage = new MetroFramework.Controls.MetroPanel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonShowPassword = new System.Windows.Forms.Button();
            this.buttonExit = new MetroFramework.Controls.MetroButton();
            this.buttonSignin = new MetroFramework.Controls.MetroButton();
            this.buttonLogin = new MetroFramework.Controls.MetroButton();
            this.textEmail = new MetroFramework.Controls.MetroTextBox();
            this.textPassword = new MetroFramework.Controls.MetroTextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelLoginImage.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLoginImage
            // 
            this.panelLoginImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLoginImage.BackgroundImage")));
            this.panelLoginImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLoginImage.Controls.Add(this.panelLogin);
            this.panelLoginImage.HorizontalScrollbarBarColor = true;
            this.panelLoginImage.HorizontalScrollbarHighlightOnWheel = false;
            this.panelLoginImage.HorizontalScrollbarSize = 10;
            this.panelLoginImage.Location = new System.Drawing.Point(0, 28);
            this.panelLoginImage.Name = "panelLoginImage";
            this.panelLoginImage.Size = new System.Drawing.Size(1085, 753);
            this.panelLoginImage.TabIndex = 0;
            this.panelLoginImage.VerticalScrollbarBarColor = true;
            this.panelLoginImage.VerticalScrollbarHighlightOnWheel = false;
            this.panelLoginImage.VerticalScrollbarSize = 10;
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelLogin.Controls.Add(this.buttonShowPassword);
            this.panelLogin.Controls.Add(this.buttonExit);
            this.panelLogin.Controls.Add(this.buttonSignin);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.textEmail);
            this.panelLogin.Controls.Add(this.textPassword);
            this.panelLogin.Controls.Add(this.labelEmail);
            this.panelLogin.Controls.Add(this.labelPassword);
            this.panelLogin.Controls.Add(this.labelTitle);
            this.panelLogin.Location = new System.Drawing.Point(300, 115);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(511, 534);
            this.panelLogin.TabIndex = 2;
            // 
            // buttonShowPassword
            // 
            this.buttonShowPassword.BackColor = System.Drawing.Color.Black;
            this.buttonShowPassword.ForeColor = System.Drawing.Color.White;
            this.buttonShowPassword.Location = new System.Drawing.Point(422, 231);
            this.buttonShowPassword.Name = "buttonShowPassword";
            this.buttonShowPassword.Size = new System.Drawing.Size(75, 28);
            this.buttonShowPassword.TabIndex = 5;
            this.buttonShowPassword.Text = "Show";
            this.buttonShowPassword.UseVisualStyleBackColor = false;
            this.buttonShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonShowPassword_MouseDown);
            this.buttonShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonShowPassword_MouseUp);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Location = new System.Drawing.Point(410, 468);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(68, 33);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseCustomBackColor = true;
            this.buttonExit.UseCustomForeColor = true;
            this.buttonExit.UseSelectable = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSignin
            // 
            this.buttonSignin.BackColor = System.Drawing.Color.Transparent;
            this.buttonSignin.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.buttonSignin.ForeColor = System.Drawing.Color.White;
            this.buttonSignin.Location = new System.Drawing.Point(133, 385);
            this.buttonSignin.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSignin.Name = "buttonSignin";
            this.buttonSignin.Size = new System.Drawing.Size(268, 44);
            this.buttonSignin.TabIndex = 4;
            this.buttonSignin.Text = "Sign in";
            this.buttonSignin.UseCustomBackColor = true;
            this.buttonSignin.UseCustomForeColor = true;
            this.buttonSignin.UseSelectable = true;
            this.buttonSignin.Click += new System.EventHandler(this.buttonSignin_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(133, 302);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 49);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Log in";
            this.buttonLogin.UseCustomBackColor = true;
            this.buttonLogin.UseCustomForeColor = true;
            this.buttonLogin.UseSelectable = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textEmail
            // 
            // 
            // 
            // 
            this.textEmail.CustomButton.Image = null;
            this.textEmail.CustomButton.Location = new System.Drawing.Point(182, 2);
            this.textEmail.CustomButton.Name = "";
            this.textEmail.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textEmail.CustomButton.TabIndex = 1;
            this.textEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textEmail.CustomButton.UseSelectable = true;
            this.textEmail.CustomButton.Visible = false;
            this.textEmail.Lines = new string[0];
            this.textEmail.Location = new System.Drawing.Point(208, 185);
            this.textEmail.MaxLength = 32767;
            this.textEmail.Name = "textEmail";
            this.textEmail.PasswordChar = '\0';
            this.textEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textEmail.SelectedText = "";
            this.textEmail.SelectionLength = 0;
            this.textEmail.SelectionStart = 0;
            this.textEmail.ShortcutsEnabled = true;
            this.textEmail.Size = new System.Drawing.Size(208, 28);
            this.textEmail.TabIndex = 1;
            this.textEmail.UseSelectable = true;
            this.textEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textPassword
            // 
            // 
            // 
            // 
            this.textPassword.CustomButton.Image = null;
            this.textPassword.CustomButton.Location = new System.Drawing.Point(182, 2);
            this.textPassword.CustomButton.Name = "";
            this.textPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textPassword.CustomButton.TabIndex = 1;
            this.textPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textPassword.CustomButton.UseSelectable = true;
            this.textPassword.CustomButton.Visible = false;
            this.textPassword.Lines = new string[0];
            this.textPassword.Location = new System.Drawing.Point(208, 231);
            this.textPassword.MaxLength = 32767;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '✹';
            this.textPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textPassword.SelectedText = "";
            this.textPassword.SelectionLength = 0;
            this.textPassword.SelectionStart = 0;
            this.textPassword.ShortcutsEnabled = true;
            this.textPassword.Size = new System.Drawing.Size(208, 28);
            this.textPassword.TabIndex = 2;
            this.textPassword.UseSelectable = true;
            this.textPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEmail.Location = new System.Drawing.Point(109, 185);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(63, 30);
            this.labelEmail.TabIndex = 91;
            this.labelEmail.Text = "Email :";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPassword.Location = new System.Drawing.Point(109, 231);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(93, 30);
            this.labelPassword.TabIndex = 92;
            this.labelPassword.Text = "Password :";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Myanmar Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle.Location = new System.Drawing.Point(170, 68);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(169, 58);
            this.labelTitle.TabIndex = 99;
            this.labelTitle.Text = "Welcome";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 779);
            this.Controls.Add(this.panelLoginImage);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.panelLoginImage.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelLoginImage;
        private System.Windows.Forms.Panel panelLogin;
        private MetroFramework.Controls.MetroButton buttonLogin;
        private MetroFramework.Controls.MetroTextBox textEmail;
        private MetroFramework.Controls.MetroTextBox textPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelTitle;
        private MetroFramework.Controls.MetroButton buttonSignin;
        private MetroFramework.Controls.MetroButton buttonExit;
        private System.Windows.Forms.Button buttonShowPassword;
    }
}

