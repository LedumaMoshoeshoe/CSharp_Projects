using System;

namespace SalesTaxCalculator
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
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.taxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultLabel1 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.taxNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(451, 59);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(250, 20);
            this.amountTextBox.TabIndex = 0;
            this.amountTextBox.TextChanged += new System.EventHandler(this.amountTextBox_TextChanged);
            // 
            // taxNumericUpDown
            // 
            this.taxNumericUpDown.Location = new System.Drawing.Point(451, 117);
            this.taxNumericUpDown.Name = "taxNumericUpDown";
            this.taxNumericUpDown.Size = new System.Drawing.Size(250, 20);
            this.taxNumericUpDown.TabIndex = 1;
            this.taxNumericUpDown.ValueChanged += new System.EventHandler(this.taxNumericUpDown_ValueChanged);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(158, 65);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(72, 13);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "Sales Amount";
            // 
            // resultLabel1
            // 
            this.resultLabel1.AutoSize = true;
            this.resultLabel1.Location = new System.Drawing.Point(158, 124);
            this.resultLabel1.Name = "resultLabel1";
            this.resultLabel1.Size = new System.Drawing.Size(54, 13);
            this.resultLabel1.TabIndex = 3;
            this.resultLabel1.Text = "Sales Tax";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(451, 195);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click_1);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(549, 194);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(646, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.resultLabel1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.taxNumericUpDown);
            this.Controls.Add(this.amountTextBox);
            this.Name = "Form1";
            this.Text = "SalesTaxCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.taxNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.NumericUpDown taxNumericUpDown;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label resultLabel1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button button3;

    }
}

