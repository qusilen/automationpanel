namespace lastpanel
{
    partial class recipeForm
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
            this.recipeNameTextBox = new System.Windows.Forms.TextBox();
            this.floatValTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shortValTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pullDataButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(185, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reçete Adı:";
            // 
            // recipeNameTextBox
            // 
            this.recipeNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recipeNameTextBox.Location = new System.Drawing.Point(325, 106);
            this.recipeNameTextBox.Name = "recipeNameTextBox";
            this.recipeNameTextBox.Size = new System.Drawing.Size(220, 30);
            this.recipeNameTextBox.TabIndex = 1;
            // 
            // floatValTextBox
            // 
            this.floatValTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.floatValTextBox.Location = new System.Drawing.Point(325, 168);
            this.floatValTextBox.Name = "floatValTextBox";
            this.floatValTextBox.Size = new System.Drawing.Size(220, 30);
            this.floatValTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(178, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Float Değer:";
            // 
            // shortValTextBox
            // 
            this.shortValTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.shortValTextBox.Location = new System.Drawing.Point(325, 233);
            this.shortValTextBox.Name = "shortValTextBox";
            this.shortValTextBox.Size = new System.Drawing.Size(220, 30);
            this.shortValTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(174, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Short Değer:";
            // 
            // pullDataButton
            // 
            this.pullDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pullDataButton.Location = new System.Drawing.Point(296, 321);
            this.pullDataButton.Name = "pullDataButton";
            this.pullDataButton.Size = new System.Drawing.Size(125, 80);
            this.pullDataButton.TabIndex = 6;
            this.pullDataButton.Text = "Değerleri Makineden Çek";
            this.pullDataButton.UseVisualStyleBackColor = true;
            this.pullDataButton.Click += new System.EventHandler(this.pullDataButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.Location = new System.Drawing.Point(440, 321);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(125, 80);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Reçeteyi Kaydet";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(310, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reçete Kaydet";
            // 
            // recipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pullDataButton);
            this.Controls.Add(this.shortValTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.floatValTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recipeNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "recipeForm";
            this.Text = "receteForm";
            this.Load += new System.EventHandler(this.receteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox recipeNameTextBox;
        private System.Windows.Forms.TextBox floatValTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox shortValTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pullDataButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
    }
}