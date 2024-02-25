namespace Banking_Mini_Project_Raynard
{
    partial class ReceiptActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptActivity));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.custUsernameLabel = new System.Windows.Forms.Label();
            this.transferAmountLabel = new System.Windows.Forms.Label();
            this.transferNameLabel = new System.Windows.Forms.Label();
            this.customerBankBalanceLabel = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Amount:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Transfer To";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Customer Username:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 44);
            this.label3.TabIndex = 14;
            this.label3.Text = "Customer Remaining \r\nBank Balance:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // custUsernameLabel
            // 
            this.custUsernameLabel.AutoSize = true;
            this.custUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custUsernameLabel.Location = new System.Drawing.Point(47, 84);
            this.custUsernameLabel.Name = "custUsernameLabel";
            this.custUsernameLabel.Size = new System.Drawing.Size(167, 22);
            this.custUsernameLabel.TabIndex = 15;
            this.custUsernameLabel.Text = "customer username";
            this.custUsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transferAmountLabel
            // 
            this.transferAmountLabel.AutoSize = true;
            this.transferAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferAmountLabel.Location = new System.Drawing.Point(47, 168);
            this.transferAmountLabel.Name = "transferAmountLabel";
            this.transferAmountLabel.Size = new System.Drawing.Size(135, 22);
            this.transferAmountLabel.TabIndex = 16;
            this.transferAmountLabel.Text = "transfer amount";
            this.transferAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transferNameLabel
            // 
            this.transferNameLabel.AutoSize = true;
            this.transferNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferNameLabel.Location = new System.Drawing.Point(47, 259);
            this.transferNameLabel.Name = "transferNameLabel";
            this.transferNameLabel.Size = new System.Drawing.Size(129, 22);
            this.transferNameLabel.TabIndex = 17;
            this.transferNameLabel.Text = "transfer to who";
            this.transferNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.transferNameLabel.Visible = false;
            // 
            // customerBankBalanceLabel
            // 
            this.customerBankBalanceLabel.AutoSize = true;
            this.customerBankBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBankBalanceLabel.Location = new System.Drawing.Point(304, 119);
            this.customerBankBalanceLabel.Name = "customerBankBalanceLabel";
            this.customerBankBalanceLabel.Size = new System.Drawing.Size(119, 22);
            this.customerBankBalanceLabel.TabIndex = 18;
            this.customerBankBalanceLabel.Text = "bank Balance";
            this.customerBankBalanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btPrint
            // 
            this.btPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.Location = new System.Drawing.Point(404, 220);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(97, 37);
            this.btPrint.TabIndex = 45;
            this.btPrint.Text = "Print";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // ReceiptActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 371);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.customerBankBalanceLabel);
            this.Controls.Add(this.transferNameLabel);
            this.Controls.Add(this.transferAmountLabel);
            this.Controls.Add(this.custUsernameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReceiptActivity";
            this.Text = "ReceiptActivity";
            this.Load += new System.EventHandler(this.ReceiptActivity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label custUsernameLabel;
        private System.Windows.Forms.Label transferAmountLabel;
        private System.Windows.Forms.Label transferNameLabel;
        private System.Windows.Forms.Label customerBankBalanceLabel;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btPrint;
    }
}