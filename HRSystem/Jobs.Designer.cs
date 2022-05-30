namespace HRSystem
{
    partial class Jobs
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
            this.logoutBtn = new System.Windows.Forms.Button();
            this.adminNameLabel = new System.Windows.Forms.Label();
            this.jobList = new System.Windows.Forms.ListBox();
            this.jobTableAdapter = new HRSystem.HRSystemDataSetTableAdapters.jobTableAdapter();
            this.viewBtn = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(515, 16);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(131, 40);
            this.logoutBtn.TabIndex = 6;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // adminNameLabel
            // 
            this.adminNameLabel.AutoSize = true;
            this.adminNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.adminNameLabel.Location = new System.Drawing.Point(138, 19);
            this.adminNameLabel.Name = "adminNameLabel";
            this.adminNameLabel.Size = new System.Drawing.Size(120, 29);
            this.adminNameLabel.TabIndex = 5;
            this.adminNameLabel.Text = "username";
            // 
            // jobList
            // 
            this.jobList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jobList.FormattingEnabled = true;
            this.jobList.ItemHeight = 16;
            this.jobList.Location = new System.Drawing.Point(143, 152);
            this.jobList.Name = "jobList";
            this.jobList.Size = new System.Drawing.Size(503, 276);
            this.jobList.TabIndex = 7;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // viewBtn
            // 
            this.viewBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.viewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.viewBtn.ForeColor = System.Drawing.Color.White;
            this.viewBtn.Location = new System.Drawing.Point(550, 111);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(96, 35);
            this.viewBtn.TabIndex = 9;
            this.viewBtn.Text = "View";
            this.viewBtn.UseVisualStyleBackColor = false;
            this.viewBtn.Visible = false;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(140, 118);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(42, 18);
            this.errorLabel.TabIndex = 10;
            this.errorLabel.Text = "Error";
            this.errorLabel.Visible = false;
            // 
            // Jobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.jobList);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.adminNameLabel);
            this.Name = "Jobs";
            this.Text = "Job Posts";
            this.Load += new System.EventHandler(this.Jobs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label adminNameLabel;
        private System.Windows.Forms.ListBox jobList;
        private HRSystemDataSetTableAdapters.jobTableAdapter jobTableAdapter;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Label errorLabel;
    }
}