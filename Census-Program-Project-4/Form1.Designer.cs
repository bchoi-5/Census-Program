namespace Census_Program_Project_4
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
            System.Windows.Forms.Label lblOutput;
            this.txtNumOfBathrooms = new System.Windows.Forms.TextBox();
            this.txtNumOfPersons = new System.Windows.Forms.TextBox();
            this.txtHouseholdIncome = new System.Windows.Forms.TextBox();
            this.txtAvgNumBaths = new System.Windows.Forms.TextBox();
            this.txtAvgNumPersons = new System.Windows.Forms.TextBox();
            this.txtAvgHouseholdIncome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbOutputList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHouseTen = new System.Windows.Forms.Button();
            this.btnHouseNine = new System.Windows.Forms.Button();
            this.btnHouseEight = new System.Windows.Forms.Button();
            this.btnHouseSeven = new System.Windows.Forms.Button();
            this.btnHouseSix = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHouseFive = new System.Windows.Forms.Button();
            this.btnHouseFour = new System.Windows.Forms.Button();
            this.btnHouseThree = new System.Windows.Forms.Button();
            this.btnHouseTwo = new System.Windows.Forms.Button();
            this.btnHouseOne = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            lblOutput = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblOutput.Location = new System.Drawing.Point(140, 100);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new System.Drawing.Size(127, 22);
            lblOutput.TabIndex = 43;
            lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumOfBathrooms
            // 
            this.txtNumOfBathrooms.Location = new System.Drawing.Point(449, 59);
            this.txtNumOfBathrooms.Name = "txtNumOfBathrooms";
            this.txtNumOfBathrooms.Size = new System.Drawing.Size(100, 20);
            this.txtNumOfBathrooms.TabIndex = 0;
            this.txtNumOfBathrooms.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNumOfPersons
            // 
            this.txtNumOfPersons.Location = new System.Drawing.Point(449, 127);
            this.txtNumOfPersons.Name = "txtNumOfPersons";
            this.txtNumOfPersons.Size = new System.Drawing.Size(100, 20);
            this.txtNumOfPersons.TabIndex = 1;
            // 
            // txtHouseholdIncome
            // 
            this.txtHouseholdIncome.Location = new System.Drawing.Point(452, 190);
            this.txtHouseholdIncome.Name = "txtHouseholdIncome";
            this.txtHouseholdIncome.Size = new System.Drawing.Size(100, 20);
            this.txtHouseholdIncome.TabIndex = 2;
            // 
            // txtAvgNumBaths
            // 
            this.txtAvgNumBaths.Location = new System.Drawing.Point(449, 302);
            this.txtAvgNumBaths.Name = "txtAvgNumBaths";
            this.txtAvgNumBaths.ReadOnly = true;
            this.txtAvgNumBaths.Size = new System.Drawing.Size(100, 20);
            this.txtAvgNumBaths.TabIndex = 5;
            // 
            // txtAvgNumPersons
            // 
            this.txtAvgNumPersons.Location = new System.Drawing.Point(449, 356);
            this.txtAvgNumPersons.Name = "txtAvgNumPersons";
            this.txtAvgNumPersons.ReadOnly = true;
            this.txtAvgNumPersons.Size = new System.Drawing.Size(100, 20);
            this.txtAvgNumPersons.TabIndex = 6;
            // 
            // txtAvgHouseholdIncome
            // 
            this.txtAvgHouseholdIncome.Location = new System.Drawing.Point(449, 415);
            this.txtAvgHouseholdIncome.Name = "txtAvgHouseholdIncome";
            this.txtAvgHouseholdIncome.ReadOnly = true;
            this.txtAvgHouseholdIncome.Size = new System.Drawing.Size(100, 20);
            this.txtAvgHouseholdIncome.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(446, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "No. of bathrooms";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(449, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "No. of persons";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(449, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Household Income";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(446, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Avg No of bathrooms";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(446, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Avg No of persons";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(446, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Avg Household Income";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbOutputList
            // 
            this.lbOutputList.FormattingEnabled = true;
            this.lbOutputList.Location = new System.Drawing.Point(15, 275);
            this.lbOutputList.Name = "lbOutputList";
            this.lbOutputList.Size = new System.Drawing.Size(413, 173);
            this.lbOutputList.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHouseTen);
            this.groupBox1.Controls.Add(this.btnHouseNine);
            this.groupBox1.Controls.Add(this.btnHouseEight);
            this.groupBox1.Controls.Add(this.btnHouseSeven);
            this.groupBox1.Controls.Add(this.btnHouseSix);
            this.groupBox1.Controls.Add(lblOutput);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnHouseFive);
            this.groupBox1.Controls.Add(this.btnHouseFour);
            this.groupBox1.Controls.Add(this.btnHouseThree);
            this.groupBox1.Controls.Add(this.btnHouseTwo);
            this.groupBox1.Controls.Add(this.btnHouseOne);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 222);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnHouseTen
            // 
            this.btnHouseTen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHouseTen.Location = new System.Drawing.Point(313, 167);
            this.btnHouseTen.Name = "btnHouseTen";
            this.btnHouseTen.Size = new System.Drawing.Size(76, 40);
            this.btnHouseTen.TabIndex = 11;
            this.btnHouseTen.Text = "House 10";
            this.btnHouseTen.UseVisualStyleBackColor = false;
            this.btnHouseTen.Click += new System.EventHandler(this.btnHouseTen_Click);
            // 
            // btnHouseNine
            // 
            this.btnHouseNine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHouseNine.Location = new System.Drawing.Point(240, 165);
            this.btnHouseNine.Name = "btnHouseNine";
            this.btnHouseNine.Size = new System.Drawing.Size(67, 42);
            this.btnHouseNine.TabIndex = 10;
            this.btnHouseNine.Text = "House 9";
            this.btnHouseNine.UseVisualStyleBackColor = false;
            this.btnHouseNine.Click += new System.EventHandler(this.btnHouseNine_Click);
            // 
            // btnHouseEight
            // 
            this.btnHouseEight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHouseEight.Location = new System.Drawing.Point(167, 165);
            this.btnHouseEight.Name = "btnHouseEight";
            this.btnHouseEight.Size = new System.Drawing.Size(67, 42);
            this.btnHouseEight.TabIndex = 9;
            this.btnHouseEight.Text = "House 8";
            this.btnHouseEight.UseVisualStyleBackColor = false;
            this.btnHouseEight.Click += new System.EventHandler(this.btnHouseEight_Click);
            // 
            // btnHouseSeven
            // 
            this.btnHouseSeven.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHouseSeven.Location = new System.Drawing.Point(94, 165);
            this.btnHouseSeven.Name = "btnHouseSeven";
            this.btnHouseSeven.Size = new System.Drawing.Size(67, 42);
            this.btnHouseSeven.TabIndex = 8;
            this.btnHouseSeven.Text = "House 7";
            this.btnHouseSeven.UseVisualStyleBackColor = false;
            this.btnHouseSeven.Click += new System.EventHandler(this.btnHouseSeven_Click);
            // 
            // btnHouseSix
            // 
            this.btnHouseSix.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHouseSix.Location = new System.Drawing.Point(21, 165);
            this.btnHouseSix.Name = "btnHouseSix";
            this.btnHouseSix.Size = new System.Drawing.Size(67, 42);
            this.btnHouseSix.TabIndex = 7;
            this.btnHouseSix.Text = "House 6";
            this.btnHouseSix.UseVisualStyleBackColor = false;
            this.btnHouseSix.Click += new System.EventHandler(this.btnHouseSix_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(288, 95);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 32);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(21, 95);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 32);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnHouseFive
            // 
            this.btnHouseFive.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHouseFive.Location = new System.Drawing.Point(313, 21);
            this.btnHouseFive.Name = "btnHouseFive";
            this.btnHouseFive.Size = new System.Drawing.Size(76, 40);
            this.btnHouseFive.TabIndex = 4;
            this.btnHouseFive.Text = "House 5";
            this.btnHouseFive.UseVisualStyleBackColor = false;
            this.btnHouseFive.Click += new System.EventHandler(this.btnHouseFive_Click);
            // 
            // btnHouseFour
            // 
            this.btnHouseFour.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHouseFour.Location = new System.Drawing.Point(240, 19);
            this.btnHouseFour.Name = "btnHouseFour";
            this.btnHouseFour.Size = new System.Drawing.Size(67, 42);
            this.btnHouseFour.TabIndex = 3;
            this.btnHouseFour.Text = "House  4";
            this.btnHouseFour.UseVisualStyleBackColor = false;
            this.btnHouseFour.Click += new System.EventHandler(this.btnHouseFour_Click);
            // 
            // btnHouseThree
            // 
            this.btnHouseThree.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHouseThree.Location = new System.Drawing.Point(167, 19);
            this.btnHouseThree.Name = "btnHouseThree";
            this.btnHouseThree.Size = new System.Drawing.Size(67, 42);
            this.btnHouseThree.TabIndex = 2;
            this.btnHouseThree.Text = "House 3";
            this.btnHouseThree.UseVisualStyleBackColor = false;
            this.btnHouseThree.Click += new System.EventHandler(this.btnHouseThree_Click);
            // 
            // btnHouseTwo
            // 
            this.btnHouseTwo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHouseTwo.Location = new System.Drawing.Point(94, 19);
            this.btnHouseTwo.Name = "btnHouseTwo";
            this.btnHouseTwo.Size = new System.Drawing.Size(67, 42);
            this.btnHouseTwo.TabIndex = 1;
            this.btnHouseTwo.Text = "House 2";
            this.btnHouseTwo.UseVisualStyleBackColor = false;
            this.btnHouseTwo.Click += new System.EventHandler(this.btnHouseTwo_Click);
            // 
            // btnHouseOne
            // 
            this.btnHouseOne.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHouseOne.Location = new System.Drawing.Point(21, 19);
            this.btnHouseOne.Name = "btnHouseOne";
            this.btnHouseOne.Size = new System.Drawing.Size(67, 42);
            this.btnHouseOne.TabIndex = 0;
            this.btnHouseOne.Text = "House 1";
            this.btnHouseOne.UseVisualStyleBackColor = false;
            this.btnHouseOne.Click += new System.EventHandler(this.btnHouseOne_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(23, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 10);
            this.label2.TabIndex = 29;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 10);
            this.label1.TabIndex = 28;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(539, 10);
            this.label3.TabIndex = 30;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 472);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbOutputList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAvgHouseholdIncome);
            this.Controls.Add(this.txtAvgNumPersons);
            this.Controls.Add(this.txtAvgNumBaths);
            this.Controls.Add(this.txtHouseholdIncome);
            this.Controls.Add(this.txtNumOfPersons);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumOfBathrooms);
            this.Name = "Form1";
            this.Text = "Census Avenue";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumOfBathrooms;
        private System.Windows.Forms.TextBox txtNumOfPersons;
        private System.Windows.Forms.TextBox txtHouseholdIncome;
        private System.Windows.Forms.TextBox txtAvgNumBaths;
        private System.Windows.Forms.TextBox txtAvgNumPersons;
        private System.Windows.Forms.TextBox txtAvgHouseholdIncome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lbOutputList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHouseTen;
        private System.Windows.Forms.Button btnHouseNine;
        private System.Windows.Forms.Button btnHouseEight;
        private System.Windows.Forms.Button btnHouseSeven;
        private System.Windows.Forms.Button btnHouseSix;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnHouseFive;
        private System.Windows.Forms.Button btnHouseFour;
        private System.Windows.Forms.Button btnHouseThree;
        private System.Windows.Forms.Button btnHouseTwo;
        private System.Windows.Forms.Button btnHouseOne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

