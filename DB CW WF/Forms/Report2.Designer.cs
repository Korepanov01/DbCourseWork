
namespace DB_CW_WF.Forms
{
    partial class Report2
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
            this.findButton = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.freeRoomsTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.notFreeRoomsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // findButton
            // 
            this.findButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.findButton.Location = new System.Drawing.Point(12, 159);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(423, 43);
            this.findButton.TabIndex = 56;
            this.findButton.Text = "Найти";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(12, 12);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(154, 43);
            this.textBox5.TabIndex = 54;
            this.textBox5.Text = "Дата";
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datePicker.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datePicker.Location = new System.Drawing.Point(172, 12);
            this.datePicker.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(263, 43);
            this.datePicker.TabIndex = 53;
            this.datePicker.Value = new System.DateTime(2021, 12, 25, 23, 59, 59, 0);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(154, 43);
            this.textBox1.TabIndex = 58;
            this.textBox1.Text = "Свободных";
            // 
            // freeRoomsTextBox
            // 
            this.freeRoomsTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.freeRoomsTextBox.Location = new System.Drawing.Point(172, 61);
            this.freeRoomsTextBox.Name = "freeRoomsTextBox";
            this.freeRoomsTextBox.ReadOnly = true;
            this.freeRoomsTextBox.Size = new System.Drawing.Size(263, 43);
            this.freeRoomsTextBox.TabIndex = 57;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(12, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(154, 43);
            this.textBox2.TabIndex = 60;
            this.textBox2.Text = "Занятых";
            // 
            // notFreeRoomsTextBox
            // 
            this.notFreeRoomsTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.notFreeRoomsTextBox.Location = new System.Drawing.Point(172, 110);
            this.notFreeRoomsTextBox.Name = "notFreeRoomsTextBox";
            this.notFreeRoomsTextBox.ReadOnly = true;
            this.notFreeRoomsTextBox.Size = new System.Drawing.Size(263, 43);
            this.notFreeRoomsTextBox.TabIndex = 59;
            // 
            // Report2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 209);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.notFreeRoomsTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.freeRoomsTextBox);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.datePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Report2";
            this.Text = "Количество свободных номеров/занятых номеров на заданную дату";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox freeRoomsTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox notFreeRoomsTextBox;
    }
}