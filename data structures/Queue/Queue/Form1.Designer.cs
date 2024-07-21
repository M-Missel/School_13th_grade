namespace Queue
{
    partial class Form1
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
            this.BTN_Add_Input = new System.Windows.Forms.Button();
            this.TB_Input = new System.Windows.Forms.TextBox();
            this.BTN_Remove_Item = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Add_Input
            // 
            this.BTN_Add_Input.Location = new System.Drawing.Point(68, 94);
            this.BTN_Add_Input.Name = "BTN_Add_Input";
            this.BTN_Add_Input.Size = new System.Drawing.Size(100, 43);
            this.BTN_Add_Input.TabIndex = 0;
            this.BTN_Add_Input.Text = "Add Item";
            this.BTN_Add_Input.UseVisualStyleBackColor = true;
            this.BTN_Add_Input.Click += new System.EventHandler(this.BTN_Add_Item_Click);
            // 
            // TB_Input
            // 
            this.TB_Input.Location = new System.Drawing.Point(68, 68);
            this.TB_Input.Name = "TB_Input";
            this.TB_Input.Size = new System.Drawing.Size(100, 20);
            this.TB_Input.TabIndex = 1;
            // 
            // BTN_Remove_Item
            // 
            this.BTN_Remove_Item.Location = new System.Drawing.Point(68, 143);
            this.BTN_Remove_Item.Name = "BTN_Remove_Item";
            this.BTN_Remove_Item.Size = new System.Drawing.Size(100, 43);
            this.BTN_Remove_Item.TabIndex = 2;
            this.BTN_Remove_Item.Text = "Remove Item";
            this.BTN_Remove_Item.UseVisualStyleBackColor = true;
            this.BTN_Remove_Item.Click += new System.EventHandler(this.BTN_Remove_Item_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 190);
            this.Controls.Add(this.BTN_Remove_Item);
            this.Controls.Add(this.TB_Input);
            this.Controls.Add(this.BTN_Add_Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Add_Input;
        private System.Windows.Forms.TextBox TB_Input;
        private System.Windows.Forms.Button BTN_Remove_Item;
    }
}

