
namespace DB_CW_WF.Forms
{
    partial class RoomStatuses
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
            this.changeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.roomStatusesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeButton.Location = new System.Drawing.Point(570, 121);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(185, 43);
            this.changeButton.TabIndex = 42;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(570, 170);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(185, 47);
            this.deleteButton.TabIndex = 41;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(552, 43);
            this.textBox1.TabIndex = 40;
            this.textBox1.Text = "Статусы комнат";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(570, 68);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(185, 47);
            this.addButton.TabIndex = 39;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // statusesListBox
            // 
            this.roomStatusesListBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomStatusesListBox.FormattingEnabled = true;
            this.roomStatusesListBox.HorizontalScrollbar = true;
            this.roomStatusesListBox.ItemHeight = 37;
            this.roomStatusesListBox.Location = new System.Drawing.Point(12, 68);
            this.roomStatusesListBox.Name = "roomStatusesListBox";
            this.roomStatusesListBox.Size = new System.Drawing.Size(552, 448);
            this.roomStatusesListBox.TabIndex = 38;
            // 
            // RoomStatuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 524);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.roomStatusesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoomStatuses";
            this.Text = "Статусы комнат";
            this.Load += new System.EventHandler(this.RoomStatuses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox roomStatusesListBox;
    }
}