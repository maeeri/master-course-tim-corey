﻿namespace TestingEvents
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
            button1 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AllowDrop = true;
            button1.BackColor = Color.Coral;
            button1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Cornsilk;
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point(240, 153);
            button1.Name = "button1";
            button1.Size = new Size(250, 75);
            button1.TabIndex = 0;
            button1.Text = "Click me!";
            button1.TextImageRelation = TextImageRelation.TextAboveImage;
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = false;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.InfoText;
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(55, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 1;
            panel1.Text = "Hello World!";
            panel1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "FirstForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
    }
}
