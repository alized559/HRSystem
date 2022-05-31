namespace HRSystem
{
    partial class Job
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Job));
            this.titleLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.employeesNbLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.applyBtn = new System.Windows.Forms.Button();
            this.placeLabel = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.titleLabel.Location = new System.Drawing.Point(39, 22);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(226, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Software Developer";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.locationLabel.Location = new System.Drawing.Point(44, 69);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(127, 20);
            this.locationLabel.TabIndex = 1;
            this.locationLabel.Text = "Beirut, Lebanon";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.typeLabel.Location = new System.Drawing.Point(87, 110);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(74, 20);
            this.typeLabel.TabIndex = 3;
            this.typeLabel.Text = "Full-time";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(48, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // employeesNbLabel
            // 
            this.employeesNbLabel.AutoSize = true;
            this.employeesNbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.employeesNbLabel.Location = new System.Drawing.Point(87, 163);
            this.employeesNbLabel.Name = "employeesNbLabel";
            this.employeesNbLabel.Size = new System.Drawing.Size(112, 20);
            this.employeesNbLabel.TabIndex = 5;
            this.employeesNbLabel.Text = "50 employees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(44, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Job Description";
            // 
            // applyBtn
            // 
            this.applyBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.applyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyBtn.ForeColor = System.Drawing.Color.White;
            this.applyBtn.Location = new System.Drawing.Point(212, 439);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(364, 43);
            this.applyBtn.TabIndex = 37;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = false;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // placeLabel
            // 
            this.placeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.placeLabel.Location = new System.Drawing.Point(218, 69);
            this.placeLabel.Name = "placeLabel";
            this.placeLabel.Size = new System.Drawing.Size(88, 20);
            this.placeLabel.TabIndex = 38;
            this.placeLabel.Text = "(On-site)";
            this.placeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(44, 250);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Size = new System.Drawing.Size(712, 167);
            this.description.TabIndex = 39;
            // 
            // Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.description);
            this.Controls.Add(this.placeLabel);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.employeesNbLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Job";
            this.Text = "Job";
            this.Load += new System.EventHandler(this.Job_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label employeesNbLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Label placeLabel;
        private System.Windows.Forms.TextBox description;
    }
}