namespace WinFormsAppbest
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
            groupBoxFuel = new GroupBox();
            labelResult = new Label();
            buttonCalculate = new Button();
            labelPayment = new Label();
            textBoxMoney = new TextBox();
            textBoxLiters = new TextBox();
            radioButtonMoney = new RadioButton();
            radioButtonLiters = new RadioButton();
            label1 = new Label();
            labelPrice = new Label();
            comboBoxFuelType = new ComboBox();
            groupBoxCafe = new GroupBox();
            groupBoxAmout = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            labelGeneralTotal = new Label();
            buttonGeneral = new Button();
            label2 = new Label();
            groupBoxFuel.SuspendLayout();
            groupBoxAmout.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxFuel
            // 
            groupBoxFuel.BackColor = Color.Khaki;
            groupBoxFuel.Controls.Add(labelResult);
            groupBoxFuel.Controls.Add(buttonCalculate);
            groupBoxFuel.Controls.Add(labelPayment);
            groupBoxFuel.Controls.Add(textBoxMoney);
            groupBoxFuel.Controls.Add(textBoxLiters);
            groupBoxFuel.Controls.Add(radioButtonMoney);
            groupBoxFuel.Controls.Add(radioButtonLiters);
            groupBoxFuel.Controls.Add(label1);
            groupBoxFuel.Controls.Add(labelPrice);
            groupBoxFuel.Controls.Add(comboBoxFuelType);
            groupBoxFuel.Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxFuel.ForeColor = Color.FromArgb(128, 64, 0);
            groupBoxFuel.Location = new Point(0, 0);
            groupBoxFuel.Name = "groupBoxFuel";
            groupBoxFuel.Size = new Size(404, 333);
            groupBoxFuel.TabIndex = 0;
            groupBoxFuel.TabStop = false;
            groupBoxFuel.Text = "Автозаправка";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(63, 273);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 26);
            labelResult.TabIndex = 8;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(12, 232);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(131, 29);
            buttonCalculate.TabIndex = 7;
            buttonCalculate.Text = "К оплате";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // labelPayment
            // 
            labelPayment.AutoSize = true;
            labelPayment.Location = new Point(94, 93);
            labelPayment.Name = "labelPayment";
            labelPayment.Size = new Size(71, 26);
            labelPayment.TabIndex = 6;
            labelPayment.Text = "Выбор";
            // 
            // textBoxMoney
            // 
            textBoxMoney.Location = new Point(188, 157);
            textBoxMoney.Name = "textBoxMoney";
            textBoxMoney.Size = new Size(125, 34);
            textBoxMoney.TabIndex = 5;
            // 
            // textBoxLiters
            // 
            textBoxLiters.Location = new Point(188, 118);
            textBoxLiters.Name = "textBoxLiters";
            textBoxLiters.Size = new Size(125, 34);
            textBoxLiters.TabIndex = 4;
            // 
            // radioButtonMoney
            // 
            radioButtonMoney.AutoSize = true;
            radioButtonMoney.Location = new Point(6, 158);
            radioButtonMoney.Name = "radioButtonMoney";
            radioButtonMoney.Size = new Size(145, 30);
            radioButtonMoney.TabIndex = 3;
            radioButtonMoney.TabStop = true;
            radioButtonMoney.Text = "Сумма (грн)";
            radioButtonMoney.UseVisualStyleBackColor = true;
            // 
            // radioButtonLiters
            // 
            radioButtonLiters.AutoSize = true;
            radioButtonLiters.Location = new Point(6, 122);
            radioButtonLiters.Name = "radioButtonLiters";
            radioButtonLiters.Size = new Size(176, 30);
            radioButtonLiters.TabIndex = 0;
            radioButtonLiters.TabStop = true;
            radioButtonLiters.Text = "Количество (л)";
            radioButtonLiters.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Matura MT Script Capitals", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(208, 23);
            label1.TabIndex = 2;
            label1.Text = "Выбирите вид топлива";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(182, 55);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(0, 26);
            labelPrice.TabIndex = 1;
            // 
            // comboBoxFuelType
            // 
            comboBoxFuelType.FormattingEnabled = true;
            comboBoxFuelType.Location = new Point(6, 52);
            comboBoxFuelType.Name = "comboBoxFuelType";
            comboBoxFuelType.Size = new Size(151, 34);
            comboBoxFuelType.TabIndex = 0;
            // 
            // groupBoxCafe
            // 
            groupBoxCafe.BackColor = Color.PeachPuff;
            groupBoxCafe.Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxCafe.Location = new Point(401, 26);
            groupBoxCafe.Name = "groupBoxCafe";
            groupBoxCafe.Size = new Size(399, 307);
            groupBoxCafe.TabIndex = 0;
            groupBoxCafe.TabStop = false;
            groupBoxCafe.Enter += groupBoxCafe_Enter;
            // 
            // groupBoxAmout
            // 
            groupBoxAmout.Controls.Add(label4);
            groupBoxAmout.Controls.Add(label3);
            groupBoxAmout.Controls.Add(labelGeneralTotal);
            groupBoxAmout.Controls.Add(buttonGeneral);
            groupBoxAmout.Dock = DockStyle.Bottom;
            groupBoxAmout.Font = new Font("Matura MT Script Capitals", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxAmout.ForeColor = Color.FromArgb(128, 64, 0);
            groupBoxAmout.Location = new Point(0, 325);
            groupBoxAmout.Name = "groupBoxAmout";
            groupBoxAmout.Size = new Size(800, 125);
            groupBoxAmout.TabIndex = 1;
            groupBoxAmout.TabStop = false;
            groupBoxAmout.Text = "к оплате";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(541, -6);
            label4.Name = "label4";
            label4.Size = new Size(242, 37);
            label4.TabIndex = 3;
            label4.Text = "\"BESTOIL\"";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(230, 0);
            label3.Name = "label3";
            label3.Size = new Size(305, 31);
            label3.TabIndex = 2;
            label3.Text = "Feed yourself and your car";
            // 
            // labelGeneralTotal
            // 
            labelGeneralTotal.AutoSize = true;
            labelGeneralTotal.Location = new Point(325, 48);
            labelGeneralTotal.Name = "labelGeneralTotal";
            labelGeneralTotal.Size = new Size(0, 37);
            labelGeneralTotal.TabIndex = 1;
            // 
            // buttonGeneral
            // 
            buttonGeneral.Location = new Point(28, 44);
            buttonGeneral.Name = "buttonGeneral";
            buttonGeneral.Size = new Size(239, 41);
            buttonGeneral.TabIndex = 0;
            buttonGeneral.Text = "Полный расчет";
            buttonGeneral.UseVisualStyleBackColor = true;
            buttonGeneral.Click += buttonGeneral_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(401, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 26);
            label2.TabIndex = 0;
            label2.Text = "Миникафе";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(groupBoxAmout);
            Controls.Add(groupBoxCafe);
            Controls.Add(groupBoxFuel);
            Name = "Form1";
            Text = "Form1";
            groupBoxFuel.ResumeLayout(false);
            groupBoxFuel.PerformLayout();
            groupBoxAmout.ResumeLayout(false);
            groupBoxAmout.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxFuel;
        private GroupBox groupBoxCafe;
        private GroupBox groupBoxAmout;
        private ComboBox comboBoxFuelType;
        private Label labelPrice;
        private Label label1;
        private RadioButton radioButtonMoney;
        private RadioButton radioButtonLiters;
        private TextBox textBoxMoney;
        private TextBox textBoxLiters;
        private Label labelResult;
        private Button buttonCalculate;
        private Label labelPayment;
        private Label labelGeneralTotal;
        private Button buttonGeneral;
        private Label label2;
        private Label label4;
        private Label label3;
    }
}