using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fahrzeugpark;
using Newtonsoft.Json;

namespace Serialisierung
{
    public partial class Form1 : Form
    {
        //Benötigte Properties (Liste zum Speichern der Fahrzeuge und Zufaöllsgenerator)
        public List<Fahrzeug> Fahrzeugliste { get; set; }
        public Random Generator { get; set; }

        public Form1()
        {
            InitializeComponent();
            
            //Initialisierung der Properties
            this.Fahrzeugliste = new List<Fahrzeug>();
            this.Generator = new Random();
        }

        //Methode zur zufälligen Erstellung von Fahrzeugen
        public Fahrzeug ErstelleNeuesFz()
        {
            switch (Generator.Next(1,4))
            {
                case 1:
                    return new Schiff("Titanic", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf);
                case 2:
                    return new Flugzeug("Boing", 800, 3000000, 9999);
                case 3:
                    return PKW.ErzeugeZufälligenPKW("");
            }
            return null;
        }

        //Methode zur Darstellung der Fahrzeuge aus der Liste in der ListBox der GUI
        public void ZeigeFzs()
        {
            LbxFahrzeuge.Items.Clear();

            foreach (var item in Fahrzeugliste)
            {
                LbxFahrzeuge.Items.Add(item.Name);
            }
        }

        //Methode zum Löschen markierter Fahrzeugen
        public void LöscheFzs()
        {
            for (int i = LbxFahrzeuge.Items.Count - 1; i >= 0; i--)
            {
                if (LbxFahrzeuge.GetSelected(i))
                    Fahrzeugliste.RemoveAt(i);
            }
        }

        //Methode zum Abspeichern von Fahrzeugen (vgl. auch LadeFZ)
        public void SpeichereFzs()
        {
            try
            {
                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.TypeNameHandling = TypeNameHandling.Objects;

                using(StreamWriter sw = new StreamWriter("fahrzeuge.txt"))
                {
                    //Iteration über die ListBox
                    for (int i = 0; i < Fahrzeugliste.Count; i++)
                    {
                        string fzAlsString = JsonConvert.SerializeObject(Fahrzeugliste[i], settings);

                        sw.WriteLine(fzAlsString);
                    }
                }

                MessageBox.Show("Speichern erfolgreich");
            }
            catch
            {
                MessageBox.Show("Speichern fehgeschlagen");
            }
        }

        //Methode zum Laden einer 'Fahrzeug'-Datei (vgl. auch SpeichernUndLaden.Form1.LadeText())
        public void LadeFzs()
        {
            try
            {
                //Mittels der TypeNameHandling-Property des JsonSerializerSettings-Objekts kann dem Serialisierer aufgegeben werden, dass er den expliziten Objekt-Type der 
                //zu ladenden/speichernden Objekte mit abspeichert
                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.TypeNameHandling = TypeNameHandling.Objects;

                using(StreamReader sr = new StreamReader("fahrzeuge.txt"))
                {
                    Fahrzeugliste.Clear();

                    while (!sr.EndOfStream)
                    {
                        //Lesen einer Textzeile aus der Datei
                        string fzAlsString = sr.ReadLine();
                        //Umwandlung der Textzeile in ein Fahrzeug (Beachte die Übergabe des Settings-Objekts)
                        Fahrzeug fz = JsonConvert.DeserializeObject<Fahrzeug>(fzAlsString, settings);
                        //Hinzufügen des Fahrzeugs zur Liste
                        Fahrzeugliste.Add(fz);
                    }
                }

                MessageBox.Show("Laden erfolgreich");
            }
            catch
            {
                MessageBox.Show("Laden fehlgeschlagen");
            }
        }

        //Click-Event-Methoden der Buttons
        private void BtnNew_Click(object sender, EventArgs e)
        {
            Fahrzeugliste.Add(ErstelleNeuesFz());
            ZeigeFzs();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            LöscheFzs();
            ZeigeFzs();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SpeichereFzs();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            LadeFzs();
            ZeigeFzs();
        }
    }
}
