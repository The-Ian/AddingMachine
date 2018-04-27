namespace ArrayWork
{
    partial class Form1
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
            this.numberLB = new System.Windows.Forms.ListBox();
            this.numberEntryTB = new System.Windows.Forms.TextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.runningTotalLabel = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.subBtn = new System.Windows.Forms.Button();
            this.multiBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberLB
            // 
            this.numberLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLB.FormattingEnabled = true;
            this.numberLB.ItemHeight = 16;
            this.numberLB.Location = new System.Drawing.Point(12, 35);
            this.numberLB.Name = "numberLB";
            this.numberLB.Size = new System.Drawing.Size(234, 212);
            this.numberLB.TabIndex = 0;
            // 
            // numberEntryTB
            // 
            this.numberEntryTB.Location = new System.Drawing.Point(12, 253);
            this.numberEntryTB.Name = "numberEntryTB";
            this.numberEntryTB.Size = new System.Drawing.Size(234, 20);
            this.numberEntryTB.TabIndex = 1;
            this.numberEntryTB.Validating += new System.ComponentModel.CancelEventHandler(this.numberEntryTB_Validating);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.Tan;
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.Color.Firebrick;
            this.resetBtn.Location = new System.Drawing.Point(93, 290);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(55, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numeric History";
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.LightYellow;
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(303, 232);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(133, 41);
            this.totalLabel.TabIndex = 5;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // runningTotalLabel
            // 
            this.runningTotalLabel.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runningTotalLabel.Location = new System.Drawing.Point(326, 214);
            this.runningTotalLabel.Name = "runningTotalLabel";
            this.runningTotalLabel.Size = new System.Drawing.Size(113, 17);
            this.runningTotalLabel.TabIndex = 6;
            this.runningTotalLabel.Text = "Running Total";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.PapayaWhip;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.addBtn.Location = new System.Drawing.Point(326, 49);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(89, 23);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "&Addition";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // subBtn
            // 
            this.subBtn.BackColor = System.Drawing.Color.PapayaWhip;
            this.subBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.subBtn.Location = new System.Drawing.Point(326, 78);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(89, 23);
            this.subBtn.TabIndex = 8;
            this.subBtn.Text = "&Subtraction";
            this.subBtn.UseVisualStyleBackColor = false;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // multiBtn
            // 
            this.multiBtn.BackColor = System.Drawing.Color.PapayaWhip;
            this.multiBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.multiBtn.Location = new System.Drawing.Point(326, 107);
            this.multiBtn.Name = "multiBtn";
            this.multiBtn.Size = new System.Drawing.Size(89, 23);
            this.multiBtn.TabIndex = 9;
            this.multiBtn.Text = "&Multiplication";
            this.multiBtn.UseVisualStyleBackColor = false;
            this.multiBtn.Click += new System.EventHandler(this.multiBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.BackColor = System.Drawing.Color.PapayaWhip;
            this.divBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.divBtn.Location = new System.Drawing.Point(326, 136);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(89, 23);
            this.divBtn.TabIndex = 10;
            this.divBtn.Text = "&Division";
            this.divBtn.UseVisualStyleBackColor = false;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(332, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Operators";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(487, 325);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.multiBtn);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.runningTotalLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.numberEntryTB);
            this.Controls.Add(this.numberLB);
            this.Name = "Form1";
            this.Text = "Adding Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox numberLB;
        private System.Windows.Forms.TextBox numberEntryTB;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label runningTotalLabel;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.Button multiBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Label label5;
    }
}

