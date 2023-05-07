using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Projekt2_Skupiński59369
{
    class FiguryGeometryczne
    {
        public class Punkt
        {
            const int psDomyślnyRozmiarPunktu = 20;
            protected int psX;
            protected int psY;
            protected int psGrubośćLinii;
            protected Color psKolor;
            protected bool psWidoczny;
            protected Color psKolorTła;
            protected DashStyle psStylLinii;

            public Punkt(int psx, int psy)
            {
                psX = psx;
                psY = psy;
                psKolor = Color.Black;
                psKolorTła = Color.White;
                psStylLinii = DashStyle.Solid;
                psGrubośćLinii = psDomyślnyRozmiarPunktu;
                psWidoczny = false;
            }
            public Punkt(int psx, int psy, Color psKolor) : this(psx, psy)
            {
                this.psKolor = psKolor;
            }
            public Punkt(int psX, int psY, Color psKolor, DashStyle psStylLinii, int psRozmiarPunktu) : this(psX, psY, psKolor)
            {
                this.psStylLinii = psStylLinii;
                psGrubośćLinii = psRozmiarPunktu;
            }
            public virtual void UaktualnijXY(int psX, int psY)
            {
                this.psX = psX;
                this.psY = psY;
            }
            public virtual void UaktualnijXY(Point psNowaLokalizacja)
            {
                psX = psNowaLokalizacja.X;
                psY = psNowaLokalizacja.Y;
            }
            public virtual void UstalAtrybutyGraficzne(Color psKolorLinii, DashStyle psStylLinii, int psGrubośćLinii)
            {
                psKolor = psKolorLinii;
                this.psStylLinii = psStylLinii;
                this.psGrubośćLinii = psGrubośćLinii;
            }
            public void UstalKolorLinii(Color psKolorLinii)
            {
                psKolor = psKolorLinii;
            }
            public void UstalAtrybutyGraficzne(Color psKolorTła)
            {
                this.psKolorTła = psKolorTła;
            }
            public void UstalKolorFill(Color psKolorFill)
            {
                psKolor = psKolorFill;
            }
            public void UstalStylLinii(DashStyle psStylLinii)
            {
                this.psStylLinii = psStylLinii;
            }
            public void UstalGrubośćLinii(int psGrubośćLinii)
            {
                this.psGrubośćLinii = psGrubośćLinii;
            }
            public virtual void Wykreśl(Graphics psRysownica)
            {
                SolidBrush psPędzel = new SolidBrush(psKolor);
                psRysownica.FillEllipse(psPędzel, psX - psGrubośćLinii / 2,
                    psY - psGrubośćLinii / 2, psGrubośćLinii, psGrubośćLinii);
                psWidoczny = true;
                psPędzel.Dispose();
            }
            public virtual void Wymaż(Control psKontrolka, Graphics psRysownica)
            {
                if (this.psWidoczny)
                {
                    SolidBrush psPędzel = new SolidBrush(psKontrolka.BackColor);
                    psRysownica.FillEllipse(psPędzel, psX - psGrubośćLinii / 2,
                        psY - psGrubośćLinii / 2, psGrubośćLinii, psGrubośćLinii);
                    this.psWidoczny = false;
                    psPędzel.Dispose();
                }
            }
            public virtual void PrzesuńDoNowegoXY(Control psKontrolka, Graphics psRysownica, Point psNowaLokalizacja)
            {
                UaktualnijXY(psNowaLokalizacja);
                Wykreśl(psRysownica);
            }
            public virtual void PrzesuńDoNowegoXY(Control psKontrolka, Graphics psRysownica, int psx, int psy)
            {
                UaktualnijXY(psx, psy);
                Wykreśl(psRysownica);
            }
        }
        public class Linia : Punkt
        {
            int psXk, psYk;

            public Linia(int psXp, int psYp, int psXk, int psYk) : base(psXp, psYp)
            {
                this.psXk = psXk;
                this.psYk = psYk;
            }
            public Linia(int psXp, int psYp, int psXk, int psYk, Color psKolorLinii, DashStyle psStylLinii, int psGrubośćLinii)
                : base(psXp, psYp, psKolorLinii, psStylLinii, psGrubośćLinii)
            {
                this.psXk = psXk;
                this.psYk = psYk;
            }
            public override void Wykreśl(Graphics psRysownica)
            {
                Pen psPióro = new Pen(psKolor, this.psGrubośćLinii);
                psPióro.DashStyle = psStylLinii;
                psRysownica.DrawLine(psPióro, psX, psY, psXk, psYk);
                psWidoczny = false;
                psPióro.Dispose();
            }
            public override void Wymaż(Control psKontrolka, Graphics psRysownica)
            {
                if (psWidoczny)
                {
                    Pen psPióro = new Pen(psKontrolka.BackColor, this.psGrubośćLinii);
                    psPióro.DashStyle = psStylLinii;
                    psRysownica.DrawLine(psPióro, psX, psY, psXk, psYk);
                    psWidoczny = false;
                    psPióro.Dispose();
                }
            }
        }
        public class Elipsa : Punkt
        {
            protected int psOśDuża, psOśMała;
            public Elipsa(int psx, int psy, int psOśDuża, int psOśMała) : base(psx, psy)
            {
                this.psOśDuża = psOśDuża;
                this.psOśMała = psOśMała;
            }
            public override void Wykreśl(Graphics psRysownica)
            {
                Pen psPióro = new Pen(psKolor, this.psGrubośćLinii);
                psPióro.DashStyle = psStylLinii;
                psRysownica.DrawEllipse(psPióro, psX , psY , psOśDuża, psOśMała);
                psWidoczny = true;
                psPióro.Dispose();
            }
            public override void Wymaż(Control psKontrolka, Graphics psRysownica)
            {
                Pen psPióro = new Pen(psKontrolka.BackColor, this.psGrubośćLinii);
                psPióro.DashStyle = psStylLinii;
                psRysownica.DrawEllipse(psPióro, psX , psY , psOśDuża, psOśMała);
                psWidoczny = true;
                psPióro.Dispose();
            }
        }
        public class Okrąg : Elipsa
        {
            protected int psPromień;
            public Okrąg(int psx, int psy, int psPromień) : base(psx, psy, 2 * psPromień, 2 * psPromień)
            {
                this.psPromień = psPromień;
            }
            public override void Wykreśl(Graphics psRysownica)
            {
                psStylLinii = DashStyle.Solid;
                Pen psPióro = new Pen(psKolor, this.psGrubośćLinii / 2);
                psPióro.DashStyle = psStylLinii;
                psRysownica.DrawEllipse(psPióro, psX, psY ,  psPromień,  psPromień);
                psWidoczny = true;
                psPióro.Dispose();
            }
            public override void Wymaż(Control psKontrolka, Graphics psRysownica)
            {
                psStylLinii = DashStyle.Solid;
                Pen psPióro = new Pen(psKontrolka.BackColor, this.psGrubośćLinii / 2);
                psPióro.DashStyle = psStylLinii;
                psRysownica.DrawEllipse(psPióro, psX , psY , psPromień, psPromień);
                psWidoczny = false;
                psPióro.Dispose();
            }
        }
        public class Koło:Okrąg
        {
            public Koło(int psx, int psy, int psPromień) : base(psx, psy,psPromień)
            {
                this.psPromień = psPromień;
            }
            public override void Wykreśl(Graphics psRysownica)
            {
                
                SolidBrush psPędzel = new SolidBrush(psKolor);
                psRysownica.FillEllipse(psPędzel, psX, psY, psPromień, psPromień);
                psWidoczny = true;
                psPędzel.Dispose();
            }
            public override void Wymaż(Control psKontrolka, Graphics psRysownica)
            {
                SolidBrush psPędzel = new SolidBrush(psKontrolka.BackColor);
                psRysownica.FillEllipse(psPędzel, psX, psY, psPromień, psPromień);
                psWidoczny = false;
                psPędzel.Dispose();
            }
        }

        public class Prostokąt : Punkt
        {
            protected int psx, psy, psSzerokość, psWysokość;
            public Prostokąt(int psx, int psy, int psSzerokość, int psWysokość) : base(psx, psy)
            {
                this.psx = psx;
                this.psy = psx;
                this.psSzerokość = psSzerokość;
                this.psWysokość = psWysokość;
            }
            public override void Wykreśl(Graphics psRysownica)
            {
                Pen psPióro = new Pen(psKolor, this.psGrubośćLinii);
                psPióro.DashStyle = psStylLinii;
                psRysownica.DrawRectangle(psPióro, psX, psY, psSzerokość, psWysokość);
                psWidoczny = true;
                psPióro.Dispose();
            }
            public override void Wymaż(Control psKontrolka, Graphics psRysownica)
            {
                Pen psPióro = new Pen(psKontrolka.BackColor, this.psGrubośćLinii);
                psPióro.DashStyle = psStylLinii;
                psRysownica.DrawRectangle(psPióro, psX, psY, psSzerokość, psWysokość);
                psWidoczny = true;
                psPióro.Dispose();
            }
        }
        public class Kwadrat:Prostokąt
        {
            public Kwadrat(int psx, int psy, int psSzerokość) : base(psx,psy,psSzerokość,psSzerokość)
            {
                this.psx = psx;
                this.psy = psx;
                this.psSzerokość = psSzerokość;
            }
            public override void Wykreśl(Graphics psRysownica)
            {
                Pen psPióro = new Pen(psKolor, this.psGrubośćLinii);
                psPióro.DashStyle = psStylLinii;
                psRysownica.DrawRectangle(psPióro, psX, psY, psSzerokość, psSzerokość);
                psWidoczny = true;
                psPióro.Dispose();
            }
            public override void Wymaż(Control psKontrolka, Graphics psRysownica)
            {
                Pen psPióro = new Pen(psKontrolka.BackColor, this.psGrubośćLinii);
                psPióro.DashStyle = psStylLinii;
                psRysownica.DrawRectangle(psPióro, psX, psY, psSzerokość, psSzerokość);
                psWidoczny = true;
                psPióro.Dispose();
            }
        }
        
        public class LiniaCiągła : Punkt
        {
            List<Point> psListaPunktów = new List<Point>();
            public LiniaCiągła(Point psPoczątekLinii) : base(psPoczątekLinii.X, psPoczątekLinii.Y)
            {
                psListaPunktów.Add(psPoczątekLinii);
            }
            public LiniaCiągła(Point psPoczątekLinii, Color psKolor, DashStyle psStylLinii, int psGrubośćLinii)
                : base(psPoczątekLinii.X, psPoczątekLinii.Y, psKolor, psStylLinii, psGrubośćLinii)
            {
                psListaPunktów.Add(psPoczątekLinii);
            }

            public void DodajNowyPunktLiniiCiągłej(Point psNowyPunkt)
            {
                psListaPunktów.Add(psNowyPunkt);
            }
            public override void UaktualnijXY(int psx, int psy)
            {
                if (psListaPunktów.Count < 1)
                {
                    return;
                }
                int psPrzyrostX = psListaPunktów[0].X - psx;
                int psPrzyrostY = psListaPunktów[0].Y - psy;
                for (int i = 0; i < psListaPunktów.Count; i++)
                {
                    psListaPunktów[i] = 
                        new Point(psListaPunktów[i].X - psPrzyrostX,
                        psListaPunktów[i].Y - psPrzyrostY);
                }
            }
            public override void Wykreśl(Graphics psRysownica)
            {
                Point[] psTablicaPunktów = new Point[psListaPunktów.Count];
                for (int i = 0; i < psListaPunktów.Count; i++)
                {
                    psTablicaPunktów[i] = psListaPunktów[i];
                }
                Pen psPióro = new Pen(psKolor, psGrubośćLinii);
                psPióro.DashStyle = psStylLinii;
                psRysownica.DrawLines(psPióro, psTablicaPunktów);
                psWidoczny = true;
                psPióro.Dispose();
            }
            public override void Wymaż(Control psKontrolka, Graphics psRysownica)
            {
                Point[] psTablicaPunktów = new Point[psListaPunktów.Count];
                for (int i = 0; i < psListaPunktów.Count; i++)
                {
                    psTablicaPunktów[i] = psListaPunktów[i];
                }
                Pen psPióro = new Pen(psKontrolka.BackColor, psGrubośćLinii);
                psPióro.DashStyle = psStylLinii;
                psRysownica.DrawLines(psPióro, psTablicaPunktów);
                psWidoczny = true;
                psPióro.Dispose();
            }
        }
        public class FillElipse : Punkt
        {
            protected int psOśDuża, psOśMała;
            public FillElipse(int psx, int psy, int psOśDuża, int psOśMała) : base(psx, psy)
            {
                this.psOśDuża = psOśDuża;
                this.psOśMała = psOśMała;
            }
            public override void Wykreśl(Graphics psRysownica)
            {
                SolidBrush psPędzel = new SolidBrush(psKolor);
                psRysownica.FillEllipse(psPędzel, psX , psY , psOśDuża, psOśMała);
                psWidoczny = true;
                psPędzel.Dispose();
            }
            public override void Wymaż(Control psKontrolka, Graphics psRysownica)
            {
                SolidBrush psPędzel = new SolidBrush(psKolor);
                psRysownica.FillEllipse(psPędzel, psX , psY , psOśDuża, psOśMała);
                psWidoczny = true;
                psPędzel.Dispose();
            }
        }
        public class FillRectangle : Punkt
        {
            protected int psx, psy, psSzerokość, psWysokość;
            public FillRectangle(int psx, int psy, int psSzerokość, int psWysokość) : base(psx, psy)
            {
                this.psx = psx;
                this.psy = psx;
                this.psSzerokość = psSzerokość;
                this.psWysokość = psWysokość;
            }
            public override void Wykreśl(Graphics psRysownica)
            {
                SolidBrush psPędzel = new SolidBrush(psKolor);
                psRysownica.FillRectangle(psPędzel, psX, psY, psSzerokość, psWysokość);
                psWidoczny = true;
                psPędzel.Dispose();
            }
            public override void Wymaż(Control psKontrolka, Graphics psRysownica)
            {
                SolidBrush psPędzel = new SolidBrush(psKolor);
                psRysownica.FillRectangle(psPędzel, psX, psY, psSzerokość, psWysokość);
                psWidoczny = true;
                psPędzel.Dispose();
            }
        }
        public class DrawPie : Elipsa
        {
            int psStartAngle;
            int psSweepAngle;
            protected int psPromień;
            public DrawPie(int psx, int psy, int psPromień, int psStartAngle, int psSweepAngle) : 
                base(psx, psy, 2 * psPromień, 2 * psPromień)
            {
                this.psPromień = psPromień;
                this.psStartAngle = psStartAngle;
                this.psSweepAngle = psSweepAngle;
            }
            public override void Wykreśl(Graphics psRysownica)
            {
                psStylLinii = DashStyle.Solid;
                Pen psPióro = new Pen(psKolor, this.psGrubośćLinii / 2);
                psPióro.DashStyle = psStylLinii;
                psRysownica.DrawPie(psPióro, psX, psY, psPromień, psPromień, psStartAngle, psSweepAngle);
                psWidoczny = true;
                psPióro.Dispose();
            }
            public override void Wymaż(Control psKontrolka, Graphics psRysownica)
            {
                psStylLinii = DashStyle.Solid;
                Pen psPióro = new Pen(psKontrolka.BackColor, this.psGrubośćLinii / 2);
                psPióro.DashStyle = psStylLinii;
                psRysownica.DrawPie(psPióro, psX, psY, psPromień, psPromień, psStartAngle, psSweepAngle);
                psWidoczny = true;
                psPióro.Dispose();
            }
        }
        public class FillPie : Elipsa
        {
            float psStartAngle;
            float psSweepAngle;
            protected int psPromień;
            public FillPie(int psx, int psy, int psPromień, int psStartAngle, int psSweepAngle) : base(psx, psy, 2 * psPromień, 2 * psPromień)
            {
                this.psPromień = psPromień;
                this.psStartAngle = psStartAngle;
                this.psSweepAngle = psSweepAngle;
            }
            public override void Wykreśl(Graphics psRysownica)
            {
                SolidBrush psPędzel = new SolidBrush(psKolor);
                psRysownica.FillPie(psPędzel, psX, psY, psPromień, psPromień, psStartAngle, psSweepAngle);
                psWidoczny = true;
                psPędzel.Dispose();
            }
            public override void Wymaż(Control psKontrolka, Graphics psRysownica)
            {
                SolidBrush psPędzel = new SolidBrush(psKolor);
                psRysownica.FillPie(psPędzel, psX, psY, psPromień, psPromień, psStartAngle, psSweepAngle);
                psWidoczny = true;
                psPędzel.Dispose();
            }
        }
        public class DrawArc : Elipsa
        {
            float psStartAngle;
            float psSweepAngle;
            protected int psPromień;
            public DrawArc(int psx, int psy, int psPromień, int psStartAngle, int psSweepAngle) :
                base(psx, psy, 2 * psPromień, 2 * psPromień)
            {
                this.psPromień = psPromień;
                this.psStartAngle = psStartAngle;
                this.psSweepAngle = psSweepAngle;
            }
            public override void Wykreśl(Graphics psRysownica)
            {
                psStylLinii = DashStyle.Solid;
                Pen psPióro = new Pen(psKolor, this.psGrubośćLinii / 2);
                psPióro.DashStyle = psStylLinii;
                psRysownica.DrawArc(psPióro, psX, psY, psPromień, psPromień, psStartAngle, psSweepAngle);
                psWidoczny = true;
                psPióro.Dispose();
            }
            public override void Wymaż(Control psKontrolka, Graphics psRysownica)
            {
                psStylLinii = DashStyle.Solid;
                Pen psPióro = new Pen(psKontrolka.BackColor, this.psGrubośćLinii / 2);
                psPióro.DashStyle = psStylLinii;
                psRysownica.DrawArc(psPióro, psX, psY, psPromień, psPromień, psStartAngle, psSweepAngle);
                psWidoczny = true;
                psPióro.Dispose();
            }
        }
        public class KrzywaBeziera : Punkt
        {
            public List<Point> psPunktKrzywejBeziera = new List<Point>();
            int psPPK = 5;
            public ushort LiczbaPunktówKontrolnych
            {
                get;
                set;
            }
            Font psFontOpisuPunktów = new Font("Arial", 8, FontStyle.Italic);
            public KrzywaBeziera(Graphics psRysownica, Pen psPióro, Point psPunktXY)
                : base(psPunktXY.X, psPunktXY.Y, psPióro.Color, psPióro.DashStyle, (int)psPióro.Width)
            {
                psPunktKrzywejBeziera.Add(psPunktXY);
                using (SolidBrush psPędzel = new SolidBrush(psKolor))
                {
                    psRysownica.FillEllipse(psPędzel, psPunktXY.X - psPPK, psPunktXY.Y - psPPK, 2 * psPPK, 2 * psPPK);
                    psRysownica.DrawString("p" + (psPunktKrzywejBeziera.Count - 1).ToString(), psFontOpisuPunktów, psPędzel,
                        psPunktKrzywejBeziera[psPunktKrzywejBeziera.Count - 1]);
                }
            }
            public void DodajNowyPunktKontrolny(Point psPunktXY, Graphics psRysownica)
            {
                psPunktKrzywejBeziera.Add(psPunktXY);
                using (SolidBrush psPędzel = new SolidBrush(Color.Red))
                {
                    if (psPunktKrzywejBeziera.Count == 1 || psPunktKrzywejBeziera.Count == 4)
                    {
                        psPędzel.Color = psKolor;
                    }
                    psRysownica.FillEllipse(psPędzel, psPunktXY.X - psPPK, psPunktXY.Y - psPPK, 2 * psPPK, 2 * psPPK);
                    psRysownica.DrawString("p" + (psPunktKrzywejBeziera.Count - 1).ToString(), psFontOpisuPunktów, psPędzel,
                        psPunktKrzywejBeziera[psPunktKrzywejBeziera.Count - 1]);
                }
                if (psPunktKrzywejBeziera.Count == 4)
                {
                    Wykreśl(psRysownica);
                }
            }
            public override void Wykreśl(Graphics psRysownica)
            {
                using (Pen psPióro = new Pen(psKolor, psGrubośćLinii))
                {
                    psPióro.DashStyle = psStylLinii;
                    Point[] psPunktyKontrolne = new Point[psPunktKrzywejBeziera.Count];
                    for (ushort i = 0; i < psPunktKrzywejBeziera.Count; i++)
                    {
                        psPunktyKontrolne[i] = new Point(psPunktKrzywejBeziera[i].X, psPunktKrzywejBeziera[i].Y);
                    }
                    psRysownica.DrawBezier(psPióro, psPunktyKontrolne[0], psPunktyKontrolne[1], psPunktyKontrolne[2], psPunktyKontrolne[3]);
                    psWidoczny = true;
                }
            }
            public override void Wymaż(Control psKontrolka, Graphics psRysownica)
            {
                if (psWidoczny)
                {
                    using (Pen psPióro = new Pen(psKontrolka.BackColor, psGrubośćLinii))
                    {
                        psPióro.DashStyle = psStylLinii;
                        Point[] psPKB = new Point[psPunktKrzywejBeziera.Count];
                        for (int i = 0; i < psPunktKrzywejBeziera.Count; i++)
                        {
                            psPKB[i] = new Point(psPunktKrzywejBeziera[i].X, psPunktKrzywejBeziera[i].Y);
                        }
                        psRysownica.DrawBezier(psPióro, psPKB[0], psPKB[1], psPKB[2], psPKB[3]);
                        psWidoczny = false;
                    }
                }
            }
            public override void UaktualnijXY(int psX, int psY)
            {
                int psPrzyrostX = psPunktKrzywejBeziera[0].X - psX;
                int psPrzyrostY = psPunktKrzywejBeziera[0].Y - psY;
                for (int i = 0; i < psPunktKrzywejBeziera.Count; i++)
                {
                    psPunktKrzywejBeziera[i] = new Point(psPunktKrzywejBeziera[i].X - psPrzyrostX,
                        psPunktKrzywejBeziera[i].Y - psPrzyrostY);
                }
            }
        }
        public class KrzywaKardynalna:Punkt
        {
            public List<Point> psPunktyKrzywejKardynalnej = new List<Point>();
            protected int psPPK = 5;
            public ushort LiczbaPunktówKontrolnych
            {
                get;
                set;
            }
            protected Font psFontOpisuPunktów = new Font("Arial", 8, FontStyle.Italic);
            public KrzywaKardynalna(Graphics psRysownica, Pen psPióro, Point psPunktXY)
    : base(psPunktXY.X, psPunktXY.Y, psPióro.Color, psPióro.DashStyle, (int)psPióro.Width)
            {
                psPunktyKrzywejKardynalnej.Add(psPunktXY);
                using (SolidBrush psPędzel = new SolidBrush(psKolor))
                {
                    psRysownica.FillEllipse(psPędzel, psPunktXY.X - psPPK, psPunktXY.Y - psPPK, 2 * psPPK, 2 * psPPK);
                    psRysownica.DrawString("p" + (psPunktyKrzywejKardynalnej.Count - 1).ToString(), psFontOpisuPunktów, psPędzel,
                        psPunktyKrzywejKardynalnej[psPunktyKrzywejKardynalnej.Count - 1]);
                }
            }
            public virtual void DodajNowyPunktKontrolny(Point psPunktXY, Graphics psRysownica)
            {
                psPunktyKrzywejKardynalnej.Add(psPunktXY);
                using (SolidBrush psPędzel = new SolidBrush(Color.Red))
                {
                    if (psPunktyKrzywejKardynalnej.Count == 1 || psPunktyKrzywejKardynalnej.Count == 6)
                    {
                        psPędzel.Color = psKolor;
                    }
                    psRysownica.FillEllipse(psPędzel, psPunktXY.X - psPPK, psPunktXY.Y - psPPK, 2 * psPPK, 2 * psPPK);
                    psRysownica.DrawString("p" + (psPunktyKrzywejKardynalnej.Count - 1).ToString(), psFontOpisuPunktów, psPędzel,
                        psPunktyKrzywejKardynalnej[psPunktyKrzywejKardynalnej.Count - 1]);
                }
                if (psPunktyKrzywejKardynalnej.Count == 6)
                {
                    Wykreśl(psRysownica);
                }
            }
            public override void Wykreśl(Graphics psRysownica)
            {
                using (Pen psPióro = new Pen(psKolor, psGrubośćLinii))
                {
                    psPióro.DashStyle = psStylLinii;
                    Point[] psPunktyKontrolne = new Point[psPunktyKrzywejKardynalnej.Count];
                    for (ushort i = 0; i < psPunktyKrzywejKardynalnej.Count; i++)
                    {
                        psPunktyKontrolne[i] = new Point(psPunktyKrzywejKardynalnej[i].X, psPunktyKrzywejKardynalnej[i].Y);
                    }
                    psRysownica.DrawCurve(psPióro, psPunktyKontrolne);
                    psWidoczny = true;
                }
            }
            public override void Wymaż(Control psKontrolka, Graphics psRysownica)
            {
                if (psWidoczny)
                {
                    using (Pen psPióro = new Pen(psKontrolka.BackColor, psGrubośćLinii))
                    {
                        psPióro.DashStyle = psStylLinii;
                        Point[] psPunktyKontrolne = new Point[psPunktyKrzywejKardynalnej.Count];
                        for (ushort i = 0; i < psPunktyKrzywejKardynalnej.Count; i++)
                        {
                            psPunktyKontrolne[i] = new Point(psPunktyKrzywejKardynalnej[i].X, psPunktyKrzywejKardynalnej[i].Y);
                        }
                        psRysownica.DrawCurve(psPióro, psPunktyKontrolne);
                        psWidoczny = false;
                    }
                }
            }
            public override void UaktualnijXY(int psX, int psY)
            {
                int psPrzyrostX = psPunktyKrzywejKardynalnej[0].X - psX;
                int psPrzyrostY = psPunktyKrzywejKardynalnej[0].Y - psY;
                for (int i = 0; i < psPunktyKrzywejKardynalnej.Count; i++)
                {
                    psPunktyKrzywejKardynalnej[i] = new Point(psPunktyKrzywejKardynalnej[i].X - psPrzyrostX,
                        psPunktyKrzywejKardynalnej[i].Y - psPrzyrostY);
                }
            }
        }
        //public class DrawArc:KrzywaKardynalna
        //{
        //    float psStartAngle;
        //    float psSweepAngle;
        //    public List<Point> psPunktyArcu = new List<Point>();
        //    public DrawArc(Graphics psRysownica, Pen psPióro, Point psPunktXY)
        //        : base( psRysownica,  psPióro, psPunktXY)
        //    {
        //        psPunktyArcu.Add(psPunktXY);
        //        using (SolidBrush psPędzel = new SolidBrush(psKolor))
        //        {
        //            psRysownica.FillEllipse(psPędzel, psPunktXY.X - psPPK, psPunktXY.Y - psPPK, 2 * psPPK, 2 * psPPK);
        //            psRysownica.DrawString("p" + (psPunktyArcu.Count - 1).ToString(), psFontOpisuPunktów, psPędzel,
        //                psPunktyArcu[psPunktyArcu.Count - 1]);
        //        }
        //    }
        //    public override void DodajNowyPunktKontrolny(Point psPunktXY, Graphics psRysownica)
        //    {
        //        psPunktyArcu.Add(psPunktXY);
        //        using (SolidBrush psPędzel = new SolidBrush(Color.Red))
        //        {
        //            if (psPunktyArcu.Count == 1 || psPunktyArcu.Count == 3)
        //            {
        //                psPędzel.Color = psKolor;
        //            }
        //            psRysownica.FillEllipse(psPędzel, psPunktXY.X - psPPK, psPunktXY.Y - psPPK, 2 * psPPK, 2 * psPPK);
        //            psRysownica.DrawString("p" + (psPunktyArcu.Count - 1).ToString(), psFontOpisuPunktów, psPędzel,
        //                psPunktyArcu[psPunktyArcu.Count - 1]);
        //        }
        //        if (psPunktyArcu.Count == 3)
        //        {
        //            Wykreśl(psRysownica);
        //        }
        //    }
        //    public float PrzeciągnijLinię(Point P1, Point P2)
        //    {//sqrt((P1x - P2x)2 + (P1y - P2y)2)
        //        float Linia;
        //        Linia = (float)Math.Sqrt((P1.X - P2.X) * (P1.X - P2.X) + (P1.Y - P2.Y) * (P1.Y - P2.Y));
        //        return Linia;


        //    }
        //    public override void Wykreśl(Graphics psRysownica)
        //    {
        //        using (Pen psPióro = new Pen(psKolor, psGrubośćLinii))
        //        {
        //            //psSweepAngle= Math.Acos((P12 2 + P13 2 - P23 2) / (2 * P12 * P13))
        //            float Linia1, Linia2, Linia3, Linia4;
        //            Linia1 = PrzeciągnijLinię(psPunktyArcu[0], psPunktyArcu[1]);
        //            Linia2 = PrzeciągnijLinię(psPunktyArcu[0], psPunktyArcu[2]);
        //            Linia3 = PrzeciągnijLinię(psPunktyArcu[1], psPunktyArcu[2]);
        //            Linia4 = PrzeciągnijLinię(psPunktyArcu[0], new Point(psPunktyArcu[1].X, psPunktyArcu[0].Y));
        //            psSweepAngle = (float)(Math.Acos((Linia1 * Linia1 + Linia2 * Linia2 - Linia3 * Linia3) / (2 * Linia1 * Linia2)));
        //            psStartAngle = (float)((Math.Acos((Linia1 * Linia1 + Linia2 * Linia2 - Linia4 * Linia4) / (2 * Linia1 * Linia2))));

        //            psPióro.DashStyle = psStylLinii;
        //            psRysownica.DrawArc(psPióro, psPunktyArcu[0].X, psPunktyArcu[0].Y, Linia1, Linia2, psStartAngle, psSweepAngle);
        //            psWidoczny = true;
        //        }
        //    }
        //    public override void Wymaż(Control psKontrolka, Graphics psRysownica)
        //    {
        //        if (psWidoczny)
        //        {
        //            using (Pen psPióro = new Pen(psKontrolka.BackColor, psGrubośćLinii))
        //            {
        //                float Linia1, Linia2, Linia3, Linia4;
        //                Linia1 = PrzeciągnijLinię(psPunktyArcu[0], psPunktyArcu[1]);
        //                Linia2 = PrzeciągnijLinię(psPunktyArcu[0], psPunktyArcu[2]);
        //                Linia3 = PrzeciągnijLinię(psPunktyArcu[1], psPunktyArcu[2]);
        //                Linia4 = PrzeciągnijLinię(psPunktyArcu[0], new Point(psPunktyArcu[0].X, psPunktyArcu[1].Y));
        //                psSweepAngle = (float)(Math.Acos((Linia1 * Linia1 + Linia2 * Linia2 - Linia3 * Linia3) / (2 * Linia1 * Linia2)));
        //                psStartAngle = (float)((Math.Acos((Linia1 * Linia1 + Linia2 * Linia2 - Linia4 * Linia4) / (2 * Linia1 * Linia2))));

        //                psPióro.DashStyle = psStylLinii;

        //                psRysownica.DrawArc(psPióro, psPunktyArcu[0].X, psPunktyArcu[0].Y, Linia1, Linia2, psStartAngle, psSweepAngle);
        //                psWidoczny = false;
        //            }
        //        }
        //    }

        //}
        public class FillClosedCurve : KrzywaKardynalna
        {
            public FillClosedCurve(Graphics psRysownica, Pen psPióro, Point psPunktXY)
    : base(psRysownica, psPióro, psPunktXY)
            {
                psPunktyKrzywejKardynalnej.Add(psPunktXY);
                using (SolidBrush psPędzel = new SolidBrush(psKolor))
                {
                    psRysownica.FillEllipse(psPędzel, psPunktXY.X - psPPK, psPunktXY.Y - psPPK, 2 * psPPK, 2 * psPPK);
                    psRysownica.DrawString("p" + (psPunktyKrzywejKardynalnej.Count - 1).ToString(), psFontOpisuPunktów, psPędzel,
                        psPunktyKrzywejKardynalnej[psPunktyKrzywejKardynalnej.Count - 1]);
                }
            }
            public override void Wykreśl(Graphics psRysownica)
            {
                using (SolidBrush psPędzel = new SolidBrush(psKolor))
                {
                    
                    Point[] psPunktyKontrolne = new Point[psPunktyKrzywejKardynalnej.Count];
                    for (ushort i = 0; i < psPunktyKrzywejKardynalnej.Count; i++)
                    {
                        psPunktyKontrolne[i] = new Point(psPunktyKrzywejKardynalnej[i].X, psPunktyKrzywejKardynalnej[i].Y);
                    }
                    psRysownica.FillClosedCurve(psPędzel, psPunktyKontrolne);
                    psWidoczny = true;
                }
            }
            public override void Wymaż(Control psKontrolka, Graphics psRysownica)
            {
                if (psWidoczny)
                {
                    using (SolidBrush psPędzel = new SolidBrush(psKontrolka.BackColor))
                    {
                        
                        Point[] psPunktyKontrolne = new Point[psPunktyKrzywejKardynalnej.Count];
                        for (ushort i = 0; i < psPunktyKrzywejKardynalnej.Count; i++)
                        {
                            psPunktyKontrolne[i] = new Point(psPunktyKrzywejKardynalnej[i].X, psPunktyKrzywejKardynalnej[i].Y);
                        }
                        psRysownica.FillClosedCurve(psPędzel, psPunktyKontrolne);
                        psWidoczny = false;
                    }
                }
            }
        }
        public class WielokątForemny : Kwadrat
        {
            static Random rnd = new Random();
            static int N = rnd.Next(3, 12);//liczba ścian
            public Point[] psPunktyWielokąta = new Point[N];
            
            public WielokątForemny(int psx, int psy, int psSzerokość) : base(psx, psy, psSzerokość)
            {
                this.psx = psx;
                this.psy = psx;
                this.psSzerokość = psSzerokość;
            }
            public override void Wykreśl(Graphics psRysownica)
            {
                Pen psPióro = new Pen(psKolor, this.psGrubośćLinii);
                psPióro.DashStyle = psStylLinii;
                //N = rnd.Next(3, 12);
                for(int n=0;n<N ;n++)
                {
                    int X = (int)(psSzerokość * Math.Cos(2 * Math.PI * n / N) + psx);
                    int Y = (int)(psSzerokość * Math.Sin(2 * Math.PI * n / N) + psy);
                    psPunktyWielokąta[n]=(new Point(X, Y));

                }
                psRysownica.DrawPolygon(psPióro, psPunktyWielokąta);
                psWidoczny = true;
                psPióro.Dispose();
            }
            public override void Wymaż(Control psKontrolka, Graphics psRysownica)
            {
                Pen psPióro = new Pen(psKontrolka.BackColor, this.psGrubośćLinii);
                psPióro.DashStyle = psStylLinii;
                for (int n = 0; n < N; n++)
                {
                    int X = (int)(psSzerokość * Math.Cos(2 * Math.PI * n / N) + psx);
                    int Y = (int)(psSzerokość * Math.Sin(2 * Math.PI * n / N) + psy);
                    psPunktyWielokąta[n] = (new Point(X, Y));

                }
                psRysownica.DrawPolygon(psPióro, psPunktyWielokąta);
                psWidoczny = false;
                psPióro.Dispose();
            }
        }
        public class WielokątForemnyWypełniony: WielokątForemny
        {
            static Random rnd = new Random();
            static int N = rnd.Next(3, 12);//liczba ścian

            public WielokątForemnyWypełniony(int psx, int psy, int psSzerokość) : base(psx, psy, psSzerokość)
            {
                this.psx = psx;
                this.psy = psx;
                this.psSzerokość = psSzerokość;
            }
            public override void Wykreśl(Graphics psRysownica)
            {
                SolidBrush psPędzel = new SolidBrush(psKolor);
                for (int n = 0; n < N; n++)
                {
                    int X = (int)(psSzerokość * Math.Cos(2 * Math.PI * n / N) + psx);
                    int Y = (int)(psSzerokość * Math.Sin(2 * Math.PI * n / N) + psy);
                    psPunktyWielokąta[n] = (new Point(X, Y));

                }
                psRysownica.FillPolygon(psPędzel, psPunktyWielokąta);
                psWidoczny = true;
                psPędzel.Dispose(); 
            }
            public override void Wymaż(Control psKontrolka, Graphics psRysownica)
            {
                SolidBrush psPędzel = new SolidBrush(psKontrolka.BackColor);
                for (int n = 0; n < N; n++)
                {
                    int X = (int)(psSzerokość * Math.Cos(2 * Math.PI * n / N) + psx);
                    int Y = (int)(psSzerokość * Math.Sin(2 * Math.PI * n / N) + psy);
                    psPunktyWielokąta[n] = (new Point(X, Y));

                }
                psRysownica.FillPolygon(psPędzel, psPunktyWielokąta);
                psWidoczny = false;
                psPędzel.Dispose();
            }
        }
    }
}
