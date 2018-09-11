namespace DbConnection
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.empId = new System.Windows.Forms.TextBox();
            this.empName = new System.Windows.Forms.TextBox();
            this.empAge = new System.Windows.Forms.TextBox();
            this.empSalary = new System.Windows.Forms.TextBox();
            this.empDpt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Department";
            // 
            // empId
            // 
            this.empId.Location = new System.Drawing.Point(171, 44);
            this.empId.Name = "empId";
            this.empId.Size = new System.Drawing.Size(100, 20);
            this.empId.TabIndex = 5;
            this.empId.TextChanged += new System.EventHandler(this.empId_TextChanged);
            // 
            // empName
            // 
            this.empName.Location = new System.Drawing.Point(171, 82);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(100, 20);
            this.empName.TabIndex = 6;
            // 
            // empAge
            // 
            this.empAge.Location = new System.Drawing.Point(171, 119);
            this.empAge.Name = "empAge";
            this.empAge.Size = new System.Drawing.Size(100, 20);
            this.empAge.TabIndex = 7;
            // 
            // empSalary
            // 
            this.empSalary.Location = new System.Drawing.Point(171, 157);
            this.empSalary.Name = "empSalary";
            this.empSalary.Size = new System.Drawing.Size(100, 20);
            this.empSalary.TabIndex = 8;
            // 
            // empDpt
            // 
            this.empDpt.Location = new System.Drawing.Point(171, 192);
            this.empDpt.Name = "empDpt";
            this.empDpt.Size = new System.Drawing.Size(100, 20);
            this.empDpt.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 372);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.empDpt);
            this.Controls.Add(this.empSalary);
            this.Controls.Add(this.empAge);
            this.Controls.Add(this.empName);
            this.Controls.Add(this.empId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox empId;
        private System.Windows.Forms.TextBox empName;
        private System.Windows.Forms.TextBox empAge;
        private System.Windows.Forms.TextBox empSalary;
        private System.Windows.Forms.TextBox empDpt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}