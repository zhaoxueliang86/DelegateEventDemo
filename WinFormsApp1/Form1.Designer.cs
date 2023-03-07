namespace WinFormsApp1
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
            BtnStart = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // BtnStart
            // 
            BtnStart.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnStart.Location = new Point(36, 44);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(128, 64);
            BtnStart.TabIndex = 1;
            BtnStart.Text = "开始";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(36, 134);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(616, 663);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 858);
            Controls.Add(richTextBox1);
            Controls.Add(BtnStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnStart;
        private RichTextBox richTextBox1;
    }
}