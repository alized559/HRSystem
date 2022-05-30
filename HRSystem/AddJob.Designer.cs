namespace HRSystem
{
    partial class AddJob
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
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.workplaceTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.locationTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.typeTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.postBtn = new System.Windows.Forms.Button();
            this.hRSystemDataSet = new HRSystem.HRSystemDataSet();
            this.jobTableAdapter = new HRSystem.HRSystemDataSetTableAdapters.jobTableAdapter();
            this.jobBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.hRSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(0, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create a job";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleTextbox
            // 
            this.titleTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource1, "title", true));
            this.titleTextbox.Location = new System.Drawing.Point(84, 117);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(369, 22);
            this.titleTextbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(80, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lets Start With Job Title";
            // 
            // workplaceTextbox
            // 
            this.workplaceTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource1, "wrokplace_type", true));
            this.workplaceTextbox.Location = new System.Drawing.Point(84, 189);
            this.workplaceTextbox.Name = "workplaceTextbox";
            this.workplaceTextbox.Size = new System.Drawing.Size(369, 22);
            this.workplaceTextbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(80, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "What The Workplace Type?";
            // 
            // locationTextbox
            // 
            this.locationTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource1, "location", true));
            this.locationTextbox.Location = new System.Drawing.Point(84, 266);
            this.locationTextbox.Name = "locationTextbox";
            this.locationTextbox.Size = new System.Drawing.Size(369, 22);
            this.locationTextbox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(80, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "What The Location?";
            // 
            // typeTextbox
            // 
            this.typeTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource1, "type", true));
            this.typeTextbox.Location = new System.Drawing.Point(84, 341);
            this.typeTextbox.Name = "typeTextbox";
            this.typeTextbox.Size = new System.Drawing.Size(369, 22);
            this.typeTextbox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(80, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Full-time Or Part-time?";
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource1, "description", true));
            this.descriptionTextbox.Location = new System.Drawing.Point(84, 417);
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(369, 116);
            this.descriptionTextbox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(80, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "What About Description?";
            // 
            // postBtn
            // 
            this.postBtn.AutoSize = true;
            this.postBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.postBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.postBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.postBtn.ForeColor = System.Drawing.Color.White;
            this.postBtn.Location = new System.Drawing.Point(166, 554);
            this.postBtn.Name = "postBtn";
            this.postBtn.Size = new System.Drawing.Size(188, 53);
            this.postBtn.TabIndex = 20;
            this.postBtn.Text = "Post";
            this.postBtn.UseVisualStyleBackColor = false;
            this.postBtn.Click += new System.EventHandler(this.postBtn_Click);
            // 
            // hRSystemDataSet
            // 
            this.hRSystemDataSet.DataSetName = "HRSystemDataSet";
            this.hRSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // jobBindingSource1
            // 
            this.jobBindingSource1.DataMember = "job";
            this.jobBindingSource1.DataSource = this.hRSystemDataSet;
            // 
            // AddJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 631);
            this.Controls.Add(this.postBtn);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.typeTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.locationTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.workplaceTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.titleTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddJob";
            this.Text = "Add Job Post";
            this.Load += new System.EventHandler(this.AddJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hRSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox workplaceTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox locationTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox typeTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button postBtn;
        private HRSystemDataSet hRSystemDataSet;
        private HRSystemDataSetTableAdapters.jobTableAdapter jobTableAdapter;
        private System.Windows.Forms.BindingSource jobBindingSource1;
    }
}