namespace BirdHome
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            home1 = new Home();
            vetka1 = new Vetka();
            SuspendLayout();
            // 
            // home1
            // 
            home1.BackColor = Color.Transparent;
            home1.BackgroundImage = (Image)resources.GetObject("home1.BackgroundImage");
            home1.CountBird = 0U;
            home1.Location = new Point(650, 14);
            home1.Margin = new Padding(3, 5, 3, 5);
            home1.Name = "home1";
            home1.Size = new Size(318, 295);
            home1.TabIndex = 0;
            // 
            // vetka1
            // 
            vetka1.BackColor = Color.Transparent;
            vetka1.BackgroundImage = (Image)resources.GetObject("vetka1.BackgroundImage");
            vetka1.CountBird = 0;
            vetka1.ForeColor = SystemColors.ControlText;
            vetka1.Location = new Point(602, 460);
            vetka1.Name = "vetka1";
            vetka1.Size = new Size(445, 222);
            vetka1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 707);
            Controls.Add(vetka1);
            Controls.Add(home1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Кормушка";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Home home1;
        private Vetka vetka1;
    }
}
