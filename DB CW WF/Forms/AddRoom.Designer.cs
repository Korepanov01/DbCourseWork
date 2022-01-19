
namespace DB_CW_WF.Forms
{
    partial class AddRoom
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusesComboBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.bedsCountTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.costPerDayTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(263, 43);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Статус";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusesComboBox
            // 
            this.statusesComboBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusesComboBox.FormattingEnabled = true;
            this.statusesComboBox.Location = new System.Drawing.Point(12, 208);
            this.statusesComboBox.Name = "statusesComboBox";
            this.statusesComboBox.Size = new System.Drawing.Size(263, 45);
            this.statusesComboBox.TabIndex = 16;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(12, 306);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(263, 41);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(12, 259);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(263, 41);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // bedsCountTextBox
            // 
            this.bedsCountTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bedsCountTextBox.Location = new System.Drawing.Point(12, 61);
            this.bedsCountTextBox.Name = "bedsCountTextBox";
            this.bedsCountTextBox.PlaceholderText = "Число мест";
            this.bedsCountTextBox.Size = new System.Drawing.Size(263, 43);
            this.bedsCountTextBox.TabIndex = 13;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberTextBox.Location = new System.Drawing.Point(12, 12);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.PlaceholderText = "Номер";
            this.numberTextBox.Size = new System.Drawing.Size(263, 43);
            this.numberTextBox.TabIndex = 12;
            // 
            // costPerDayTextBox
            // 
            this.costPerDayTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.costPerDayTextBox.Location = new System.Drawing.Point(12, 110);
            this.costPerDayTextBox.Name = "costPerDayTextBox";
            this.costPerDayTextBox.PlaceholderText = "Цена в день (руб.)";
            this.costPerDayTextBox.Size = new System.Drawing.Size(263, 43);
            this.costPerDayTextBox.TabIndex = 18;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionTextBox.Location = new System.Drawing.Point(281, 12);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PlaceholderText = "Описание";
            this.descriptionTextBox.Size = new System.Drawing.Size(507, 335);
            this.descriptionTextBox.TabIndex = 19;
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 353);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.costPerDayTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusesComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.bedsCountTextBox);
            this.Controls.Add(this.numberTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRoom";
            this.Text = "Добавить комнату";
            this.Load += new System.EventHandler(this.AddRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox statusesComboBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox bedsCountTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox costPerDayTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
    }
}