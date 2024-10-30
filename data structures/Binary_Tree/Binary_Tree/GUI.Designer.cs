namespace Binary_Tree
{
    partial class GUI
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
            this.GB_Output = new GraphVizBmp.Graph2Bitmap();
            this.B_erstelleZahlenbaum = new System.Windows.Forms.Button();
            this.B_erstelleTierbaum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GB_Output
            // 
            this.GB_Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GB_Output.GraphVizDir = GraphVizBmp.GraphVizDir.Vertical;
            this.GB_Output.GraphVizPath = "graphviz";
            this.GB_Output.Location = new System.Drawing.Point(174, 83);
            this.GB_Output.Name = "GB_Output";
            this.GB_Output.ScaleMode = Graph2Bitmap.ScaleMode.FitToGraph;
            this.GB_Output.Size = new System.Drawing.Size(479, 262);
            this.GB_Output.TabIndex = 0;
            // 
            // B_erstelleZahlenbaum
            // 
            this.B_erstelleZahlenbaum.Location = new System.Drawing.Point(28, 83);
            this.B_erstelleZahlenbaum.Name = "B_erstelleZahlenbaum";
            this.B_erstelleZahlenbaum.Size = new System.Drawing.Size(140, 47);
            this.B_erstelleZahlenbaum.TabIndex = 1;
            this.B_erstelleZahlenbaum.Text = "erstelle Zahlenbaum";
            this.B_erstelleZahlenbaum.UseVisualStyleBackColor = true;
            this.B_erstelleZahlenbaum.Click += new System.EventHandler(this.B_erstelleZahlenbaum_Click);
            // 
            // B_erstelleTierbaum
            // 
            this.B_erstelleTierbaum.Location = new System.Drawing.Point(28, 164);
            this.B_erstelleTierbaum.Name = "B_erstelleTierbaum";
            this.B_erstelleTierbaum.Size = new System.Drawing.Size(140, 47);
            this.B_erstelleTierbaum.TabIndex = 2;
            this.B_erstelleTierbaum.Text = "erstelle Tierbaum";
            this.B_erstelleTierbaum.UseVisualStyleBackColor = true;
            this.B_erstelleTierbaum.Click += new System.EventHandler(this.B_erstelleTierbaum_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_erstelleTierbaum);
            this.Controls.Add(this.B_erstelleZahlenbaum);
            this.Controls.Add(this.GB_Output);
            this.Name = "GUI";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private GraphVizBmp.Graph2Bitmap GB_Output;
        private System.Windows.Forms.Button B_erstelleZahlenbaum;
        private System.Windows.Forms.Button B_erstelleTierbaum;
    }
}

