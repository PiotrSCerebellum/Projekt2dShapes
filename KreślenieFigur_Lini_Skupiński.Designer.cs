
namespace Projekt2_Skupiński59369
{
    partial class KreślenieFigur_Lini_Skupiński
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
            this.components = new System.ComponentModel.Container();
            this.btWłączSlajd = new System.Windows.Forms.Button();
            this.gbPokazFigurKreślenie = new System.Windows.Forms.GroupBox();
            this.btWyłączPokaz = new System.Windows.Forms.Button();
            this.rbManualny = new System.Windows.Forms.RadioButton();
            this.rbAutomatyczny = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.lbPołożenie = new System.Windows.Forms.Label();
            this.gbWybierzFigurę = new System.Windows.Forms.GroupBox();
            this.btCofnij = new System.Windows.Forms.Button();
            this.btPrzesuń = new System.Windows.Forms.Button();
            this.rbFillClosedCurve = new System.Windows.Forms.RadioButton();
            this.rbFillPie = new System.Windows.Forms.RadioButton();
            this.rbDrawArc = new System.Windows.Forms.RadioButton();
            this.rbKrzywaKardynalna = new System.Windows.Forms.RadioButton();
            this.rbFillElipse = new System.Windows.Forms.RadioButton();
            this.rbLiniaCiągła = new System.Windows.Forms.RadioButton();
            this.rbLosowyWielokątForemny = new System.Windows.Forms.RadioButton();
            this.rbProstokąt = new System.Windows.Forms.RadioButton();
            this.rbOkrąg = new System.Windows.Forms.RadioButton();
            this.rbLiniaProsta = new System.Windows.Forms.RadioButton();
            this.rbDrawPie = new System.Windows.Forms.RadioButton();
            this.rbClosedCurve = new System.Windows.Forms.RadioButton();
            this.rbFillRectangle = new System.Windows.Forms.RadioButton();
            this.rbKrzywaBeziera = new System.Windows.Forms.RadioButton();
            this.rbWielokątWyp = new System.Windows.Forms.RadioButton();
            this.rbKwadrat = new System.Windows.Forms.RadioButton();
            this.rbKoło = new System.Windows.Forms.RadioButton();
            this.rbElipsa = new System.Windows.Forms.RadioButton();
            this.rbPunkt = new System.Windows.Forms.RadioButton();
            this.gbManualnaKontrolaK = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumerFigury = new System.Windows.Forms.TextBox();
            this.btPoprzedni = new System.Windows.Forms.Button();
            this.btNastępny = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbAtrybutyGraficzne = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trbUstawGrubośćLinii = new System.Windows.Forms.TrackBar();
            this.cbWybierzStylLinii = new System.Windows.Forms.ComboBox();
            this.txtKolorWypełnienia = new System.Windows.Forms.TextBox();
            this.btnKolorWypełnienia = new System.Windows.Forms.Button();
            this.txtKolorLinii = new System.Windows.Forms.TextBox();
            this.btnKolorLinii = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszBitmapęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajBitmapęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powrótToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjścieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msUstawienieKoloru = new System.Windows.Forms.ToolStripMenuItem();
            this.wybierzKolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawTłoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wybierzKolorTłaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbPokazFigurKreślenie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            this.gbWybierzFigurę.SuspendLayout();
            this.gbManualnaKontrolaK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbAtrybutyGraficzne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbUstawGrubośćLinii)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btWłączSlajd
            // 
            this.btWłączSlajd.Location = new System.Drawing.Point(13, 42);
            this.btWłączSlajd.Name = "btWłączSlajd";
            this.btWłączSlajd.Size = new System.Drawing.Size(111, 36);
            this.btWłączSlajd.TabIndex = 0;
            this.btWłączSlajd.Text = "Włącz Pokaz Figur";
            this.btWłączSlajd.UseVisualStyleBackColor = true;
            this.btWłączSlajd.Click += new System.EventHandler(this.btWłączPokazKreślenie_Click);
            // 
            // gbPokazFigurKreślenie
            // 
            this.gbPokazFigurKreślenie.Controls.Add(this.btWyłączPokaz);
            this.gbPokazFigurKreślenie.Controls.Add(this.rbManualny);
            this.gbPokazFigurKreślenie.Controls.Add(this.rbAutomatyczny);
            this.gbPokazFigurKreślenie.Controls.Add(this.btWłączSlajd);
            this.gbPokazFigurKreślenie.Location = new System.Drawing.Point(7, 250);
            this.gbPokazFigurKreślenie.Name = "gbPokazFigurKreślenie";
            this.gbPokazFigurKreślenie.Size = new System.Drawing.Size(263, 84);
            this.gbPokazFigurKreślenie.TabIndex = 1;
            this.gbPokazFigurKreślenie.TabStop = false;
            this.gbPokazFigurKreślenie.Text = "Pokaz Figur";
            // 
            // btWyłączPokaz
            // 
            this.btWyłączPokaz.Enabled = false;
            this.btWyłączPokaz.Location = new System.Drawing.Point(135, 42);
            this.btWyłączPokaz.Name = "btWyłączPokaz";
            this.btWyłączPokaz.Size = new System.Drawing.Size(111, 36);
            this.btWyłączPokaz.TabIndex = 8;
            this.btWyłączPokaz.Text = "Wyłącz Pokaz Figur";
            this.btWyłączPokaz.UseVisualStyleBackColor = true;
            this.btWyłączPokaz.Click += new System.EventHandler(this.btWyłączPokazFigurK_Click);
            // 
            // rbManualny
            // 
            this.rbManualny.AutoSize = true;
            this.rbManualny.Enabled = false;
            this.rbManualny.Location = new System.Drawing.Point(135, 19);
            this.rbManualny.Name = "rbManualny";
            this.rbManualny.Size = new System.Drawing.Size(71, 17);
            this.rbManualny.TabIndex = 1;
            this.rbManualny.Text = "Manualny";
            this.rbManualny.UseVisualStyleBackColor = true;
            this.rbManualny.CheckedChanged += new System.EventHandler(this.rbManualnyKreślenie_CheckedChanged);
            // 
            // rbAutomatyczny
            // 
            this.rbAutomatyczny.AutoSize = true;
            this.rbAutomatyczny.Checked = true;
            this.rbAutomatyczny.Enabled = false;
            this.rbAutomatyczny.Location = new System.Drawing.Point(6, 19);
            this.rbAutomatyczny.Name = "rbAutomatyczny";
            this.rbAutomatyczny.Size = new System.Drawing.Size(91, 17);
            this.rbAutomatyczny.TabIndex = 0;
            this.rbAutomatyczny.TabStop = true;
            this.rbAutomatyczny.Text = "Automatyczny";
            this.rbAutomatyczny.UseVisualStyleBackColor = true;
            this.rbAutomatyczny.CheckedChanged += new System.EventHandler(this.rbAutomatyczny_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Położenie myszy (X,Y)";
            // 
            // pbRysownica
            // 
            this.pbRysownica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRysownica.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pbRysownica.Location = new System.Drawing.Point(12, 44);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(515, 527);
            this.pbRysownica.TabIndex = 3;
            this.pbRysownica.TabStop = false;
            this.pbRysownica.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseDown);
            this.pbRysownica.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseMove);
            this.pbRysownica.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseUp);
            // 
            // lbPołożenie
            // 
            this.lbPołożenie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPołożenie.AutoSize = true;
            this.lbPołożenie.Location = new System.Drawing.Point(287, 28);
            this.lbPołożenie.Name = "lbPołożenie";
            this.lbPołożenie.Size = new System.Drawing.Size(45, 13);
            this.lbPołożenie.TabIndex = 4;
            this.lbPołożenie.Text = "X:      Y:";
            // 
            // gbWybierzFigurę
            // 
            this.gbWybierzFigurę.Controls.Add(this.btCofnij);
            this.gbWybierzFigurę.Controls.Add(this.btPrzesuń);
            this.gbWybierzFigurę.Controls.Add(this.rbFillClosedCurve);
            this.gbWybierzFigurę.Controls.Add(this.rbFillPie);
            this.gbWybierzFigurę.Controls.Add(this.rbDrawArc);
            this.gbWybierzFigurę.Controls.Add(this.rbKrzywaKardynalna);
            this.gbWybierzFigurę.Controls.Add(this.rbFillElipse);
            this.gbWybierzFigurę.Controls.Add(this.rbLiniaCiągła);
            this.gbWybierzFigurę.Controls.Add(this.rbLosowyWielokątForemny);
            this.gbWybierzFigurę.Controls.Add(this.rbProstokąt);
            this.gbWybierzFigurę.Controls.Add(this.rbOkrąg);
            this.gbWybierzFigurę.Controls.Add(this.rbLiniaProsta);
            this.gbWybierzFigurę.Controls.Add(this.rbDrawPie);
            this.gbWybierzFigurę.Controls.Add(this.rbClosedCurve);
            this.gbWybierzFigurę.Controls.Add(this.rbFillRectangle);
            this.gbWybierzFigurę.Controls.Add(this.rbKrzywaBeziera);
            this.gbWybierzFigurę.Controls.Add(this.rbWielokątWyp);
            this.gbWybierzFigurę.Controls.Add(this.rbKwadrat);
            this.gbWybierzFigurę.Controls.Add(this.rbKoło);
            this.gbWybierzFigurę.Controls.Add(this.rbElipsa);
            this.gbWybierzFigurę.Controls.Add(this.rbPunkt);
            this.gbWybierzFigurę.Location = new System.Drawing.Point(10, 6);
            this.gbWybierzFigurę.Name = "gbWybierzFigurę";
            this.gbWybierzFigurę.Size = new System.Drawing.Size(260, 238);
            this.gbWybierzFigurę.TabIndex = 5;
            this.gbWybierzFigurę.TabStop = false;
            this.gbWybierzFigurę.Text = "Wybierz Figurę";
            // 
            // btCofnij
            // 
            this.btCofnij.Location = new System.Drawing.Point(133, 208);
            this.btCofnij.Name = "btCofnij";
            this.btCofnij.Size = new System.Drawing.Size(75, 23);
            this.btCofnij.TabIndex = 21;
            this.btCofnij.Text = "Cofnij";
            this.btCofnij.UseVisualStyleBackColor = true;
            this.btCofnij.Click += new System.EventHandler(this.btCofnij_Click);
            // 
            // btPrzesuń
            // 
            this.btPrzesuń.Location = new System.Drawing.Point(44, 208);
            this.btPrzesuń.Name = "btPrzesuń";
            this.btPrzesuń.Size = new System.Drawing.Size(75, 23);
            this.btPrzesuń.TabIndex = 19;
            this.btPrzesuń.Text = "Losuj Lokalizacje";
            this.btPrzesuń.UseVisualStyleBackColor = true;
            this.btPrzesuń.Click += new System.EventHandler(this.btPrzesuń_Click);
            // 
            // rbFillClosedCurve
            // 
            this.rbFillClosedCurve.AutoSize = true;
            this.rbFillClosedCurve.Location = new System.Drawing.Point(9, 185);
            this.rbFillClosedCurve.Name = "rbFillClosedCurve";
            this.rbFillClosedCurve.Size = new System.Drawing.Size(97, 17);
            this.rbFillClosedCurve.TabIndex = 18;
            this.rbFillClosedCurve.Text = "FillClosedCurve";
            this.rbFillClosedCurve.UseVisualStyleBackColor = true;
            // 
            // rbFillPie
            // 
            this.rbFillPie.AutoSize = true;
            this.rbFillPie.Location = new System.Drawing.Point(138, 167);
            this.rbFillPie.Name = "rbFillPie";
            this.rbFillPie.Size = new System.Drawing.Size(52, 17);
            this.rbFillPie.TabIndex = 17;
            this.rbFillPie.Text = "FillPie";
            this.rbFillPie.UseVisualStyleBackColor = true;
            // 
            // rbDrawArc
            // 
            this.rbDrawArc.AutoSize = true;
            this.rbDrawArc.Location = new System.Drawing.Point(138, 149);
            this.rbDrawArc.Name = "rbDrawArc";
            this.rbDrawArc.Size = new System.Drawing.Size(66, 17);
            this.rbDrawArc.TabIndex = 16;
            this.rbDrawArc.Text = "DrawArc";
            this.rbDrawArc.UseVisualStyleBackColor = true;
            // 
            // rbKrzywaKardynalna
            // 
            this.rbKrzywaKardynalna.AutoSize = true;
            this.rbKrzywaKardynalna.Location = new System.Drawing.Point(138, 131);
            this.rbKrzywaKardynalna.Name = "rbKrzywaKardynalna";
            this.rbKrzywaKardynalna.Size = new System.Drawing.Size(115, 17);
            this.rbKrzywaKardynalna.TabIndex = 15;
            this.rbKrzywaKardynalna.Text = "Krzywa Kardynalna";
            this.rbKrzywaKardynalna.UseVisualStyleBackColor = true;
            // 
            // rbFillElipse
            // 
            this.rbFillElipse.AutoSize = true;
            this.rbFillElipse.Location = new System.Drawing.Point(138, 113);
            this.rbFillElipse.Name = "rbFillElipse";
            this.rbFillElipse.Size = new System.Drawing.Size(65, 17);
            this.rbFillElipse.TabIndex = 14;
            this.rbFillElipse.Text = "FillElipse";
            this.rbFillElipse.UseVisualStyleBackColor = true;
            // 
            // rbLiniaCiągła
            // 
            this.rbLiniaCiągła.AutoSize = true;
            this.rbLiniaCiągła.Location = new System.Drawing.Point(138, 95);
            this.rbLiniaCiągła.Name = "rbLiniaCiągła";
            this.rbLiniaCiągła.Size = new System.Drawing.Size(81, 17);
            this.rbLiniaCiągła.TabIndex = 13;
            this.rbLiniaCiągła.Text = "Linia Ciągła";
            this.rbLiniaCiągła.UseVisualStyleBackColor = true;
            // 
            // rbLosowyWielokątForemny
            // 
            this.rbLosowyWielokątForemny.AutoSize = true;
            this.rbLosowyWielokątForemny.Location = new System.Drawing.Point(138, 77);
            this.rbLosowyWielokątForemny.Name = "rbLosowyWielokątForemny";
            this.rbLosowyWielokątForemny.Size = new System.Drawing.Size(106, 17);
            this.rbLosowyWielokątForemny.TabIndex = 12;
            this.rbLosowyWielokątForemny.Text = "Losowy Wielokąt";
            this.rbLosowyWielokątForemny.UseVisualStyleBackColor = true;
            this.rbLosowyWielokątForemny.CheckedChanged += new System.EventHandler(this.rbWielokątForemny_CheckedChanged);
            // 
            // rbProstokąt
            // 
            this.rbProstokąt.AutoSize = true;
            this.rbProstokąt.Location = new System.Drawing.Point(138, 59);
            this.rbProstokąt.Name = "rbProstokąt";
            this.rbProstokąt.Size = new System.Drawing.Size(70, 17);
            this.rbProstokąt.TabIndex = 11;
            this.rbProstokąt.Text = "Prostokąt";
            this.rbProstokąt.UseVisualStyleBackColor = true;
            // 
            // rbOkrąg
            // 
            this.rbOkrąg.AutoSize = true;
            this.rbOkrąg.Location = new System.Drawing.Point(138, 41);
            this.rbOkrąg.Name = "rbOkrąg";
            this.rbOkrąg.Size = new System.Drawing.Size(54, 17);
            this.rbOkrąg.TabIndex = 10;
            this.rbOkrąg.Text = "Okrąg";
            this.rbOkrąg.UseVisualStyleBackColor = true;
            // 
            // rbLiniaProsta
            // 
            this.rbLiniaProsta.AutoSize = true;
            this.rbLiniaProsta.Location = new System.Drawing.Point(138, 23);
            this.rbLiniaProsta.Name = "rbLiniaProsta";
            this.rbLiniaProsta.Size = new System.Drawing.Size(80, 17);
            this.rbLiniaProsta.TabIndex = 9;
            this.rbLiniaProsta.Text = "Linia Prosta";
            this.rbLiniaProsta.UseVisualStyleBackColor = true;
            // 
            // rbDrawPie
            // 
            this.rbDrawPie.AutoSize = true;
            this.rbDrawPie.Location = new System.Drawing.Point(9, 167);
            this.rbDrawPie.Name = "rbDrawPie";
            this.rbDrawPie.Size = new System.Drawing.Size(65, 17);
            this.rbDrawPie.TabIndex = 8;
            this.rbDrawPie.Text = "DrawPie";
            this.rbDrawPie.UseVisualStyleBackColor = true;
            // 
            // rbClosedCurve
            // 
            this.rbClosedCurve.AutoSize = true;
            this.rbClosedCurve.Location = new System.Drawing.Point(9, 149);
            this.rbClosedCurve.Name = "rbClosedCurve";
            this.rbClosedCurve.Size = new System.Drawing.Size(110, 17);
            this.rbClosedCurve.TabIndex = 7;
            this.rbClosedCurve.Text = "DrawClosedCurve";
            this.rbClosedCurve.UseVisualStyleBackColor = true;
            // 
            // rbFillRectangle
            // 
            this.rbFillRectangle.AutoSize = true;
            this.rbFillRectangle.Location = new System.Drawing.Point(9, 131);
            this.rbFillRectangle.Name = "rbFillRectangle";
            this.rbFillRectangle.Size = new System.Drawing.Size(89, 17);
            this.rbFillRectangle.TabIndex = 6;
            this.rbFillRectangle.Text = "Fill Rectangle";
            this.rbFillRectangle.UseVisualStyleBackColor = true;
            // 
            // rbKrzywaBeziera
            // 
            this.rbKrzywaBeziera.AutoSize = true;
            this.rbKrzywaBeziera.Location = new System.Drawing.Point(9, 113);
            this.rbKrzywaBeziera.Name = "rbKrzywaBeziera";
            this.rbKrzywaBeziera.Size = new System.Drawing.Size(97, 17);
            this.rbKrzywaBeziera.TabIndex = 5;
            this.rbKrzywaBeziera.Text = "Krzywa Beziera";
            this.rbKrzywaBeziera.UseVisualStyleBackColor = true;
            // 
            // rbWielokątWyp
            // 
            this.rbWielokątWyp.AutoSize = true;
            this.rbWielokątWyp.Location = new System.Drawing.Point(9, 95);
            this.rbWielokątWyp.Name = "rbWielokątWyp";
            this.rbWielokątWyp.Size = new System.Drawing.Size(127, 17);
            this.rbWielokątWyp.TabIndex = 4;
            this.rbWielokątWyp.Text = "Wielokąt Wypełniony";
            this.rbWielokątWyp.UseVisualStyleBackColor = true;
            // 
            // rbKwadrat
            // 
            this.rbKwadrat.AutoSize = true;
            this.rbKwadrat.Location = new System.Drawing.Point(9, 77);
            this.rbKwadrat.Name = "rbKwadrat";
            this.rbKwadrat.Size = new System.Drawing.Size(64, 17);
            this.rbKwadrat.TabIndex = 3;
            this.rbKwadrat.Text = "Kwadrat";
            this.rbKwadrat.UseVisualStyleBackColor = true;
            // 
            // rbKoło
            // 
            this.rbKoło.AutoSize = true;
            this.rbKoło.Location = new System.Drawing.Point(10, 59);
            this.rbKoło.Name = "rbKoło";
            this.rbKoło.Size = new System.Drawing.Size(48, 17);
            this.rbKoło.TabIndex = 2;
            this.rbKoło.Text = "Koło";
            this.rbKoło.UseVisualStyleBackColor = true;
            // 
            // rbElipsa
            // 
            this.rbElipsa.AutoSize = true;
            this.rbElipsa.Location = new System.Drawing.Point(10, 41);
            this.rbElipsa.Name = "rbElipsa";
            this.rbElipsa.Size = new System.Drawing.Size(53, 17);
            this.rbElipsa.TabIndex = 1;
            this.rbElipsa.Text = "Elipsa";
            this.rbElipsa.UseVisualStyleBackColor = true;
            // 
            // rbPunkt
            // 
            this.rbPunkt.AutoSize = true;
            this.rbPunkt.Checked = true;
            this.rbPunkt.Location = new System.Drawing.Point(10, 23);
            this.rbPunkt.Name = "rbPunkt";
            this.rbPunkt.Size = new System.Drawing.Size(53, 17);
            this.rbPunkt.TabIndex = 0;
            this.rbPunkt.TabStop = true;
            this.rbPunkt.Text = "Punkt";
            this.rbPunkt.UseVisualStyleBackColor = true;
            this.rbPunkt.CheckedChanged += new System.EventHandler(this.rbPunkt_CheckedChanged);
            // 
            // gbManualnaKontrolaK
            // 
            this.gbManualnaKontrolaK.Controls.Add(this.label2);
            this.gbManualnaKontrolaK.Controls.Add(this.tbNumerFigury);
            this.gbManualnaKontrolaK.Controls.Add(this.btPoprzedni);
            this.gbManualnaKontrolaK.Controls.Add(this.btNastępny);
            this.gbManualnaKontrolaK.Location = new System.Drawing.Point(10, 340);
            this.gbManualnaKontrolaK.Name = "gbManualnaKontrolaK";
            this.gbManualnaKontrolaK.Size = new System.Drawing.Size(263, 67);
            this.gbManualnaKontrolaK.TabIndex = 7;
            this.gbManualnaKontrolaK.TabStop = false;
            this.gbManualnaKontrolaK.Text = "Manualna Kontrola Pokazu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numer Figury";
            // 
            // tbNumerFigury
            // 
            this.tbNumerFigury.Enabled = false;
            this.tbNumerFigury.Location = new System.Drawing.Point(87, 39);
            this.tbNumerFigury.Name = "tbNumerFigury";
            this.tbNumerFigury.Size = new System.Drawing.Size(81, 20);
            this.tbNumerFigury.TabIndex = 2;
            // 
            // btPoprzedni
            // 
            this.btPoprzedni.Enabled = false;
            this.btPoprzedni.Location = new System.Drawing.Point(6, 37);
            this.btPoprzedni.Name = "btPoprzedni";
            this.btPoprzedni.Size = new System.Drawing.Size(75, 23);
            this.btPoprzedni.TabIndex = 1;
            this.btPoprzedni.Text = "Poprzedni";
            this.btPoprzedni.UseVisualStyleBackColor = true;
            this.btPoprzedni.Click += new System.EventHandler(this.btPoprzedniK_Click);
            // 
            // btNastępny
            // 
            this.btNastępny.Enabled = false;
            this.btNastępny.Location = new System.Drawing.Point(174, 37);
            this.btNastępny.Name = "btNastępny";
            this.btNastępny.Size = new System.Drawing.Size(75, 23);
            this.btNastępny.TabIndex = 0;
            this.btNastępny.Text = "Następny";
            this.btNastępny.UseVisualStyleBackColor = true;
            this.btNastępny.Click += new System.EventHandler(this.btNastępnyK_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gbAtrybutyGraficzne);
            this.panel1.Controls.Add(this.gbManualnaKontrolaK);
            this.panel1.Controls.Add(this.gbWybierzFigurę);
            this.panel1.Controls.Add(this.gbPokazFigurKreślenie);
            this.panel1.Location = new System.Drawing.Point(542, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 543);
            this.panel1.TabIndex = 9;
            // 
            // gbAtrybutyGraficzne
            // 
            this.gbAtrybutyGraficzne.Controls.Add(this.label4);
            this.gbAtrybutyGraficzne.Controls.Add(this.trbUstawGrubośćLinii);
            this.gbAtrybutyGraficzne.Controls.Add(this.cbWybierzStylLinii);
            this.gbAtrybutyGraficzne.Controls.Add(this.txtKolorWypełnienia);
            this.gbAtrybutyGraficzne.Controls.Add(this.btnKolorWypełnienia);
            this.gbAtrybutyGraficzne.Controls.Add(this.txtKolorLinii);
            this.gbAtrybutyGraficzne.Controls.Add(this.btnKolorLinii);
            this.gbAtrybutyGraficzne.Location = new System.Drawing.Point(9, 412);
            this.gbAtrybutyGraficzne.Margin = new System.Windows.Forms.Padding(2);
            this.gbAtrybutyGraficzne.Name = "gbAtrybutyGraficzne";
            this.gbAtrybutyGraficzne.Padding = new System.Windows.Forms.Padding(2);
            this.gbAtrybutyGraficzne.Size = new System.Drawing.Size(246, 129);
            this.gbAtrybutyGraficzne.TabIndex = 10;
            this.gbAtrybutyGraficzne.TabStop = false;
            this.gbAtrybutyGraficzne.Text = "Atrybuty graficzne";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(116, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ustaw grubość linii";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trbUstawGrubośćLinii
            // 
            this.trbUstawGrubośćLinii.Location = new System.Drawing.Point(119, 80);
            this.trbUstawGrubośćLinii.Margin = new System.Windows.Forms.Padding(2);
            this.trbUstawGrubośćLinii.Minimum = 3;
            this.trbUstawGrubośćLinii.Name = "trbUstawGrubośćLinii";
            this.trbUstawGrubośćLinii.Size = new System.Drawing.Size(115, 45);
            this.trbUstawGrubośćLinii.TabIndex = 10;
            this.trbUstawGrubośćLinii.Value = 3;
            // 
            // cbWybierzStylLinii
            // 
            this.cbWybierzStylLinii.FormattingEnabled = true;
            this.cbWybierzStylLinii.Items.AddRange(new object[] {
            "Linia",
            "Kreska",
            "Kropka",
            "Kreska-Kropka",
            "Kreska-Kropka-Kropka"});
            this.cbWybierzStylLinii.Location = new System.Drawing.Point(116, 22);
            this.cbWybierzStylLinii.Margin = new System.Windows.Forms.Padding(2);
            this.cbWybierzStylLinii.Name = "cbWybierzStylLinii";
            this.cbWybierzStylLinii.Size = new System.Drawing.Size(116, 21);
            this.cbWybierzStylLinii.TabIndex = 4;
            this.cbWybierzStylLinii.Text = "Wybierz styl linii";
            this.cbWybierzStylLinii.SelectedIndexChanged += new System.EventHandler(this.cbWybierzStylLinii_SelectedIndexChanged);
            // 
            // txtKolorWypełnienia
            // 
            this.txtKolorWypełnienia.BackColor = System.Drawing.Color.Blue;
            this.txtKolorWypełnienia.Location = new System.Drawing.Point(5, 100);
            this.txtKolorWypełnienia.Margin = new System.Windows.Forms.Padding(2);
            this.txtKolorWypełnienia.Name = "txtKolorWypełnienia";
            this.txtKolorWypełnienia.Size = new System.Drawing.Size(76, 20);
            this.txtKolorWypełnienia.TabIndex = 3;
            // 
            // btnKolorWypełnienia
            // 
            this.btnKolorWypełnienia.Location = new System.Drawing.Point(4, 69);
            this.btnKolorWypełnienia.Margin = new System.Windows.Forms.Padding(2);
            this.btnKolorWypełnienia.Name = "btnKolorWypełnienia";
            this.btnKolorWypełnienia.Size = new System.Drawing.Size(103, 27);
            this.btnKolorWypełnienia.TabIndex = 2;
            this.btnKolorWypełnienia.Text = "Kolor wypełnienia";
            this.btnKolorWypełnienia.UseVisualStyleBackColor = true;
            this.btnKolorWypełnienia.Click += new System.EventHandler(this.btnKolorWypełnienia_Click);
            // 
            // txtKolorLinii
            // 
            this.txtKolorLinii.BackColor = System.Drawing.Color.Red;
            this.txtKolorLinii.Location = new System.Drawing.Point(5, 46);
            this.txtKolorLinii.Margin = new System.Windows.Forms.Padding(2);
            this.txtKolorLinii.Name = "txtKolorLinii";
            this.txtKolorLinii.Size = new System.Drawing.Size(76, 20);
            this.txtKolorLinii.TabIndex = 1;
            // 
            // btnKolorLinii
            // 
            this.btnKolorLinii.Location = new System.Drawing.Point(5, 18);
            this.btnKolorLinii.Margin = new System.Windows.Forms.Padding(2);
            this.btnKolorLinii.Name = "btnKolorLinii";
            this.btnKolorLinii.Size = new System.Drawing.Size(75, 24);
            this.btnKolorLinii.TabIndex = 0;
            this.btnKolorLinii.Text = "Kolor linii";
            this.btnKolorLinii.UseVisualStyleBackColor = true;
            this.btnKolorLinii.Click += new System.EventHandler(this.btnKolorLinii_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.msUstawienieKoloru});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszBitmapęToolStripMenuItem,
            this.wczytajBitmapęToolStripMenuItem,
            this.powrótToolStripMenuItem,
            this.wyjścieToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zapiszBitmapęToolStripMenuItem
            // 
            this.zapiszBitmapęToolStripMenuItem.Enabled = false;
            this.zapiszBitmapęToolStripMenuItem.Name = "zapiszBitmapęToolStripMenuItem";
            this.zapiszBitmapęToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.zapiszBitmapęToolStripMenuItem.Text = "Zapisz Bitmapę";
            this.zapiszBitmapęToolStripMenuItem.Click += new System.EventHandler(this.zapiszBitmapęToolStripMenuItem_Click);
            // 
            // wczytajBitmapęToolStripMenuItem
            // 
            this.wczytajBitmapęToolStripMenuItem.Enabled = false;
            this.wczytajBitmapęToolStripMenuItem.Name = "wczytajBitmapęToolStripMenuItem";
            this.wczytajBitmapęToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.wczytajBitmapęToolStripMenuItem.Text = "WczytajBitmapę";
            // 
            // powrótToolStripMenuItem
            // 
            this.powrótToolStripMenuItem.Name = "powrótToolStripMenuItem";
            this.powrótToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.powrótToolStripMenuItem.Text = "Powrót";
            this.powrótToolStripMenuItem.Click += new System.EventHandler(this.powrótToolStripMenuItem_Click);
            // 
            // wyjścieToolStripMenuItem
            // 
            this.wyjścieToolStripMenuItem.Name = "wyjścieToolStripMenuItem";
            this.wyjścieToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.wyjścieToolStripMenuItem.Text = "Wyjście";
            this.wyjścieToolStripMenuItem.Click += new System.EventHandler(this.wyjścieToolStripMenuItem_Click);
            // 
            // msUstawienieKoloru
            // 
            this.msUstawienieKoloru.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wybierzKolorToolStripMenuItem,
            this.ustawTłoToolStripMenuItem,
            this.wybierzKolorTłaToolStripMenuItem});
            this.msUstawienieKoloru.Name = "msUstawienieKoloru";
            this.msUstawienieKoloru.Size = new System.Drawing.Size(47, 20);
            this.msUstawienieKoloru.Text = "Kolor";
            // 
            // wybierzKolorToolStripMenuItem
            // 
            this.wybierzKolorToolStripMenuItem.Name = "wybierzKolorToolStripMenuItem";
            this.wybierzKolorToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.wybierzKolorToolStripMenuItem.Text = "Wybierz Kolor";
            this.wybierzKolorToolStripMenuItem.Click += new System.EventHandler(this.wybierzKolorToolStripMenuItem_Click);
            // 
            // ustawTłoToolStripMenuItem
            // 
            this.ustawTłoToolStripMenuItem.Name = "ustawTłoToolStripMenuItem";
            this.ustawTłoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ustawTłoToolStripMenuItem.Text = "Ustaw Kolor Wypełnienia";
            this.ustawTłoToolStripMenuItem.Click += new System.EventHandler(this.ustawTłoToolStripMenuItem_Click);
            // 
            // wybierzKolorTłaToolStripMenuItem
            // 
            this.wybierzKolorTłaToolStripMenuItem.Name = "wybierzKolorTłaToolStripMenuItem";
            this.wybierzKolorTłaToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.wybierzKolorTłaToolStripMenuItem.Text = "Wybierz Kolor Tła";
            this.wybierzKolorTłaToolStripMenuItem.Click += new System.EventHandler(this.wybierzKolorTłaToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // KreślenieFigur_Lini_Skupiński
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 583);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbPołożenie);
            this.Controls.Add(this.pbRysownica);
            this.Controls.Add(this.label1);
            this.Name = "KreślenieFigur_Lini_Skupiński";
            this.Text = "Kreślenie Figur Geometrycznych";
            this.gbPokazFigurKreślenie.ResumeLayout(false);
            this.gbPokazFigurKreślenie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            this.gbWybierzFigurę.ResumeLayout(false);
            this.gbWybierzFigurę.PerformLayout();
            this.gbManualnaKontrolaK.ResumeLayout(false);
            this.gbManualnaKontrolaK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbAtrybutyGraficzne.ResumeLayout(false);
            this.gbAtrybutyGraficzne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbUstawGrubośćLinii)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btWłączSlajd;
        private System.Windows.Forms.GroupBox gbPokazFigurKreślenie;
        private System.Windows.Forms.RadioButton rbManualny;
        private System.Windows.Forms.RadioButton rbAutomatyczny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.Label lbPołożenie;
        private System.Windows.Forms.GroupBox gbWybierzFigurę;
        private System.Windows.Forms.RadioButton rbFillClosedCurve;
        private System.Windows.Forms.RadioButton rbFillPie;
        private System.Windows.Forms.RadioButton rbDrawArc;
        private System.Windows.Forms.RadioButton rbKrzywaKardynalna;
        private System.Windows.Forms.RadioButton rbFillElipse;
        private System.Windows.Forms.RadioButton rbLiniaCiągła;
        private System.Windows.Forms.RadioButton rbLosowyWielokątForemny;
        private System.Windows.Forms.RadioButton rbProstokąt;
        private System.Windows.Forms.RadioButton rbOkrąg;
        private System.Windows.Forms.RadioButton rbLiniaProsta;
        private System.Windows.Forms.RadioButton rbDrawPie;
        private System.Windows.Forms.RadioButton rbClosedCurve;
        private System.Windows.Forms.RadioButton rbFillRectangle;
        private System.Windows.Forms.RadioButton rbKrzywaBeziera;
        private System.Windows.Forms.RadioButton rbWielokątWyp;
        private System.Windows.Forms.RadioButton rbKwadrat;
        private System.Windows.Forms.RadioButton rbKoło;
        private System.Windows.Forms.RadioButton rbElipsa;
        private System.Windows.Forms.RadioButton rbPunkt;
        private System.Windows.Forms.GroupBox gbManualnaKontrolaK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumerFigury;
        private System.Windows.Forms.Button btPoprzedni;
        private System.Windows.Forms.Button btNastępny;
        private System.Windows.Forms.Button btWyłączPokaz;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbAtrybutyGraficzne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trbUstawGrubośćLinii;
        private System.Windows.Forms.ComboBox cbWybierzStylLinii;
        private System.Windows.Forms.TextBox txtKolorWypełnienia;
        private System.Windows.Forms.Button btnKolorWypełnienia;
        private System.Windows.Forms.TextBox txtKolorLinii;
        private System.Windows.Forms.Button btnKolorLinii;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszBitmapęToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajBitmapęToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powrótToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjścieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msUstawienieKoloru;
        private System.Windows.Forms.ToolStripMenuItem wybierzKolorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawTłoToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btCofnij;
        private System.Windows.Forms.Button btPrzesuń;
        private System.Windows.Forms.ToolStripMenuItem wybierzKolorTłaToolStripMenuItem;
    }
}