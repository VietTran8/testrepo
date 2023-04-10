namespace Lab08
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadEx = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSymbol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txbAmout = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDateEx = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.dgvRateData = new System.Windows.Forms.DataGridView();
            this.cbSym = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRateData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSym);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnLoadEx);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbSymbol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Exchange Rate Data";
            // 
            // btnLoadEx
            // 
            this.btnLoadEx.Location = new System.Drawing.Point(313, 71);
            this.btnLoadEx.Name = "btnLoadEx";
            this.btnLoadEx.Size = new System.Drawing.Size(189, 34);
            this.btnLoadEx.TabIndex = 7;
            this.btnLoadEx.Text = "Load exchange rate";
            this.btnLoadEx.UseVisualStyleBackColor = true;
            this.btnLoadEx.Click += new System.EventHandler(this.btnLoadEx_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(18, 199);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(295, 31);
            this.dtpDate.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date";
            // 
            // cbSymbol
            // 
            this.cbSymbol.FormattingEnabled = true;
            this.cbSymbol.Location = new System.Drawing.Point(18, 126);
            this.cbSymbol.Name = "cbSymbol";
            this.cbSymbol.Size = new System.Drawing.Size(208, 33);
            this.cbSymbol.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Base";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txbResult);
            this.groupBox2.Controls.Add(this.btnConvert);
            this.groupBox2.Controls.Add(this.txbAmout);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpDateEx);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbTo);
            this.groupBox2.Controls.Add(this.cbFrom);
            this.groupBox2.Location = new System.Drawing.Point(540, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 669);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exchange Rate Conversion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Result";
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(26, 515);
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(353, 31);
            this.txbResult.TabIndex = 13;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(26, 423);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(133, 34);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txbAmout
            // 
            this.txbAmout.Location = new System.Drawing.Point(26, 351);
            this.txbAmout.Name = "txbAmout";
            this.txbAmout.Size = new System.Drawing.Size(353, 31);
            this.txbAmout.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Amout";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = " Date of rate";
            // 
            // dtpDateEx
            // 
            this.dtpDateEx.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateEx.Location = new System.Drawing.Point(26, 256);
            this.dtpDateEx.Name = "dtpDateEx";
            this.dtpDateEx.Size = new System.Drawing.Size(353, 31);
            this.dtpDateEx.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "From";
            // 
            // cbTo
            // 
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Location = new System.Drawing.Point(26, 162);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(353, 33);
            this.cbTo.TabIndex = 9;
            // 
            // cbFrom
            // 
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Location = new System.Drawing.Point(26, 73);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(353, 33);
            this.cbFrom.TabIndex = 8;
            // 
            // dgvRateData
            // 
            this.dgvRateData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRateData.Location = new System.Drawing.Point(12, 256);
            this.dgvRateData.Name = "dgvRateData";
            this.dgvRateData.RowHeadersWidth = 62;
            this.dgvRateData.RowTemplate.Height = 33;
            this.dgvRateData.Size = new System.Drawing.Size(522, 413);
            this.dgvRateData.TabIndex = 2;
            // 
            // cbSym
            // 
            this.cbSym.FormattingEnabled = true;
            this.cbSym.Location = new System.Drawing.Point(18, 60);
            this.cbSym.Name = "cbSym";
            this.cbSym.Size = new System.Drawing.Size(208, 33);
            this.cbSym.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Symbol";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 681);
            this.Controls.Add(this.dgvRateData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRateData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnLoadEx;
        private DateTimePicker dtpDate;
        private Label label2;
        private ComboBox cbSymbol;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txbResult;
        private Button btnConvert;
        private TextBox txbAmout;
        private Label label6;
        private Label label5;
        private DateTimePicker dtpDateEx;
        private Label label4;
        private Label label3;
        private ComboBox cbTo;
        private ComboBox cbFrom;
        private DataGridView dgvRateData;
        private Label label7;
        private ComboBox cbSym;
        private Label label8;
    }
}