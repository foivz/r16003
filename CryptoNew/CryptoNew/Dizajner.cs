using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoNew
{
    static class Dizajner
    {
        /// <summary>
        /// Poziva se prilikom inicjalizacije forme kako bi dizajn odgovarao ostatku aplikacije i glavnom panelu aplikacije
        /// </summary>
        /// <param name="forma"></param>
        public static void FormaBezOkna(Form forma)
        {
            forma.FormBorderStyle = FormBorderStyle.None;
            forma.MaximizeBox = false;
            forma.MinimizeBox = false;
            forma.StartPosition = FormStartPosition.CenterScreen;
            // Remove the control box so the form will only display client area.
            forma.ControlBox = false;
            forma.BackColor = System.Drawing.Color.SkyBlue;
            forma.AutoScroll = true;
        }

        /// <summary>
        /// Prilagodi formu glavnom panelu aplikacije
        /// </summary>
        /// <param name="forma"></param>
        public static void prilagodiFormuPanelu(Form forma, Panel panel)
        {
            forma.TopLevel = false;
            forma.Width = panel.Width;
            forma.Height = panel.Height;
            panel.Controls.Add(forma);
            forma.Show();
        }

        /// <summary>
        /// Prilagodi veličinu forme s obzirom na veličinu glavnoga panela aplilacije
        /// </summary>
        /// <param name="forma"></param>
        /// <param name="panel"></param>
        public static void prilagodiVelicinu(Form forma, Panel panel)
        {
            forma.Height = panel.Height;
            forma.Width = panel.Width;
        }

        /// <summary>
        /// Glavni button za formu - enter button
        /// </summary>
        /// <param name="myDefaultBtn"></param>
        public static void SetDefaultButton(Form forma, Button myDefaultBtn)
        {
            forma.AcceptButton = myDefaultBtn;
        }
    }
}
