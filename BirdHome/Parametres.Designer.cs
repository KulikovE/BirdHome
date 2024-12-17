namespace BirdHome
{
    partial class Parametres
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            numericUpDown4 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(29, 42);
            label2.Name = "label2";
            label2.Size = new Size(266, 41);
            label2.TabIndex = 1;
            label2.Text = "Время кормления";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(318, 42);
            label3.Name = "label3";
            label3.Size = new Size(242, 41);
            label3.TabIndex = 2;
            label3.Text = "Частота подлета";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(78, 124);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(79, 27);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(215, 124);
            numericUpDown2.Margin = new Padding(3, 4, 3, 4);
            numericUpDown2.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(79, 27);
            numericUpDown2.TabIndex = 7;
            numericUpDown2.Value = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(28, 126);
            label4.Name = "label4";
            label4.Size = new Size(42, 32);
            label4.TabIndex = 8;
            label4.Text = "От";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(165, 126);
            label5.Name = "label5";
            label5.Size = new Size(45, 32);
            label5.TabIndex = 9;
            label5.Text = "До";
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(380, 124);
            numericUpDown4.Margin = new Padding(3, 4, 3, 4);
            numericUpDown4.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numericUpDown4.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(79, 27);
            numericUpDown4.TabIndex = 11;
            numericUpDown4.Value = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown4.ValueChanged += numericUpDown4_ValueChanged;
            // 
            // Parametres
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(numericUpDown4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Parametres";
            Size = new Size(559, 248);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDown4;
    }
}
