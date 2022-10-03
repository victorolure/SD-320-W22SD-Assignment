namespace Calculator
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
            this.NumZero = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.NumThree = new System.Windows.Forms.Button();
            this.NumOne = new System.Windows.Forms.Button();
            this.NumTwo = new System.Windows.Forms.Button();
            this.NumFive = new System.Windows.Forms.Button();
            this.NumFour = new System.Windows.Forms.Button();
            this.NumSix = new System.Windows.Forms.Button();
            this.NumEight = new System.Windows.Forms.Button();
            this.NumSeven = new System.Windows.Forms.Button();
            this.NumNine = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.ClearEntryButton = new System.Windows.Forms.Button();
            this.ResetValuesButton = new System.Windows.Forms.Button();
            this.CalcInput = new System.Windows.Forms.TextBox();
            this.CurrentOutput = new System.Windows.Forms.Label();
            this.BinaryButton = new System.Windows.Forms.Button();
            this.DecButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumZero
            // 
            this.NumZero.AccessibleDescription = "Number zero button";
            this.NumZero.AccessibleName = "Number zero button";
            this.NumZero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumZero.Location = new System.Drawing.Point(28, 764);
            this.NumZero.Name = "NumZero";
            this.NumZero.Size = new System.Drawing.Size(193, 120);
            this.NumZero.TabIndex = 0;
            this.NumZero.Text = "0";
            this.NumZero.UseVisualStyleBackColor = true;
            this.NumZero.Click += new System.EventHandler(this.button_Click);
            // 
            // EqualButton
            // 
            this.EqualButton.AccessibleDescription = "equal to operation";
            this.EqualButton.AccessibleName = "equal to operation";
            this.EqualButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EqualButton.Location = new System.Drawing.Point(464, 616);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(94, 85);
            this.EqualButton.TabIndex = 1;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = true;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.AccessibleDescription = "decimal point";
            this.DecimalButton.AccessibleName = "decimal point";
            this.DecimalButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DecimalButton.Location = new System.Drawing.Point(238, 764);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(96, 120);
            this.DecimalButton.TabIndex = 2;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = true;
            this.DecimalButton.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.AccessibleDescription = "addition operation";
            this.button2.AccessibleName = "addition operation";
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(351, 764);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 120);
            this.button2.TabIndex = 3;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.operation_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.AccessibleDescription = "subtraction operation";
            this.MinusButton.AccessibleName = "subtraction operation";
            this.MinusButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MinusButton.Location = new System.Drawing.Point(351, 616);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(96, 115);
            this.MinusButton.TabIndex = 4;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.operation_Click);
            // 
            // NumThree
            // 
            this.NumThree.AccessibleDescription = "Number three button";
            this.NumThree.AccessibleName = "Number three button";
            this.NumThree.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumThree.Location = new System.Drawing.Point(238, 616);
            this.NumThree.Name = "NumThree";
            this.NumThree.Size = new System.Drawing.Size(96, 115);
            this.NumThree.TabIndex = 5;
            this.NumThree.Text = "3";
            this.NumThree.UseVisualStyleBackColor = true;
            this.NumThree.Click += new System.EventHandler(this.button_Click);
            // 
            // NumOne
            // 
            this.NumOne.AccessibleDescription = "Number one button";
            this.NumOne.AccessibleName = "Number one button";
            this.NumOne.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumOne.Location = new System.Drawing.Point(28, 616);
            this.NumOne.Name = "NumOne";
            this.NumOne.Size = new System.Drawing.Size(84, 115);
            this.NumOne.TabIndex = 6;
            this.NumOne.Text = "1";
            this.NumOne.UseVisualStyleBackColor = true;
            this.NumOne.Click += new System.EventHandler(this.button_Click);
            // 
            // NumTwo
            // 
            this.NumTwo.AccessibleDescription = "Number two button";
            this.NumTwo.AccessibleName = "Number one button";
            this.NumTwo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumTwo.Location = new System.Drawing.Point(131, 616);
            this.NumTwo.Name = "NumTwo";
            this.NumTwo.Size = new System.Drawing.Size(90, 115);
            this.NumTwo.TabIndex = 7;
            this.NumTwo.Text = "2";
            this.NumTwo.UseVisualStyleBackColor = true;
            this.NumTwo.Click += new System.EventHandler(this.button_Click);
            // 
            // NumFive
            // 
            this.NumFive.AccessibleDescription = "Number five button";
            this.NumFive.AccessibleName = "Number five button";
            this.NumFive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumFive.Location = new System.Drawing.Point(131, 452);
            this.NumFive.Name = "NumFive";
            this.NumFive.Size = new System.Drawing.Size(90, 119);
            this.NumFive.TabIndex = 10;
            this.NumFive.Text = "5";
            this.NumFive.UseVisualStyleBackColor = true;
            this.NumFive.Click += new System.EventHandler(this.button_Click);
            // 
            // NumFour
            // 
            this.NumFour.AccessibleDescription = "Number four button";
            this.NumFour.AccessibleName = "Number four button";
            this.NumFour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumFour.Location = new System.Drawing.Point(28, 452);
            this.NumFour.Name = "NumFour";
            this.NumFour.Size = new System.Drawing.Size(84, 119);
            this.NumFour.TabIndex = 9;
            this.NumFour.Text = "4";
            this.NumFour.UseVisualStyleBackColor = true;
            this.NumFour.Click += new System.EventHandler(this.button_Click);
            // 
            // NumSix
            // 
            this.NumSix.AccessibleDescription = "Number six button";
            this.NumSix.AccessibleName = "Number six button";
            this.NumSix.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumSix.Location = new System.Drawing.Point(238, 452);
            this.NumSix.Name = "NumSix";
            this.NumSix.Size = new System.Drawing.Size(96, 119);
            this.NumSix.TabIndex = 8;
            this.NumSix.Text = "6";
            this.NumSix.UseVisualStyleBackColor = true;
            this.NumSix.Click += new System.EventHandler(this.button_Click);
            // 
            // NumEight
            // 
            this.NumEight.AccessibleDescription = "Number eight button";
            this.NumEight.AccessibleName = "Number eight button";
            this.NumEight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumEight.Location = new System.Drawing.Point(131, 294);
            this.NumEight.Name = "NumEight";
            this.NumEight.Size = new System.Drawing.Size(90, 115);
            this.NumEight.TabIndex = 13;
            this.NumEight.Text = "8";
            this.NumEight.UseVisualStyleBackColor = true;
            this.NumEight.Click += new System.EventHandler(this.button_Click);
            // 
            // NumSeven
            // 
            this.NumSeven.AccessibleDescription = "Number seven button";
            this.NumSeven.AccessibleName = "Number seven button";
            this.NumSeven.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumSeven.Location = new System.Drawing.Point(28, 294);
            this.NumSeven.Name = "NumSeven";
            this.NumSeven.Size = new System.Drawing.Size(84, 115);
            this.NumSeven.TabIndex = 12;
            this.NumSeven.Text = "7";
            this.NumSeven.UseVisualStyleBackColor = true;
            this.NumSeven.Click += new System.EventHandler(this.button_Click);
            // 
            // NumNine
            // 
            this.NumNine.AccessibleDescription = "Number nine button";
            this.NumNine.AccessibleName = "Number nine button";
            this.NumNine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumNine.Location = new System.Drawing.Point(238, 294);
            this.NumNine.Name = "NumNine";
            this.NumNine.Size = new System.Drawing.Size(96, 115);
            this.NumNine.TabIndex = 11;
            this.NumNine.Text = "9";
            this.NumNine.UseVisualStyleBackColor = true;
            this.NumNine.Click += new System.EventHandler(this.button_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.AccessibleDescription = "division operation";
            this.DivideButton.AccessibleName = "division operation";
            this.DivideButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DivideButton.Location = new System.Drawing.Point(351, 294);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(96, 115);
            this.DivideButton.TabIndex = 15;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.operation_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.AccessibleDescription = "multiply operation";
            this.MultiplyButton.AccessibleName = "multiply operation";
            this.MultiplyButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MultiplyButton.Location = new System.Drawing.Point(351, 452);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(96, 119);
            this.MultiplyButton.TabIndex = 14;
            this.MultiplyButton.Text = "x";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.operation_Click);
            // 
            // ClearEntryButton
            // 
            this.ClearEntryButton.AccessibleDescription = "clear textbox value";
            this.ClearEntryButton.AccessibleName = "clear textbox value";
            this.ClearEntryButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearEntryButton.Location = new System.Drawing.Point(464, 294);
            this.ClearEntryButton.Name = "ClearEntryButton";
            this.ClearEntryButton.Size = new System.Drawing.Size(94, 115);
            this.ClearEntryButton.TabIndex = 17;
            this.ClearEntryButton.Text = "CE";
            this.ClearEntryButton.UseVisualStyleBackColor = true;
            this.ClearEntryButton.Click += new System.EventHandler(this.clearValue_Click);
            // 
            // ResetValuesButton
            // 
            this.ResetValuesButton.AccessibleDescription = "clear all values";
            this.ResetValuesButton.AccessibleName = "clear all values";
            this.ResetValuesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetValuesButton.Location = new System.Drawing.Point(464, 452);
            this.ResetValuesButton.Name = "ResetValuesButton";
            this.ResetValuesButton.Size = new System.Drawing.Size(94, 119);
            this.ResetValuesButton.TabIndex = 16;
            this.ResetValuesButton.Text = "C";
            this.ResetValuesButton.UseVisualStyleBackColor = true;
            this.ResetValuesButton.Click += new System.EventHandler(this.clearValue_Click);
            // 
            // CalcInput
            // 
            this.CalcInput.AccessibleDescription = "number input textbox";
            this.CalcInput.AccessibleName = "number input form";
            this.CalcInput.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalcInput.Location = new System.Drawing.Point(28, 130);
            this.CalcInput.Multiline = true;
            this.CalcInput.Name = "CalcInput";
            this.CalcInput.Size = new System.Drawing.Size(519, 118);
            this.CalcInput.TabIndex = 18;
            this.CalcInput.Text = "0";
            this.CalcInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CurrentOutput
            // 
            this.CurrentOutput.AutoSize = true;
            this.CurrentOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CurrentOutput.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentOutput.Location = new System.Drawing.Point(447, 47);
            this.CurrentOutput.Name = "CurrentOutput";
            this.CurrentOutput.Size = new System.Drawing.Size(0, 50);
            this.CurrentOutput.TabIndex = 19;
            // 
            // BinaryButton
            // 
            this.BinaryButton.AccessibleDescription = "convert decimal to binary";
            this.BinaryButton.AccessibleName = "convert decimal to binary";
            this.BinaryButton.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BinaryButton.Location = new System.Drawing.Point(464, 720);
            this.BinaryButton.Name = "BinaryButton";
            this.BinaryButton.Size = new System.Drawing.Size(94, 74);
            this.BinaryButton.TabIndex = 20;
            this.BinaryButton.Text = "BIN";
            this.BinaryButton.UseVisualStyleBackColor = true;
            this.BinaryButton.Click += new System.EventHandler(this.BinaryButton_Click);
            // 
            // DecButton
            // 
            this.DecButton.AccessibleDescription = "convert binary to decimal";
            this.DecButton.AccessibleName = "convert binary to decimal";
            this.DecButton.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DecButton.Location = new System.Drawing.Point(464, 810);
            this.DecButton.Name = "DecButton";
            this.DecButton.Size = new System.Drawing.Size(94, 74);
            this.DecButton.TabIndex = 21;
            this.DecButton.Text = "DEC";
            this.DecButton.UseVisualStyleBackColor = true;
            this.DecButton.Click += new System.EventHandler(this.DecButton_Click);
            // 
            // Form1
            // 
            this.AccessibleDescription = "calculator application";
            this.AccessibleName = "calculator application";
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 907);
            this.Controls.Add(this.DecButton);
            this.Controls.Add(this.BinaryButton);
            this.Controls.Add(this.CurrentOutput);
            this.Controls.Add(this.CalcInput);
            this.Controls.Add(this.ClearEntryButton);
            this.Controls.Add(this.ResetValuesButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.NumEight);
            this.Controls.Add(this.NumSeven);
            this.Controls.Add(this.NumNine);
            this.Controls.Add(this.NumFive);
            this.Controls.Add(this.NumFour);
            this.Controls.Add(this.NumSix);
            this.Controls.Add(this.NumTwo);
            this.Controls.Add(this.NumOne);
            this.Controls.Add(this.NumThree);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DecimalButton);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.NumZero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button NumZero;
        private Button EqualButton;
        private Button DecimalButton;
        private Button button2;
        private Button MinusButton;
        private Button NumThree;
        private Button NumOne;
        private Button NumTwo;
        private Button NumFive;
        private Button NumFour;
        private Button NumSix;
        private Button NumEight;
        private Button NumSeven;
        private Button NumNine;
        private Button DivideButton;
        private Button MultiplyButton;
        private Button ClearEntryButton;
        private Button ResetValuesButton;
        private TextBox CalcInput;
        private Label CurrentOutput;
        private Button BinaryButton;
        private Button DecButton;
    }
}