namespace Banking_Mini_Project_Raynard
{
    partial class LoanActivity
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
            this.label2 = new System.Windows.Forms.Label();
            this.loanTextBox = new System.Windows.Forms.TextBox();
            this.interestComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.dayComboBox = new System.Windows.Forms.ComboBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Loan Amount :";
            // 
            // loanTextBox
            // 
            this.loanTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanTextBox.Location = new System.Drawing.Point(35, 237);
            this.loanTextBox.Name = "loanTextBox";
            this.loanTextBox.Size = new System.Drawing.Size(116, 27);
            this.loanTextBox.TabIndex = 34;
            // 
            // interestComboBox
            // 
            this.interestComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestComboBox.FormattingEnabled = true;
            this.interestComboBox.Items.AddRange(new object[] {
            "6 Months Loan (Compound Interest Monthly 6%)",
            "9 Months Loan (Compound Interest Monthly 5.5%)",
            "12 Months Loan (Compound Interest Monthly 5%)"});
            this.interestComboBox.Location = new System.Drawing.Point(38, 136);
            this.interestComboBox.Name = "interestComboBox";
            this.interestComboBox.Size = new System.Drawing.Size(400, 28);
            this.interestComboBox.TabIndex = 35;
            this.interestComboBox.SelectedIndexChanged += new System.EventHandler(this.interestComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Interest Rate : ";
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.Location = new System.Drawing.Point(27, 431);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(92, 49);
            this.btBack.TabIndex = 37;
            this.btBack.Text = "Back To Main ";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btOk
            // 
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.Location = new System.Drawing.Point(166, 431);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(92, 49);
            this.btOk.TabIndex = 39;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 22);
            this.label3.TabIndex = 40;
            this.label3.Text = "Input Today\'s Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 22);
            this.label4.TabIndex = 41;
            this.label4.Text = "in MM/dd/yyyy";
            // 
            // monthComboBox
            // 
            this.monthComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "July",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.monthComboBox.Location = new System.Drawing.Point(27, 342);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(67, 28);
            this.monthComboBox.TabIndex = 42;
            // 
            // dayComboBox
            // 
            this.dayComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.IntegralHeight = false;
            this.dayComboBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayComboBox.Location = new System.Drawing.Point(100, 342);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.Size = new System.Drawing.Size(67, 28);
            this.dayComboBox.TabIndex = 43;
            // 
            // yearComboBox
            // 
            this.yearComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.IntegralHeight = false;
            this.yearComboBox.Items.AddRange(new object[] {
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930",
            "1929",
            "1928",
            "1927",
            "1926",
            "1925",
            "1924",
            "1923",
            "1922",
            "1921",
            "1920",
            "1919",
            "1918",
            "1917",
            "1916",
            "1915",
            "1914",
            "1913",
            "1912",
            "1911",
            "1910",
            "1909",
            "1908",
            "1907",
            "1906",
            "1905",
            "1904",
            "1903",
            "1902",
            "1901"});
            this.yearComboBox.Location = new System.Drawing.Point(173, 342);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(67, 28);
            this.yearComboBox.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 31);
            this.label5.TabIndex = 45;
            this.label5.Text = "Loan Page";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoanActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 511);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.dayComboBox);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.interestComboBox);
            this.Controls.Add(this.loanTextBox);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoanActivity";
            this.Text = "LoanActivity";
            this.Load += new System.EventHandler(this.LoanActivity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loanTextBox;
        private System.Windows.Forms.ComboBox interestComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.ComboBox dayComboBox;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.Label label5;
    }
}