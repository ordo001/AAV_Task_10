namespace AAV_Task_10.Forms
{
    partial class AddSellForm
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
            this.numericUpDownStartPrice = new System.Windows.Forms.NumericUpDown();
            this.labelStartPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBuyer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxBuyer = new System.Windows.Forms.ComboBox();
            this.numericUpDownEndPrice = new System.Windows.Forms.NumericUpDown();
            this.labelEndPrice = new System.Windows.Forms.Label();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownStartPrice
            // 
            this.numericUpDownStartPrice.Location = new System.Drawing.Point(169, 93);
            this.numericUpDownStartPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownStartPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStartPrice.Name = "numericUpDownStartPrice";
            this.numericUpDownStartPrice.Size = new System.Drawing.Size(256, 23);
            this.numericUpDownStartPrice.TabIndex = 34;
            this.numericUpDownStartPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStartPrice.ValueChanged += new System.EventHandler(this.numericUpDownStartPrice_ValueChanged);
            // 
            // labelStartPrice
            // 
            this.labelStartPrice.AutoSize = true;
            this.labelStartPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStartPrice.Location = new System.Drawing.Point(28, 90);
            this.labelStartPrice.Name = "labelStartPrice";
            this.labelStartPrice.Size = new System.Drawing.Size(129, 21);
            this.labelStartPrice.TabIndex = 26;
            this.labelStartPrice.Text = "Начальная цена:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Выберите товар:";
            // 
            // labelBuyer
            // 
            this.labelBuyer.AutoSize = true;
            this.labelBuyer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBuyer.Location = new System.Drawing.Point(52, 185);
            this.labelBuyer.Name = "labelBuyer";
            this.labelBuyer.Size = new System.Drawing.Size(97, 21);
            this.labelBuyer.TabIndex = 28;
            this.labelBuyer.Text = "Покупатель:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(70, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 40);
            this.button1.TabIndex = 29;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(259, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 40);
            this.button2.TabIndex = 30;
            this.button2.Text = "Вернуться";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxBuyer
            // 
            this.comboBoxBuyer.FormattingEnabled = true;
            this.comboBoxBuyer.Location = new System.Drawing.Point(169, 183);
            this.comboBoxBuyer.Name = "comboBoxBuyer";
            this.comboBoxBuyer.Size = new System.Drawing.Size(254, 23);
            this.comboBoxBuyer.TabIndex = 33;
            // 
            // numericUpDownEndPrice
            // 
            this.numericUpDownEndPrice.Location = new System.Drawing.Point(169, 139);
            this.numericUpDownEndPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownEndPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEndPrice.Name = "numericUpDownEndPrice";
            this.numericUpDownEndPrice.Size = new System.Drawing.Size(256, 23);
            this.numericUpDownEndPrice.TabIndex = 36;
            this.numericUpDownEndPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelEndPrice
            // 
            this.labelEndPrice.AutoSize = true;
            this.labelEndPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEndPrice.Location = new System.Drawing.Point(28, 136);
            this.labelEndPrice.Name = "labelEndPrice";
            this.labelEndPrice.Size = new System.Drawing.Size(121, 21);
            this.labelEndPrice.TabIndex = 35;
            this.labelEndPrice.Text = "Конечная цена:";
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(169, 38);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(254, 23);
            this.comboBoxItem.TabIndex = 37;
            // 
            // AddSellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 312);
            this.Controls.Add(this.comboBoxItem);
            this.Controls.Add(this.numericUpDownEndPrice);
            this.Controls.Add(this.labelEndPrice);
            this.Controls.Add(this.numericUpDownStartPrice);
            this.Controls.Add(this.comboBoxBuyer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelBuyer);
            this.Controls.Add(this.labelStartPrice);
            this.Controls.Add(this.label1);
            this.Name = "AddSellForm";
            this.Text = "AddSellForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numericUpDownStartPrice;
        private Label labelStartPrice;
        private Label label1;
        private Label labelBuyer;
        private Button button1;
        private Button button2;
        private ComboBox comboBoxBuyer;
        private NumericUpDown numericUpDownEndPrice;
        private Label labelEndPrice;
        private ComboBox comboBoxItem;
    }
}