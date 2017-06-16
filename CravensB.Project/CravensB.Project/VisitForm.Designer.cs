namespace CravensB.Project
{
    partial class VisitForm
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
            this.txtVisitId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVisitDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhysician = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVisitPatientId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddVisit = new System.Windows.Forms.Button();
            this.btnRemoveVisit = new System.Windows.Forms.Button();
            this.cboVisitDates = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearVisit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVisitId
            // 
            this.txtVisitId.Location = new System.Drawing.Point(101, 136);
            this.txtVisitId.Name = "txtVisitId";
            this.txtVisitId.Size = new System.Drawing.Size(123, 21);
            this.txtVisitId.TabIndex = 2;
            this.txtVisitId.TextChanged += new System.EventHandler(this.txtVisitId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Visit ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Visit Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtVisitDate
            // 
            this.txtVisitDate.Location = new System.Drawing.Point(101, 178);
            this.txtVisitDate.Name = "txtVisitDate";
            this.txtVisitDate.Size = new System.Drawing.Size(123, 21);
            this.txtVisitDate.TabIndex = 3;
            this.txtVisitDate.TextChanged += new System.EventHandler(this.txtVisitDate_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Location";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(101, 220);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(123, 21);
            this.txtLocation.TabIndex = 4;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Physician";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPhysician
            // 
            this.txtPhysician.Location = new System.Drawing.Point(101, 262);
            this.txtPhysician.Name = "txtPhysician";
            this.txtPhysician.Size = new System.Drawing.Size(123, 21);
            this.txtPhysician.TabIndex = 5;
            this.txtPhysician.TextChanged += new System.EventHandler(this.txtPhysician_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(101, 303);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(329, 21);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Description";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtVisitPatientId
            // 
            this.txtVisitPatientId.Location = new System.Drawing.Point(101, 99);
            this.txtVisitPatientId.Name = "txtVisitPatientId";
            this.txtVisitPatientId.Size = new System.Drawing.Size(123, 21);
            this.txtVisitPatientId.TabIndex = 1;
            this.txtVisitPatientId.TextChanged += new System.EventHandler(this.txtVisitPatientId_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Patient ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnAddVisit
            // 
            this.btnAddVisit.BackColor = System.Drawing.Color.Silver;
            this.btnAddVisit.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVisit.ForeColor = System.Drawing.Color.Black;
            this.btnAddVisit.Location = new System.Drawing.Point(298, 56);
            this.btnAddVisit.Name = "btnAddVisit";
            this.btnAddVisit.Size = new System.Drawing.Size(121, 31);
            this.btnAddVisit.TabIndex = 7;
            this.btnAddVisit.Text = "Add Visit";
            this.btnAddVisit.UseVisualStyleBackColor = false;
            this.btnAddVisit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemoveVisit
            // 
            this.btnRemoveVisit.BackColor = System.Drawing.Color.Silver;
            this.btnRemoveVisit.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveVisit.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveVisit.Location = new System.Drawing.Point(298, 93);
            this.btnRemoveVisit.Name = "btnRemoveVisit";
            this.btnRemoveVisit.Size = new System.Drawing.Size(121, 30);
            this.btnRemoveVisit.TabIndex = 8;
            this.btnRemoveVisit.Text = "Remove Visit";
            this.btnRemoveVisit.UseVisualStyleBackColor = false;
            this.btnRemoveVisit.Click += new System.EventHandler(this.btnRemoveVisit_Click);
            // 
            // cboVisitDates
            // 
            this.cboVisitDates.FormattingEnabled = true;
            this.cboVisitDates.Location = new System.Drawing.Point(101, 54);
            this.cboVisitDates.Name = "cboVisitDates";
            this.cboVisitDates.Size = new System.Drawing.Size(123, 23);
            this.cboVisitDates.TabIndex = 14;
            this.cboVisitDates.SelectedIndexChanged += new System.EventHandler(this.cboVisitDates_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Visit Dates";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(298, 255);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 28);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnClearVisit
            // 
            this.btnClearVisit.BackColor = System.Drawing.Color.Silver;
            this.btnClearVisit.Location = new System.Drawing.Point(298, 129);
            this.btnClearVisit.Name = "btnClearVisit";
            this.btnClearVisit.Size = new System.Drawing.Size(121, 32);
            this.btnClearVisit.TabIndex = 17;
            this.btnClearVisit.Text = "Clear Visit Info";
            this.btnClearVisit.UseVisualStyleBackColor = false;
            this.btnClearVisit.Click += new System.EventHandler(this.btnClearVisit_Click);
            // 
            // VisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(528, 513);
            this.Controls.Add(this.btnClearVisit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboVisitDates);
            this.Controls.Add(this.btnRemoveVisit);
            this.Controls.Add(this.btnAddVisit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVisitPatientId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPhysician);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVisitDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVisitId);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "VisitForm";
            this.Text = "VisitForm";
            this.Load += new System.EventHandler(this.VisitForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVisitId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVisitDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhysician;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVisitPatientId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddVisit;
        private System.Windows.Forms.Button btnRemoveVisit;
        private System.Windows.Forms.ComboBox cboVisitDates;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearVisit;
    }
}