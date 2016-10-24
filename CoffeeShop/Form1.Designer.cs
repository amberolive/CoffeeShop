namespace CoffeeShop
{
    partial class CoffeeShopAdmin
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
            this.cbFlavor = new System.Windows.Forms.ComboBox();
            this.clbSyrup = new System.Windows.Forms.CheckedListBox();
            this.lbDisplayCoffee = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countFlavorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFlavorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFlavorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFlavorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btDisplay = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coffee Shop";
            // 
            // cbFlavor
            // 
            this.cbFlavor.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFlavor.FormattingEnabled = true;
            this.cbFlavor.IntegralHeight = false;
            this.cbFlavor.Location = new System.Drawing.Point(89, 151);
            this.cbFlavor.Name = "cbFlavor";
            this.cbFlavor.Size = new System.Drawing.Size(262, 47);
            this.cbFlavor.TabIndex = 1;
            this.cbFlavor.Text = "Coffee Flavor";
            // 
            // clbSyrup
            // 
            this.clbSyrup.CheckOnClick = true;
            this.clbSyrup.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbSyrup.FormattingEnabled = true;
            this.clbSyrup.Items.AddRange(new object[] {
            "Caramel",
            "Hazlenut",
            "Vanilla",
            "Irish Cream",
            "Pumpkin Spice",
            "Rasberry"});
            this.clbSyrup.Location = new System.Drawing.Point(471, 194);
            this.clbSyrup.Name = "clbSyrup";
            this.clbSyrup.Size = new System.Drawing.Size(219, 196);
            this.clbSyrup.TabIndex = 2;
            this.clbSyrup.Tag = "Syrup";
            this.clbSyrup.ThreeDCheckBoxes = true;
            // 
            // lbDisplayCoffee
            // 
            this.lbDisplayCoffee.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDisplayCoffee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDisplayCoffee.Location = new System.Drawing.Point(836, 151);
            this.lbDisplayCoffee.Name = "lbDisplayCoffee";
            this.lbDisplayCoffee.Size = new System.Drawing.Size(282, 243);
            this.lbDisplayCoffee.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(471, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "Syrups";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1242, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countFlavorsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // countFlavorsToolStripMenuItem
            // 
            this.countFlavorsToolStripMenuItem.Name = "countFlavorsToolStripMenuItem";
            this.countFlavorsToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.countFlavorsToolStripMenuItem.Text = "Count Flavors";
            this.countFlavorsToolStripMenuItem.Click += new System.EventHandler(this.countFlavorsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFlavorToolStripMenuItem1,
            this.removeFlavorToolStripMenuItem,
            this.clearFlavorsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addFlavorToolStripMenuItem1
            // 
            this.addFlavorToolStripMenuItem1.Name = "addFlavorToolStripMenuItem1";
            this.addFlavorToolStripMenuItem1.Size = new System.Drawing.Size(214, 30);
            this.addFlavorToolStripMenuItem1.Text = "Add Flavor";
            this.addFlavorToolStripMenuItem1.Click += new System.EventHandler(this.addFlavorToolStripMenuItem1_Click);
            // 
            // removeFlavorToolStripMenuItem
            // 
            this.removeFlavorToolStripMenuItem.Name = "removeFlavorToolStripMenuItem";
            this.removeFlavorToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.removeFlavorToolStripMenuItem.Text = "Remove Flavor";
            this.removeFlavorToolStripMenuItem.Click += new System.EventHandler(this.removeFlavorToolStripMenuItem_Click);
            // 
            // clearFlavorsToolStripMenuItem
            // 
            this.clearFlavorsToolStripMenuItem.Name = "clearFlavorsToolStripMenuItem";
            this.clearFlavorsToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.clearFlavorsToolStripMenuItem.Text = "Clear Flavors";
            this.clearFlavorsToolStripMenuItem.Click += new System.EventHandler(this.clearFlavorsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(147, 30);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btDisplay
            // 
            this.btDisplay.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDisplay.Location = new System.Drawing.Point(836, 406);
            this.btDisplay.Name = "btDisplay";
            this.btDisplay.Size = new System.Drawing.Size(282, 48);
            this.btDisplay.TabIndex = 7;
            this.btDisplay.Text = "Display Information";
            this.btDisplay.UseVisualStyleBackColor = true;
            this.btDisplay.Click += new System.EventHandler(this.btDisplay_Click);
            // 
            // CoffeeShopAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 509);
            this.Controls.Add(this.btDisplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbDisplayCoffee);
            this.Controls.Add(this.clbSyrup);
            this.Controls.Add(this.cbFlavor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CoffeeShopAdmin";
            this.Text = "Coffee Shop Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFlavor;
        private System.Windows.Forms.CheckedListBox clbSyrup;
        private System.Windows.Forms.Label lbDisplayCoffee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countFlavorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearFlavorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFlavorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFlavorToolStripMenuItem1;
        private System.Windows.Forms.Button btDisplay;
    }
}

