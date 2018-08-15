namespace Database_Project
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ItemQuantity = new System.Windows.Forms.NumericUpDown();
            this.ItemCompany = new System.Windows.Forms.ComboBox();
            this.ItemCategory = new System.Windows.Forms.ComboBox();
            this.ItemName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ItemQuantity);
            this.groupBox1.Controls.Add(this.ItemCompany);
            this.groupBox1.Controls.Add(this.ItemCategory);
            this.groupBox1.Controls.Add(this.ItemName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Item to Stock";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.Location = new System.Drawing.Point(90, 123);
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.Size = new System.Drawing.Size(169, 20);
            this.ItemQuantity.TabIndex = 7;
            // 
            // ItemCompany
            // 
            this.ItemCompany.FormattingEnabled = true;
            this.ItemCompany.Location = new System.Drawing.Point(90, 91);
            this.ItemCompany.Name = "ItemCompany";
            this.ItemCompany.Size = new System.Drawing.Size(169, 21);
            this.ItemCompany.TabIndex = 6;
            // 
            // ItemCategory
            // 
            this.ItemCategory.FormattingEnabled = true;
            this.ItemCategory.Location = new System.Drawing.Point(90, 62);
            this.ItemCategory.Name = "ItemCategory";
            this.ItemCategory.Size = new System.Drawing.Size(169, 21);
            this.ItemCategory.TabIndex = 5;
            this.ItemCategory.SelectedIndexChanged += new System.EventHandler(this.ItemCategory_SelectedIndexChanged);
            // 
            // ItemName
            // 
            this.ItemName.Location = new System.Drawing.Point(90, 35);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(169, 20);
            this.ItemName.TabIndex = 4;
            this.ItemName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Company:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(186, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(75, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Add Item to Stock";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 221);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Update Stock";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ItemQuantity;
        private System.Windows.Forms.ComboBox ItemCompany;
        private System.Windows.Forms.ComboBox ItemCategory;
        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}