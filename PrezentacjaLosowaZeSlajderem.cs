using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static Projekt2_Skupiński59369.FiguryGeometryczne;

namespace Projekt2_Skupiński59369
{
    public partial class PrezentacjaLosowaZeSlajderem : Form
    {
        Graphics psRysownica;
        Punkt[] psTFG;
        int psIndexTFG;
        const int psMarginesFormularza = 20;
        const int psMargines = 10;
        Random rnd = new Random();





        public PrezentacjaLosowaZeSlajderem()
        {
            InitializeComponent();
            this.Location = new Point(Screen.PrimaryScreen.Bounds.X
                + psMargines, Screen.PrimaryScreen.Bounds.Y + psMargines);
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.9f);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.8f);
            this.StartPosition = FormStartPosition.Manual;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            {//gbPrzyciski.Location = new Point(Left + psMarginesFormularza,
            //    Top + psMarginesFormularza);
            //gbPokaz.Location = new Point(gbPrzyciski.Width + psMarginesFormularza, Bottom-gbPokaz.Height- psMarginesFormularza);
            //gbManualnaKontrola.Location = new Point(gbPokaz.Location.X + gbPokaz.Width + psMargines,
            //    gbPokaz.Location.Y);
            //btResetuj.Location = new Point(gbManualnaKontrola.Location.X + gbManualnaKontrola.Width + psMargines,
            //    gbPokaz.Location.Y-psMargines);
            //label3.Location = new Point(Right-label3.Width - psMarginesFormularza, Top + psMargines);
            //clbFigury.Location = new Point(Right -(clbFigury.Width + psMarginesFormularza), label3.Location.Y + psMargines);
            //pbRysownica.Location = new Point(gbPrzyciski.Location.X + gbPrzyciski.Width + psMargines,
            //    Top + psMarginesFormularza);
                }
            pbRysownica.BorderStyle = BorderStyle.FixedSingle;

            pbRysownica.Image = new Bitmap(pbRysownica.Width, pbRysownica.Height);
            psRysownica = Graphics.FromImage(pbRysownica.Image);

                
        }

        private void KreślenieFigur_Lini_Skupiński_Load(object sender, EventArgs e)
        {

        }

        private void btResetuj_Click_1(object sender, EventArgs e)
        {
            pbRysownica.BackColor = Color.Beige;
            psRysownica.Clear(pbRysownica.BackColor);
            pbRysownica.Refresh();
            tbPodajLiczbęFigur.Enabled = true;
            btStart.Enabled = true;
            btWyłączPokaz.Enabled = false;
            btWyłączPokaz.Enabled = false;
            rbAutomatyczny.Enabled = false;
            rbManualny.Enabled = false;
            btPrzesuń.Enabled = false;
            btLosujPołożenieIAtrybuty.Enabled = false;
            btLosujAtrybuty.Enabled = false;
            btStop.Enabled = false;
        }
        private void btStart_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ushort psLiczbaFG;
            errorProvider1.Dispose();
            if (string.IsNullOrEmpty(tbPodajLiczbęFigur.Text.Trim()))
            {
                errorProvider1.SetError(tbPodajLiczbęFigur, "ERROR: Wystąpił niedozwolony znak w zapisie liczby figur geometrycznych");
                return;
            }
            if (!ushort.TryParse(tbPodajLiczbęFigur.Text, out psLiczbaFG))
            {
                errorProvider1.SetError(tbPodajLiczbęFigur, "ERROR: Wystąpił niedozwolony znak w zapisie liczby figur geometrycznych");
                return;
            }
            psTFG = new Punkt[psLiczbaFG];
            psIndexTFG = 0;
            if (clbFigury.CheckedItems.Count <= 0)
            {
                errorProvider1.SetError(clbFigury, "ERROR: Musisz wybrać co najmniej jedną figurę geometryczną");
                return;
            }
            CheckedListBox.CheckedItemCollection psWybraneFigury = clbFigury.CheckedItems;
            int psXmax = pbRysownica.Width;
            int psYmax = pbRysownica.Height;
            int psX, psY;
            int psXk, psYk;
            int psOśDuża, psOśMała;
            int psPromień, psSzerokość, psWysokość;
            Color psKolorLinii;
            Color psKolorWypełnienia;
            int psGrubośćLinii;
            DashStyle psStylLinii;
            int psRozmiarPunktu;
            for (int i = 0; i < psLiczbaFG; i++)
            {
                psX = rnd.Next(psMargines, psXmax - psMargines);
                psY = rnd.Next(psMargines, psYmax - psMargines);
                psKolorLinii = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                psKolorWypełnienia = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));

                switch (rnd.Next(1, 6))
                {
                    case 1:
                        {
                            psStylLinii = DashStyle.Dash;
                            break;
                        }
                    case 2:
                        {
                            psStylLinii = DashStyle.DashDot;
                            break;
                        }
                    case 3:
                        {
                            psStylLinii = DashStyle.DashDotDot;
                            break;
                        }
                    case 4:
                        {
                            psStylLinii = DashStyle.Dot;
                            break;
                        }
                    case 5:
                        {
                            psStylLinii = DashStyle.Solid;
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Przepraszam ale nie znam takiego stylu linii");
                            psStylLinii = DashStyle.Solid;
                            break;
                        }
                }
                psGrubośćLinii = rnd.Next(1, psMargines);
                int psWybranyIndeksFigury = rnd.Next(psWybraneFigury.Count);
                switch (psWybraneFigury[psWybranyIndeksFigury].ToString())
                {
                    case "Punkt":
                        {
                            psTFG[psIndexTFG] = new Punkt(psX, psY);
                            psRozmiarPunktu = rnd.Next(3, psMargines);
                            psTFG[psIndexTFG].UstalAtrybutyGraficzne
                                (psKolorWypełnienia, psStylLinii, psRozmiarPunktu);
                            psTFG[psIndexTFG].Wykreśl(psRysownica);
                            psIndexTFG++;
                            break;
                        }
                    case "Linia":
                        {
                            psXk = rnd.Next(psMargines, psXmax - psMargines);
                            psYk = rnd.Next(psMargines, psYmax - psMargines);
                            psTFG[psIndexTFG] = new Linia(psX, psY, psXk, psYk);
                            psTFG[psIndexTFG].UstalAtrybutyGraficzne
                                (psKolorLinii, psStylLinii, psGrubośćLinii);
                            psTFG[psIndexTFG].Wykreśl(psRysownica);
                            psIndexTFG++;
                            break;
                        }
                    case "Elipsa":
                        {
                            psOśDuża = rnd.Next(psMargines, psXmax / 4 - psMargines);
                            psOśMała = rnd.Next(psMargines, psYmax / 4 - psMargines);
                            psTFG[psIndexTFG] = new Elipsa(psX, psY, psOśDuża, psOśMała);
                            psTFG[psIndexTFG].UstalAtrybutyGraficzne
                                (psKolorLinii, psStylLinii, psGrubośćLinii);
                            psTFG[psIndexTFG].Wykreśl(psRysownica);
                            psIndexTFG++;
                            break;
                        }
                    case "Okrąg":
                        {
                            psPromień = rnd.Next(psMargines, psYmax / 4);
                            psTFG[psIndexTFG] = new Okrąg(psX, psY, psPromień);
                            psTFG[psIndexTFG].UstalAtrybutyGraficzne
                                (psKolorLinii, psStylLinii, psGrubośćLinii);
                            psTFG[psIndexTFG].Wykreśl(psRysownica);
                            psIndexTFG++;
                            break;
                        }
                    case "Kwadrat":
                        {
                            psSzerokość = rnd.Next(psMargines, psXmax - psMargines);
                            psTFG[psIndexTFG] = new Prostokąt
                                (psX / 2, psY / 4, psSzerokość / 4, psSzerokość / 4);
                            psTFG[psIndexTFG].UstalAtrybutyGraficzne
                                (psKolorLinii, psStylLinii, psGrubośćLinii);
                            psTFG[psIndexTFG].Wykreśl(psRysownica);
                            psIndexTFG++;
                            break;
                        }
                    case "Prostokąt":
                        {
                            psSzerokość = rnd.Next(psMargines, psXmax - psMargines);
                            psWysokość = rnd.Next(psMargines, psXmax - psMargines);
                            psTFG[psIndexTFG] = new Prostokąt
                                (psX, psY, psSzerokość / 4, psWysokość / 4);
                            psTFG[psIndexTFG].UstalAtrybutyGraficzne
                                (psKolorLinii, psStylLinii, psGrubośćLinii);
                            psTFG[psIndexTFG].Wykreśl(psRysownica);
                            psIndexTFG++;
                            break;
                        }
                    case "Wielokąt foremny":
                        {
                            psSzerokość = rnd.Next(psMargines, psXmax - psMargines);
                            psWysokość = rnd.Next(psMargines, psXmax - psMargines);
                            psTFG[psIndexTFG] = new WielokątForemny
                                (psX, psY, psSzerokość / 4);
                            psTFG[psIndexTFG].UstalAtrybutyGraficzne
                                (psKolorLinii, psStylLinii, psGrubośćLinii);
                            psTFG[psIndexTFG].Wykreśl(psRysownica);
                            psIndexTFG++;
                            break;
                        }
                    case "Koło":
                        {
                            psPromień = rnd.Next(psMargines, psYmax / 4);
                            psTFG[psIndexTFG] = new Koło(psX, psY, psPromień);
                            psTFG[psIndexTFG].UstalAtrybutyGraficzne
                                (psKolorLinii, psStylLinii, psGrubośćLinii);
                            psTFG[psIndexTFG].Wykreśl(psRysownica);
                            psIndexTFG++;
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Wylosowana figura: " +
                                (string)clbFigury.CheckedItems[psIndexTFG] +
                                " nie jest jescze wykreślona");
                            break;
                        }
                }
                pbRysownica.Refresh();
                tbPodajLiczbęFigur.Enabled = false;
                btStart.Enabled = false;
                btPrzesuń.Enabled = true;
                btLosujPołożenieIAtrybuty.Enabled = true;
                btLosujAtrybuty.Enabled = true;
                btStop.Enabled = true;
                msUstawienieKoloru.Enabled = true;
                msUstawienieGrubościLini.Enabled = true;
                msUstawienieStyluLini.Enabled = true;
            }
        }

        private void btStop_Click_1(object sender, EventArgs e)
        {

            psRysownica.Clear(pbRysownica.BackColor);
            pbRysownica.Refresh();
            btPrzesuń.Enabled = false;
            btLosujPołożenieIAtrybuty.Enabled = false;
            btLosujAtrybuty.Enabled = false;
            btWłączSlajd.Enabled = true;
            btStop.Enabled = false;
        }
        private void btPrzesuń_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int psXmax = pbRysownica.Width;
            int psYmax = pbRysownica.Height;
            int psXp, psYp;
            psRysownica.Clear(pbRysownica.BackColor);
            for (int i = 0; i < psTFG.Length; i++)
            {
                psXp = rnd.Next(psMargines, psXmax - psMargines);
                psYp = rnd.Next(psMargines, psYmax - psMargines);
                psTFG[i].PrzesuńDoNowegoXY(pbRysownica, psRysownica, psXp, psYp);
            }
            pbRysownica.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            psRysownica.Clear(pbRysownica.BackColor);
            int psXmax = pbRysownica.Width;
            int psYmax = pbRysownica.Height;
            tbNumerFigury.Text = timer1.Tag.ToString();
            psTFG[(int)timer1.Tag].PrzesuńDoNowegoXY(pbRysownica, psRysownica, psXmax / 2, psYmax / 2);
            pbRysownica.Refresh();
            timer1.Tag = ((int)timer1.Tag + 1) % psTFG.Length;
        }
        private void btLosujPołożenieIAtrybuty_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int psXp, psYp;
            Color psKolorLinii, psKolorWypełnienia;
            int psGrubośćLinii, psRozmiarPunktu;
            DashStyle psStylLinii;
            int psXmax = pbRysownica.Width;
            int psYmax = pbRysownica.Height;
            psRysownica.Clear(pbRysownica.BackColor);
            for (int i = 0; i < psTFG.Length; i++)
            {
                psKolorLinii = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                psKolorWypełnienia = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                switch (rnd.Next(0, 4))
                {
                    case 0:
                        {
                            psStylLinii = DashStyle.Solid;
                            break;
                        }
                    case 1:
                        {
                            psStylLinii = DashStyle.Dash;
                            break;
                        }
                    case 2:
                        {
                            psStylLinii = DashStyle.Dot;
                            break;
                        }
                    case 3:
                        {
                            psStylLinii = DashStyle.DashDot;
                            break;
                        }
                    case 4:
                        {
                            psStylLinii = DashStyle.DashDotDot;
                            break;
                        }
                    default:
                        {
                            psStylLinii = DashStyle.Solid;
                            break;
                        }
                }
                psGrubośćLinii = rnd.Next(1, 10);
                psRozmiarPunktu = rnd.Next(3, 10);
                psXp = rnd.Next(psMargines, psXmax - psMargines);
                psYp = rnd.Next(psMargines, psYmax - psMargines);
                psTFG[i].UstalAtrybutyGraficzne(psKolorLinii, psStylLinii, psGrubośćLinii);
                psTFG[i].UstalAtrybutyGraficzne(psKolorLinii, psStylLinii, psRozmiarPunktu);
                psTFG[i].PrzesuńDoNowegoXY(pbRysownica, psRysownica, psXp, psYp);
            }
            pbRysownica.Refresh();
        }

        private void btLosujAtrybuty_Click_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Color psKolorLinii, psKolorWypełnienia;
            int psGrubośćLinii, psRozmiarPunktu;
            DashStyle psStylLinii;
            psRysownica.Clear(pbRysownica.BackColor);
            for (int i = 0; i < psTFG.Length; i++)
            {
                psKolorLinii = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                psKolorWypełnienia = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                switch (rnd.Next(0, 4))
                {
                    case 0:
                        {
                            psStylLinii = DashStyle.Solid;
                            break;
                        }
                    case 1:
                        {
                            psStylLinii = DashStyle.Dash;
                            break;
                        }
                    case 2:
                        {
                            psStylLinii = DashStyle.Dot;
                            break;
                        }
                    case 3:
                        {
                            psStylLinii = DashStyle.DashDot;
                            break;
                        }
                    case 4:
                        {
                            psStylLinii = DashStyle.DashDotDot;
                            break;
                        }
                    default:
                        {
                            psStylLinii = DashStyle.Solid;
                            break;
                        }
                }
                psGrubośćLinii = rnd.Next(1, 10);
                psRozmiarPunktu = rnd.Next(3, 10);
                psTFG[i].UstalAtrybutyGraficzne(psKolorLinii, psStylLinii, psGrubośćLinii);
                psTFG[i].UstalAtrybutyGraficzne(psKolorLinii, psStylLinii, psRozmiarPunktu);
                psTFG[i].Wykreśl(psRysownica);
            }
            pbRysownica.Refresh();
        }

        private void btWłączSlajd_Click_1(object sender, EventArgs e)
        {
            rbManualny.Enabled = true;
            rbAutomatyczny.Enabled = true;
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
                if (psIndeksFigury < 0 || psIndeksFigury >= psTFG.Length)
                {
                    errorProvider1.SetError(tbNumerFigury, "ERROR: Nie ma figury geometrycznej o takim numerze");
                    return;
                }
                rbAutomatyczny.Enabled = true;
                rbManualny.Enabled = true;
                int psXmax = pbRysownica.Width;
                int psYmax = pbRysownica.Height;
                psTFG[psIndeksFigury].PrzesuńDoNowegoXY(pbRysownica, psRysownica, psXmax / 2, psYmax / 2);
            }
            pbRysownica.Refresh();
            btWłączSlajd.Enabled = false;
            btWyłączPokaz.Enabled = true;

        }
        private void btNastępny_Click_1(object sender, EventArgs e)
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
            
            if (psIndeksFigury < 0 || psIndeksFigury > psTFG.Length)
            {
                errorProvider1.SetError(tbNumerFigury, "ERROR: Do pola TextBox został wpisany nieodpowiedni indeks figury do prezentacji");
                return;
            }

            
            if (psIndeksFigury < psTFG.Length)
            {

                
                    psRysownica.Clear(pbRysownica.BackColor);
                    psTFG[psIndeksFigury].PrzesuńDoNowegoXY(pbRysownica, psRysownica, psXmax / 2, psYmax / 2);
                    psIndeksFigury++;
                

            }
            else
            {
                psIndeksFigury = 0;
                psRysownica.Clear(pbRysownica.BackColor);
                psTFG[psIndeksFigury].PrzesuńDoNowegoXY(pbRysownica, psRysownica, psXmax / 2, psYmax / 2);
                
            }
            tbNumerFigury.Text = psIndeksFigury.ToString();
            pbRysownica.Refresh();
        }

        private void btPoprzedni_Click_1(object sender, EventArgs e)
        {
            int psIndeksFigury;
            errorProvider1.Dispose();
            if (!int.TryParse(tbNumerFigury.Text, out psIndeksFigury))
            {
                errorProvider1.SetError(tbNumerFigury, "ERROR: W zapisanym numerze indeksu figury wystąpił niedozwolony znak");
                return;
            }
            if (psIndeksFigury < 0 || psIndeksFigury >= psTFG.Length)
            {
                errorProvider1.SetError(tbNumerFigury, "ERROR: Indeks podanej figury wykracza poza dozwolony zakres");
                return;
            }
            psRysownica.Clear(pbRysownica.BackColor);
            
            if (psIndeksFigury > 0)
            {
                int psXmax = pbRysownica.Width;
                int psYmax = pbRysownica.Height;
                psTFG[psIndeksFigury].PrzesuńDoNowegoXY(pbRysownica, psRysownica, psXmax / 2, psYmax / 2);
                pbRysownica.Refresh();
                psIndeksFigury--;
                
            }
            else
            {
                psIndeksFigury = psTFG.Length - 1;
                int psXmax = pbRysownica.Width;
                int psYmax = pbRysownica.Height;
                psTFG[psIndeksFigury].PrzesuńDoNowegoXY(pbRysownica, psRysownica, psXmax / 2, psYmax / 2);
                pbRysownica.Refresh();
            }
            tbNumerFigury.Text = psIndeksFigury.ToString();
        }
        private void btWyłączPokaz_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btNastępny.Enabled = false;
            btPoprzedni.Enabled = false;
            tbNumerFigury.Enabled = false;
            btWyłączPokaz.Enabled = false;
            rbAutomatyczny.Checked = true;
            rbAutomatyczny.Enabled = false;
            rbManualny.Enabled = false;
            Random rnd = new Random();
            int psXmax = pbRysownica.Width;
            int psYmax = pbRysownica.Height;
            int psX, psY;
            psRysownica.Clear(pbRysownica.BackColor);

        }

        private void wybierzKolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog psKolorLinii = new ColorDialog();
            if (psKolorLinii.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < psTFG.Length; i++)
                {
                    psTFG[i].UstalKolorLinii(psKolorLinii.Color);
                    psTFG[i].Wykreśl(psRysownica);
                }
            }
            pbRysownica.Refresh();
        }

        private void ustawTłoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog psKolorTła = new ColorDialog();
            psKolorTła.Color = pbRysownica.BackColor;
            if (psKolorTła.ShowDialog() == DialogResult.OK)
            {
                pbRysownica.BackColor = psKolorTła.Color;
            }
            psRysownica.Clear(pbRysownica.BackColor);
            for (int i = 0; i < psTFG.Length; i++)
            {
                psTFG[i].Wykreśl(psRysownica);
            }
            pbRysownica.Refresh();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int psGrubośćLini = 1;

            for (int i = 0; i < psTFG.Length; i++)
            {
                psTFG[i].UstalGrubośćLinii(psGrubośćLini);
                psTFG[i].Wykreśl(psRysownica);
            }
            pbRysownica.Refresh();
            psRysownica.Clear(pbRysownica.BackColor);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            int psGrubośćLini = 3;

            for (int i = 0; i < psTFG.Length; i++)
            {
                psTFG[i].UstalGrubośćLinii(psGrubośćLini);
                psTFG[i].Wykreśl(psRysownica);
            }
            pbRysownica.Refresh();
            psRysownica.Clear(pbRysownica.BackColor);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            int psGrubośćLini = 6;

            for (int i = 0; i < psTFG.Length; i++)
            {
                psTFG[i].UstalGrubośćLinii(psGrubośćLini);
                psTFG[i].Wykreśl(psRysownica);
            }
            pbRysownica.Refresh();
            psRysownica.Clear(pbRysownica.BackColor);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            int psGrubośćLini = 10;

            for (int i = 0; i < psTFG.Length; i++)
            {
                psTFG[i].UstalGrubośćLinii(psGrubośćLini);
                psTFG[i].Wykreśl(psRysownica);
            }
            pbRysownica.Refresh();
            psRysownica.Clear(pbRysownica.BackColor);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            int psGrubośćLini = 15;

            for (int i = 0; i < psTFG.Length; i++)
            {
                psTFG[i].UstalGrubośćLinii(psGrubośćLini);
                psTFG[i].Wykreśl(psRysownica);
            }
            pbRysownica.Refresh();
            psRysownica.Clear(pbRysownica.BackColor);
        }

        private void CiągłaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashStyle psStylLinii;
            psStylLinii = DashStyle.Solid;
            for (int i = 0; i < psTFG.Length; i++)
            {
                psTFG[i].UstalStylLinii(psStylLinii);
                psTFG[i].Wykreśl(psRysownica);
            }
            pbRysownica.Refresh();
            psRysownica.Clear(pbRysownica.BackColor);

        }

        private void KreskowatoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DashStyle psStylLinii;
            psStylLinii = DashStyle.Dash;
            for (int i = 0; i < psTFG.Length; i++)
            {
                psTFG[i].UstalStylLinii(psStylLinii);
                psTFG[i].Wykreśl(psRysownica);
            }
            pbRysownica.Refresh();
            psRysownica.Clear(pbRysownica.BackColor);
        }

        private void kropkowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashStyle psStylLinii;
            psStylLinii = DashStyle.Dot;
            for (int i = 0; i < psTFG.Length; i++)
            {
                psTFG[i].UstalStylLinii(psStylLinii);
                psTFG[i].Wykreśl(psRysownica);
            }
            pbRysownica.Refresh();
            psRysownica.Clear(pbRysownica.BackColor);
        }

        private void kreskowoKropkowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashStyle psStylLinii;
            psStylLinii = DashStyle.DashDot;
            for (int i = 0; i < psTFG.Length; i++)
            {
                psTFG[i].UstalStylLinii(psStylLinii);
                psTFG[i].Wykreśl(psRysownica);
            }
            pbRysownica.Refresh();
            psRysownica.Clear(pbRysownica.BackColor);
        }

        private void rbManualny_CheckedChanged(object sender, EventArgs e)
        {
            if (rbManualny.Checked)
            {
                btPoprzedni.Enabled = true;
                btNastępny.Enabled = true;
                timer1.Enabled = false;
                tbNumerFigury.Enabled = true;
            }
        }

        private void rbAutomatyczny_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAutomatyczny.Checked)
            {
                btPoprzedni.Enabled = false;
                btNastępny.Enabled = false;
            }
        }

        private void clbFigury_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}

