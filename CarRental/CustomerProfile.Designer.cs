namespace CarRental
{
    partial class CustomerProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerProfile));
            this.panelProfile = new MetroFramework.Controls.MetroPanel();
            this.panelCustomerProfile = new MetroFramework.Controls.MetroPanel();
            this.buttonGoBack = new MetroFramework.Controls.MetroButton();
            this.labelShowEmail = new System.Windows.Forms.Label();
            this.labelShowPassword = new System.Windows.Forms.Label();
            this.labelShowName = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonChangePassword = new MetroFramework.Controls.MetroButton();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panelProfile.SuspendLayout();
            this.panelCustomerProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProfile
            // 
            this.panelProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelProfile.BackgroundImage")));
            this.panelProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelProfile.Controls.Add(this.panelCustomerProfile);
            this.panelProfile.HorizontalScrollbarBarColor = true;
            this.panelProfile.HorizontalScrollbarHighlightOnWheel = false;
            this.panelProfile.HorizontalScrollbarSize = 10;
            this.panelProfile.Location = new System.Drawing.Point(0, 38);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(1078, 753);
            this.panelProfile.TabIndex = 0;
            this.panelProfile.VerticalScrollbarBarColor = true;
            this.panelProfile.VerticalScrollbarHighlightOnWheel = false;
            this.panelProfile.VerticalScrollbarSize = 10;
            // 
            // panelCustomerProfile
            // 
            this.panelCustomerProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelCustomerProfile.Controls.Add(this.buttonGoBack);
            this.panelCustomerProfile.Controls.Add(this.labelShowEmail);
            this.panelCustomerProfile.Controls.Add(this.labelShowPassword);
            this.panelCustomerProfile.Controls.Add(this.labelShowName);
            this.panelCustomerProfile.Controls.Add(this.labelUserName);
            this.panelCustomerProfile.Controls.Add(this.labelWelcome);
            this.panelCustomerProfile.Controls.Add(this.buttonChangePassword);
            this.panelCustomerProfile.Controls.Add(this.labelPassword);
            this.panelCustomerProfile.Controls.Add(this.labelEmail);
            this.panelCustomerProfile.Controls.Add(this.labelName);
            this.panelCustomerProfile.HorizontalScrollbarBarColor = true;
            this.panelCustomerProfile.HorizontalScrollbarHighlightOnWheel = false;
            this.panelCustomerProfile.HorizontalScrollbarSize = 10;
            this.panelCustomerProfile.Location = new System.Drawing.Point(280, 55);
            this.panelCustomerProfile.Name = "panelCustomerProfile";
            this.panelCustomerProfile.Size = new System.Drawing.Size(533, 584);
            this.panelCustomerProfile.TabIndex = 1;
            this.panelCustomerProfile.UseCustomBackColor = true;
            this.panelCustomerProfile.UseCustomForeColor = true;
            this.panelCustomerProfile.VerticalScrollbarBarColor = true;
            this.panelCustomerProfile.VerticalScrollbarHighlightOnWheel = false;
            this.panelCustomerProfile.VerticalScrollbarSize = 10;
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonGoBack.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.buttonGoBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGoBack.Location = new System.Drawing.Point(180, 466);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(186, 35);
            this.buttonGoBack.TabIndex = 2;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseCustomBackColor = true;
            this.buttonGoBack.UseCustomForeColor = true;
            this.buttonGoBack.UseSelectable = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // labelShowEmail
            // 
            this.labelShowEmail.AutoSize = true;
            this.labelShowEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelShowEmail.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelShowEmail.Location = new System.Drawing.Point(190, 237);
            this.labelShowEmail.Name = "labelShowEmail";
            this.labelShowEmail.Size = new System.Drawing.Size(0, 30);
            this.labelShowEmail.TabIndex = 14;
            // 
            // labelShowPassword
            // 
            this.labelShowPassword.AutoSize = true;
            this.labelShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelShowPassword.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelShowPassword.Location = new System.Drawing.Point(190, 286);
            this.labelShowPassword.Name = "labelShowPassword";
            this.labelShowPassword.Size = new System.Drawing.Size(0, 30);
            this.labelShowPassword.TabIndex = 13;
            // 
            // labelShowName
            // 
            this.labelShowName.AutoSize = true;
            this.labelShowName.BackColor = System.Drawing.Color.Transparent;
            this.labelShowName.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelShowName.Location = new System.Drawing.Point(190, 188);
            this.labelShowName.Name = "labelShowName";
            this.labelShowName.Size = new System.Drawing.Size(0, 30);
            this.labelShowName.TabIndex = 12;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("Myanmar Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUserName.Location = new System.Drawing.Point(185, 94);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(0, 58);
            this.labelUserName.TabIndex = 11;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Myanmar Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelWelcome.Location = new System.Drawing.Point(185, 34);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(178, 58);
            this.labelWelcome.TabIndex = 10;
            this.labelWelcome.Text = "Welcome,";
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.buttonChangePassword.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.buttonChangePassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonChangePassword.Location = new System.Drawing.Point(180, 382);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(186, 35);
            this.buttonChangePassword.TabIndex = 1;
            this.buttonChangePassword.Text = "Change Password";
            this.buttonChangePassword.UseCustomBackColor = true;
            this.buttonChangePassword.UseCustomForeColor = true;
            this.buttonChangePassword.UseSelectable = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPassword.Location = new System.Drawing.Point(96, 286);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(93, 30);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password :";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEmail.Location = new System.Drawing.Point(96, 237);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(63, 30);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelName.Location = new System.Drawing.Point(96, 188);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 30);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name :";
            // 
            // CustomerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 779);
            this.Controls.Add(this.panelProfile);
            this.Name = "CustomerProfile";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.panelProfile.ResumeLayout(false);
            this.panelCustomerProfile.ResumeLayout(false);
            this.panelCustomerProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelProfile;
        private MetroFramework.Controls.MetroPanel panelCustomerProfile;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelName;
        private MetroFramework.Controls.MetroButton buttonChangePassword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelWelcome;
        private MetroFramework.Controls.MetroButton buttonGoBack;
        private System.Windows.Forms.Label labelShowEmail;
        private System.Windows.Forms.Label labelShowPassword;
        private System.Windows.Forms.Label labelShowName;
    }
}