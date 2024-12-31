using System;

namespace MessageWall
{
    partial class Dashboard
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
            this.msgAdderTxtBox = new System.Windows.Forms.TextBox();
            this.msgAddLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.msgListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // msgAdderTxtBox
            // 
            this.msgAdderTxtBox.Location = new System.Drawing.Point(502, 134);
            this.msgAdderTxtBox.Name = "msgAdderTxtBox";
            this.msgAdderTxtBox.Size = new System.Drawing.Size(367, 38);
            this.msgAdderTxtBox.TabIndex = 0;
            // 
            // msgAddLabel
            // 
            this.msgAddLabel.AutoSize = true;
            this.msgAddLabel.Location = new System.Drawing.Point(166, 132);
            this.msgAddLabel.Name = "msgAddLabel";
            this.msgAddLabel.Size = new System.Drawing.Size(225, 32);
            this.msgAddLabel.TabIndex = 1;
            this.msgAddLabel.Text = "Write a message";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(932, 120);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(137, 64);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // msgListBox
            // 
            this.msgListBox.FormattingEnabled = true;
            this.msgListBox.ItemHeight = 31;
            this.msgListBox.Location = new System.Drawing.Point(172, 254);
            this.msgListBox.Name = "msgListBox";
            this.msgListBox.Size = new System.Drawing.Size(754, 407);
            this.msgListBox.TabIndex = 3;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 757);
            this.Controls.Add(this.msgListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.msgAddLabel);
            this.Controls.Add(this.msgAdderTxtBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox msgAdderTxtBox;
        private System.Windows.Forms.Label msgAddLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox msgListBox;
    }
}

