namespace CarMechanicApp
{
    partial class AddVehicleForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.plateNoTextBox = new System.Windows.Forms.TextBox();
            this.plateNoLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.colourLabel = new System.Windows.Forms.Label();
            this.colourTextBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.ownerComboBox = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ownerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(176, 246);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(257, 246);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // plateNoTextBox
            // 
            this.plateNoTextBox.Location = new System.Drawing.Point(98, 10);
            this.plateNoTextBox.Name = "plateNoTextBox";
            this.plateNoTextBox.Size = new System.Drawing.Size(121, 20);
            this.plateNoTextBox.TabIndex = 9;
            // 
            // plateNoLabel
            // 
            this.plateNoLabel.AutoSize = true;
            this.plateNoLabel.Location = new System.Drawing.Point(13, 13);
            this.plateNoLabel.Name = "plateNoLabel";
            this.plateNoLabel.Size = new System.Drawing.Size(82, 13);
            this.plateNoLabel.TabIndex = 10;
            this.plateNoLabel.Text = "Nr rejestracyjny:";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(13, 39);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(40, 13);
            this.brandLabel.TabIndex = 12;
            this.brandLabel.Text = "Marka:";
            // 
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(98, 36);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(121, 20);
            this.brandTextBox.TabIndex = 11;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(13, 65);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(39, 13);
            this.modelLabel.TabIndex = 14;
            this.modelLabel.Text = "Model:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(98, 62);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(121, 20);
            this.modelTextBox.TabIndex = 13;
            // 
            // colourLabel
            // 
            this.colourLabel.AutoSize = true;
            this.colourLabel.Location = new System.Drawing.Point(13, 91);
            this.colourLabel.Name = "colourLabel";
            this.colourLabel.Size = new System.Drawing.Size(34, 13);
            this.colourLabel.TabIndex = 16;
            this.colourLabel.Text = "Kolor:";
            // 
            // colourTextBox
            // 
            this.colourTextBox.Location = new System.Drawing.Point(98, 88);
            this.colourTextBox.Name = "colourTextBox";
            this.colourTextBox.Size = new System.Drawing.Size(121, 20);
            this.colourTextBox.TabIndex = 15;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(13, 117);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(76, 13);
            this.yearLabel.TabIndex = 18;
            this.yearLabel.Text = "Rok produkcji:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(98, 114);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(121, 20);
            this.yearTextBox.TabIndex = 17;
            // 
            // ownerComboBox
            // 
            this.ownerComboBox.DataSource = this.clientBindingSource;
            this.ownerComboBox.DisplayMember = "FullName";
            this.ownerComboBox.FormattingEnabled = true;
            this.ownerComboBox.Location = new System.Drawing.Point(98, 141);
            this.ownerComboBox.Name = "ownerComboBox";
            this.ownerComboBox.Size = new System.Drawing.Size(121, 21);
            this.ownerComboBox.TabIndex = 19;
            this.ownerComboBox.ValueMember = "Id";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(CarMechanicApp.Models.Client);
            // 
            // ownerLabel
            // 
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.Location = new System.Drawing.Point(13, 144);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(60, 13);
            this.ownerLabel.TabIndex = 20;
            this.ownerLabel.Text = "Właściciel:";
            // 
            // AddVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 281);
            this.Controls.Add(this.ownerLabel);
            this.Controls.Add(this.ownerComboBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.colourLabel);
            this.Controls.Add(this.colourTextBox);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(this.plateNoLabel);
            this.Controls.Add(this.plateNoTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddVehicleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj pojazd";
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox plateNoTextBox;
        private System.Windows.Forms.Label plateNoLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label colourLabel;
        private System.Windows.Forms.TextBox colourTextBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.ComboBox ownerComboBox;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.Label ownerLabel;
    }
}