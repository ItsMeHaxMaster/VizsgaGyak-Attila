using DataAccess;

namespace Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Auto> autok = Auto.BeolvasCSV("autok.csv");

            // 5. feladat
            System.Console.WriteLine($"5. feladat: {autok.Count} autó található a listában");

            // 6. feladat
            double atlag = autok.Average(a => a.EladottDarabszam);
            System.Console.WriteLine($"6. feladat: Az autók esetében az átlagosan eladott darabszám {atlag:F1}");

            // 7. feladat
            System.Console.WriteLine("7. feladat: Az elmúlt 5 évben gyártott autók:");
            var ujAutok = autok.Where(a => a.GyartasiEv >= 2019);
            foreach (var auto in ujAutok)
            {
                System.Console.WriteLine($"    - {auto.Marka} {auto.Modell}: {auto.GyartasiEv}");
            }

            // 8. feladat
            System.Console.WriteLine("8. feladat: Legsikeresebb márkák listája az eladott darabszám alapján:");
            var markak = autok
                .GroupBy(a => a.Marka)
                .Select(g => new { Marka = g.Key, Darabszam = g.Sum(a => a.EladottDarabszam) })
                .OrderByDescending(m => m.Darabszam);
            foreach (var marka in markak)
            {
                System.Console.WriteLine($"    - {marka.Marka}: {marka.Darabszam} darab");
            }
        }
    }
}
