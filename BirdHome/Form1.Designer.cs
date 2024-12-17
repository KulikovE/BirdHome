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
            SuspendLayout();
            // 
            // home1
            // 
            home1.BackColor = Color.Transparent;
            home1.BackgroundImage = (Image)resources.GetObject("home1.BackgroundImage");
            home1.Location = new Point(356, 38);
            home1.Name = "home1";
            home1.Size = new Size(314, 291);
            home1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(home1);
            Name = "Form1";
            Text = "Кормушка";
            ResumeLayout(false);
        }

        #endregion

        private Home home1;
    }
}
