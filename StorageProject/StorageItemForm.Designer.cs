namespace StorageProject
{
    partial class StorageItemForm
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
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Count_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Units_textBox = new System.Windows.Forms.TextBox();
            this.Comment_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Count_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(13, 13);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(247, 20);
            this.Name_textBox.TabIndex = 0;
            // 
            // Count_numericUpDown
            // 
            this.Count_numericUpDown.Location = new System.Drawing.Point(13, 40);
            this.Count_numericUpDown.Name = "Count_numericUpDown";
            this.Count_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.Count_numericUpDown.TabIndex = 1;
            // 
            // Units_textBox
            // 
            this.Units_textBox.Location = new System.Drawing.Point(159, 39);
            this.Units_textBox.Name = "Units_textBox";
            this.Units_textBox.Size = new System.Drawing.Size(100, 20);
            this.Units_textBox.TabIndex = 2;
            // 
            // Comment_textBox
            // 
            this.Comment_textBox.Location = new System.Drawing.Point(13, 213);
            this.Comment_textBox.Multiline = true;
            this.Comment_textBox.Name = "Comment_textBox";
            this.Comment_textBox.Size = new System.Drawing.Size(286, 128);
            this.Comment_textBox.TabIndex = 3;
            // 
            // StorageItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 357);
            this.Controls.Add(this.Comment_textBox);
            this.Controls.Add(this.Units_textBox);
            this.Controls.Add(this.Count_numericUpDown);
            this.Controls.Add(this.Name_textBox);
            this.Name = "StorageItemForm";
            this.Text = "StorageItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.Count_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.NumericUpDown Count_numericUpDown;
        private System.Windows.Forms.TextBox Units_textBox;
        private System.Windows.Forms.TextBox Comment_textBox;
    }
}