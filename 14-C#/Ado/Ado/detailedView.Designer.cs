namespace Ado
{
    partial class detailedView
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prdidLable = new System.Windows.Forms.Label();
            this.prdName = new System.Windows.Forms.TextBox();
            this.catName = new System.Windows.Forms.ComboBox();
            this.supName = new System.Windows.Forms.ComboBox();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(619, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 404);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Supplier Name";
            // 
            // prdidLable
            // 
            this.prdidLable.AutoSize = true;
            this.prdidLable.Location = new System.Drawing.Point(223, 83);
            this.prdidLable.Name = "prdidLable";
            this.prdidLable.Size = new System.Drawing.Size(50, 20);
            this.prdidLable.TabIndex = 5;
            this.prdidLable.Text = "label5";
            // 
            // prdName
            // 
            this.prdName.Location = new System.Drawing.Point(223, 147);
            this.prdName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prdName.Name = "prdName";
            this.prdName.Size = new System.Drawing.Size(204, 27);
            this.prdName.TabIndex = 6;
            // 
            // catName
            // 
            this.catName.FormattingEnabled = true;
            this.catName.Location = new System.Drawing.Point(223, 212);
            this.catName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.catName.Name = "catName";
            this.catName.Size = new System.Drawing.Size(204, 28);
            this.catName.TabIndex = 7;
            // 
            // supName
            // 
            this.supName.FormattingEnabled = true;
            this.supName.Location = new System.Drawing.Point(223, 272);
            this.supName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.supName.Name = "supName";
            this.supName.Size = new System.Drawing.Size(204, 28);
            this.supName.TabIndex = 8;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(327, 3);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(94, 29);
            this.save.TabIndex = 9;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // detailedView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.save);
            this.Controls.Add(this.supName);
            this.Controls.Add(this.catName);
            this.Controls.Add(this.prdName);
            this.Controls.Add(this.prdidLable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "detailedView";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.detailedView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label prdidLable;
        private TextBox prdName;
        private ComboBox catName;
        private ComboBox supName;
        private Button save;
    }
}