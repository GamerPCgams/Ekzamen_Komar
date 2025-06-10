using BagetCalculator;
using System;
using System.Windows.Forms;

namespace BagetApp
{
    public partial class MainForm : Form
    {
        private readonly BagetCalculator.BagetPriceCalculator calculator;
        public MainForm()
        {
            InitializeComponent();
            calculator = new BagetPriceCalculator();

            manufacturerComboBox.DataSource = calculator.GetManufacturers();
            UpdateMaterials();
        }
        private void UpdateMaterials()
        {
            string selectedManufacturer = manufacturerComboBox.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedManufacturer))
            {
                materialComboBox.DataSource = calculator.GetMaterials(selectedManufacturer);
            }
        }

        private void manufacturerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMaterials();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal width = decimal.Parse(widthTextBox.Text);
                decimal height = decimal.Parse(heightTextBox.Text);
                string manufacturer = manufacturerComboBox.SelectedItem.ToString();
                string material = materialComboBox.SelectedItem.ToString();
                bool hasGlass = glassCheckBox.Checked;
                bool needsStretching = stretchingCheckBox.Checked;
                bool hasPaspartu = paspartuCheckBox.Checked;
                decimal paspartuWidth = hasPaspartu ? decimal.Parse(paspartuWidthTextBox.Text) : 0;

                decimal totalCost = calculator.Calculate(
                    width, height,
                    manufacturer, material,
                    hasGlass, needsStretching,
                    hasPaspartu, paspartuWidth);

                resultLabel.Text = $"Стоимость оформления: {totalCost:N2} руб.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка расчета", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void paspartuCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            paspartuWidthTextBox.Enabled = paspartuCheckBox.Checked;
            if (!paspartuCheckBox.Checked)
                paspartuWidthTextBox.Text = "5";
        }
    }
}
