
namespace DB_CW_WF.Forms
{
    partial class RoomInfo
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.statusesComboBox = new System.Windows.Forms.ComboBox();
            this.cancelInfoChangingButton = new System.Windows.Forms.Button();
            this.saveInfoChangesButton = new System.Windows.Forms.Button();
            this.changeInfoButton = new System.Windows.Forms.Button();
            this.bedsCountTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.costPerDayTextBox = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.hotelTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.clientTextBox = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.clientInfoButton = new System.Windows.Forms.Button();
            this.addClientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(12, 257);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(150, 43);
            this.textBox3.TabIndex = 41;
            this.textBox3.Text = "Статус";
            // 
            // statusesComboBox
            // 
            this.statusesComboBox.Enabled = false;
            this.statusesComboBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusesComboBox.FormattingEnabled = true;
            this.statusesComboBox.Location = new System.Drawing.Point(168, 257);
            this.statusesComboBox.Name = "statusesComboBox";
            this.statusesComboBox.Size = new System.Drawing.Size(342, 45);
            this.statusesComboBox.TabIndex = 40;
            // 
            // cancelInfoChangingButton
            // 
            this.cancelInfoChangingButton.Enabled = false;
            this.cancelInfoChangingButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelInfoChangingButton.Location = new System.Drawing.Point(516, 110);
            this.cancelInfoChangingButton.Name = "cancelInfoChangingButton";
            this.cancelInfoChangingButton.Size = new System.Drawing.Size(189, 43);
            this.cancelInfoChangingButton.TabIndex = 39;
            this.cancelInfoChangingButton.Text = "Отмена";
            this.cancelInfoChangingButton.UseVisualStyleBackColor = true;
            this.cancelInfoChangingButton.Click += new System.EventHandler(this.CancelInfoChangingButton_Click);
            // 
            // saveInfoChangesButton
            // 
            this.saveInfoChangesButton.Enabled = false;
            this.saveInfoChangesButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveInfoChangesButton.Location = new System.Drawing.Point(516, 61);
            this.saveInfoChangesButton.Name = "saveInfoChangesButton";
            this.saveInfoChangesButton.Size = new System.Drawing.Size(189, 43);
            this.saveInfoChangesButton.TabIndex = 38;
            this.saveInfoChangesButton.Text = "Сохранить";
            this.saveInfoChangesButton.UseVisualStyleBackColor = true;
            this.saveInfoChangesButton.Click += new System.EventHandler(this.SaveInfoChangesButton_Click);
            // 
            // changeInfoButton
            // 
            this.changeInfoButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeInfoButton.Location = new System.Drawing.Point(516, 12);
            this.changeInfoButton.Name = "changeInfoButton";
            this.changeInfoButton.Size = new System.Drawing.Size(189, 43);
            this.changeInfoButton.TabIndex = 37;
            this.changeInfoButton.Text = "Изменить";
            this.changeInfoButton.UseVisualStyleBackColor = true;
            this.changeInfoButton.Click += new System.EventHandler(this.ChangeInfoButton_Click);
            // 
            // bedsCountTextBox
            // 
            this.bedsCountTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bedsCountTextBox.Location = new System.Drawing.Point(168, 61);
            this.bedsCountTextBox.Name = "bedsCountTextBox";
            this.bedsCountTextBox.ReadOnly = true;
            this.bedsCountTextBox.Size = new System.Drawing.Size(342, 43);
            this.bedsCountTextBox.TabIndex = 36;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberTextBox.Location = new System.Drawing.Point(168, 12);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.ReadOnly = true;
            this.numberTextBox.Size = new System.Drawing.Size(342, 43);
            this.numberTextBox.TabIndex = 35;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(12, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(150, 43);
            this.textBox2.TabIndex = 34;
            this.textBox2.Text = "Число мест";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(150, 43);
            this.textBox1.TabIndex = 33;
            this.textBox1.Text = "Номер";
            // 
            // costPerDayTextBox
            // 
            this.costPerDayTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.costPerDayTextBox.Location = new System.Drawing.Point(168, 110);
            this.costPerDayTextBox.Name = "costPerDayTextBox";
            this.costPerDayTextBox.ReadOnly = true;
            this.costPerDayTextBox.Size = new System.Drawing.Size(342, 43);
            this.costPerDayTextBox.TabIndex = 44;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(12, 110);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(150, 43);
            this.textBox5.TabIndex = 45;
            this.textBox5.Text = "Цена";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(12, 159);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(150, 43);
            this.textBox4.TabIndex = 43;
            this.textBox4.Text = "Отель";
            // 
            // hotelTextBox
            // 
            this.hotelTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hotelTextBox.Location = new System.Drawing.Point(168, 159);
            this.hotelTextBox.Name = "hotelTextBox";
            this.hotelTextBox.ReadOnly = true;
            this.hotelTextBox.Size = new System.Drawing.Size(342, 43);
            this.hotelTextBox.TabIndex = 46;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 308);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PlaceholderText = "Описание";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(693, 335);
            this.descriptionTextBox.TabIndex = 47;
            // 
            // clientTextBox
            // 
            this.clientTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientTextBox.Location = new System.Drawing.Point(168, 208);
            this.clientTextBox.Name = "clientTextBox";
            this.clientTextBox.ReadOnly = true;
            this.clientTextBox.Size = new System.Drawing.Size(342, 43);
            this.clientTextBox.TabIndex = 49;
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox8.Location = new System.Drawing.Point(12, 208);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(150, 43);
            this.textBox8.TabIndex = 48;
            this.textBox8.Text = "Клиент";
            // 
            // clientInfoButton
            // 
            this.clientInfoButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientInfoButton.Location = new System.Drawing.Point(516, 208);
            this.clientInfoButton.Name = "clientInfoButton";
            this.clientInfoButton.Size = new System.Drawing.Size(189, 43);
            this.clientInfoButton.TabIndex = 50;
            this.clientInfoButton.Text = "Подробнее";
            this.clientInfoButton.UseVisualStyleBackColor = true;
            this.clientInfoButton.Visible = false;
            this.clientInfoButton.Click += new System.EventHandler(this.ClientInfoButton_Click);
            // 
            // addClientButton
            // 
            this.addClientButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addClientButton.Location = new System.Drawing.Point(516, 208);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(189, 43);
            this.addClientButton.TabIndex = 51;
            this.addClientButton.Text = "Заселить";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Visible = false;
            this.addClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // RoomInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 651);
            this.Controls.Add(this.addClientButton);
            this.Controls.Add(this.clientInfoButton);
            this.Controls.Add(this.clientTextBox);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.hotelTextBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.costPerDayTextBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.statusesComboBox);
            this.Controls.Add(this.cancelInfoChangingButton);
            this.Controls.Add(this.saveInfoChangesButton);
            this.Controls.Add(this.changeInfoButton);
            this.Controls.Add(this.bedsCountTextBox);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoomInfo";
            this.Text = "Комната";
            this.Load += new System.EventHandler(this.RoomInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox statusesComboBox;
        private System.Windows.Forms.Button cancelInfoChangingButton;
        private System.Windows.Forms.Button saveInfoChangesButton;
        private System.Windows.Forms.Button changeInfoButton;
        private System.Windows.Forms.TextBox bedsCountTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox costPerDayTextBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox hotelTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox clientTextBox;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button clientInfoButton;
        private System.Windows.Forms.Button addClientButton;
    }
}