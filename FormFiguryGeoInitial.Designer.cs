
namespace Projekt2_Skupiński59369
{
    partial class FormFiguryGeoInitial
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btKreślenie = new System.Windows.Forms.Button();
            this.btPrezentacja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btKreślenie
            // 
            this.btKreślenie.Location = new System.Drawing.Point(439, 153);
            this.btKreślenie.Name = "btKreślenie";
            this.btKreślenie.Size = new System.Drawing.Size(233, 69);
            this.btKreślenie.TabIndex = 0;
            this.btKreślenie.Text = "Kreślenie figur geometrycznych ";
            this.btKreślenie.UseVisualStyleBackColor = true;
            this.btKreślenie.Click += new System.EventHandler(this.btKreślenie_Click);
            // 
            // btPrezentacja
            // 
            this.btPrezentacja.Location = new System.Drawing.Point(157, 153);
            this.btPrezentacja.Name = "btPrezentacja";
            this.btPrezentacja.Size = new System.Drawing.Size(232, 69);
            this.btPrezentacja.TabIndex = 1;
            this.btPrezentacja.Text = "Prezentacja Figur Geometrycznych ";
            this.btPrezentacja.UseVisualStyleBackColor = true;
            this.btPrezentacja.Click += new System.EventHandler(this.btPrezentacja_Click);
            // 
            // FormFiguryGeoInitial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btPrezentacja);
            this.Controls.Add(this.btKreślenie);
            this.Name = "FormFiguryGeoInitial";
            this.Text = "FiguryGeometryczne";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btKreślenie;
        private System.Windows.Forms.Button btPrezentacja;
    }
}

