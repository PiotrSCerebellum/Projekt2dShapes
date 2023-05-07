using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing.Imaging;
using static Projekt2_Skupiński59369.FiguryGeometryczne;
namespace Projekt2_Skupiński59369
{
    public partial class KreślenieFigur_Lini_Skupiński : Form
    {
        //deklaracje pomocnicze
        const int psMargines = 10;
        const int psMarginesFormularza = 20;
        //deklaracja powierzchni graficznej
        Graphics psRysownica;
        Graphics psRysownicaTymczasowa;
        
        Point Punkt;
        Pen psPióro;
        SolidBrush psPędzel;
        Pen psPióroTymczasowe;// dla wizualizacji rozciągania
        //deklaracje dla tworzenia listy kreślonych figur
        List<Punkt> psLFG = new List<Punkt>();//lista figur
        DashStyle Styl;
        Random rnd = new Random();

        public KreślenieFigur_Lini_Skupiński()
        {
            InitializeComponent();
            this.Location = new Point(Screen.PrimaryScreen.Bounds.X
                + psMargines, Screen.PrimaryScreen.Bounds.Y + psMargines);
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.9f);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.8f);
            this.StartPosition = FormStartPosition.Manual;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //pbRysownica.Width = (int)(this.Width*0.9f - (panel1.Width + 2 * psMargines));
            //pbRysownica.Height = (int)(this.Height*0.9f - (2 * psMargines));
            //pbRysownica.BackColor = Color.Azure;
            pbRysownica.BorderStyle = BorderStyle.FixedSingle;
            pbRysownica.Image = new Bitmap
                (pbRysownica.Width, pbRysownica.Height);
            psRysownica = Graphics.FromImage(pbRysownica.Image);
            psRysownicaTymczasowa = pbRysownica.CreateGraphics();
            Punkt = Point.Empty;
            psPióro = new Pen(Color.Black, 1F);
            psPióro.DashStyle = DashStyle.Solid;
            psPióro.StartCap = LineCap.Round;
            psPióro.EndCap = LineCap.Round;
            psPióroTymczasowe = new Pen(System.Drawing.Color.Blue, 1);
            psPędzel = new SolidBrush(Color.Blue);
        }





        private void pbRysownica_MouseDown(object sender, MouseEventArgs e)
        {
            //wypisanie współrzędnych XY
            lbPołożenie.Text = "X:  " + e.Location.X.ToString() +
                "Y:  " + e.Location.Y.ToString();
            //obsługa zdarzeń od naciśniętego lewego przycisku
            if (e.Button == MouseButtons.Left)
            {//zapamiętanie lokacji kliknięcia
                Punkt = e.Location;
            }
            if(rbLiniaCiągła.Checked)
            {
                psPióro.Color = txtKolorLinii.BackColor;
                psPióro.DashStyle = Styl;
                psPióro.Width = trbUstawGrubośćLinii.Value;
                psLFG.Add(new LiniaCiągła(Punkt, psPióro.Color, psPióro.DashStyle, (int)psPióro.Width));
            }


        }

        private void pbRysownica_MouseMove(object sender, MouseEventArgs e)
        {
            //wypisanie współrzędnych
            lbPołożenie.Text = "X:  " + e.Location.X.ToString() +
                "Y:  " + e.Location.Y.ToString();

            if (e.Button == MouseButtons.Left)
            { // wyświetlenie aktualnego położenia myszy
                lbPołożenie.Text = "X:  " + e.Location.X.ToString() +
            "Y:  " + e.Location.Y.ToString();
                /* deklaracje zmiennych pomocniczych i wyznaczenie parametrów 
                 opisujących prostokąt, w którym będzie wykreślana figura 
                 geometryczna */
                int LewyGórnyNarożnikX =
                    (Punkt.X > e.Location.X) ? e.Location.X : Punkt.X;
                int LewyGórnyNarożnikY =
                (Punkt.Y > e.Location.Y) ? e.Location.Y : Punkt.Y;
                int Szerokość = Math.Abs(Punkt.X - e.Location.X);
                int Wysokość = Math.Abs(Punkt.Y - e.Location.Y);
                if (rbPunkt.Checked)
                { }// punktu nie rozciągamy !!!
                if (rbLiniaProsta.Checked)
                // kreślenie linii na powierzchni tymczasowej 
                {
                    psRysownicaTymczasowa.DrawLine(psPióroTymczasowe, Punkt.X, Punkt.Y,
                                    e.Location.X, e.Location.Y);
                }
                if (rbElipsa.Checked)
                {
                    psRysownicaTymczasowa.DrawEllipse(psPióroTymczasowe,
                        new Rectangle(LewyGórnyNarożnikX, LewyGórnyNarożnikY,
                        Szerokość, Wysokość));
                }
                if (rbOkrąg.Checked)
                {
                    psRysownicaTymczasowa.DrawEllipse(psPióroTymczasowe,
                        new Rectangle(LewyGórnyNarożnikX, LewyGórnyNarożnikY,
                        Wysokość, Wysokość));
                }
                if (rbKoło.Checked)
                {
                    psRysownicaTymczasowa.DrawEllipse(psPióroTymczasowe,
                        new Rectangle(LewyGórnyNarożnikX, LewyGórnyNarożnikY,
                        Wysokość, Wysokość));
                }
                if (rbProstokąt.Checked)
                {
                    psRysownicaTymczasowa.DrawRectangle(psPióroTymczasowe, 
                        new Rectangle(LewyGórnyNarożnikX, LewyGórnyNarożnikY, Szerokość, Wysokość));
                }
                if (rbKwadrat.Checked)
                {
                    psRysownicaTymczasowa.DrawRectangle(psPióroTymczasowe,
                        new Rectangle(LewyGórnyNarożnikX, LewyGórnyNarożnikY, Szerokość, Szerokość));
                }
                if (rbLiniaCiągła.Checked)
                {
                    ((LiniaCiągła)psLFG[psLFG.Count - 1]).DodajNowyPunktLiniiCiągłej(e.Location);
                    psRysownicaTymczasowa.DrawLine(psPióro, Punkt, e.Location);
                    Punkt = e.Location;
                }
                if (rbFillRectangle.Checked)
                {
                    psRysownicaTymczasowa.DrawRectangle(psPióroTymczasowe, new Rectangle(LewyGórnyNarożnikX, LewyGórnyNarożnikY, Szerokość, Wysokość));
                }
                if (rbFillElipse.Checked)
                {
                    psRysownicaTymczasowa.DrawEllipse(psPióroTymczasowe, new Rectangle(LewyGórnyNarożnikX, LewyGórnyNarożnikY, Szerokość, Wysokość));
                }
                if (rbDrawPie.Checked|| rbFillPie.Checked)
                {
                    DrawPie Pie = (new DrawPie(Math.Abs(LewyGórnyNarożnikX - Szerokość / 6), Math.Abs(LewyGórnyNarożnikY - Wysokość / 6), Szerokość, Math.Min(Szerokość, 359), Math.Min(Wysokość, 359) - Math.Min(Szerokość, 359)));
                    Pie.UstalAtrybutyGraficzne(Color.Blue, DashStyle.Solid, 2);
                    Pie.Wykreśl(psRysownicaTymczasowa);
                }
                if (rbDrawArc.Checked)
                {

                    psLFG.Add(new DrawArc(Math.Abs(LewyGórnyNarożnikX - Szerokość / 6), Math.Abs(LewyGórnyNarożnikY - Wysokość / 6),
                        Szerokość, Math.Min(Szerokość, 359), Math.Min(Wysokość, 359) - Math.Min(Szerokość, 359)));
                    psLFG[psLFG.Count - 1].UstalAtrybutyGraficzne(Color.Blue, DashStyle.Solid, 2);
                    psLFG[psLFG.Count - 1].Wykreśl(psRysownicaTymczasowa);

                }
                if (rbLosowyWielokątForemny.Checked|| rbWielokątWyp.Checked)
                {
                    WielokątForemny Wielo=(new WielokątForemny(LewyGórnyNarożnikX, LewyGórnyNarożnikY, Szerokość));
                    Wielo.UstalAtrybutyGraficzne(Color.Blue, DashStyle.Solid, 2);
                    Wielo.Wykreśl(psRysownicaTymczasowa);
                }

                pbRysownica.Refresh();
            }
        }


        private void pbRysownica_MouseUp(object sender, MouseEventArgs e)
        {
            //wypisanie współrzędnych
            lbPołożenie.Text = "X:  " + e.Location.X.ToString() +
                "Y:  " + e.Location.Y.ToString();
            int LewyGórnyNarożnikX =
                (Punkt.X > e.Location.X) ? e.Location.X : Punkt.X;
            int LewyGórnyNarożnikY =
                (Punkt.Y > e.Location.Y) ? e.Location.Y : Punkt.Y;
            int Szerokość = Math.Abs(Punkt.X - e.Location.X);
            int Wysokość = Math.Abs(Punkt.Y - e.Location.Y);
            psPióro.Color = txtKolorLinii.BackColor;
            psPióro.DashStyle = Styl;
            psPióro.Width = trbUstawGrubośćLinii.Value;
            if (e.Button == MouseButtons.Left)
            {
                //rozpoznanie figury geometrycznej, utworzenie 
                //dla niej egemplarza i wykreślenie
                if (rbPunkt.Checked)
                {
                    //utworzenie egzemlrz i dodanie do lfg
                    psLFG.Add(new Punkt(Punkt.X, Punkt.Y));
                    //ustlenie atrybutów graficznych 
                    psLFG[psLFG.Count - 1].UstalAtrybutyGraficzne(psPióro.Color, psPióro.DashStyle, (int)psPióro.Width);
                    //wykreślenie
                    psLFG[psLFG.Count - 1].Wykreśl(psRysownica);

                }
                if (rbLiniaProsta.Checked)
                {
                    psLFG.Add(new Linia(Punkt.X, Punkt.Y, e.Location.X, e.Location.Y));
                    psLFG[psLFG.Count - 1].UstalAtrybutyGraficzne(psPióro.Color, psPióro.DashStyle, (int)psPióro.Width);
                    psLFG[psLFG.Count - 1].Wykreśl(psRysownica);
                }
                if (rbElipsa.Checked)
                {
                    psLFG.Add(new Elipsa(LewyGórnyNarożnikX, LewyGórnyNarożnikY, Szerokość, Wysokość));
                    psLFG[psLFG.Count - 1].UstalAtrybutyGraficzne(psPióro.Color, psPióro.DashStyle, (int)psPióro.Width);
                    psLFG[psLFG.Count - 1].Wykreśl(psRysownica);
                }
                if (rbOkrąg.Checked)
                {
                    psLFG.Add(new Okrąg(LewyGórnyNarożnikX, LewyGórnyNarożnikY, Szerokość));
                    psLFG[psLFG.Count - 1].UstalAtrybutyGraficzne(psPióro.Color, psPióro.DashStyle, (int)psPióro.Width);
                    psLFG[psLFG.Count - 1].Wykreśl(psRysownica);
                }
                if (rbKoło.Checked)
                {
                    psLFG.Add(new Koło(LewyGórnyNarożnikX, LewyGórnyNarożnikY, Szerokość));
                    psLFG[psLFG.Count - 1].UstalAtrybutyGraficzne(psPióro.Color, psPióro.DashStyle, (int)psPióro.Width);
                    psLFG[psLFG.Count - 1].Wykreśl(psRysownica);
                }
                if (rbKwadrat.Checked)
                {
                    psLFG.Add(new Kwadrat(LewyGórnyNarożnikX, LewyGórnyNarożnikY, Szerokość));
                    psLFG[psLFG.Count - 1].UstalAtrybutyGraficzne(psPióro.Color, psPióro.DashStyle, (int)psPióro.Width);
                    psLFG[psLFG.Count - 1].Wykreśl(psRysownica);
                }
                if (rbProstokąt.Checked)
                {
                    psLFG.Add(new Prostokąt(LewyGórnyNarożnikX, LewyGórnyNarożnikY, Szerokość, Wysokość));
                    psLFG[psLFG.Count - 1].UstalAtrybutyGraficzne(psPióro.Color, psPióro.DashStyle, (int)psPióro.Width);
                    psLFG[psLFG.Count - 1].Wykreśl(psRysownica);
                }
                if (rbLiniaCiągła.Checked)
                {
                    ((LiniaCiągła)psLFG[psLFG.Count - 1]).DodajNowyPunktLiniiCiągłej(e.Location);
                    psRysownica.DrawLine(psPióro, Punkt, e.Location);
                    psLFG[psLFG.Count - 1].Wykreśl(psRysownica);
                }
                if (rbFillElipse.Checked)
                {
                    psPędzel.Color = txtKolorWypełnienia.BackColor;
                    psLFG.Add(new FillElipse(LewyGórnyNarożnikX, LewyGórnyNarożnikY, Szerokość, Wysokość));
                    psLFG[psLFG.Count - 1].UstalKolorFill(psPędzel.Color);
                    psLFG[psLFG.Count - 1].Wykreśl(psRysownica);
                }
                if (rbFillRectangle.Checked)
                {
                    psPędzel.Color = txtKolorWypełnienia.BackColor;
                    psLFG.Add(new FillRectangle(LewyGórnyNarożnikX, LewyGórnyNarożnikY, Szerokość, Wysokość));
                    psLFG[psLFG.Count - 1].UstalKolorFill(psPędzel.Color);
                    psLFG[psLFG.Count - 1].Wykreśl(psRysownica);
                }
                if(rbDrawArc.Checked)
                {
                    
                        psLFG.Add(new DrawArc(Math.Abs(LewyGórnyNarożnikX - Szerokość / 6), Math.Abs(LewyGórnyNarożnikY - Wysokość / 6),
                            Szerokość, Math.Min(Szerokość, 359), Math.Min(Wysokość, 359) - Math.Min(Szerokość, 359)));
                        psLFG[psLFG.Count - 1].UstalAtrybutyGraficzne(psPióro.Color, psPióro.DashStyle, (int)psPióro.Width);
                        psLFG[psLFG.Count - 1].Wykreśl(psRysownica);
                    
                }
                if (rbDrawPie.Checked)
                {
                    psLFG.Add(new DrawPie(Math.Abs(LewyGórnyNarożnikX - Szerokość / 6), Math.Abs(LewyGórnyNarożnikY - Wysokość / 6),
                        Szerokość, Math.Min(Szerokość,359), Math.Min(Wysokość,359)-Math.Min(Szerokość, 359)));
                    psLFG[psLFG.Count - 1].UstalAtrybutyGraficzne(psPióro.Color, psPióro.DashStyle, (int)psPióro.Width);
                    psLFG[psLFG.Count - 1].Wykreśl(psRysownica);
                }
                if (rbFillPie.Checked)
                {
                    psPędzel.Color = txtKolorWypełnienia.BackColor;
                    psLFG.Add(new FillPie(Math.Abs(LewyGórnyNarożnikX - Szerokość / 6), Math.Abs(LewyGórnyNarożnikY - Wysokość / 6), Szerokość, Math.Min(Szerokość,359),Math.Min(Wysokość,359)-Math.Min(Szerokość, 359)));
                    psLFG[psLFG.Count - 1].UstalKolorFill(psPędzel.Color);
                    psLFG[psLFG.Count - 1].Wykreśl(psRysownica);
                }
                {//if (rbDrawArc.Checked)
                 //{
                 //    {
                 //        if (gbWybierzFigurę.Enabled)
                 //        {
                 //            psLFG.Add(new DrawArc(psRysownica, psPióro, Punkt));
                 //            gbWybierzFigurę.Enabled = false;
                 //            ((DrawArc)psLFG[psLFG.Count - 1]).LiczbaPunktówKontrolnych = 0;

                    //        }
                    //        else
                    //        {// dodanie nowego punktu kontrolnego
                    //            ((DrawArc)psLFG[psLFG.Count - 1]).DodajNowyPunktKontrolny(e.Location, psRysownica);
                    //            ((DrawArc)psLFG[psLFG.Count - 1]).LiczbaPunktówKontrolnych++;
                    //            if (((DrawArc)psLFG[psLFG.Count -
                    //                        1]).LiczbaPunktówKontrolnych == 3)
                    //            {
                    //                gbWybierzFigurę.Enabled = true;
                    //                psLFG[psLFG.Count - 1].Wykreśl(psRysownica);
                    //            }
                    //        }
                    //    }
                    //}
                }
                if (rbKrzywaKardynalna.Checked||rbClosedCurve.Checked)
                {
                    { 
                        if (gbWybierzFigurę.Enabled)
                        {
                            psLFG.Add(new KrzywaKardynalna(psRysownica, psPióro, Punkt));
                            gbWybierzFigurę.Enabled = false;
                            ((KrzywaKardynalna)psLFG[psLFG.Count - 1]).LiczbaPunktówKontrolnych = 0;

                        }
                        else
                        {// dodanie nowego punktu kontrolnego
                            ((KrzywaKardynalna)psLFG[psLFG.Count - 1]).DodajNowyPunktKontrolny(e.Location, psRysownica);
                            ((KrzywaKardynalna)psLFG[psLFG.Count - 1]).LiczbaPunktówKontrolnych++;
                            if (((KrzywaKardynalna)psLFG[psLFG.Count -
                                        1]).LiczbaPunktówKontrolnych == 5)
                            {
                                gbWybierzFigurę.Enabled = true;
                                psLFG[psLFG.Count - 1].Wykreśl(psRysownica);
                            }
                        }
                    }
                }
                if(rbFillClosedCurve.Checked)
                {
                    psPędzel.Color = txtKolorWypełnienia.BackColor;
                    {
                        {
                            if (gbWybierzFigurę.Enabled)
                            {
                                psLFG.Add(new FillClosedCurve(psRysownica, psPióro, Punkt));
                                gbWybierzFigurę.Enabled = false;
                                ((FillClosedCurve)psLFG[psLFG.Count - 1]).LiczbaPunktówKontrolnych = 0;
                            }
                            else
                            {// dodanie nowego punktu kontrolnego
                                ((FillClosedCurve)psLFG[psLFG.Count - 1]).DodajNowyPunktKontrolny(e.Location, psRysownica);
                                ((FillClosedCurve)psLFG[psLFG.Count - 1]).LiczbaPunktówKontrolnych++;
                                if (((FillClosedCurve)psLFG[psLFG.Count -
                                            1]).LiczbaPunktówKontrolnych == 4)
                                {
                                    gbWybierzFigurę.Enabled = true;
                                    psLFG[psLFG.Count - 1].UstalKolorFill(psPędzel.Color);
                                    psLFG[psLFG.Count - 1].Wykreśl(psRysownica);
                                }
                            }
                        }
                    }
                }
                if(rbLosowyWielokątForemny.Checked)
                {
                    psLFG.Add(new WielokątForemny(LewyGórnyNarożnikX, LewyGórnyNarożnikY, Szerokość));
                    psLFG[psLFG.Count - 1].UstalAtrybutyGraficzne(psPióro.Color, psPióro.DashStyle, (int)psPióro.Width);
                    psLFG[psLFG.Count - 1].Wykreśl(psRysownica);
                }
                if(rbWielokątWyp.Checked)
                {
                    psPędzel.Color = txtKolorWypełnienia.BackColor;
                    psLFG.Add(new WielokątForemnyWypełniony(LewyGórnyNarożnikX, LewyGórnyNarożnikY, Szerokość));
                    psLFG[psLFG.Count - 1].UstalKolorFill(psPędzel.Color);
                    psLFG[psLFG.Count - 1].Wykreśl(psRysownica);
                }

                if (rbKrzywaBeziera.Checked)
                {// sprawdzenie, czy to jest pierwszy punkt kontrolny: PO 
                    if (gbWybierzFigurę.Enabled)
                    {// to jest pierwszy punkt: PO
                     // utworzenie egzemplarza klasy KrzywaBeziera i dodanie go
                     //do psLFG
                        psLFG.Add(new KrzywaBeziera(psRysownica, psPióro, Punkt));
                        // Punkt = e.Location
                        /* ustawienie stanu braku aktywności dla kontenera z
                           kontrolkami RadioButton, które sq przypisane różnym 
                           figurom geometrycznym */
                        gbWybierzFigurę.Enabled = false;
                        /* przypisanie wartości 0 (stan początkowy) właściwości 
                           LiczbaPunktówKontrolnych, która jest zadeklarowana w klasie 
                           KrzywaBeziera */
                        ((KrzywaBeziera)psLFG[psLFG.Count - 1]).LiczbaPunktówKontrolnych = 0;

                    }
                    else
                    {// dodanie nowego punktu kontrolnego

                        ((KrzywaBeziera)psLFG[psLFG.Count - 1]).DodajNowyPunktKontrolny(e.Location, psRysownica);
                        ((KrzywaBeziera)psLFG[psLFG.Count - 1]).LiczbaPunktówKontrolnych++;
                        // sprawdzenie, czy jest to już punkt ostatni: P3 
                        if (((KrzywaBeziera)psLFG[psLFG.Count -
                                    1]).LiczbaPunktówKontrolnych == 3)
                        {/* ustawienie stanu aktywności dla kontenera z
                                kontrolkami RadioButton, które sa przypisane różnym figurom geometrycznym */
                            gbWybierzFigurę.Enabled = true;
                            // wykreślenie Krzywej Beziera
                            psLFG[psLFG.Count - 1].Wykreśl(psRysownica);
                        }
                    }
                }
                pbRysownica.Refresh();
            }
        }

        private void rbPunkt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void plikToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wybierzKolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog psKolorLinii = new ColorDialog();
            psKolorLinii.Color = psPióro.Color;
            if (psKolorLinii.ShowDialog() == DialogResult.OK)
            {
                txtKolorLinii.BackColor = psKolorLinii.Color;
                psPióro.Color = psKolorLinii.Color;
            }
            psKolorLinii.Dispose();
        }

        private void ustawTłoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog psKolorWypełnienia = new ColorDialog();
            psKolorWypełnienia.Color = psPióro.Color;
            if (psKolorWypełnienia.ShowDialog() == DialogResult.OK)
            {
                txtKolorWypełnienia.BackColor = psKolorWypełnienia.Color;
                psPędzel.Color = psKolorWypełnienia.Color;
            }
            psKolorWypełnienia.Dispose();
        }

        private void btnKolorLinii_Click(object sender, EventArgs e)
        {
            ColorDialog psKolorLinii = new ColorDialog();
            psKolorLinii.Color = psPióro.Color;
            if (psKolorLinii.ShowDialog() == DialogResult.OK)
            {
                txtKolorLinii.BackColor = psKolorLinii.Color;
                psPióro.Color = psKolorLinii.Color;
            }
            psKolorLinii.Dispose();
        }

        private void btnKolorWypełnienia_Click(object sender, EventArgs e)
        {
            ColorDialog psKolorWypełnienia = new ColorDialog();
            psKolorWypełnienia.Color = psPióro.Color;
            if (psKolorWypełnienia.ShowDialog() == DialogResult.OK)
            {
                txtKolorWypełnienia.BackColor = psKolorWypełnienia.Color;
                psPędzel.Color = psKolorWypełnienia.Color;
            }
            psKolorWypełnienia.Dispose();
        }

        private void cbWybierzStylLinii_SelectedIndexChanged(object sender, EventArgs e)
        {

            {
                switch (cbWybierzStylLinii.SelectedIndex)
                {
                    case 0:
                        {
                            Styl = DashStyle.Solid;
                            break;
                        }
                    case 1:
                        {
                            Styl = DashStyle.Dash;
                            break;
                        }
                    case 2:
                        {
                            Styl = DashStyle.Dot;
                            break;
                        }
                    case 3:
                        {
                            Styl = DashStyle.DashDot;
                            break;
                        }
                    case 4:
                        {
                            Styl = DashStyle.DashDotDot;
                            break;
                        }
                    default:
                        {
                            Styl = DashStyle.Solid;
                            break;
                        }
                }
            }

        }

        private void rbWielokątForemny_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btWłączPokazKreślenie_Click(object sender, EventArgs e)
        {
            if (psLFG.Count == 0)
                return;
            rbManualny.Enabled = true;
            rbAutomatyczny.Enabled = true;
            gbWybierzFigurę.Enabled = false;
            btWyłączPokaz.Enabled = true;
            int psIndeksFigury = 0;
            errorProvider1.Dispose();
            psRysownica.Clear(pbRysownica.BackColor);
            if (rbAutomatyczny.Checked)
            {
                timer1.Tag = psIndeksFigury;
                timer1.Enabled = true;
            }
            else
            {
                if (string.IsNullOrEmpty(tbNumerFigury.Text.Trim()))
                {
                    tbNumerFigury.Text = psIndeksFigury.ToString();
                }
                else if (!int.TryParse(tbNumerFigury.Text, out psIndeksFigury))
                {
                    errorProvider1.SetError(tbNumerFigury, "ERROR: W zapisie numeru figury do prezentacji wystąpił niedozwolony znak");
                    return;
                }
                if (psIndeksFigury < 0 || psIndeksFigury >= psLFG.Count)
                {
                    errorProvider1.SetError(tbNumerFigury, "ERROR: Nie ma figury geometrycznej o takim numerze");
                    return;
                }
                rbAutomatyczny.Enabled = true;
                rbManualny.Enabled = true;
                int psXmax = pbRysownica.Width;
                int psYmax = pbRysownica.Height;
                psLFG[psIndeksFigury].PrzesuńDoNowegoXY(pbRysownica, psRysownica, psXmax / 2, psYmax / 2);
            }
            pbRysownica.Refresh();
            btWłączSlajd.Enabled = false;
            btWyłączPokaz.Enabled = true;

        }
        private void btWyłączPokazFigurK_Click(object sender, EventArgs e)
        {
            pbRysownica.BackColor = Color.Beige;
            psRysownica.Clear(pbRysownica.BackColor);
            gbWybierzFigurę.Enabled = true;
            btWłączSlajd.Enabled = true;
            pbRysownica.Refresh();
            timer1.Enabled = false;
            btNastępny.Enabled = false;
            btPoprzedni.Enabled = false;
            tbNumerFigury.Enabled = false;
            btWyłączPokaz.Enabled = false;
            rbAutomatyczny.Checked = true;
            rbAutomatyczny.Enabled = false;
            rbManualny.Enabled = false;

            psRysownica.Clear(pbRysownica.BackColor);
            psLFG.Clear();

        }

        private void btPoprzedniK_Click(object sender, EventArgs e)
        {
            int psIndeksFigury;
            errorProvider1.Dispose();
            if (!int.TryParse(tbNumerFigury.Text, out psIndeksFigury))
            {
                errorProvider1.SetError(tbNumerFigury, "ERROR: W zapisanym numerze indeksu figury wystąpił niedozwolony znak");
                return;
            }
            if (psIndeksFigury < 0 || psIndeksFigury >= psLFG.Count)
            {
                errorProvider1.SetError(tbNumerFigury, "ERROR: Indeks podanej figury wykracza poza dozwolony zakres");
                return;
            }
            psRysownica.Clear(pbRysownica.BackColor);

            if (psIndeksFigury > 0)
            {
                int psXmax = pbRysownica.Width;
                int psYmax = pbRysownica.Height;
                psLFG[psIndeksFigury].PrzesuńDoNowegoXY(pbRysownica, psRysownica, psXmax / 2, psYmax / 2);
                pbRysownica.Refresh();
                psIndeksFigury--;

            }
            else
            {
                psIndeksFigury = psLFG.Count - 1;
                int psXmax = pbRysownica.Width;
                int psYmax = pbRysownica.Height;
                psLFG[psIndeksFigury].PrzesuńDoNowegoXY(pbRysownica, psRysownica, psXmax / 2, psYmax / 2);
                pbRysownica.Refresh();
            }
            tbNumerFigury.Text = psIndeksFigury.ToString();
        }

        private void btNastępnyK_Click(object sender, EventArgs e)
        {
            int psIndeksFigury;
            int psXmax = pbRysownica.Width;
            int psYmax = pbRysownica.Height;
            errorProvider1.Dispose();
            if (!int.TryParse(tbNumerFigury.Text, out psIndeksFigury))
            {
                errorProvider1.SetError(tbNumerFigury, "ERROR: W zapisie indeksu figury do prezentacji wystąpił niedozwolony znak");
                return;
            }

            if (psIndeksFigury < 0 || psIndeksFigury > psLFG.Count)
            {
                errorProvider1.SetError(tbNumerFigury, "ERROR: Do pola TextBox został wpisany nieodpowiedni indeks figury do prezentacji");
                return;
            }


            if (psIndeksFigury < psLFG.Count)
            {


                psRysownica.Clear(pbRysownica.BackColor);
                psLFG[psIndeksFigury].PrzesuńDoNowegoXY(pbRysownica, psRysownica, psXmax / 2, psYmax / 2);
                psIndeksFigury++;


            }
            else
            {
                psIndeksFigury = 0;
                psRysownica.Clear(pbRysownica.BackColor);
                psLFG[psIndeksFigury].PrzesuńDoNowegoXY(pbRysownica, psRysownica, psXmax / 2, psYmax / 2);

            }
            tbNumerFigury.Text = psIndeksFigury.ToString();
            pbRysownica.Refresh();
        }

        private void rbAutomatyczny_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAutomatyczny.Checked)
            {
                btPoprzedni.Enabled = false;
                btNastępny.Enabled = false;
            }
        }
        private void rbManualnyKreślenie_CheckedChanged(object sender, EventArgs e)
        {
            if (rbManualny.Checked)
            {
                btPoprzedni.Enabled = true;
                btNastępny.Enabled = true;
                timer1.Enabled = false;
                tbNumerFigury.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            psRysownica.Clear(pbRysownica.BackColor);
            int psXmax = pbRysownica.Width;
            int psYmax = pbRysownica.Height;
            tbNumerFigury.Text = timer1.Tag.ToString();
            psLFG[(int)timer1.Tag].PrzesuńDoNowegoXY(pbRysownica, psRysownica, psXmax / 2, psYmax / 2);
            pbRysownica.Refresh();
            timer1.Tag = ((int)timer1.Tag + 1) % psLFG.Count;
        }

        private void zapiszBitmapęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btPrzesuń_Click(object sender, EventArgs e)
        {
            psRysownica.Clear(pbRysownica.BackColor);
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            int X, Y;
            Random rnd = new Random();
            for (int i=0;i<psLFG.Count;i++)
            {
                X = rnd.Next(psMargines, Xmax - psMargines);
                Y = rnd.Next(psMargines, Ymax - psMargines);
                psLFG[i].PrzesuńDoNowegoXY(pbRysownica, psRysownica, X, Y);
                //psLFG[i].UaktualnijXY(X, Y);
                //psLFG[i].Wykreśl(psRysownica);
            }pbRysownica.Refresh();

        }

        private void btCofnij_Click(object sender, EventArgs e)
        {
            if(psLFG.Count<=0)
            {
                errorProvider1.SetError(btCofnij, "Błąd: Lista figur jest pusta");
                    return; 
            }
            psLFG.RemoveAt(psLFG.Count - 1);
            psRysownica.Clear(pbRysownica.BackColor);
            for (int i = 0; i < psLFG.Count; i++)
                psLFG[i].Wykreśl(psRysownica);
            pbRysownica.Refresh();
            errorProvider1.Dispose();

            }

        private void powrótToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var prezentacja = new FormFiguryGeoInitial();
            prezentacja.Location = this.Location;
            prezentacja.StartPosition = FormStartPosition.Manual;
            prezentacja.Show();
            this.Hide();
        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wybierzKolorTłaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog psKolorTła = new ColorDialog();
            psKolorTła.Color = pbRysownica.BackColor;
            if (psKolorTła.ShowDialog() == DialogResult.OK)
            {
                pbRysownica.BackColor = psKolorTła.Color;
            }
            psRysownica.Clear(pbRysownica.BackColor);
            for (int i = 0; i < psLFG.Count; i++)
            {
                psLFG[i].Wykreśl(psRysownica);
            }
            pbRysownica.Refresh();
        }
    }
}
