using PhotoPrintCalculator;
using System;
using System.Windows.Forms;

namespace PhotoPrintWinForms
{
    public partial class MainForm : Form
    {
        private readonly PhotoPrintCalculator.PhotoPrintCalculator calculator;

        public MainForm()
        {
            InitializeComponent();
            calculator = new PhotoPrintCalculator.PhotoPrintCalculator();

            sizeComboBox.Items.AddRange(calculator.GetAvailableSizes());
            sizeComboBox.SelectedIndex = 0;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string size = sizeComboBox.SelectedItem.ToString();
                int quantity = (int)quantityNumericUpDown.Value;

                decimal cost = calculator.CalculateOrderCost(size, quantity);
                resultLabel.Text = $"Стоимость заказа: {cost} руб.";

                discountLabel.Visible = quantity > 20;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
