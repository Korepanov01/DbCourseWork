
namespace DB_CW_WF.Forms
{
    partial class HotelInfo
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.innTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.staffListBox = new System.Windows.Forms.ListBox();
            this.addStaffButton = new System.Windows.Forms.Button();
            this.roomListBox = new System.Windows.Forms.ListBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.changeInfoButton = new System.Windows.Forms.Button();
            this.saveInfoChangesButton = new System.Windows.Forms.Button();
            this.cancelInfoChangingButton = new System.Windows.Forms.Button();
            this.deleteStaffButton = new System.Windows.Forms.Button();
            this.staffInfoButton = new System.Windows.Forms.Button();
            this.roomInfoButton = new System.Windows.Forms.Button();
            this.deleteRoomButton = new System.Windows.Forms.Button();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(128, 43);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Название";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(12, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(128, 43);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "ИНН";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(12, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(128, 43);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Адрес";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextBox.Location = new System.Drawing.Point(146, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(342, 43);
            this.nameTextBox.TabIndex = 3;
            // 
            // innTextBox
            // 
            this.innTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.innTextBox.Location = new System.Drawing.Point(146, 61);
            this.innTextBox.Name = "innTextBox";
            this.innTextBox.ReadOnly = true;
            this.innTextBox.Size = new System.Drawing.Size(342, 43);
            this.innTextBox.TabIndex = 4;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressTextBox.Location = new System.Drawing.Point(146, 110);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(342, 43);
            this.addressTextBox.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(12, 170);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(323, 43);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Персонал";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // staffListBox
            // 
            this.staffListBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.staffListBox.FormattingEnabled = true;
            this.staffListBox.HorizontalScrollbar = true;
            this.staffListBox.ItemHeight = 37;
            this.staffListBox.Location = new System.Drawing.Point(12, 219);
            this.staffListBox.Name = "staffListBox";
            this.staffListBox.Size = new System.Drawing.Size(323, 337);
            this.staffListBox.TabIndex = 8;
            // 
            // addStaffButton
            // 
            this.addStaffButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addStaffButton.Location = new System.Drawing.Point(341, 268);
            this.addStaffButton.Name = "addStaffButton";
            this.addStaffButton.Size = new System.Drawing.Size(189, 43);
            this.addStaffButton.TabIndex = 9;
            this.addStaffButton.Text = "Добавить";
            this.addStaffButton.UseVisualStyleBackColor = true;
            this.addStaffButton.Click += new System.EventHandler(this.AddStaffButton_Click);
            // 
            // roomListBox
            // 
            this.roomListBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomListBox.FormattingEnabled = true;
            this.roomListBox.HorizontalScrollbar = true;
            this.roomListBox.ItemHeight = 37;
            this.roomListBox.Location = new System.Drawing.Point(548, 219);
            this.roomListBox.Name = "roomListBox";
            this.roomListBox.Size = new System.Drawing.Size(323, 337);
            this.roomListBox.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(548, 170);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(323, 43);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "Комнаты";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // changeInfoButton
            // 
            this.changeInfoButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeInfoButton.Location = new System.Drawing.Point(494, 12);
            this.changeInfoButton.Name = "changeInfoButton";
            this.changeInfoButton.Size = new System.Drawing.Size(189, 43);
            this.changeInfoButton.TabIndex = 16;
            this.changeInfoButton.Text = "Изменить";
            this.changeInfoButton.UseVisualStyleBackColor = true;
            this.changeInfoButton.Click += new System.EventHandler(this.ChangeInfoButton_Click);
            // 
            // saveInfoChangesButton
            // 
            this.saveInfoChangesButton.Enabled = false;
            this.saveInfoChangesButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveInfoChangesButton.Location = new System.Drawing.Point(494, 61);
            this.saveInfoChangesButton.Name = "saveInfoChangesButton";
            this.saveInfoChangesButton.Size = new System.Drawing.Size(189, 43);
            this.saveInfoChangesButton.TabIndex = 17;
            this.saveInfoChangesButton.Text = "Сохранить";
            this.saveInfoChangesButton.UseVisualStyleBackColor = true;
            this.saveInfoChangesButton.Click += new System.EventHandler(this.SaveInfoChangesButton_Click);
            // 
            // cancelInfoChangingButton
            // 
            this.cancelInfoChangingButton.Enabled = false;
            this.cancelInfoChangingButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelInfoChangingButton.Location = new System.Drawing.Point(494, 110);
            this.cancelInfoChangingButton.Name = "cancelInfoChangingButton";
            this.cancelInfoChangingButton.Size = new System.Drawing.Size(189, 43);
            this.cancelInfoChangingButton.TabIndex = 18;
            this.cancelInfoChangingButton.Text = "Отмена";
            this.cancelInfoChangingButton.UseVisualStyleBackColor = true;
            this.cancelInfoChangingButton.Click += new System.EventHandler(this.CancelInfoChangingButton_Click);
            // 
            // deleteStaffButton
            // 
            this.deleteStaffButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteStaffButton.Location = new System.Drawing.Point(341, 317);
            this.deleteStaffButton.Name = "deleteStaffButton";
            this.deleteStaffButton.Size = new System.Drawing.Size(189, 43);
            this.deleteStaffButton.TabIndex = 19;
            this.deleteStaffButton.Text = "Удалить";
            this.deleteStaffButton.UseVisualStyleBackColor = true;
            this.deleteStaffButton.Click += new System.EventHandler(this.DeleteStaffButton_Click);
            // 
            // staffInfoButton
            // 
            this.staffInfoButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.staffInfoButton.Location = new System.Drawing.Point(341, 219);
            this.staffInfoButton.Name = "staffInfoButton";
            this.staffInfoButton.Size = new System.Drawing.Size(189, 43);
            this.staffInfoButton.TabIndex = 20;
            this.staffInfoButton.Text = "Подробнее";
            this.staffInfoButton.UseVisualStyleBackColor = true;
            this.staffInfoButton.Click += new System.EventHandler(this.StaffInfoButton_Click);
            // 
            // roomInfoButton
            // 
            this.roomInfoButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomInfoButton.Location = new System.Drawing.Point(877, 219);
            this.roomInfoButton.Name = "roomInfoButton";
            this.roomInfoButton.Size = new System.Drawing.Size(189, 43);
            this.roomInfoButton.TabIndex = 23;
            this.roomInfoButton.Text = "Подробнее";
            this.roomInfoButton.UseVisualStyleBackColor = true;
            this.roomInfoButton.Click += new System.EventHandler(this.RoomInfoButton_Click);
            // 
            // deleteRoomButton
            // 
            this.deleteRoomButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteRoomButton.Location = new System.Drawing.Point(877, 317);
            this.deleteRoomButton.Name = "deleteRoomButton";
            this.deleteRoomButton.Size = new System.Drawing.Size(189, 43);
            this.deleteRoomButton.TabIndex = 22;
            this.deleteRoomButton.Text = "Удалить";
            this.deleteRoomButton.UseVisualStyleBackColor = true;
            this.deleteRoomButton.Click += new System.EventHandler(this.DeleteRoomButton_Click);
            // 
            // addRoomButton
            // 
            this.addRoomButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addRoomButton.Location = new System.Drawing.Point(877, 268);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(189, 43);
            this.addRoomButton.TabIndex = 21;
            this.addRoomButton.Text = "Добавить";
            this.addRoomButton.UseVisualStyleBackColor = true;
            this.addRoomButton.Click += new System.EventHandler(this.AddRoomButton_Click);
            // 
            // HotelInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 567);
            this.Controls.Add(this.roomInfoButton);
            this.Controls.Add(this.deleteRoomButton);
            this.Controls.Add(this.addRoomButton);
            this.Controls.Add(this.staffInfoButton);
            this.Controls.Add(this.deleteStaffButton);
            this.Controls.Add(this.cancelInfoChangingButton);
            this.Controls.Add(this.saveInfoChangesButton);
            this.Controls.Add(this.changeInfoButton);
            this.Controls.Add(this.roomListBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.addStaffButton);
            this.Controls.Add(this.staffListBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.innTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HotelInfo";
            this.Text = "Отель";
            this.Load += new System.EventHandler(this.HotelInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox innTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListBox staffListBox;
        private System.Windows.Forms.Button addStaffButton;
        private System.Windows.Forms.ListBox roomListBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button changeInfoButton;
        private System.Windows.Forms.Button saveInfoChangesButton;
        private System.Windows.Forms.Button cancelInfoChangingButton;
        private System.Windows.Forms.Button deleteStaffButton;
        private System.Windows.Forms.Button staffInfoButton;
        private System.Windows.Forms.Button roomInfoButton;
        private System.Windows.Forms.Button deleteRoomButton;
        private System.Windows.Forms.Button addRoomButton;
    }
}