using System.ComponentModel;

namespace DB_CW_WF.Forms
{
    partial class ClientInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.departureDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.arrivalDatePicker = new System.Windows.Forms.DateTimePicker();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.prepaidTextBox = new System.Windows.Forms.TextBox();
            this.cancelInfoChangingButton = new System.Windows.Forms.Button();
            this.saveInfoChangesButton = new System.Windows.Forms.Button();
            this.changeInfoButton = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.hotelTextBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.roomTextBox = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // departureDateDateTimePicker
            // 
            this.departureDateDateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departureDateDateTimePicker.Enabled = false;
            this.departureDateDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departureDateDateTimePicker.Location = new System.Drawing.Point(195, 159);
            this.departureDateDateTimePicker.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.departureDateDateTimePicker.Name = "departureDateDateTimePicker";
            this.departureDateDateTimePicker.Size = new System.Drawing.Size(263, 43);
            this.departureDateDateTimePicker.TabIndex = 37;
            this.departureDateDateTimePicker.Value = new System.DateTime(2021, 12, 25, 23, 59, 59, 0);
            // 
            // arrivalDatePicker
            // 
            this.arrivalDatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrivalDatePicker.Enabled = false;
            this.arrivalDatePicker.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrivalDatePicker.Location = new System.Drawing.Point(195, 110);
            this.arrivalDatePicker.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.arrivalDatePicker.Name = "arrivalDatePicker";
            this.arrivalDatePicker.Size = new System.Drawing.Size(263, 43);
            this.arrivalDatePicker.TabIndex = 36;
            this.arrivalDatePicker.Value = new System.DateTime(2021, 12, 25, 23, 59, 59, 0);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextBox.Location = new System.Drawing.Point(195, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(263, 43);
            this.nameTextBox.TabIndex = 35;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 308);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PlaceholderText = "Описание";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(641, 284);
            this.descriptionTextBox.TabIndex = 34;
            // 
            // prepaidTextBox
            // 
            this.prepaidTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prepaidTextBox.Location = new System.Drawing.Point(195, 61);
            this.prepaidTextBox.Name = "prepaidTextBox";
            this.prepaidTextBox.ReadOnly = true;
            this.prepaidTextBox.Size = new System.Drawing.Size(263, 43);
            this.prepaidTextBox.TabIndex = 33;
            // 
            // cancelInfoChangingButton
            // 
            this.cancelInfoChangingButton.Enabled = false;
            this.cancelInfoChangingButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelInfoChangingButton.Location = new System.Drawing.Point(464, 110);
            this.cancelInfoChangingButton.Name = "cancelInfoChangingButton";
            this.cancelInfoChangingButton.Size = new System.Drawing.Size(189, 43);
            this.cancelInfoChangingButton.TabIndex = 42;
            this.cancelInfoChangingButton.Text = "Отмена";
            this.cancelInfoChangingButton.UseVisualStyleBackColor = true;
            this.cancelInfoChangingButton.Click += new System.EventHandler(this.CancelInfoChangingButton_Click);
            // 
            // saveInfoChangesButton
            // 
            this.saveInfoChangesButton.Enabled = false;
            this.saveInfoChangesButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveInfoChangesButton.Location = new System.Drawing.Point(464, 61);
            this.saveInfoChangesButton.Name = "saveInfoChangesButton";
            this.saveInfoChangesButton.Size = new System.Drawing.Size(189, 43);
            this.saveInfoChangesButton.TabIndex = 41;
            this.saveInfoChangesButton.Text = "Сохранить";
            this.saveInfoChangesButton.UseVisualStyleBackColor = true;
            this.saveInfoChangesButton.Click += new System.EventHandler(this.SaveInfoChangesButton_Click);
            // 
            // changeInfoButton
            // 
            this.changeInfoButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeInfoButton.Location = new System.Drawing.Point(464, 12);
            this.changeInfoButton.Name = "changeInfoButton";
            this.changeInfoButton.Size = new System.Drawing.Size(189, 43);
            this.changeInfoButton.TabIndex = 40;
            this.changeInfoButton.Text = "Изменить";
            this.changeInfoButton.UseVisualStyleBackColor = true;
            this.changeInfoButton.Click += new System.EventHandler(this.ChangeInfoButton_Click);
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(12, 110);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(177, 43);
            this.textBox5.TabIndex = 48;
            this.textBox5.Text = "Дата заезда";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(12, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(177, 43);
            this.textBox2.TabIndex = 47;
            this.textBox2.Text = "Предоплата";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(177, 43);
            this.textBox1.TabIndex = 46;
            this.textBox1.Text = "Имя";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(12, 161);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(177, 43);
            this.textBox3.TabIndex = 49;
            this.textBox3.Text = "Дата отъезда";
            // 
            // hotelTextBox
            // 
            this.hotelTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hotelTextBox.Location = new System.Drawing.Point(195, 210);
            this.hotelTextBox.Name = "hotelTextBox";
            this.hotelTextBox.ReadOnly = true;
            this.hotelTextBox.Size = new System.Drawing.Size(263, 43);
            this.hotelTextBox.TabIndex = 51;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(12, 210);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(177, 43);
            this.textBox4.TabIndex = 50;
            this.textBox4.Text = "Отель";
            // 
            // roomTextBox
            // 
            this.roomTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomTextBox.Location = new System.Drawing.Point(195, 259);
            this.roomTextBox.Name = "roomTextBox";
            this.roomTextBox.ReadOnly = true;
            this.roomTextBox.Size = new System.Drawing.Size(263, 43);
            this.roomTextBox.TabIndex = 53;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox7.Location = new System.Drawing.Point(12, 259);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(177, 43);
            this.textBox7.TabIndex = 52;
            this.textBox7.Text = "Номер";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(464, 159);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(189, 43);
            this.deleteButton.TabIndex = 54;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 602);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.roomTextBox);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.hotelTextBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cancelInfoChangingButton);
            this.Controls.Add(this.saveInfoChangesButton);
            this.Controls.Add(this.changeInfoButton);
            this.Controls.Add(this.departureDateDateTimePicker);
            this.Controls.Add(this.arrivalDatePicker);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.prepaidTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientInfo";
            this.Text = "Клиент";
            this.Load += new System.EventHandler(this.ClientInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker departureDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker arrivalDatePicker;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox prepaidTextBox;
        private System.Windows.Forms.Button cancelInfoChangingButton;
        private System.Windows.Forms.Button saveInfoChangesButton;
        private System.Windows.Forms.Button changeInfoButton;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox hotelTextBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox roomTextBox;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button deleteButton;
    }
}