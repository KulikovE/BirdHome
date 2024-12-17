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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(24, 28);
            label1.Name = "label1";
            label1.Size = new Size(160, 80);
            label1.TabIndex = 0;
            label1.Text = "Вместимость кормушки";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(280, 58);
            label2.Name = "label2";
            label2.Size = new Size(214, 32);
            label2.TabIndex = 1;
            label2.Text = "Время кормления";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(533, 58);
            label3.Name = "label3";
            label3.Size = new Size(195, 32);
            label3.TabIndex = 2;
            label3.Text = "Частота подлета";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(323, 119);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(69, 23);
            numericUpDown1.TabIndex = 6;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(443, 119);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(69, 23);
            numericUpDown2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(279, 121);
            label4.Name = "label4";
            label4.Size = new Size(34, 25);
            label4.TabIndex = 8;
            label4.Text = "От";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(399, 121);
            label5.Name = "label5";
            label5.Size = new Size(36, 25);
            label5.TabIndex = 9;
            label5.Text = "До";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(54, 119);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(69, 23);
            numericUpDown3.TabIndex = 10;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(587, 119);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(69, 23);
            numericUpDown4.TabIndex = 11;
            // 
            // Parametres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(numericUpDown4);
            Controls.Add(numericUpDown3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Parametres";
            Size = new Size(728, 186);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
    }
}
