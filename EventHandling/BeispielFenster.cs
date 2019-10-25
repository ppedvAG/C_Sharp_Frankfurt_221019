using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventHandling
{
    //PARTIAL besagt, dass die Klasse hier nicht vollständig dargestellt wird. Der Rest befindet sich in einem
    ///anderen Dokument. Jedes Form erbt von der Klasse FORM, welche sämtliche Funktionen eines Fensters zur Verfügung stellt
    public partial class BeispielFenster : Form
    {
        //Konstruktor des Forms (wird bei Aufruf des Fensters aufgerufen)
        public BeispielFenster()
        {
            //Mit dieser Methode werden die Designerseitig gebauten Elemente gezeichnet (-> sollte immer die erste Funktion sein, welche
            ///der Konstruktor aufruft
            InitializeComponent();

            //EVENTs sind spezielle Delegates, welche nicht per Zuweisung überschrieben werden können. Methode müssen das Event per += abbonieren und
            ///per -= deabbonieren. Tritt ein Event auf (z.B. wenn ein Button geklickt wird) werden alle Methoden ausgeführt, welche dieses Event
            ///abboniert haben
            BtnKlickMich.Click += ZweiteEventMethode;
        }

        //Click-Methoden, der einzelnen Buttons
        private void BtnKlickMich_Click(object sender, EventArgs e)
        {
            //Buttonfarbwechsel über die Variable des Buttons
            BtnKlickMich.BackColor = Color.Crimson;
            //Buttonfarbwechsel über den sender-Übergabeparameter
            ///Hier liegt immer das Objekt drin, welches das Event geworfen hat.
            ///Dies muss dann noch gecastet werden:
            (sender as Button).BackColor = Color.Crimson;
        }

        private void ZweiteEventMethode(object sender, EventArgs e)
        {
            //Ändern der Texteigenschaft (Inhalt) des Buttons
            BtnKlickMich.Text = "Hast du gut gemacht";
        }

        //Eventmethode des 'Beenden'-Menüeintrags
        private void BeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Schließen des aktuellen Fensters
            this.Close();
            //Beenden der kompletten Applikation
            Application.Exit();
        }

        //Eventmethode des 'Neues Fenster'-Menüeintrags
        private void NeuesFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanziierung des neuen Fensters
            BeispielFenster neuesFenster = new BeispielFenster();
            //Manipuation des Fenstertitels
            neuesFenster.Text = "2. Fenster";
            //Öffnen des Fensters als gleichberechtigtes Fenster
            //neuesFenster.Show();
            //Öffnen des neuen Fensters als Dialogfenster (verbietet Zugriff auf alle anderen Fenster)
            neuesFenster.ShowDialog();
        }

        //Tick-Eventmethode des Timers (wird nach jedem Intervalldurchlauf ausgeführt)
        private void Timer1_Tick(object sender, EventArgs e)
        {
            //Bewegen des Buttons um 10 Pixel nach unten
            BtnKlickMich.Top += 10;
        }

        //Click-Event-Methode des Buttons zur Timer-Kontrolle
        private void BtnTimer_Click(object sender, EventArgs e)
        {
            //Prüfun, ob der Timer noch läuft
            if (timer1.Enabled)
                //Stoppen des Timers
                timer1.Stop();
            else
                //Starten des Timers
                timer1.Start();
        }

        //Click-Event-Methode des MessageBox-Buttons
        private void BtnMB_Click(object sender, EventArgs e)
        {
            //Anzeigen einer MessageBox mit Prüfung, welcher Button geklickt wurde
            if (MessageBox.Show("Geht es dir gut?", "Befindlichkeitabfrage", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                MessageBox.Show("Aber nicht mehr lange...");
            else
                MessageBox.Show("Schade aber auch...");
        }
    }
}
