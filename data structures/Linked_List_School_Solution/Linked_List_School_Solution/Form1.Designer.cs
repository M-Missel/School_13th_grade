namespace Linked_List_School_Solution
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
            this.BTN_Einfuegen = new System.Windows.Forms.Button();
            this.BTN_Inhalt = new System.Windows.Forms.Button();
            this.BTN_Entfernen = new System.Windows.Forms.Button();
            this.BTN_Ausgeben = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_Index = new System.Windows.Forms.TextBox();
            this.TB_Ausgabe = new System.Windows.Forms.TextBox();
            this.LB_Output = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BTN_Einfuegen
            // 
            this.BTN_Einfuegen.Location = new System.Drawing.Point(95, 107);
            this.BTN_Einfuegen.Name = "BTN_Einfuegen";
            this.BTN_Einfuegen.Size = new System.Drawing.Size(95, 39);
            this.BTN_Einfuegen.TabIndex = 0;
            this.BTN_Einfuegen.Text = "einfügen";
            this.BTN_Einfuegen.UseVisualStyleBackColor = true;
            this.BTN_Einfuegen.Click += new System.EventHandler(this.BTN_Einfuegen_Click);
            // 
            // BTN_Inhalt
            // 
            this.BTN_Inhalt.Location = new System.Drawing.Point(95, 152);
            this.BTN_Inhalt.Name = "BTN_Inhalt";
            this.BTN_Inhalt.Size = new System.Drawing.Size(95, 39);
            this.BTN_Inhalt.TabIndex = 1;
            this.BTN_Inhalt.Text = "Inhalt";
            this.BTN_Inhalt.UseVisualStyleBackColor = true;
            this.BTN_Inhalt.Click += new System.EventHandler(this.BTN_Inhalt_Click);
            // 
            // BTN_Entfernen
            // 
            this.BTN_Entfernen.Location = new System.Drawing.Point(95, 254);
            this.BTN_Entfernen.Name = "BTN_Entfernen";
            this.BTN_Entfernen.Size = new System.Drawing.Size(95, 39);
            this.BTN_Entfernen.TabIndex = 2;
            this.BTN_Entfernen.Text = "entfernen";
            this.BTN_Entfernen.UseVisualStyleBackColor = true;
            this.BTN_Entfernen.Click += new System.EventHandler(this.BTN_Entfernen_Click);
            // 
            // BTN_Ausgeben
            // 
            this.BTN_Ausgeben.Location = new System.Drawing.Point(433, 254);
            this.BTN_Ausgeben.Name = "BTN_Ausgeben";
            this.BTN_Ausgeben.Size = new System.Drawing.Size(95, 39);
            this.BTN_Ausgeben.TabIndex = 3;
            this.BTN_Ausgeben.Text = "ausgeben";
            this.BTN_Ausgeben.UseVisualStyleBackColor = true;
            this.BTN_Ausgeben.Click += new System.EventHandler(this.BTN_Ausgeben_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Index";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ausgabe:";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(108, 32);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(100, 20);
            this.TB_Name.TabIndex = 7;
            // 
            // TB_Index
            // 
            this.TB_Index.Location = new System.Drawing.Point(108, 70);
            this.TB_Index.Name = "TB_Index";
            this.TB_Index.Size = new System.Drawing.Size(100, 20);
            this.TB_Index.TabIndex = 8;
            // 
            // TB_Ausgabe
            // 
            this.TB_Ausgabe.Location = new System.Drawing.Point(433, 335);
            this.TB_Ausgabe.Name = "TB_Ausgabe";
            this.TB_Ausgabe.Size = new System.Drawing.Size(100, 20);
            this.TB_Ausgabe.TabIndex = 9;
            // 
            // LB_Output
            // 
            this.LB_Output.FormattingEnabled = true;
            this.LB_Output.Location = new System.Drawing.Point(433, 32);
            this.LB_Output.Name = "LB_Output";
            this.LB_Output.Size = new System.Drawing.Size(175, 212);
            this.LB_Output.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LB_Output);
            this.Controls.Add(this.TB_Ausgabe);
            this.Controls.Add(this.TB_Index);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Ausgeben);
            this.Controls.Add(this.BTN_Entfernen);
            this.Controls.Add(this.BTN_Inhalt);
            this.Controls.Add(this.BTN_Einfuegen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Einfuegen;
        private System.Windows.Forms.Button BTN_Inhalt;
        private System.Windows.Forms.Button BTN_Entfernen;
        private System.Windows.Forms.Button BTN_Ausgeben;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_Index;
        private System.Windows.Forms.TextBox TB_Ausgabe;
        private System.Windows.Forms.ListBox LB_Output;
    }
}

