namespace HRSystem
{
    partial class AddEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.fullnameTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.genderTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ageTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numberTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.jobTextbox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.companyTextbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.hrSystemDataSet1 = new HRSystem.HRSystemDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new HRSystem.HRSystemDataSetTableAdapters.employeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hrSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(1, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adding A New Employee?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(64, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lets Start With The Username";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(68, 151);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(369, 22);
            this.usernameTextbox.TabIndex = 2;
            // 
            // fullnameTextbox
            // 
            this.fullnameTextbox.Location = new System.Drawing.Point(68, 231);
            this.fullnameTextbox.Name = "fullnameTextbox";
            this.fullnameTextbox.Size = new System.Drawing.Size(369, 22);
            this.fullnameTextbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(64, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "What About Full Name?";
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(68, 305);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(369, 22);
            this.emailTextbox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(64, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "What The Email?";
            // 
            // genderTextbox
            // 
            this.genderTextbox.Location = new System.Drawing.Point(68, 383);
            this.genderTextbox.Name = "genderTextbox";
            this.genderTextbox.Size = new System.Drawing.Size(369, 22);
            this.genderTextbox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(64, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Female Or Male?";
            // 
            // ageTextbox
            // 
            this.ageTextbox.Location = new System.Drawing.Point(68, 460);
            this.ageTextbox.Name = "ageTextbox";
            this.ageTextbox.Size = new System.Drawing.Size(369, 22);
            this.ageTextbox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(64, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "How Much Old?";
            // 
            // addressTextbox
            // 
            this.addressTextbox.Location = new System.Drawing.Point(68, 534);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(369, 22);
            this.addressTextbox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(64, 502);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "What The Location?";
            // 
            // numberTextbox
            // 
            this.numberTextbox.Location = new System.Drawing.Point(68, 607);
            this.numberTextbox.Name = "numberTextbox";
            this.numberTextbox.Size = new System.Drawing.Size(369, 22);
            this.numberTextbox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(64, 575);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "What The Contact Number?";
            // 
            // jobTextbox
            // 
            this.jobTextbox.Location = new System.Drawing.Point(68, 680);
            this.jobTextbox.Name = "jobTextbox";
            this.jobTextbox.Size = new System.Drawing.Size(369, 22);
            this.jobTextbox.TabIndex = 16;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label.Location = new System.Drawing.Point(64, 648);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(174, 20);
            this.label.TabIndex = 15;
            this.label.Text = "What About Job Title?";
            // 
            // companyTextbox
            // 
            this.companyTextbox.Location = new System.Drawing.Point(68, 751);
            this.companyTextbox.Name = "companyTextbox";
            this.companyTextbox.Size = new System.Drawing.Size(369, 22);
            this.companyTextbox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(64, 719);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Which Company?";
            // 
            // addBtn
            // 
            this.addBtn.AutoSize = true;
            this.addBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(164, 800);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(188, 53);
            this.addBtn.TabIndex = 19;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // hrSystemDataSet1
            // 
            this.hrSystemDataSet1.DataSetName = "HRSystemDataSet";
            this.hrSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.hrSystemDataSet1;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 545);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.companyTextbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.jobTextbox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.numberTextbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addressTextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ageTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.genderTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fullnameTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployee";
            this.Text = "Add Employee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hrSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TextBox fullnameTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox genderTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ageTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addressTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numberTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox jobTextbox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox companyTextbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button addBtn;
        private HRSystemDataSet hrSystemDataSet1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private HRSystemDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
    }
}