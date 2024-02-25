namespace Banking_Mini_Project_Raynard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCustomer = new System.Windows.Forms.Button();
            this.btAdmin = new System.Windows.Forms.Button();
            this.btAdminRegister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btCustomerRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banking Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login Page";
            // 
            // btCustomer
            // 
            this.btCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCustomer.Location = new System.Drawing.Point(127, 158);
            this.btCustomer.Name = "btCustomer";
            this.btCustomer.Size = new System.Drawing.Size(137, 51);
            this.btCustomer.TabIndex = 2;
            this.btCustomer.Text = "Customer Login";
            this.btCustomer.UseVisualStyleBackColor = true;
            this.btCustomer.Click += new System.EventHandler(this.btCustomer_Click);
            // 
            // btAdmin
            // 
            this.btAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdmin.Location = new System.Drawing.Point(127, 251);
            this.btAdmin.Name = "btAdmin";
            this.btAdmin.Size = new System.Drawing.Size(137, 51);
            this.btAdmin.TabIndex = 3;
            this.btAdmin.Text = "Admin Login";
            this.btAdmin.UseVisualStyleBackColor = true;
            this.btAdmin.Click += new System.EventHandler(this.btAdmin_Click);
            // 
            // btAdminRegister
            // 
            this.btAdminRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdminRegister.Location = new System.Drawing.Point(284, 399);
            this.btAdminRegister.Name = "btAdminRegister";
            this.btAdminRegister.Size = new System.Drawing.Size(91, 36);
            this.btAdminRegister.TabIndex = 4;
            this.btAdminRegister.Text = "Admin";
            this.btAdminRegister.UseVisualStyleBackColor = true;
            this.btAdminRegister.Click += new System.EventHandler(this.btAdminRegister_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "New User? Register Here!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "New User? Register Here!";
            // 
            // btCustomerRegister
            // 
            this.btCustomerRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCustomerRegister.Location = new System.Drawing.Point(284, 357);
            this.btCustomerRegister.Name = "btCustomerRegister";
            this.btCustomerRegister.Size = new System.Drawing.Size(91, 36);
            this.btCustomerRegister.TabIndex = 6;
            this.btCustomerRegister.Text = "Customer";
            this.btCustomerRegister.UseVisualStyleBackColor = true;
            this.btCustomerRegister.Click += new System.EventHandler(this.btCustomerRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 478);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btCustomerRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btAdminRegister);
            this.Controls.Add(this.btAdmin);
            this.Controls.Add(this.btCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCustomer;
        private System.Windows.Forms.Button btAdmin;
        private System.Windows.Forms.Button btAdminRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCustomerRegister;
    }
}

