
namespace DB_CW_WF.Forms
{
    partial class Hotels
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hotelsListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.hotelInfoButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.positionsButton = new System.Windows.Forms.Button();
            this.roomStatusesButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hotelsListBox
            // 
            this.hotelsListBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hotelsListBox.FormattingEnabled = true;
            this.hotelsListBox.HorizontalScrollbar = true;
            this.hotelsListBox.ItemHeight = 37;
            this.hotelsListBox.Location = new System.Drawing.Point(12, 61);
            this.hotelsListBox.Name = "hotelsListBox";
            this.hotelsListBox.Size = new System.Drawing.Size(862, 448);
            this.hotelsListBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(880, 114);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(174, 47);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // hotelInfoButton
            // 
            this.hotelInfoButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hotelInfoButton.Location = new System.Drawing.Point(880, 61);
            this.hotelInfoButton.Name = "hotelInfoButton";
            this.hotelInfoButton.Size = new System.Drawing.Size(174, 47);
            this.hotelInfoButton.TabIndex = 4;
            this.hotelInfoButton.Text = "Подробнее";
            this.hotelInfoButton.UseVisualStyleBackColor = true;
            this.hotelInfoButton.Click += new System.EventHandler(this.HotelInfoButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refreshButton.Location = new System.Drawing.Point(880, 460);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(174, 49);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "Перезаполнить БД";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(862, 43);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Отели";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(880, 167);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(174, 47);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // positionsButton
            // 
            this.positionsButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.positionsButton.Location = new System.Drawing.Point(880, 293);
            this.positionsButton.Name = "positionsButton";
            this.positionsButton.Size = new System.Drawing.Size(174, 50);
            this.positionsButton.TabIndex = 8;
            this.positionsButton.Text = "Редактировать должности";
            this.positionsButton.UseVisualStyleBackColor = true;
            this.positionsButton.Click += new System.EventHandler(this.PositionsButton_Click);
            // 
            // roomStatusesButton
            // 
            this.roomStatusesButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomStatusesButton.Location = new System.Drawing.Point(880, 349);
            this.roomStatusesButton.Name = "roomStatusesButton";
            this.roomStatusesButton.Size = new System.Drawing.Size(174, 50);
            this.roomStatusesButton.TabIndex = 9;
            this.roomStatusesButton.Text = "Редактировать статусы комнат";
            this.roomStatusesButton.UseVisualStyleBackColor = true;
            this.roomStatusesButton.Click += new System.EventHandler(this.RoomStatusesButton_Click);
            // 
            // reportsButton
            // 
            this.reportsButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reportsButton.Location = new System.Drawing.Point(880, 405);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(174, 49);
            this.reportsButton.TabIndex = 10;
            this.reportsButton.Text = "Отчеты";
            this.reportsButton.UseVisualStyleBackColor = true;
            this.reportsButton.Click += new System.EventHandler(this.ReportsButton_Click);
            // 
            // Hotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 515);
            this.Controls.Add(this.reportsButton);
            this.Controls.Add(this.roomStatusesButton);
            this.Controls.Add(this.positionsButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.hotelInfoButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.hotelsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hotels";
            this.Text = "Отели";
            this.Load += new System.EventHandler(this.Hotels_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox hotelsListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button hotelInfoButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button positionsButton;
        private System.Windows.Forms.Button roomStatusesButton;
        private System.Windows.Forms.Button reportsButton;
    }
}

