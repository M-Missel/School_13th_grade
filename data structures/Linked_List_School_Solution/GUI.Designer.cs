namespace VerketteteListe {
  partial class GUI {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent() {
      this.T_Name = new System.Windows.Forms.TextBox();
      this.L_Ausgabe = new System.Windows.Forms.ListBox();
      this.B_insert = new System.Windows.Forms.Button();
      this.B_ausgeben = new System.Windows.Forms.Button();
      this.T_Index = new System.Windows.Forms.TextBox();
      this.L_Index = new System.Windows.Forms.Label();
      this.B_inhalt = new System.Windows.Forms.Button();
      this.T_Ausgabe = new System.Windows.Forms.TextBox();
      this.B_ersetzen = new System.Windows.Forms.Button();
      this.B_anhaengen = new System.Windows.Forms.Button();
      this.T_entfernen = new System.Windows.Forms.Button();
      this.B_enthaelt = new System.Windows.Forms.Button();
      this.T_entfElem = new System.Windows.Forms.Button();
      this.L_Name = new System.Windows.Forms.Label();
      this.G_Liste = new GraphVizBmp.Graph2Bitmap();
      this.SuspendLayout();
      // 
      // T_Name
      // 
      this.T_Name.Location = new System.Drawing.Point(78, 34);
      this.T_Name.Name = "T_Name";
      this.T_Name.Size = new System.Drawing.Size(75, 20);
      this.T_Name.TabIndex = 0;
      this.T_Name.Text = "P_1";
      // 
      // L_Ausgabe
      // 
      this.L_Ausgabe.FormattingEnabled = true;
      this.L_Ausgabe.Location = new System.Drawing.Point(226, 42);
      this.L_Ausgabe.Name = "L_Ausgabe";
      this.L_Ausgabe.Size = new System.Drawing.Size(120, 186);
      this.L_Ausgabe.TabIndex = 1;
      // 
      // B_insert
      // 
      this.B_insert.Location = new System.Drawing.Point(39, 88);
      this.B_insert.Name = "B_insert";
      this.B_insert.Size = new System.Drawing.Size(114, 23);
      this.B_insert.TabIndex = 2;
      this.B_insert.Text = "einfügen";
      this.B_insert.UseVisualStyleBackColor = true;
      this.B_insert.Click += new System.EventHandler(this.B_insert_Click);
      // 
      // B_ausgeben
      // 
      this.B_ausgeben.Location = new System.Drawing.Point(226, 234);
      this.B_ausgeben.Name = "B_ausgeben";
      this.B_ausgeben.Size = new System.Drawing.Size(120, 23);
      this.B_ausgeben.TabIndex = 3;
      this.B_ausgeben.Text = "ausgeben";
      this.B_ausgeben.UseVisualStyleBackColor = true;
      this.B_ausgeben.Click += new System.EventHandler(this.B_ausgeben_Click);
      // 
      // T_Index
      // 
      this.T_Index.Location = new System.Drawing.Point(81, 62);
      this.T_Index.Name = "T_Index";
      this.T_Index.Size = new System.Drawing.Size(33, 20);
      this.T_Index.TabIndex = 4;
      this.T_Index.Text = "0";
      // 
      // L_Index
      // 
      this.L_Index.AutoSize = true;
      this.L_Index.Location = new System.Drawing.Point(36, 66);
      this.L_Index.Name = "L_Index";
      this.L_Index.Size = new System.Drawing.Size(36, 13);
      this.L_Index.TabIndex = 5;
      this.L_Index.Text = "Index:";
      // 
      // B_inhalt
      // 
      this.B_inhalt.Location = new System.Drawing.Point(39, 118);
      this.B_inhalt.Name = "B_inhalt";
      this.B_inhalt.Size = new System.Drawing.Size(114, 23);
      this.B_inhalt.TabIndex = 6;
      this.B_inhalt.Text = "Inhalt";
      this.B_inhalt.UseVisualStyleBackColor = true;
      this.B_inhalt.Click += new System.EventHandler(this.B_inhalt_Click);
      // 
      // T_Ausgabe
      // 
      this.T_Ausgabe.Location = new System.Drawing.Point(226, 283);
      this.T_Ausgabe.Name = "T_Ausgabe";
      this.T_Ausgabe.Size = new System.Drawing.Size(100, 20);
      this.T_Ausgabe.TabIndex = 7;
      // 
      // B_ersetzen
      // 
      this.B_ersetzen.Location = new System.Drawing.Point(39, 145);
      this.B_ersetzen.Name = "B_ersetzen";
      this.B_ersetzen.Size = new System.Drawing.Size(114, 23);
      this.B_ersetzen.TabIndex = 8;
      this.B_ersetzen.Text = "ersetzen";
      this.B_ersetzen.UseVisualStyleBackColor = true;
      this.B_ersetzen.Click += new System.EventHandler(this.B_ersetzen_Click);
      // 
      // B_anhaengen
      // 
      this.B_anhaengen.Location = new System.Drawing.Point(39, 175);
      this.B_anhaengen.Name = "B_anhaengen";
      this.B_anhaengen.Size = new System.Drawing.Size(114, 23);
      this.B_anhaengen.TabIndex = 9;
      this.B_anhaengen.Text = "anhängen";
      this.B_anhaengen.UseVisualStyleBackColor = true;
      this.B_anhaengen.Click += new System.EventHandler(this.B_anhaengen_Click);
      // 
      // T_entfernen
      // 
      this.T_entfernen.Location = new System.Drawing.Point(39, 205);
      this.T_entfernen.Name = "T_entfernen";
      this.T_entfernen.Size = new System.Drawing.Size(114, 23);
      this.T_entfernen.TabIndex = 10;
      this.T_entfernen.Text = "entfernen";
      this.T_entfernen.UseVisualStyleBackColor = true;
      this.T_entfernen.Click += new System.EventHandler(this.T_entfernenClick);
      // 
      // B_enthaelt
      // 
      this.B_enthaelt.Location = new System.Drawing.Point(39, 281);
      this.B_enthaelt.Name = "B_enthaelt";
      this.B_enthaelt.Size = new System.Drawing.Size(114, 23);
      this.B_enthaelt.TabIndex = 11;
      this.B_enthaelt.Text = "enthält";
      this.B_enthaelt.UseVisualStyleBackColor = true;
      this.B_enthaelt.Click += new System.EventHandler(this.B_enthaelt_Click);
      // 
      // T_entfElem
      // 
      this.T_entfElem.Location = new System.Drawing.Point(39, 235);
      this.T_entfElem.Name = "T_entfElem";
      this.T_entfElem.Size = new System.Drawing.Size(114, 40);
      this.T_entfElem.TabIndex = 12;
      this.T_entfElem.Text = "entfernen Element";
      this.T_entfElem.UseVisualStyleBackColor = true;
      this.T_entfElem.Click += new System.EventHandler(this.T_entfElem_Click);
      // 
      // L_Name
      // 
      this.L_Name.AutoSize = true;
      this.L_Name.Location = new System.Drawing.Point(36, 37);
      this.L_Name.Name = "L_Name";
      this.L_Name.Size = new System.Drawing.Size(38, 13);
      this.L_Name.TabIndex = 13;
      this.L_Name.Text = "Name:";
      // 
      // G_Liste
      // 
      this.G_Liste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.G_Liste.GraphVizDir = GraphVizBmp.GraphVizDir.Vertical;
      this.G_Liste.GraphVizPath = "graphviz";
      this.G_Liste.Location = new System.Drawing.Point(353, 42);
      this.G_Liste.Name = "G_Liste";
      this.G_Liste.Size = new System.Drawing.Size(132, 132);
      this.G_Liste.TabIndex = 14;
      // 
      // GUI
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(865, 323);
      this.Controls.Add(this.G_Liste);
      this.Controls.Add(this.L_Name);
      this.Controls.Add(this.T_entfElem);
      this.Controls.Add(this.B_enthaelt);
      this.Controls.Add(this.T_entfernen);
      this.Controls.Add(this.B_anhaengen);
      this.Controls.Add(this.B_ersetzen);
      this.Controls.Add(this.T_Ausgabe);
      this.Controls.Add(this.B_inhalt);
      this.Controls.Add(this.L_Index);
      this.Controls.Add(this.T_Index);
      this.Controls.Add(this.B_ausgeben);
      this.Controls.Add(this.B_insert);
      this.Controls.Add(this.L_Ausgabe);
      this.Controls.Add(this.T_Name);
      this.Name = "GUI";
      this.Text = "Verkettete Listen";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox T_Name;
    private System.Windows.Forms.ListBox L_Ausgabe;
    private System.Windows.Forms.Button B_insert;
    private System.Windows.Forms.Button B_ausgeben;
    private System.Windows.Forms.TextBox T_Index;
    private System.Windows.Forms.Label L_Index;
    private System.Windows.Forms.Button B_inhalt;
    private System.Windows.Forms.TextBox T_Ausgabe;
    private System.Windows.Forms.Button B_ersetzen;
    private System.Windows.Forms.Button B_anhaengen;
    private System.Windows.Forms.Button T_entfernen;
    private System.Windows.Forms.Button B_enthaelt;
    private System.Windows.Forms.Button T_entfElem;
    private System.Windows.Forms.Label L_Name;
    private GraphVizBmp.Graph2Bitmap G_Liste;
  }
}

