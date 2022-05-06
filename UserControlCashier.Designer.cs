namespace StoreSystem
{
    partial class UserControlCashier
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainerCashier = new System.Windows.Forms.SplitContainer();
            this.buttonAddCart = new System.Windows.Forms.Button();
            this.labelStore = new System.Windows.Forms.Label();
            this.dataGridCashier = new System.Windows.Forms.DataGridView();
            this.textBoxReturn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRemoveCart = new System.Windows.Forms.Button();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.labelCart = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCashier)).BeginInit();
            this.splitContainerCashier.Panel1.SuspendLayout();
            this.splitContainerCashier.Panel2.SuspendLayout();
            this.splitContainerCashier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCashier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerCashier
            // 
            this.splitContainerCashier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerCashier.Location = new System.Drawing.Point(0, 0);
            this.splitContainerCashier.Name = "splitContainerCashier";
            // 
            // splitContainerCashier.Panel1
            // 
            this.splitContainerCashier.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainerCashier.Panel1.Controls.Add(this.buttonAddCart);
            this.splitContainerCashier.Panel1.Controls.Add(this.labelStore);
            this.splitContainerCashier.Panel1.Controls.Add(this.dataGridCashier);
            // 
            // splitContainerCashier.Panel2
            // 
            this.splitContainerCashier.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainerCashier.Panel2.Controls.Add(this.textBoxReturn);
            this.splitContainerCashier.Panel2.Controls.Add(this.label1);
            this.splitContainerCashier.Panel2.Controls.Add(this.buttonRemoveCart);
            this.splitContainerCashier.Panel2.Controls.Add(this.dataGridViewCart);
            this.splitContainerCashier.Panel2.Controls.Add(this.textBoxTotalPrice);
            this.splitContainerCashier.Panel2.Controls.Add(this.labelCart);
            this.splitContainerCashier.Panel2.Controls.Add(this.buttonReturn);
            this.splitContainerCashier.Panel2.Controls.Add(this.buttonBuy);
            this.splitContainerCashier.Panel2.Controls.Add(this.labelPrice);
            this.splitContainerCashier.Size = new System.Drawing.Size(879, 532);
            this.splitContainerCashier.SplitterDistance = 428;
            this.splitContainerCashier.TabIndex = 0;
            // 
            // buttonAddCart
            // 
            this.buttonAddCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddCart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddCart.Location = new System.Drawing.Point(28, 483);
            this.buttonAddCart.Name = "buttonAddCart";
            this.buttonAddCart.Size = new System.Drawing.Size(153, 46);
            this.buttonAddCart.TabIndex = 2;
            this.buttonAddCart.Text = "Add to cart";
            this.buttonAddCart.UseVisualStyleBackColor = false;
            this.buttonAddCart.Click += new System.EventHandler(this.buttonAddCart_Click);
            // 
            // labelStore
            // 
            this.labelStore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStore.AutoSize = true;
            this.labelStore.Location = new System.Drawing.Point(3, 10);
            this.labelStore.Name = "labelStore";
            this.labelStore.Size = new System.Drawing.Size(52, 20);
            this.labelStore.TabIndex = 1;
            this.labelStore.Text = "Store:";
            // 
            // dataGridCashier
            // 
            this.dataGridCashier.AllowUserToAddRows = false;
            this.dataGridCashier.AllowUserToDeleteRows = false;
            this.dataGridCashier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCashier.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridCashier.Location = new System.Drawing.Point(3, 33);
            this.dataGridCashier.Name = "dataGridCashier";
            this.dataGridCashier.ReadOnly = true;
            this.dataGridCashier.RowHeadersWidth = 62;
            this.dataGridCashier.RowTemplate.Height = 28;
            this.dataGridCashier.Size = new System.Drawing.Size(422, 427);
            this.dataGridCashier.TabIndex = 0;
            // 
            // textBoxReturn
            // 
            this.textBoxReturn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReturn.Location = new System.Drawing.Point(170, 352);
            this.textBoxReturn.Name = "textBoxReturn";
            this.textBoxReturn.Size = new System.Drawing.Size(123, 26);
            this.textBoxReturn.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID of product to return:";
            // 
            // buttonRemoveCart
            // 
            this.buttonRemoveCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveCart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRemoveCart.Location = new System.Drawing.Point(289, 3);
            this.buttonRemoveCart.Name = "buttonRemoveCart";
            this.buttonRemoveCart.Size = new System.Drawing.Size(155, 30);
            this.buttonRemoveCart.TabIndex = 3;
            this.buttonRemoveCart.Text = "Remove from cart";
            this.buttonRemoveCart.UseVisualStyleBackColor = false;
            this.buttonRemoveCart.Click += new System.EventHandler(this.buttonRemoveCart_Click);
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Location = new System.Drawing.Point(3, 33);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.RowHeadersWidth = 62;
            this.dataGridViewCart.RowTemplate.Height = 28;
            this.dataGridViewCart.Size = new System.Drawing.Size(441, 254);
            this.dataGridViewCart.TabIndex = 10;
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotalPrice.Location = new System.Drawing.Point(118, 299);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.ReadOnly = true;
            this.textBoxTotalPrice.Size = new System.Drawing.Size(175, 26);
            this.textBoxTotalPrice.TabIndex = 9;
            // 
            // labelCart
            // 
            this.labelCart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCart.AutoSize = true;
            this.labelCart.Location = new System.Drawing.Point(13, 10);
            this.labelCart.Name = "labelCart";
            this.labelCart.Size = new System.Drawing.Size(112, 20);
            this.labelCart.TabIndex = 7;
            this.labelCart.Text = "Shopping cart:";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReturn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReturn.Location = new System.Drawing.Point(318, 350);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(106, 31);
            this.buttonReturn.TabIndex = 5;
            this.buttonReturn.Text = "Return Item";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBuy.Location = new System.Drawing.Point(318, 293);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(93, 38);
            this.buttonBuy.TabIndex = 3;
            this.buttonBuy.Text = "Purchase";
            this.buttonBuy.UseVisualStyleBackColor = false;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(13, 302);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(87, 20);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Total Price:";
            // 
            // UserControlCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.splitContainerCashier);
            this.Name = "UserControlCashier";
            this.Size = new System.Drawing.Size(879, 532);
            this.splitContainerCashier.Panel1.ResumeLayout(false);
            this.splitContainerCashier.Panel1.PerformLayout();
            this.splitContainerCashier.Panel2.ResumeLayout(false);
            this.splitContainerCashier.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCashier)).EndInit();
            this.splitContainerCashier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCashier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerCashier;
        private System.Windows.Forms.DataGridView dataGridCashier;
        private System.Windows.Forms.Label labelStore;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonRemoveCart;
        private System.Windows.Forms.Button buttonAddCart;
        private System.Windows.Forms.Label labelCart;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.TextBox textBoxReturn;
        private System.Windows.Forms.Label label1;
    }
}
