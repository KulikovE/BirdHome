namespace BirdHome
{
    partial class Form2
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
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            numericUpDown4 = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(397, 39);
            label1.TabIndex = 0;
            label1.Text = "Вместимость кормушки";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Microsoft Sans Serif", 19.8000011F);
            numericUpDown1.Location = new Point(100, 84);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 45);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(397, 195);
            button1.Name = "button1";
            button1.Size = new Size(124, 63);
            button1.TabIndex = 4;
            button1.Text = "Пуск";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Font = new Font("Microsoft Sans Serif", 19.8000011F);
            numericUpDown4.Location = new Point(124, 370);
            numericUpDown4.Margin = new Padding(3, 4, 3, 4);
            numericUpDown4.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numericUpDown4.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(79, 45);
            numericUpDown4.TabIndex = 18;
            numericUpDown4.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 19.8000011F);
            label5.Location = new Point(170, 237);
            label5.Name = "label5";
            label5.Size = new Size(62, 39);
            label5.TabIndex = 17;
            label5.Text = "До";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 19.8000011F);
            label4.Location = new Point(11, 237);
            label4.Name = "label4";
            label4.Size = new Size(59, 39);
            label4.TabIndex = 16;
            label4.Text = "От";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Microsoft Sans Serif", 19.8000011F);
            numericUpDown2.Location = new Point(238, 235);
            numericUpDown2.Margin = new Padding(3, 4, 3, 4);
            numericUpDown2.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(79, 45);
            numericUpDown2.TabIndex = 15;
            numericUpDown2.Value = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Font = new Font("Microsoft Sans Serif", 19.8000011F);
            numericUpDown3.Location = new Point(85, 235);
            numericUpDown3.Margin = new Padding(3, 4, 3, 4);
            numericUpDown3.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(79, 45);
            numericUpDown3.TabIndex = 14;
            numericUpDown3.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 19.8000011F);
            label3.Location = new Point(12, 327);
            label3.Name = "label3";
            label3.Size = new Size(286, 39);
            label3.TabIndex = 13;
            label3.Text = "Частота подлета";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 19.8000011F);
            label2.Location = new Point(12, 153);
            label2.Name = "label2";
            label2.Size = new Size(302, 39);
            label2.TabIndex = 12;
            label2.Text = "Время кормления";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 439);
            Controls.Add(numericUpDown4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private NumericUpDown numericUpDown4;
        private Label label5;
        private Label label4;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Label label3;
        private Label label2;
    }
}