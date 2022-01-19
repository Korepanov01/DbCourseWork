
namespace DB_CW_WF.Forms
{
    partial class Reports
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
            this.report1Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.report2Button = new System.Windows.Forms.Button();
            this.report3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // report1Button
            // 
            this.report1Button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.report1Button.Location = new System.Drawing.Point(12, 61);
            this.report1Button.Name = "report1Button";
            this.report1Button.Size = new System.Drawing.Size(552, 50);
            this.report1Button.TabIndex = 9;
            this.report1Button.Text = "Перечень свободных номеров на заданную дату\r\n";
            this.report1Button.UseVisualStyleBackColor = true;
            this.report1Button.Click += new System.EventHandler(this.Report1Button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(552, 43);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Отчеты";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // report2Button
            // 
            this.report2Button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.report2Button.Location = new System.Drawing.Point(12, 117);
            this.report2Button.Name = "report2Button";
            this.report2Button.Size = new System.Drawing.Size(552, 50);
            this.report2Button.TabIndex = 11;
            this.report2Button.Text = "Количество свободных номеров/занятых номеров на заданную дат";
            this.report2Button.UseVisualStyleBackColor = true;
            this.report2Button.Click += new System.EventHandler(this.Report2Button_Click);
            // 
            // report3Button
            // 
            this.report3Button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.report3Button.Location = new System.Drawing.Point(12, 173);
            this.report3Button.Name = "report3Button";
            this.report3Button.Size = new System.Drawing.Size(552, 50);
            this.report3Button.TabIndex = 12;
            this.report3Button.Text = "Количество посетителей в срок с ... по ...";
            this.report3Button.UseVisualStyleBackColor = true;
            this.report3Button.Click += new System.EventHandler(this.Report3Button_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 230);
            this.Controls.Add(this.report3Button);
            this.Controls.Add(this.report2Button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.report1Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reports";
            this.Text = "Отчеты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button report1Button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button report2Button;
        private System.Windows.Forms.Button report3Button;
    }
}