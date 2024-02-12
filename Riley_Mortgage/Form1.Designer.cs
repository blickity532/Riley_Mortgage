using System;

namespace Riley_Mortgage
{
    partial class frm_Mortgage_Calculator
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
            this.LBL_Principal = new System.Windows.Forms.Label();
            this.TXT_Principal = new System.Windows.Forms.TextBox();
            this.LBL_Term = new System.Windows.Forms.Label();
            this.RBO_15Year = new System.Windows.Forms.RadioButton();
            this.RBO_30Year = new System.Windows.Forms.RadioButton();
            this.RBO_Other = new System.Windows.Forms.RadioButton();
            this.LBL_Interest = new System.Windows.Forms.Label();
            this.CBX_Interest = new System.Windows.Forms.ComboBox();
            this.BTN_Calculate = new System.Windows.Forms.Button();
            this.BTN_Reset = new System.Windows.Forms.Button();
            this.BTN_Exit = new System.Windows.Forms.Button();
            this.TXT_Other = new System.Windows.Forms.TextBox();
            this.LBL_MonthlyPayment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBL_Principal
            // 
            this.LBL_Principal.AutoSize = true;
            this.LBL_Principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LBL_Principal.Location = new System.Drawing.Point(139, 98);
            this.LBL_Principal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Principal.Name = "LBL_Principal";
            this.LBL_Principal.Size = new System.Drawing.Size(86, 25);
            this.LBL_Principal.TabIndex = 0;
            this.LBL_Principal.Text = "Principal";
            // 
            // TXT_Principal
            // 
            this.TXT_Principal.Location = new System.Drawing.Point(280, 95);
            this.TXT_Principal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_Principal.Name = "TXT_Principal";
            this.TXT_Principal.Size = new System.Drawing.Size(231, 30);
            this.TXT_Principal.TabIndex = 1;
            // 
            // LBL_Term
            // 
            this.LBL_Term.AutoSize = true;
            this.LBL_Term.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LBL_Term.Location = new System.Drawing.Point(125, 162);
            this.LBL_Term.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Term.Name = "LBL_Term";
            this.LBL_Term.Size = new System.Drawing.Size(135, 25);
            this.LBL_Term.TabIndex = 2;
            this.LBL_Term.Text = "Term In Years";
            // 
            // RBO_15Year
            // 
            this.RBO_15Year.AutoSize = true;
            this.RBO_15Year.Location = new System.Drawing.Point(146, 216);
            this.RBO_15Year.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RBO_15Year.Name = "RBO_15Year";
            this.RBO_15Year.Size = new System.Drawing.Size(101, 29);
            this.RBO_15Year.TabIndex = 3;
            this.RBO_15Year.TabStop = true;
            this.RBO_15Year.Text = "15 Year";
            this.RBO_15Year.UseVisualStyleBackColor = true;
            this.RBO_15Year.Click += new System.EventHandler(this.TermChanged);
            // 
            // RBO_30Year
            // 
            this.RBO_30Year.AutoSize = true;
            this.RBO_30Year.Location = new System.Drawing.Point(146, 253);
            this.RBO_30Year.Name = "RBO_30Year";
            this.RBO_30Year.Size = new System.Drawing.Size(101, 29);
            this.RBO_30Year.TabIndex = 4;
            this.RBO_30Year.TabStop = true;
            this.RBO_30Year.Text = "30 Year";
            this.RBO_30Year.UseVisualStyleBackColor = true;
            this.RBO_30Year.Click += new System.EventHandler(this.TermChanged);
            // 
            // RBO_Other
            // 
            this.RBO_Other.AutoSize = true;
            this.RBO_Other.Location = new System.Drawing.Point(146, 288);
            this.RBO_Other.Name = "RBO_Other";
            this.RBO_Other.Size = new System.Drawing.Size(82, 29);
            this.RBO_Other.TabIndex = 5;
            this.RBO_Other.TabStop = true;
            this.RBO_Other.Text = "Other";
            this.RBO_Other.UseVisualStyleBackColor = true;
            this.RBO_Other.Click += new System.EventHandler(this.TermChanged);
            // 
            // LBL_Interest
            // 
            this.LBL_Interest.AutoSize = true;
            this.LBL_Interest.Location = new System.Drawing.Point(184, 365);
            this.LBL_Interest.Name = "LBL_Interest";
            this.LBL_Interest.Size = new System.Drawing.Size(76, 25);
            this.LBL_Interest.TabIndex = 6;
            this.LBL_Interest.Text = "Interest";
            // 
            // CBX_Interest
            // 
            this.CBX_Interest.FormattingEnabled = true;
            this.CBX_Interest.Items.AddRange(new object[] {
            "3.0",
            "3.1",
            "3.2",
            "3.3",
            "3.4",
            "3.5",
            "3.6",
            "3.7",
            "3.8",
            "3.9",
            "4.0",
            "4.1",
            "4.2",
            "4.3",
            "4.4",
            "4.5"});
            this.CBX_Interest.Location = new System.Drawing.Point(280, 357);
            this.CBX_Interest.Name = "CBX_Interest";
            this.CBX_Interest.Size = new System.Drawing.Size(54, 33);
            this.CBX_Interest.TabIndex = 7;
            // 
            // BTN_Calculate
            // 
            this.BTN_Calculate.Location = new System.Drawing.Point(204, 446);
            this.BTN_Calculate.Name = "BTN_Calculate";
            this.BTN_Calculate.Size = new System.Drawing.Size(235, 48);
            this.BTN_Calculate.TabIndex = 8;
            this.BTN_Calculate.Text = "Calculate Payment";
            this.BTN_Calculate.UseVisualStyleBackColor = true;
            this.BTN_Calculate.Click += new System.EventHandler(this.BTN_Calculate_Click);
            // 
            // BTN_Reset
            // 
            this.BTN_Reset.Location = new System.Drawing.Point(217, 558);
            this.BTN_Reset.Name = "BTN_Reset";
            this.BTN_Reset.Size = new System.Drawing.Size(75, 58);
            this.BTN_Reset.TabIndex = 9;
            this.BTN_Reset.Text = "Reset";
            this.BTN_Reset.UseVisualStyleBackColor = true;
            this.BTN_Reset.Click += new System.EventHandler(this.BTN_Reset_Click);
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.Location = new System.Drawing.Point(364, 560);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(75, 54);
            this.BTN_Exit.TabIndex = 10;
            this.BTN_Exit.Text = "Exit";
            this.BTN_Exit.UseVisualStyleBackColor = true;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            // 
            // TXT_Other
            // 
            this.TXT_Other.Location = new System.Drawing.Point(294, 288);
            this.TXT_Other.Name = "TXT_Other";
            this.TXT_Other.Size = new System.Drawing.Size(100, 30);
            this.TXT_Other.TabIndex = 11;
            // 
            // LBL_MonthlyPayment
            // 
            this.LBL_MonthlyPayment.AutoSize = true;
            this.LBL_MonthlyPayment.Location = new System.Drawing.Point(180, 406);
            this.LBL_MonthlyPayment.Name = "LBL_MonthlyPayment";
            this.LBL_MonthlyPayment.Size = new System.Drawing.Size(64, 25);
            this.LBL_MonthlyPayment.TabIndex = 12;
            this.LBL_MonthlyPayment.Text = "label1";
            // 
            // frm_Mortgage_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 911);
            this.Controls.Add(this.LBL_MonthlyPayment);
            this.Controls.Add(this.TXT_Other);
            this.Controls.Add(this.BTN_Exit);
            this.Controls.Add(this.BTN_Reset);
            this.Controls.Add(this.BTN_Calculate);
            this.Controls.Add(this.CBX_Interest);
            this.Controls.Add(this.LBL_Interest);
            this.Controls.Add(this.RBO_Other);
            this.Controls.Add(this.RBO_30Year);
            this.Controls.Add(this.RBO_15Year);
            this.Controls.Add(this.LBL_Term);
            this.Controls.Add(this.TXT_Principal);
            this.Controls.Add(this.LBL_Principal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Mortgage_Calculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_Mortgage_Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Principal;
        private System.Windows.Forms.TextBox TXT_Principal;
        private System.Windows.Forms.Label LBL_Term;
        private System.Windows.Forms.RadioButton RBO_15Year;
        private System.Windows.Forms.RadioButton RBO_30Year;
        private System.Windows.Forms.RadioButton RBO_Other;
        private System.Windows.Forms.Label LBL_Interest;
        private System.Windows.Forms.ComboBox CBX_Interest;
        private System.Windows.Forms.Button BTN_Calculate;
        private System.Windows.Forms.Button BTN_Reset;
        private System.Windows.Forms.Button BTN_Exit;
        private System.Windows.Forms.TextBox TXT_Other;
        private System.Windows.Forms.Label LBL_MonthlyPayment;
    }
}

