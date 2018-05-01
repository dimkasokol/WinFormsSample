namespace Sales.Forms
{
    partial class EmployeeForm
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
            this.employeeLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.employeeLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeLayoutPanel
            // 
            this.employeeLayoutPanel.Controls.Add(this.nameLabel);
            this.employeeLayoutPanel.Controls.Add(this.nameTextBox);
            this.employeeLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.employeeLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.employeeLayoutPanel.Name = "employeeLayoutPanel";
            this.employeeLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.employeeLayoutPanel.Size = new System.Drawing.Size(334, 82);
            this.employeeLayoutPanel.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(8, 5);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(85, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Employee name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(8, 21);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(314, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(334, 111);
            this.Controls.Add(this.employeeLayoutPanel);
            this.Name = "EmployeeForm";
            this.Text = "Employee";
            this.Controls.SetChildIndex(this.employeeLayoutPanel, 0);
            this.employeeLayoutPanel.ResumeLayout(false);
            this.employeeLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel employeeLayoutPanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}
