namespace LunchOrderApplication
{
    partial class LunchOrder
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
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.rdoSalad = new System.Windows.Forms.RadioButton();
            this.rdoPizza = new System.Windows.Forms.RadioButton();
            this.rdoHamburger = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.grpBox3 = new System.Windows.Forms.GroupBox();
            this.chkBox5 = new System.Windows.Forms.CheckBox();
            this.chkBox4 = new System.Windows.Forms.CheckBox();
            this.chkBox3 = new System.Windows.Forms.CheckBox();
            this.chkBox2 = new System.Windows.Forms.CheckBox();
            this.chkBox1 = new System.Windows.Forms.CheckBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBox2.SuspendLayout();
            this.grpBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox1
            // 
            this.grpBox1.BackColor = System.Drawing.Color.Transparent;
            this.grpBox1.Controls.Add(this.rdoSalad);
            this.grpBox1.Controls.Add(this.rdoPizza);
            this.grpBox1.Controls.Add(this.rdoHamburger);
            this.grpBox1.Controls.Add(this.pictureBox1);
            this.grpBox1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox1.Location = new System.Drawing.Point(22, 24);
            this.grpBox1.Margin = new System.Windows.Forms.Padding(4);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Padding = new System.Windows.Forms.Padding(4);
            this.grpBox1.Size = new System.Drawing.Size(389, 240);
            this.grpBox1.TabIndex = 0;
            this.grpBox1.TabStop = false;
            this.grpBox1.Text = "LUNCH MENU";
            // 
            // rdoSalad
            // 
            this.rdoSalad.AutoSize = true;
            this.rdoSalad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSalad.Location = new System.Drawing.Point(8, 140);
            this.rdoSalad.Margin = new System.Windows.Forms.Padding(4);
            this.rdoSalad.Name = "rdoSalad";
            this.rdoSalad.Size = new System.Drawing.Size(123, 23);
            this.rdoSalad.TabIndex = 3;
            this.rdoSalad.TabStop = true;
            this.rdoSalad.Text = "Salad - $4.95";
            this.rdoSalad.UseVisualStyleBackColor = true;
            this.rdoSalad.CheckedChanged += new System.EventHandler(this.rdoSalad_CheckedChanged);
            // 
            // rdoPizza
            // 
            this.rdoPizza.AutoSize = true;
            this.rdoPizza.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPizza.Location = new System.Drawing.Point(8, 89);
            this.rdoPizza.Margin = new System.Windows.Forms.Padding(4);
            this.rdoPizza.Name = "rdoPizza";
            this.rdoPizza.Size = new System.Drawing.Size(122, 23);
            this.rdoPizza.TabIndex = 2;
            this.rdoPizza.TabStop = true;
            this.rdoPizza.Text = "Pizza - $5.95";
            this.rdoPizza.UseVisualStyleBackColor = true;
            this.rdoPizza.CheckedChanged += new System.EventHandler(this.rdoPizza_CheckedChanged);
            // 
            // rdoHamburger
            // 
            this.rdoHamburger.AutoSize = true;
            this.rdoHamburger.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoHamburger.Location = new System.Drawing.Point(8, 33);
            this.rdoHamburger.Margin = new System.Windows.Forms.Padding(4);
            this.rdoHamburger.Name = "rdoHamburger";
            this.rdoHamburger.Size = new System.Drawing.Size(166, 23);
            this.rdoHamburger.TabIndex = 1;
            this.rdoHamburger.TabStop = true;
            this.rdoHamburger.Text = "Hamburger - $6.95";
            this.rdoHamburger.UseVisualStyleBackColor = true;
            this.rdoHamburger.CheckedChanged += new System.EventHandler(this.rdoHamburger_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(185, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grpBox2
            // 
            this.grpBox2.BackColor = System.Drawing.Color.Transparent;
            this.grpBox2.Controls.Add(this.txtTotal);
            this.grpBox2.Controls.Add(this.txtTax);
            this.grpBox2.Controls.Add(this.txtSubTotal);
            this.grpBox2.Controls.Add(this.lblTotal);
            this.grpBox2.Controls.Add(this.lblTax);
            this.grpBox2.Controls.Add(this.lblSubTotal);
            this.grpBox2.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox2.Location = new System.Drawing.Point(22, 273);
            this.grpBox2.Margin = new System.Windows.Forms.Padding(4);
            this.grpBox2.Name = "grpBox2";
            this.grpBox2.Padding = new System.Windows.Forms.Padding(4);
            this.grpBox2.Size = new System.Drawing.Size(206, 166);
            this.grpBox2.TabIndex = 0;
            this.grpBox2.TabStop = false;
            this.grpBox2.Text = "Order Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTotal.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(99, 113);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 5;
            // 
            // txtTax
            // 
            this.txtTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTax.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTax.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(99, 75);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 26);
            this.txtTax.TabIndex = 4;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSubTotal.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(99, 37);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(100, 26);
            this.txtSubTotal.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(6, 121);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 19);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(6, 79);
            this.lblTax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(81, 19);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "Tax (5%):";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(6, 37);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(88, 19);
            this.lblSubTotal.TabIndex = 0;
            this.lblSubTotal.Text = "Sub-Total:";
            // 
            // grpBox3
            // 
            this.grpBox3.BackColor = System.Drawing.Color.Transparent;
            this.grpBox3.Controls.Add(this.chkBox5);
            this.grpBox3.Controls.Add(this.chkBox4);
            this.grpBox3.Controls.Add(this.chkBox3);
            this.grpBox3.Controls.Add(this.chkBox2);
            this.grpBox3.Controls.Add(this.chkBox1);
            this.grpBox3.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox3.Location = new System.Drawing.Point(473, 24);
            this.grpBox3.Margin = new System.Windows.Forms.Padding(4);
            this.grpBox3.Name = "grpBox3";
            this.grpBox3.Padding = new System.Windows.Forms.Padding(4);
            this.grpBox3.Size = new System.Drawing.Size(245, 250);
            this.grpBox3.TabIndex = 0;
            this.grpBox3.TabStop = false;
            this.grpBox3.Text = "ADD ON ITEMS($0.75/EACH)";
            // 
            // chkBox5
            // 
            this.chkBox5.AutoSize = true;
            this.chkBox5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox5.Location = new System.Drawing.Point(7, 200);
            this.chkBox5.Name = "chkBox5";
            this.chkBox5.Size = new System.Drawing.Size(99, 22);
            this.chkBox5.TabIndex = 8;
            this.chkBox5.Text = "Extra Ham";
            this.chkBox5.UseVisualStyleBackColor = true;
            // 
            // chkBox4
            // 
            this.chkBox4.AutoSize = true;
            this.chkBox4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox4.Location = new System.Drawing.Point(7, 154);
            this.chkBox4.Name = "chkBox4";
            this.chkBox4.Size = new System.Drawing.Size(138, 22);
            this.chkBox4.TabIndex = 7;
            this.chkBox4.Text = "Sweet Potatoes";
            this.chkBox4.UseVisualStyleBackColor = true;
            // 
            // chkBox3
            // 
            this.chkBox3.AutoSize = true;
            this.chkBox3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox3.Location = new System.Drawing.Point(7, 111);
            this.chkBox3.Name = "chkBox3";
            this.chkBox3.Size = new System.Drawing.Size(117, 22);
            this.chkBox3.TabIndex = 6;
            this.chkBox3.Text = "French Fries";
            this.chkBox3.UseVisualStyleBackColor = true;
            // 
            // chkBox2
            // 
            this.chkBox2.AutoSize = true;
            this.chkBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox2.Location = new System.Drawing.Point(7, 65);
            this.chkBox2.Name = "chkBox2";
            this.chkBox2.Size = new System.Drawing.Size(233, 22);
            this.chkBox2.TabIndex = 5;
            this.chkBox2.Text = "Ketch-up, Mustard, and Mayo";
            this.chkBox2.UseVisualStyleBackColor = true;
            // 
            // chkBox1
            // 
            this.chkBox1.AutoSize = true;
            this.chkBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox1.Location = new System.Drawing.Point(7, 27);
            this.chkBox1.Name = "chkBox1";
            this.chkBox1.Size = new System.Drawing.Size(223, 22);
            this.chkBox1.TabIndex = 4;
            this.chkBox1.Text = "Lettuce, tomato, and onions";
            this.chkBox1.UseVisualStyleBackColor = true;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(515, 285);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(145, 44);
            this.btnPlaceOrder.TabIndex = 1;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(515, 334);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(145, 40);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(515, 398);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 45);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LunchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 456);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.grpBox2);
            this.Controls.Add(this.grpBox3);
            this.Controls.Add(this.grpBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LunchOrder";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Lunch Order";
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBox2.ResumeLayout(false);
            this.grpBox2.PerformLayout();
            this.grpBox3.ResumeLayout(false);
            this.grpBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpBox2;
        private System.Windows.Forms.GroupBox grpBox3;
        private System.Windows.Forms.RadioButton rdoSalad;
        private System.Windows.Forms.RadioButton rdoPizza;
        private System.Windows.Forms.RadioButton rdoHamburger;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.CheckBox chkBox3;
        private System.Windows.Forms.CheckBox chkBox2;
        private System.Windows.Forms.CheckBox chkBox1;
        private System.Windows.Forms.CheckBox chkBox5;
        private System.Windows.Forms.CheckBox chkBox4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubTotal;
    }
}

