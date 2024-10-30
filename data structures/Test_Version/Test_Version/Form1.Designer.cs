namespace Test_Version
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
            this.GB_Output = new GraphVizBmp.Graph2Bitmap();
            this.BTN_Test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GB_Output
            // 
            this.GB_Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GB_Output.GraphVizDir = GraphVizBmp.GraphVizDir.Vertical;
            this.GB_Output.GraphVizPath = "graphviz";
            this.GB_Output.Location = new System.Drawing.Point(209, 47);
            this.GB_Output.Name = "GB_Output";
            this.GB_Output.ScaleMode = Graph2Bitmap.ScaleMode.FitToGraph;
            this.GB_Output.Size = new System.Drawing.Size(328, 250);
            this.GB_Output.TabIndex = 0;
            // 
            // BTN_Test
            // 
            this.BTN_Test.Location = new System.Drawing.Point(46, 135);
            this.BTN_Test.Name = "BTN_Test";
            this.BTN_Test.Size = new System.Drawing.Size(75, 23);
            this.BTN_Test.TabIndex = 1;
            this.BTN_Test.Text = "Test";
            this.BTN_Test.UseVisualStyleBackColor = true;
            this.BTN_Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_Test);
            this.Controls.Add(this.GB_Output);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private GraphVizBmp.Graph2Bitmap GB_Output;
        private System.Windows.Forms.Button BTN_Test;
    }
}

