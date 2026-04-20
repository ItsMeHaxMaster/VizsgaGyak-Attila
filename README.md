# Autók – Vizsga feladat

Asztali alkalmazás fejlesztési vizsga feladat C# nyelven. Az `autok.csv` fájlban tárolt autóeladási adatokat dolgozza fel konzolos és grafikus felületen egyaránt.

---

## Projektstruktúra

```
/
├── desktop/
│   ├── autok.csv              # Forrásfájl (15 autó adata)
│   ├── desktop.slnx           # Solution fájl
│   ├── DataAccess/            # Közös adatmodell (Auto osztály)
│   ├── Console/               # Konzolos alkalmazás (autoapp)
│   └── GUI/                   # Windows Forms alkalmazás (autoform)
└── web/                       # Webes rész (HTML/CSS)
```

---

## Projektek

### DataAccess
Közös osztálykönyvtár. Tartalmazza az `Auto` osztályt, amely:
- Tárolja egy autó adatait (sorszám, márka, modell, gyártási év, szín, eladott darabszám, átlagos eladási ár)
- Konstruktorban CSV-sorból inicializálja magát
- `BeolvasCSV(string fajlNev)` statikus metódussal betölti az egész fájlt

### Console – konzolos alkalmazás
**Projekt:** `autoapp.csproj`

Feldolgozza az `autok.csv` adatait és a következő feladatokat oldja meg:

| Feladat | Leírás |
|---------|--------|
| 5. | Autók számának kiírása |
| 6. | Átlagosan eladott darabszám (1 tizedesjegy) |
| 7. | Az elmúlt 5 évben (2019–) gyártott autók listája |
| 8. | Márkánkénti eladott darabszám, csökkenő sorrendben |

**Futtatás:**
```bash
cd desktop/Console
dotnet run
```

### GUI – grafikus alkalmazás
**Projekt:** `autoform.csproj` · Windows Forms · .NET 9

Reszponzív ablak (alapméret: 1061×764), amely tartalmaz:
- **DataGridView** – a betöltött autók táblázatos megjelenítése
- **Betölt gomb** – `OpenFileDialog` segítségével beolvassa a CSV-t
- **ListBox + TextBox** – gyártási év alapján szűri és listázza az autókat
- **Bezár gomb** – megerősítő párbeszédablak után kilép

**Futtatás:**
```bash
cd desktop/GUI
dotnet run
```

---

## Követelmények

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- Windows (a GUI Windows Forms miatt)
