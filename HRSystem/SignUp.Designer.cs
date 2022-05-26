namespace HRSystem
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.AuthTitle = new System.Windows.Forms.Label();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.password2Textbox = new System.Windows.Forms.TextBox();
            this.cPassLabel = new System.Windows.Forms.Label();
            this.signupBtn = new System.Windows.Forms.Button();
            this.loginLink = new System.Windows.Forms.Label();
            this.passwordShow = new System.Windows.Forms.PictureBox();
            this.password2Show = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRSystemDataSet = new HRSystem.HRSystemDataSet();
            this.adminTableAdapter = new HRSystem.HRSystemDataSetTableAdapters.adminTableAdapter();
            this.fullnameTextbox = new System.Windows.Forms.TextBox();
            this.errorText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.passwordShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password2Show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRSystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // AuthTitle
            // 
            this.AuthTitle.BackColor = System.Drawing.Color.White;
            this.AuthTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AuthTitle.Location = new System.Drawing.Point(-2, 152);
            this.AuthTitle.Name = "AuthTitle";
            this.AuthTitle.Size = new System.Drawing.Size(504, 29);
            this.AuthTitle.TabIndex = 1;
            this.AuthTitle.Text = "Hello, Signup";
            this.AuthTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.BackColor = System.Drawing.Color.White;
            this.fullnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fullnameLabel.Location = new System.Drawing.Point(61, 238);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(85, 20);
            this.fullnameLabel.TabIndex = 2;
            this.fullnameLabel.Text = "Full Name";
            // 
            // emailTextbox
            // 
            this.emailTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminBindingSource, "email", true));
            this.emailTextbox.Location = new System.Drawing.Point(65, 320);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(364, 22);
            this.emailTextbox.TabIndex = 5;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.White;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailLabel.Location = new System.Drawing.Point(61, 296);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(51, 20);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminBindingSource, "password", true));
            this.passwordTextbox.Location = new System.Drawing.Point(65, 377);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(364, 22);
            this.passwordTextbox.TabIndex = 7;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.White;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordLabel.Location = new System.Drawing.Point(61, 353);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(83, 20);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password";
            // 
            // password2Textbox
            // 
            this.password2Textbox.Location = new System.Drawing.Point(65, 435);
            this.password2Textbox.Name = "password2Textbox";
            this.password2Textbox.Size = new System.Drawing.Size(364, 22);
            this.password2Textbox.TabIndex = 9;
            // 
            // cPassLabel
            // 
            this.cPassLabel.AutoSize = true;
            this.cPassLabel.BackColor = System.Drawing.Color.White;
            this.cPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cPassLabel.Location = new System.Drawing.Point(61, 411);
            this.cPassLabel.Name = "cPassLabel";
            this.cPassLabel.Size = new System.Drawing.Size(147, 20);
            this.cPassLabel.TabIndex = 8;
            this.cPassLabel.Text = "Confirm Password";
            // 
            // signupBtn
            // 
            this.signupBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.signupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBtn.ForeColor = System.Drawing.Color.White;
            this.signupBtn.Location = new System.Drawing.Point(65, 480);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(364, 43);
            this.signupBtn.TabIndex = 10;
            this.signupBtn.Text = "Sign Up";
            this.signupBtn.UseVisualStyleBackColor = false;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // loginLink
            // 
            this.loginLink.AutoSize = true;
            this.loginLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.loginLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginLink.Location = new System.Drawing.Point(65, 530);
            this.loginLink.Name = "loginLink";
            this.loginLink.Size = new System.Drawing.Size(201, 20);
            this.loginLink.TabIndex = 11;
            this.loginLink.Text = "Are you a member? Login";
            this.loginLink.Click += new System.EventHandler(this.loginLink_Click);
            // 
            // passwordShow
            // 
            this.passwordShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordShow.Image = ((System.Drawing.Image)(resources.GetObject("passwordShow.Image")));
            this.passwordShow.Location = new System.Drawing.Point(436, 377);
            this.passwordShow.Margin = new System.Windows.Forms.Padding(4);
            this.passwordShow.Name = "passwordShow";
            this.passwordShow.Size = new System.Drawing.Size(32, 22);
            this.passwordShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordShow.TabIndex = 24;
            this.passwordShow.TabStop = false;
            // 
            // password2Show
            // 
            this.password2Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.password2Show.Image = ((System.Drawing.Image)(resources.GetObject("password2Show.Image")));
            this.password2Show.Location = new System.Drawing.Point(436, 435);
            this.password2Show.Margin = new System.Windows.Forms.Padding(4);
            this.password2Show.Name = "password2Show";
            this.password2Show.Size = new System.Drawing.Size(32, 22);
            this.password2Show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.password2Show.TabIndex = 25;
            this.password2Show.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "admin";
            this.adminBindingSource.DataSource = this.hRSystemDataSet;
            // 
            // hRSystemDataSet
            // 
            this.hRSystemDataSet.DataSetName = "HRSystemDataSet";
            this.hRSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // fullnameTextbox
            // 
            this.fullnameTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminBindingSource, "email", true));
            this.fullnameTextbox.Location = new System.Drawing.Point(65, 261);
            this.fullnameTextbox.Name = "fullnameTextbox";
            this.fullnameTextbox.Size = new System.Drawing.Size(364, 22);
            this.fullnameTextbox.TabIndex = 28;
            // 
            // errorText
            // 
            this.errorText.ForeColor = System.Drawing.Color.Red;
            this.errorText.Location = new System.Drawing.Point(129, 194);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(241, 23);
            this.errorText.TabIndex = 29;
            this.errorText.Text = "Error";
            this.errorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorText.Visible = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(502, 577);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.fullnameTextbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.password2Show);
            this.Controls.Add(this.passwordShow);
            this.Controls.Add(this.loginLink);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.password2Textbox);
            this.Controls.Add(this.cPassLabel);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.fullnameLabel);
            this.Controls.Add(this.AuthTitle);
            this.MaximizeBox = false;
            this.Name = "SignUp";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passwordShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password2Show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRSystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AuthTitle;
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox password2Textbox;
        private System.Windows.Forms.Label cPassLabel;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.Label loginLink;
        private System.Windows.Forms.PictureBox passwordShow;
        private System.Windows.Forms.PictureBox password2Show;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private HRSystemDataSet hRSystemDataSet;
        private HRSystemDataSetTableAdapters.adminTableAdapter adminTableAdapter;
        private System.Windows.Forms.TextBox fullnameTextbox;
        private System.Windows.Forms.Label errorText;
    }
}

