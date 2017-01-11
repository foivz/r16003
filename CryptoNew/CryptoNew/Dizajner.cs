using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoNew
{
    static class Dizajner
    {
        public static void FormaBezOkna(Form forma)
        {
            forma.FormBorderStyle = FormBorderStyle.None;
            forma.MaximizeBox = false;
            forma.MinimizeBox = false;
            forma.StartPosition = FormStartPosition.CenterScreen;
            // Remove the control box so the form will only display client area.
            forma.ControlBox = false;
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
    }
}
