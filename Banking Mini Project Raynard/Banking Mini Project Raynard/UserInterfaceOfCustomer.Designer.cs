namespace Banking_Mini_Project_Raynard
{
    partial class UserInterfaceOfCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterfaceOfCustomer));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btLoan = new System.Windows.Forms.Button();
            this.depositAndWithdrawButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btProfile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btPayment = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Customer User Interface";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 44);
            this.label2.TabIndex = 7;
            this.label2.Text = "Deposit/Withdrawal\r\n/Transfer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btLoan
            // 
            this.btLoan.Image = ((System.Drawing.Image)(resources.GetObject("btLoan.Image")));
            this.btLoan.Location = new System.Drawing.Point(241, 84);
            this.btLoan.Name = "btLoan";
            this.btLoan.Size = new System.Drawing.Size(153, 69);
            this.btLoan.TabIndex = 9;
            this.btLoan.UseVisualStyleBackColor = true;
            this.btLoan.Click += new System.EventHandler(this.btLoan_Click);
            // 
            // depositAndWithdrawButton
            // 
            this.depositAndWithdrawButton.Image = ((System.Drawing.Image)(resources.GetObject("depositAndWithdrawButton.Image")));
            this.depositAndWithdrawButton.Location = new System.Drawing.Point(53, 84);
            this.depositAndWithdrawButton.Name = "depositAndWithdrawButton";
            this.depositAndWithdrawButton.Size = new System.Drawing.Size(153, 69);
            this.depositAndWithdrawButton.TabIndex = 8;
            this.depositAndWithdrawButton.UseVisualStyleBackColor = true;
            this.depositAndWithdrawButton.Click += new System.EventHandler(this.depositAndWithdrawButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(287, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Loan";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btProfile
            // 
            this.btProfile.Image = ((System.Drawing.Image)(resources.GetObject("btProfile.Image")));
            this.btProfile.Location = new System.Drawing.Point(667, 12);
            this.btProfile.Name = "btProfile";
            this.btProfile.Size = new System.Drawing.Size(94, 70);
            this.btProfile.TabIndex = 11;
            this.btProfile.UseVisualStyleBackColor = true;
            this.btProfile.Click += new System.EventHandler(this.btProfile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(685, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Profile";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btPayment
            // 
            this.btPayment.Image = ((System.Drawing.Image)(resources.GetObject("btPayment.Image")));
            this.btPayment.Location = new System.Drawing.Point(436, 84);
            this.btPayment.Name = "btPayment";
            this.btPayment.Size = new System.Drawing.Size(153, 69);
            this.btPayment.TabIndex = 13;
            this.btPayment.UseVisualStyleBackColor = true;
            this.btPayment.Click += new System.EventHandler(this.btPayment_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(440, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Payment Of Loan";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserInterfaceOfCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btPayment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btProfile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btLoan);
            this.Controls.Add(this.depositAndWithdrawButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "UserInterfaceOfCustomer";
            this.Text = "UserInterfaceOfCustomer";
            this.Load += new System.EventHandler(this.UserInterfaceOfCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button depositAndWithdrawButton;
        private System.Windows.Forms.Button btLoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btProfile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btPayment;
        private System.Windows.Forms.Label label6;
    }
}