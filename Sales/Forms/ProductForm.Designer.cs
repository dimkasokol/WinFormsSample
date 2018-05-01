namespace Sales.Forms
{
    partial class ProductForm
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
            this.productLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.costUpDown = new System.Windows.Forms.NumericUpDown();
            this.productLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // productLayoutPanel
            // 
            this.productLayoutPanel.Controls.Add(this.nameLabel);
            this.productLayoutPanel.Controls.Add(this.nameTextBox);
            this.productLayoutPanel.Controls.Add(this.costLabel);
            this.productLayoutPanel.Controls.Add(this.costUpDown);
            this.productLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.productLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.productLayoutPanel.Name = "productLayoutPanel";
            this.productLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.productLayoutPanel.Size = new System.Drawing.Size(334, 132);
            this.productLayoutPanel.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(8, 5);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(8, 21);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(314, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(8, 44);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(31, 13);
            this.costLabel.TabIndex = 2;
            this.costLabel.Text = "Cost:";
            // 
            // costUpDown
            // 
            this.costUpDown.DecimalPlaces = 2;
            this.costUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.costUpDown.Location = new System.Drawing.Point(8, 60);
            this.costUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.costUpDown.Name = "costUpDown";
            this.costUpDown.Size = new System.Drawing.Size(314, 20);
            this.costUpDown.TabIndex = 3;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.productLayoutPanel);
            this.Name = "ProductForm";
            this.Text = "Product";
            this.Controls.SetChildIndex(this.productLayoutPanel, 0);
            this.productLayoutPanel.ResumeLayout(false);
            this.productLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel productLayoutPanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.NumericUpDown costUpDown;
    }
}
