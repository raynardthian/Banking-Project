namespace Banking_Mini_Project_Raynard
{
    partial class DepositAndWithdrawActivity
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
            this.btBack = new System.Windows.Forms.Button();
            this.choiceComboBox = new System.Windows.Forms.ComboBox();
            this.btOk = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.transferTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.Location = new System.Drawing.Point(64, 373);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(92, 49);
            this.btBack.TabIndex = 24;
            this.btBack.Text = "Back To Main ";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // choiceComboBox
            // 
            this.choiceComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceComboBox.FormattingEnabled = true;
            this.choiceComboBox.Items.AddRange(new object[] {
            "Withdrawal",
            "Deposit",
            "Transfer"});
            this.choiceComboBox.Location = new System.Drawing.Point(60, 109);
            this.choiceComboBox.Name = "choiceComboBox";
            this.choiceComboBox.Size = new System.Drawing.Size(180, 28);
            this.choiceComboBox.TabIndex = 25;
            this.choiceComboBox.SelectedIndexChanged += new System.EventHandler(this.choiceComboBox_SelectedIndexChanged);
            // 
            // btOk
            // 
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.Location = new System.Drawing.Point(197, 373);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(92, 49);
            this.btOk.TabIndex = 28;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(56, 166);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(46, 22);
            this.questionLabel.TabIndex = 29;
            this.questionLabel.Text = "Text";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(60, 206);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(116, 27);
            this.inputTextBox.TabIndex = 30;
            // 
            // transferTextBox
            // 
            this.transferTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferTextBox.Location = new System.Drawing.Point(60, 287);
            this.transferTextBox.Name = "transferTextBox";
            this.transferTextBox.Size = new System.Drawing.Size(116, 27);
            this.transferTextBox.TabIndex = 31;
            this.transferTextBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "Transfer To :";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(414, 31);
            this.label3.TabIndex = 33;
            this.label3.Text = "Deposit/Withdrawl/Transfer Page";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DepositAndWithdrawActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.transferTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.choiceComboBox);
            this.Controls.Add(this.btBack);
            this.Name = "DepositAndWithdrawActivity";
            this.Text = "DepositAndWithdrawActivity";
            this.Load += new System.EventHandler(this.DepositAndWithdrawActivity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.ComboBox choiceComboBox;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox transferTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}