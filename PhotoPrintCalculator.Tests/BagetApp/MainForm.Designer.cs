namespace BagetApp
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
            this.sizeGroupBox = new System.Windows.Forms.GroupBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.bagetGroupBox = new System.Windows.Forms.GroupBox();
            this.materialLabel = new System.Windows.Forms.Label();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.manufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.paspartuWidthTextBox = new System.Windows.Forms.TextBox();
            this.paspartuWidthLabel = new System.Windows.Forms.Label();
            this.paspartuCheckBox = new System.Windows.Forms.CheckBox();
            this.stretchingCheckBox = new System.Windows.Forms.CheckBox();
            this.glassCheckBox = new System.Windows.Forms.CheckBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.sizeGroupBox.SuspendLayout();
            this.bagetGroupBox.SuspendLayout();
            this.optionsGroupBox.SuspendLayout();
            this.SuspendLayout();

            // sizeGroupBox
            this.sizeGroupBox.Controls.Add(this.heightLabel);
            this.sizeGroupBox.Controls.Add(this.widthLabel);
            this.sizeGroupBox.Controls.Add(this.heightTextBox);
            this.sizeGroupBox.Controls.Add(this.widthTextBox);
            this.sizeGroupBox.Location = new System.Drawing.Point(20, 20);
            this.sizeGroupBox.Name = "sizeGroupBox";
            this.sizeGroupBox.Size = new System.Drawing.Size(300, 100);
            this.sizeGroupBox.TabIndex = 0;
            this.sizeGroupBox.TabStop = false;
            this.sizeGroupBox.Text = "Размер работы (см)";

            // heightLabel
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(160, 30);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(48, 13);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "Высота:";

            // widthLabel
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(20, 30);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(49, 13);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Ширина:";

            // heightTextBox
            this.heightTextBox.Location = new System.Drawing.Point(160, 50);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 1;
            this.heightTextBox.Text = "50";

            // widthTextBox
            this.widthTextBox.Location = new System.Drawing.Point(20, 50);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 0;
            this.widthTextBox.Text = "40";

            // bagetGroupBox
            this.bagetGroupBox.Controls.Add(this.materialLabel);
            this.bagetGroupBox.Controls.Add(this.materialComboBox);
            this.bagetGroupBox.Controls.Add(this.manufacturerLabel);
            this.bagetGroupBox.Controls.Add(this.manufacturerComboBox);
            this.bagetGroupBox.Location = new System.Drawing.Point(20, 130);
            this.bagetGroupBox.Name = "bagetGroupBox";
            this.bagetGroupBox.Size = new System.Drawing.Size(300, 100);
            this.bagetGroupBox.TabIndex = 1;
            this.bagetGroupBox.TabStop = false;
            this.bagetGroupBox.Text = "Багет";

            // materialLabel
            this.materialLabel.AutoSize = true;
            this.materialLabel.Location = new System.Drawing.Point(160, 30);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(60, 13);
            this.materialLabel.TabIndex = 3;
            this.materialLabel.Text = "Материал:";

            // materialComboBox
            this.materialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(160, 50);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(120, 21);
            this.materialComboBox.TabIndex = 1;

            // manufacturerLabel
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Location = new System.Drawing.Point(20, 30);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(89, 13);
            this.manufacturerLabel.TabIndex = 2;
            this.manufacturerLabel.Text = "Производитель:";

            // manufacturerComboBox
            this.manufacturerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufacturerComboBox.FormattingEnabled = true;
            this.manufacturerComboBox.Location = new System.Drawing.Point(20, 50);
            this.manufacturerComboBox.Name = "manufacturerComboBox";
            this.manufacturerComboBox.Size = new System.Drawing.Size(120, 21);
            this.manufacturerComboBox.TabIndex = 0;
            this.manufacturerComboBox.SelectedIndexChanged += new System.EventHandler(this.manufacturerComboBox_SelectedIndexChanged);

            // optionsGroupBox
            this.optionsGroupBox.Controls.Add(this.paspartuWidthTextBox);
            this.optionsGroupBox.Controls.Add(this.paspartuWidthLabel);
            this.optionsGroupBox.Controls.Add(this.paspartuCheckBox);
            this.optionsGroupBox.Controls.Add(this.stretchingCheckBox);
            this.optionsGroupBox.Controls.Add(this.glassCheckBox);
            this.optionsGroupBox.Location = new System.Drawing.Point(20, 240);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(300, 150);
            this.optionsGroupBox.TabIndex = 2;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "Дополнительные опции";

            // paspartuWidthTextBox
            this.paspartuWidthTextBox.Enabled = false;
            this.paspartuWidthTextBox.Location = new System.Drawing.Point(160, 100);
            this.paspartuWidthTextBox.Name = "paspartuWidthTextBox";
            this.paspartuWidthTextBox.Size = new System.Drawing.Size(50, 20);
            this.paspartuWidthTextBox.TabIndex = 4;
            this.paspartuWidthTextBox.Text = "5";

            // paspartuWidthLabel
            this.paspartuWidthLabel.AutoSize = true;
            this.paspartuWidthLabel.Location = new System.Drawing.Point(220, 103);
            this.paspartuWidthLabel.Name = "paspartuWidthLabel";
            this.paspartuWidthLabel.Size = new System.Drawing.Size(60, 13);
            this.paspartuWidthLabel.TabIndex = 3;
            this.paspartuWidthLabel.Text = "см (ширина)";

            // paspartuCheckBox
            this.paspartuCheckBox.AutoSize = true;
            this.paspartuCheckBox.Location = new System.Drawing.Point(20, 100);
            this.paspartuCheckBox.Name = "paspartuCheckBox";
            this.paspartuCheckBox.Size = new System.Drawing.Size(134, 17);
            this.paspartuCheckBox.TabIndex = 2;
            this.paspartuCheckBox.Text = "Добавить паспарту";
            this.paspartuCheckBox.UseVisualStyleBackColor = true;
            this.paspartuCheckBox.CheckedChanged += new System.EventHandler(this.paspartuCheckBox_CheckedChanged);

            // stretchingCheckBox
            this.stretchingCheckBox.AutoSize = true;
            this.stretchingCheckBox.Location = new System.Drawing.Point(20, 60);
            this.stretchingCheckBox.Name = "stretchingCheckBox";
            this.stretchingCheckBox.Size = new System.Drawing.Size(216, 17);
            this.stretchingCheckBox.TabIndex = 1;
            this.stretchingCheckBox.Text = "Натяжение работы на подрамник";
            this.stretchingCheckBox.UseVisualStyleBackColor = true;

            // glassCheckBox
            this.glassCheckBox.AutoSize = true;
            this.glassCheckBox.Location = new System.Drawing.Point(20, 30);
            this.glassCheckBox.Name = "glassCheckBox";
            this.glassCheckBox.Size = new System.Drawing.Size(98, 17);
            this.glassCheckBox.TabIndex = 0;
            this.glassCheckBox.Text = "Добавить стекло";
            this.glassCheckBox.UseVisualStyleBackColor = true;

            // calculateButton
            this.calculateButton.Location = new System.Drawing.Point(20, 400);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(300, 40);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Рассчитать стоимость";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);

            // resultLabel
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(20, 450);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(300, 40);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 511);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.optionsGroupBox);
            this.Controls.Add(this.bagetGroupBox);
            this.Controls.Add(this.sizeGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор стоимости багета";
            this.sizeGroupBox.ResumeLayout(false);
            this.sizeGroupBox.PerformLayout();
            this.bagetGroupBox.ResumeLayout(false);
            this.bagetGroupBox.PerformLayout();
            this.optionsGroupBox.ResumeLayout(false);
            this.optionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox sizeGroupBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.GroupBox bagetGroupBox;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.ComboBox materialComboBox;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.ComboBox manufacturerComboBox;
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.TextBox paspartuWidthTextBox;
        private System.Windows.Forms.Label paspartuWidthLabel;
        private System.Windows.Forms.CheckBox paspartuCheckBox;
        private System.Windows.Forms.CheckBox stretchingCheckBox;
        private System.Windows.Forms.CheckBox glassCheckBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label resultLabel;
    }
}