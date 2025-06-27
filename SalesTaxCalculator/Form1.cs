using System;
using System.IO;
using System.Windows.Forms;

namespace SalesTaxCalculator
{
    public partial class Form1 : Form
    {
        private const string ExceptionFilePath = "Exceptionfile.txt";
        private const string TaxCalculationFilePath = "TaxCalculation.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amount = decimal.Parse(amountTextBox.Text);
                decimal taxRate = taxNumericUpDown.Value;
                decimal tax = amount * (taxRate / 100);
                decimal total = amount + tax;

                resultLabel.Text = $"Tax: R{tax}\nTotal: R{total}";

                SaveTaxCalculationToFile(DateTime.Now, amount, taxRate, tax, total);
            }
            catch (FormatException)
            {
                ShowExceptionMessage("Invalid input. Please enter a valid number.");
            }
            catch (Exception ex)
            {
                ShowExceptionMessage(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            amountTextBox.Clear();
        }

        private void ShowExceptionMessage(string message)
        {
            MessageBox.Show(message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            SaveExceptionToFile(message);
        }

        private void SaveExceptionToFile(string message)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(ExceptionFilePath, true))
                {
                    writer.WriteLine($"{DateTime.Now}: {message}");
                }
            }
            catch (Exception)
            {
                // Handle the exception if unable to save the exception to the file.
            }
        }

        private void SaveTaxCalculationToFile(DateTime dateTime, decimal amount, decimal taxRate, decimal tax, decimal total)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(TaxCalculationFilePath, true))
                {
                    writer.WriteLine($"Date/Time: {dateTime}");
                    writer.WriteLine($"Amount: R{amount}");
                    writer.WriteLine($"Tax Rate: {taxRate}%");
                    writer.WriteLine($"Tax: R{tax}");
                    writer.WriteLine($"Total: R{total}");
                    writer.WriteLine();
                }
            }
            catch (Exception)
            {
                // Handle the exception if unable to save the tax calculation to the file.
            }
        }

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void taxNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void submitButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                decimal amount = decimal.Parse(amountTextBox.Text);
                decimal taxRate = taxNumericUpDown.Value;
                decimal tax = amount * (taxRate / 100);
                decimal total = amount + tax;

                resultLabel.Text = $"Tax: R{tax}\nTotal: R{total}";

                SaveTaxCalculationToFile(DateTime.Now, amount, taxRate, tax, total);
            }
            catch (FormatException)
            {
                ShowExceptionMessage("Invalid input. Please enter a valid number.");
            }
            catch (Exception ex)
            {
                ShowExceptionMessage(ex.Message);
            }
        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            amountTextBox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
