namespace TempConvert
{
    partial class frmTempConvert
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.cboConvert = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblK = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(162, 123);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(127, 20);
            this.txtInput.TabIndex = 15;
            this.txtInput.TextChanged += new System.EventHandler(this.cboConvert_SelectedIndexChanged);
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // cboConvert
            // 
            this.cboConvert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboConvert.FormattingEnabled = true;
            this.cboConvert.Items.AddRange(new object[] {
            "Fahrenheit",
            "Celsius",
            "Kelvin"});
            this.cboConvert.Location = new System.Drawing.Point(101, 152);
            this.cboConvert.Name = "cboConvert";
            this.cboConvert.Size = new System.Drawing.Size(188, 21);
            this.cboConvert.TabIndex = 17;
            this.cboConvert.SelectedIndexChanged += new System.EventHandler(this.cboConvert_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Beige;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(295, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "=";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblF
            // 
            this.lblF.BackColor = System.Drawing.Color.White;
            this.lblF.Location = new System.Drawing.Point(362, 123);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(100, 23);
            this.lblF.TabIndex = 18;
            this.lblF.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblC
            // 
            this.lblC.BackColor = System.Drawing.Color.White;
            this.lblC.Location = new System.Drawing.Point(362, 152);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(100, 23);
            this.lblC.TabIndex = 19;
            this.lblC.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblK
            // 
            this.lblK.BackColor = System.Drawing.Color.White;
            this.lblK.Location = new System.Drawing.Point(362, 187);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(100, 23);
            this.lblK.TabIndex = 20;
            this.lblK.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(481, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fahrenheit";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(481, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Celsius";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(481, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kelvin";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Input Degree Here:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 59);
            this.label1.TabIndex = 14;
            this.label1.Text = "Temperature Converter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTempConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 230);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.cboConvert);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "frmTempConvert";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmTempConvert_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTempConvert_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ComboBox cboConvert;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

