namespace Sales.Forms
{
    partial class ConnectionForm
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dataSourceLabel = new System.Windows.Forms.Label();
            this.dataSourceTextBox = new System.Windows.Forms.TextBox();
            this.initialCatalogLabel = new System.Windows.Forms.Label();
            this.initialCatalogTextBox = new System.Windows.Forms.TextBox();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.integratedSecurityCheckBox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.dataSourceLabel);
            this.flowLayoutPanel.Controls.Add(this.dataSourceTextBox);
            this.flowLayoutPanel.Controls.Add(this.initialCatalogLabel);
            this.flowLayoutPanel.Controls.Add(this.initialCatalogTextBox);
            this.flowLayoutPanel.Controls.Add(this.integratedSecurityCheckBox);
            this.flowLayoutPanel.Controls.Add(this.userIdLabel);
            this.flowLayoutPanel.Controls.Add(this.userIdTextBox);
            this.flowLayoutPanel.Controls.Add(this.passwordLabel);
            this.flowLayoutPanel.Controls.Add(this.passwordTextBox);
            this.flowLayoutPanel.Controls.Add(this.okButton);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel.Size = new System.Drawing.Size(284, 221);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // dataSourceLabel
            // 
            this.dataSourceLabel.AutoSize = true;
            this.dataSourceLabel.Location = new System.Drawing.Point(8, 5);
            this.dataSourceLabel.Name = "dataSourceLabel";
            this.dataSourceLabel.Size = new System.Drawing.Size(68, 13);
            this.dataSourceLabel.TabIndex = 0;
            this.dataSourceLabel.Text = "Data source:";
            // 
            // dataSourceTextBox
            // 
            this.dataSourceTextBox.Location = new System.Drawing.Point(8, 21);
            this.dataSourceTextBox.Name = "dataSourceTextBox";
            this.dataSourceTextBox.Size = new System.Drawing.Size(264, 20);
            this.dataSourceTextBox.TabIndex = 1;
            // 
            // initialCatalogLabel
            // 
            this.initialCatalogLabel.AutoSize = true;
            this.initialCatalogLabel.Location = new System.Drawing.Point(8, 44);
            this.initialCatalogLabel.Name = "initialCatalogLabel";
            this.initialCatalogLabel.Size = new System.Drawing.Size(72, 13);
            this.initialCatalogLabel.TabIndex = 2;
            this.initialCatalogLabel.Text = "Initial catalog:";
            // 
            // initialCatalogTextBox
            // 
            this.initialCatalogTextBox.Location = new System.Drawing.Point(8, 60);
            this.initialCatalogTextBox.Name = "initialCatalogTextBox";
            this.initialCatalogTextBox.Size = new System.Drawing.Size(264, 20);
            this.initialCatalogTextBox.TabIndex = 3;
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(8, 106);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(44, 13);
            this.userIdLabel.TabIndex = 4;
            this.userIdLabel.Text = "User Id:";
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Location = new System.Drawing.Point(8, 122);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(264, 20);
            this.userIdTextBox.TabIndex = 5;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(8, 145);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(8, 161);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(264, 20);
            this.passwordTextBox.TabIndex = 7;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // integratedSecurityCheckBox
            // 
            this.integratedSecurityCheckBox.AutoSize = true;
            this.integratedSecurityCheckBox.Location = new System.Drawing.Point(8, 86);
            this.integratedSecurityCheckBox.Name = "integratedSecurityCheckBox";
            this.integratedSecurityCheckBox.Size = new System.Drawing.Size(113, 17);
            this.integratedSecurityCheckBox.TabIndex = 8;
            this.integratedSecurityCheckBox.Text = "Integrated security";
            this.integratedSecurityCheckBox.UseVisualStyleBackColor = true;
            this.integratedSecurityCheckBox.CheckedChanged += new System.EventHandler(this.integratedSecurityCheckBox_CheckedChanged);
            // 
            // okButton
            // 
            this.okButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.okButton.Location = new System.Drawing.Point(197, 187);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 9;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ConnectionStringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 221);
            this.Controls.Add(this.flowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConnectionStringForm";
            this.Text = "Connection string";
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label dataSourceLabel;
        private System.Windows.Forms.TextBox dataSourceTextBox;
        private System.Windows.Forms.Label initialCatalogLabel;
        private System.Windows.Forms.TextBox initialCatalogTextBox;
        private System.Windows.Forms.CheckBox integratedSecurityCheckBox;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button okButton;
    }
}