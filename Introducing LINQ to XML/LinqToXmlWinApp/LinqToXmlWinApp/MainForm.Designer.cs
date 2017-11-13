namespace LinqToXmlWinApp
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
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLookUpColors = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMakeToLookUp = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInventory
            // 
            this.txtInventory.Location = new System.Drawing.Point(12, 36);
            this.txtInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtInventory.Multiline = true;
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInventory.Size = new System.Drawing.Size(278, 215);
            this.txtInventory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Inventory";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddNewItem);
            this.groupBox1.Controls.Add(this.txtPetName);
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMake);
            this.groupBox1.Location = new System.Drawing.Point(336, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(304, 156);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Inventory Item";
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.Location = new System.Drawing.Point(196, 114);
            this.btnAddNewItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(90, 23);
            this.btnAddNewItem.TabIndex = 6;
            this.btnAddNewItem.Text = "Add";
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // txtPetName
            // 
            this.txtPetName.Location = new System.Drawing.Point(106, 78);
            this.txtPetName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(182, 20);
            this.txtPetName.TabIndex = 5;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(106, 49);
            this.txtColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(182, 20);
            this.txtColor.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pet Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Make";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(106, 19);
            this.txtMake.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(182, 20);
            this.txtMake.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLookUpColors);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMakeToLookUp);
            this.groupBox2.Location = new System.Drawing.Point(336, 227);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(304, 107);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Look up  Colors for Make";
            // 
            // btnLookUpColors
            // 
            this.btnLookUpColors.Location = new System.Drawing.Point(148, 71);
            this.btnLookUpColors.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLookUpColors.Name = "btnLookUpColors";
            this.btnLookUpColors.Size = new System.Drawing.Size(142, 23);
            this.btnLookUpColors.TabIndex = 2;
            this.btnLookUpColors.Text = "Look Up Colors";
            this.btnLookUpColors.UseVisualStyleBackColor = true;
            this.btnLookUpColors.Click += new System.EventHandler(this.btnLookUpColors_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Make to Look Up";
            // 
            // txtMakeToLookUp
            // 
            this.txtMakeToLookUp.Location = new System.Drawing.Point(148, 33);
            this.txtMakeToLookUp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMakeToLookUp.Name = "txtMakeToLookUp";
            this.txtMakeToLookUp.Size = new System.Drawing.Size(140, 20);
            this.txtMakeToLookUp.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 354);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInventory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Fun With LINQ to XML";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLookUpColors;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMakeToLookUp;
    }
}

