namespace Banking_Mini_Project_Raynard
{
    partial class PaymentOfLoanActivity
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
            this.label4 = new System.Windows.Forms.Label();
            this.loanAmountLabel = new System.Windows.Forms.Label();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Amount Due : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loanAmountLabel
            // 
            this.loanAmountLabel.AutoSize = true;
            this.loanAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanAmountLabel.Location = new System.Drawing.Point(44, 104);
            this.loanAmountLabel.Name = "loanAmountLabel";
            this.loanAmountLabel.Size = new System.Drawing.Size(116, 22);
            this.loanAmountLabel.TabIndex = 12;
            this.loanAmountLabel.Text = "Loan Amount";
            this.loanAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTextBox.Location = new System.Drawing.Point(44, 182);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(116, 27);
            this.paymentTextBox.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Payment :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btOk
            // 
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.Location = new System.Drawing.Point(161, 310);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(92, 49);
            this.btOk.TabIndex = 40;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.Location = new System.Drawing.Point(44, 310);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(92, 49);
            this.btBack.TabIndex = 41;
            this.btBack.Text = "Back To Main ";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(216, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 31);
            this.label5.TabIndex = 46;
            this.label5.Text = "Payment Of Loan Page";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PaymentOfLoanActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paymentTextBox);
            this.Controls.Add(this.loanAmountLabel);
            this.Controls.Add(this.label4);
            this.Name = "PaymentOfLoanActivity";
            this.Text = "PaymentOfLoanActivity";
            this.Load += new System.EventHandler(this.PaymentOfLoanActivity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label loanAmountLabel;
        private System.Windows.Forms.TextBox paymentTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label label5;
    }
}