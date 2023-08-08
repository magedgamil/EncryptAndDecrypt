
namespace EncAndDec
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDecrypted = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtEncrypted = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBKey = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtDecrypted
            // 
            this.TxtDecrypted.Location = new System.Drawing.Point(208, 120);
            this.TxtDecrypted.Multiline = true;
            this.TxtDecrypted.Name = "TxtDecrypted";
            this.TxtDecrypted.ReadOnly = true;
            this.TxtDecrypted.Size = new System.Drawing.Size(471, 32);
            this.TxtDecrypted.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Location = new System.Drawing.Point(8, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Encrypted Value";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtEncrypted
            // 
            this.TxtEncrypted.Location = new System.Drawing.Point(208, 72);
            this.TxtEncrypted.Multiline = true;
            this.TxtEncrypted.Name = "TxtEncrypted";
            this.TxtEncrypted.Size = new System.Drawing.Size(471, 32);
            this.TxtEncrypted.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label3.Location = new System.Drawing.Point(8, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Decrypted Value";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CBKey
            // 
            this.CBKey.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBKey.FormattingEnabled = true;
            this.CBKey.Items.AddRange(new object[] {
            "Sales12345",
            "ePMS4321",
            "MahaAlgorithm"});
            this.CBKey.Location = new System.Drawing.Point(208, 16);
            this.CBKey.Name = "CBKey";
            this.CBKey.Size = new System.Drawing.Size(471, 23);
            this.CBKey.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.Location = new System.Drawing.Point(299, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 42);
            this.button3.TabIndex = 10;
            this.button3.Text = "Decrypt";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 222);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.CBKey);
            this.Controls.Add(this.TxtEncrypted);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDecrypted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDecrypted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtEncrypted;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBKey;
        private System.Windows.Forms.Button button3;
    }
}

