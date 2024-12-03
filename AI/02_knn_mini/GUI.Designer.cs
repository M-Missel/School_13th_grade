using System;

namespace knn {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
      this.P_Features = new System.Windows.Forms.Panel();
      this.L_Feature = new System.Windows.Forms.Label();
      this.B_newLabel = new System.Windows.Forms.Button();
      this.M_Hauptmenu = new System.Windows.Forms.MenuStrip();
      this.M_Datei = new System.Windows.Forms.ToolStripMenuItem();
      this.MI_DateiNeu = new System.Windows.Forms.ToolStripMenuItem();
      this.MI_DateiOeffnen = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.MI_DateiSpeichern = new System.Windows.Forms.ToolStripMenuItem();
      this.MI_DateiSpeichernUnter = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.MI_DateiBeenden = new System.Windows.Forms.ToolStripMenuItem();
      this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.MI_BearbeitenKopieren = new System.Windows.Forms.ToolStripMenuItem();
      this.M_Extras = new System.Windows.Forms.ToolStripMenuItem();
      this.MI_Punkte = new System.Windows.Forms.ToolStripMenuItem();
      this.MI_kNN = new System.Windows.Forms.ToolStripMenuItem();
      this.M_Info = new System.Windows.Forms.ToolStripMenuItem();
      this.FD_Save = new System.Windows.Forms.SaveFileDialog();
      this.FD_Open = new System.Windows.Forms.OpenFileDialog();
      this.LB_FuncTree = new System.Windows.Forms.ListBox();
      this.MI_contextIntersect_Point = new System.Windows.Forms.ToolStripMenuItem();
      this.MI_contextIntersect_xTangent = new System.Windows.Forms.ToolStripMenuItem();
      this.MI_contextIntersect_IntMin = new System.Windows.Forms.ToolStripMenuItem();
      this.MI_contextIntersect_IntMax = new System.Windows.Forms.ToolStripMenuItem();
      this.MI_ContextTangentAddFunction = new System.Windows.Forms.ToolStripMenuItem();
      this.TP_kNN = new System.Windows.Forms.TabPage();
      this.LB_kNN_Counts = new System.Windows.Forms.ListBox();
      this.L_kNN_k = new System.Windows.Forms.Label();
      this.TB_kNN_k = new System.Windows.Forms.TrackBar();
      this.LB_knnList = new System.Windows.Forms.ListBox();
      this.L_Punkt_kNN = new System.Windows.Forms.Label();
      this.T_kNN_y = new System.Windows.Forms.TextBox();
      this.T_kNN_x = new System.Windows.Forms.TextBox();
      this.L_kNN_y = new System.Windows.Forms.Label();
      this.L_kNN_x = new System.Windows.Forms.Label();
      this.TP_Punkt = new System.Windows.Forms.TabPage();
      this.B_Zufallspunkte = new System.Windows.Forms.Button();
      this.L_FeatureSelect = new System.Windows.Forms.Label();
      this.B_deletePoint = new System.Windows.Forms.Button();
      this.P_PointStyle = new System.Windows.Forms.Panel();
      this.T_PunktX = new System.Windows.Forms.TextBox();
      this.T_PunktY = new System.Windows.Forms.TextBox();
      this.CB_FeatureChoice = new System.Windows.Forms.ComboBox();
      this.L_Punkt = new System.Windows.Forms.Label();
      this.L_PunktX = new System.Windows.Forms.Label();
      this.L_PunktY = new System.Windows.Forms.Label();
      this.B_neuerPunkt = new System.Windows.Forms.Button();
      this.TP_Koordinatensystem = new System.Windows.Forms.TabPage();
      this.L_xAchse = new System.Windows.Forms.Label();
      this.L_xvon = new System.Windows.Forms.Label();
      this.L_xbis = new System.Windows.Forms.Label();
      this.L_yAchse = new System.Windows.Forms.Label();
      this.T_GitY = new System.Windows.Forms.TextBox();
      this.T_GitX = new System.Windows.Forms.TextBox();
      this.T_ymax = new System.Windows.Forms.TextBox();
      this.T_ymin = new System.Windows.Forms.TextBox();
      this.T_xmax = new System.Windows.Forms.TextBox();
      this.T_xmin = new System.Windows.Forms.TextBox();
      this.L_yvon = new System.Windows.Forms.Label();
      this.L_ybis = new System.Windows.Forms.Label();
      this.L_Gitter = new System.Windows.Forms.Label();
      this.L_GitX = new System.Windows.Forms.Label();
      this.L_GitY = new System.Windows.Forms.Label();
      this.B_zeichneFeatures = new System.Windows.Forms.Button();
      this.CB_koppleY = new System.Windows.Forms.CheckBox();
      this.TC_Config = new System.Windows.Forms.TabControl();
      this.P_Description = new System.Windows.Forms.Panel();
      this.L_DescriptionHeader = new System.Windows.Forms.Label();
      this.L_Description = new System.Windows.Forms.Label();
      this.M_Hauptmenu.SuspendLayout();
      this.TP_kNN.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.TB_kNN_k)).BeginInit();
      this.TP_Punkt.SuspendLayout();
      this.TP_Koordinatensystem.SuspendLayout();
      this.TC_Config.SuspendLayout();
      this.P_Description.SuspendLayout();
      this.SuspendLayout();
      // 
      // P_Features
      // 
      this.P_Features.AutoScroll = true;
      this.P_Features.Location = new System.Drawing.Point(15, 60);
      this.P_Features.Name = "P_Features";
      this.P_Features.Size = new System.Drawing.Size(190, 580);
      this.P_Features.TabIndex = 2;
      // 
      // L_Feature
      // 
      this.L_Feature.AutoSize = true;
      this.L_Feature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.L_Feature.Location = new System.Drawing.Point(12, 32);
      this.L_Feature.Name = "L_Feature";
      this.L_Feature.Size = new System.Drawing.Size(54, 13);
      this.L_Feature.TabIndex = 3;
      this.L_Feature.Text = "Feature:";
      // 
      // B_newLabel
      // 
      this.B_newLabel.Location = new System.Drawing.Point(98, 27);
      this.B_newLabel.Name = "B_newLabel";
      this.B_newLabel.Size = new System.Drawing.Size(75, 23);
      this.B_newLabel.TabIndex = 1;
      this.B_newLabel.Text = "weitere";
      this.B_newLabel.UseVisualStyleBackColor = true;
      this.B_newLabel.Click += new System.EventHandler(this.B_newLabelClick);
      // 
      // M_Hauptmenu
      // 
      this.M_Hauptmenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.M_Hauptmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M_Datei,
            this.bearbeitenToolStripMenuItem,
            this.M_Extras,
            this.M_Info});
      this.M_Hauptmenu.Location = new System.Drawing.Point(0, 0);
      this.M_Hauptmenu.Name = "M_Hauptmenu";
      this.M_Hauptmenu.Size = new System.Drawing.Size(830, 24);
      this.M_Hauptmenu.TabIndex = 43;
      this.M_Hauptmenu.Text = "menuStrip1";
      // 
      // M_Datei
      // 
      this.M_Datei.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_DateiNeu,
            this.MI_DateiOeffnen,
            this.toolStripSeparator,
            this.MI_DateiSpeichern,
            this.MI_DateiSpeichernUnter,
            this.toolStripSeparator1,
            this.MI_DateiBeenden});
      this.M_Datei.Name = "M_Datei";
      this.M_Datei.Size = new System.Drawing.Size(46, 20);
      this.M_Datei.Text = "&Datei";
      // 
      // MI_DateiNeu
      // 
      this.MI_DateiNeu.Name = "MI_DateiNeu";
      this.MI_DateiNeu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.MI_DateiNeu.Size = new System.Drawing.Size(168, 22);
      this.MI_DateiNeu.Text = "Neu";
      this.MI_DateiNeu.Click += new System.EventHandler(this.MI_DateiNeu_Click);
      // 
      // MI_DateiOeffnen
      // 
      this.MI_DateiOeffnen.Image = ((System.Drawing.Image)(resources.GetObject("MI_DateiOeffnen.Image")));
      this.MI_DateiOeffnen.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.MI_DateiOeffnen.Name = "MI_DateiOeffnen";
      this.MI_DateiOeffnen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.MI_DateiOeffnen.Size = new System.Drawing.Size(168, 22);
      this.MI_DateiOeffnen.Text = "Ö&ffnen";
      this.MI_DateiOeffnen.Click += new System.EventHandler(this.MI_DateiOeffnen_Click);
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new System.Drawing.Size(165, 6);
      // 
      // MI_DateiSpeichern
      // 
      this.MI_DateiSpeichern.Image = ((System.Drawing.Image)(resources.GetObject("MI_DateiSpeichern.Image")));
      this.MI_DateiSpeichern.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.MI_DateiSpeichern.Name = "MI_DateiSpeichern";
      this.MI_DateiSpeichern.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.MI_DateiSpeichern.Size = new System.Drawing.Size(168, 22);
      this.MI_DateiSpeichern.Text = "&Speichern";
      this.MI_DateiSpeichern.Click += new System.EventHandler(this.MI_DateiSpeichern_Click);
      // 
      // MI_DateiSpeichernUnter
      // 
      this.MI_DateiSpeichernUnter.Name = "MI_DateiSpeichernUnter";
      this.MI_DateiSpeichernUnter.Size = new System.Drawing.Size(168, 22);
      this.MI_DateiSpeichernUnter.Text = "Speichern &unter";
      this.MI_DateiSpeichernUnter.Click += new System.EventHandler(this.MI_DateiSpeichernUnter_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
      // 
      // MI_DateiBeenden
      // 
      this.MI_DateiBeenden.Name = "MI_DateiBeenden";
      this.MI_DateiBeenden.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
      this.MI_DateiBeenden.Size = new System.Drawing.Size(168, 22);
      this.MI_DateiBeenden.Text = "&Beenden";
      this.MI_DateiBeenden.Click += new System.EventHandler(this.MI_DateiBeenden_Click);
      // 
      // bearbeitenToolStripMenuItem
      // 
      this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_BearbeitenKopieren});
      this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
      this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
      this.bearbeitenToolStripMenuItem.Text = "&Bearbeiten";
      // 
      // MI_BearbeitenKopieren
      // 
      this.MI_BearbeitenKopieren.Name = "MI_BearbeitenKopieren";
      this.MI_BearbeitenKopieren.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.MI_BearbeitenKopieren.Size = new System.Drawing.Size(266, 22);
      this.MI_BearbeitenKopieren.Text = "&Kopieren in Zwischenablage";
      this.MI_BearbeitenKopieren.Click += new System.EventHandler(this.MI_BearbeitenKopieren_Click);
      // 
      // M_Extras
      // 
      this.M_Extras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Punkte,
            this.MI_kNN});
      this.M_Extras.Name = "M_Extras";
      this.M_Extras.Size = new System.Drawing.Size(50, 20);
      this.M_Extras.Text = "&Extras";
      // 
      // MI_Punkte
      // 
      this.MI_Punkte.Name = "MI_Punkte";
      this.MI_Punkte.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
      this.MI_Punkte.Size = new System.Drawing.Size(255, 22);
      this.MI_Punkte.Text = "&Punktemodus ausschalten";
      this.MI_Punkte.Click += new System.EventHandler(this.MI_Punkte_Click);
      // 
      // MI_kNN
      // 
      this.MI_kNN.Name = "MI_kNN";
      this.MI_kNN.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
      this.MI_kNN.Size = new System.Drawing.Size(255, 22);
      this.MI_kNN.Text = "&kNN-Modus aktivieren";
      this.MI_kNN.Click += new System.EventHandler(this.MI_knn_Click);
      // 
      // M_Info
      // 
      this.M_Info.Name = "M_Info";
      this.M_Info.Size = new System.Drawing.Size(12, 20);
      // 
      // FD_Save
      // 
      this.FD_Save.Filter = "kNN-Dateien|*.kNN|Alle Dateien|*.*";
      // 
      // FD_Open
      // 
      this.FD_Open.DefaultExt = "fct";
      this.FD_Open.Filter = "kNN-Dateien|*.knn|Alle Dateien|*.*";
      // 
      // LB_FuncTree
      // 
      this.LB_FuncTree.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LB_FuncTree.FormattingEnabled = true;
      this.LB_FuncTree.Location = new System.Drawing.Point(831, 37);
      this.LB_FuncTree.Name = "LB_FuncTree";
      this.LB_FuncTree.Size = new System.Drawing.Size(134, 563);
      this.LB_FuncTree.TabIndex = 44;
      this.LB_FuncTree.Visible = false;
      // 
      // MI_contextIntersect_Point
      // 
      this.MI_contextIntersect_Point.Name = "MI_contextIntersect_Point";
      this.MI_contextIntersect_Point.Size = new System.Drawing.Size(32, 19);
      // 
      // MI_contextIntersect_xTangent
      // 
      this.MI_contextIntersect_xTangent.Name = "MI_contextIntersect_xTangent";
      this.MI_contextIntersect_xTangent.Size = new System.Drawing.Size(32, 19);
      // 
      // MI_contextIntersect_IntMin
      // 
      this.MI_contextIntersect_IntMin.Name = "MI_contextIntersect_IntMin";
      this.MI_contextIntersect_IntMin.Size = new System.Drawing.Size(32, 19);
      // 
      // MI_contextIntersect_IntMax
      // 
      this.MI_contextIntersect_IntMax.Name = "MI_contextIntersect_IntMax";
      this.MI_contextIntersect_IntMax.Size = new System.Drawing.Size(32, 19);
      // 
      // MI_ContextTangentAddFunction
      // 
      this.MI_ContextTangentAddFunction.Name = "MI_ContextTangentAddFunction";
      this.MI_ContextTangentAddFunction.Size = new System.Drawing.Size(32, 19);
      // 
      // TP_kNN
      // 
      this.TP_kNN.Controls.Add(this.LB_kNN_Counts);
      this.TP_kNN.Controls.Add(this.L_kNN_k);
      this.TP_kNN.Controls.Add(this.TB_kNN_k);
      this.TP_kNN.Controls.Add(this.LB_knnList);
      this.TP_kNN.Controls.Add(this.L_Punkt_kNN);
      this.TP_kNN.Controls.Add(this.T_kNN_y);
      this.TP_kNN.Controls.Add(this.T_kNN_x);
      this.TP_kNN.Controls.Add(this.L_kNN_y);
      this.TP_kNN.Controls.Add(this.L_kNN_x);
      this.TP_kNN.Location = new System.Drawing.Point(4, 22);
      this.TP_kNN.Name = "TP_kNN";
      this.TP_kNN.Size = new System.Drawing.Size(594, 145);
      this.TP_kNN.TabIndex = 4;
      this.TP_kNN.Text = "kNN";
      this.TP_kNN.UseVisualStyleBackColor = true;
      // 
      // LB_kNN_Counts
      // 
      this.LB_kNN_Counts.FormattingEnabled = true;
      this.LB_kNN_Counts.Location = new System.Drawing.Point(383, 10);
      this.LB_kNN_Counts.Name = "LB_kNN_Counts";
      this.LB_kNN_Counts.Size = new System.Drawing.Size(143, 121);
      this.LB_kNN_Counts.TabIndex = 137;
      // 
      // L_kNN_k
      // 
      this.L_kNN_k.AutoSize = true;
      this.L_kNN_k.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.L_kNN_k.Location = new System.Drawing.Point(110, 59);
      this.L_kNN_k.Name = "L_kNN_k";
      this.L_kNN_k.Size = new System.Drawing.Size(28, 13);
      this.L_kNN_k.TabIndex = 136;
      this.L_kNN_k.Text = "k=5";
      // 
      // TB_kNN_k
      // 
      this.TB_kNN_k.Location = new System.Drawing.Point(37, 11);
      this.TB_kNN_k.Maximum = 9;
      this.TB_kNN_k.Minimum = 1;
      this.TB_kNN_k.Name = "TB_kNN_k";
      this.TB_kNN_k.Size = new System.Drawing.Size(191, 45);
      this.TB_kNN_k.TabIndex = 135;
      this.TB_kNN_k.Value = 5;
      this.TB_kNN_k.ValueChanged += new System.EventHandler(this.TB_kNN_k_ValueChanged);
      // 
      // LB_knnList
      // 
      this.LB_knnList.FormattingEnabled = true;
      this.LB_knnList.Location = new System.Drawing.Point(234, 10);
      this.LB_knnList.Name = "LB_knnList";
      this.LB_knnList.Size = new System.Drawing.Size(143, 121);
      this.LB_knnList.TabIndex = 134;
      // 
      // L_Punkt_kNN
      // 
      this.L_Punkt_kNN.AutoSize = true;
      this.L_Punkt_kNN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.L_Punkt_kNN.Location = new System.Drawing.Point(16, 105);
      this.L_Punkt_kNN.Name = "L_Punkt_kNN";
      this.L_Punkt_kNN.Size = new System.Drawing.Size(73, 13);
      this.L_Punkt_kNN.TabIndex = 133;
      this.L_Punkt_kNN.Text = "Basispunkt:";
      // 
      // T_kNN_y
      // 
      this.T_kNN_y.Location = new System.Drawing.Point(113, 115);
      this.T_kNN_y.Name = "T_kNN_y";
      this.T_kNN_y.Size = new System.Drawing.Size(115, 20);
      this.T_kNN_y.TabIndex = 132;
      // 
      // T_kNN_x
      // 
      this.T_kNN_x.Location = new System.Drawing.Point(113, 89);
      this.T_kNN_x.Name = "T_kNN_x";
      this.T_kNN_x.Size = new System.Drawing.Size(115, 20);
      this.T_kNN_x.TabIndex = 131;
      // 
      // L_kNN_y
      // 
      this.L_kNN_y.AutoSize = true;
      this.L_kNN_y.Location = new System.Drawing.Point(95, 118);
      this.L_kNN_y.Name = "L_kNN_y";
      this.L_kNN_y.Size = new System.Drawing.Size(15, 13);
      this.L_kNN_y.TabIndex = 130;
      this.L_kNN_y.Text = "y:";
      // 
      // L_kNN_x
      // 
      this.L_kNN_x.AutoSize = true;
      this.L_kNN_x.Location = new System.Drawing.Point(95, 92);
      this.L_kNN_x.Name = "L_kNN_x";
      this.L_kNN_x.Size = new System.Drawing.Size(15, 13);
      this.L_kNN_x.TabIndex = 129;
      this.L_kNN_x.Text = "x:";
      // 
      // TP_Punkt
      // 
      this.TP_Punkt.Controls.Add(this.B_Zufallspunkte);
      this.TP_Punkt.Controls.Add(this.L_FeatureSelect);
      this.TP_Punkt.Controls.Add(this.B_deletePoint);
      this.TP_Punkt.Controls.Add(this.P_PointStyle);
      this.TP_Punkt.Controls.Add(this.T_PunktX);
      this.TP_Punkt.Controls.Add(this.T_PunktY);
      this.TP_Punkt.Controls.Add(this.CB_FeatureChoice);
      this.TP_Punkt.Controls.Add(this.L_Punkt);
      this.TP_Punkt.Controls.Add(this.L_PunktX);
      this.TP_Punkt.Controls.Add(this.L_PunktY);
      this.TP_Punkt.Controls.Add(this.B_neuerPunkt);
      this.TP_Punkt.Location = new System.Drawing.Point(4, 22);
      this.TP_Punkt.Name = "TP_Punkt";
      this.TP_Punkt.Padding = new System.Windows.Forms.Padding(3);
      this.TP_Punkt.Size = new System.Drawing.Size(594, 145);
      this.TP_Punkt.TabIndex = 1;
      this.TP_Punkt.Text = "Punkte";
      this.TP_Punkt.UseVisualStyleBackColor = true;
      // 
      // B_Zufallspunkte
      // 
      this.B_Zufallspunkte.Location = new System.Drawing.Point(78, 114);
      this.B_Zufallspunkte.Name = "B_Zufallspunkte";
      this.B_Zufallspunkte.Size = new System.Drawing.Size(113, 23);
      this.B_Zufallspunkte.TabIndex = 129;
      this.B_Zufallspunkte.Text = "20 Zufallspunkte";
      this.B_Zufallspunkte.UseVisualStyleBackColor = true;
      this.B_Zufallspunkte.Click += new System.EventHandler(this.B_Zufallspunkte_Click);
      // 
      // L_FeatureSelect
      // 
      this.L_FeatureSelect.AutoSize = true;
      this.L_FeatureSelect.Location = new System.Drawing.Point(26, 61);
      this.L_FeatureSelect.Name = "L_FeatureSelect";
      this.L_FeatureSelect.Size = new System.Drawing.Size(46, 13);
      this.L_FeatureSelect.TabIndex = 128;
      this.L_FeatureSelect.Text = "Feature:";
      // 
      // B_deletePoint
      // 
      this.B_deletePoint.Location = new System.Drawing.Point(268, 107);
      this.B_deletePoint.Name = "B_deletePoint";
      this.B_deletePoint.Size = new System.Drawing.Size(133, 23);
      this.B_deletePoint.TabIndex = 124;
      this.B_deletePoint.Text = "Punkt löschen";
      this.B_deletePoint.UseVisualStyleBackColor = true;
      this.B_deletePoint.Visible = false;
      this.B_deletePoint.Click += new System.EventHandler(this.B_deletePoint_Click);
      // 
      // P_PointStyle
      // 
      this.P_PointStyle.Location = new System.Drawing.Point(241, 6);
      this.P_PointStyle.Name = "P_PointStyle";
      this.P_PointStyle.Size = new System.Drawing.Size(24, 95);
      this.P_PointStyle.TabIndex = 126;
      this.P_PointStyle.Paint += new System.Windows.Forms.PaintEventHandler(this.P_PointStyle_Paint);
      // 
      // T_PunktX
      // 
      this.T_PunktX.Location = new System.Drawing.Point(78, 6);
      this.T_PunktX.Name = "T_PunktX";
      this.T_PunktX.Size = new System.Drawing.Size(113, 20);
      this.T_PunktX.TabIndex = 116;
      this.T_PunktX.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
      // 
      // T_PunktY
      // 
      this.T_PunktY.Location = new System.Drawing.Point(78, 32);
      this.T_PunktY.Name = "T_PunktY";
      this.T_PunktY.Size = new System.Drawing.Size(113, 20);
      this.T_PunktY.TabIndex = 119;
      this.T_PunktY.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
      // 
      // CB_FeatureChoice
      // 
      this.CB_FeatureChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.CB_FeatureChoice.FormattingEnabled = true;
      this.CB_FeatureChoice.ImeMode = System.Windows.Forms.ImeMode.On;
      this.CB_FeatureChoice.Location = new System.Drawing.Point(78, 58);
      this.CB_FeatureChoice.Name = "CB_FeatureChoice";
      this.CB_FeatureChoice.Size = new System.Drawing.Size(113, 21);
      this.CB_FeatureChoice.TabIndex = 117;
      // 
      // L_Punkt
      // 
      this.L_Punkt.AutoSize = true;
      this.L_Punkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.L_Punkt.Location = new System.Drawing.Point(7, 9);
      this.L_Punkt.Name = "L_Punkt";
      this.L_Punkt.Size = new System.Drawing.Size(44, 13);
      this.L_Punkt.TabIndex = 23;
      this.L_Punkt.Text = "Punkt:";
      // 
      // L_PunktX
      // 
      this.L_PunktX.AutoSize = true;
      this.L_PunktX.Location = new System.Drawing.Point(57, 9);
      this.L_PunktX.Name = "L_PunktX";
      this.L_PunktX.Size = new System.Drawing.Size(15, 13);
      this.L_PunktX.TabIndex = 24;
      this.L_PunktX.Text = "x:";
      // 
      // L_PunktY
      // 
      this.L_PunktY.AutoSize = true;
      this.L_PunktY.Location = new System.Drawing.Point(57, 35);
      this.L_PunktY.Name = "L_PunktY";
      this.L_PunktY.Size = new System.Drawing.Size(15, 13);
      this.L_PunktY.TabIndex = 25;
      this.L_PunktY.Text = "y:";
      // 
      // B_neuerPunkt
      // 
      this.B_neuerPunkt.Location = new System.Drawing.Point(78, 85);
      this.B_neuerPunkt.Name = "B_neuerPunkt";
      this.B_neuerPunkt.Size = new System.Drawing.Size(113, 23);
      this.B_neuerPunkt.TabIndex = 118;
      this.B_neuerPunkt.Text = "erstelle Punkt";
      this.B_neuerPunkt.UseVisualStyleBackColor = true;
      this.B_neuerPunkt.Click += new System.EventHandler(this.B_berechnePunktY_Click);
      // 
      // TP_Koordinatensystem
      // 
      this.TP_Koordinatensystem.Controls.Add(this.L_xAchse);
      this.TP_Koordinatensystem.Controls.Add(this.L_xvon);
      this.TP_Koordinatensystem.Controls.Add(this.L_xbis);
      this.TP_Koordinatensystem.Controls.Add(this.L_yAchse);
      this.TP_Koordinatensystem.Controls.Add(this.T_GitY);
      this.TP_Koordinatensystem.Controls.Add(this.T_GitX);
      this.TP_Koordinatensystem.Controls.Add(this.T_ymax);
      this.TP_Koordinatensystem.Controls.Add(this.T_ymin);
      this.TP_Koordinatensystem.Controls.Add(this.T_xmax);
      this.TP_Koordinatensystem.Controls.Add(this.T_xmin);
      this.TP_Koordinatensystem.Controls.Add(this.L_yvon);
      this.TP_Koordinatensystem.Controls.Add(this.L_ybis);
      this.TP_Koordinatensystem.Controls.Add(this.L_Gitter);
      this.TP_Koordinatensystem.Controls.Add(this.L_GitX);
      this.TP_Koordinatensystem.Controls.Add(this.L_GitY);
      this.TP_Koordinatensystem.Controls.Add(this.B_zeichneFeatures);
      this.TP_Koordinatensystem.Controls.Add(this.CB_koppleY);
      this.TP_Koordinatensystem.Location = new System.Drawing.Point(4, 22);
      this.TP_Koordinatensystem.Name = "TP_Koordinatensystem";
      this.TP_Koordinatensystem.Padding = new System.Windows.Forms.Padding(3);
      this.TP_Koordinatensystem.Size = new System.Drawing.Size(594, 145);
      this.TP_Koordinatensystem.TabIndex = 0;
      this.TP_Koordinatensystem.Text = "Koordinatensystem";
      this.TP_Koordinatensystem.UseVisualStyleBackColor = true;
      // 
      // L_xAchse
      // 
      this.L_xAchse.AutoSize = true;
      this.L_xAchse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.L_xAchse.Location = new System.Drawing.Point(17, 12);
      this.L_xAchse.Name = "L_xAchse";
      this.L_xAchse.Size = new System.Drawing.Size(56, 13);
      this.L_xAchse.TabIndex = 7;
      this.L_xAchse.Text = "x-Achse:";
      // 
      // L_xvon
      // 
      this.L_xvon.AutoSize = true;
      this.L_xvon.Location = new System.Drawing.Point(18, 40);
      this.L_xvon.Name = "L_xvon";
      this.L_xvon.Size = new System.Drawing.Size(28, 13);
      this.L_xvon.TabIndex = 8;
      this.L_xvon.Text = "von:";
      // 
      // L_xbis
      // 
      this.L_xbis.AutoSize = true;
      this.L_xbis.Location = new System.Drawing.Point(23, 66);
      this.L_xbis.Name = "L_xbis";
      this.L_xbis.Size = new System.Drawing.Size(23, 13);
      this.L_xbis.TabIndex = 9;
      this.L_xbis.Text = "bis:";
      // 
      // L_yAchse
      // 
      this.L_yAchse.AutoSize = true;
      this.L_yAchse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.L_yAchse.Location = new System.Drawing.Point(112, 13);
      this.L_yAchse.Name = "L_yAchse";
      this.L_yAchse.Size = new System.Drawing.Size(56, 13);
      this.L_yAchse.TabIndex = 10;
      this.L_yAchse.Text = "y-Achse:";
      // 
      // T_GitY
      // 
      this.T_GitY.Location = new System.Drawing.Point(260, 64);
      this.T_GitY.Name = "T_GitY";
      this.T_GitY.Size = new System.Drawing.Size(74, 20);
      this.T_GitY.TabIndex = 110;
      this.T_GitY.Text = "0,5";
      this.T_GitY.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
      // 
      // T_GitX
      // 
      this.T_GitX.Location = new System.Drawing.Point(260, 37);
      this.T_GitX.Name = "T_GitX";
      this.T_GitX.Size = new System.Drawing.Size(74, 20);
      this.T_GitX.TabIndex = 109;
      this.T_GitX.Text = "0,5";
      this.T_GitX.TextChanged += new System.EventHandler(this.T_GitX_TextChanged);
      // 
      // T_ymax
      // 
      this.T_ymax.Location = new System.Drawing.Point(147, 63);
      this.T_ymax.Name = "T_ymax";
      this.T_ymax.Size = new System.Drawing.Size(50, 20);
      this.T_ymax.TabIndex = 106;
      this.T_ymax.Text = "5";
      // 
      // T_ymin
      // 
      this.T_ymin.Location = new System.Drawing.Point(147, 37);
      this.T_ymin.Name = "T_ymin";
      this.T_ymin.Size = new System.Drawing.Size(50, 20);
      this.T_ymin.TabIndex = 105;
      this.T_ymin.Text = "-5";
      this.T_ymin.TextChanged += new System.EventHandler(this.setYMax);
      // 
      // T_xmax
      // 
      this.T_xmax.Location = new System.Drawing.Point(52, 63);
      this.T_xmax.Name = "T_xmax";
      this.T_xmax.Size = new System.Drawing.Size(50, 20);
      this.T_xmax.TabIndex = 103;
      this.T_xmax.Text = "5";
      this.T_xmax.TextChanged += new System.EventHandler(this.setYMax);
      // 
      // T_xmin
      // 
      this.T_xmin.Location = new System.Drawing.Point(52, 37);
      this.T_xmin.Name = "T_xmin";
      this.T_xmin.Size = new System.Drawing.Size(50, 20);
      this.T_xmin.TabIndex = 102;
      this.T_xmin.Text = "-5";
      this.T_xmin.TextChanged += new System.EventHandler(this.setYMax);
      // 
      // L_yvon
      // 
      this.L_yvon.AutoSize = true;
      this.L_yvon.Location = new System.Drawing.Point(113, 40);
      this.L_yvon.Name = "L_yvon";
      this.L_yvon.Size = new System.Drawing.Size(28, 13);
      this.L_yvon.TabIndex = 11;
      this.L_yvon.Text = "von:";
      // 
      // L_ybis
      // 
      this.L_ybis.AutoSize = true;
      this.L_ybis.Location = new System.Drawing.Point(118, 67);
      this.L_ybis.Name = "L_ybis";
      this.L_ybis.Size = new System.Drawing.Size(23, 13);
      this.L_ybis.TabIndex = 12;
      this.L_ybis.Text = "bis:";
      // 
      // L_Gitter
      // 
      this.L_Gitter.AutoSize = true;
      this.L_Gitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.L_Gitter.Location = new System.Drawing.Point(238, 12);
      this.L_Gitter.Name = "L_Gitter";
      this.L_Gitter.Size = new System.Drawing.Size(42, 13);
      this.L_Gitter.TabIndex = 13;
      this.L_Gitter.Text = "Gitter:";
      // 
      // L_GitX
      // 
      this.L_GitX.AutoSize = true;
      this.L_GitX.Location = new System.Drawing.Point(238, 40);
      this.L_GitX.Name = "L_GitX";
      this.L_GitX.Size = new System.Drawing.Size(15, 13);
      this.L_GitX.TabIndex = 14;
      this.L_GitX.Text = "x:";
      // 
      // L_GitY
      // 
      this.L_GitY.AutoSize = true;
      this.L_GitY.Location = new System.Drawing.Point(238, 67);
      this.L_GitY.Name = "L_GitY";
      this.L_GitY.Size = new System.Drawing.Size(15, 13);
      this.L_GitY.TabIndex = 15;
      this.L_GitY.Text = "y:";
      // 
      // B_zeichneFeatures
      // 
      this.B_zeichneFeatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.B_zeichneFeatures.Location = new System.Drawing.Point(21, 89);
      this.B_zeichneFeatures.Name = "B_zeichneFeatures";
      this.B_zeichneFeatures.Size = new System.Drawing.Size(216, 33);
      this.B_zeichneFeatures.TabIndex = 114;
      this.B_zeichneFeatures.Text = "zeichne Plot";
      this.B_zeichneFeatures.UseVisualStyleBackColor = true;
      this.B_zeichneFeatures.Click += new System.EventHandler(this.B_drawFeature_Click);
      // 
      // CB_koppleY
      // 
      this.CB_koppleY.AutoSize = true;
      this.CB_koppleY.Location = new System.Drawing.Point(340, 54);
      this.CB_koppleY.Name = "CB_koppleY";
      this.CB_koppleY.Size = new System.Drawing.Size(89, 17);
      this.CB_koppleY.TabIndex = 111;
      this.CB_koppleY.Text = "kopple y an x";
      this.CB_koppleY.UseVisualStyleBackColor = true;
      this.CB_koppleY.CheckedChanged += new System.EventHandler(this.CB_koppleY_CheckedChanged);
      // 
      // TC_Config
      // 
      this.TC_Config.Controls.Add(this.TP_Koordinatensystem);
      this.TC_Config.Controls.Add(this.TP_Punkt);
      this.TC_Config.Controls.Add(this.TP_kNN);
      this.TC_Config.Location = new System.Drawing.Point(216, 653);
      this.TC_Config.Name = "TC_Config";
      this.TC_Config.SelectedIndex = 0;
      this.TC_Config.Size = new System.Drawing.Size(602, 171);
      this.TC_Config.TabIndex = 123;
      // 
      // P_Description
      // 
      this.P_Description.BackColor = System.Drawing.Color.White;
      this.P_Description.Controls.Add(this.L_DescriptionHeader);
      this.P_Description.Controls.Add(this.L_Description);
      this.P_Description.Location = new System.Drawing.Point(15, 653);
      this.P_Description.Name = "P_Description";
      this.P_Description.Size = new System.Drawing.Size(189, 170);
      this.P_Description.TabIndex = 125;
      // 
      // L_DescriptionHeader
      // 
      this.L_DescriptionHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.L_DescriptionHeader.Location = new System.Drawing.Point(11, 9);
      this.L_DescriptionHeader.Name = "L_DescriptionHeader";
      this.L_DescriptionHeader.Size = new System.Drawing.Size(100, 23);
      this.L_DescriptionHeader.TabIndex = 1;
      this.L_DescriptionHeader.Text = "Überschrift";
      // 
      // L_Description
      // 
      this.L_Description.Location = new System.Drawing.Point(11, 32);
      this.L_Description.Name = "L_Description";
      this.L_Description.Size = new System.Drawing.Size(167, 89);
      this.L_Description.TabIndex = 0;
      this.L_Description.Text = "Beschreibung";
      // 
      // GUI
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(830, 830);
      this.Controls.Add(this.P_Description);
      this.Controls.Add(this.TC_Config);
      this.Controls.Add(this.LB_FuncTree);
      this.Controls.Add(this.B_newLabel);
      this.Controls.Add(this.L_Feature);
      this.Controls.Add(this.P_Features);
      this.Controls.Add(this.M_Hauptmenu);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.M_Hauptmenu;
      this.MinimumSize = new System.Drawing.Size(825, 400);
      this.Name = "GUI";
      this.Text = "kNN";
      this.Resize += new System.EventHandler(this.GUI_Resize);
      this.M_Hauptmenu.ResumeLayout(false);
      this.M_Hauptmenu.PerformLayout();
      this.TP_kNN.ResumeLayout(false);
      this.TP_kNN.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.TB_kNN_k)).EndInit();
      this.TP_Punkt.ResumeLayout(false);
      this.TP_Punkt.PerformLayout();
      this.TP_Koordinatensystem.ResumeLayout(false);
      this.TP_Koordinatensystem.PerformLayout();
      this.TC_Config.ResumeLayout(false);
      this.P_Description.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel P_Features;
    private System.Windows.Forms.Label L_Feature;
    private System.Windows.Forms.Button B_newLabel;
    private System.Windows.Forms.MenuStrip M_Hauptmenu;
    private System.Windows.Forms.ToolStripMenuItem M_Datei;
    private System.Windows.Forms.ToolStripMenuItem MI_DateiOeffnen;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripMenuItem MI_DateiSpeichern;
    private System.Windows.Forms.ToolStripMenuItem MI_DateiSpeichernUnter;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem MI_DateiBeenden;
    private System.Windows.Forms.SaveFileDialog FD_Save;
    private System.Windows.Forms.OpenFileDialog FD_Open;
    private System.Windows.Forms.ListBox LB_FuncTree;
    private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem MI_BearbeitenKopieren;
    private System.Windows.Forms.ToolStripMenuItem M_Info;
    private System.Windows.Forms.ToolStripMenuItem MI_DateiNeu;
    private System.Windows.Forms.ToolStripMenuItem M_Extras;
    private System.Windows.Forms.ToolStripMenuItem MI_Punkte;
    private System.Windows.Forms.ToolStripMenuItem MI_contextIntersect_Point;
    private System.Windows.Forms.ToolStripMenuItem MI_contextIntersect_IntMin;
    private System.Windows.Forms.ToolStripMenuItem MI_contextIntersect_IntMax;
    private System.Windows.Forms.ToolStripMenuItem MI_contextIntersect_xTangent;
    private System.Windows.Forms.ToolStripMenuItem MI_ContextTangentAddFunction;
    private System.Windows.Forms.ToolStripMenuItem MI_kNN;
    private System.Windows.Forms.TabPage TP_kNN;
    private System.Windows.Forms.TabPage TP_Punkt;
    private System.Windows.Forms.Label L_FeatureSelect;
    private System.Windows.Forms.Button B_deletePoint;
    private System.Windows.Forms.Panel P_PointStyle;
    private System.Windows.Forms.TextBox T_PunktX;
    private System.Windows.Forms.TextBox T_PunktY;
    private System.Windows.Forms.ComboBox CB_FeatureChoice;
    private System.Windows.Forms.Label L_Punkt;
    private System.Windows.Forms.Label L_PunktX;
    private System.Windows.Forms.Label L_PunktY;
    private System.Windows.Forms.Button B_neuerPunkt;
    private System.Windows.Forms.TabPage TP_Koordinatensystem;
    private System.Windows.Forms.Label L_xAchse;
    private System.Windows.Forms.Label L_xvon;
    private System.Windows.Forms.Label L_xbis;
    private System.Windows.Forms.Label L_yAchse;
    private System.Windows.Forms.TextBox T_GitY;
    private System.Windows.Forms.TextBox T_GitX;
    private System.Windows.Forms.TextBox T_ymax;
    private System.Windows.Forms.TextBox T_ymin;
    private System.Windows.Forms.TextBox T_xmax;
    private System.Windows.Forms.TextBox T_xmin;
    private System.Windows.Forms.Label L_yvon;
    private System.Windows.Forms.Label L_ybis;
    private System.Windows.Forms.Label L_Gitter;
    private System.Windows.Forms.Label L_GitX;
    private System.Windows.Forms.Label L_GitY;
    private System.Windows.Forms.Button B_zeichneFeatures;
    private System.Windows.Forms.CheckBox CB_koppleY;
    private System.Windows.Forms.TabControl TC_Config;
    private System.Windows.Forms.TextBox T_kNN_y;
    private System.Windows.Forms.TextBox T_kNN_x;
    private System.Windows.Forms.Label L_kNN_y;
    private System.Windows.Forms.Label L_kNN_x;
    private System.Windows.Forms.Label L_Punkt_kNN;
    private System.Windows.Forms.TrackBar TB_kNN_k;
    private System.Windows.Forms.ListBox LB_knnList;
    private System.Windows.Forms.Label L_kNN_k;
    private System.Windows.Forms.ListBox LB_kNN_Counts;
    private System.Windows.Forms.Panel P_Description;
    private System.Windows.Forms.Label L_DescriptionHeader;
    private System.Windows.Forms.Label L_Description;
    private System.Windows.Forms.Button B_Zufallspunkte;
  }
}

