namespace HRSystem
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.passwordShow = new System.Windows.Forms.PictureBox();
            this.loginLink = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.AuthTitle = new System.Windows.Forms.Label();
            this.userImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.passwordShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordShow
            // 
            this.passwordShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordShow.Image = ((System.Drawing.Image)(resources.GetObject("passwordShow.Image")));
            this.passwordShow.Location = new System.Drawing.Point(440, 297);
            this.passwordShow.Margin = new System.Windows.Forms.Padding(4);
            this.passwordShow.Name = "passwordShow";
            this.passwordShow.Size = new System.Drawing.Size(32, 22);
            this.passwordShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordShow.TabIndex = 38;
            this.passwordShow.TabStop = false;
            // 
            // loginLink
            // 
            this.loginLink.AutoSize = true;
            this.loginLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.loginLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginLink.Location = new System.Drawing.Point(69, 396);
            this.loginLink.Name = "loginLink";
            this.loginLink.Size = new System.Drawing.Size(207, 20);
            this.loginLink.TabIndex = 37;
            this.loginLink.Text = "Not a member yet? Signup";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Green;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(69, 346);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(364, 43);
            this.loginBtn.TabIndex = 36;
            this.loginBtn.Text = "Login In";
            this.loginBtn.UseVisualStyleBackColor = false;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(69, 297);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(364, 22);
            this.passwordTextbox.TabIndex = 33;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.SystemColors.Control;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordLabel.Location = new System.Drawing.Point(65, 273);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(83, 20);
            this.passwordLabel.TabIndex = 32;
            this.passwordLabel.Text = "Password";
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(69, 240);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(364, 22);
            this.emailTextbox.TabIndex = 31;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.SystemColors.Control;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailLabel.Location = new System.Drawing.Point(65, 216);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(51, 20);
            this.emailLabel.TabIndex = 30;
            this.emailLabel.Text = "Email";
            // 
            // AuthTitle
            // 
            this.AuthTitle.AutoSize = true;
            this.AuthTitle.BackColor = System.Drawing.SystemColors.Control;
            this.AuthTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AuthTitle.Location = new System.Drawing.Point(172, 151);
            this.AuthTitle.Name = "AuthTitle";
            this.AuthTitle.Size = new System.Drawing.Size(142, 29);
            this.AuthTitle.TabIndex = 27;
            this.AuthTitle.Text = "Hello, Login";
            // 
            // userImage
            // 
            this.userImage.Image = ((System.Drawing.Image)(resources.GetObject("userImage.Image")));
            this.userImage.Location = new System.Drawing.Point(171, 25);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(143, 109);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userImage.TabIndex = 26;
            this.userImage.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 464);
            this.Controls.Add(this.passwordShow);
            this.Controls.Add(this.loginLink);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.AuthTitle);
            this.Controls.Add(this.userImage);
            this.Name = "LogIn";
            this.Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)(this.passwordShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox passwordShow;
        private System.Windows.Forms.Label loginLink;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label AuthTitle;
        private System.Windows.Forms.PictureBox userImage;
    }
}