
namespace Projekt2_Skupiński59369
{
    partial class PrezentacjaLosowaZeSlajderem
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
            this.gbPrzyciski = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPodajLiczbęFigur = new System.Windows.Forms.TextBox();
            this.btWyłączPokaz = new System.Windows.Forms.Button();
            this.btWłączSlajd = new System.Windows.Forms.Button();
            this.btInneFunkcjonalności = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btLosujAtrybuty = new System.Windows.Forms.Button();
            this.btLosujPołożenieIAtrybuty = new System.Windows.Forms.Button();
            this.btPrzesuń = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.gbPokaz = new System.Windows.Forms.GroupBox();
            this.rbManualny = new System.Windows.Forms.RadioButton();
            this.rbAutomatyczny = new System.Windows.Forms.RadioButton();
            this.gbManualnaKontrola = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumerFigury = new System.Windows.Forms.TextBox();
            this.btPoprzedni = new System.Windows.Forms.Button();
            this.btNastępny = new System.Windows.Forms.Button();
            this.clbFigury = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszBitmapęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajBitmapęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powrótToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjścieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btResetuj = new System.Windows.Forms.Button();
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.wybierzKolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawTłoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msUstawienieKoloru = new System.Windows.Forms.ToolStripMenuItem();
            this.CiągłaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KreskowatoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kropkowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreskowoKropkowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msUstawienieStyluLini = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.msUstawienieGrubościLini = new System.Windows.Forms.ToolStripMenuItem();
            this.gbPrzyciski.SuspendLayout();
            this.gbPokaz.SuspendLayout();
            this.gbManualnaKontrola.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPrzyciski
            // 
            this.gbPrzyciski.Controls.Add(this.label1);
            this.gbPrzyciski.Controls.Add(this.tbPodajLiczbęFigur);
            this.gbPrzyciski.Controls.Add(this.btWyłączPokaz);
            this.gbPrzyciski.Controls.Add(this.btWłączSlajd);
            this.gbPrzyciski.Controls.Add(this.btInneFunkcjonalności);
            this.gbPrzyciski.Controls.Add(this.btStop);
            this.gbPrzyciski.Controls.Add(this.btLosujAtrybuty);
            this.gbPrzyciski.Controls.Add(this.btLosujPołożenieIAtrybuty);
            this.gbPrzyciski.Controls.Add(this.btPrzesuń);
            this.gbPrzyciski.Controls.Add(this.btStart);
            this.gbPrzyciski.Location = new System.Drawing.Point(13, 27);
            this.gbPrzyciski.Name = "gbPrzyciski";
            this.gbPrzyciski.Size = new System.Drawing.Size(175, 411);
            this.gbPrzyciski.TabIndex = 0;
            this.gbPrzyciski.TabStop = false;
            this.gbPrzyciski.Text = "Przyciski Kontrolne";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Podaj Liczbę Figur";
            // 
            // tbPodajLiczbęFigur
            // 
            this.tbPodajLiczbęFigur.Location = new System.Drawing.Point(39, 366);
            this.tbPodajLiczbęFigur.Name = "tbPodajLiczbęFigur";
            this.tbPodajLiczbęFigur.Size = new System.Drawing.Size(100, 20);
            this.tbPodajLiczbęFigur.TabIndex = 8;
            this.tbPodajLiczbęFigur.Text = "5";
            // 
            // btWyłączPokaz
            // 
            this.btWyłączPokaz.Enabled = false;
            this.btWyłączPokaz.Location = new System.Drawing.Point(18, 292);
            this.btWyłączPokaz.Name = "btWyłączPokaz";
            this.btWyłączPokaz.Size = new System.Drawing.Size(133, 44);
            this.btWyłączPokaz.TabIndex = 7;
            this.btWyłączPokaz.Text = "Wyłącz pokaz figur geometrycznych";
            this.btWyłączPokaz.UseVisualStyleBackColor = true;
            this.btWyłączPokaz.Click += new System.EventHandler(this.btWyłączPokaz_Click_1);
            // 
            // btWłączSlajd
            // 
            this.btWłączSlajd.Enabled = false;
            this.btWłączSlajd.Location = new System.Drawing.Point(18, 254);
            this.btWłączSlajd.Name = "btWłączSlajd";
            this.btWłączSlajd.Size = new System.Drawing.Size(133, 38);
            this.btWłączSlajd.TabIndex = 6;
            this.btWłączSlajd.Text = "Włączenie slajdera figur geometrycznych";
            this.btWłączSlajd.UseVisualStyleBackColor = true;
            this.btWłączSlajd.Click += new System.EventHandler(this.btWłączSlajd_Click_1);
            // 
            // btInneFunkcjonalności
            // 
            this.btInneFunkcjonalności.Enabled = false;
            this.btInneFunkcjonalności.Location = new System.Drawing.Point(18, 219);
            this.btInneFunkcjonalności.Name = "btInneFunkcjonalności";
            this.btInneFunkcjonalności.Size = new System.Drawing.Size(133, 35);
            this.btInneFunkcjonalności.TabIndex = 5;
            this.btInneFunkcjonalności.Text = "Inne funkcjonalności ";
            this.btInneFunkcjonalności.UseVisualStyleBackColor = true;
            // 
            // btStop
            // 
            this.btStop.Enabled = false;
            this.btStop.Location = new System.Drawing.Point(18, 184);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(133, 35);
            this.btStop.TabIndex = 4;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click_1);
            // 
            // btLosujAtrybuty
            // 
            this.btLosujAtrybuty.Enabled = false;
            this.btLosujAtrybuty.Location = new System.Drawing.Point(18, 145);
            this.btLosujAtrybuty.Name = "btLosujAtrybuty";
            this.btLosujAtrybuty.Size = new System.Drawing.Size(133, 39);
            this.btLosujAtrybuty.TabIndex = 3;
            this.btLosujAtrybuty.Text = "Losuj atrybuty graficzne figur geometrycznych";
            this.btLosujAtrybuty.UseVisualStyleBackColor = true;
            this.btLosujAtrybuty.Click += new System.EventHandler(this.btLosujAtrybuty_Click_1);
            // 
            // btLosujPołożenieIAtrybuty
            // 
            this.btLosujPołożenieIAtrybuty.Enabled = false;
            this.btLosujPołożenieIAtrybuty.Location = new System.Drawing.Point(18, 101);
            this.btLosujPołożenieIAtrybuty.Name = "btLosujPołożenieIAtrybuty";
            this.btLosujPołożenieIAtrybuty.Size = new System.Drawing.Size(133, 44);
            this.btLosujPołożenieIAtrybuty.TabIndex = 2;
            this.btLosujPołożenieIAtrybuty.Text = "Wylosuj nowe położenie i atrybuty graficzne";
            this.btLosujPołożenieIAtrybuty.UseVisualStyleBackColor = true;
            this.btLosujPołożenieIAtrybuty.Click += new System.EventHandler(this.btLosujPołożenieIAtrybuty_Click);
            // 
            // btPrzesuń
            // 
            this.btPrzesuń.Enabled = false;
            this.btPrzesuń.Location = new System.Drawing.Point(18, 66);
            this.btPrzesuń.Name = "btPrzesuń";
            this.btPrzesuń.Size = new System.Drawing.Size(133, 35);
            this.btPrzesuń.TabIndex = 1;
            this.btPrzesuń.Text = "Przesuń do nowego miejsca";
            this.btPrzesuń.UseVisualStyleBackColor = true;
            this.btPrzesuń.Click += new System.EventHandler(this.btPrzesuń_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(18, 26);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(133, 40);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // gbPokaz
            // 
            this.gbPokaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbPokaz.Controls.Add(this.rbManualny);
            this.gbPokaz.Controls.Add(this.rbAutomatyczny);
            this.gbPokaz.Location = new System.Drawing.Point(192, 356);
            this.gbPokaz.Name = "gbPokaz";
            this.gbPokaz.Size = new System.Drawing.Size(162, 82);
            this.gbPokaz.TabIndex = 1;
            this.gbPokaz.TabStop = false;
            this.gbPokaz.Text = "Pokaz Figur Geometrycznych";
            // 
            // rbManualny
            // 
            this.rbManualny.AutoSize = true;
            this.rbManualny.Enabled = false;
            this.rbManualny.Location = new System.Drawing.Point(6, 43);
            this.rbManualny.Name = "rbManualny";
            this.rbManualny.Size = new System.Drawing.Size(71, 17);
            this.rbManualny.TabIndex = 1;
            this.rbManualny.Text = "Manualny";
            this.rbManualny.UseVisualStyleBackColor = true;
            this.rbManualny.CheckedChanged += new System.EventHandler(this.rbManualny_CheckedChanged);
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
            // gbManualnaKontrola
            // 
            this.gbManualnaKontrola.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbManualnaKontrola.Controls.Add(this.label2);
            this.gbManualnaKontrola.Controls.Add(this.tbNumerFigury);
            this.gbManualnaKontrola.Controls.Add(this.btPoprzedni);
            this.gbManualnaKontrola.Controls.Add(this.btNastępny);
            this.gbManualnaKontrola.Location = new System.Drawing.Point(360, 356);
            this.gbManualnaKontrola.Name = "gbManualnaKontrola";
            this.gbManualnaKontrola.Size = new System.Drawing.Size(263, 82);
            this.gbManualnaKontrola.TabIndex = 2;
            this.gbManualnaKontrola.TabStop = false;
            this.gbManualnaKontrola.Text = "Manualna Kontrola Pokazu";
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
            this.tbNumerFigury.Text = "0";
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
            this.btPoprzedni.Click += new System.EventHandler(this.btPoprzedni_Click_1);
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
            this.btNastępny.Click += new System.EventHandler(this.btNastępny_Click_1);
            // 
            // clbFigury
            // 
            this.clbFigury.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clbFigury.CheckOnClick = true;
            this.clbFigury.FormattingEnabled = true;
            this.clbFigury.Items.AddRange(new object[] {
            "Punkt",
            "Linia",
            "Elipsa",
            "Okrąg",
            "Prostokąt",
            "Kwadrat",
            "Wielokąt foremny",
            "Koło"});
            this.clbFigury.Location = new System.Drawing.Point(640, 52);
            this.clbFigury.Name = "clbFigury";
            this.clbFigury.Size = new System.Drawing.Size(120, 259);
            this.clbFigury.TabIndex = 3;
            this.clbFigury.SelectedIndexChanged += new System.EventHandler(this.clbFigury_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(621, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Zaznacz pulę figur do losowania";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.msUstawienieKoloru,
            this.msUstawienieGrubościLini,
            this.msUstawienieStyluLini});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
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
            this.zapiszBitmapęToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zapiszBitmapęToolStripMenuItem.Text = "Zapisz Bitmapę";
            // 
            // wczytajBitmapęToolStripMenuItem
            // 
            this.wczytajBitmapęToolStripMenuItem.Enabled = false;
            this.wczytajBitmapęToolStripMenuItem.Name = "wczytajBitmapęToolStripMenuItem";
            this.wczytajBitmapęToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wczytajBitmapęToolStripMenuItem.Text = "WczytajBitmapę";
            // 
            // powrótToolStripMenuItem
            // 
            this.powrótToolStripMenuItem.Name = "powrótToolStripMenuItem";
            this.powrótToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.powrótToolStripMenuItem.Text = "Powrót";
            this.powrótToolStripMenuItem.Click += new System.EventHandler(this.powrótToolStripMenuItem_Click);
            // 
            // wyjścieToolStripMenuItem
            // 
            this.wyjścieToolStripMenuItem.Name = "wyjścieToolStripMenuItem";
            this.wyjścieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wyjścieToolStripMenuItem.Text = "Wyjście";
            this.wyjścieToolStripMenuItem.Click += new System.EventHandler(this.wyjścieToolStripMenuItem_Click);
            // 
            // btResetuj
            // 
            this.btResetuj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btResetuj.Location = new System.Drawing.Point(640, 377);
            this.btResetuj.Name = "btResetuj";
            this.btResetuj.Size = new System.Drawing.Size(140, 50);
            this.btResetuj.TabIndex = 6;
            this.btResetuj.Text = "Przywróć Stan Początkowy";
            this.btResetuj.UseVisualStyleBackColor = true;
            this.btResetuj.Click += new System.EventHandler(this.btResetuj_Click_1);
            // 
            // pbRysownica
            // 
            this.pbRysownica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRysownica.Location = new System.Drawing.Point(198, 37);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(411, 313);
            this.pbRysownica.TabIndex = 7;
            this.pbRysownica.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // wybierzKolorToolStripMenuItem
            // 
            this.wybierzKolorToolStripMenuItem.Name = "wybierzKolorToolStripMenuItem";
            this.wybierzKolorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wybierzKolorToolStripMenuItem.Text = "Wybierz Kolor";
            this.wybierzKolorToolStripMenuItem.Click += new System.EventHandler(this.wybierzKolorToolStripMenuItem_Click);
            // 
            // ustawTłoToolStripMenuItem
            // 
            this.ustawTłoToolStripMenuItem.Name = "ustawTłoToolStripMenuItem";
            this.ustawTłoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ustawTłoToolStripMenuItem.Text = "Ustaw Tło";
            this.ustawTłoToolStripMenuItem.Click += new System.EventHandler(this.ustawTłoToolStripMenuItem_Click);
            // 
            // msUstawienieKoloru
            // 
            this.msUstawienieKoloru.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wybierzKolorToolStripMenuItem,
            this.ustawTłoToolStripMenuItem});
            this.msUstawienieKoloru.Name = "msUstawienieKoloru";
            this.msUstawienieKoloru.Size = new System.Drawing.Size(47, 20);
            this.msUstawienieKoloru.Text = "Kolor";
            // 
            // CiągłaToolStripMenuItem
            // 
            this.CiągłaToolStripMenuItem.Name = "CiągłaToolStripMenuItem";
            this.CiągłaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.CiągłaToolStripMenuItem.Text = "Ciągła";
            this.CiągłaToolStripMenuItem.Click += new System.EventHandler(this.CiągłaToolStripMenuItem_Click);
            // 
            // KreskowatoolStripMenuItem1
            // 
            this.KreskowatoolStripMenuItem1.Name = "KreskowatoolStripMenuItem1";
            this.KreskowatoolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.KreskowatoolStripMenuItem1.Text = "Kreskowa";
            this.KreskowatoolStripMenuItem1.Click += new System.EventHandler(this.KreskowatoolStripMenuItem1_Click);
            // 
            // kropkowaToolStripMenuItem
            // 
            this.kropkowaToolStripMenuItem.Name = "kropkowaToolStripMenuItem";
            this.kropkowaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.kropkowaToolStripMenuItem.Text = "Kropkowa";
            this.kropkowaToolStripMenuItem.Click += new System.EventHandler(this.kropkowaToolStripMenuItem_Click);
            // 
            // kreskowoKropkowaToolStripMenuItem
            // 
            this.kreskowoKropkowaToolStripMenuItem.Name = "kreskowoKropkowaToolStripMenuItem";
            this.kreskowoKropkowaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.kreskowoKropkowaToolStripMenuItem.Text = "Kreskowo-Kropkowa";
            this.kreskowoKropkowaToolStripMenuItem.Click += new System.EventHandler(this.kreskowoKropkowaToolStripMenuItem_Click);
            // 
            // msUstawienieStyluLini
            // 
            this.msUstawienieStyluLini.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CiągłaToolStripMenuItem,
            this.KreskowatoolStripMenuItem1,
            this.kropkowaToolStripMenuItem,
            this.kreskowoKropkowaToolStripMenuItem});
            this.msUstawienieStyluLini.Name = "msUstawienieStyluLini";
            this.msUstawienieStyluLini.Size = new System.Drawing.Size(60, 20);
            this.msUstawienieStyluLini.Text = "Styl Lini";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "1";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "2";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem6.Text = "3";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem7.Text = "4";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "5";
            // 
            // msUstawienieGrubościLini
            // 
            this.msUstawienieGrubościLini.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem2});
            this.msUstawienieGrubościLini.Name = "msUstawienieGrubościLini";
            this.msUstawienieGrubościLini.Size = new System.Drawing.Size(85, 20);
            this.msUstawienieGrubościLini.Text = "Grubość Lini";
            // 
            // PrezentacjaLosowaZeSlajderem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbRysownica);
            this.Controls.Add(this.btResetuj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clbFigury);
            this.Controls.Add(this.gbManualnaKontrola);
            this.Controls.Add(this.gbPokaz);
            this.Controls.Add(this.gbPrzyciski);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrezentacjaLosowaZeSlajderem";
            this.Text = "Prezentacja Figur Geometrycznych";
            this.Load += new System.EventHandler(this.KreślenieFigur_Lini_Skupiński_Load);
            this.gbPrzyciski.ResumeLayout(false);
            this.gbPrzyciski.PerformLayout();
            this.gbPokaz.ResumeLayout(false);
            this.gbPokaz.PerformLayout();
            this.gbManualnaKontrola.ResumeLayout(false);
            this.gbManualnaKontrola.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPrzyciski;
        private System.Windows.Forms.Button btWyłączPokaz;
        private System.Windows.Forms.Button btWłączSlajd;
        private System.Windows.Forms.Button btInneFunkcjonalności;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btLosujAtrybuty;
        private System.Windows.Forms.Button btLosujPołożenieIAtrybuty;
        private System.Windows.Forms.Button btPrzesuń;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.GroupBox gbPokaz;
        private System.Windows.Forms.RadioButton rbManualny;
        private System.Windows.Forms.RadioButton rbAutomatyczny;
        private System.Windows.Forms.GroupBox gbManualnaKontrola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPodajLiczbęFigur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumerFigury;
        private System.Windows.Forms.Button btPoprzedni;
        private System.Windows.Forms.Button btNastępny;
        private System.Windows.Forms.CheckedListBox clbFigury;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.Button btResetuj;
        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.ToolStripMenuItem zapiszBitmapęToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajBitmapęToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem powrótToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjścieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msUstawienieKoloru;
        private System.Windows.Forms.ToolStripMenuItem wybierzKolorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawTłoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msUstawienieGrubościLini;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem msUstawienieStyluLini;
        private System.Windows.Forms.ToolStripMenuItem CiągłaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KreskowatoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kropkowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreskowoKropkowaToolStripMenuItem;
    }
}