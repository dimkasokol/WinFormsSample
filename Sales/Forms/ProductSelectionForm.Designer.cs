namespace Sales.Forms
{
    partial class ProductSelectionForm
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
            this.productsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.productsGridView = new System.Windows.Forms.DataGridView();
            this.productsLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productsLayoutPanel
            // 
            this.productsLayoutPanel.Controls.Add(this.searchLabel);
            this.productsLayoutPanel.Controls.Add(this.searchTextBox);
            this.productsLayoutPanel.Controls.Add(this.productsGridView);
            this.productsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.productsLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.productsLayoutPanel.Name = "productsLayoutPanel";
            this.productsLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.productsLayoutPanel.Size = new System.Drawing.Size(534, 312);
            this.productsLayoutPanel.TabIndex = 1;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(8, 5);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(137, 13);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Start typing product name...";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(8, 21);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(514, 20);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // productsGridView
            // 
            this.productsGridView.AllowUserToAddRows = false;
            this.productsGridView.AllowUserToDeleteRows = false;
            this.productsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsGridView.Location = new System.Drawing.Point(8, 47);
            this.productsGridView.MultiSelect = false;
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.ReadOnly = true;
            this.productsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsGridView.Size = new System.Drawing.Size(514, 256);
            this.productsGridView.TabIndex = 2;
            // 
            // ProductSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(534, 341);
            this.Controls.Add(this.productsLayoutPanel);
            this.Name = "ProductSelectionForm";
            this.Text = "Select product";
            this.Controls.SetChildIndex(this.productsLayoutPanel, 0);
            this.productsLayoutPanel.ResumeLayout(false);
            this.productsLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel productsLayoutPanel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView productsGridView;
    }
}
