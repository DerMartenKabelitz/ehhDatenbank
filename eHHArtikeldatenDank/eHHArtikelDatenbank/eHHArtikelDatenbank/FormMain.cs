using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace eHHArtikelDatenbank
{
    public partial class FormMain : Form
    {
        //S:\Artikel.txt
        //S:\Benutzer.txt

        private int prioLevel;
        private string benutzer = Environment.UserName;
        
        //TODO FilePath anpassen
        //private const string BENUTZERFILEPATH = @"C:\Users\Marten Boy\Desktop\Benutzer.txt";
        //private const string ARTIKELDATENFILEPATH = @"C:\Users\Marten Boy\Desktop\Artikel.txt";
        private const string BENUTZERFILEPATH = @"S:\Benutzer.txt";
        private const string ARTIKELDATENFILEPATH = @"S:\Artikel.txt";

        #region Properties
        public List<Artikel> ArtikelListe { get; set; }
        #endregion

        public FormMain()
        {
            prioLevel = GetPrioLevel();            
            if (prioLevel == 1 || prioLevel == 2)
            {
                InitializeComponent();
                MessageBox.Show($"Willkommen {benutzer} !");
                lbl_angemeldeterUser.Text = $"Angemeldeter User: {Environment.UserName}";
                lbl_angemeldeterUser.BackColor = Color.Green;
                button_jaeger.BackColor = Color.Pink;         
                ArtikelListe = LadeArtikelListe(ARTIKELDATENFILEPATH);                
                dataGridView_Artikel.DataSource = ArtikelListe;

                if (prioLevel == 2)
                    dataGridView_Artikel.ReadOnly = true;
            }
            else
            {
                MessageBox.Show($"Der Angemeldete Nutzer: '{benutzer}' besitzt keine Berechtigung für dieses Programm");
            }
            
            
        }
      
        public int GetPrioLevel()
        {
            int priolevel = int.MaxValue;

            using (StreamReader streamReader = new StreamReader(BENUTZERFILEPATH))
            {
                //Skip csvHeader
                streamReader.ReadLine();

                while (!streamReader.EndOfStream)
                {
                    string csvLine = streamReader.ReadLine();
                    //TODO Environment.Username nehmen
                    if (csvLine.ToLower().Contains(Environment.UserName.ToLower()))                  
                    {
                        var csvAttribute = csvLine.Split(';');
                        priolevel = Convert.ToInt32(csvAttribute[1]);
                    }
                }
            }

            return priolevel;
        }

        public List<Artikel> LadeArtikelListe(string path)
        {
            List<Artikel> artikelListe = new List<Artikel>();

            using(StreamReader streamReader = new StreamReader(ARTIKELDATENFILEPATH))
            {
                streamReader.ReadLine();

                while (!streamReader.EndOfStream)
                {
                    var artikelAttribute = streamReader.ReadLine().Split(';');

                    Artikel artikel = new Artikel(artikelAttribute[0], artikelAttribute[1], artikelAttribute[2]);
                    artikelListe.Add(artikel);
                }
            }

            return artikelListe;
        }

        private void AktualisiereCsv()
        {
            //Textdatei leeren
            File.WriteAllText(ARTIKELDATENFILEPATH, String.Empty);

            //Für jeden Artikel neuen Eintrag in csv schreiben
            using (StreamWriter streamWriter = new StreamWriter(ARTIKELDATENFILEPATH))
            {
                foreach(var artikel in ArtikelListe)
                {
                    streamWriter.WriteLine($"{artikel.Artikelnummer};{artikel.Bezeichnung};{artikel.Preis}");
                }
            }
        }

        //TODO Prio abfragen
        private void btn_addArtikel_Click(object sender, EventArgs e)
        {
            if(prioLevel == 1)
            {
                ArtikelListe.Add(new Artikel("", "", ""));
                dataGridView_Artikel.DataSource = null;
                dataGridView_Artikel.DataSource = ArtikelListe;
            }
            else
            {
                MessageBox.Show("Sie besitzen keine Berechtigung für diese Funktionalität");
            }           
        }

        private void btn_saveEdits_Click(object sender, EventArgs e)
        {
            if (prioLevel == 1)
            {
                //Setup list object
                var aktuelleArtikelListe = new List<Artikel>();
                //Loop through datagridview rows
                foreach(DataGridViewRow dgvr in dataGridView_Artikel.Rows)
                {
                    var obj = new Artikel()
                    {
                        Artikelnummer = dgvr.Cells["Artikelnummer"].Value.ToString(),
                        Bezeichnung = dgvr.Cells["Bezeichnung"].Value.ToString(),
                        Preis = dgvr.Cells["Preis"].Value.ToString()
                    };

                    aktuelleArtikelListe.Add(obj);
                }

                ArtikelListe = aktuelleArtikelListe;
                AktualisiereCsv();
            }
            else
            {
                MessageBox.Show("Sie besitzen keine Berechtigung für diese Funktionalität");
            }
        }
    }
}
