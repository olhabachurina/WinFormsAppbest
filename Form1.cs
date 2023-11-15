namespace WinFormsAppbest
{
    public partial class Form1 : Form
    {
        // ������ � ���� �������� � �� �����
        private string[] fuelTypes = { "������ �-92", "������ �-95", "������" };
        private double[] fuelPrices = { 53.4, 55.2, 55.5 };
        private double litersToBuy;
        private double moneyToPay;
        string[] cafeItemNames = { "���������", "���", "���������", "�������" };
        double[] cafePrices = { 65.0, 55.0, 80.0, 40.0 };
        private TextBox textBoxPriceLemonade;
        private TextBox textBoxPriceHamburger;
        private TextBox textBoxPriceTea;
        private TextBox textBoxPriceAmericano;
        private TextBox textBoxQuantityLemonade;
        private TextBox textBoxQuantityHamburger;
        private TextBox textBoxQuantityTea;
        private TextBox textBoxQuantityAmericano;
        private CheckBox checkBoxNameLemonade;
        private CheckBox checkBoxNameHamburger;
        private CheckBox checkBoxNameTea;
        private CheckBox checkBoxNameAmericano;
        private Label labelTotalAmount;
        private Button buttonCalculateOrder;

        public Form1()
        {
            InitializeComponent();
            InitializeFuelComboBox();
            InitializeCafeItems();
        }

        private void InitializeCafeItems()
        {
            for (int i = 0; i < cafeItemNames.Length; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = cafeItemNames[i];

                checkBox.CheckedChanged += CheckBox_CheckedChanged;

                TextBox textBoxQuantity = new TextBox();
                textBoxQuantity.Enabled = false;

                TextBox textBoxPrice = new TextBox();
                textBoxPrice.Enabled = false;
                textBoxPrice.Text = cafePrices[i].ToString();


                int top = i * 30;
                checkBox.Top = top;
                textBoxQuantity.Top = top;
                textBoxPrice.Top = top;

                checkBox.Left = 10;
                textBoxPrice.Left = 150;
                textBoxQuantity.Left = 250;

                groupBoxCafe.Controls.Add(checkBox);
                groupBoxCafe.Controls.Add(textBoxQuantity);
                groupBoxCafe.Controls.Add(textBoxPrice);
                if (i == 0)
                {
                    textBoxQuantityAmericano = textBoxQuantity;
                    textBoxPriceAmericano = textBoxPrice;
                    checkBoxNameAmericano = checkBox;
                }
                else if (i == 1)
                {
                    textBoxQuantityTea = textBoxQuantity;
                    textBoxPriceTea = textBoxPrice;
                    checkBoxNameTea = checkBox;
                }
                else if (i == 2)
                {
                    textBoxQuantityHamburger = textBoxQuantity;
                    textBoxPriceHamburger = textBoxPrice;
                    checkBoxNameHamburger = checkBox;
                }
                else if (i == 3)
                {
                    textBoxQuantityLemonade = textBoxQuantity;
                    textBoxPriceLemonade = textBoxPrice;
                    checkBoxNameLemonade = checkBox;
                }

                buttonCalculateOrder = new Button();
                buttonCalculateOrder.Text = "���������� �����";
                buttonCalculateOrder.Click += ButtonCalculateOrder_Click;
                buttonCalculateOrder.AutoSize = true;

                buttonCalculateOrder.Top = cafeItemNames.Length * 30 + 60;
                buttonCalculateOrder.Left = 10;
                groupBoxCafe.Controls.Add(buttonCalculateOrder);

                labelTotalAmount = new Label();
                labelTotalAmount.Text = "� ������ ";
                labelTotalAmount.AutoSize = true;
                labelTotalAmount.AutoEllipsis = true;
                labelTotalAmount.Top = cafeItemNames.Length * 30 + 100;
                labelTotalAmount.Left = 10;
                groupBoxCafe.Controls.Add(labelTotalAmount);

            }
        }

        private void ButtonCalculateOrder_Click(object? sender, EventArgs e)
        {
            double totalAmount = 0;

            totalAmount += CalculateItemTotal(textBoxQuantityAmericano, textBoxPriceAmericano);
            totalAmount += CalculateItemTotal(textBoxQuantityTea, textBoxPriceTea);
            totalAmount += CalculateItemTotal(textBoxQuantityHamburger, textBoxPriceHamburger);
            totalAmount += CalculateItemTotal(textBoxQuantityLemonade, textBoxPriceLemonade);

            labelTotalAmount.Text = "           : " + totalAmount.ToString("F2") + " ���";
        }

        private double CalculateItemTotal(TextBox textBoxQuantity, TextBox textBoxPrice)
        {
            double quantity = 0;
            double price = 0;

            if (!string.IsNullOrEmpty(textBoxQuantity.Text))
            {
                quantity = Convert.ToDouble(textBoxQuantity.Text);
            }

            if (!string.IsNullOrEmpty(textBoxPrice.Text))
            {
                price = Convert.ToDouble(textBoxPrice.Text);
            }

            return quantity * price;
        }

        private void CheckBox_CheckedChanged(object? sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                EnableQuantityInput(checkBox);
            }
            else
            {
                DisableQuantityInput(checkBox);
            }
        }

        private void DisableQuantityInput(CheckBox checkBox)
        {
            TextBox textBoxQuantity = GetQuantityTextBox(checkBox);
            textBoxQuantity.Enabled = false;
            textBoxQuantity.Text = "";
        }

        private TextBox GetQuantityTextBox(CheckBox checkBox)
        {
            if (checkBox == checkBoxNameAmericano) return textBoxQuantityAmericano;
            if (checkBox == checkBoxNameTea) return textBoxQuantityTea;
            if (checkBox == checkBoxNameHamburger) return textBoxQuantityHamburger;
            if (checkBox == checkBoxNameLemonade) return textBoxQuantityLemonade;

            return null;
        }

        private void EnableQuantityInput(CheckBox checkBox)
        {
            TextBox textBoxQuantity = GetQuantityTextBox(checkBox);
            textBoxQuantity.Enabled = true;
            textBoxQuantity.Text = "1";
        }

        public void InitializeFuelComboBox()
        {

            if (fuelTypes.Length > 0)
            {
                comboBoxFuelType.SelectedIndexChanged += comboBoxFuelType_SelectedIndexChanged;
                comboBoxFuelType.Items.AddRange(fuelTypes);
                comboBoxFuelType.SelectedIndex = 0;
                UpdatePriceLabel();
            }
            else
            {
                MessageBox.Show("����������� ������ � ����� ��������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBoxFuelType_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdatePriceLabel();
        }

        private void UpdatePriceLabel()
        {
            if (comboBoxFuelType.SelectedIndex >= 0 && comboBoxFuelType.SelectedIndex < fuelPrices.Length)
            {
                int selectedIndex = comboBoxFuelType.SelectedIndex;
                labelPrice.Text = $"����: {fuelPrices[selectedIndex]:F2} ���/�";
            }
            else
            {
                // ��������� ��������, ����� comboBoxFuelType �� ������ ��� ������ ������������ ������
                MessageBox.Show("�������� ��� ��������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void radioButtonLiters_CheckedChanged(object sender, EventArgs e)
        {
            // ��������� ������ ������ �� �����
            if (radioButtonLiters.Checked)
            {
                textBoxLiters.Enabled = true;
                textBoxMoney.Enabled = false;
                labelPayment.Text = "� ������:";
            }
        }

        private void radioButtonMoney_CheckedChanged(object sender, EventArgs e)
        {
            // ��������� ������ ������ �� ������
            if (radioButtonMoney.Checked)
            {
                textBoxLiters.Enabled = false;
                textBoxMoney.Enabled = true;
                labelPayment.Text = "� ������:";
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (radioButtonLiters.Checked)
            {
                litersToBuy = Convert.ToDouble(textBoxLiters.Text);
                moneyToPay = litersToBuy * fuelPrices[comboBoxFuelType.SelectedIndex];
                labelResult.Text = $"� ������: {moneyToPay:F2}��� �� {litersToBuy:F2} ������.";
            }
            else if (radioButtonMoney.Checked)
            {
                if (!string.IsNullOrWhiteSpace(textBoxMoney.Text))
                {
                    moneyToPay = Convert.ToDouble(textBoxMoney.Text);
                    int selectedIndex = comboBoxFuelType.SelectedIndex;

                    if (fuelPrices.Length > selectedIndex && selectedIndex >= 0)
                    {
                        litersToBuy = moneyToPay / fuelPrices[selectedIndex];
                        labelResult.Text = $"� ������: {litersToBuy:F2} ������ �� {moneyToPay:F2}���.";

                        // ����� ��������� � ��������� ����� � ���������� ������
                        MessageBox.Show($"� ������: {litersToBuy:F2} ������ �� {moneyToPay:F2}���.", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("�������� ��� ��������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("������� ����� ��� ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void groupBoxCafe_Enter(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGeneral_Click(object sender, EventArgs e)
        {
            double fuelMoneyToPay = 0;
            double litersToBuy = 0;

            if (radioButtonLiters.Checked)
            {
                litersToBuy = Convert.ToDouble(textBoxLiters.Text);
                fuelMoneyToPay = litersToBuy * fuelPrices[comboBoxFuelType.SelectedIndex];
            }
            else if (radioButtonMoney.Checked && !string.IsNullOrWhiteSpace(textBoxMoney.Text))
            {
                double moneyToPayInput = Convert.ToDouble(textBoxMoney.Text);
                int selectedIndex = comboBoxFuelType.SelectedIndex;

                if (fuelPrices.Length > selectedIndex && selectedIndex >= 0)
                {
                    litersToBuy = moneyToPayInput / fuelPrices[selectedIndex];
                    fuelMoneyToPay = moneyToPayInput;
                }
            }

            // ���������� ������� �� ��������
            double productTotalAmount = 0;
            productTotalAmount += CalculateItemTotal(textBoxQuantityAmericano, textBoxPriceAmericano);
            productTotalAmount += CalculateItemTotal(textBoxQuantityTea, textBoxPriceTea);
            productTotalAmount += CalculateItemTotal(textBoxQuantityHamburger, textBoxPriceHamburger);
            productTotalAmount += CalculateItemTotal(textBoxQuantityLemonade, textBoxPriceLemonade);

            // ����� ����� � ������
            double totalAmount = fuelMoneyToPay + productTotalAmount;

            // ���������� ����� � ����� ������
            labelGeneralTotal.Text = $"����� �����: {totalAmount:F2}���";

            // ����� ��������� � ����� ������
            MessageBox.Show($"����� ����� � ������: {totalAmount:F2} ���\n\n" +
                    $"��� �������: {fuelMoneyToPay:F2} ��� �� {litersToBuy:F2} ������.\n" +
                    $"�� ��������: {productTotalAmount:F2} ���", "����� ������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
