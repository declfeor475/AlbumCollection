namespace Album_Collection
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.albumInput = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.originalLabel = new System.Windows.Forms.Label();
            this.sortedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Album Information";
            // 
            // albumInput
            // 
            this.albumInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.albumInput.Location = new System.Drawing.Point(237, 18);
            this.albumInput.Name = "albumInput";
            this.albumInput.Size = new System.Drawing.Size(309, 26);
            this.albumInput.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addButton.Location = new System.Drawing.Point(567, 14);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(92, 39);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.removeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeButton.Location = new System.Drawing.Point(686, 14);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(92, 39);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(39, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Original Order:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(427, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sorted Order:";
            // 
            // originalLabel
            // 
            this.originalLabel.BackColor = System.Drawing.Color.White;
            this.originalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.originalLabel.Location = new System.Drawing.Point(39, 107);
            this.originalLabel.Name = "originalLabel";
            this.originalLabel.Size = new System.Drawing.Size(351, 248);
            this.originalLabel.TabIndex = 6;
            // 
            // sortedLabel
            // 
            this.sortedLabel.BackColor = System.Drawing.Color.White;
            this.sortedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sortedLabel.Location = new System.Drawing.Point(427, 107);
            this.sortedLabel.Name = "sortedLabel";
            this.sortedLabel.Size = new System.Drawing.Size(351, 248);
            this.sortedLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sortedLabel);
            this.Controls.Add(this.originalLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.albumInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Album Collection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox albumInput;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label originalLabel;
        private System.Windows.Forms.Label sortedLabel;
    }
}

