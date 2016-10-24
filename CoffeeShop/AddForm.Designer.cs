namespace CoffeeShop
{
    partial class AddRemoveForm
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
            this.tbFlavor = new System.Windows.Forms.TextBox();
            this.lbFlavor = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.mtbPrice = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFlavor
            // 
            this.tbFlavor.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFlavor.Location = new System.Drawing.Point(239, 126);
            this.tbFlavor.Name = "tbFlavor";
            this.tbFlavor.Size = new System.Drawing.Size(239, 37);
            this.tbFlavor.TabIndex = 0;
            // 
            // lbFlavor
            // 
            this.lbFlavor.AutoSize = true;
            this.lbFlavor.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFlavor.Location = new System.Drawing.Point(71, 126);
            this.lbFlavor.Name = "lbFlavor";
            this.lbFlavor.Size = new System.Drawing.Size(108, 39);
            this.lbFlavor.TabIndex = 1;
            this.lbFlavor.Text = "Flavor:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(88, 205);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(91, 39);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "Price:";
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(239, 307);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(123, 41);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Add Flavor";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // mtbPrice
            // 
            this.mtbPrice.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPrice.Location = new System.Drawing.Point(239, 205);
            this.mtbPrice.Mask = "$99.00";
            this.mtbPrice.Name = "mtbPrice";
            this.mtbPrice.Size = new System.Drawing.Size(123, 37);
            this.mtbPrice.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add Coffee Flavor";
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(403, 307);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 41);
            this.btExit.TabIndex = 8;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // AddRemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 460);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbPrice);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbFlavor);
            this.Controls.Add(this.tbFlavor);
            this.Name = "AddRemoveForm";
            this.Text = "Add Coffee Flavor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFlavor;
        private System.Windows.Forms.Label lbFlavor;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.MaskedTextBox mtbPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btExit;
    }
}