namespace Sales.Forms
{
    partial class SaleForm
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
            this.saleLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.productLabel = new System.Windows.Forms.Label();
            this.productLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.productButton = new System.Windows.Forms.Button();
            this.detailsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountUpDown = new System.Windows.Forms.NumericUpDown();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.totalCostUpDown = new System.Windows.Forms.NumericUpDown();
            this.saleDateLabel = new System.Windows.Forms.Label();
            this.saleDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saleLayoutPanel.SuspendLayout();
            this.productLayoutPanel.SuspendLayout();
            this.detailsLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalCostUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // saleLayoutPanel
            // 
            this.saleLayoutPanel.Controls.Add(this.employeeLabel);
            this.saleLayoutPanel.Controls.Add(this.employeeComboBox);
            this.saleLayoutPanel.Controls.Add(this.productLabel);
            this.saleLayoutPanel.Controls.Add(this.productLayoutPanel);
            this.saleLayoutPanel.Controls.Add(this.detailsLayoutPanel);
            this.saleLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saleLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.saleLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.saleLayoutPanel.Name = "saleLayoutPanel";
            this.saleLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.saleLayoutPanel.Size = new System.Drawing.Size(434, 159);
            this.saleLayoutPanel.TabIndex = 1;
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Location = new System.Drawing.Point(8, 5);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(56, 13);
            this.employeeLabel.TabIndex = 0;
            this.employeeLabel.Text = "Employee:";
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(8, 21);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(414, 21);
            this.employeeComboBox.TabIndex = 1;
            this.employeeComboBox.SelectedIndexChanged += new System.EventHandler(this.employeeComboBox_SelectedIndexChanged);
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(8, 45);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(47, 13);
            this.productLabel.TabIndex = 2;
            this.productLabel.Text = "Product:";
            // 
            // productLayoutPanel
            // 
            this.productLayoutPanel.Controls.Add(this.productTextBox);
            this.productLayoutPanel.Controls.Add(this.productButton);
            this.productLayoutPanel.Location = new System.Drawing.Point(8, 61);
            this.productLayoutPanel.Name = "productLayoutPanel";
            this.productLayoutPanel.Size = new System.Drawing.Size(414, 26);
            this.productLayoutPanel.TabIndex = 4;
            // 
            // productTextBox
            // 
            this.productTextBox.Location = new System.Drawing.Point(3, 3);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.ReadOnly = true;
            this.productTextBox.Size = new System.Drawing.Size(375, 20);
            this.productTextBox.TabIndex = 3;
            // 
            // productButton
            // 
            this.productButton.Location = new System.Drawing.Point(384, 3);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(25, 20);
            this.productButton.TabIndex = 4;
            this.productButton.Text = "...";
            this.productButton.UseVisualStyleBackColor = true;
            this.productButton.Click += new System.EventHandler(this.productButton_Click);
            // 
            // detailsLayoutPanel
            // 
            this.detailsLayoutPanel.Controls.Add(this.amountLabel);
            this.detailsLayoutPanel.Controls.Add(this.amountUpDown);
            this.detailsLayoutPanel.Controls.Add(this.totalCostLabel);
            this.detailsLayoutPanel.Controls.Add(this.totalCostUpDown);
            this.detailsLayoutPanel.Controls.Add(this.saleDateLabel);
            this.detailsLayoutPanel.Controls.Add(this.saleDateTimePicker);
            this.detailsLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.detailsLayoutPanel.Location = new System.Drawing.Point(8, 93);
            this.detailsLayoutPanel.Name = "detailsLayoutPanel";
            this.detailsLayoutPanel.Size = new System.Drawing.Size(414, 51);
            this.detailsLayoutPanel.TabIndex = 11;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(3, 0);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(46, 13);
            this.amountLabel.TabIndex = 5;
            this.amountLabel.Text = "Amount:";
            // 
            // amountUpDown
            // 
            this.amountUpDown.Location = new System.Drawing.Point(3, 16);
            this.amountUpDown.Name = "amountUpDown";
            this.amountUpDown.Size = new System.Drawing.Size(120, 20);
            this.amountUpDown.TabIndex = 6;
            this.amountUpDown.ValueChanged += new System.EventHandler(this.amountUpDown_ValueChanged);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(129, 0);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(57, 13);
            this.totalCostLabel.TabIndex = 7;
            this.totalCostLabel.Text = "Total cost:";
            // 
            // totalCostUpDown
            // 
            this.totalCostUpDown.DecimalPlaces = 2;
            this.totalCostUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.totalCostUpDown.Location = new System.Drawing.Point(129, 16);
            this.totalCostUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.totalCostUpDown.Name = "totalCostUpDown";
            this.totalCostUpDown.Size = new System.Drawing.Size(120, 20);
            this.totalCostUpDown.TabIndex = 8;
            // 
            // saleDateLabel
            // 
            this.saleDateLabel.AutoSize = true;
            this.saleDateLabel.Location = new System.Drawing.Point(255, 0);
            this.saleDateLabel.Name = "saleDateLabel";
            this.saleDateLabel.Size = new System.Drawing.Size(55, 13);
            this.saleDateLabel.TabIndex = 9;
            this.saleDateLabel.Text = "Sale date:";
            // 
            // saleDateTimePicker
            // 
            this.saleDateTimePicker.Location = new System.Drawing.Point(255, 16);
            this.saleDateTimePicker.Name = "saleDateTimePicker";
            this.saleDateTimePicker.Size = new System.Drawing.Size(150, 20);
            this.saleDateTimePicker.TabIndex = 10;
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(434, 188);
            this.Controls.Add(this.saleLayoutPanel);
            this.Name = "SaleForm";
            this.Text = "Sale";
            this.Controls.SetChildIndex(this.saleLayoutPanel, 0);
            this.saleLayoutPanel.ResumeLayout(false);
            this.saleLayoutPanel.PerformLayout();
            this.productLayoutPanel.ResumeLayout(false);
            this.productLayoutPanel.PerformLayout();
            this.detailsLayoutPanel.ResumeLayout(false);
            this.detailsLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalCostUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel saleLayoutPanel;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.FlowLayoutPanel productLayoutPanel;
        private System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.Button productButton;
        private System.Windows.Forms.FlowLayoutPanel detailsLayoutPanel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.NumericUpDown amountUpDown;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.NumericUpDown totalCostUpDown;
        private System.Windows.Forms.Label saleDateLabel;
        private System.Windows.Forms.DateTimePicker saleDateTimePicker;
    }
}
