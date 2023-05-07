using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt2_Skupiński59369
{
    public partial class FormFiguryGeoInitial : Form
    {
        public FormFiguryGeoInitial()
        {
            InitializeComponent();
        }

        private void btPrezentacja_Click(object sender, EventArgs e)
        {
            var prezentacja = new PrezentacjaLosowaZeSlajderem();
            prezentacja.Location = this.Location;
            prezentacja.StartPosition = FormStartPosition.Manual;
            prezentacja.Show();
            this.Hide();

        }

        private void btKreślenie_Click(object sender, EventArgs e)
        {
            var Kreślenie = new KreślenieFigur_Lini_Skupiński();
            Kreślenie.Location = this.Location;
            Kreślenie.StartPosition = FormStartPosition.Manual;
            Kreślenie.Show();
            this.Hide();

        }
    }
}
