namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.MaskedTextBox();
            this.lblPurchaedDate = new System.Windows.Forms.Label();
            this.dtPurchased = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(45, 45);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 28);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(220, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(433, 34);
            this.txtName.TabIndex = 1;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(220, 114);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(433, 166);
            this.txtDesc.TabIndex = 3;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesc.Location = new System.Drawing.Point(45, 117);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(112, 28);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Description";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(45, 318);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(54, 28);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(224, 317);
            this.txtPrice.Mask = "000000000.00";
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(429, 34);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.ValidatingType = typeof(int);
            // 
            // lblPurchaedDate
            // 
            this.lblPurchaedDate.AutoSize = true;
            this.lblPurchaedDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPurchaedDate.Location = new System.Drawing.Point(45, 395);
            this.lblPurchaedDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPurchaedDate.Name = "lblPurchaedDate";
            this.lblPurchaedDate.Size = new System.Drawing.Size(147, 28);
            this.lblPurchaedDate.TabIndex = 6;
            this.lblPurchaedDate.Text = "Purchased Date";
            // 
            // dtPurchased
            // 
            this.dtPurchased.Location = new System.Drawing.Point(220, 390);
            this.dtPurchased.Name = "dtPurchased";
            this.dtPurchased.Size = new System.Drawing.Size(433, 34);
            this.dtPurchased.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(449, 506);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(204, 61);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(220, 506);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(206, 61);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 611);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dtPurchased);
            this.Controls.Add(this.lblPurchaedDate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Test Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private TextBox txtDesc;
        private Label lblDesc;
        private Label lblPrice;
        private MaskedTextBox txtPrice;
        private Label lblPurchaedDate;
        private DateTimePicker dtPurchased;
        private Button btnSubmit;
        private Button btnReset;
    }
}