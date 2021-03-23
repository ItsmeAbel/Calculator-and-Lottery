namespace CSharpLab2
{
    partial class Calculator
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
            this.calcPanel1 = new System.Windows.Forms.Panel();
            this.PreviousInput = new System.Windows.Forms.Label();
            this.NumberInput = new System.Windows.Forms.TextBox();
            this.CalcPanel2 = new System.Windows.Forms.Panel();
            this.DevisionButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.MultiplicationButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.calcPanel1.SuspendLayout();
            this.CalcPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // calcPanel1
            // 
            this.calcPanel1.Controls.Add(this.PreviousInput);
            this.calcPanel1.Controls.Add(this.NumberInput);
            this.calcPanel1.Location = new System.Drawing.Point(7, 12);
            this.calcPanel1.Name = "calcPanel1";
            this.calcPanel1.Size = new System.Drawing.Size(407, 103);
            this.calcPanel1.TabIndex = 0;
            // 
            // PreviousInput
            // 
            this.PreviousInput.AutoSize = true;
            this.PreviousInput.Enabled = false;
            this.PreviousInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousInput.Location = new System.Drawing.Point(6, 0);
            this.PreviousInput.Name = "PreviousInput";
            this.PreviousInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PreviousInput.Size = new System.Drawing.Size(0, 46);
            this.PreviousInput.TabIndex = 1;
            // 
            // NumberInput
            // 
            this.NumberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberInput.Location = new System.Drawing.Point(6, 45);
            this.NumberInput.Name = "NumberInput";
            this.NumberInput.ReadOnly = true;
            this.NumberInput.Size = new System.Drawing.Size(393, 53);
            this.NumberInput.TabIndex = 0;
            this.NumberInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CalcPanel2
            // 
            this.CalcPanel2.Controls.Add(this.DevisionButton);
            this.CalcPanel2.Controls.Add(this.EqualsButton);
            this.CalcPanel2.Controls.Add(this.ZeroButton);
            this.CalcPanel2.Controls.Add(this.CButton);
            this.CalcPanel2.Controls.Add(this.MultiplicationButton);
            this.CalcPanel2.Controls.Add(this.NineButton);
            this.CalcPanel2.Controls.Add(this.EightButton);
            this.CalcPanel2.Controls.Add(this.SevenButton);
            this.CalcPanel2.Controls.Add(this.MinusButton);
            this.CalcPanel2.Controls.Add(this.SixButton);
            this.CalcPanel2.Controls.Add(this.FiveButton);
            this.CalcPanel2.Controls.Add(this.FourButton);
            this.CalcPanel2.Controls.Add(this.PlusButton);
            this.CalcPanel2.Controls.Add(this.ThreeButton);
            this.CalcPanel2.Controls.Add(this.TwoButton);
            this.CalcPanel2.Controls.Add(this.oneButton);
            this.CalcPanel2.Location = new System.Drawing.Point(8, 121);
            this.CalcPanel2.Name = "CalcPanel2";
            this.CalcPanel2.Size = new System.Drawing.Size(406, 454);
            this.CalcPanel2.TabIndex = 1;
            // 
            // DevisionButton
            // 
            this.DevisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevisionButton.Location = new System.Drawing.Point(326, 342);
            this.DevisionButton.Name = "DevisionButton";
            this.DevisionButton.Size = new System.Drawing.Size(72, 107);
            this.DevisionButton.TabIndex = 0;
            this.DevisionButton.Text = "/";
            this.DevisionButton.UseVisualStyleBackColor = true;
            this.DevisionButton.Click += new System.EventHandler(this.DevisionButton_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualsButton.Location = new System.Drawing.Point(221, 342);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(102, 107);
            this.EqualsButton.TabIndex = 0;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroButton.Location = new System.Drawing.Point(113, 342);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(102, 107);
            this.ZeroButton.TabIndex = 0;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // CButton
            // 
            this.CButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CButton.Location = new System.Drawing.Point(5, 342);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(102, 107);
            this.CButton.TabIndex = 0;
            this.CButton.Text = "c";
            this.CButton.UseVisualStyleBackColor = true;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplicationButton.Location = new System.Drawing.Point(326, 229);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(72, 107);
            this.MultiplicationButton.TabIndex = 0;
            this.MultiplicationButton.Text = "x";
            this.MultiplicationButton.UseVisualStyleBackColor = true;
            this.MultiplicationButton.Click += new System.EventHandler(this.MultiplicationButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineButton.Location = new System.Drawing.Point(221, 229);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(102, 107);
            this.NineButton.TabIndex = 0;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightButton.Location = new System.Drawing.Point(113, 229);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(102, 107);
            this.EightButton.TabIndex = 0;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenButton.Location = new System.Drawing.Point(5, 229);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(102, 107);
            this.SevenButton.TabIndex = 0;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusButton.Location = new System.Drawing.Point(326, 116);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(72, 107);
            this.MinusButton.TabIndex = 0;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixButton.Location = new System.Drawing.Point(221, 116);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(102, 107);
            this.SixButton.TabIndex = 0;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveButton.Location = new System.Drawing.Point(113, 116);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(102, 107);
            this.FiveButton.TabIndex = 0;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourButton.Location = new System.Drawing.Point(5, 116);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(102, 107);
            this.FourButton.TabIndex = 0;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusButton.Location = new System.Drawing.Point(326, 3);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(72, 107);
            this.PlusButton.TabIndex = 0;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeButton.Location = new System.Drawing.Point(221, 3);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(102, 107);
            this.ThreeButton.TabIndex = 0;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoButton.Location = new System.Drawing.Point(113, 3);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(102, 107);
            this.TwoButton.TabIndex = 0;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneButton.Location = new System.Drawing.Point(5, 3);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(102, 107);
            this.oneButton.TabIndex = 0;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(418, 578);
            this.Controls.Add(this.CalcPanel2);
            this.Controls.Add(this.calcPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(436, 625);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(436, 625);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.calcPanel1.ResumeLayout(false);
            this.calcPanel1.PerformLayout();
            this.CalcPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel calcPanel1;
        private System.Windows.Forms.TextBox NumberInput;
        private System.Windows.Forms.Panel CalcPanel2;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button DevisionButton;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button MultiplicationButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Label PreviousInput;
    }
}