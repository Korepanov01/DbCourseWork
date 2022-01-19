
namespace DB_CW_WF.Forms
{
    partial class Report3
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.clientsTextBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(12, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(167, 43);
            this.textBox2.TabIndex = 67;
            this.textBox2.Text = "Посетителей";
            // 
            // clientsTextBox
            // 
            this.clientsTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientsTextBox.Location = new System.Drawing.Point(185, 110);
            this.clientsTextBox.Name = "clientsTextBox";
            this.clientsTextBox.ReadOnly = true;
            this.clientsTextBox.Size = new System.Drawing.Size(263, 43);
            this.clientsTextBox.TabIndex = 66;
            // 
            // findButton
            // 
            this.findButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.findButton.Location = new System.Drawing.Point(12, 159);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(436, 43);
            this.findButton.TabIndex = 63;
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
            this.textBox5.Size = new System.Drawing.Size(167, 43);
            this.textBox5.TabIndex = 62;
            this.textBox5.Text = "C";
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromDatePicker.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromDatePicker.Location = new System.Drawing.Point(185, 12);
            this.fromDatePicker.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(263, 43);
            this.fromDatePicker.TabIndex = 61;
            this.fromDatePicker.Value = new System.DateTime(2021, 12, 25, 23, 59, 59, 0);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(167, 43);
            this.textBox1.TabIndex = 69;
            this.textBox1.Text = "По";
            // 
            // toDatePicker
            // 
            this.toDatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toDatePicker.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toDatePicker.Location = new System.Drawing.Point(185, 61);
            this.toDatePicker.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(263, 43);
            this.toDatePicker.TabIndex = 68;
            this.toDatePicker.Value = new System.DateTime(2021, 12, 25, 23, 59, 59, 0);
            // 
            // Report3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 214);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toDatePicker);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.clientsTextBox);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.fromDatePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Report3";
            this.Text = "Количество посетителей в срок с ... по ...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox clientsTextBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker toDatePicker;
    }
}