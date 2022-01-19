
namespace DB_CW_WF.Forms
{
    partial class StaffInfo
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
            this.cancelInfoChangingButton = new System.Windows.Forms.Button();
            this.saveInfoChangesButton = new System.Windows.Forms.Button();
            this.changeInfoButton = new System.Windows.Forms.Button();
            this.innTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.hotelTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelInfoChangingButton
            // 
            this.cancelInfoChangingButton.Enabled = false;
            this.cancelInfoChangingButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelInfoChangingButton.Location = new System.Drawing.Point(516, 110);
            this.cancelInfoChangingButton.Name = "cancelInfoChangingButton";
            this.cancelInfoChangingButton.Size = new System.Drawing.Size(189, 43);
            this.cancelInfoChangingButton.TabIndex = 27;
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
            this.saveInfoChangesButton.TabIndex = 26;
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
            this.changeInfoButton.TabIndex = 25;
            this.changeInfoButton.Text = "Изменить";
            this.changeInfoButton.UseVisualStyleBackColor = true;
            this.changeInfoButton.Click += new System.EventHandler(this.ChangeInfoButton_Click);
            // 
            // innTextBox
            // 
            this.innTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.innTextBox.Location = new System.Drawing.Point(168, 61);
            this.innTextBox.Name = "innTextBox";
            this.innTextBox.ReadOnly = true;
            this.innTextBox.Size = new System.Drawing.Size(342, 43);
            this.innTextBox.TabIndex = 23;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextBox.Location = new System.Drawing.Point(168, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(342, 43);
            this.nameTextBox.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(12, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(150, 43);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "ИНН";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(150, 43);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "Имя";
            // 
            // positionComboBox
            // 
            this.positionComboBox.Enabled = false;
            this.positionComboBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Location = new System.Drawing.Point(168, 110);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(342, 45);
            this.positionComboBox.TabIndex = 28;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(12, 112);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(150, 43);
            this.textBox3.TabIndex = 30;
            this.textBox3.Text = "Должность";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(12, 163);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(150, 43);
            this.textBox4.TabIndex = 32;
            this.textBox4.Text = "Отель";
            // 
            // hotelTextBox
            // 
            this.hotelTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hotelTextBox.Location = new System.Drawing.Point(168, 163);
            this.hotelTextBox.Name = "hotelTextBox";
            this.hotelTextBox.ReadOnly = true;
            this.hotelTextBox.Size = new System.Drawing.Size(342, 43);
            this.hotelTextBox.TabIndex = 33;
            // 
            // StaffInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 216);
            this.Controls.Add(this.hotelTextBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.positionComboBox);
            this.Controls.Add(this.cancelInfoChangingButton);
            this.Controls.Add(this.saveInfoChangesButton);
            this.Controls.Add(this.changeInfoButton);
            this.Controls.Add(this.innTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StaffInfo";
            this.Text = "Сотрудник";
            this.Load += new System.EventHandler(this.StaffInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelInfoChangingButton;
        private System.Windows.Forms.Button saveInfoChangesButton;
        private System.Windows.Forms.Button changeInfoButton;
        private System.Windows.Forms.TextBox innTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox positionComboBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox hotelTextBox;
    }
}