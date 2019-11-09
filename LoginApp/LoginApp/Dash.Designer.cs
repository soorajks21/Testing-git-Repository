namespace LoginApp
{
    partial class Dash
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
            this.addAccountBtn = new System.Windows.Forms.Button();
            this.addOrderBtn = new System.Windows.Forms.Button();
            this.deleteOrderBtn = new System.Windows.Forms.Button();
            this.qestionBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addAccountBtn
            // 
            this.addAccountBtn.Location = new System.Drawing.Point(308, 82);
            this.addAccountBtn.Name = "addAccountBtn";
            this.addAccountBtn.Size = new System.Drawing.Size(182, 23);
            this.addAccountBtn.TabIndex = 0;
            this.addAccountBtn.Text = "Add an Account";
            this.addAccountBtn.UseVisualStyleBackColor = true;
            this.addAccountBtn.Click += new System.EventHandler(this.addAccountBtn_Click);
            // 
            // addOrderBtn
            // 
            this.addOrderBtn.Location = new System.Drawing.Point(308, 155);
            this.addOrderBtn.Name = "addOrderBtn";
            this.addOrderBtn.Size = new System.Drawing.Size(182, 23);
            this.addOrderBtn.TabIndex = 1;
            this.addOrderBtn.Text = "Add Order";
            this.addOrderBtn.UseVisualStyleBackColor = true;
            this.addOrderBtn.Click += new System.EventHandler(this.addOrderBtn_Click);
            // 
            // deleteOrderBtn
            // 
            this.deleteOrderBtn.Location = new System.Drawing.Point(308, 227);
            this.deleteOrderBtn.Name = "deleteOrderBtn";
            this.deleteOrderBtn.Size = new System.Drawing.Size(182, 23);
            this.deleteOrderBtn.TabIndex = 2;
            this.deleteOrderBtn.Text = "Delete an Order";
            this.deleteOrderBtn.UseVisualStyleBackColor = true;
            this.deleteOrderBtn.Click += new System.EventHandler(this.deleteOrderBtn_Click);
            // 
            // qestionBtn
            // 
            this.qestionBtn.Location = new System.Drawing.Point(308, 310);
            this.qestionBtn.Name = "qestionBtn";
            this.qestionBtn.Size = new System.Drawing.Size(182, 23);
            this.qestionBtn.TabIndex = 3;
            this.qestionBtn.Text = "Ask Question?";
            this.qestionBtn.UseVisualStyleBackColor = true;
            this.qestionBtn.Click += new System.EventHandler(this.qestionBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "What do you want to do?";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(605, 385);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // Dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qestionBtn);
            this.Controls.Add(this.deleteOrderBtn);
            this.Controls.Add(this.addOrderBtn);
            this.Controls.Add(this.addAccountBtn);
            this.Name = "Dash";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addAccountBtn;
        private System.Windows.Forms.Button addOrderBtn;
        private System.Windows.Forms.Button deleteOrderBtn;
        private System.Windows.Forms.Button qestionBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitBtn;
    }
}