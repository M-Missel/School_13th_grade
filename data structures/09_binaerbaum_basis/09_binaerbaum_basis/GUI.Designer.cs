namespace _09_binaerbaum_basis
{
    partial class GUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.GB_Output = new GraphVizBmp.Graph2Bitmap();
            this.BTN_Zahlenbaum = new System.Windows.Forms.Button();
            this.BTN_Tierbaum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GB_Output
            // 
            this.GB_Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GB_Output.GraphVizDir = GraphVizBmp.GraphVizDir.Vertical;
            this.GB_Output.GraphVizPath = "graphviz";
            this.GB_Output.Location = new System.Drawing.Point(150, 31);
            this.GB_Output.Name = "GB_Output";
            this.GB_Output.Size = new System.Drawing.Size(526, 251);
            this.GB_Output.TabIndex = 0;
            // 
            // BTN_Zahlenbaum
            // 
            this.BTN_Zahlenbaum.Location = new System.Drawing.Point(12, 31);
            this.BTN_Zahlenbaum.Name = "BTN_Zahlenbaum";
            this.BTN_Zahlenbaum.Size = new System.Drawing.Size(132, 73);
            this.BTN_Zahlenbaum.TabIndex = 1;
            this.BTN_Zahlenbaum.Text = "erstelle Zahlenbaum";
            this.BTN_Zahlenbaum.UseVisualStyleBackColor = true;
            this.BTN_Zahlenbaum.Click += new System.EventHandler(this.B_erstelleZahlenbaum_Click);
            // 
            // BTN_Tierbaum
            // 
            this.BTN_Tierbaum.Location = new System.Drawing.Point(12, 209);
            this.BTN_Tierbaum.Name = "BTN_Tierbaum";
            this.BTN_Tierbaum.Size = new System.Drawing.Size(132, 73);
            this.BTN_Tierbaum.TabIndex = 2;
            this.BTN_Tierbaum.Text = "erstelle Tierbaum";
            this.BTN_Tierbaum.UseVisualStyleBackColor = true;
            this.BTN_Tierbaum.Click += new System.EventHandler(this.B_erstelleTierbaum_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_Tierbaum);
            this.Controls.Add(this.BTN_Zahlenbaum);
            this.Controls.Add(this.GB_Output);
            this.Name = "GUI";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private GraphVizBmp.Graph2Bitmap GB_Output;
        private System.Windows.Forms.Button BTN_Zahlenbaum;
        private System.Windows.Forms.Button BTN_Tierbaum;
    }
}

