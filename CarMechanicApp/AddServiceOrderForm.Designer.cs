namespace CarMechanicApp
{
    partial class AddServiceOrderForm
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
            this.components = new System.ComponentModel.Container();
            this.saveButton = new System.Windows.Forms.Button();
            this.mechanicComboBox = new System.Windows.Forms.ComboBox();
            this.mechanicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mechanicLabel = new System.Windows.Forms.Label();
            this.vehicleLabel = new System.Windows.Forms.Label();
            this.vehicleComboBox = new System.Windows.Forms.ComboBox();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mechanicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(255, 246);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // mechanicComboBox
            // 
            this.mechanicComboBox.DataSource = this.mechanicBindingSource;
            this.mechanicComboBox.DisplayMember = "FullName";
            this.mechanicComboBox.FormattingEnabled = true;
            this.mechanicComboBox.Location = new System.Drawing.Point(76, 32);
            this.mechanicComboBox.Name = "mechanicComboBox";
            this.mechanicComboBox.Size = new System.Drawing.Size(173, 21);
            this.mechanicComboBox.TabIndex = 1;
            this.mechanicComboBox.ValueMember = "Id";
            // 
            // mechanicBindingSource
            // 
            this.mechanicBindingSource.DataSource = typeof(CarMechanicApp.Models.Mechanic);
            // 
            // mechanicLabel
            // 
            this.mechanicLabel.AutoSize = true;
            this.mechanicLabel.Location = new System.Drawing.Point(13, 40);
            this.mechanicLabel.Name = "mechanicLabel";
            this.mechanicLabel.Size = new System.Drawing.Size(57, 13);
            this.mechanicLabel.TabIndex = 2;
            this.mechanicLabel.Text = "Mechanik:";
            // 
            // vehicleLabel
            // 
            this.vehicleLabel.AutoSize = true;
            this.vehicleLabel.Location = new System.Drawing.Point(13, 67);
            this.vehicleLabel.Name = "vehicleLabel";
            this.vehicleLabel.Size = new System.Drawing.Size(39, 13);
            this.vehicleLabel.TabIndex = 4;
            this.vehicleLabel.Text = "Pojazd";
            this.vehicleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // vehicleComboBox
            // 
            this.vehicleComboBox.DataSource = this.vehicleBindingSource;
            this.vehicleComboBox.DisplayMember = "VehicleInfo";
            this.vehicleComboBox.FormattingEnabled = true;
            this.vehicleComboBox.Location = new System.Drawing.Point(76, 59);
            this.vehicleComboBox.Name = "vehicleComboBox";
            this.vehicleComboBox.Size = new System.Drawing.Size(173, 21);
            this.vehicleComboBox.TabIndex = 3;
            this.vehicleComboBox.ValueMember = "Id";
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataSource = typeof(CarMechanicApp.Models.Vehicle);
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Location = new System.Drawing.Point(16, 121);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(314, 108);
            this.descriptionRichTextBox.TabIndex = 5;
            this.descriptionRichTextBox.Text = "";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(174, 246);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddServiceOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 281);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.vehicleLabel);
            this.Controls.Add(this.vehicleComboBox);
            this.Controls.Add(this.mechanicLabel);
            this.Controls.Add(this.mechanicComboBox);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddServiceOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodanie zlecenia";
            ((System.ComponentModel.ISupportInitialize)(this.mechanicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox mechanicComboBox;
        private System.Windows.Forms.Label mechanicLabel;
        private System.Windows.Forms.Label vehicleLabel;
        private System.Windows.Forms.ComboBox vehicleComboBox;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.BindingSource mechanicBindingSource;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
    }
}