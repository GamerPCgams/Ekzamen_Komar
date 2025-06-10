namespace PhotoPrintWinForms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.sizeLabel = new System.Windows.Forms.Label();
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();

            // sizeLabel
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(20, 20);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(83, 13);
            this.sizeLabel.TabIndex = 0;
            this.sizeLabel.Text = "Размер фото:";

            // sizeComboBox
            this.sizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeComboBox.FormattingEnabled = true;
            this.sizeComboBox.Location = new System.Drawing.Point(120, 17);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(150, 21);
            this.sizeComboBox.TabIndex = 1;

            // quantityLabel
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(20, 50);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(69, 13);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "Количество:";

            // quantityNumericUpDown
            this.quantityNumericUpDown.Location = new System.Drawing.Point(120, 48);
            this.quantityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(150, 20);
            this.quantityNumericUpDown.TabIndex = 3;
            this.quantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});

            // calculateButton
            this.calculateButton.Location = new System.Drawing.Point(120, 80);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(150, 30);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Рассчитать стоимость";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);

            // resultLabel
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(20, 130);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 17);
            this.resultLabel.TabIndex = 5;

            // discountLabel
            this.discountLabel.AutoSize = true;
            this.discountLabel.ForeColor = System.Drawing.Color.Green;
            this.discountLabel.Location = new System.Drawing.Point(20, 160);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(250, 13);
            this.discountLabel.TabIndex = 6;
            this.discountLabel.Text = "Применена скидка 10% за заказ более 20 фото";
            this.discountLabel.Visible = false;

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.sizeComboBox);
            this.Controls.Add(this.sizeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фото печать";
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.ComboBox sizeComboBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label discountLabel;
    }
}
