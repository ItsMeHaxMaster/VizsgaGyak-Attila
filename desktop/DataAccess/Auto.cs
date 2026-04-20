namespace DataAccess
{
    public class Auto
    {
        public int Sorszam { get; set; }
        public string Marka { get; set; }
        public string Modell { get; set; }
        public int GyartasiEv { get; set; }
        public string Szin { get; set; }
        public int EladottDarabszam { get; set; }
        public int AtlagosEladasiAr { get; set; }

        public Auto(string sor)
        {
            string[] reszek = sor.Split(';');
            Sorszam = int.Parse(reszek[0]);
            Marka = reszek[1];
            Modell = reszek[2];
            GyartasiEv = int.Parse(reszek[3]);
            Szin = reszek[4];
            EladottDarabszam = int.Parse(reszek[5]);
            AtlagosEladasiAr = int.Parse(reszek[6]);
        }

        public static List<Auto> BeolvasCSV(string fajlNev)
        {
            List<Auto> autok = new List<Auto>();
            string[] sorok = File.ReadAllLines(fajlNev, System.Text.Encoding.UTF8);
            for (int i = 1; i < sorok.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(sorok[i]))
                    autok.Add(new Auto(sorok[i]));
            }
            return autok;
        }
    }
}
