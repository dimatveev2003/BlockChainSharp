namespace BlockChainSharp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mineButton = new System.Windows.Forms.Button();
            this.mainingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mineButton
            // 
            this.mineButton.Location = new System.Drawing.Point(104, 130);
            this.mineButton.Name = "mineButton";
            this.mineButton.Size = new System.Drawing.Size(65, 23);
            this.mineButton.TabIndex = 0;
            this.mineButton.Text = "Mine";
            this.mineButton.UseVisualStyleBackColor = true;
            this.mineButton.Click += new System.EventHandler(this.MineButton_Click);
            // 
            // mainingLabel
            // 
            this.mainingLabel.AutoSize = true;
            this.mainingLabel.Location = new System.Drawing.Point(101, 103);
            this.mainingLabel.Name = "mainingLabel";
            this.mainingLabel.Size = new System.Drawing.Size(68, 13);
            this.mainingLabel.TabIndex = 1;
            this.mainingLabel.Text = "maining label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 284);
            this.Controls.Add(this.mainingLabel);
            this.Controls.Add(this.mineButton);
            this.Name = "Form1";
            this.Text = "Mine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button mineButton;
        private System.Windows.Forms.Label mainingLabel;
    }
}

