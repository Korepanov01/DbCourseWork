
namespace DB_CW_WF.Forms
{
    partial class AddRoomStatus
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
            this.cancel = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.isFreeCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancel.Location = new System.Drawing.Point(192, 108);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(174, 41);
            this.cancel.TabIndex = 12;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add.Location = new System.Drawing.Point(12, 108);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(174, 41);
            this.add.TabIndex = 11;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextBox.Location = new System.Drawing.Point(12, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PlaceholderText = "Название";
            this.nameTextBox.Size = new System.Drawing.Size(354, 43);
            this.nameTextBox.TabIndex = 10;
            // 
            // isFreeCheckBox
            // 
            this.isFreeCheckBox.AutoSize = true;
            this.isFreeCheckBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isFreeCheckBox.Location = new System.Drawing.Point(12, 61);
            this.isFreeCheckBox.Name = "isFreeCheckBox";
            this.isFreeCheckBox.Size = new System.Drawing.Size(336, 41);
            this.isFreeCheckBox.TabIndex = 13;
            this.isFreeCheckBox.Text = "Доступна для заселения";
            this.isFreeCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddRoomStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 154);
            this.Controls.Add(this.isFreeCheckBox);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.add);
            this.Controls.Add(this.nameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRoomStatus";
            this.Text = "Добавить статус комнаты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.CheckBox isFreeCheckBox;
    }
}