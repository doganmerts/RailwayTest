namespace RailwayTest
{
    partial class MainForm
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
            YukOlusturButton = new Button();
            SuspendLayout();
            // 
            // YukOlusturButton
            // 
            YukOlusturButton.Location = new Point(12, 12);
            YukOlusturButton.Name = "YukOlusturButton";
            YukOlusturButton.Size = new Size(123, 64);
            YukOlusturButton.TabIndex = 1;
            YukOlusturButton.Text = "Yük Oluştur";
            YukOlusturButton.UseVisualStyleBackColor = true;
            YukOlusturButton.Click += YukOlusturButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 613);
            Controls.Add(YukOlusturButton);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button YukOlusturButton;
    }
}