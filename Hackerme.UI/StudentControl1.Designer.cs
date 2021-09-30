
namespace Hackerme.UI
{
    partial class StudentControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSearchByLast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(137, 65);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(170, 27);
            this.txtFirst.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date of Birth:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(136, 103);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(171, 27);
            this.dtpDOB.TabIndex = 3;
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(136, 136);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(171, 28);
            this.cmbCity.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "City:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(544, 514);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(164, 402);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(205, 27);
            this.txtTerm.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search by First name";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(644, 514);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 29);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSearchByLast
            // 
            this.btnSearchByLast.Location = new System.Drawing.Point(164, 465);
            this.btnSearchByLast.Name = "btnSearchByLast";
            this.btnSearchByLast.Size = new System.Drawing.Size(203, 29);
            this.btnSearchByLast.TabIndex = 10;
            this.btnSearchByLast.Text = "Search by Last name";
            this.btnSearchByLast.UseVisualStyleBackColor = true;
            this.btnSearchByLast.Click += new System.EventHandler(this.btnSearchByLast_Click);
            // 
            // StudentControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.btnSearchByLast);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.label1);
            this.Name = "StudentControl1";
            this.Size = new System.Drawing.Size(910, 546);
            this.Load += new System.EventHandler(this.StudentControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSearchByLast;
    }
}
