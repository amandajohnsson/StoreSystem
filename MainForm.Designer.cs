namespace StoreSystem
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
            this.tabcontrol1 = new System.Windows.Forms.TabControl();
            this.cashiertab = new System.Windows.Forms.TabPage();
            this.stocktab = new System.Windows.Forms.TabPage();
            this.tabcontrol1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrol1
            // 
            this.tabcontrol1.Controls.Add(this.cashiertab);
            this.tabcontrol1.Controls.Add(this.stocktab);
            this.tabcontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol1.Location = new System.Drawing.Point(0, 0);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(800, 450);
            this.tabcontrol1.TabIndex = 0;
            // 
            // cashiertab
            // 
            this.cashiertab.Location = new System.Drawing.Point(4, 29);
            this.cashiertab.Name = "cashiertab";
            this.cashiertab.Padding = new System.Windows.Forms.Padding(3);
            this.cashiertab.Size = new System.Drawing.Size(792, 417);
            this.cashiertab.TabIndex = 0;
            this.cashiertab.Text = "Cashier";
            this.cashiertab.UseVisualStyleBackColor = true;
            // 
            // stocktab
            // 
            this.stocktab.Location = new System.Drawing.Point(4, 29);
            this.stocktab.Name = "stocktab";
            this.stocktab.Padding = new System.Windows.Forms.Padding(3);
            this.stocktab.Size = new System.Drawing.Size(792, 417);
            this.stocktab.TabIndex = 1;
            this.stocktab.Text = "Stock";
            this.stocktab.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabcontrol1);
            this.Name = "MainForm";
            this.Text = "Store Managment";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabcontrol1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol1;
        private System.Windows.Forms.TabPage cashiertab;
        private System.Windows.Forms.TabPage stocktab;
    }
}

